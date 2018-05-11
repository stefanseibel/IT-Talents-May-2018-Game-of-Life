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

            for (int i = 0; i < grid.height; i++) {

                for (int j = 0; j < grid.width; j++) {

                    grid.field[i, j] = false;
                }
            }

            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";


            form.Refresh();

        }

        public void SetCell(int x, int y) {
            if (form.gridX < x && x < (form.gridX + form.gridWidth) && form.gridY < y && y < (form.gridY + form.gridHeight)) {

                if (!form.checkBoxLockField.Checked) {
                    float posX = ((float) x - form.gridX) / form.gd.widthPerCell;
                    float posY = ((float) y - form.gridY) / form.gd.widthPerCell;


                    grid.field[(int)posY, (int)posX] = !grid.field[(int)posY, (int)posX];



                    form.Refresh();

                    grid.oldGens.Clear();
                    grid.generation = 1;
                    form.labelGeneration.Text = grid.generation.ToString() + ". Generation";
                }
            }
        }

        public void NewGrid(int width, int height) {
            
            form.CreateGraphics().Clear(Color.White);

            //Bad Code, only temporary
            this.grid = new Grid(width, height);
            form.grid = grid;
            form.gd.grid = grid;

            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";


            form.Refresh();
        }
    }
}
