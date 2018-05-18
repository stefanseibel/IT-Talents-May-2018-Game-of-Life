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
    public partial class FormNewTab : Form {

        private Form1 form;

        public FormNewTab(Form1 form) {
            InitializeComponent();
            this.form = form;
        }

        private void buttonNewGrid_Click(object sender, EventArgs e) {

            int width = (int) this.numericUpDownWidth.Value;
            int height = (int) this.numericUpDownHeight.Value;
            string tabName = this.textBoxName.Text;

            form.NewTab(width, height, tabName);
            this.Close();

        }
    }
}
