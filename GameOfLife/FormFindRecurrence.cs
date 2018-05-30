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
    public partial class FormFindRecurrence : Form {

        private Grid grid;
        private Form1 form;
        private int patternStart;
        private int patternEnd;
        private bool finished = false;

        System.Threading.Thread thread;


        public FormFindRecurrence(Grid grid, Form1 form) {
            InitializeComponent();

            this.grid = grid;
            this.form = form;
        }

        private void buttonFindPattern_Click(object sender, EventArgs e) {

            Tuple<int, int> bounds = grid.FindPattern();

            this.labelPrintResult.Text = "Recurring Pattern between Generations " + (bounds.Item1 + 1).ToString() + " and " + (bounds.Item2 + 1).ToString();

        }

        private void FormFindRecurrence_Shown(object sender, EventArgs e) {
            
            thread = new System.Threading.Thread(FindPattern);
            thread.Start();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void ButtonGoToLast_Click(object sender, EventArgs e) {

            if (finished) {

                this.form.selectedTab.fieldIndex = patternEnd;
                this.form.trackBarGen.Value = patternEnd + 1;
                this.form.selectedTab.Invalidate();
            }

        }

        private void buttonGoToFirst_Click(object sender, EventArgs e) {

            if (finished) {

                this.form.selectedTab.fieldIndex = patternStart;
                this.form.trackBarGen.Value = patternStart + 1;
                this.form.selectedTab.Invalidate();
            }
        }
        
        private void FindPattern() {

            Tuple<int, int> bounds = grid.FindPattern();

            finished = true;
            patternStart = bounds.Item1;
            patternEnd = bounds.Item2;

            
            Action action = UpdateForm;
            
            this.Invoke(action);

        }

        private void UpdateForm() {



            this.labelPrintResult.Text = "Recurring Pattern between Generations " + patternStart.ToString() + " and " + patternEnd.ToString();


            this.form.selectedTab.fieldIndex = patternEnd;
            this.form.selectedTab.Invalidate();


        }

        private void FormFindRecurrence_Deactivate(object sender, EventArgs e) {
            thread.Abort();

            form.isLocked = form.checkBoxLockField.Checked;
        }
    }
}
