

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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.checkBoxLockField = new System.Windows.Forms.CheckBox();
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
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonNextGen.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(300, 50);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(400, 400);
            this.gridPanel.TabIndex = 2;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPanel_Paint);
            this.gridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseClick);
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(779, 437);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(71, 13);
            this.labelGeneration.TabIndex = 3;
            this.labelGeneration.Text = "1. Generation";
            // 
            // checkBoxLockField
            // 
            this.checkBoxLockField.AutoSize = true;
            this.checkBoxLockField.Location = new System.Drawing.Point(782, 399);
            this.checkBoxLockField.Name = "checkBoxLockField";
            this.checkBoxLockField.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLockField.TabIndex = 4;
            this.checkBoxLockField.Text = "lock field";
            this.checkBoxLockField.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 555);
            this.Controls.Add(this.checkBoxLockField);
            this.Controls.Add(this.labelGeneration);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.buttonNextGen);
            this.Controls.Add(this.buttonClear);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonNextGen;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.CheckBox checkBoxLockField;
    }
}

