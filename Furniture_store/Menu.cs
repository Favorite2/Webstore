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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            Form formProduct = new FormGroupProduct();
            formProduct.Show();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            Form formProvider = new FormProvider();
            formProvider.Show();
        }

        private void buttonOpenProduct_Click(object sender, EventArgs e)
        {
            Form formProducts = new FormProduct();
            formProducts.Show();
        }
    }
}

