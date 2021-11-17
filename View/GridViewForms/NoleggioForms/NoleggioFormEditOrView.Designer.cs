namespace View
{
    partial class NoleggioFormEditOrView
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
            this._mainPanel = new System.Windows.Forms.Panel();
            this._annullaButton = new System.Windows.Forms.Button();
            this._concludiNoleggioButton = new System.Windows.Forms.Button();
            this._prezzoTotaleLabel = new System.Windows.Forms.Label();
            this._elementiGroupBox = new System.Windows.Forms.GroupBox();
            this.elementGroupBoxesTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this._elementiNoleggioDataGridView = new System.Windows.Forms.DataGridView();
            this._aggiungiAgevolazioneEccezionaleButton = new System.Windows.Forms.Button();
            this._durataGroupBox = new System.Windows.Forms.GroupBox();
            this._durataLabel = new System.Windows.Forms.Label();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this._datiClienteLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._prezzoSingoloElementoStatus = new System.Windows.Forms.Label();
            this._mainPanel.SuspendLayout();
            this._elementiGroupBox.SuspendLayout();
            this.elementGroupBoxesTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._elementiNoleggioDataGridView)).BeginInit();
            this._durataGroupBox.SuspendLayout();
            this.clienteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainPanel.Controls.Add(this._annullaButton);
            this._mainPanel.Controls.Add(this._concludiNoleggioButton);
            this._mainPanel.Controls.Add(this._prezzoTotaleLabel);
            this._mainPanel.Controls.Add(this._elementiGroupBox);
            this._mainPanel.Controls.Add(this._durataGroupBox);
            this._mainPanel.Controls.Add(this.clienteGroupBox);
            this._mainPanel.Location = new System.Drawing.Point(4, 20);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(733, 543);
            this._mainPanel.TabIndex = 2;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(637, 509);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 9;
            this._annullaButton.Text = "ANNULLA";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _concludiNoleggioButton
            // 
            this._concludiNoleggioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._concludiNoleggioButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._concludiNoleggioButton.Location = new System.Drawing.Point(493, 509);
            this._concludiNoleggioButton.Name = "_concludiNoleggioButton";
            this._concludiNoleggioButton.Size = new System.Drawing.Size(138, 23);
            this._concludiNoleggioButton.TabIndex = 8;
            this._concludiNoleggioButton.Text = "CONCLUDI NOLEGGIO";
            this._concludiNoleggioButton.UseVisualStyleBackColor = true;
            // 
            // _prezzoTotaleLabel
            // 
            this._prezzoTotaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._prezzoTotaleLabel.AutoSize = true;
            this._prezzoTotaleLabel.Location = new System.Drawing.Point(43, 519);
            this._prezzoTotaleLabel.Name = "_prezzoTotaleLabel";
            this._prezzoTotaleLabel.Size = new System.Drawing.Size(0, 13);
            this._prezzoTotaleLabel.TabIndex = 6;
            // 
            // _elementiGroupBox
            // 
            this._elementiGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._elementiGroupBox.Controls.Add(this.elementGroupBoxesTablePanel);
            this._elementiGroupBox.Controls.Add(this._aggiungiAgevolazioneEccezionaleButton);
            this._elementiGroupBox.Location = new System.Drawing.Point(1, 225);
            this._elementiGroupBox.Name = "_elementiGroupBox";
            this._elementiGroupBox.Size = new System.Drawing.Size(721, 283);
            this._elementiGroupBox.TabIndex = 2;
            this._elementiGroupBox.TabStop = false;
            this._elementiGroupBox.Text = "Elementi del noleggio";
            // 
            // elementGroupBoxesTablePanel
            // 
            this.elementGroupBoxesTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementGroupBoxesTablePanel.AutoScroll = true;
            this.elementGroupBoxesTablePanel.ColumnCount = 1;
            this.elementGroupBoxesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.elementGroupBoxesTablePanel.Controls.Add(this._elementiNoleggioDataGridView, 0, 1);
            this.elementGroupBoxesTablePanel.Location = new System.Drawing.Point(3, 16);
            this.elementGroupBoxesTablePanel.Name = "elementGroupBoxesTablePanel";
            this.elementGroupBoxesTablePanel.RowCount = 2;
            this.elementGroupBoxesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.elementGroupBoxesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.elementGroupBoxesTablePanel.Size = new System.Drawing.Size(715, 232);
            this.elementGroupBoxesTablePanel.TabIndex = 2;
            // 
            // _elementiNoleggioDataGridView
            // 
            this._elementiNoleggioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._elementiNoleggioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._elementiNoleggioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._elementiNoleggioDataGridView.Location = new System.Drawing.Point(3, 3);
            this._elementiNoleggioDataGridView.Name = "_elementiNoleggioDataGridView";
            this._elementiNoleggioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._elementiNoleggioDataGridView.Size = new System.Drawing.Size(709, 335);
            this._elementiNoleggioDataGridView.TabIndex = 0;
            // 
            // _aggiungiAgevolazioneEccezionaleButton
            // 
            this._aggiungiAgevolazioneEccezionaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._aggiungiAgevolazioneEccezionaleButton.Location = new System.Drawing.Point(522, 254);
            this._aggiungiAgevolazioneEccezionaleButton.Name = "_aggiungiAgevolazioneEccezionaleButton";
            this._aggiungiAgevolazioneEccezionaleButton.Size = new System.Drawing.Size(193, 23);
            this._aggiungiAgevolazioneEccezionaleButton.TabIndex = 0;
            this._aggiungiAgevolazioneEccezionaleButton.Tag = "AggiungiAgevolazioneEccezionale";
            this._aggiungiAgevolazioneEccezionaleButton.Text = "Aggiungi agevolazione eccezionale";
            this._aggiungiAgevolazioneEccezionaleButton.UseVisualStyleBackColor = true;
            // 
            // _durataGroupBox
            // 
            this._durataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._durataGroupBox.Controls.Add(this._durataLabel);
            this._durataGroupBox.Location = new System.Drawing.Point(1, 169);
            this._durataGroupBox.Name = "_durataGroupBox";
            this._durataGroupBox.Size = new System.Drawing.Size(721, 55);
            this._durataGroupBox.TabIndex = 1;
            this._durataGroupBox.TabStop = false;
            this._durataGroupBox.Text = "Durata noleggio";
            // 
            // _durataLabel
            // 
            this._durataLabel.AutoSize = true;
            this._durataLabel.Location = new System.Drawing.Point(7, 25);
            this._durataLabel.Name = "_durataLabel";
            this._durataLabel.Size = new System.Drawing.Size(0, 13);
            this._durataLabel.TabIndex = 6;
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteGroupBox.Controls.Add(this._datiClienteLayoutPanel);
            this.clienteGroupBox.Location = new System.Drawing.Point(3, 3);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(722, 160);
            this.clienteGroupBox.TabIndex = 0;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Dati Cliente";
            // 
            // _datiClienteLayoutPanel
            // 
            this._datiClienteLayoutPanel.AutoScroll = true;
            this._datiClienteLayoutPanel.ColumnCount = 2;
            this._datiClienteLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._datiClienteLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._datiClienteLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._datiClienteLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this._datiClienteLayoutPanel.Name = "_datiClienteLayoutPanel";
            this._datiClienteLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this._datiClienteLayoutPanel.RowCount = 1;
            this._datiClienteLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._datiClienteLayoutPanel.Size = new System.Drawing.Size(716, 141);
            this._datiClienteLayoutPanel.TabIndex = 0;
            // 
            // _prezzoSingoloElementoStatus
            // 
            this._prezzoSingoloElementoStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._prezzoSingoloElementoStatus.AutoSize = true;
            this._prezzoSingoloElementoStatus.Location = new System.Drawing.Point(11, 570);
            this._prezzoSingoloElementoStatus.Name = "_prezzoSingoloElementoStatus";
            this._prezzoSingoloElementoStatus.Size = new System.Drawing.Size(0, 13);
            this._prezzoSingoloElementoStatus.TabIndex = 3;
            // 
            // NoleggioFormEditOrView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 584);
            this.Controls.Add(this._prezzoSingoloElementoStatus);
            this.Controls.Add(this._mainPanel);
            this.Name = "NoleggioFormEditOrView";
            this.Text = "Gestione Noleggio";
            this._mainPanel.ResumeLayout(false);
            this._mainPanel.PerformLayout();
            this._elementiGroupBox.ResumeLayout(false);
            this.elementGroupBoxesTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._elementiNoleggioDataGridView)).EndInit();
            this._durataGroupBox.ResumeLayout(false);
            this._durataGroupBox.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Button _concludiNoleggioButton;
        private System.Windows.Forms.Label _prezzoTotaleLabel;
        private System.Windows.Forms.GroupBox _elementiGroupBox;
        private System.Windows.Forms.TableLayoutPanel elementGroupBoxesTablePanel;
        private System.Windows.Forms.DataGridView _elementiNoleggioDataGridView;
        private System.Windows.Forms.Button _aggiungiAgevolazioneEccezionaleButton;
        private System.Windows.Forms.GroupBox _durataGroupBox;
        private System.Windows.Forms.Label _durataLabel;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.Label _prezzoSingoloElementoStatus;
        private System.Windows.Forms.TableLayoutPanel _datiClienteLayoutPanel;
    }
}