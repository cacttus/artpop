namespace ArtPop
{
    partial class MonoEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._objStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._objStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // _objStyleManager
            // 
            this._objStyleManager.Owner = null;
            // 
            // MonoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 185);
            this.Name = "MonoEditForm";
            this.Text = "MonoEditForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MonoEditForm_Load);
            this.Shown += new System.EventHandler(this.MonoEditForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._objStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager _objStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}