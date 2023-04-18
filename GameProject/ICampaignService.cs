using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(int id);
        public void Update(Campaign campaign);
    }
}
