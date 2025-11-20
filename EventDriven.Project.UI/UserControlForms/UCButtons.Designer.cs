namespace EventDriven.Project.UI.UserControlForms.Buttons
{
    partial class UCButtons
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbDelete = new PictureBox();
            pbEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            SuspendLayout();
            // 
            // pbDelete
            // 
            pbDelete.Image = Properties.Resources.bin__1_;
            pbDelete.Location = new Point(178, 4);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(64, 64);
            pbDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDelete.TabIndex = 0;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // pbEdit
            // 
            pbEdit.Image = Properties.Resources.write;
            pbEdit.Location = new Point(58, 4);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(64, 64);
            pbEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            pbEdit.TabIndex = 2;
            pbEdit.TabStop = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // UCButtons
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pbEdit);
            Controls.Add(pbDelete);
            Name = "UCButtons";
            Size = new Size(245, 68);
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDelete;
        private PictureBox pbEdit;
    }
}
