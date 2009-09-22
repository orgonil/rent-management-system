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
        Renting_Management_System.DAL.DBConnection sq2 = new Renting_Management_System.DAL.DBConnection();
        Renting_Management_System.DAL.CertificateTypeDAL certificateType;
        Renting_Management_System.DAL.CustomerTypeDAL customerType;
        Renting_Management_System.DAL.ImageTypeDAL imageType;
        Renting_Management_System.DAL.UserTypeDAL userType;
        Renting_Management_System.Models.UserTypeMod userTypeMod;
        Renting_Management_System.Models.CertificateTypeMod certificateTypeMod;
        Renting_Management_System.Models.CustomerTypeMod customerTypeMod;
        Renting_Management_System.Models.ImageTypeMod imageTypeMod;
        public CodeLibrary()
        {
            InitializeComponent();
        }

        private void CodeLibrary_Load(object sender, EventArgs e)
        {
            userType = new Renting_Management_System.DAL.UserTypeDAL();
            ds = new DataSet();
            s1 = new BindingSource();
            ds = userType.GetAll();
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
            customerType = new Renting_Management_System.DAL.CustomerTypeDAL();
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
            imageType = new Renting_Management_System.DAL.ImageTypeDAL();
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
            certificateType = new Renting_Management_System.DAL.CertificateTypeDAL();
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
        private void Add_btn_Click(object sender, EventArgs e)
        {

            if (this.usertype.Enabled==false)
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
                userType.Update(ds);
                MessageBox.Show("添加成功");
            }
            else if (this.Certificatetype.Enabled==false)
            {
                certificateType = new Renting_Management_System.DAL.CertificateTypeDAL();
                certificateTypeMod = new Renting_Management_System.Models.CertificateTypeMod();
                certificateTypeMod.CertificateTypeCode = txtID.Text.Trim();
                certificateTypeMod.CertificateTypeName = txtName.Text.Trim();
                certificateType.AddData(certificateTypeMod);
                ds.Clear();
                ds = certificateType.GetAll();
                s1 = new BindingSource();
                s1.DataSource = ds;
                s1.DataMember = ds.Tables[0].TableName;
                bindingNavigator1.BindingSource = s1;
                dataGridView1.DataSource = s1;
                certificateType.Update(ds);
                MessageBox.Show("添加成功");
            }
            else if(this.customertype.Enabled==false)
            {
                customerType=new Renting_Management_System.DAL.CustomerTypeDAL();
                customerTypeMod=new Renting_Management_System.Models.CustomerTypeMod();
                customerTypeMod.CustomerTypeCode=txtID.Text.Trim();
                customerTypeMod.CustomerTypeName=txtName.Text.Trim();
                customerType.AddData(customerTypeMod);
                ds.Clear();
                ds=customerType.GetAll();
                s1 = new BindingSource();
                s1.DataSource = ds;
                s1.DataMember = ds.Tables[0].TableName;
                bindingNavigator1.BindingSource = s1;
                dataGridView1.DataSource = s1;
                customerType.Update(ds);
                MessageBox.Show("添加成功");
            }
            else if (this.Imagetype.Enabled == false)
            {
                imageType = new Renting_Management_System.DAL.ImageTypeDAL();
                imageTypeMod = new Renting_Management_System.Models.ImageTypeMod();
                imageTypeMod.ImageTypeCode = txtID.Text.Trim();
                imageTypeMod.ImageTypeName = txtName.Text.Trim();
                imageType.AddData(imageTypeMod);
                ds.Clear();
                ds = imageType.GetAll();
                s1 = new BindingSource();
                s1.DataSource = ds;
                s1.DataMember = ds.Tables[0].TableName;
                bindingNavigator1.BindingSource = s1;
                dataGridView1.DataSource = s1;
                imageType.Update(ds);
                MessageBox.Show("添加成功");
            }
        }

        private void Mod_btn_Click(object sender, EventArgs e)
        {

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
          



        }
    }
}
