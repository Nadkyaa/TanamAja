using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanamAja.App.Context;
using TanamAja.App.Models;

namespace TanamAja.App.View
{
    public partial class UC_Register : UserControl
    {
        public event EventHandler LoginClicked;
        public UC_Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void klikLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validasi input data
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat objek pengguna baru
            Users newUser = new Users
            {
                username = username,
                password = password,
                role = "customer"
            };

            try
            {
                // Buat instance dari kelas C_Users
                C_Users userContext = new C_Users();

                // Panggil metode AddUsers untuk menyimpan data
                userContext.AddUsers(newUser);

                MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan form setelah berhasil registrasi
                textUsername.Clear();
                textPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
