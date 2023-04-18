using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id = 1, BirthYear = 1980, FirstName = "Tarık", LastName = "Önal", IdentityNumber = 12345 };
            Game game = new Game { Id = 1, Description = "vurdulu kırdılı", Name = "Street Fighter", Price = 100 };
            Game game2 = new Game { Id = 2, Description = "yarış", Name = "Need For Speed", Price = 200 };

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer);
            
          

            Campaign campaign = new Campaign {Id = 1, Name = "Dövüşlü Oyun", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), DiscountRate = 50, GameId = 1 };
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaign.DiscountRate = 40;
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign.Id);

            SalesManager salesManager = new SalesManager();
            int salesId = salesManager.Sell(game, gamer);
            salesManager.CancelTransaction(salesId);
            int salesIdWithCampaign = salesManager.SellWithCampaign(game2, gamer,campaign);
            salesManager.PrintBill(salesIdWithCampaign);

        }
    }
}
