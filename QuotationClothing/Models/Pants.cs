namespace QuotationClothing.Models
{
    public class Pants : Garment
    {
        public enum TypePants
        {
            Common,
            Chupin
        };
        public TypePants Type { get; set; }

        public Pants(QualityGarment quality, double basePrice, int quantityStock, TypePants type) : base(quality, basePrice, quantityStock)
        {
            Type = type;
        }

        public override double CalculatePrice()
        {
            double finalPrice = BasePrice;
            if (Type == TypePants.Chupin)
            {
                finalPrice *= 0.88;
            }

            return finalPrice;
        }

        public override string ToString()
        {
            return $"Pantalón {(Type == TypePants.Chupin ? "chupín" : "común")} ({Quality})";
        }
    }
}