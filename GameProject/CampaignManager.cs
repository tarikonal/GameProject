using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
