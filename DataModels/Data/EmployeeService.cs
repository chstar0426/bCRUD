using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModels
{
    public class EmployeeService
    {
        private readonly dbContext _db;

        public EmployeeService(dbContext db)
        {
            _db = db;

        }

        public List<EmployeeInfo> GetEmployee()
        {
            return _db.Employees.ToList();
        }

        public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeID == id);
            return employee;
        }

        public string UpdeateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Update Successfully";

        }

        public string DeleteEmpInfo(EmployeeInfo objEmployee)
        {

            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delecte Successfully";  
        }
    }
}
