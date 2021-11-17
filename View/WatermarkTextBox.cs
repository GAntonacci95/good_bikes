using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    class WatermarkTextBox : TextBox
    {

        private String _propertyName;
        private String _waterMark;
        public String PropertyName { set { _propertyName = value; } get { return _propertyName; } }

        public WatermarkTextBox(String propertyName) : base()
        {
            _propertyName = propertyName;

            _waterMark = _propertyName.Clone() as String;
            ForeColor = System.Drawing.Color.Gray;
            Text = PropertyName;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (Text.Equals(PropertyName))
            {
                Text = "";
                ForeColor = System.Drawing.Color.Black;
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (Text.Length == 0)
            {
                ForeColor = System.Drawing.Color.Gray;
                Text = PropertyName;
            }
            base.OnLostFocus(e);
        }
    }
}
