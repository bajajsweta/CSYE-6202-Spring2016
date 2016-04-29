using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Customer : Person
    { 
        string IDProof { get; set; }


        public Customer construct(List<object> list)
        {
            Customer customer = new Customer();
            customer.ID = (int)list[0];
            customer.Name = list[1].ToString();
            customer.Gender = list[2].ToString();
            customer.Age = (int)list[3];
            customer.Email = list[4].ToString();
            customer.IDProof = list[4].ToString();
            return customer;
        }



    }
}
