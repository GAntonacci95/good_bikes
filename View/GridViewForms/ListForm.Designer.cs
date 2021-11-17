namespace View
{
    partial class ListForm
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
            this._editButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _editButton
            // 
            this._editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._editButton.Location = new System.Drawing.Point(524, 285);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(75, 25);
            this._editButton.TabIndex = 5;
            this._editButton.Tag = "Edit";
            this._editButton.Text = "Edit";
            this._editButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deleteButton.ForeColor = System.Drawing.Color.Red;
            this._deleteButton.Location = new System.Drawing.Point(605, 285);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(30, 25);
            this._deleteButton.TabIndex = 4;
            this._deleteButton.Tag = "EliminaElementoDalSistema";
            this._deleteButton.Text = "x";
            this._deleteButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addButton.Location = new System.Drawing.Point(641, 285);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(30, 25);
            this._addButton.TabIndex = 3;
            this._addButton.Tag = "AggiungiElementoAlSistema";
            this._addButton.Text = "+";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _OKbutton
            // 
            this._OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._OKbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._OKbutton.Location = new System.Drawing.Point(443, 285);
            this._OKbutton.Name = "_OKbutton";
            this._OKbutton.Size = new System.Drawing.Size(75, 25);
            this._OKbutton.TabIndex = 9;
            this._OKbutton.Tag = "Ok";
            this._OKbutton.Text = "OK";
            this._OKbutton.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._OKbutton;
            this.ClientSize = new System.Drawing.Size(683, 316);
            this.Controls.Add(this._OKbutton);
            this.Controls.Add(this._editButton);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._addButton);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Controls.SetChildIndex(this._addButton, 0);
            this.Controls.SetChildIndex(this._deleteButton, 0);
            this.Controls.SetChildIndex(this._editButton, 0);
            this.Controls.SetChildIndex(this._OKbutton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _OKbutton;
    }
}