

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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.trackBarGen = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).BeginInit();
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
            this.buttonClear.Location = new System.Drawing.Point(1060, 506);
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
            this.buttonNextGen.Location = new System.Drawing.Point(884, 506);
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
            this.labelGeneration.Location = new System.Drawing.Point(705, 437);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(71, 13);
            this.labelGeneration.TabIndex = 3;
            this.labelGeneration.Text = "1. Generation";
            // 
            // checkBoxLockField
            // 
            this.checkBoxLockField.AutoSize = true;
            this.checkBoxLockField.Location = new System.Drawing.Point(884, 436);
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
            this.buttonNewGrid.Location = new System.Drawing.Point(708, 506);
            this.buttonNewGrid.Name = "buttonNewGrid";
            this.buttonNewGrid.Size = new System.Drawing.Size(159, 37);
            this.buttonNewGrid.TabIndex = 5;
            this.buttonNewGrid.Text = "New Grid";
            this.buttonNewGrid.UseVisualStyleBackColor = false;
            this.buttonNewGrid.Click += new System.EventHandler(this.buttonNewGrid_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(554, 512);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(142, 27);
            this.textBoxHeight.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(406, 512);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(142, 27);
            this.textBoxWidth.TabIndex = 7;
            // 
            // trackBarGen
            // 
            this.trackBarGen.Location = new System.Drawing.Point(12, 437);
            this.trackBarGen.Name = "trackBarGen";
            this.trackBarGen.Size = new System.Drawing.Size(684, 45);
            this.trackBarGen.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 555);
            this.Controls.Add(this.trackBarGen);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).EndInit();
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
        public System.Windows.Forms.TextBox textBoxHeight;
        public System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TrackBar trackBarGen;
    }
}

