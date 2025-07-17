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
        private EDDPanelCallbacks PanelCallBack;
        private EDDCallBacks DLLCallBack;
        private readonly Logger _logger;

        public PanelUserControl()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;
            _logger = new Logger(textBox_logMsgs);

            InitializeDataGridView();            
        }

        public BindingList<CodexEntryView> ViewEntries { get; } = new BindingList<CodexEntryView>();

        public bool SupportTransparency => true;

        public bool DefaultTransparent => false;

        public CodexEntryType SelectedDiscoveryType { get; private set; } = CodexEntryType.Star; // Default to Star

        protected Codex Codex => DbAccessor.Codex;

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

        public void Initialise(EDDPanelCallbacks callbacks, int displayid, string themeasjson, string configuration)
        {
            DLLCallBack = CSharpDLLPanelEDDClass.DLLCallBack;
            this.PanelCallBack = callbacks;
            DLLCallBack.WriteToLogHighlight("Panel DLL Initialised");
                        
            _logger.Debug("New panel initialized.");
            
            DbAccessor.LoadCodex();
            PopulateGalacticRegionsCombobox();
            PopulateDiscoveryTypesCombobox();

            _logger.LogMessage("Welcome to EDCodex custom panel.");
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

        private void comboBox_currentRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_currentRegion.SelectedItem is GalacticRegion selectedRegion)
                {
                    if (Codex != null)
                    {
                        Codex.CurrentRegion = selectedRegion;
                        DbAccessor.SaveCodex();
                        
                        _logger.Debug($"Current galactic region changed to: {selectedRegion}"); // [+msg]

                        var codexEntries = GetEntriesForSelectedType(SelectedDiscoveryType);
                        DisplayEntriesByRegion(codexEntries, Codex.CurrentRegion);
                    }
                    else
                    {
                        _logger.LogMessage("Codex is null. Cannot update region.");
                    }
                }
                else
                {                    
                    _logger.Debug("Selected item is not a valid GalacticRegion.");
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error changing selected region:\r\n{ex.Message}");
            }
        }

        /// <summary>
        /// Displays entries of a specified type for a given galactic region in the UI list.
        /// </summary>
        /// <typeparam name="T">The type of codex entries to display. Must implement ICodexEntry.</typeparam>
        /// <param name="codexEntries">A collection of codex entries to show.</param>
        /// <param name="galacticRegion">The galactic region to filter the entries by.</param>
        private void DisplayEntriesByRegion<T>(IEnumerable<T> codexEntries, GalacticRegion galacticRegion)
            where T : ICodexEntry
        {
            if (dataGridView_codexEntries == null)
            {
                _logger.Debug("Data view is not initialized.");

                return;
            }

            if (codexEntries == null || !codexEntries.Any())
            {
                _logger.LogMessage("No entries available for the selected region.");
                return;
            }

            ViewEntries.Clear();

            foreach (var entry in codexEntries)
            {
                if (entry.StatusByGalacticRegion == null)
                {
                    _logger.LogMessage($"No status information is available for the entry {entry.Description}.");
                    continue;
                }

                var statusEnum = entry.StatusByGalacticRegion.TryGetValue(galacticRegion, out var status)
                    ? status
                    : CodexEntryStatus.Undefined;

                ViewEntries.Add(new CodexEntryView
                {
                    Description = entry.Description,
                    Status = statusEnum,
                });
            }

            _logger.Debug($"{ViewEntries.Count} {SelectedDiscoveryType} entries loaded for {galacticRegion} region."); // [+msg]
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

        private void comboBox_discoveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = comboBox_discoveryType.SelectedItem;
                if (selected is CodexEntryType entryType)
                {
                    SelectedDiscoveryType = entryType;
                    
                    _logger.Debug($"Discovery type changed to: {entryType}");

                    var codexEntries = GetEntriesForSelectedType(SelectedDiscoveryType);
                    DisplayEntriesByRegion(codexEntries, Codex.CurrentRegion);
                }
                else
                {
                    _logger.LogMessage("Selected item is not a valid discovery type or is null.");
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error changing selected discovery type:\r\n{ex.Message}");
            }
        }

        private IEnumerable<ICodexEntry> GetEntriesForSelectedType(CodexEntryType entryType)
        {
            switch (entryType)
            {
                case CodexEntryType.Star:
                    return Codex.Stars;
                case CodexEntryType.GasGiantPlanet:
                    return Codex.GasGiantPlanets;
                case CodexEntryType.TerrestrialPlanet:
                    return Codex.TerrestrialPlanets;
                case CodexEntryType.Geo:
                    return Codex.GeoFeatures;
                case CodexEntryType.Bio:
                    return Codex.BioFeatures;
                case CodexEntryType.Space:
                    return Codex.SpaceFeatures;
                case CodexEntryType.SpaceBio:
                    return Codex.SpaceBioFeatures;
                case CodexEntryType.Thargiod:
                    return Codex.ThargoidObjects;
                case CodexEntryType.Guardian:
                    return Codex.GuardianObjects;
                default:
                    throw new NotImplementedException($"Unsupported discovery type: {SelectedDiscoveryType}");
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView_codexEntries.AutoGenerateColumns = false;
            dataGridView_codexEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_codexEntries.AllowUserToAddRows = false;

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
                //DataSource = Enum.GetValues(typeof(CodexEntryStatus))
                //    .Cast<CodexEntryStatus>()
                //    .Where(s => s != CodexEntryStatus.Undefined)
                //    .ToArray()
            };

            dataGridView_codexEntries.Columns.Add(comboColumn);

            dataGridView_codexEntries.DataSource = ViewEntries;
        }
    }
}
