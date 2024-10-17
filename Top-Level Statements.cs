/* 
    Esta clase funciona en base a los 'Top-Level Statements'.
    Estos permiten que toda esta clase funcione como el método static void Main(string[] args).
    Solamente se puede tener un archivo que funcione como Top-Level Statements.
    Si se encuentra un método Main(), se lanzará una advertencia, diciendo que será ignorado.
*/

// EJEMPLO:
// Console.WriteLine("Hello, world");

/*
    Para poder utilizar el contenido de las librerias, estas deben de estar declaradas al inicio de los archivos.
*/

/*
using System.Text;

StringBuilder builder = new();
builder.AppendLine("The following arguments are passed: ");

foreach (var arg in args) {
    builder.AppendLine($"Argument={arg}");
}

Console.WriteLine(builder.ToString());
*/

/*
    Los Top-Level Statements están incluidas dentro del namespace global de manera implícita.
*/

/*
    El archivo que contenga los Top-Level Statements, puede contener namespaces y definiciones.
    Sim embargo, estos tienen que estar después de los Top-Level Statements.
*/

/*
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

public class MyClass {
    
    public static void TestMethod() {
        Console.WriteLine("Hello World!");
    }
}

namespace MyNamespace {

    class MyClass {

        public static void MyMethod() {
            Console.WriteLine("Hello world from MyNamespace.MyClass.MyMethod!");
        }
    }
}
*/

/*
    Los Top-Level Statements pueden acceder a la variable 'args'.
    Esta variable nunca será null, sin embargo, puede estar vacia.
*/

/*
if (args.Length > 0) {
    foreach (var arg in args) {
        Console.WriteLine($"Argument={arg}");
    }
}
else {
    Console.WriteLine("No arguments");
}
*/

/*
    Puedes llamar un async usando la palabra clave 'await'.
*/

/*
Console.Write("Hello ");
await Task.Delay(5000);
Console.WriteLine("World!");
*/

/* 
    Para devolver un valor int cuando la aplicación termina, usa la declaración 'return', como lo harias en un método Main().
 */

/* 
string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;
 */

/*
    El compilador generará de forma implicita un tipo de Main() u otro, dependiendo de si los Top-Level Statements
    contienen las palabras clave 'await' o 'return'. 

    'await' y 'return' = static async Task<int> Main(string[] args)}
    'await'            = static async Task Main(string[] args)
    'return'           = static int Main(string[] args)
    nothing            = static void Main(string[] args)
*/