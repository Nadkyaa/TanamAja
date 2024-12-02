using Microsoft.VisualBasic.Logging;
using TanamAja.App.View;

namespace TanamAja
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            formLogin Login = new formLogin();
            Login.Show();
            this.Hide();
        }
    }
}
