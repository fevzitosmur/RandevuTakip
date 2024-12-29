namespace LazerEpilasyonTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grpAppointments = new System.Windows.Forms.GroupBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPackages = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.btnCheckAppointments = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCustomers.SuspendLayout();
            this.grpAppointments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomers
            // 
            this.grpCustomers.BackColor = System.Drawing.Color.Transparent;
            this.grpCustomers.Controls.Add(this.btnAddCustomer);
            this.grpCustomers.Controls.Add(this.txtEmail);
            this.grpCustomers.Controls.Add(this.lblEmail);
            this.grpCustomers.Controls.Add(this.txtPhone);
            this.grpCustomers.Controls.Add(this.lblPhone);
            this.grpCustomers.Controls.Add(this.txtName);
            this.grpCustomers.Controls.Add(this.lblName);
            this.grpCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCustomers.Location = new System.Drawing.Point(29, 31);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(383, 263);
            this.grpCustomers.TabIndex = 0;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Müşteri Ekle";
            this.grpCustomers.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(20, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ad Soyad :";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(124, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(230, 34);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(37, 79);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 18);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefon :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(34, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-posta :";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(80, 189);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(151, 38);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // grpAppointments
            // 
            this.grpAppointments.BackColor = System.Drawing.Color.Transparent;
            this.grpAppointments.Controls.Add(this.btnAddAppointment);
            this.grpAppointments.Controls.Add(this.dtpAppointmentDate);
            this.grpAppointments.Controls.Add(this.cmbPackages);
            this.grpAppointments.Controls.Add(this.label2);
            this.grpAppointments.Controls.Add(this.label1);
            this.grpAppointments.Controls.Add(this.cmbCustomers);
            this.grpAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAppointments.Location = new System.Drawing.Point(418, 31);
            this.grpAppointments.Name = "grpAppointments";
            this.grpAppointments.Size = new System.Drawing.Size(541, 263);
            this.grpAppointments.TabIndex = 1;
            this.grpAppointments.TabStop = false;
            this.grpAppointments.Text = "Randevu Ekle";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(157, 40);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(183, 28);
            this.cmbCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paket :";
            // 
            // cmbPackages
            // 
            this.cmbPackages.FormattingEnabled = true;
            this.cmbPackages.Location = new System.Drawing.Point(157, 90);
            this.cmbPackages.Name = "cmbPackages";
            this.cmbPackages.Size = new System.Drawing.Size(183, 28);
            this.cmbPackages.TabIndex = 3;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(47, 142);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(349, 34);
            this.dtpAppointmentDate.TabIndex = 4;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(136, 189);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(151, 38);
            this.btnAddAppointment.TabIndex = 5;
            this.btnAddAppointment.Text = "Randevu Ekle";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(32, 34);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(403, 164);
            this.listBoxNotifications.TabIndex = 2;
            // 
            // btnCheckAppointments
            // 
            this.btnCheckAppointments.Location = new System.Drawing.Point(472, 34);
            this.btnCheckAppointments.Name = "btnCheckAppointments";
            this.btnCheckAppointments.Size = new System.Drawing.Size(212, 38);
            this.btnCheckAppointments.TabIndex = 3;
            this.btnCheckAppointments.Text = "Randevuları Kontrol Et";
            this.btnCheckAppointments.UseVisualStyleBackColor = true;
            this.btnCheckAppointments.Click += new System.EventHandler(this.btnCheckAppointments_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBoxNotifications);
            this.groupBox1.Controls.Add(this.btnCheckAppointments);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(29, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YAKLAŞAN RANDEVULAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LazerEpilasyonTakip.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAppointments);
            this.Controls.Add(this.grpCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            this.grpAppointments.ResumeLayout(false);
            this.grpAppointments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbPackages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.Button btnCheckAppointments;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

