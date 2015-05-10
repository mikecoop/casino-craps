using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoF.CasinoCraps.UserInterface
{
    public partial class SetRollForm : Form
    {
        public SetRollForm()
        {
            InitializeComponent();
        }

        public int FirstDie { get; private set; }

        public int SecondDie { get; private set; }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FirstDie = Convert.ToInt32(firstDieUpDown.Value);
            SecondDie = Convert.ToInt32(secondDieUpDown.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
