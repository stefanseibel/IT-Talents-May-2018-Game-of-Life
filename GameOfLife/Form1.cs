
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

        Grid grid;

        Graphics g;

        GridDrawing gd;

        public Form1() {
            InitializeComponent();

            grid = new Grid(10,10);

        }

        private void Form1_Load(object sender, EventArgs e) {

            
            this.gridPanel.Paint += new PaintEventHandler(gridPanel_Paint);

        }

        private void gridPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {

            g = e.Graphics;

            gd = new GridDrawing(this.grid, g, 0, 0, this.gridPanel.Width, this.gridPanel.Height);

            gd.DrawGrid();
            gd.drawBorders();


            this.Paint += new PaintEventHandler(Form1_Paint);
        }


        private void button1_Click(object sender, EventArgs e) {
            grid.oldGens.Clear();
            grid = new Grid(grid.width, grid.height);
            this.Refresh();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            for (int i = 0; i < 1; i++) {
                grid.NextGeneration();
                this.Refresh();
                labelGeneration.Text = grid.generation.ToString() + ". Generation";
            }
            
        }


        private void gridPanel_MouseClick(object sender, MouseEventArgs e) {
            int posX = e.X / (int)gd.widthPerCell;
            int posY = e.Y / (int)gd.widthPerCell;

            try {
                grid.field[posY, posX] = !grid.field[posY, posX];

            } catch {
                //prevents Crash when clicking on the edge of the board due to rounding errors
                
            }

            this.Refresh();

            grid.oldGens.Clear();
            grid.generation = 1;
            labelGeneration.Text = grid.generation.ToString() + ". Generation";

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {

            if (gd != null) {
                e.Graphics.DrawRectangle(new Pen(Color.Black, gd.widthPerCell / 25), gridPanel.Location.X, gridPanel.Location.Y, gridPanel.Width, gridPanel.Height);
            }
        }
    }
}
