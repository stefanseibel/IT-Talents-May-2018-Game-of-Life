
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
        

        public int gridX, gridY, gridWidth, gridHeight;

        public bool[,] currentField;

        public Form1() {
            InitializeComponent();

            this.tabControl1.TabPages.Add(new GridTab(this,new Grid(6,6), 30));
            GridTab t = (GridTab)this.tabControl1.TabPages[0];
            t.Paint += new PaintEventHandler(Tab_Paint);
            t.MouseDown += new MouseEventHandler(Tab_MouseClick);
            
            t.grid.PrintField();
        }

        private void Form1_Load(object sender, EventArgs e) {

            
            this.Invalidate();
        }

        private void Tab_Paint(object sender, PaintEventArgs e) {

            GridTab selectedTab = (GridTab) sender;

            g = e.Graphics;

            //TODO: make gd saved in GridTab
            gd = new GridDrawing(selectedTab.field, g, selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 3, selectedTab.Height - selectedTab.border * 3);

            gd.DrawGrid();



        }


        private void buttonClear_Click(object sender, EventArgs e) {
            GridTab selectedTab = (GridTab)tabControl1.SelectedTab;
            selectedTab.ClearGrid();
            selectedTab.Invalidate();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            
        }


        private void Tab_MouseClick(object sender, MouseEventArgs e) {

            GridTab selectedTab = (GridTab) sender;

            selectedTab.SetCell(e.X, e.Y);

            Console.WriteLine(this.Height.ToString() + " " + e.Y.ToString());
        }

        private void trackBarGen_Scroll(object sender, EventArgs e) {

            GridTab selectedTab = (GridTab)tabControl1.SelectedTab;

            if (this.trackBarGen.Value == this.trackBarGen.Maximum) {

                selectedTab.field = selectedTab.grid.field;

            } else {

                selectedTab.field = selectedTab.grid.oldGens[this.trackBarGen.Value];

            }

            selectedTab.Invalidate();
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

        //TODO: change trackBarGen.Maximum somewhere else instead of reloading the whole form
        private void Form1_Invalidate(object sender, InvalidateEventArgs e) {
            GridTab selectedTab = (GridTab)tabControl1.SelectedTab;
            labelGeneration.Text = selectedTab.grid.generation.ToString() + ". Generation";

            this.trackBarGen.Maximum = selectedTab.grid.oldGens.Count;
        }

        private void buttonNextGen_Click(object sender, EventArgs e) {
            GridTab selectedTab = (GridTab)tabControl1.SelectedTab;
            selectedTab.NextGeneration();
            
            this.Invalidate();
            this.trackBarGen.Value = this.trackBarGen.Maximum;
        }
        

        private void buttonNewGrid_Click(object sender, EventArgs e) {
            GridTab selectedTab = (GridTab)tabControl1.SelectedTab;
            selectedTab.NewGrid((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);
        }
    }
}
