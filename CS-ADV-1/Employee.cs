using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_ADV_1
{
    internal class Employee : IComparable
    {
        // properties
        public int id { get; set; }
        public string name { get; set; }
        public decimal  salary { get; set; }

        // constructor
        public Employee(int id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public Employee() { }


        // methods
        public override string ToString()
        {
            return $"(id: {id} :: name: {name} :: salary: {salary})";
        }

        //* now i make the Equals(); method compare between object state "data" when i use it with class. 
        public override bool Equals(object? obj)   // will return [true] or [false] 
        {
            Employee? employee = (Employee?) obj;

            return (this.id == employee?.id) && (this.name == employee?.name) && (this.salary == employee?.salary);
        }

        //* here we ---------> generate HashCode based on object state "data".
        public override int GetHashCode()
        {
            return HashCode.Combine(this.id.GetHashCode(), this.name?.GetHashCode() ?? 0, this.salary.GetHashCode()); // this is the correct an recommended way to generate HashCode.
           
            //return this.id.GetHashCode() + this.name?.GetHashCode() ?? 0 + this.salary.GetHashCode(); // deprecated way for generating HashCode.

        }

        public int CompareTo(object? obj)
        {
            /*Employee? employee = (Employee?)obj;*/ // explicit casting, unsafe.


            #region Is conditional Operator [true , false]
            // ---> will return true if obj is Employee
            // ----> will return true if obj is an object of class that inherit from Employee

            //if(obj is Employee emp)
            //{
            //    return this.salary.CompareTo(emp.salary);
            //}
            //return -1;

            #endregion

            #region As casting operator  [true, false]

            // ---> will return true if obj is Employee      
            // ---> will return true if  obj is an object from class that inherit from Employee

            Employee? employee = obj as Employee;
            return this.salary.CompareTo(employee?.salary);


            #endregion

        }
    }
}
 