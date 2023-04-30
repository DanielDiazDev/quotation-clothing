namespace QuotationClothing.Models
{
    public abstract class Garment
    {
        public enum QualityGarment
        {
            Standart,
            Premium
        };
        public QualityGarment Quality { get; set; }
        public double BasePrice { get; set; }
        public int QuantityStock { get; set; }
        public abstract double CalculatePrice();

        public Garment(QualityGarment quality, double basePrice, int quantityStock)
        {
            Quality = quality;
            BasePrice = basePrice;
            QuantityStock = quantityStock;
        }
    }
}