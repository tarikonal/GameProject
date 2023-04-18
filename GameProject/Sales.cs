using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Sales
    {
        public int Id { get; set; }
        
        public DateTime OrderDate { get; set; }

        [ForeignKey("Gamer")]
        public int GamerId { get; set; }

        [ForeignKey("Campaign")]
        public int CampaignId { get; set; }
    }
}
