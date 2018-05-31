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

    //Form where User can create new Tabs
    public partial class FormNewTab : Form {

        //Form1
        private Form1 form;

        //CONSTRUCTOR: initializes the Form and its components
        public FormNewTab(Form1 form) {
            //Initializes the Forms
            InitializeComponent();

            //sets form Attribute from Parameter
            this.form = form;
        }

        //event when the "New Grid" Button is pressed
        private void buttonNewGrid_Click(object sender, EventArgs e) {
            
            //reads out Values from numericUpDowns and the textBox
            int width = (int) this.numericUpDownWidth.Value;
            int height = (int) this.numericUpDownHeight.Value;
            string tabName = this.textBoxName.Text;

            //makes a new tab on the form1
            form.NewTab(width, height, tabName);

            //refreshes the Drawing
            form.selectedTab.Invalidate();

            //closes the Form 
            this.Close();

        }
    }
}
