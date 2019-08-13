using System;
using System.Globalization;

namespace Exercicio.Entities
{
    class ImportedProduct : Product
    {
        public Double customsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public Double totalPrice()
        {
             return Price += customsFee;
        }

        public override string priceTag()
        {
            return  Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: " + customsFee + ").";

        }
    }
}
