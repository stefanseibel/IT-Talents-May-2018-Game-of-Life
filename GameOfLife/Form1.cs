
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace GameOfLife {
    public partial class Form1 : Form {

        public Grid grid;

        Graphics g;

        public GridDrawing gd;

        UIControl uiControl;

        int gridX, gridY, gridWidth, gridHeight;

        public Form1() {
            InitializeComponent();

            
            grid = new Grid(6,6);

            uiControl = new UIControl(this, grid);

            this.gridX = 100;
            gridY = 100;
            gridWidth = 300;
            gridHeight = 300;

        }

        private void Form1_Load(object sender, EventArgs e) {

            

            this.Paint += new PaintEventHandler(Form1_Paint);

            this.Refresh();
        }



        private void Form1_Paint(object sender, PaintEventArgs e) {
            
            g = e.Graphics;

            gd = new GridDrawing(this.grid, g, 100, 100, 300, 300);

            gd.DrawGrid();
            gd.DrawBorders();

            

        }

        private void button1_Click(object sender, EventArgs e) {
            uiControl.ClearGrid();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            if (gridX < e.X && e.X < (gridX + gridWidth) && gridY < e.Y && e.Y < (gridY + gridHeight)){

                if (!checkBoxLockField.Checked) {
                    float posX = ((float)e.X - gridX) / gd.widthPerCell;
                    float posY = ((float)e.Y - gridY) / gd.widthPerCell;
                    

                    grid.field[(int)posY, (int)posX] = !grid.field[(int)posY, (int)posX];



                    this.Refresh();

                    grid.oldGens.Clear();
                    grid.generation = 1;
                    labelGeneration.Text = grid.generation.ToString() + ". Generation";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            uiControl.NextGeneration();
        }





        private void button1_Click_1(object sender, EventArgs e) {

            this.CreateGraphics().Clear(Color.White);

            this.grid = new Grid(int.Parse(textBoxWidth.Text), int.Parse(textBoxHeight.Text));
            labelGeneration.Text = grid.generation.ToString() + ". Generation";


            this.Refresh();
        }
    }
}
