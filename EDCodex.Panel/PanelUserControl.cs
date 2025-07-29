using EDCodex.Data;
using EDCodex.Data.Enums;
using EDCodex.Data.Models;
using EDCodex.Panel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static EDDDLLInterfaces.EDDDLLIF;

namespace EDCodex.Panel
{
    public partial class PanelUserControl : UserControl, IEDDPanelExtension
    {
        #region Fields.

        private EDDPanelCallbacks PanelCallBack;
        private EDDCallBacks DLLCallBack;
        private readonly Logger _logger;
        private BindingList<CodexEntryView> _filteredEntries = new BindingList<CodexEntryView>();

        private FilterType _currentFilter = FilterType.All;
        private GalacticRegion _selectedRegion = GalacticRegion.TheVoid;
        private CodexEntryType _selectedDiscoveryType = CodexEntryType.Star; // Default to Star

        #endregion

        public PanelUserControl()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;
            _logger = new Logger(textBox_logMsgs);
        }

        #region Properties.

        public BindingList<CodexEntryView> ViewEntries { get; } = new BindingList<CodexEntryView>();

        public IEnumerable<ICodexEntry> AllEntries => GetAllCodexEntries();

        public bool SupportTransparency => true;

        public bool DefaultTransparent => false;

        protected Codex Codex => DbAccessor.Codex;

        #endregion

        #region Initialization methods.

        public void Initialise(EDDPanelCallbacks callbacks, int displayid, string themeasjson, string configuration)
        {
            DLLCallBack = CSharpDLLPanelEDDClass.DLLCallBack;
            this.PanelCallBack = callbacks;
            DLLCallBack.WriteToLogHighlight("Panel DLL Initialised");

            _logger.Debug("New panel initialized.");

            DbAccessor.LoadCodex();
            InitializeDataGridView();
            InitializeRadioButtonFilters();
            PopulateGalacticRegionsCombobox();
            PopulateDiscoveryTypesCombobox();

            _logger.LogMessage("Welcome to EDCodex custom panel.");
        }

        /// <summary>
        /// Loads all regions into the dropdown and sets the current region.
        /// </summary>
        private void PopulateGalacticRegionsCombobox()
        {
            try
            {
                comboBox_currentRegion.Items.Clear();

                foreach (GalacticRegion region in Enum.GetValues(typeof(GalacticRegion)))
                {
                    comboBox_currentRegion.Items.Add(region);

                    _logger.Debug($"Region added to dropdown: {region} ({(int)region})"); // [+msg]
                }

                // If Codex exists and the current region is valid, select it.
                if (Codex != null && Enum.IsDefined(typeof(GalacticRegion), Codex.CurrentRegion))
                {
                    comboBox_currentRegion.SelectedItem = Codex.CurrentRegion;

                    _logger.Debug($"Current galactic region selected: {Codex.CurrentRegion} ({(int)Codex.CurrentRegion})"); // [+msg]
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error populating regions:\r\n{ex.Message}");
            }
        }

        /// <summary>
        /// Loads all discovery types into the dropdown and sets the default selection to the specified type.
        /// </summary>
        /// <param name="defaultType">The discovery type to select by default. Defaults to <see cref="CodexEntryType.Star"/>.</param>
        private void PopulateDiscoveryTypesCombobox(CodexEntryType defaultType = CodexEntryType.Star)
        {
            try
            {
                comboBox_discoveryType.Items.Clear();

                foreach (CodexEntryType entryType in Enum.GetValues(typeof(CodexEntryType)))
                {
                    comboBox_discoveryType.Items.Add(entryType);

                    _logger.Debug($"Discovery type added to dropdown: {entryType}");
                }

                if (comboBox_discoveryType.Items.Contains(defaultType))
                {
                    comboBox_discoveryType.SelectedItem = defaultType;

                    _logger.Debug($"Default discovery type selected: {defaultType}");
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error populating discovery types:\r\n{ex.Message}");
            }
        }

        private void InitializeRadioButtonFilters()
        {
            radioButton_filterAll.Checked = true; // Default.

            // Shared event handler for filter radio buttons.
            radioButton_filterAll.CheckedChanged += FilterChanged;
            radioButton_filterExisting.CheckedChanged += FilterChanged;
            radioButton_filterNotFound.CheckedChanged += FilterChanged;
        }

        private void InitializeDataGridView()
        {
            ConfigureDataGridView();
            AddDataGridViewColumns();

            // Bind data.
            dataGridView_codexEntries.DataSource = _filteredEntries;

            // Apply header styles.
            foreach (DataGridViewColumn column in dataGridView_codexEntries.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Arial", 10, FontStyle.Regular);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView_codexEntries.AutoGenerateColumns = false;
            dataGridView_codexEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_codexEntries.AllowUserToAddRows = false;
            dataGridView_codexEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_codexEntries.MultiSelect = false;
        }

        private void AddDataGridViewColumns()
        {
            dataGridView_codexEntries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CodexEntryView.Description),
                HeaderText = "Description",
                ReadOnly = true
            });

            var comboColumn = new DataGridViewComboBoxColumn
            {
                DataPropertyName = nameof(CodexEntryView.Status),
                HeaderText = "Status",
                ValueType = typeof(CodexEntryStatus),
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                DataSource = Enum.GetValues(typeof(CodexEntryStatus)),
            };

            dataGridView_codexEntries.Columns.Add(comboColumn);
        }

