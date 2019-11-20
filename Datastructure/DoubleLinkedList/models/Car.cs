using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class Car
    {
        private decimal _price;

        public string Brand { get; set; }
        public string Colour { get; set; }
        public decimal Price
        {
            get { return this._price; }
            set
            {
                if (value >= 0.0m)
                {
                    this._price = value;
                }
            }
        }

        public Car() : this("", "", 0.0m) { }
        public Car(string brand, string colour, decimal price)
        {
            this.Brand = brand;
            this.Colour = colour;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Brand + " " + this.Colour + " " + this.Price + " ";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Car);
        }

        public bool Equals (Car obj)
        {
            if (obj == null)
            {
                return false;
            }

            if ((obj.Brand == this.Brand) && (obj.Colour == this.Colour) && (obj.Price == this.Price))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            
            var hashCode = -1786895991;

          
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Brand);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Colour);
            hashCode = hashCode * -1521134295 + EqualityComparer<decimal>.Default.GetHashCode(Price);

            return hashCode;
        }


    }
}
