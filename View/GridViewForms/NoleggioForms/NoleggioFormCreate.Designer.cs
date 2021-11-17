namespace View
{
    partial class NoleggioFormCreate
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
            this._avviaNoleggioButton = new System.Windows.Forms.Button();
            this._prezzoTotaleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._elementiGroupBox = new System.Windows.Forms.GroupBox();
            this._removeButton = new System.Windows.Forms.Button();
            this.elementGroupBoxesTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this._elementiNoleggioDataGridView = new System.Windows.Forms.DataGridView();
            this._aggiungiElementoAlNoleggioButton = new System.Windows.Forms.Button();
            this._durataGroupBox = new System.Windows.Forms.GroupBox();
            this._datePicker = new System.Windows.Forms.DateTimePicker();
            this._timePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this._resetClienteButton = new System.Windows.Forms.Button();
            this._editingControl = new View.EditingControl();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonScegliCliente = new System.Windows.Forms.Button();
            this._tipiClientiComboBox = new System.Windows.Forms.ComboBox();
            this._statusLabel = new System.Windows.Forms.Label();
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
            this._mainPanel.Controls.Add(this._avviaNoleggioButton);
            this._mainPanel.Controls.Add(this._prezzoTotaleTextBox);
            this._mainPanel.Controls.Add(this.label8);
            this._mainPanel.Controls.Add(this._elementiGroupBox);
            this._mainPanel.Controls.Add(this._durataGroupBox);
            this._mainPanel.Controls.Add(this.clienteGroupBox);
            this._mainPanel.Location = new System.Drawing.Point(0, 12);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(733, 641);
            this._mainPanel.TabIndex = 1;
            // 
            // _annullaButton
            // 
            this._annullaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(640, 586);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(75, 23);
            this._annullaButton.TabIndex = 9;
            this._annullaButton.Text = "ANNULLA";
            this._annullaButton.UseVisualStyleBackColor = true;
            // 
            // _avviaNoleggioButton
            // 
            this._avviaNoleggioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._avviaNoleggioButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._avviaNoleggioButton.Location = new System.Drawing.Point(527, 586);
            this._avviaNoleggioButton.Name = "_avviaNoleggioButton";
            this._avviaNoleggioButton.Size = new System.Drawing.Size(107, 23);
            this._avviaNoleggioButton.TabIndex = 8;
            this._avviaNoleggioButton.Text = "AVVIA NOLEGGIO";
            this._avviaNoleggioButton.UseVisualStyleBackColor = true;
            // 
            // _prezzoTotaleTextBox
            // 
            this._prezzoTotaleTextBox.Enabled = false;
            this._prezzoTotaleTextBox.Location = new System.Drawing.Point(148, 593);
            this._prezzoTotaleTextBox.Name = "_prezzoTotaleTextBox";
            this._prezzoTotaleTextBox.ReadOnly = true;
            this._prezzoTotaleTextBox.Size = new System.Drawing.Size(100, 20);
            this._prezzoTotaleTextBox.TabIndex = 7;
            this._prezzoTotaleTextBox.Text = "0 €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "PREZZO TOTALE";
            // 
            // _elementiGroupBox
            // 
            this._elementiGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._elementiGroupBox.Controls.Add(this._removeButton);
            this._elementiGroupBox.Controls.Add(this.elementGroupBoxesTablePanel);
            this._elementiGroupBox.Controls.Add(this._aggiungiElementoAlNoleggioButton);
            this._elementiGroupBox.Location = new System.Drawing.Point(4, 266);
            this._elementiGroupBox.Name = "_elementiGroupBox";
            this._elementiGroupBox.Size = new System.Drawing.Size(721, 319);
            this._elementiGroupBox.TabIndex = 2;
            this._elementiGroupBox.TabStop = false;
            this._elementiGroupBox.Text = "Aggiunta elementi";
            // 
            // _removeButton
            // 
            this._removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removeButton.ForeColor = System.Drawing.Color.Red;
            this._removeButton.Location = new System.Drawing.Point(633, 290);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(38, 23);
            this._removeButton.TabIndex = 3;
            this._removeButton.Tag = "RimuoviElementoDalNoleggio";
            this._removeButton.Text = "X";
            this._removeButton.UseVisualStyleBackColor = true;
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
            this.elementGroupBoxesTablePanel.Size = new System.Drawing.Size(715, 268);
            this.elementGroupBoxesTablePanel.TabIndex = 2;
            // 
            // _elementiNoleggioDataGridView
            // 
            this._elementiNoleggioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._elementiNoleggioDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this._elementiNoleggioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._elementiNoleggioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._elementiNoleggioDataGridView.Location = new System.Drawing.Point(3, 3);
            this._elementiNoleggioDataGridView.Name = "_elementiNoleggioDataGridView";
            this._elementiNoleggioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._elementiNoleggioDataGridView.Size = new System.Drawing.Size(709, 335);
            this._elementiNoleggioDataGridView.TabIndex = 0;
            // 
            // _aggiungiElementoAlNoleggioButton
            // 
            this._aggiungiElementoAlNoleggioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._aggiungiElementoAlNoleggioButton.Location = new System.Drawing.Point(677, 290);
            this._aggiungiElementoAlNoleggioButton.Name = "_aggiungiElementoAlNoleggioButton";
            this._aggiungiElementoAlNoleggioButton.Size = new System.Drawing.Size(38, 23);
            this._aggiungiElementoAlNoleggioButton.TabIndex = 0;
            this._aggiungiElementoAlNoleggioButton.Tag = "AggiungiElementoAlNoleggio";
            this._aggiungiElementoAlNoleggioButton.Text = "+";
            this._aggiungiElementoAlNoleggioButton.UseVisualStyleBackColor = true;
            // 
            // _durataGroupBox
            // 
            this._durataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._durataGroupBox.Controls.Add(this._datePicker);
            this._durataGroupBox.Controls.Add(this._timePicker);
            this._durataGroupBox.Controls.Add(this.label4);
            this._durataGroupBox.Location = new System.Drawing.Point(4, 213);
            this._durataGroupBox.Name = "_durataGroupBox";
            this._durataGroupBox.Size = new System.Drawing.Size(721, 47);
            this._durataGroupBox.TabIndex = 1;
            this._durataGroupBox.TabStop = false;
            this._durataGroupBox.Text = "Durata noleggio";
            // 
            // _datePicker
            // 
            this._datePicker.Location = new System.Drawing.Point(92, 20);
            this._datePicker.Name = "_datePicker";
            this._datePicker.Size = new System.Drawing.Size(200, 20);
            this._datePicker.TabIndex = 9;
            // 
            // _timePicker
            // 
            this._timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._timePicker.Location = new System.Drawing.Point(298, 19);
            this._timePicker.Name = "_timePicker";
            this._timePicker.ShowUpDown = true;
            this._timePicker.Size = new System.Drawing.Size(108, 20);
            this._timePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rientro stimato";
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteGroupBox.Controls.Add(this._resetClienteButton);
            this.clienteGroupBox.Controls.Add(this._editingControl);
            this.clienteGroupBox.Controls.Add(this.label1);
            this.clienteGroupBox.Controls.Add(this._buttonScegliCliente);
            this.clienteGroupBox.Controls.Add(this._tipiClientiComboBox);
            this.clienteGroupBox.Location = new System.Drawing.Point(3, 3);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(722, 204);
            this.clienteGroupBox.TabIndex = 0;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Dati Cliente";
            // 
            // _resetClienteButton
            // 
            this._resetClienteButton.Location = new System.Drawing.Point(12, 119);
            this._resetClienteButton.Name = "_resetClienteButton";
            this._resetClienteButton.Size = new System.Drawing.Size(109, 23);
            this._resetClienteButton.TabIndex = 10;
            this._resetClienteButton.Text = "Reset";
            this._resetClienteButton.UseVisualStyleBackColor = true;
            // 
            // _editingControl
            // 
            this._editingControl.Location = new System.Drawing.Point(212, 17);
            this._editingControl.Name = "_editingControl";
            this._editingControl.Padding = new System.Windows.Forms.Padding(10);
            this._editingControl.Size = new System.Drawing.Size(478, 171);
            this._editingControl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scegli tipologia cliente";
            // 
            // _buttonScegliCliente
            // 
            this._buttonScegliCliente.Location = new System.Drawing.Point(12, 89);
            this._buttonScegliCliente.Name = "_buttonScegliCliente";
            this._buttonScegliCliente.Size = new System.Drawing.Size(109, 23);
            this._buttonScegliCliente.TabIndex = 7;
            this._buttonScegliCliente.Text = "Cerca cliente";
            this._buttonScegliCliente.UseVisualStyleBackColor = true;
            // 
            // _tipiClientiComboBox
            // 
            this._tipiClientiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tipiClientiComboBox.FormattingEnabled = true;
            this._tipiClientiComboBox.Location = new System.Drawing.Point(12, 46);
            this._tipiClientiComboBox.Name = "_tipiClientiComboBox";
            this._tipiClientiComboBox.Size = new System.Drawing.Size(109, 21);
            this._tipiClientiComboBox.TabIndex = 6;
            // 
            // _statusLabel
            // 
            this._statusLabel.AutoSize = true;
            this._statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._statusLabel.Location = new System.Drawing.Point(0, 663);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(35, 13);
            this._statusLabel.TabIndex = 2;
            this._statusLabel.Text = "label2";
            // 
            // NoleggioFormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 676);
            this.Controls.Add(this._statusLabel);
            this.Controls.Add(this._mainPanel);
            this.Name = "NoleggioFormCreate";
            this.Text = "Creazione Noleggio";
            this._mainPanel.ResumeLayout(false);
            this._mainPanel.PerformLayout();
            this._elementiGroupBox.ResumeLayout(false);
            this.elementGroupBoxesTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._elementiNoleggioDataGridView)).EndInit();
            this._durataGroupBox.ResumeLayout(false);
            this._durataGroupBox.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Button _annullaButton;
        private System.Windows.Forms.Button _avviaNoleggioButton;
        private System.Windows.Forms.TextBox _prezzoTotaleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox _elementiGroupBox;
        private System.Windows.Forms.TableLayoutPanel elementGroupBoxesTablePanel;
        private System.Windows.Forms.DataGridView _elementiNoleggioDataGridView;
        private System.Windows.Forms.Button _aggiungiElementoAlNoleggioButton;
        private System.Windows.Forms.GroupBox _durataGroupBox;
        private System.Windows.Forms.DateTimePicker _timePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.ComboBox _tipiClientiComboBox;
        private System.Windows.Forms.DateTimePicker _datePicker;
        private EditingControl _editingControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonScegliCliente;
        private System.Windows.Forms.Button _resetClienteButton;
        private System.Windows.Forms.Label _statusLabel;
    }
}