

namespace GameOfLife {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.buttonClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonNextGen = new System.Windows.Forms.Button();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.checkBoxLockField = new System.Windows.Forms.CheckBox();
            this.buttonNewGrid = new System.Windows.Forms.Button();
            this.trackBarGen = new System.Windows.Forms.TrackBar();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(12, 506);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 37);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // buttonNextGen
            // 
            this.buttonNextGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNextGen.FlatAppearance.BorderSize = 0;
            this.buttonNextGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextGen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextGen.ForeColor = System.Drawing.Color.White;
            this.buttonNextGen.Location = new System.Drawing.Point(177, 506);
            this.buttonNextGen.Name = "buttonNextGen";
            this.buttonNextGen.Size = new System.Drawing.Size(159, 37);
            this.buttonNextGen.TabIndex = 1;
            this.buttonNextGen.Text = "Next Generation";
            this.buttonNextGen.UseVisualStyleBackColor = false;
            this.buttonNextGen.Click += new System.EventHandler(this.buttonNextGen_Click);
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(839, 530);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(71, 13);
            this.labelGeneration.TabIndex = 3;
            this.labelGeneration.Text = "1. Generation";
            // 
            // checkBoxLockField
            // 
            this.checkBoxLockField.AutoSize = true;
            this.checkBoxLockField.Location = new System.Drawing.Point(842, 506);
            this.checkBoxLockField.Name = "checkBoxLockField";
            this.checkBoxLockField.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLockField.TabIndex = 4;
            this.checkBoxLockField.Text = "lock field";
            this.checkBoxLockField.UseVisualStyleBackColor = true;
            // 
            // buttonNewGrid
            // 
            this.buttonNewGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(131)))));
            this.buttonNewGrid.FlatAppearance.BorderSize = 0;
            this.buttonNewGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGrid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGrid.ForeColor = System.Drawing.Color.Black;
            this.buttonNewGrid.Location = new System.Drawing.Point(342, 506);
            this.buttonNewGrid.Name = "buttonNewGrid";
            this.buttonNewGrid.Size = new System.Drawing.Size(159, 37);
            this.buttonNewGrid.TabIndex = 5;
            this.buttonNewGrid.Text = "New Grid";
            this.buttonNewGrid.UseVisualStyleBackColor = false;
            this.buttonNewGrid.Click += new System.EventHandler(this.buttonNewGrid_Click);
            // 
            // trackBarGen
            // 
            this.trackBarGen.BackColor = System.Drawing.Color.White;
            this.trackBarGen.Location = new System.Drawing.Point(12, 446);
            this.trackBarGen.Name = "trackBarGen";
            this.trackBarGen.Size = new System.Drawing.Size(684, 45);
            this.trackBarGen.TabIndex = 8;
            this.trackBarGen.Scroll += new System.EventHandler(this.trackBarGen_Scroll);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(507, 517);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownWidth.TabIndex = 9;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(674, 517);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownHeight.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(18, 16);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 418);
            this.tabControl1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.trackBarGen);
            this.Controls.Add(this.buttonNewGrid);
            this.Controls.Add(this.checkBoxLockField);
            this.Controls.Add(this.labelGeneration);
            this.Controls.Add(this.buttonNextGen);
            this.Controls.Add(this.buttonClear);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Invalidated += new System.Windows.Forms.InvalidateEventHandler(this.Form1_Invalidate);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonNextGen;
        public System.Windows.Forms.Label labelGeneration;
        public System.Windows.Forms.CheckBox checkBoxLockField;
        private System.Windows.Forms.Button buttonNewGrid;
        private System.Windows.Forms.TrackBar trackBarGen;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

