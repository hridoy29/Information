using GuestFeedBackForm.Class;
using Information.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Information.Class
{
    public class DataAccessLayer
    {

        DBExecutor dbExecutor;
       
        public DataAccessLayer()
        {
            dbExecutor = new DBExecutor();
        }
      
        public List<Employee> EmployeeInfo(int Id)
        {
            List<Employee> _Employee_Info_Result = new List<Employee>();

            Parameters[] colparameters = new Parameters[1]{
                new Parameters("@_EmployeeId", Id, DbType.Int32, ParameterDirection.Input)
            };
            _Employee_Info_Result = dbExecutor.FetchData<Employee>(CommandType.StoredProcedure, "Employee_Info", colparameters);

            return _Employee_Info_Result;
        }
        
    }
}