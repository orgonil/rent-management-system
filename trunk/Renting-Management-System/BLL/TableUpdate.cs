using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Renting_Management_System.BLL
{
    class TableUpdate
    {
        private Renting_Management_System.DAL.DBConnection da;
        public void Update(DataSet ds)
        {
            da = new Renting_Management_System.DAL.DBConnection();
            da.Refresh(ds);
        }
    }
}
