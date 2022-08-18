// See https://aka.ms/new-console-template for more information
using DesignPattern;
using DesignPattern.FactoryPattern;
using DesignPattern.Models;
using DesignPattern.Singleton;
using DesignPattern.UnitOfWork;

//Console.WriteLine("Hello, World!");


//var log = Log.Instance;

//log.Save("Se creo el archivo");

//log.Save("Se le agrego otra linea");

//var a = Log.Instance;
//var b = Log.Instance;

//Console.WriteLine(a == b);


//LPS_Singleton_practice SingletonPractice = LPS_Singleton_practice.Singleton_Practice;

//Console.WriteLine("Ingrese lo que quiere grabar");

//string ?messageLeo = Console.ReadLine();

//SingletonPractice.SaveFile(messageLeo);

//Console.WriteLine("Archivo guardado");

//Console.WriteLine($"Me fui en segueta duplicando numeros con LAMBDA, estoy multiplicando 1590 x 2 = {Lambda.Duplied(1590)}" );

//Console.WriteLine($"ahora rompi dividiendo 20 / 10 = {Lambda.Divide(20,10)}");

//Lambda Lambdaf = new Lambda();


//var numbers = new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

//Func<int, bool> GetPais = (number) => number % 2 == 0;

//var Pairs = numbers.Where(GetPais);

//foreach (int x in Pairs)
//{

//    Console.WriteLine($"Pares: {x}");

//}


//Console.WriteLine($"El resultado de la operacion es {Funciones.operacioensBasica(10, 5, "resta")}");

////Expresiones Lambda : Un tipo de funcion, pero es una funcion anonima.

//Func<int, int> NumeroAlCuadrado = (x) => x * x;

//Func<int, int, int> suma = (x,z) => z + x;

//Action<int> CuadradoAutonomo = (x) => Console.WriteLine($"El cuadrado autonomo es {x*x}");

//Func<int, int, int> Operacionx = (x, y) =>
//{
//    if (x > y)
//    {
//        x = x * x;
//        y = y - 3;
//    }

//    return (x * y) * 2;
//};


//Console.WriteLine($"El numero al cuadrado da {NumeroAlCuadrado(5)}");
//Console.WriteLine($"El numero de la suma es {suma(30,5)}");
//Console.WriteLine($"El numero de OperacionX es {Operacionx(30, 5)}");

//CuadradoAutonomo(6);

//var numeros = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

//Func<int, bool> GetPairs = (numeros) => numeros % 2 == 0;

//var PairList = numeros.Where(GetPairs);

//var PairList2 = numeros.Select(x => x % 2 == 0 ? x : 0).Where(x=>x!=0);

//Console.WriteLine("Los numeros pares son: " + String.Join(" - ", PairList));
//Console.WriteLine("Los numeros pares son: " + String.Join(" - ", PairList2));

//public class Funciones
//{    
//    public static int operacioensBasica(int valor1, int valor2, string operacion)
//    {
//        int resultado = 0;

//        switch (operacion)
//        {
//            case "suma":
//                {
//                    resultado = suma(valor1, valor2);

//                }break;
//            case "resta":
//                {
//                    resultado = resta(valor1, valor2);

//                }
//                break;
//        }


//        return resultado;


//        int suma(int v1, int v2)
//        {
//            return v1 + v2;
//        }

//        int resta(int v1, int v2)
//        {
//            return v1 - v2;
//        }
//    }
//}

#region "This is the code of test Factory Method"
//SalesFactory storeSalesFactory = new StoreSaleFactory(10);
//SalesFactory internetSalesFactory = new InternetSaleFactory(2);

//Isales sales = storeSalesFactory.GetSales();
//sales.Sell(15);

//Isales Sales2 = internetSalesFactory.GetSales();
//Sales2.Sell(15);

#endregion

#region "This is the code of test Repository Pattern"
//using (var context = new DesignPatternsContext())
//{
//    var list = context.Users.ToList();

//    foreach (var users in list)
//    {
//        Console.WriteLine(users.UserName);
//    }
//}
#endregion


#region "Ejemplo de consola de UnitOfWork
using (var context = new DesignPatternsContext())
{
    var unitOfWork = new UnitOfWork(context);

    var users = unitOfWork.Users;

    var user = new User()
    {
        UserFullName = "Vivian Perez",
        UserName = "vperez",
        Password = "Candy"
    };

    users.Add(user);
        
    var roles = unitOfWork.Roles;

    var role = new Role()
    {
        Description = "Consultor"
    };

    roles.Add(role);

    unitOfWork.Save();
}

#endregion





