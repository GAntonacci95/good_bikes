namespace View
{
    partial class ElementoNoleggioUpperPanel
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
            this.FiltriGroupBox = new System.Windows.Forms.GroupBox();
            this._elementoUpperPanel = new View.ElementoUpperPanel();
            this.agevolazioniGroupBox = new System.Windows.Forms.GroupBox();
            this._agevolazioniNormaliComboBox = new System.Windows.Forms.ComboBox();
            this.FiltriGroupBox.SuspendLayout();
            this.agevolazioniGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltriGroupBox
            // 
            this.FiltriGroupBox.Controls.Add(this._elementoUpperPanel);
            this.FiltriGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FiltriGroupBox.Name = "FiltriGroupBox";
            this.FiltriGroupBox.Size = new System.Drawing.Size(660, 62);
            this.FiltriGroupBox.TabIndex = 1;
            this.FiltriGroupBox.TabStop = false;
            this.FiltriGroupBox.Text = "Filtri:";
            // 
            // _elementoUpperPanel
            // 
            this._elementoUpperPanel.DataSource = null;
            this._elementoUpperPanel.Location = new System.Drawing.Point(7, 19);
            this._elementoUpperPanel.Name = "_elementoUpperPanel";
            this._elementoUpperPanel.Size = new System.Drawing.Size(647, 33);
            this._elementoUpperPanel.TabIndex = 0;
            // 
            // agevolazioniGroupBox
            // 
            this.agevolazioniGroupBox.Controls.Add(this._agevolazioniNormaliComboBox);
            this.agevolazioniGroupBox.Location = new System.Drawing.Point(669, 3);
            this.agevolazioniGroupBox.Name = "agevolazioniGroupBox";
            this.agevolazioniGroupBox.Size = new System.Drawing.Size(239, 62);
            this.agevolazioniGroupBox.TabIndex = 2;
            this.agevolazioniGroupBox.TabStop = false;
            this.agevolazioniGroupBox.Text = "Agevolazioni da applicare:";
            // 
            // _agevolazioniNormaliComboBox
            // 
            this._agevolazioniNormaliComboBox.FormattingEnabled = true;
            this._agevolazioniNormaliComboBox.Location = new System.Drawing.Point(29, 19);
            this._agevolazioniNormaliComboBox.Name = "_agevolazioniNormaliComboBox";
            this._agevolazioniNormaliComboBox.Size = new System.Drawing.Size(151, 21);
            this._agevolazioniNormaliComboBox.TabIndex = 3;
            // 
            // ElementoNoleggioUpperPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.agevolazioniGroupBox);
            this.Controls.Add(this.FiltriGroupBox);
            this.Name = "ElementoNoleggioUpperPanel";
            this.Size = new System.Drawing.Size(911, 78);
            this.FiltriGroupBox.ResumeLayout(false);
            this.agevolazioniGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private View.ElementoUpperPanel _elementoUpperPanel;
        private System.Windows.Forms.GroupBox FiltriGroupBox;
        private System.Windows.Forms.GroupBox agevolazioniGroupBox;
        private System.Windows.Forms.ComboBox _agevolazioniNormaliComboBox;
    }
}
