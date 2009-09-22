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
        Renting_Management_System.DAL.DBConnection sq1 = new Renting_Management_System.DAL.DBConnection();
        Renting_Management_System.DAL.UserTypeDAL sq2 = new Renting_Management_System.DAL.UserTypeDAL();
        public CodeLibrary()
        {
            InitializeComponent();
        }

        private void CodeLibrary_Load(object sender, EventArgs e)
        {
            DataSet DS = sq2.GetAll();
            
            this.dataGridView1.DataSource = DS.Tables[0].DefaultView;
            this.dataGridView1.Columns[0].Width = 80;
            this.dataGridView1.Columns[1].Width = 298;
        }
        private void usertype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.UserTypeDAL userType = new Renting_Management_System.DAL.UserTypeDAL();
            da = userType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = false;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = true;
        }
            

        private void customertype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CustomerTypeDAL customerType = new Renting_Management_System.DAL.CustomerTypeDAL();
            da = customerType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.customertype.Enabled= false;
            this.usertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = true;
        }

        private void Imagetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.ImageTypeDAL imageType = new Renting_Management_System.DAL.ImageTypeDAL();
            da = imageType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = true;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = false;

            this.Certificatetype.Enabled = true;
            
        }

        private void Certificatetype_Click(object sender, EventArgs e)
        {
            Renting_Management_System.DAL.CertificateTypeDAL certificateType = new Renting_Management_System.DAL.CertificateTypeDAL();
            da = certificateType.GetAll();
            s1 = new BindingSource();
            s1.DataSource = da;
            s1.DataMember = da.Tables[0].TableName;
            dataGridView1.DataSource = s1;
            this.usertype.Enabled = true;
            this.customertype.Enabled = true;
            this.Imagetype.Enabled = true;
            this.Certificatetype.Enabled = false;
        }
        private int Add(string Name)
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
              
          
     
           
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
           
            if (this.Certificatetype.Enabled == false)
            {
                string certificatetype="Certificatetype";
                if (Add(certificatetype) > 0)
                {
                    MessageBox.Show("添加成功");
                }
                
            }
            else if (this.usertype.Enabled == false)
            {
                string certificatetype = "UserType";
                if (Add(certificatetype) > 0)
                {
                    MessageBox.Show("添加成功");
                }
            }
            else if(this.customertype.Enabled==false)
            {
                string certificatetype = "CustomerType";
                if (Add(certificatetype) > 0)
                {
                    MessageBox.Show("添加成功");
                }
            }
            else if(this.Imagetype.Enabled==false)
            {
                string certificatetype="ImageType";
                if (Add(certificatetype) > 0)
                {
                    MessageBox.Show("添加成功");
                }
            }
            else
            {
                MessageBox.Show("请选择相应的表再进行添加");
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
