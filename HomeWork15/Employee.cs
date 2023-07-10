using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    public class Employee
    {
        private string _fullname;
        private int _age;
        private int _workingExperience;
        private double _salary;



        public string Fullname 
        {
            get
            {
                Console.WriteLine("Fullname");//ToCheck method execution
                return _fullname;
            }
            set
            {
                if(value == "") 
                {
                    throw new ArgumentNullException("Empty parameter");
                }
                else
                {
                    _fullname = value;
                    Console.WriteLine(value); //ToCheck method execution
                }
            }
        }

        public int Age
        {
            get
            {
                Console.WriteLine(_age);
                return _age;
            }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }else if(value < 0)
                {
                    throw new ArgumentException("Age must be more than 0");
                }else
                {
                    throw new ArgumentException("Employee must be older than 18 years");
                }
            }
        }

        public double Salary
        {
            get
            {
                Console.WriteLine(_salary);
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("salary cann't be less than 0");
                }else
                {
                    _salary = value;
                }
            }
        }

        public int WorkingExperience
        {
            get
            {
                Console.WriteLine(_workingExperience);
                return _workingExperience;
            }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Experience cann't be less than 0");
                }else
                {
                    _workingExperience = value;
                }
                
            }
        }

        public void RaiseSalary()
        {
            if(_workingExperience == 0) 
            {
                _salary *= 1;
            }else if (_workingExperience >= 5) 
            {
                _salary *= 2;
            }else if( _workingExperience >= 10)
            {
                _salary *= 3;
            }else
            {
                _salary *= 4;
            }

            Console.WriteLine(_salary);
        }
    }
}
