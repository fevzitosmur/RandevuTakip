using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazerEpilasyonTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            // Müşteri bilgilerini al
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Veritabanına bağlan ve kaydet
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gokku\source\repos\LazerEpilasyonTakip\LazerEpilasyonTakip\LaserCenterDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Customers (Name, Phone, Email, Package) VALUES (@Name, @Phone, @Email, @Package)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Package", "Kemer Üstü"); // Sabit paket adı

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Müşteri başarıyla eklendi.");
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            // Müşteri başarıyla eklenince ComboBox'ı güncelle
            LoadCustomers();


        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            // Seçilen müşteri ve paket
            if (cmbCustomers.SelectedItem == null || cmbPackages.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri ve paket seçiniz.");
                return;
            }

            // Seçilen müşteri ID'sini almak
            int customerId = ((KeyValuePair<int, string>)cmbCustomers.SelectedItem).Key;  // Müşteri ID

            // Seçilen paket ID'sini almak
            int packageId = ((KeyValuePair<int, string>)cmbPackages.SelectedItem).Key;  // Paket ID

            DateTime appointmentDate = dtpAppointmentDate.Value;

            // Veritabanına bağlan ve kaydet
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gokku\source\repos\LazerEpilasyonTakip\LazerEpilasyonTakip\LaserCenterDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Appointments (CustomerID, AppointmentDate, PackageID) VALUES (@CustomerId, @AppointmentDate, @PackageID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@PackageID", packageId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Randevu başarıyla eklendi.");
        }



        private void btnCheckAppointments_Click(object sender, EventArgs e)
        {
            listBoxNotifications.Items.Clear();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gokku\source\repos\LazerEpilasyonTakip\LazerEpilasyonTakip\LaserCenterDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT c.Name, a.AppointmentDate
FROM Appointments a
JOIN Customers c ON a.CustomerID = c.CustomerID
WHERE DATEDIFF(DAY, GETDATE(), a.AppointmentDate) <= 5"; // 5 gün içinde yaklaşan randevular

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customerName = reader["Name"].ToString();
                        DateTime appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                        listBoxNotifications.Items.Add($"{customerName} - {appointmentDate:dd/MM/yyyy}");
                    }
                }
            }

        }






        private void Form1_Load(object sender, EventArgs e)
        {
            // Müşteri listesini yükleme
            LoadCustomers();

            // Paketleri manuel olarak ekleme
            cmbPackages.Items.Add(new KeyValuePair<int, string>(1, "Tüm Vücut"));
            cmbPackages.Items.Add(new KeyValuePair<int, string>(2, "Kemer Üstü"));

            cmbPackages.DisplayMember = "Value";  // Görüntüleme ismi
            cmbPackages.ValueMember = "Key";  // Seçilen değer
        }

        private void LoadCustomers()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gokku\source\repos\LazerEpilasyonTakip\LazerEpilasyonTakip\LaserCenterDB.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CustomerID, Name FROM Customers";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbCustomers.Items.Clear();
                        while (reader.Read())
                        {
                            cmbCustomers.Items.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["CustomerID"]),
                                reader["Name"].ToString()));
                        }
                    }
                }
            }

            cmbCustomers.DisplayMember = "Value";  // Görüntüleme ismi
            cmbCustomers.ValueMember = "Key";  // Seçilen değer
        }

        private void LoadPackages()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gokku\source\repos\LazerEpilasyonTakip\LazerEpilasyonTakip\LaserCenterDB.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PackageID, PackageName FROM Packages"; // Paket adlarını alıyoruz

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbPackages.Items.Clear(); // Mevcut paketleri temizle
                        while (reader.Read())
                        {
                            // Paketleri ComboBox'a ekle
                            cmbPackages.Items.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["PackageID"]),
                                reader["PackageName"].ToString()));
                        }
                    }
                }
            }

            cmbPackages.DisplayMember = "Value";  // Görüntüleme ismi
            cmbPackages.ValueMember = "Key";  // Seçilen değer
        }


    }
}
