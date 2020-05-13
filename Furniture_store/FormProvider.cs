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
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
            ShowProvider();
            ShowProduct();
        }
        void ShowProvider()
        {
            listViewProvider.Items.Clear();
            foreach (Provider provider in Program.ws.Provider)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                      provider.Id.ToString(), provider.Name, provider.Address, provider.Email, provider.Phone, provider.IdProduct.ToString()
                });
                item.Tag = provider;
                listViewProvider.Items.Add(item);

            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowProduct()
        {
            comboBoxIdProduct.Items.Clear();
            foreach (GroupSet productsSet in Program.ws.GroupSet)
            {
                string[] item = { productsSet.Id.ToString() + ".", productsSet.Name };
                comboBoxIdProduct.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdProduct.SelectedItem != null)
            {
                Provider provider = new Provider();
                provider.Name = textBoxName.Text;
                provider.Address = textBoxAddress.Text;
                provider.Email = textBoxEmail.Text;
                provider.Phone = textBoxPhone.Text;
                provider.IdProduct = Convert.ToInt32(comboBoxIdProduct.SelectedItem.ToString().Split('.')[0]);
                Program.ws.Provider.Add(provider);
                Program.ws.SaveChanges();
                ShowProvider();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                Provider provider = listViewProvider.SelectedItems[0].Tag as Provider;
                provider.Name = textBoxName.Text;
                provider.Address = textBoxAddress.Text;
                provider.Email = textBoxEmail.Text;
                provider.Phone = textBoxPhone.Text;
                Program.ws.SaveChanges();
                ShowProvider();
            }
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                Provider provider = listViewProvider.SelectedItems[0].Tag as Provider;
                textBoxName.Text = provider.Name;
                textBoxAddress.Text = provider.Address;
                textBoxEmail.Text = provider.Email;
                textBoxPhone.Text = provider.Phone;
                comboBoxIdProduct.SelectedIndex = comboBoxIdProduct.FindString(provider.IdProduct.ToString());
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
                comboBoxIdProduct.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    Provider provider = listViewProvider.SelectedItems[0].Tag as Provider;
                    Program.ws.Provider.Remove(provider);
                    Program.ws.SaveChanges();
                    ShowProvider();
                }
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
                comboBoxIdProduct.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
