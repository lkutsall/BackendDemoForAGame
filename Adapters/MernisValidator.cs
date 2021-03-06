using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;
using BackendDemoForAGame.Concrete;
using MernisReference;

namespace BackendDemoForAGame.Adapters
{
    public class MernisValidator : IUserValidation
    {
        public bool CheckIfUserIsValid(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.TCKN), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
