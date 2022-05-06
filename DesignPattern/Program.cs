// See https://aka.ms/new-console-template for more information
using DesignPattern;
using DesignPattern.Singleton;

Console.WriteLine("Hello, World!");


var log = Log.Instance;

log.Save("Se creo el archivo");

log.Save("Se le agrego otra linea");

var a = Log.Instance;
var b = Log.Instance;

Console.WriteLine(a == b);


