using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife {
    //Form to find a recurrence
    public partial class FormFindRecurrence : Form {

        //Grid whose field will be checked for patterns
        private Grid grid;

        //Form1 where the grid is on
        private Form1 form;

        //Start and End for the patterns
        private int patternStart;
        private int patternEnd;

        //indicates if the calculations are finished
        private bool finished = false;

        //points to the thread where the pattern is searched
        System.Threading.Thread thread;
        
        //CONSTRUCTOR: opens the Form 
        public FormFindRecurrence(Grid grid, Form1 form) {
            //Initializes the Forms
            InitializeComponent();

            //sets grid and form Attributes from Parameters
            this.grid = grid;
            this.form = form;
        }

        //Event is called when the form is shown
        private void FormFindRecurrence_Shown(object sender, EventArgs e) {
            
            //opens and starts a new Tab where the searching is done
            //the search calculation is done on another Thread so that the Form can be displayed without problems while the search is done
            thread = new System.Threading.Thread(FindPattern);
            thread.Start();
            
        }

        //Event is called when the "close" button is pressed
        private void buttonClose_Click(object sender, EventArgs e) {

            //closes this form
            this.Close();
        }

        //Event is called when the "Go to first Element" button is pressed
        private void buttonGoToFirst_Click(object sender, EventArgs e) {

            //checks if the calculation has been finished
            if (finished) {

                //sets the selected field as patternStart
                this.form.selectedTab.fieldIndex = patternStart;
                this.form.trackBarGen.Value = patternStart + 1;

                //refreshes the Drawing
                this.form.selectedTab.Invalidate();
            }
        }

        //Event is called when the "Go to last Element" button is pressed
        //Code is the same as previous only with patternEnd instead of patternStart
        private void ButtonGoToLast_Click(object sender, EventArgs e) {

            if (finished) {

                this.form.selectedTab.fieldIndex = patternEnd;
                this.form.trackBarGen.Value = patternEnd + 1;
                this.form.selectedTab.Invalidate();
            }

        }
        
        //Searches for recurring Patterns
        private void FindPattern() {

            //gets the Bounds of the recurring Pattern
            Tuple<int, int> bounds = grid.FindPattern();

            //sets the status finished to true
            finished = true;

            //updates the patternStart and patternEnd Attributes
            patternStart = bounds.Item1;
            patternEnd = bounds.Item2;

            //saves the UpdateForm Method as an action
            Action action = UpdateForm;
            
            //Calls the UpdateForm Function in the Main Thread
            this.Invoke(action);

        }

        //Updates the Form after the Calculation is Finished
        private void UpdateForm() {


            //TODO: Other Text for special patterns e. g. stable end
            //Updates the labelPrintResult to communicate the Result to the User
            this.labelPrintResult.Text = "Recurring Pattern between Generations " + (patternStart + 1).ToString() + " and " + (patternEnd + 1).ToString();
            
            //Selects the last Generation in the grid if new Generations have been created
            if (this.grid.generation == (patternEnd + 1)) { 
                this.form.selectedTab.fieldIndex = patternEnd;

                this.form.trackBarGen.Maximum = (patternEnd + 1);
                this.form.trackBarGen.Value = (patternEnd + 1);
            }

            //refreshes the Drawing
            this.form.selectedTab.Invalidate();

        }

        //Event is called when the Form is Closed
        private void FormFindRecurrence_Deactivate(object sender, EventArgs e) {
            //Aborts the Thread if it is still running
            thread.Abort();

            //Unlocks the Grid if the checkBoxLockField is unchecked
            form.isLocked = form.checkBoxLockField.Checked;
        }
    }
}
