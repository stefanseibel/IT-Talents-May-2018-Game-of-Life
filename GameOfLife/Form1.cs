
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

            grid = new Grid(6,6);

        }

        private void Form1_Load(object sender, EventArgs e) {

            
            this.gridPanel.Paint += new PaintEventHandler(gridPanel_Paint);

            this.Paint += new PaintEventHandler(Form1_Paint);

            this.Refresh();
        }

        private void gridPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {

            g = e.Graphics;

            gd = new GridDrawing(this.grid, g, 0, 0, this.gridPanel.Width, this.gridPanel.Height);

            gd.DrawGrid();
            gd.DrawBorders();

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

            if (!checkBoxLockField.Checked) {
                float posX = (float)e.X / gd.widthPerCell;
                float posY = (float)e.Y / gd.widthPerCell;

                Console.WriteLine("a " + e.X.ToString() + " " + gd.widthPerCell.ToString() + " " + posX.ToString());




                grid.field[(int)posY, (int)posX] = !grid.field[(int)posY, (int)posX];



                this.Refresh();

                grid.oldGens.Clear();
                grid.generation = 1;
                labelGeneration.Text = grid.generation.ToString() + ". Generation";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {

            if (gd != null) {
                e.Graphics.DrawRectangle(new Pen(Color.Black, gd.widthPerCell / 25), gridPanel.Location.X, gridPanel.Location.Y, gridPanel.Width, gridPanel.Height);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e) {

            this.CreateGraphics().Clear(Color.White);
            this.gridPanel.CreateGraphics().Clear(Color.White);
            
            this.grid = new Grid(int.Parse(textBoxWidth.Text), int.Parse(textBoxHeight.Text));
            labelGeneration.Text = grid.generation.ToString() + ". Generation";


            this.Refresh();
        }
    }
}
