﻿using System;

using ED_Codex.Enums;
using ED_Codex.Menu;

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
