using System;

namespace View
{
    partial class ElementoUpperPanel
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this._tipoComboBox = new System.Windows.Forms.ComboBox();
            this._categoriaComboBox = new System.Windows.Forms.ComboBox();
            this._statoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _tipoComboBox
            // 
            this._tipoComboBox.FormattingEnabled = true;
            this._tipoComboBox.Location = new System.Drawing.Point(314, 3);
            this._tipoComboBox.Name = "_tipoComboBox";
            this._tipoComboBox.Size = new System.Drawing.Size(148, 21);
            this._tipoComboBox.TabIndex = 1;
            // 
            // _categoriaComboBox
            // 
            this._categoriaComboBox.FormattingEnabled = true;
            this._categoriaComboBox.Location = new System.Drawing.Point(157, 3);
            this._categoriaComboBox.Name = "_categoriaComboBox";
            this._categoriaComboBox.Size = new System.Drawing.Size(151, 21);
            this._categoriaComboBox.TabIndex = 2;
            // 
            // _statoComboBox
            // 
            this._statoComboBox.FormattingEnabled = true;
            this._statoComboBox.Location = new System.Drawing.Point(3, 3);
            this._statoComboBox.Name = "_statoComboBox";
            this._statoComboBox.Size = new System.Drawing.Size(148, 21);
            this._statoComboBox.TabIndex = 3;
            // 
            // ElementoUpperPanel
            // 
            this.Controls.Add(this._statoComboBox);
            this.Controls.Add(this._categoriaComboBox);
            this.Controls.Add(this._tipoComboBox);
            this.Name = "ElementoUpperPanel";
            this.Size = new System.Drawing.Size(465, 33);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox _tipoComboBox;
        private System.Windows.Forms.ComboBox _categoriaComboBox;
        private System.Windows.Forms.ComboBox _statoComboBox;
    }
}
