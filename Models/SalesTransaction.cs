using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Sales_Final_Project.Models
{
    //Sales transaction
    public class SalesTransaction
    {

        //transaction id 
        public int Id { get; set; }

        //Buyer id 
        public int BuyerId { get; set; }

        //Property id
        public int PropertyId { get; set; }

        //Buyer link
        public Buyer Buyer { get; set; }

        //Property link
        public Property Property { get; set; }


    }
}
