using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    class GridDrawing {

        int x;
        int y;
        Graphics g;
        int width;
        int height;
        Grid grid;
        public float widthPerCell;

        public Pen blackPen;

        public GridDrawing(Grid grid, Graphics g, int x, int y, int width, int height) {
            this.grid = grid;
            this.g = g;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            widthPerCell = height / grid.height;
        }

        public void DrawGrid() {

            Pen pinkPen = new Pen(Color.Pink);

            int xCells = grid.width;
            int yCells = grid.height;

            RectangleF[] rectangles = new RectangleF[xCells * yCells];

            for (int i = 0; i < yCells; i++) {

                for (int j = 0; j < xCells; j++) {

                    if (grid.field[i, j]) {

                        RectangleF rectangle = new RectangleF(x + j * widthPerCell, y + i * widthPerCell, widthPerCell, widthPerCell);
                        rectangles[i * yCells + j] = rectangle;
                    }
                }
            }
            
            g.FillRectangles(new SolidBrush(pinkPen.Color), rectangles);

        }

        public void drawBorders() {

            blackPen = new Pen(Color.Black);
            blackPen.Width = widthPerCell / 25;

            for(int i = 0; i < grid.height + 1; i++) {
                g.DrawLine(blackPen, 0, i * widthPerCell, width, i * widthPerCell);
            }

            for (int i = 0; i < grid.width + 1; i++) {
                g.DrawLine(blackPen, i * widthPerCell, 0, i * widthPerCell, height);
            }
        }
    }
}
