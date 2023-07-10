using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    public class Company
    {
        public string OwnerName { get; set; }
        public string Name { get; set; }

        private Building _office;

        private List<Employee> _employees;

        public Company()
        {
            _employees = new List<Employee>();
        }

        
        public void SetEmployees(List<Employee> employees)
        {
            _employees = employees;
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                _employees.Add(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void AddEmployees(List<Employee> newEmployees)
        {
            try
            {
                _employees.AddRange(newEmployees);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString() );
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }
        public void RemoveEmployees(List<Employee> newEmployees)
        {
            foreach (Employee employee in newEmployees)
            {
                _employees.Remove(employee);
            }
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Building Office
        {
            get
            {
                return _office;
            }
            set
            {
                _office = value;
            }
        }
    }
}
