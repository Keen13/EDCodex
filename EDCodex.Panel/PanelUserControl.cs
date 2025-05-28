using System;
using System.Drawing;
using System.Windows.Forms;
using static EDDDLLInterfaces.EDDDLLIF;

namespace EDCodex.Panel
{
    public partial class PanelUserControl : UserControl, IEDDPanelExtension
    {
        private EDDPanelCallbacks PanelCallBack;
        private EDDCallBacks DLLCallBack;

        public PanelUserControl()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Inherit;
        }

        public bool SupportTransparency => true;

        public bool DefaultTransparent => false;

        public bool AllowClose() => true;

        public void DataResult(string data)
        {
            richTextBox1.AppendText($"System Responded:\r\n{data}\r\n");
            richTextBox1.ScrollToCaret();
        }

        public void Closing()
        {
            richTextBox1.AppendText($"Close panel {PanelCallBack.IsClosed()}\r\n");            
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
            richTextBox1.AppendText("Welcome to EDCodex custom panel.\r\n");
        }

        public void Initialise(EDDPanelCallbacks callbacks, int displayid, string themeasjson, string configuration)
        {
            DLLCallBack = CSharpDLLPanelEDDClass.DLLCallBack;
            this.PanelCallBack = callbacks;

            richTextBox1.AppendText("New Panel init\r\n");
            DLLCallBack.WriteToLogHighlight("Demo DLL Initialised");
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
            richTextBox1.AppendText($"Cursor changed to {je.name}\r\n");
        }
    }
}
