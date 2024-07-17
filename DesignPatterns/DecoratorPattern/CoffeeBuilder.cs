using System.Collections.Generic;

namespace DecoratorPattern
{
    public class CoffeeBuilder
    {
        private string sort;
        private List<Milk> milks = new List<Milk>();
        private List<Sugar> sugars = new List<Sugar>();

        public CoffeeBuilder()
        {
        }

        public CoffeeBuilder SetBlackCoffee()
        {
            sort = "Black";
            milks.Clear();
            sugars.Clear();
            return this;
        }

        public CoffeeBuilder SetCubanoCoffee()
        {
            sort = "Cubano";
            milks.Clear();
            sugars.Clear();
            sugars.Add(new Sugar("Brown"));
            return this;
        }

        public CoffeeBuilder SetAmericanoCoffee()
        {
            sort = "Americano";
            milks.Clear();
            sugars.Clear();
            milks.Add(new Milk(0.5));
            return this;
        }

        public CoffeeBuilder WithMilk(double fat)
        {
            milks.Add(new Milk(fat));
            return this;
        }

        public CoffeeBuilder WithSugar(string sort)
        {
            sugars.Add(new Sugar(sort));
            return this;
        }

        public Coffee Build()
        {
            return new Coffee(sort, milks, sugars);
        }
    }

    public class Coffee
    {
        public string Sort { get; set; }
        public List<Milk> Milk { get; set; }
        public List<Sugar> Sugar { get; set; }

        public Coffee(string sort, List<Milk> milk, List<Sugar> sugar)
        {
        }
    }

    public class Milk
    {
        double Fat { get; set; }

        public Milk(double fat)
        {
        }
    }

    public class Sugar
    {
        public string Sort { get; set; }

        public Sugar(string sort)
        {
        }
    }
}
