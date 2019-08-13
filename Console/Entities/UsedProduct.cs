using System;

using System.Globalization;

namespace Exercicio.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufacturedDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            this.manufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2",CultureInfo.InvariantCulture) + " Manufecture date: " + manufacturedDate.ToString("dd/MM/yyyy");
        }
    }


}
