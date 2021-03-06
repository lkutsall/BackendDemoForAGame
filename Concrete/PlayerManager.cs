using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;
using MernisReference;

namespace BackendDemoForAGame.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        IUserValidation _userValidation;
        public PlayerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }
        //Add methodu boolean tanımlanıp mernis'e göre true veya false dönebilir. Buna göre alış satış yapılması veya kampanyalardan yararlanma durumu kontrol edilebilir.
        public void Add(Player player)
        {
            if (_userValidation.CheckIfUserIsValid(player))
            {
                Console.WriteLine("SUCCESS! The user, " + player.FirstName + " is valid and added into database.");
            }
            else
            {
                throw new Exception("FAILED! The user " + player.FirstName + " is invalid. Please check your information again.");
            }
        }

        public void Delete(Player player)
        {
            throw new NotImplementedException();
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
