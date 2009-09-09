using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renting_Management_System.BLL
{
    class OpenBLL
    {
        private Renting_Management_System.Forms.CounterForm counter;
        private Renting_Management_System.Forms.StoreForm store;
        private Renting_Management_System.Forms.AdminForm admin;
        private Renting_Management_System.DAL.UserTypeDAL userType;
        public void OpenForm(string _userTypeCode)
        {
            switch (_userTypeCode)
            { 
                case "001":
                    admin = new Renting_Management_System.Forms.AdminForm();
                    admin.Show();
                    break;
                case "002":
                    counter = new Renting_Management_System.Forms.CounterForm();
                    counter.Show();
                    break;
                default :
                    store = new Renting_Management_System.Forms.StoreForm();
                    store.Show();
                    break;
            }
        }
    }
}
