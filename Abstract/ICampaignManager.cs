using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Concrete;

namespace BackendDemoForAGame.Abstract
{
    public interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
