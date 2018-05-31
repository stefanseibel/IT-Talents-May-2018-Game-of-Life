using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLife {
    public class GridDrawing {
        
        ///ATTRIBUTES:

        /// x and y coordinates where on the area the grid should start
        int x;
        int y;

        ///Graphics on which should be drawn
        public Graphics g;

        ///available width and height for the Grid
        public int width;
        public int height;

        ///field which will be drawn
        public bool[,] field;

        ///Width of a Cell in px
        public int widthPerCell;

        /// Pens for Drawing the Grid
        /// blackPen.Width = thickness of the Border
        public Pen blackPen = new Pen(Color.Black);
        private Pen pinkPen = new Pen(Color.Pink);

        //CONSTRUCTOR: Default Constructor without Arguments

        //METHODS:

        //sets the maximum bounds of the Grid
        public void SetSize(int x, int y, int width, int height) {

            //save x, y, width and height parameters as attributes
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }

        //Changes the field that will be drawn and updates the graphics
        public void changeDrawing(bool[,] field, Graphics g) {

            //save field and Graphics parameters as attributes
            this.field = field;
            this.g = g;

            //Calculates the maximum Possible Width of a Cell (in px) that fits within the Bounds without overflow
            widthPerCell = RecommendedWidth();

            //sets the Width of the line between Cells
            //Width of the line is 1/25 of the Cellwidth but needs to be Divisible by two (see DrawGrid() below)
            // widthPerCell / 50 * 2 makes it divisible by two due to how integers are rounded
            blackPen.Width = (int)widthPerCell / 50 * 2;

            //Limits the Width of the lines to the border on the Edge so the everything fits on the Screen
            if(blackPen.Width > x) {
                blackPen.Width = x;
            }

            //subtracts the width of the line between Cells from their width
            widthPerCell -= (int) blackPen.Width;

        }

        //Draws the Grid on the GUI
        public void DrawGrid() {

            //half of the Width of the lines between Cells
            //blackPen.Width is always divisible by 2 because of how it was set in changeDrawing
            int halfWidth = (int)blackPen.Width / 2;
            
            //iterates through every Cell
            for (int i = 0; i < field.GetLength(0); i++) {

                for (int j = 0; j < field.GetLength(1); j++) {

                    //creates a rectangle at its Coordinates and widthPerCell as the size
                    Rectangle rect = new Rectangle(x + j * widthPerCell + (int)blackPen.Width * j, y + i * widthPerCell + (int)blackPen.Width * i, widthPerCell, widthPerCell);

                    //fills the rectangle pink if the cell is alive
                    if (field[i, j]) {
                        
                        g.FillRectangle(new SolidBrush(pinkPen.Color), rect);
                    }

                    //creates a rectangle for the border which is blackPen.Width wider in total (half of that on each side) around rect
                    Rectangle border = new Rectangle(rect.X - halfWidth, rect.Y - halfWidth, rect.Width + (int)blackPen.Width, rect.Height + (int)blackPen.Width);
                    
                    //draws the border-rectangle on the graphics
                    g.DrawRectangle(blackPen, border);

                    
                }
            }
        }

        //calculates the maximum possible Width of a cell so that it fits on the tab
        private int RecommendedWidth() {

            //calculates the maximum possible width and height of the grid
            int heightPerCell = height / field.GetLength(0);
            int widthPerCell = width / field.GetLength(1);

            //returns the smaller Value of the two
            return heightPerCell < widthPerCell ? heightPerCell : widthPerCell;
            
        }
    }
}
