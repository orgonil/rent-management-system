using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renting_Management_System.Forms
{
    public partial class CodeLibrary : Form
    {
        DataSet da;
        BindingSource s1;
        public CodeLibrary()
        {
            InitializeComponent();
        }

        private void CodeLibrary_Load(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.DBConnection sql = new Renting_Management_System.DAL.DBConnection();

            
        }

        private void usertype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.UserTypeDAL userType = new Renting_Management_System.DAL.UserTypeDAL();
            da= userType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
        }

        private void customertype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CustomerTypeDAL customerType = new Renting_Management_System.DAL.CustomerTypeDAL();
            da = customerType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
        }

        private void Imagetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.ImageTypeDAL imageType = new Renting_Management_System.DAL.ImageTypeDAL();
            da = imageType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
        }

        private void Certificatetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CertificateTypeDAL certificateType = new Renting_Management_System.DAL.CertificateTypeDAL();
            da = certificateType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {

        }

        private void Mod_btn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
