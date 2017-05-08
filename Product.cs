using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorksData.Models
{
    public class Product
    {
        [StringLength(50)]
        public string  Name { get; set; }

        [StringLength(15)]
        public string Color { get; set; }


        public int ProductID { get; set; }

        [StringLength(25)]
        public string ProductNumber { get; set; }


        public decimal StandardCost { get; set; }

        public decimal  ListPrice { get; set; }

   
        [StringLength(5)]
        public string  Size { get; set; }

        public decimal? Weight { get; set; }

        public int ProductCategoryID { get; set; }

        public int ProductModelID { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }
        
        public DateTime? DiscontiuedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string Rowguid { get; set; }




    }
}
