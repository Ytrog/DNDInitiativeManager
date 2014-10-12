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
    public partial class MainForm : Form
    {

        private Initiative.InitiativeDataTable _initiative;
        private const string _sort = "Initiative desc, Modifier desc";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadParty();
        }

        private void LoadParty()
        {
            var party = PartyLoader.Load();

            _initiative = new Initiative.InitiativeDataTable();

            foreach (Initiative.PartyRow partyMember in party.Rows)
            {
                _initiative.AddInitiativeRow(partyMember.Name, 0, partyMember.Modifier, InitiativeType.PartyMember.ToString());
            }

            dgInitiative.DataSource = _initiative.DefaultView;
            _initiative.DefaultView.Sort = _sort;
        }

        private void newSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to re-initialize the table?", "Re-initialize table?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                LoadParty(); 
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartyManagerForm partyManagerForm = new PartyManagerForm();
            partyManagerForm.ShowDialog(this);
            SyncParty();
        }

        private void SyncParty()
        {
            // sync initiative
            var filteredInitiative = _initiative.Where(i => i.Type.Equals(InitiativeType.PartyMember.ToString()));
            var party = PartyLoader.Party;

            foreach (var item in filteredInitiative)
            {
                item.Modifier = party.Single(p => p.Name.Trim().Equals(item.Name.Trim())).Modifier;
            }

            // sync new members
            var newMembers = party.Where(p => !filteredInitiative.Select(i => i.Name.Trim()).Contains(p.Name.Trim()));
            foreach (var member in newMembers)
            {
                _initiative.AddInitiativeRow(member.Name, 0, member.Modifier, InitiativeType.PartyMember.ToString());
            }
        }

        private void SortTable()
        {
            _initiative.DefaultView.Sort = _sort;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void dgInitiative_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            var row =  (Initiative.InitiativeRow) _initiative.Rows[index];
            string rowType = row.Type;
            if (rowType.Equals(InitiativeType.PartyMember.ToString()))
            {
                MessageBox.Show(this, "Please remove a party member through the party manager", "You tried to remove a party member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