        #endregion

        #region Not important methods.

        public bool AllowClose() => true;

        public void DataResult(string data)
        {
            _logger.Debug($"System Responded:\r\n{data}");
        }

        public void Closing()
        {
            _logger.Debug($"Close panel {PanelCallBack.IsClosed()}");            
        }

        public void ControlTextVisibleChange(bool on)
        {
        }

        public string HelpKeyOrAddress()
        {
            return @"http:\\news.bbc.co.uk";
        }

        public void HistoryChange(int count, string commander, bool beta, bool legacy)
        {
        }

        public void InitialDisplay()
        {
        }        

        public void LoadLayout()
        {
        }

        public void NewFilteredJournal(JournalEntry je)
        {
        }

        public void NewTarget(Tuple<string, double, double, double> target)
        {
        }

        public void NewUIEvent(string jsonui)
        {
        }

        public void NewUnfilteredJournal(JournalEntry je)
        {
        }

        public void ScreenShotCaptured(string file, Size s)
        {
        }

        public void SetTransparency(bool ison, Color curcol)
        {
        }

        public void ThemeChanged(string themeasjson)
        {
        }

        public void TransparencyModeChanged(bool on)
        {
        }

        void IEDDPanelExtension.CursorChanged(JournalEntry je)
        {            
            _logger.Debug($"Cursor changed to {je.name}");            
        }

        #endregion

        #region Event handlers.

