using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class GridViewForm : Form, IGridViewForm
    {
        public GridViewForm()
        {
            InitializeComponent();
            FormClosing += OnClose;
        }

        public object DataSource { get { return _dataGridView.DataSource; } set { _dataGridView.DataSource = value; } }

        public DataGridView DataGridView { get { return _dataGridView; } }

        public virtual void AddFilter(Control filterControl)
        {
            _filtersFlowLayoutPanel.Controls.Add(filterControl);
        }

        private void OnClose(object sender, EventArgs e)
        {
            FormClosingEventArgs args = e as FormClosingEventArgs;
            if (args == null)
                throw new ArgumentException("Wrong EventArgs");
            if (args.CloseReason == CloseReason.FormOwnerClosing) //if closed by application
            {
                this.Close();
            }
            if (args.CloseReason == CloseReason.UserClosing) //if closed by user
            {
                args.Cancel = true;
                this.Hide();
            }
        }

        public void SetFilter(Control panel)
        {
            _filtersFlowLayoutPanel.Controls.Clear();
            _filtersFlowLayoutPanel.Controls.Add(panel);
            Width = panel.Width + 50;
        }

        public FlowLayoutPanel FlowLayoytPanel { get { return _filtersFlowLayoutPanel; } }
    }
}
