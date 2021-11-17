using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class AutoDataGridView : DataGridView
    {
        public AutoDataGridView()
            : base()
        {
            base.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            base.Dock = System.Windows.Forms.DockStyle.Fill;
            base.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            base.AllowUserToAddRows = false;
            base.AllowUserToDeleteRows = false;
            base.ReadOnly = true;

            base.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            base.BorderStyle = System.Windows.Forms.BorderStyle.None;

            base.Name = "_dataGridView";
            base.Location = new System.Drawing.Point(3, 3);
            base.Size = new System.Drawing.Size(572, 413);

            base.TabIndex = 0;
        }
    }
}
