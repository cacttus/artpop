namespace ArtPop
{
    partial class ExerciseTimer
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
            this._lblClocko = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblClocko
            // 
            this._lblClocko.AutoSize = true;
            this._lblClocko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._lblClocko.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClocko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._lblClocko.Location = new System.Drawing.Point(2, 0);
            this._lblClocko.Name = "_lblClocko";
            this._lblClocko.Size = new System.Drawing.Size(52, 27);
            this._lblClocko.TabIndex = 0;
            this._lblClocko.Text = "0:0:00";
            this._lblClocko.SizeChanged += new System.EventHandler(this._lblClocko_SizeChanged);
            this._lblClocko.Click += new System.EventHandler(this._lblClocko_Click);
            // 
            // ExerciseTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblClocko);
            this.Name = "ExerciseTimer";
            this.Size = new System.Drawing.Size(57, 26);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ExerciseTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblClocko;
    }
}
