using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanamAja.App.View
{
    public partial class DashboardCustomer : Form
    {
        public DashboardCustomer()
        {
            InitializeComponent();
            UC_DashboardCustomer uC_DashboardCustomer = new UC_DashboardCustomer();
            AddUserControl(uC_DashboardCustomer);
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            // Mengatur UserControl agar mengisi panel
            userControl.Dock = DockStyle.Fill;
            tempatDashboardCustomer.Controls.Clear();
            tempatDashboardCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tempatDashboardCustomer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
