using System;
using System.Collections.Generic;
using System.Linq;

namespace QuotationClothing.Models
{
    public class Seller
    {
        public string Name {get; set;}

        public string LastName{get; set;}
        
        public int IDSeller{get; set;}

        public List<Quotation> QuotationsHistory { get; set; }

        public Seller(string name, string lastName, int idSeller, List<Quotation> quotationsHistory)
        {
            Name = name;
            LastName = lastName;
            IDSeller = idSeller;
            QuotationsHistory = quotationsHistory;
        }

        public void RealizeQuaotation(int id, DateTime dateTime, int idSeller, Garment quotedGarment, int quantityUnitsQuoted, decimal resultQuotation)
        {
            Quotation quotation = new Quotation(id,dateTime, idSeller, quotedGarment, quantityUnitsQuoted, resultQuotation);
            QuotationsHistory.Add(quotation);
        }

        public List<Quotation> GetQuotations()
        {
            return QuotationsHistory;
        }

        public Quotation GetQuotationsByID(int id)
        {
            return QuotationsHistory.FirstOrDefault(qh => qh.ID == id);
        }

        public bool DeleteQuotationByID(int id)
        {
            return QuotationsHistory.Remove(QuotationsHistory.FirstOrDefault(qh => qh.ID == id));
        }




    }
}