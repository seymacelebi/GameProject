using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string  CampaignName { get; set; }
        public int DiscountPercent { get; set; }
    }
}