        private void comboBox_currentRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_currentRegion.SelectedItem is GalacticRegion selectedRegion)
                {
                    if (Codex != null)
                    {
                        _selectedRegion = (GalacticRegion)comboBox_currentRegion.SelectedItem;
                        Codex.CurrentRegion = selectedRegion;
                        DbAccessor.SaveCodex();

                        _logger.Debug($"Current galactic region changed to: {selectedRegion}"); // [+msg]

                        ApplyCombinedFilter();
                    }
                    else
                    {
                        _logger.Debug("Codex is not initialized.");
                        MessageBox.Show(
                            "Codex is not initialized. Please ensure the codex file is present on disk.", 
                            "Error", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _logger.Debug("Selected item is not a valid GalacticRegion.");
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error selecting region:\r\n{ex.Message}");
                MessageBox.Show(
                    "An error occurred while selecting the galactic region.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                
                return;
            }
        }

        private void comboBox_discoveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = comboBox_discoveryType.SelectedItem;
                if (selected is CodexEntryType entryType)
                {
                    _logger.Debug($"Discovery type changed to: {entryType}");
                    _selectedDiscoveryType = entryType;
                    ApplyCombinedFilter();
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error selecting discovery type:\r\n{ex.Message}");
                MessageBox.Show("An error occurred while selecting the discovery type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        /// <summary>
        /// Gets all codex entries across every category as a single combined sequence.
        /// </summary>
        private IEnumerable<ICodexEntry> GetAllCodexEntries()
        {
            return Codex.Stars.Cast<ICodexEntry>()
                .Concat(Codex.GasGiantPlanets)
                .Concat(Codex.TerrestrialPlanets)
                .Concat(Codex.GeoFeatures)
                .Concat(Codex.BioFeatures)
                .Concat(Codex.SpaceFeatures)
                .Concat(Codex.SpaceBioFeatures)
                .Concat(Codex.ThargoidObjects)
                .Concat(Codex.GuardianObjects);
        }

        /// <summary>
        /// Updates the filter type when a radio button is selected and applies the filter.
        /// </summary>
        private void FilterChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = (RadioButton)sender;

            if (!selectedRadioButton.Checked)
            {
                return;
            }

            if (selectedRadioButton == radioButton_filterAll)
            {
                _logger.Debug("Discovery filter selected: All");
                _currentFilter = FilterType.All;
            }
            else if (selectedRadioButton == radioButton_filterExisting)
            {
                _logger.Debug("Discovery filter selected: Existing");
                _currentFilter = FilterType.Existing;
            }
            else if (selectedRadioButton == radioButton_filterNotFound)
            {
                _logger.Debug("Discovery filter selected: Not Found");
                _currentFilter = FilterType.NotFound;
            }
            else
            {
                _logger.Debug("Unknown filter option selected.");
            }

            ApplyCombinedFilter();
        }

        /// <summary>
        /// Applies the selected filters and updates the codex entries in the table accordingly.
        /// </summary>
        private void ApplyCombinedFilter()
        {            
            _filteredEntries.Clear();

            foreach (var entry in AllEntries)
            {
                if (entry.Type != _selectedDiscoveryType)
                {
                    continue;
                }

                var status = GetStatusForCurrentRegion(entry);

                if (!IsMatchingCurrentFilter(status))
                {
                    continue;
                }

                _filteredEntries.Add(new CodexEntryView
                {
                    Description = entry.Description,
                    Status = status,
                });
            }

            _logger.Debug($"{_filteredEntries.Count} {_selectedDiscoveryType} entries loaded for {_selectedRegion} region."); // [+msg]
        }

        /// <summary>
        /// Determines whether the given status matches the currently selected filter.
        /// </summary>
        /// <param name="status">The codex entry status to evaluate.</param>
        /// <returns><c>true</c> if the status matches the current filter; otherwise, <c>false</c>.</returns>
        private bool IsMatchingCurrentFilter(CodexEntryStatus status)
        {
            switch (_currentFilter)
            {
                case FilterType.All:
                    return true;
                case FilterType.Existing:
                    return status == CodexEntryStatus.Exists || status == CodexEntryStatus.Found;
                case FilterType.NotFound:
                    return status == CodexEntryStatus.Exists;
                default:
                    return false; // Should not reach here.
            }
        }

        /// <summary>
        /// Returns the status of the specified codex entry for the current galactic region.
        /// If no status is found, returns <see cref="CodexEntryStatus.Undefined"/>.
        /// </summary>
        /// <param name="entry">The codex entry to retrieve the status for.</param>
        private CodexEntryStatus GetStatusForCurrentRegion(ICodexEntry entry)
        {
            return entry.StatusByGalacticRegion.TryGetValue(Codex.CurrentRegion, out var status)
                ? status
                : CodexEntryStatus.Undefined;
        }
    }
}
