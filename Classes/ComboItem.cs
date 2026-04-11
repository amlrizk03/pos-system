using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Classes
{
    public class ComboItem
    {
        public ComboItem(string _id,string _DES) {
            Id = _id;
            DES = _DES;
        }
        public string Id { get; set; }
        public string DES { get; set; }

        
        public override string ToString()
        {
            return DES;
        }
    }
}
