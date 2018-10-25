using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCD.BL
{
    public class InventoryRepository
    {
        public void OrderItems(Order order, bool allowSplitOrders)
        {
            // Order items from inventory
            // for each item ordered
            // locate item
            // if not available, notify user
            // if items are back ordered and order shouldn't be split, notify user
            // if the item is available
            // decrement quantity remaining
            // open a connection
            // set stored proc params with data
            // call the save stored proc
        }
    }
}
