using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;

namespace BackendDemoForAGame.Concrete
{
    public class CustomUserValidation : IUserValidation
    {
        public bool CheckIfUserIsValid(Player player)
        {
            return true;
        }
    }
}
