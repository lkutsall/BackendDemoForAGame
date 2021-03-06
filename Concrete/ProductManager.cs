using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;

namespace BackendDemoForAGame.Concrete
{
    public class ProductManager : IProductManager
    {
        //Varsa, kampanya eklenecek.
        public void Buy(Product product, Player player)
        {
            Console.WriteLine(product.Price + "TL has been paid by " + player.FirstName +". The " + product.ProductName + " has been added into " + player.FirstName + "'s inventory.");
        }

        public void Sell(Product product, Player player)
        {
            Console.WriteLine("The " + product.ProductName + " has been sold with a price " + product.Price + "by " + player.FirstName);
        }
    }
}
