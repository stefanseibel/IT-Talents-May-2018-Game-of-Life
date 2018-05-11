using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    class UIControl {

        public Grid grid;
        public Form1 form;

        public UIControl(Form1 form, Grid grid) {

            this.grid = grid;
            this.form = form;
        }

        public void NextGeneration() {
            for (int i = 0; i < 1; i++) {
                this.grid.NextGeneration();
                form.grid.PrintField();
            }
            
            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";

            form.Refresh();
        }

        public void ClearGrid() {
            form.CreateGraphics().Clear(Color.White);
            
            for(int i = 0; i < grid.height; i++) {

                for(int j = 0; j < grid.width; j++) {

                    grid.field[i, j] = false;
                }
            }
            
            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";


            form.Refresh();

        }
    }
}
