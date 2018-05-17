
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
        
        public GridTab selectedTab;

        public Form1() {
            InitializeComponent();

            NewTab(6, 6);
            NewTab(9, 9);
            selectedTab = (GridTab)tabControl1.SelectedTab;
        }

        private void Form1_Load(object sender, EventArgs e) {

            
            this.Invalidate();
        }

        private void Tab_Paint(object sender, PaintEventArgs e) {

            GridTab paintedTab = (GridTab)sender;

            Graphics g = e.Graphics;

            //TODO: make gd not a new object every time
            selectedTab.gd = new GridDrawing(paintedTab.field, g, paintedTab.border, paintedTab.border, paintedTab.Width - paintedTab.border * 3, paintedTab.Height - paintedTab.border * 3);

            selectedTab.gd.DrawGrid();



        }


        private void buttonClear_Click(object sender, EventArgs e) {
            selectedTab.ClearGrid();
            selectedTab.Invalidate();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            
        }


        private void Tab_MouseClick(object sender, MouseEventArgs e) {
            

            selectedTab.SetCell(e.X, e.Y);

            Console.WriteLine(this.selectedTab.grid.width.ToString() + " " + e.Y.ToString());
        }

        private void trackBarGen_Scroll(object sender, EventArgs e) {
            
            selectedTab.field = selectedTab.grid.allGens[this.trackBarGen.Value - 1];
            
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
            this.tabControl1.SetBounds(gap, gap, this.Width - gap * 3, this.trackBarGen.Location.Y - gap * 2);

            this.Invalidate();
        }

        //TODO: change trackBarGen.Maximum somewhere else instead of reloading the whole form
        private void Form1_Invalidate(object sender, InvalidateEventArgs e) {

            labelGeneration.Text = selectedTab.grid.generation.ToString() + ". Generation";

            this.trackBarGen.Maximum = selectedTab.grid.allGens.Count;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            
            selectedTab = (GridTab) this.tabControl1.SelectedTab;
            this.trackBarGen.Maximum = selectedTab.grid.generation;
            this.trackBarGen.Value = selectedTab.grid.generation;
            this.Invalidate();
        }

        private void buttonNextGen_Click(object sender, EventArgs e) {
            selectedTab.NextGeneration();
            
            this.Invalidate();
            this.trackBarGen.Value = this.trackBarGen.Maximum;
        }
        

        private void buttonNewGrid_Click(object sender, EventArgs e) {
            selectedTab.NewGrid((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);
        }

        //FUNCTION THAT AREN'T EVENTS

        private void NewTab(int width, int height) {

            GridTab t = new GridTab(this, new Grid(width,height), 20);
            this.tabControl1.TabPages.Add(t);
            
            t.Paint += new PaintEventHandler(Tab_Paint);
            t.MouseDown += new MouseEventHandler(Tab_MouseClick);

            
        }
    }
}
