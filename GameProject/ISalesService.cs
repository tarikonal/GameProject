using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public interface ISalesService
    {
        int Sell(Game game, Gamer gamer);

        int SellWithCampaign(Game game, Gamer gamer, Campaign campaign);
        bool CancelTransaction(int id);

        void PrintBill(int id);
    }
}
