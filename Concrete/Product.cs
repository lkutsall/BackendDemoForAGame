using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;

namespace BackendDemoForAGame.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
