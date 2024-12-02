namespace TanamAja.App.View
{
    partial class DashboardCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tempatDashboardCustomer = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnBeranda = new Button();
            btnProfilCustomer = new Button();
            tempatDashboardCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tempatDashboardCustomer
            // 
            tempatDashboardCustomer.BackgroundImage = Properties.Resources.CUSTOMER_Beranda_3;
            tempatDashboardCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            tempatDashboardCustomer.Controls.Add(button2);
            tempatDashboardCustomer.Controls.Add(button1);
            tempatDashboardCustomer.Controls.Add(btnBeranda);
            tempatDashboardCustomer.Controls.Add(btnProfilCustomer);
            tempatDashboardCustomer.Location = new Point(188, 84);
            tempatDashboardCustomer.Name = "tempatDashboardCustomer";
            tempatDashboardCustomer.Size = new Size(1526, 864);
            tempatDashboardCustomer.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(187, 138, 82);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Source Han Sans CN Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button2.Image = Properties.Resources.Ikon_Riwayat__1_;
            button2.Location = new Point(1020, 80);
            button2.Name = "button2";
            button2.Size = new Size(290, 61);
            button2.TabIndex = 3;
            button2.Text = "   Riwayat Pesanan";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 138, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Source Han Sans CN Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.IkonPesanan__2_;
            button1.Location = new Point(624, 81);
            button1.Name = "button1";
            button1.Size = new Size(290, 60);
            button1.TabIndex = 2;
            button1.Text = "     Pesanan";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.FromArgb(187, 138, 82);
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Source Han Sans CN Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnBeranda.Image = Properties.Resources.IkonKatalog__1_;
            btnBeranda.Location = new Point(239, 83);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(290, 60);
            btnBeranda.TabIndex = 1;
            btnBeranda.Text = "     Beranda";
            btnBeranda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeranda.UseVisualStyleBackColor = false;
            // 
            // btnProfilCustomer
            // 
            btnProfilCustomer.BackColor = Color.FromArgb(232, 236, 215);
            btnProfilCustomer.FlatAppearance.BorderSize = 0;
            btnProfilCustomer.FlatStyle = FlatStyle.Flat;
            btnProfilCustomer.Image = Properties.Resources.IkonProfilUser__1_;
            btnProfilCustomer.Location = new Point(1332, 50);
            btnProfilCustomer.Name = "btnProfilCustomer";
            btnProfilCustomer.Size = new Size(151, 72);
            btnProfilCustomer.TabIndex = 0;
            btnProfilCustomer.UseVisualStyleBackColor = false;
            // 
            // DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 236, 215);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempatDashboardCustomer);
            Name = "DashboardCustomer";
            Text = "Dashboard";
            tempatDashboardCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel tempatDashboardCustomer;
        private Button btnProfilCustomer;
        private Button btnBeranda;
        private Button button2;
        private Button button1;
    }
}