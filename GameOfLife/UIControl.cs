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
            }

            

            form.Invalidate();
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

            form.Invalidate();

        }

        
        public void SetCell(int x, int y) {

            int totalWidth = grid.width * form.gd.widthPerCell + (grid.width) * (int)form.gd.blackPen.Width;
            int totalHeight = grid.height * form.gd.widthPerCell + (grid.height) * (int)form.gd.blackPen.Width;

            if (form.gridX < x && x < (form.gridX + totalWidth) && form.gridY < y && y < (form.gridY + totalHeight)) {

                if (!form.checkBoxLockField.Checked) {

                    
                    int totalWidthPerCell = totalWidth / grid.width;
                    int totalHeightPerCell = totalWidth / grid.height;

                    int posX = (x - form.gridX) / totalWidthPerCell;
                    int posY = (y - form.gridY) / totalWidthPerCell;
                    
                    grid.field[posY, posX] = !grid.field[posY, posX];
                    
                    grid.oldGens.Clear();
                    grid.generation = 1;

                    form.Invalidate();
                    
                }
            }
        }

        public void NewGrid(int width, int height) {
            
            form.CreateGraphics().Clear(Color.White);

            //Bad Code, only temporary
            this.grid = new Grid(width, height);
            form.grid = grid;
            form.gd.grid = grid.field;

            form.labelGeneration.Text = grid.generation.ToString() + ". Generation";


            form.Invalidate();
        }
    }
}
