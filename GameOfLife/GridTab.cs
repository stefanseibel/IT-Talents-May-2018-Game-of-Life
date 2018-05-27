using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife {
    public class GridTab : TabPage{


        public Grid grid;
        public Form1 form;
        public GridDrawing gd;

        public int fieldIndex;

        public int border;

        public GridTab(Form1 form, Grid grid, int border, string tabName) : base(tabName) {

            this.grid = grid;
            this.form = form;
            this.fieldIndex = 0;
            this.border = border;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.gd = new GridDrawing();
        }

        public void NextGeneration() {
            for (int i = 0; i < 1; i++) {
                this.grid.NextGeneration();
            }

            this.fieldIndex++;

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
            grid.allGens.RemoveRange(0, grid.allGens.Count - 1);
            fieldIndex = 0;
            form.Invalidate();

        }


        public void SetCell(int x, int y) {

            
            int totalWidth = grid.width * gd.widthPerCell + (grid.width) * (int)gd.blackPen.Width;
            int totalHeight = grid.height * gd.widthPerCell + (grid.height) * (int)gd.blackPen.Width;

            if (border < x && x < (border + totalWidth) && border < y && y < (border + totalHeight)) {
                
                if (!form.checkBoxLockField.Checked) {



                    //TODO: Use gridDrawing.widthPerCell
                    int totalWidthPerCell = totalWidth / grid.width;
                    int totalHeightPerCell = totalWidth / grid.height;

                    int posX = (x - border) / totalWidthPerCell;
                    int posY = (y - border) / totalWidthPerCell;

                    grid.allGens[fieldIndex][posY, posX] = !grid.allGens[fieldIndex][posY, posX];

                    

                    grid.allGens = new List<bool[,]> {
                        grid.allGens[fieldIndex]
                    };
                    
                    grid.field = grid.allGens[0];
                    grid.generation = 1;
                    this.fieldIndex = 0;

                    grid.PrintField(grid.allGens[fieldIndex]);
                    this.Invalidate();

                }
            }
        }

        public void NewGrid(int width, int height) {

            Graphics g = this.CreateGraphics();

            g.Clear(Color.White);
            
            this.grid = new Grid(width, height);
            this.fieldIndex = 0;


            gd.ChangeSize(border, border, this.Width - this.border * 3, this.Height - this.border * 3);
            gd.changeDrawing(grid.field, g);
            
            this.Invalidate();
        }
    }
}
