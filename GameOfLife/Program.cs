using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace GameOfLife {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            return;

            Grid grid = new Grid(5, 5) {
                field = new bool[,] {
                {false, false, false, false, false},
                {false, false, false, false, false},
                {false, true , true , false, false},
                {false, true , true , false, false},
                {false, false, false, false, false},

                }
            };
            
            grid.NextGeneration();
            grid.PrintField();

            for (int i = 0; i < 0; i++) {
                grid.NextGeneration();
                grid.PrintField();
            }

        }
    }
}
