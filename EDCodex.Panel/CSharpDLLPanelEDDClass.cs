using EDCodex.Panel.Properties;
using EDDDLLInterfaces;
using System.Diagnostics;

namespace EDCodex.Panel
{
    public class CSharpDLLPanelEDDClass
    {
        private const string PannelName = "EDCodex";
        private const string Description = "The description of the pannel goes here.";
        private const string UniqueName = "72795097-5f7a-458a-ab28-1d482f8d029c";
        public static EDDDLLIF.EDDCallBacks DLLCallBack;

        public CSharpDLLPanelEDDClass()
        {
            Debug.WriteLine("DLLPanel Made DLL instance");
        }

        public string EDDInitialise(string vstr, string dllfolder, EDDDLLIF.EDDCallBacks callBacks)
        {
            DLLCallBack = callBacks;
            if (callBacks.ver >= 3 && callBacks.AddPanel != null)
            {
                string uniquename = UniqueName;
                callBacks.AddPanel(
                    uniquename,
                    typeof(PanelUserControl),
                    PannelName,
                    uniquename,
                    Description,
                    Resources.CaptainsLog); 
            }

            return "1.0.0.0";
        }

        public void EDDTerminate()
        {
            Debug.WriteLine("DLLPanel Unload");
        }

        public void EDDDataResult(object requesttag, object usertag, string data)
        {

        }
    }
}
