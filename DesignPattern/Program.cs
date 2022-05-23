// See https://aka.ms/new-console-template for more information
using DesignPattern;
using DesignPattern.Singleton;

//Console.WriteLine("Hello, World!");


//var log = Log.Instance;

//log.Save("Se creo el archivo");

//log.Save("Se le agrego otra linea");

//var a = Log.Instance;
//var b = Log.Instance;

//Console.WriteLine(a == b);


LPS_Singleton_practice SingletonPractice = LPS_Singleton_practice.Singleton_Practice;

Console.WriteLine("Ingrese lo que quiere grabar");

string ?messageLeo = Console.ReadLine();

SingletonPractice.SaveFile(messageLeo);

Console.WriteLine("Archivo guardado");


