using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoria_1
{
    delegate void NotifyLogic();
    internal class DoubleManager
    {
        private double Value = 0;
        private TextBox TbValue;
        private NotifyLogic Notify;
        public double value { get { return Value; } }

        public DoubleManager(double Value, TextBox TbValue, NotifyLogic Notify)
        {
            this.Value = Value;
            this.TbValue = TbValue;
            this.Notify = Notify;
            TbValue.Text = Value.ToString();
            TbValue.TextChanged += TextChanged;
        }
        private void TextChanged(object sender, EventArgs e)
        {
            TbValue.BackColor = (double.TryParse(TbValue.Text, out Value) ? SystemColors.Window : Color.Yellow);
            Notify();
        }

    }
}
