using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient.Models
{
    class Book
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public DateTime PubDate { get; set; }
        public int Cost { get; set; }
        public int Retail { get; set; }
        public int CategoryID { set; get; }
        public int PublisherID { get; set; }


    }
}
