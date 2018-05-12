
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

        public int gridX, gridY, gridWidth, gridHeight;

        public bool[,] currentField;

        public Form1() {
            InitializeComponent();

            
            grid = new Grid(6,6);
            currentField = grid.field;

            uiControl = new UIControl(this, grid);

            this.gridX = 50;
            gridY = 50;
            gridWidth = 0;
            gridHeight = 0;
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.Paint += new PaintEventHandler(Form1_Paint);

            this.Invalidate();
        }



        private void Form1_Paint(object sender, PaintEventArgs e) {
            
            g = e.Graphics;

            gd = new GridDrawing(currentField, g, 50, 50, this.Width - 100, this.Height - 250);

            gd.DrawGrid();

            

        }

        private void buttonClear_Click(object sender, EventArgs e) {
            uiControl.ClearGrid();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            uiControl.SetCell(e.X, e.Y);

            Console.WriteLine(this.Height.ToString() + " " + e.Y.ToString());
        }

        private void trackBarGen_Scroll(object sender, EventArgs e) {
            
            if(this.trackBarGen.Value == this.trackBarGen.Maximum) {

                currentField = grid.field;

            } else {

                currentField = grid.oldGens[this.trackBarGen.Value];

            }

            this.Invalidate();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e) {

            int gap = 17; //px
            int buttonWidth = 160;
            int buttonHeight = 40;
            
            this.buttonClear.SetBounds(gap, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.buttonNextGen.SetBounds(gap * 2 + buttonWidth, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.buttonNewGrid.SetBounds(gap * 3 + buttonWidth * 2, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.trackBarGen.SetBounds(gap, this.Height - gap * 2 - buttonHeight - trackBarGen.Height - 40, trackBarGen.Width, trackBarGen.Height);
            this.numericUpDownWidth.SetBounds(gap * 4 + buttonWidth * 3, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.numericUpDownHeight.SetBounds(gap * 5 + buttonWidth * 4, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.checkBoxLockField.SetBounds(gap * 6 + buttonWidth * 5, this.Height - gap - buttonHeight - 40, buttonWidth, buttonHeight);
            this.labelGeneration.SetBounds(gap * 6 + buttonWidth * 5, this.Height - gap - buttonHeight - 38 + checkBoxLockField.Height, buttonWidth, buttonHeight);

            this.Invalidate();
        }

        private void Form1_Invalidate(object sender, InvalidateEventArgs e) {

            labelGeneration.Text = grid.generation.ToString() + ". Generation";

            this.trackBarGen.Maximum = this.grid.oldGens.Count;
        }

        private void buttonNextGen_Click(object sender, EventArgs e) {
            uiControl.NextGeneration();

            this.currentField = this.grid.field;
            this.trackBarGen.Invalidate();
            this.trackBarGen.Value = this.trackBarGen.Maximum;
        }
        

        private void buttonNewGrid_Click(object sender, EventArgs e) {

            uiControl.NewGrid((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);
        }
    }
}
