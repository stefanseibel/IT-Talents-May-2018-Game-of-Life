namespace GameOfLife {
    partial class FormFindRecurrence {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelPrintResult = new System.Windows.Forms.Label();
            this.buttonGoToFirst = new System.Windows.Forms.Button();
            this.ButtonGoToLast = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrintResult
            // 
            this.labelPrintResult.AutoSize = true;
            this.labelPrintResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrintResult.Location = new System.Drawing.Point(9, 25);
            this.labelPrintResult.Name = "labelPrintResult";
            this.labelPrintResult.Size = new System.Drawing.Size(78, 20);
            this.labelPrintResult.TabIndex = 16;
            this.labelPrintResult.Text = "Loading...";
            // 
            // buttonGoToFirst
            // 
            this.buttonGoToFirst.BackColor = System.Drawing.Color.Cyan;
            this.buttonGoToFirst.FlatAppearance.BorderSize = 0;
            this.buttonGoToFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToFirst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToFirst.ForeColor = System.Drawing.Color.Black;
            this.buttonGoToFirst.Location = new System.Drawing.Point(13, 97);
            this.buttonGoToFirst.Name = "buttonGoToFirst";
            this.buttonGoToFirst.Size = new System.Drawing.Size(159, 37);
            this.buttonGoToFirst.TabIndex = 20;
            this.buttonGoToFirst.Text = "Go to first Element ";
            this.buttonGoToFirst.UseVisualStyleBackColor = false;
            this.buttonGoToFirst.Click += new System.EventHandler(this.buttonGoToFirst_Click);
            // 
            // ButtonGoToLast
            // 
            this.ButtonGoToLast.BackColor = System.Drawing.Color.Crimson;
            this.ButtonGoToLast.FlatAppearance.BorderSize = 0;
            this.ButtonGoToLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGoToLast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGoToLast.ForeColor = System.Drawing.Color.White;
            this.ButtonGoToLast.Location = new System.Drawing.Point(177, 97);
            this.ButtonGoToLast.Name = "ButtonGoToLast";
            this.ButtonGoToLast.Size = new System.Drawing.Size(159, 37);
            this.ButtonGoToLast.TabIndex = 19;
            this.ButtonGoToLast.Text = "Go to last Element";
            this.ButtonGoToLast.UseVisualStyleBackColor = false;
            this.ButtonGoToLast.Click += new System.EventHandler(this.ButtonGoToLast_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(428, 97);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(159, 37);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormFindRecurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 146);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGoToFirst);
            this.Controls.Add(this.ButtonGoToLast);
            this.Controls.Add(this.labelPrintResult);
            this.MaximumSize = new System.Drawing.Size(615, 185);
            this.MinimumSize = new System.Drawing.Size(615, 185);
            this.Name = "FormFindRecurrence";
            this.Text = "FormFindRecurrence";
            this.Deactivate += new System.EventHandler(this.FormFindRecurrence_Deactivate);
            this.Shown += new System.EventHandler(this.FormFindRecurrence_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrintResult;
        private System.Windows.Forms.Button buttonGoToFirst;
        private System.Windows.Forms.Button ButtonGoToLast;
        private System.Windows.Forms.Button buttonClose;
    }
}