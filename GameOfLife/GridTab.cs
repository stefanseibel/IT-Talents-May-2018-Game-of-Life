using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife {
    ///GridTab inherits from System.Windows.Forms.TabPage
    ///so that it can be displayed as a tab in TabControl
    ///but holds further information about the Grid which is displayed in the Tab
    public class GridTab : TabPage{

        ///ATTRIBUTES:

        ///Grid which is shown in the tab
        public Grid grid;

        ///The Form of the Program
        public Form1 form;

        ///GridDrawing Object which is responsible for drawing the Graphics
        public GridDrawing gd;

        ///saves which Generation of the Grid is currently selected
        ///grid.allGens[fieldIndex] points to the selected field
        public int fieldIndex = 0;

        ///sets the border between the grid and the edge of the tab (in px)
        public int border;

        ///CONSTRUCTOR:
        ///Makes a new Gridtab and calls the TabPage Constructor with the TabName
        public GridTab(Form1 form, Grid grid, int border, string tabName) : base(tabName) {

            ///Sets attributes to the respective Parameters
            this.grid = grid;
            this.form = form;
            this.border = border;

            ///Creates a new GridDrawing whose task it is to draw the Grid
            this.gd = new GridDrawing();

            ///Enables DoubleBuffering to prevent Flickering of the Drawing
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            
        }

        ///generates a new Generation and updates the Form
        public void NextGeneration() {
            
            ///generates a new Generation on the Grid
            this.grid.NextGeneration();
            
            ///sets the fieldIndex to the newest Generation
            this.fieldIndex = this.grid.allGens.Count - 1;

            ///refreshes the Drawing
            this.Invalidate();
        }

        ///Clears the Grid
        public void ClearGrid() {

            ///Clears the Drawing
            form.CreateGraphics().Clear(Color.White);

            ///Sets every Cell to false/dead
            for (int i = 0; i < grid.height; i++) {

                for (int j = 0; j < grid.width; j++) {

                    grid.field[i, j] = false;
                }
            }

            ///resets grid.generation and clears grid.allGens except for the latest Generation
            grid.generation = 1;
            grid.allGens.RemoveRange(0, grid.allGens.Count - 1);

            ///sets fieldIndex to 0 as it is the only remaining Geneation
            fieldIndex = 0;

            ///refreshes the Drawing
            this.Invalidate();

        }

        ///Sets a Cell at given pixel-Coordinates (after Mouseclick)
        public void SetCell(int x, int y) {

            ///calculates the actual Width and Height inclunding the borders between Cells
            int totalWidth = grid.width * gd.widthPerCell + (grid.width) * (int)gd.blackPen.Width;
            int totalHeight = grid.height * gd.widthPerCell + (grid.height) * (int)gd.blackPen.Width;

            ///checks if the Mouseclick is within the Bounds of the drawn Grid
            if (border < x && x < (border + totalWidth) && border < y && y < (border + totalHeight)) {

                ///calculates the width per Cell
                int totalWidthPerCell = totalWidth / grid.width;
                
                ///Calculates the Position on the Grid (not Drawing/ not px !)
                int posX = (x - border) / totalWidthPerCell;
                int posY = (y - border) / totalWidthPerCell;

                ///invertes the currently shown field on the Position where it was clicked
                grid.allGens[fieldIndex][posY, posX] = !grid.allGens[fieldIndex][posY, posX];

                ///resets grid.allGens so that it only contains the currently shown generation
                grid.allGens = new List<bool[,]> {
                    grid.allGens[fieldIndex]
                };
                
                ///updates/resets the other related Attributes
                grid.field = grid.allGens[0];
                grid.generation = 1;
                this.fieldIndex = 0;
                    
                ///refreshes the Drawing
                this.Invalidate();
                
            }
        }

        ///makes a new Grid with width*height Cells
        public void NewGrid(int width, int height) {

            ///Creates graphics and clears the Drawing
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            ///Creates a new Grid with given Size
            this.grid = new Grid(width, height);

            ///resets the fieldIndex
            this.fieldIndex = 0;


            ///changes the Drawing to the new field and Graphics
            gd.changeDrawing(grid.field, g);

            ///refreshes the Drawing
            this.Invalidate();
        }

    }
}
