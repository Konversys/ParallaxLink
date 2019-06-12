using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxLink.TrainDatabase.Model
{
    public class InventoryShort
    {
        public InventoryShort(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        public static InventoryShort Convert(Inventory inventory)
        {
            return new InventoryShort(inventory.Title);
        }
    }
}
