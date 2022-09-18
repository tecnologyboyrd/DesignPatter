using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatterm
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 Limones");
            _builder.AddIngredients("Pizca de sal");
            _builder.AddIngredients("1/2 Taza de Tequila");
            _builder.AddIngredients("3/4 Taza de Licor de naranja");
            _builder.AddIngredients("4 Cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PreparePinaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.AddIngredients("1/2 Taza de Ron");
            _builder.AddIngredients("1/4 Taza de crema de coco");
            _builder.AddIngredients("3/4 de Tasa de Jugo de Piña");
            _builder.setMilk(500);
            _builder.SetWater(10);
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PrepareFrutPonch()
        {
            _builder.Reset();
            _builder.SetAlcohol(19);
            _builder.SetWater(0);
            _builder.AddIngredients("Pizca de sal");
            _builder.AddIngredients("1 Taza de FrutPonch");
            _builder.AddIngredients("1/2 Taza de Tequila");
            _builder.AddIngredients("3/4 Taza de Licor de naranja");
            _builder.AddIngredients("4 Cubos de hielo");
            _builder.Mix();
            _builder.Rest(1000);

        }
    }
}
