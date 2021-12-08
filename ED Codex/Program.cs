using System;

using ED_Codex.Enums;

namespace ED_Codex
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAccessor.LoadCodex();

            var mainMenu = new MainMenu();
            Runner.RunMenu(mainMenu);
        }
    }
}
