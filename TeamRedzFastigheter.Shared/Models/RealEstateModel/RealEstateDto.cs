using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamRedzFastigheter.Shared.Enitites;

namespace TeamRedzFastigheter.Shared.Models.RealEstateModel
{
    public class RealEstateDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int ConstructionYear { get; set; }
        public DateTimeOffset AdCreated { get; set; }
        public string Contact { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public int RentingPrice { get; set; }
        public int PurchasePrice { get; set; }
        public bool CanBeRented { get; set; }
        public bool CanBePurchased { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
