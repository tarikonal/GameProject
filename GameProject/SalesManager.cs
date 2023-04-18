using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class SalesManager : ISalesService
    {
        public bool CancelTransaction(int id)
        {
            Console.WriteLine(id+" numaralı Satış iptal edildi");
            return true;
        }

        public void PrintBill(int id)
        {
            Console.WriteLine("Fatura e-posta adresine yollandı");
        }

        public int Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("Satış başarılı");
            return new Random().Next();
        }

        public int SellWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            decimal iskonto = game.Price - (game.Price * campaign.DiscountRate / 100);
            Console.WriteLine("Satış fiyatı "+ game.Price+ " TL olan " +game.Name+ " isimli oyun "+gamer.FirstName + " isimli kişiye " + 
                campaign.Name+" kampanyası ile %"+ campaign.DiscountRate+" iskonto uygulanarak " +
                iskonto +" TL fiyatına satılmıştır" );
            return new Random().Next();
        }

     
    }
}
