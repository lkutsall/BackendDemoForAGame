using System;

using BackendDemoForAGame.Abstract;
using BackendDemoForAGame.Concrete;
using BackendDemoForAGame.Adapters;

namespace BackendDemoForAGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayerManager playerManager = new PlayerManager(new MernisValidator());
            IProductManager productManager = new ProductManager();

            Player player = new Player() 
            {
                FirstName = "Kutsal",
                LastName = "Mustafaoğlu",
                TCKN = "00000000000",
                DateOfBirth = new DateTime(1980,05,19)
            };

            Product product = new Product { Id = 1, ProductName = "Beginner's Sword", Price = 10 };

            playerManager.Add(player);
            productManager.Buy(product, player);
        }
    }
}
