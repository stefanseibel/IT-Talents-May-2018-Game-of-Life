

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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNextGen = new System.Windows.Forms.Button();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.checkBoxLockField = new System.Windows.Forms.CheckBox();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.trackBarGen = new System.Windows.Forms.TrackBar();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFindPattern = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(12, 480);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 37);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonNextGen
            // 
            this.buttonNextGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNextGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNextGen.FlatAppearance.BorderSize = 0;
            this.buttonNextGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextGen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextGen.ForeColor = System.Drawing.Color.White;
            this.buttonNextGen.Location = new System.Drawing.Point(177, 480);
            this.buttonNextGen.Name = "buttonNextGen";
            this.buttonNextGen.Size = new System.Drawing.Size(159, 37);
            this.buttonNextGen.TabIndex = 1;
            this.buttonNextGen.Text = "Next Generation";
            this.buttonNextGen.UseVisualStyleBackColor = false;
            this.buttonNextGen.Click += new System.EventHandler(this.buttonNextGen_Click);
            // 
            // labelGeneration
            // 
            this.labelGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(708, 383);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(71, 13);
            this.labelGeneration.TabIndex = 3;
            this.labelGeneration.Text = "1. Generation";
            // 
            // checkBoxLockField
            // 
            this.checkBoxLockField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLockField.AutoSize = true;
            this.checkBoxLockField.Location = new System.Drawing.Point(785, 382);
            this.checkBoxLockField.Name = "checkBoxLockField";
            this.checkBoxLockField.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLockField.TabIndex = 4;
            this.checkBoxLockField.Text = "lock field";
            this.checkBoxLockField.UseVisualStyleBackColor = true;
            this.checkBoxLockField.CheckedChanged += new System.EventHandler(this.checkBoxLockField_CheckedChanged);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(131)))));
            this.buttonChangeSize.FlatAppearance.BorderSize = 0;
            this.buttonChangeSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSize.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeSize.Location = new System.Drawing.Point(342, 451);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(159, 37);
            this.buttonChangeSize.TabIndex = 5;
            this.buttonChangeSize.Text = "Change Size";
            this.buttonChangeSize.UseVisualStyleBackColor = false;
            this.buttonChangeSize.Click += new System.EventHandler(this.buttonChangeSize_Click);
            // 
            // trackBarGen
            // 
            this.trackBarGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarGen.BackColor = System.Drawing.Color.White;
            this.trackBarGen.Location = new System.Drawing.Point(18, 383);
            this.trackBarGen.Minimum = 1;
            this.trackBarGen.Name = "trackBarGen";
            this.trackBarGen.Size = new System.Drawing.Size(684, 45);
            this.trackBarGen.TabIndex = 8;
            this.trackBarGen.Value = 1;
            this.trackBarGen.Scroll += new System.EventHandler(this.trackBarGen_Scroll);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownWidth.Location = new System.Drawing.Point(507, 462);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownWidth.TabIndex = 9;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownHeight.Location = new System.Drawing.Point(674, 462);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownHeight.TabIndex = 10;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabControl1.Location = new System.Drawing.Point(18, 44);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1201, 322);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGridToolStripMenuItem});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemFile.Text = "Options";
            // 
            // newGridToolStripMenuItem
            // 
            this.newGridToolStripMenuItem.Name = "newGridToolStripMenuItem";
            this.newGridToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newGridToolStripMenuItem.Text = "New Grid";
            this.newGridToolStripMenuItem.Click += new System.EventHandler(this.newGridToolStripMenuItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(1060, 480);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 37);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFindPattern
            // 
            this.buttonFindPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFindPattern.BackColor = System.Drawing.Color.Purple;
            this.buttonFindPattern.FlatAppearance.BorderSize = 0;
            this.buttonFindPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindPattern.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindPattern.ForeColor = System.Drawing.Color.White;
            this.buttonFindPattern.Location = new System.Drawing.Point(177, 434);
            this.buttonFindPattern.Name = "buttonFindPattern";
            this.buttonFindPattern.Size = new System.Drawing.Size(159, 37);
            this.buttonFindPattern.TabIndex = 14;
            this.buttonFindPattern.Text = "Find Pattern";
            this.buttonFindPattern.UseVisualStyleBackColor = false;
            this.buttonFindPattern.Click += new System.EventHandler(this.buttonFindPattern_Click);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInvert.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonInvert.FlatAppearance.BorderSize = 0;
            this.buttonInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvert.ForeColor = System.Drawing.Color.White;
            this.buttonInvert.Location = new System.Drawing.Point(12, 434);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(159, 37);
            this.buttonInvert.TabIndex = 15;
            this.buttonInvert.Text = "Invert Field";
            this.buttonInvert.UseVisualStyleBackColor = false;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 529);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.buttonFindPattern);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.trackBarGen);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.checkBoxLockField);
            this.Controls.Add(this.labelGeneration);
            this.Controls.Add(this.buttonNextGen);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Invalidated += new System.Windows.Forms.InvalidateEventHandler(this.Form1_Invalidate);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonNextGen;
        public System.Windows.Forms.Label labelGeneration;
        public System.Windows.Forms.CheckBox checkBoxLockField;
        private System.Windows.Forms.Button buttonChangeSize;
        public System.Windows.Forms.TrackBar trackBarGen;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem newGridToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFindPattern;
        private System.Windows.Forms.Button buttonInvert;
    }
}

