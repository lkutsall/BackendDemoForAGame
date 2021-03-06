using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Concrete;

namespace BackendDemoForAGame.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
