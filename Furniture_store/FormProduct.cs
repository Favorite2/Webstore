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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowGroupSet();
            ShowProvider();
            ShowAccounting();
        }
        void ShowAgents()
        {
            comboBoxIdAgent.Items.Clear();
            foreach (AgentsSet agentsSet in Program.ws.AgentsSet)
            {
                string[] item = { agentsSet.Id.ToString() + ".", agentsSet.FirstName, agentsSet.MiddleName, agentsSet.LastName};
                comboBoxIdAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxIdClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.ws.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName};
                comboBoxIdClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowGroupSet()
        {
            comboBoxIdProduct.Items.Clear();
            foreach (GroupSet groupSet in Program.ws.GroupSet)
            {
                string[] item = { groupSet.Id.ToString() + ".", groupSet.Name};
                comboBoxIdProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProvider()
        {
            comboBoxIdProvider.Items.Clear();
            foreach (Provider provider in Program.ws.Provider)
            {
                string[] item = { provider.Id.ToString() + ".", provider.Name};
                comboBoxIdProvider.Items.Add(string.Join(" ", item));
            }
        }
        void ShowAccounting()
        {
            listViewAccounting.Items.Clear();
            foreach (ProductSet productSet in Program.ws.ProductSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                     productSet.IdAgent.ToString(),
                     productSet.AgentsSet.LastName + " " + productSet.AgentsSet.FirstName + " " + productSet.AgentsSet.MiddleName,
                     productSet.IdClient.ToString(),
                     productSet.ClientsSet.LastName + " " + productSet.ClientsSet.FirstName + " " + productSet.ClientsSet.MiddleName,
                     productSet.IdProduct.ToString(),
                     productSet.GroupSet.Name,
                     productSet.IdProvider.ToString(),
                     productSet.Provider.Name,
                     productSet.Accounting.ToString()
                });
                item.Tag = productSet;
                listViewAccounting.Items.Add(item);
            }
            listViewAccounting.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewAccounting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewAccounting.SelectedItems[0].Tag as ProductSet;
                comboBoxIdAgent.SelectedIndex = comboBoxIdAgent.FindString(productSet.IdAgent.ToString());
                comboBoxIdClient.SelectedIndex = comboBoxIdClient.FindString(productSet.IdClient.ToString());
                comboBoxIdProduct.SelectedIndex = comboBoxIdProduct.FindString(productSet.IdProduct.ToString());
                comboBoxIdProvider.SelectedIndex = comboBoxIdProvider.FindString(productSet.IdProvider.ToString());
                textBoxAccounting.Text = productSet.Accounting.ToString();
            }
            else
            {
                comboBoxIdAgent.SelectedItem = null;
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdProduct.SelectedItem = null;
                comboBoxIdProvider.SelectedItem = null;
                textBoxAccounting.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdAgent.SelectedItem != null && comboBoxIdClient.SelectedItem != null && comboBoxIdProduct != null && comboBoxIdProvider != null)
            {
                ProductSet productSet = new ProductSet();
                productSet.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                productSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                productSet.IdProduct = Convert.ToInt32(comboBoxIdProduct.SelectedItem.ToString().Split('.')[0]);
                productSet.IdProvider = Convert.ToInt32(comboBoxIdProvider.SelectedItem.ToString().Split('.')[0]);
                productSet.Accounting = Convert.ToInt32(textBoxAccounting.Text);
                Program.ws.ProductSet.Add(productSet);
                Program.ws.SaveChanges();
                ShowAccounting();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAccounting.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewAccounting.SelectedItems[0].Tag as ProductSet;
                productSet.IdAgent = Convert.ToInt32(comboBoxIdAgent.SelectedItem.ToString().Split('.')[0]);
                productSet.IdClient = Convert.ToInt32(comboBoxIdClient.SelectedItem.ToString().Split('.')[0]);
                productSet.IdProvider = Convert.ToInt32(comboBoxIdProvider.SelectedItem.ToString().Split('.')[0]);
                productSet.IdProduct = Convert.ToInt32(comboBoxIdProduct.SelectedItem.ToString().Split('.')[0]);
                productSet.Accounting = Convert.ToInt32(textBoxAccounting.Text);
                Program.ws.SaveChanges();
                ShowAccounting();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAccounting.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewAccounting.SelectedItems[0].Tag as ProductSet;

                    Program.ws.ProductSet.Remove(productSet);
                    Program.ws.SaveChanges();
                    ShowAccounting();
                }
                comboBoxIdAgent.SelectedItem = null;
                comboBoxIdClient.SelectedItem = null;
                comboBoxIdProvider.SelectedItem = null;
                comboBoxIdProduct.SelectedItem = null;
                textBoxAccounting.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}
    

