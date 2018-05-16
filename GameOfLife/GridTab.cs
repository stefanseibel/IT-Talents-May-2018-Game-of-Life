using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife {
    class GridTab : TabPage{


        public Grid grid;
        public Form1 form;

        public bool[,] field;

        public int border;

        public GridTab(Form1 form, Grid grid, int border) {

            this.grid = grid;
            this.form = form;
            this.field = grid.field;
            this.border = border;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void NextGeneration() {
            for (int i = 0; i < 1; i++) {
                this.grid.NextGeneration();
            }
            
            this.field = this.grid.field;

            this.Invalidate();
        }

        public void ClearGrid() {
            form.CreateGraphics().Clear(Color.White);

            for (int i = 0; i < grid.height; i++) {

                for (int j = 0; j < grid.width; j++) {

                    grid.field[i, j] = false;
                }
            }

            grid.generation = 1;
            grid.oldGens.Clear();
            field = grid.field;
            form.Invalidate();

        }


        public void SetCell(int x, int y) {

            int totalWidth = grid.width * form.gd.widthPerCell + (grid.width) * (int)form.gd.blackPen.Width;
            int totalHeight = grid.height * form.gd.widthPerCell + (grid.height) * (int)form.gd.blackPen.Width;

            if (border < x && x < (border + totalWidth) && border < y && y < (border + totalHeight)) {

                if (!form.checkBoxLockField.Checked) {


                    int totalWidthPerCell = totalWidth / grid.width;
                    int totalHeightPerCell = totalWidth / grid.height;

                    int posX = (x - border) / totalWidthPerCell;
                    int posY = (y - border) / totalWidthPerCell;

                    field[posY, posX] = !grid.field[posY, posX];

                    grid.oldGens.Clear();
                    grid.generation = 1;

                    this.Invalidate();

                }
            }
        }

        public void NewGrid(int width, int height) {

            this.CreateGraphics().Clear(Color.White);
            
            this.grid = new Grid(width, height);
            this.field = grid.field;
            form.gd.grid = grid.field;

            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";


            this.Invalidate();
        }
    }
}
