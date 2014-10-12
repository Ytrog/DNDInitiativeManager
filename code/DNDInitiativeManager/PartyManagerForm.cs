using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNDInitiativeManager
{
    public partial class PartyManagerForm : Form
    {
        public PartyManagerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to save the current party?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PartyLoader.Save(PartyLoader.Party);
            }
        }

        private void PartyManagerForm_Load(object sender, EventArgs e)
        {
            dgParty.DataSource = PartyLoader.Load();
        }
    }
}
