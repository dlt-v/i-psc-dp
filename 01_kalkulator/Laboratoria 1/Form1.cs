namespace Laboratoria_1
{
    public partial class Form1 : Form
    {
        DoubleManager Checker1, Checker2;
        public Form1()
        {
            InitializeComponent();
            CbOperations.SelectedIndex = 0;
            Checker1 = new DoubleManager(0, TbValue1, NotifyChecker);
            Checker2 = new DoubleManager(0, TbValue2, NotifyChecker);
        }

        private void BtCalculate_Click(object sender, EventArgs e)
        {
            string operation = CbOperations.SelectedItem.ToString();
            if (operation == "+")
            {
                TbResult.Text = (Checker1.value + Checker2.value).ToString();
            } else if (operation == "-")
            {
                
            }
        }

        private void NotifyChecker()
        {
            BtCalculate.Enabled = TbValue1.BackColor == SystemColors.Window && TbValue2.BackColor == SystemColors.Window;
        }

    }
}