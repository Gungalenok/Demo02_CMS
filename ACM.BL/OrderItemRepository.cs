using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem(orderItemId);
        }

        public bool Save(OrderItem orderItem)
        {
            return true;
        }
    }
}
