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
    public partial class AddingUserForm : Form
    {
        DataSet ds;
        Renting_Management_System.DAL.UserDAL userDAL;
        Renting_Management_System.DAL.UserTypeDAL userTypeDAL;
        Renting_Management_System.DAL.CertificateTypeDAL certificateTypeDAL;
        Renting_Management_System.Models.UserMod userMod;
        DialogResult dialogResult;

        public AddingUserForm()
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

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_UserID.Text == "" || textBox_UserName.Text == "" || textBox_UserPassword01.Text == "" || textBox_UserPassword02.Text == "")
            {
                MessageBox.Show("用户登录信息区有些不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_UserPassword01.Text != textBox_UserPassword02.Text)
            {
                MessageBox.Show("再次输入密码不正确，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                userDAL = new Renting_Management_System.DAL.UserDAL();
                userMod = new Renting_Management_System.Models.UserMod();

                userMod.UserID = textBox_UserID.Text.Trim();
                userMod.UserName = textBox_UserName.Text.Trim();
                userMod.UserPassword = textBox_UserPassword01.Text.Trim();
                if (comboBox_UserType.SelectedValue == null)
                {
                    comboBox_UserType.SelectedIndex = 0;
                }
                userMod.UserTypeCode = comboBox_UserType.SelectedValue.ToString().Trim();
                if (radioButton_DenyNo.Checked)
                {
                    userMod.UserDeny = false;
                }
                else
                {
                    userMod.UserDeny = true;
                }
                userMod.BirthDate = dateTimePicker_BirthDate.Value;
                if (radioButton_SexGirl.Checked)
                {
                    userMod.Sex = 'F';
                }
                else
                {
                    userMod.Sex = 'M';
                }
                if (comboBox_CertificateType.SelectedValue == null)
                {
                    comboBox_CertificateType.SelectedIndex = 0;
                }
                userMod.CertificateTypeCode = comboBox_CertificateType.SelectedValue.ToString().Trim();
                userMod.CertificateNumber = textBox_CertificateNumber.Text.Trim();
                userMod.UserContact = textBox_Contact.Text.Trim();
                userMod.UserAddress = textBox_UserAddress.Text.Trim();
                userMod.UserDescription = textBox_UserDescription.Text.Trim();
                if (userDAL.AddData(userMod))
                {
                    MessageBox.Show("添加用户成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("该编号已存在，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("您是否要关闭添加用户窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (dialogResult)
            { 
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    return;
            }
        }

        private void AddingUserForm_Load(object sender, EventArgs e)
        {
            if (textBox_UserID.Text != "")
                button_Add.Enabled = true;
            else
                button_Add.Enabled = false;
        }
    }
}
