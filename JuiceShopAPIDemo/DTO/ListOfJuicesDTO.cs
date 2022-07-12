using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopAPIDemo
{
    public partial class ListOfJuicesDTO
        {
            public string Status { get; set; }
            public List<Data> Data { get; set; }
        }

        public partial class Data
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public double DeluxePrice { get; set; }
            public string Image { get; set; }
            public string CreatedAt { get; set; }
            public string UpdatedAt { get; set; }
            public object DeletedAt { get; set; }
        }
    }


