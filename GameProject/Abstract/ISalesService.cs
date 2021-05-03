using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface ISalesService
    {
        void Sell(Game game, CampaignManager campaignManager, Campaign campaign);
    }
}
