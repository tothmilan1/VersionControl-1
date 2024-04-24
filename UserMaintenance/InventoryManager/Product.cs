using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Hotcakes.CommerceDTO.v1;
//using Hotcakes.CommerceDTO.v1.Catalog;
//using Hotcakes.CommerceDTO.v1.Client;

namespace InventoryManager
{
    internal class Product
    {
        public string Name { get; set; } //ProductBvin alapján kéne behívni
        public string Category { get; set; } //CategoryTransalation táblában minden cat bvin és a megjeleníthető cat nevek

        //ezek mind ProductInventory tábla

        public int QuantityOnHand { get; set; }
        public int ReservedInventory { get; set; }
        public int LowStock { get; set; }
        public int OutOfStock { get; set; }
    }
}
