using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Concrete;

namespace BackendDemoForAGame.Abstract
{
    public interface IProductManager
    {
        void Buy(Product product, Player player);
        void Sell(Product product, Player player);
    }
}
