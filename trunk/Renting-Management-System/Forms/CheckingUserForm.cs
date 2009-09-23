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
        /// <summary>
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                dateTimePicker_BirthDate.Text = userMod.BirthDate.ToLongDateString();
                if (userMod.Sex == 'F')
                    radioButton_SexGirl.Checked = true;
                else
                    radioButton_SexBoy.Checked = true;
                comboBox_CertificateType.SelectedValue = userMod.CertificateTypeCode;
                textBox_CertificateNumber.Text = userMod.CertificateNumber;
                textBox_Contact.Text = userMod.UserContact;
                textBox_UserAddress.Text = userMod.UserAddress;
                textBox_UserDescription.Text = userMod.UserDescription;
                textBox_UserID.Enabled = false;
                button_Delete.Enabled = true;
                button_Modify.Enabled = true;
                button_Check.Enabled = false;
            }
        }
        /// <summary>
        /// 修改用户按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Modify_Click(object sender, EventArgs e)
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
            userMod.BirthDate = DateTime.Parse(dateTimePicker_BirthDate.Value.ToShortDateString());
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
            if (userDAL.ModifyData(userMod))
            {
                textBox_UserID.Enabled = true;
                button_Check.Enabled = false;
                button_Delete.Enabled = false;
                button_Modify.Enabled = false;
                MessageBox.Show("修改用户成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Delete_Click(object sender, EventArgs e)
        {
            userDAL = new Renting_Management_System.DAL.UserDAL();

            if (userDAL.DeleteData(textBox_UserID.Text.Trim()))
            {
                MessageBox.Show("用户已删除！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button_Delete.Enabled = false;
                button_Modify.Enabled = false;
                button_Check.Enabled = false;
                textBox_UserID.Enabled = true;
                textBox_UserID.Clear();
                textBox_UserName.Clear();
                textBox_UserPassword01.Clear();
                textBox_UserPassword02.Clear();
                textBox_UserDescription.Clear();
                textBox_UserAddress.Clear();
                textBox_Contact.Clear();
                textBox_CertificateNumber.Clear();
                comboBox_CertificateType.SelectedIndex = -1;
                comboBox_UserType.SelectedIndex = -1;
                dateTimePicker_BirthDate.Value = DateTimePicker.MinimumDateTime;
                radioButton_DenyNo.Checked = false;
                radioButton_DenyYes.Checked = false;
                radioButton_SexBoy.Checked = false;
                radioButton_SexGirl.Checked = false;
                return;
            }
        }

    }
}
