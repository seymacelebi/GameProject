using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Game game, CampaignManager campaignManager, Campaign campaign)
        {
            Console.WriteLine("Ürüne kampanya fiyatı eklendi");
        }
    }
}
