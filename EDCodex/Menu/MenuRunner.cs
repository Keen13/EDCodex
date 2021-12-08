namespace ED_Codex.Menu
{
    public static class MenuRunner
    {
        public static void RunMenu(IMenu menu, string autoRunOptionKey = null)
        {
            var toContinue = true;
            while (toContinue)
            {
                toContinue = menu.ShowAndRun(autoRunOptionKey);
            }
        }
    }
}
