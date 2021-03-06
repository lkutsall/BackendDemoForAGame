using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Concrete;

namespace BackendDemoForAGame.Abstract
{
    public interface IUserValidation
    {
        bool CheckIfUserIsValid(Player player);
    }
}
