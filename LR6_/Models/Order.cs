using System.Numerics;

namespace LR6_.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Address { get; set; }
        public string ContactTelephone { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
