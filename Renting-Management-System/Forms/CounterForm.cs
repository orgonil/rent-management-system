using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renting_Management_System.Forms
{
    public partial class CounterForm : Form
    {
        
        DataSet ds;
        BindingSource bindingSource;
        //static bool changed = false;
        DialogResult dialogeResult;
        Renting_Management_System.BLL.TableUpdate tableUpdate;
        //Renting_Management_System.Models.RentMod rentMod;
        //Renting_Management_System.Models.CustomerMod customerMod;
        Renting_Management_System.DAL.RentDAL rentDAL;
        Renting_Management_System.DAL.ImageDAL imageDAL;
        Renting_Management_System.DAL.CustomerDAL customerDAL;

        public void Save(DataSet dataSet)
        {
            tableUpdate = new Renting_Management_System.BLL.TableUpdate();
            tableUpdate.Update(dataSet);
        }

        public CounterForm()
        {
            InitializeComponent();

            LoginForm form = new LoginForm();

            toolStripStatusLabel_UserName.Text = form.GetUserName();
            toolStripStatusLabel_UserType.Text = form.GetUserType();
            toolStripStatusLabel_Date.Text = DateTime.Today.ToLongDateString();

            ds = new DataSet();
            rentDAL = new Renting_Management_System.DAL.RentDAL();

            ds = rentDAL.GetAll();
            bindingSource = new BindingSource();
            bindingSource.DataSource = ds;
            bindingSource.DataMember = ds.Tables[0].TableName;
            bindingSource.Sort = ds.Tables[0].Columns[0].ColumnName + " ASC";
            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            if (ds.HasChanges())
            {
                toolStripButton_Save.Enabled = true;
                changed = true;
            }
        }

        private void CounterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renting_Management_System.BLL.FormBLL form = new Renting_Management_System.BLL.FormBLL();
            form.Logout();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void 影像表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ds.HasChanges())
            {
                dialogeResult = new DialogResult();
                dialogeResult = MessageBox.Show("数据已更改，您是否要保存？", "数据以改变", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dialogeResult)
                { 
                    case DialogResult.Yes :
                        break;
                    case DialogResult.No:
                        break;
                    default :
                        return;
                }
            }
            else
            {
                ds = new DataSet();
                imageDAL = new Renting_Management_System.DAL.ImageDAL();
                bindingSource = new BindingSource();

                ds = imageDAL.GetAll();
                bindingSource.DataSource = ds;
                bindingSource.DataMember = ds.Tables[0].TableName;
                bindingSource.Sort = ds.Tables[0].Columns[0].ColumnName + " ASC";
                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
            }
        }

        private void 客户表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            customerDAL = new Renting_Management_System.DAL.CustomerDAL();
            bindingSource = new BindingSource();

            ds = customerDAL.GetAll();
            bindingSource.DataSource = ds;
            bindingSource.DataMember = ds.Tables[0].TableName;
            bindingSource.Sort = ds.Tables[0].Columns[0].ColumnName + " ASC";
            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void 租借表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            bindingSource = new BindingSource();
            rentDAL = new Renting_Management_System.DAL.RentDAL();

            ds = rentDAL.GetAll();
            bindingSource.DataSource = ds;
            bindingSource.DataMember = ds.Tables[0].TableName;
            bindingSource.Sort = ds.Tables[0].Columns[0].ColumnName + " ASC";
            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            this.Save(ds);
            toolStripButton_Save.Enabled = false;
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            toolStripButton_Save.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            toolStripButton_Save.Enabled = true;
        }
    }
}
