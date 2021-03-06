using System;
using System.Collections.Generic;
using System.Text;

using BackendDemoForAGame.Abstract;

namespace BackendDemoForAGame.Concrete
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public float DiscountRate { get; set; }
    }
}
