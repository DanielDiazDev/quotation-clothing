using System;

namespace QuotationClothing.Models
{
    public class Quotation
    {
        public int ID { get; set; }

        public DateTime DateTime{ get; set; }

        public int IDSeller{ get; set; }

        public Garment QuotedGarment{ get; set; }

        public int QuantityUnitsQuoted{ get; set; }

        private decimal ResultQuotation;

        public Quotation(int id, DateTime dateTime, int idSeller, Garment quotedGarment, int quantityUnitsQuoted, decimal resultQuotation)
        {
            ID = id;
            DateTime = dateTime;
            IDSeller = idSeller;
            QuotedGarment = quotedGarment;
            QuantityUnitsQuoted = quantityUnitsQuoted;
            
        }
    }
}