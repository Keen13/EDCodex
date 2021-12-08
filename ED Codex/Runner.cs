using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Codex
{
    public static class Runner
    {
        public static void RunMenu(IMenu menu)
        {
            bool conitnue = true;
            while (conitnue)
            {
                conitnue = menu.ShowAndRun();
            }
        }
    }
}
