using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baker_Street_Bakery_Challenge
{
    public class OrderRepository
    {
        private List<OrderRepository> _ListOfOrders = new List<OrderRepository>();

        
        // Add an order to the list
        public void AddOrderToList(OrderRepository order)
        {
            _ListOfOrders.Add(order);
        }

        
        // get the list
        public List<OrderRepository> GetOrderList()
        {
            return _ListOfOrders;
        }

        
        // remove from the list
        public bool RemoveOrderFromList(OrderRepository order)
        {

        }

        // print the contents of the list
    }
}
