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
    public partial class FormGroupProduct : Form
    {
        public FormGroupProduct()
        {
            InitializeComponent();
            ShowProduct();
            comboBoxType.SelectedIndex = 0;
        }
        void ShowProduct()
        {
            listViewProduct.Items.Clear();
            foreach (GroupSet groupSet in Program.ws.GroupSet)
            {
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                          groupSet.Id.ToString(), groupSet.Name, groupSet.Price.ToString(), groupSet.Type.ToString()
                    });
                    item.Tag = groupSet;
                    listViewProduct.Items.Add(item);
                }
                listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GroupSet groupSet = new GroupSet();
            groupSet.Name = textBoxName.Text;
            groupSet.Price = Convert.ToInt64(textBoxPrice.Text);
            if (comboBoxType.SelectedIndex == 0)
            {
                groupSet.Type = 0;
                groupSet.Name = textBoxName.Text;
                groupSet.Price = Convert.ToInt64(textBoxPrice.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                groupSet.Type = 1;
                groupSet.Name = textBoxName.Text;
                groupSet.Price = Convert.ToInt64(textBoxPrice.Text);
            }
            else
            {
                groupSet.Type = 2;
            }
            Program.ws.GroupSet.Add(groupSet);
            Program.ws.SaveChanges();
            ShowProduct();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    GroupSet groupSet = listViewProduct.SelectedItems[0].Tag as GroupSet;
                    groupSet.Name = textBoxName.Text;
                    groupSet.Price = Convert.ToInt64(textBoxPrice.Text);

                    Program.ws.SaveChanges();
                    ShowProduct();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    GroupSet groupSet = listViewProduct.SelectedItems[0].Tag as GroupSet;
                    groupSet.Name = textBoxName.Text;
                    groupSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    Program.ws.SaveChanges();
                    ShowProduct();
                }
            }
            else
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    GroupSet groupSet = listViewProduct.SelectedItems[0].Tag as GroupSet;
                    groupSet.Name = textBoxName.Text;
                    groupSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    Program.ws.SaveChanges();
                    ShowProduct();
                }
            }
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                GroupSet groupSet = listViewProduct.SelectedItems[0].Tag as GroupSet;
                textBoxName.Text = groupSet.Name.ToString();
                textBoxPrice.Text = groupSet.Price.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewProduct.SelectedItems.Count == 1)
                    {
                        GroupSet demand = listViewProduct.SelectedItems[0].Tag as GroupSet;
                        Program.ws.GroupSet.Remove(demand);
                        Program.ws.SaveChanges();
                        ShowProduct();
                    }
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewProduct.SelectedItems.Count == 1)
                    {
                        GroupSet demand = listViewProduct.SelectedItems[0].Tag as GroupSet;
                        Program.ws.GroupSet.Remove(demand);
                        Program.ws.SaveChanges();
                        ShowProduct();
                    }
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                }
                else
                {
                    if (listViewProduct.SelectedItems.Count == 1)
                    {
                        GroupSet demand = listViewProduct.SelectedItems[0].Tag as GroupSet;
                        Program.ws.GroupSet.Remove(demand);
                        Program.ws.SaveChanges();
                        ShowProduct();
                    }
                    textBoxName.Text = "";
                    textBoxPrice.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

