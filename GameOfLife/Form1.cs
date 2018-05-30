
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

        public bool isLocked = false;

        public Form1() {
            InitializeComponent();

            NewTab(6, 6,"6x6 Grid");
            NewTab(9, 9,"9x9 Grid");
            selectedTab = (GridTab)tabControl1.SelectedTab;
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.MinimumSize = new Size(this.labelGeneration.Location.X + this.labelGeneration.Width + this.buttonDelete.Width + 40, this.Height - this.trackBarGen.Location.Y + 30 + 250);

            selectedTab.gd.ChangeSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 2, selectedTab.Height - selectedTab.border * 2);

            this.Invalidate();
        }

        private void Tab_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            selectedTab.gd.changeDrawing(selectedTab.grid.allGens[selectedTab.fieldIndex], g);

            selectedTab.gd.DrawGrid();

            this.Invalidate();

        }


        private void buttonClear_Click(object sender, EventArgs e) {
            selectedTab.ClearGrid();
            selectedTab.Invalidate();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            
        }


        private void Tab_MouseClick(object sender, MouseEventArgs e) {

            if (!isLocked) {

                selectedTab.SetCell(e.X, e.Y);

            }
        }

        private void trackBarGen_Scroll(object sender, EventArgs e) {
            
            selectedTab.fieldIndex = this.trackBarGen.Value - 1;
            
            selectedTab.Invalidate();
        }
        
        private void Form1_Resize(object sender, EventArgs e) {

            selectedTab.gd.ChangeSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 2, selectedTab.Height - selectedTab.border * 2);

            this.Invalidate();
        }

        //TODO: change trackBarGen.Maximum somewhere else instead of reloading the whole form
        private void Form1_Invalidate(object sender, InvalidateEventArgs e) {

            labelGeneration.Text = selectedTab.grid.generation.ToString() + ". Generation";

            this.trackBarGen.Maximum = selectedTab.grid.allGens.Count;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {

            if (tabControl1.SelectedIndex >= 0) {
                selectedTab = (GridTab)this.tabControl1.SelectedTab;
                //TODO: remove duplicate code
                selectedTab.gd.ChangeSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 3, selectedTab.Height - selectedTab.border * 3);

                this.trackBarGen.Maximum = selectedTab.grid.generation;
                this.trackBarGen.Value = selectedTab.fieldIndex + 1;
                this.Invalidate();
            }
        }

        private void buttonNextGen_Click(object sender, EventArgs e) {
            selectedTab.NextGeneration();
            
            this.Invalidate();
            this.trackBarGen.Value = this.trackBarGen.Maximum;
        }
        
        //TODO: Set this.MinimumSize depending on Cell Width
        private void buttonChangeSize_Click(object sender, EventArgs e) {
            selectedTab.NewGrid((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);

        }

        private void newGridToolStripMenuItem_Click(object sender, EventArgs e) {

            FormNewTab formNewTab = new FormNewTab(this);

            formNewTab.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e) {

            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete the Grid?", "Delete Grid", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK) {
                tabControl1.TabPages.Remove(this.selectedTab);
            }
        }

        private void buttonFindPattern_Click(object sender, EventArgs e) {

            FormFindRecurrence form = new FormFindRecurrence(selectedTab.grid, this);

            isLocked = true;

            form.Show();
        }

        //FUNCTIONS THAT AREN'T EVENTS

        public void NewTab(int width, int height, string tabName) {

            GridTab t = new GridTab(this, new Grid(width,height), 20, tabName);
            this.tabControl1.TabPages.Add(t);
            
            t.Paint += new PaintEventHandler(Tab_Paint);
            t.MouseDown += new MouseEventHandler(Tab_MouseClick);

            t.gd.ChangeSize(t.border, t.border, t.Width - t.border * 2, t.Height - t.border * 2);
            
            this.selectedTab = t;
            this.tabControl1.SelectedTab = t;

        }

        private void checkBoxLockField_CheckedChanged(object sender, EventArgs e) {

            
            if (!FormOpened(typeof(FormFindRecurrence))) {
                this.isLocked = checkBoxLockField.Checked;
            }

        }

        private bool FormOpened(Type formType) {

            foreach(Form openForm in Application.OpenForms) {
                if(openForm.GetType() == formType) {
                    return true;
                }
            }

            return false;
        }
    }
}
