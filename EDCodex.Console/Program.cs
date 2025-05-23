using System;

using ED_Codex.Menu;
using EDCodex.Data;

namespace ED_Codex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            DbAccessor.LoadCodex();

            var mainMenu = new MainMenu();
            MenuRunner.RunMenu(mainMenu);
        }
    }
}
