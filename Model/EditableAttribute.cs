using System;

namespace Model
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EditableAttribute : Attribute
    {
        private string _label;
        private int _width = 100;
        private bool _notEditableAfterFirstTime = false;
        private string _mode = "text";

        public EditableAttribute(string label)
        {
            Label = label;
        }

        public EditableAttribute(string label, bool notEditableAfterFirstTime)
        {
            Label = label;
            _notEditableAfterFirstTime = notEditableAfterFirstTime;
        }

        public EditableAttribute(string label, string mode)
        {
            Label = label;
            _mode = mode;
        }

        public string Label
        {
            get { return _label; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("String.IsNullOrEmpty(value)");
                _label = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("value <= 0");
                _width = value;
            }
        }

        public bool NotEditableAfterFirstTime
        {
            get { return _notEditableAfterFirstTime; }
            set
            {
               _notEditableAfterFirstTime = value;
            }
        }

        public string Mode
        {
            get { return _mode; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentException("String.IsNullOrEmpty(value)");
                _mode = value;
            }
        }
    }
}
