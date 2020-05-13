using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_store
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentsSet agentsSet in Program.ws.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        agentsSet.Id.ToString(), agentsSet.FirstName, agentsSet.MiddleName, agentsSet.LastName, agentsSet.Phone, agentsSet.Email
                    });
                item.Tag = agentsSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentsSet agentSet = new AgentsSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.Phone = textBoxPhone.Text;
            agentSet.Email = textBoxEmail.Text;
            Program.ws.AgentsSet.Add(agentSet);
            Program.ws.SaveChanges();
            ShowAgent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.Phone = textBoxPhone.Text;
                agentSet.Email = textBoxEmail.Text;
                Program.ws.SaveChanges();
                ShowAgent();
            }
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxPhone.Text = agentSet.Phone;
                textBoxEmail.Text = agentSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                    Program.ws.AgentsSet.Remove(agentSet);
                    Program.ws.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
