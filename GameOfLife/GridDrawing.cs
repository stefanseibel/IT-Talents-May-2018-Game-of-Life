using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    public class GridDrawing {

        int x;
        int y;
        public Graphics g;
        public int width;
        public int height;
        public bool[,] grid;
        public int widthPerCell;

        Pen pinkPen = new Pen(Color.Pink);

        public Pen blackPen = new Pen(Color.Black);
        

        public void changeDrawing(bool[,] grid, Graphics g) { 
            this.grid = grid;
            this.g = g;


            widthPerCell = RecommendedWidth();

            blackPen.Width = (int)widthPerCell / 50 * 2;

        }

        public void ChangeSize(int x, int y, int width, int height) {
            
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }

        public void DrawGrid() {

            int halfWidth = (int)blackPen.Width / 2;

            int finalWidthPerCell = (int) widthPerCell;

            
            for (int i = 0; i < grid.GetLength(0); i++) {

                for (int j = 0; j < grid.GetLength(1); j++) {

                    Rectangle rect = new Rectangle(x + j * finalWidthPerCell + (int)blackPen.Width * j, y + i * finalWidthPerCell + (int)blackPen.Width * i, finalWidthPerCell, finalWidthPerCell);

                    if (grid[i, j]) {
                        
                        g.FillRectangle(new SolidBrush(pinkPen.Color), rect);
                    }

                    Rectangle border = new Rectangle(rect.X - halfWidth, rect.Y - halfWidth, rect.Width + (int)blackPen.Width, rect.Height + (int)blackPen.Width);
                    g.DrawRectangle(blackPen, border);

                    
                }
            }
        }


        private int RecommendedWidth() {

            int heightPerCell = height / grid.GetLength(0);
            int widthPerCell = width / grid.GetLength(1);

            if (heightPerCell < widthPerCell) {
                this.width = heightPerCell * grid.GetLength(1);
                return heightPerCell;
            } else {

                this.height = widthPerCell * grid.GetLength(0);
                return widthPerCell;
            }
        }
    }
}
