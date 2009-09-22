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
        DataSet ds = new DataSet();
        BindingSource s1;
        Renting_Management_System.DAL.DBConnection sq1 = new Renting_Management_System.DAL.DBConnection();
        Renting_Management_System.DAL.UserTypeDAL sq2 = new Renting_Management_System.DAL.UserTypeDAL();
        Renting_Management_System.DAL.UserTypeDAL userType;
        Renting_Management_System.Models.UserTypeMod userTypeMod;
        public CodeLibrary()
        {
            InitializeComponent();
        }

        private void CodeLibrary_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            s1 = new BindingSource();
            ds = sq2.GetAll();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            bindingNavigator1.BindingSource = s1;
            dataGridView1.DataSource = s1;
            //this.dataGridView1.Columns[0].Width = 80;
            //this.dataGridView1.Columns[1].Width = 298;
        }
        private void usertype_Click(object sender, EventArgs e)
        {
            userType = new Renting_Management_System.DAL.UserTypeDAL();
            ds.Clear();
            ds = userType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = false;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = true;
        }
            

        private void customertype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CustomerTypeDAL customerType = new Renting_Management_System.DAL.CustomerTypeDAL();
            ds.Clear();
            ds = customerType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.customertype.Enabled= false;
            this.usertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = true;
        }

        private void Imagetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.ImageTypeDAL imageType = new Renting_Management_System.DAL.ImageTypeDAL();
            ds.Clear();
            ds = imageType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = true;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = false;

            this.Certificatetype.Enabled = true;
            
        }

        private void Certificatetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CertificateTypeDAL certificateType = new Renting_Management_System.DAL.CertificateTypeDAL();
            ds.Clear();
            ds = certificateType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = true;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = false;
        }
        /*private int Add(string Name)
        {
            
               string str = sq1.ReturnStr();
                string sta = "insert into " + Name + " values(" + this.txtID.Text + ",'" + this.txtName.Text + "')";
                SqlConnection conn = new SqlConnection(str);
                SqlCommand comm = new SqlCommand(sta, conn);
                conn.Open();
                int i = comm.ExecuteNonQuery();
                DataSet DS = sq2.GetAll();
                this.dataGridView1.DataSource = DS.Tables[0].DefaultView;
                return i;
                conn.Close(); 
              
          
     
           
        }*/
        private void Add_btn_Click(object sender, EventArgs e)
        {
            userType = new Renting_Management_System.DAL.UserTypeDAL();
            userTypeMod = new Renting_Management_System.Models.UserTypeMod();
            userTypeMod.UserTypeCode = txtID.Text.Trim();
            userTypeMod.UserTypeName = txtName.Text.Trim();
            userType.AddData(userTypeMod);
            ds.Clear();
            ds = userType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = ds;
            s1.DataMember = ds.Tables[0].TableName;
            bindingNavigator1.BindingSource = s1;
            dataGridView1.DataSource = s1;
        }

        private void Mod_btn_Click(object sender, EventArgs e)
        {

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
          



        }
    }
}
