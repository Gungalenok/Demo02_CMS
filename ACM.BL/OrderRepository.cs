using CMS.BusinessLayer;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            return new Order(orderId);
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
