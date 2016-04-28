using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Payment
    {
        int ID { get; set; }
        string PaymentMode { get; set; }

        public Payment construct(List<object> list)
        {
            Payment payment = new Payment();
            payment.ID = (int)list[0];
            payment.PaymentMode = list[1].ToString();
            return payment;
        }

    }

}
