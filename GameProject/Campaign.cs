using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int DiscountRate { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }
    }
}
