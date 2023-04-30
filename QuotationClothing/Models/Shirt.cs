namespace QuotationClothing.Models
{
    public class Shirt : Garment
    {
        public enum TypeShirt
        {
            ShortSleeve,
            LongSleeve
        };
        public enum NeckShirt
        {
            Mao,
            Common
        };
        public TypeShirt Type { get; set; }
        public NeckShirt Neck { get; set; }

        public Shirt(QualityGarment quality, double basePrice, int quantityStock, TypeShirt type, NeckShirt neck) : base(quality, basePrice, quantityStock)
        {
            Type = type;
            Neck = neck;
        }

        public override double CalculatePrice()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return $"Camisa {Type} {(Neck == NeckShirt.Mao ? "con" : "sin")} cuello mao ({Quality})";
        }


        
    }
}