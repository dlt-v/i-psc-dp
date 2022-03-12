using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class SportsmenCommandMainForm : Form
    {
        public SportsmenCommandMainForm()
        {
            InitializeComponent();
            LbCommands.Items.Add(new SportsmenCommandJump());
            LbCommands.Items.Add(new SportsmenCommandRun());
            LbCommands.Items.Add(new SportsmenCommandSwim());
            LbCommands.SelectedIndex = 0;

        }

        private void BtnAddToTrening_Click(object sender, EventArgs e)
        {
            SportsmenCommand cmd = LbCommands.SelectedItem as SportsmenCommand;
            LbTrening.Items.Add(cmd);
            LbTrening.SelectedIndex = LbTrening.Items.Count-1;

        }

        private void BtnRemoveFromTrening_Click(object sender, EventArgs e)
        {
            int index = LbTrening.SelectedIndex;
            LbTrening.Items.RemoveAt(index);
            LbTrening.SelectedIndex = Math.Min(LbTrening.Items.Count - 1, index);
        }

        private void BtnAddToCommands_Click(object sender, EventArgs e)
        {
            List<SportsmenCommand> cmds = new List<SportsmenCommand>();
            for(int i = 0; i < LbTrening.Items.Count; ++i)
            {
                cmds.Add(LbTrening.Items[i] as SportsmenCommand);
            }
            string name = TbTreningName.Text.Trim();
            SportsmenCommand trening = new SportsmenCommandTreining(name, cmds);
            LbCommands.Items.Add(trening);
            LbCommands.SelectedIndex = LbCommands.Items.Count - 1;
        }
    }
}
