using System;
using TreinandoEnum.Entities;
using TreinandoEnum.Entities.Enums;

namespace TreinandoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

            
        }
    }
}