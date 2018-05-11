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
        public Grid grid;
        public float widthPerCell;

        Pen pinkPen = new Pen(Color.Pink);

        Pen blackPen = new Pen(Color.Black);
        

        public GridDrawing(Grid grid, Graphics g, int x, int y, int width, int height) {
            this.grid = grid;
            this.g = g;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            widthPerCell = RecommendedWidth();

            blackPen.Width = (int)widthPerCell / 50 * 2;
        }

        public void DrawGrid() {

            int halfWidth = (int)blackPen.Width / 2;

            int finalWidthPerCell = (int) widthPerCell;

            
            for (int i = 0; i < grid.height; i++) {

                for (int j = 0; j < grid.width; j++) {

                    Rectangle rect = new Rectangle(x + j * finalWidthPerCell + (int)blackPen.Width * j, y + i * finalWidthPerCell + (int)blackPen.Width * i, finalWidthPerCell, finalWidthPerCell);

                    if (grid.field[i, j]) {
                        
                        g.DrawRectangle(pinkPen, rect);
                        g.FillRectangle(new SolidBrush(pinkPen.Color), rect);
                    }

                    Rectangle border = new Rectangle(rect.X - halfWidth, rect.Y - halfWidth, rect.Width + (int)blackPen.Width, rect.Height + (int)blackPen.Width);
                    g.DrawRectangle(blackPen, border);

                    
                }
            }
        }


        private float RecommendedWidth() {

            float heightPerCell = (float) height / (float) grid.height;
            float widthPerCell = (float) width / (float) grid.width;

            if (heightPerCell < widthPerCell) {
                this.width = (int) heightPerCell * grid.width;
                return heightPerCell;
            } else {

                this.height = (int) widthPerCell * grid.height;
                return widthPerCell;
            }
        }
    }
}
