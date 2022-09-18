using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatterm
{
    public class PreparedAlcoholicDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;

        public PreparedAlcoholicDrinkConcreteBuilder()
        {
            Reset();
        }
        public void AddIngredients(string ingredients)
        {
            if (_preparedDrink == null)
            {
                _preparedDrink.Ingredients = new List<string>();
            }
            else
            {
                _preparedDrink.Ingredients.Add(ingredients);
            }
        }

        public void Mix()
        {
            string ingredients = _preparedDrink.Ingredients.Aggregate((i, j) => i + "\n " + j);

            _preparedDrink.result = $"Bebida Preparada con {_preparedDrink.alcohol} de Alcohol, con los siguientes ingredientes: \n {ingredients}";

            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Reset()
        {
            _preparedDrink = new PreparedDrink();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beberse");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.alcohol = alcohol;
        }

        public void setMilk(int milk)
        {
            _preparedDrink.Milks = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }

        public PreparedDrink GetPreparedDrink() => _preparedDrink;
    }
}
