namespace ListBoxContextMenu
{
    partial class Main
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
            this.lstPessoas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPessoas
            // 
            this.lstPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPessoas.FormattingEnabled = true;
            this.lstPessoas.Location = new System.Drawing.Point(12, 12);
            this.lstPessoas.Name = "lstPessoas";
            this.lstPessoas.Size = new System.Drawing.Size(260, 173);
            this.lstPessoas.TabIndex = 0;
            this.lstPessoas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstPessoas_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.lstPessoas);
            this.Name = "Main";
            this.Text = "Context Menu List Box";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPessoas;
    }
}

