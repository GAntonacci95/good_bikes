namespace View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AdminPanel = new System.Windows.Forms.Panel();
            this._elenchiTabControl = new System.Windows.Forms.TabControl();
            this.shortcutPanel = new System.Windows.Forms.Panel();
            this._sostituisciElementiButton = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._restituisciElementiButton = new System.Windows.Forms.Button();
            this._nuovoNoleggioButton = new System.Windows.Forms.Button();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.AdminPanel.SuspendLayout();
            this.shortcutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this._elenchiTabControl);
            this.AdminPanel.Controls.Add(this.shortcutPanel);
            this.AdminPanel.Controls.Add(this._menuStrip);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(768, 487);
            this.AdminPanel.TabIndex = 0;
            // 
            // _elenchiTabControl
            // 
            this._elenchiTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._elenchiTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._elenchiTabControl.Location = new System.Drawing.Point(170, 28);
            this._elenchiTabControl.Name = "_elenchiTabControl";
            this._elenchiTabControl.SelectedIndex = 0;
            this._elenchiTabControl.Size = new System.Drawing.Size(586, 447);
            this._elenchiTabControl.TabIndex = 5;
            // 
            // shortcutPanel
            // 
            this.shortcutPanel.Controls.Add(this._sostituisciElementiButton);
            this.shortcutPanel.Controls.Add(this._pictureBox);
            this.shortcutPanel.Controls.Add(this._restituisciElementiButton);
            this.shortcutPanel.Controls.Add(this._nuovoNoleggioButton);
            this.shortcutPanel.Location = new System.Drawing.Point(3, 28);
            this.shortcutPanel.Name = "shortcutPanel";
            this.shortcutPanel.Size = new System.Drawing.Size(161, 448);
            this.shortcutPanel.TabIndex = 4;
            // 
            // _sostituisciElementiButton
            // 
            this._sostituisciElementiButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sostituisciElementiButton.Location = new System.Drawing.Point(9, 241);
            this._sostituisciElementiButton.Name = "_sostituisciElementiButton";
            this._sostituisciElementiButton.Size = new System.Drawing.Size(146, 40);
            this._sostituisciElementiButton.TabIndex = 6;
            this._sostituisciElementiButton.Tag = "";
            this._sostituisciElementiButton.Text = "SOSTITUISCI ELEMENTI";
            this._sostituisciElementiButton.UseVisualStyleBackColor = true;
            // 
            // _pictureBox
            // 
            this._pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_pictureBox.Image")));
            this._pictureBox.Location = new System.Drawing.Point(9, 37);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(146, 115);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBox.TabIndex = 5;
            this._pictureBox.TabStop = false;
            // 
            // _restituisciElementiButton
            // 
            this._restituisciElementiButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._restituisciElementiButton.Location = new System.Drawing.Point(9, 195);
            this._restituisciElementiButton.Name = "_restituisciElementiButton";
            this._restituisciElementiButton.Size = new System.Drawing.Size(146, 40);
            this._restituisciElementiButton.TabIndex = 3;
            this._restituisciElementiButton.Tag = "";
            this._restituisciElementiButton.Text = "RESTITUISCI ELEMENTI";
            this._restituisciElementiButton.UseVisualStyleBackColor = true;
            // 
            // _nuovoNoleggioButton
            // 
            this._nuovoNoleggioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nuovoNoleggioButton.Location = new System.Drawing.Point(9, 287);
            this._nuovoNoleggioButton.Name = "_nuovoNoleggioButton";
            this._nuovoNoleggioButton.Size = new System.Drawing.Size(146, 40);
            this._nuovoNoleggioButton.TabIndex = 2;
            this._nuovoNoleggioButton.Tag = "InserisciNuovoNoleggio";
            this._nuovoNoleggioButton.Text = "NUOVO NOLEGGIO";
            this._nuovoNoleggioButton.UseVisualStyleBackColor = true;
            // 
            // _menuStrip
            // 
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(768, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 487);
            this.Controls.Add(this.AdminPanel);
            this.Name = "MainForm";
            this.Text = "GoodBikes";
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.shortcutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.Button _nuovoNoleggioButton;
        private System.Windows.Forms.Panel shortcutPanel;
        private System.Windows.Forms.Button _restituisciElementiButton;
        private System.Windows.Forms.TabControl _elenchiTabControl;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Button _sostituisciElementiButton;
    }
}