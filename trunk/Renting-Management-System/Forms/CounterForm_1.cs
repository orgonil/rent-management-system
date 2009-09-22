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
    public partial class CounterForm_1 : Form
    {
        public CounterForm_1()
        {
            InitializeComponent();
        }

        private void 柜台管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_Rent_Management_SystemDataSet.Image”中。您可以根据需要移动或移除它。
            this.imageTableAdapter.Fill(this._Rent_Management_SystemDataSet.Image);

        }

        private void ExecuteSQL(string SQL)
        {
            string myConStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbo.User;";
            SqlConnection myCon = new SqlConnection();
            SqlCommand myCom = new SqlCommand();
            SqlDataAdapter myAD = new SqlDataAdapter();
            DataSet myDs = new DataSet();
            try
            {
                myCon.ConnectionString = myConStr;
                myCon.Open();
                myCom.CommandText = SQL;
                myCom.CommandType = CommandType.Text;
                myCom.Connection = myCon;
                myCom.ExecuteNonQuery();
                myDs.Clear();
                myAD.SelectCommand = myCom;
                myAD.Fill(myDs, "AddrBook");
            }
            catch (SqlException oe)
            {
                MessageBox.Show(oe.Message, "Error");
            }
            finally
            {
                if (myCon.State == ConnectionState.Open)
                    myCon.Close();
            }
        }

        private void inster_btn_Click(object sender, EventArgs e)
        {
            string insStr = "insert into dbo.User(用户编号,用户名称,性别,出生日期,用户密码,用户类代码,证件类代码,证件号码,联系方式,用户地址,用户描述,用户拒绝)";
            insStr += "valuse('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text;
            insStr +="','"+textBox9.Text +"','"+textBox10 .Text +"')";
            ExecuteSQL(insStr);
        }

        private void select_btn_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void deleter_btn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
 