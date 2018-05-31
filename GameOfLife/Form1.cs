
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
    //Main Form where the Game is Played
    public partial class Form1 : Form {
        
        //The Tab that is selected in TabControl1
        public GridTab selectedTab;

        //says if the Grid is editable by the User
        public bool isLocked = false;

        //CONSTRUCTOR: generates the Form
        public Form1() {
            //Initializes the Form and its Components
            InitializeComponent();

            //Opens with an Example
            NewTab(6, 6,"new Grid");

            selectedTab = (GridTab)tabControl1.SelectedTab;
        }

        //Event is called when the Form is Loaded
        private void Form1_Load(object sender, EventArgs e) {

            //Calculates the minimum Size of the Form with the Position of checkBoxLockField
            this.MinimumSize = new Size(this.checkBoxLockField.Location.X + this.checkBoxLockField.Width + 12 + 12, this.Height - this.trackBarGen.Location.Y + 30 + 250);

            selectedTab.gd.SetSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 2, selectedTab.Height - selectedTab.border * 2);

            this.Invalidate();
        }

        //Event is called when the selectedTab is Refreshed/Invalidated
        private void Tab_Paint(object sender, PaintEventArgs e) {
            
            //changes the Drawing with a possibly changed selected Grid and Graphics
            selectedTab.gd.changeDrawing(selectedTab.grid.allGens[selectedTab.fieldIndex], e.Graphics);
            
            //Draws the Grid on the Tab
            selectedTab.gd.DrawGrid();

            //also reloads the Form
            this.Invalidate();

        }

        //Event is called when the "Clear" Button is pressed
        private void buttonClear_Click(object sender, EventArgs e) {

            //Clears the Grid
            selectedTab.ClearGrid();

            //Refreshes the Drawing
            selectedTab.Invalidate();
        }

        //Event is called when the selectedTab is pressed
        private void Tab_MouseClick(object sender, MouseEventArgs e) {

            //Checks if Mouse input is locked
            if (!isLocked) {

                //opens the SetCell Function with the coordinates of the Cursor
                selectedTab.SetCell(e.X, e.Y);

            }
        }

        //Event is called when the User scrolled on the trackBar
        private void trackBarGen_Scroll(object sender, EventArgs e) {

            //sets the fieldIndex of selectedTab to the Value of the TrackBar
            selectedTab.fieldIndex = this.trackBarGen.Value - 1;

            //Refreshes the Drawing
            selectedTab.Invalidate();
        }

        //Event is called when the Size of the Form is changed
        private void Form1_Resize(object sender, EventArgs e) {

            //changed the Bounds of the GridDrawing
            selectedTab.gd.SetSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 2, selectedTab.Height - selectedTab.border * 2);

            //Refreshes the Drawing
            selectedTab.Invalidate();
        }

        //Event is called when the Form is Refreshed/Invalidated
        private void Form1_Invalidate(object sender, InvalidateEventArgs e) {

            //updates the Text of labelGeneration to the amount of generations
            labelGeneration.Text = selectedTab.grid.generation.ToString() + ". Generation";

            //updates the maximum of trackBarGen to the amount of generations
            this.trackBarGen.Maximum = selectedTab.grid.allGens.Count;
        }

        //Event is called when the User changes Tabs
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {

            //chacks if any tabs exist
            if (tabControl1.SelectedIndex >= 0) {

                //updates the selected Tab as it changed
                selectedTab = (GridTab)this.tabControl1.SelectedTab;

                //Updates the size of the GridDrawing of the newly selectedTab as it might have changed while the tab was not active
                selectedTab.gd.SetSize(selectedTab.border, selectedTab.border, selectedTab.Width - selectedTab.border * 3, selectedTab.Height - selectedTab.border * 3);

                //Updats the trackBraGen to the Values of the new Tab
                this.trackBarGen.Maximum = selectedTab.grid.generation;
                this.trackBarGen.Value = selectedTab.fieldIndex + 1;

                //Refreshes the Drawing
                this.selectedTab.Invalidate();
            }
        }

        //Event is called when the "Next Generation" Button is pressed
        private void buttonNextGen_Click(object sender, EventArgs e) {

            //checks if there are any tabs
            if (tabControl1.TabCount > 0) {

                //Generates the next generation
                selectedTab.NextGeneration();

                //Refreshes the Form
                this.Invalidate();

                //Sets the Value of trackBarGen to the latest Generation
                this.trackBarGen.Value = this.trackBarGen.Maximum;
            }
        }

        //Event is called when the "Change Size" Button is pressed
        private void buttonChangeSize_Click(object sender, EventArgs e) {

            //Creates a new Grid with the Size of the numericUpDowns
            selectedTab.NewGrid((int) numericUpDownWidth.Value, (int) numericUpDownHeight.Value);

        }

        //Event is called when the "New Grid" Menu Element is pressed
        private void newGridToolStripMenuItem_Click(object sender, EventArgs e) {

            //creates a new formNewTab
            FormNewTab formNewTab = new FormNewTab(this);

            //opens the formNewTab as a Dialog so that the Main Form can't be used in the meanwhile
            formNewTab.ShowDialog();
        }

        //Event is called when the "Delete" Button is pressed
        private void buttonDelete_Click(object sender, EventArgs e) {

            //Opens a Dialog Window as a Warning
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete the Grid?", "Delete Grid", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //checks if User conformed the Dialog
            if (dialogResult == DialogResult.OK) {
                //remove the selected Tab From the tabControl
                tabControl1.TabPages.Remove(this.selectedTab);
            }
        }

        //Event is called when the "Find Pattern" Button is pressed
        private void buttonFindPattern_Click(object sender, EventArgs e) {

            //checks if a tab exists
            if (tabControl1.TabCount > 0) {

                //checks if the FormFindRecurrence is already opened (to prevent opening it multiple times
                if (!FormOpened(typeof(FormFindRecurrence))) {

                    //creates a new FormFindRecurrence
                    FormFindRecurrence form = new FormFindRecurrence(selectedTab.grid, this);

                    //locks the grid from changing
                    isLocked = true;

                    //displays the form
                    form.Show();
                }
            }
        }

        //Event is called when the checkbox is pressed
        private void checkBoxLockField_CheckedChanged(object sender, EventArgs e) {

            //checks if the FormFindRecurrence is opened
            if (!FormOpened(typeof(FormFindRecurrence))) {

                //updates isLocked
                this.isLocked = checkBoxLockField.Checked;
            }

        }

        //FUNCTIONS THAT AREN'T EVENTS

        //Creates a new GridTab
        public void NewTab(int width, int height, string tabName) {

            //Makes a new GridTab with given width, height and name
            GridTab t = new GridTab(this, new Grid(width,height), 20, tabName);

            //added the new Tab to the tabControl
            this.tabControl1.TabPages.Add(t);
            
            //added Paint and MouseClick Events to the Tab 
            t.Paint += new PaintEventHandler(Tab_Paint);
            t.MouseDown += new MouseEventHandler(Tab_MouseClick);

            //sets the size of the gridDrawing of the new Tab
            t.gd.SetSize(t.border, t.border, t.Width - t.border * 2, t.Height - t.border * 2);
            
            //maks selectedTab to the new Tab
            this.selectedTab = t;

            //Selects the new Tab in the tabControl
            this.tabControl1.SelectedTab = t;

        }



        private bool FormOpened(Type formType) {

            foreach(Form openForm in Application.OpenForms) {
                if(openForm.GetType() == formType) {
                    return true;
                }
            }

            return false;
        }

        private void buttonInvert_Click(object sender, EventArgs e) {

            selectedTab.InvertField();
        }
    }
}
