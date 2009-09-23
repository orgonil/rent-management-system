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
    public partial class CheckingUserForm : Form
    {
        DataSet ds;
        Renting_Management_System.DAL.UserDAL userDAL;
        Renting_Management_System.DAL.UserTypeDAL userTypeDAL;
        Renting_Management_System.DAL.CertificateTypeDAL certificateTypeDAL;
        Renting_Management_System.Models.UserMod userMod;
        DialogResult dialogResult;

        public CheckingUserForm()
        {
            InitializeComponent();

            userTypeDAL = new Renting_Management_System.DAL.UserTypeDAL();
            certificateTypeDAL = new Renting_Management_System.DAL.CertificateTypeDAL();
            ds = new DataSet();

            ds = userTypeDAL.GetAll();
            comboBox_UserType.DataSource = ds.Tables[0];
            comboBox_UserType.DisplayMember = ds.Tables[0].Columns[1].ColumnName;
            comboBox_UserType.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            comboBox_UserType.SelectedValue = "";

            ds = certificateTypeDAL.GetAll();
            comboBox_CertificateType.DataSource = ds.Tables[0];
            comboBox_CertificateType.DisplayMember = ds.Tables[0].Columns[1].ColumnName;
            comboBox_CertificateType.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            comboBox_CertificateType.SelectedValue = "";
        }

        private void CheckingUserForm_Load(object sender, EventArgs e)
        {
            if (textBox_UserID.Text != ""||textBox_UserName.Text!="")
                button_Check.Enabled = true;
            else
                button_Check.Enabled = false;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            userMod = new Renting_Management_System.Models.UserMod();
            userDAL = new Renting_Management_System.DAL.UserDAL();

            if (textBox_UserID.Text != "")
                userMod = userDAL.SelectByID(textBox_UserID.Text.Trim());
            else
                userMod = userDAL.SelectByName(textBox_UserName.Text.Trim());
            if (userMod == null)
            {
                MessageBox.Show("该用户的编号或名称不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                textBox_UserID.Text = userMod.UserID;
                textBox_UserName.Text = userMod.UserName;
                textBox_UserPassword01.Text = userMod.UserPassword;
                textBox_UserPassword02.Text = userMod.UserPassword;
                comboBox_UserType.SelectedValue = userMod.UserTypeCode;
                if (userMod.UserDeny)
                    radioButton_DenyYes.Checked = true;
                else
                    radioButton_DenyNo.Checked = true;
                dateTimePicker_BirthDate.Value = userMod.BirthDate;
                if (userMod.Sex == 'F')
                    radioButton_SexGirl.Checked = true;
                else
                    radioButton_SexBoy.Checked = true;
                comboBox_CertificateType.SelectedValue = userMod.CertificateTypeCode;
                textBox_CertificateNumber.Text = userMod.CertificateNumber;
                textBox_Contact.Text = userMod.UserContact;
                textBox_UserAddress.Text = userMod.UserAddress;
                textBox_UserDescription.Text = userMod.UserDescription;
                button_Delete.Enabled = true;
                button_Delete.Enabled = true;
                button_Check.Enabled = false;
            }
        }
    }
}
