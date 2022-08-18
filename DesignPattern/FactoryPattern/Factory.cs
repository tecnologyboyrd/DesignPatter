using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    //Creator
    public abstract class SalesFactory
    {
        public abstract Isales GetSales();
    }

    //Concret Creator
    public class StoreSaleFactory : SalesFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override Isales GetSales()
        {
            return new StoreSale(_extra);
        }
    }

    //Concret Internet Creator (ejemplo de fabrica)
    public class InternetSaleFactory : SalesFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override Isales GetSales()
        {
            return new InternetSale(_discount);
        }
    }

    //Contret product Internet (ejemplo)
    public class InternetSale : Isales
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta POR INTERNET tiene un total de {total - _discount}");
        }
    }

    //Contret product
    public class StoreSale : Isales
    {
        private decimal _extra;

        public StoreSale (decimal extra) => _extra = extra;
        /*
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        */
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta EN TIENDA tiene un total de {total + _extra}");
        }
    }

    //Product
    public interface Isales
    {
        public void Sell(decimal total);
    }

    
}
