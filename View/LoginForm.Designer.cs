namespace View
{
    partial class LoginForm
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
            this._panel = new System.Windows.Forms.Panel();
            this._btnEsci = new System.Windows.Forms.Button();
            this._btnLogin = new System.Windows.Forms.Button();
            this._label2 = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._txtPass = new System.Windows.Forms.TextBox();
            this._txtUser = new System.Windows.Forms.TextBox();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._btnEsci);
            this._panel.Controls.Add(this._btnLogin);
            this._panel.Controls.Add(this._label2);
            this._panel.Controls.Add(this._label1);
            this._panel.Controls.Add(this._txtPass);
            this._panel.Controls.Add(this._txtUser);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(230, 96);
            this._panel.TabIndex = 0;
            // 
            // _btnEsci
            // 
            this._btnEsci.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnEsci.Location = new System.Drawing.Point(148, 64);
            this._btnEsci.Name = "_btnEsci";
            this._btnEsci.Size = new System.Drawing.Size(70, 23);
            this._btnEsci.TabIndex = 5;
            this._btnEsci.Text = "Esci";
            this._btnEsci.UseVisualStyleBackColor = true;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(72, 64);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(70, 23);
            this._btnLogin.TabIndex = 1;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Location = new System.Drawing.Point(12, 41);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(53, 13);
            this._label2.TabIndex = 4;
            this._label2.Text = "Password";
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(12, 15);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(55, 13);
            this._label1.TabIndex = 3;
            this._label1.Text = "Username";
            // 
            // _txtPass
            // 
            this._txtPass.Location = new System.Drawing.Point(73, 38);
            this._txtPass.Name = "_txtPass";
            this._txtPass.Size = new System.Drawing.Size(145, 20);
            this._txtPass.TabIndex = 2;
            // 
            // _txtUser
            // 
            this._txtUser.Location = new System.Drawing.Point(73, 12);
            this._txtUser.Name = "_txtUser";
            this._txtUser.Size = new System.Drawing.Size(145, 20);
            this._txtUser.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AcceptButton = this._btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnEsci;
            this.ClientSize = new System.Drawing.Size(230, 96);
            this.Controls.Add(this._panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.TextBox _txtPass;
        private System.Windows.Forms.TextBox _txtUser;
        private System.Windows.Forms.Button _btnEsci;
        private System.Windows.Forms.Button _btnLogin;
    }
}