using System.Globalization;

namespace Exercicio14.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Name { get; set; }

        public OrderItem() { }
        public OrderItem(int quantity, double price, Product name)
        {
            Quantity = quantity;
            Price = price;
            Name = name;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
