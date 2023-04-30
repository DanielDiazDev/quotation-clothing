using System.Collections.Generic;

namespace QuotationClothing.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string Direction { get; set; }
        private List<Garment> _garments;
        private Seller _seller;

        public Store(List<Garment> garments, string name, string direction)
        {
            _garments = garments;
            Name = name;
            Direction = direction;
        }
        
        
    }
}