// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingrese un numero positivo:");
int a;
bool control = int.TryParse(Console.ReadLine(), out a);
int inv;
int invdo = 0;

if(control){
        while(a>=10){
            inv = a%10;
            a=a/10;
            invdo = invdo*10 + inv;
        }

        invdo = invdo*10 + a;


        Console.WriteLine("valor de a invertido:"+invdo);
}*/

Console.WriteLine("Ingrese una frase larga: ");
string aux;
aux = Console.ReadLine().ToString();
Console.WriteLine("El tamaño de tu frase es: "+ aux.Length); // lee la cantidad de espacios y letras de una cadena
Console.WriteLine("Ingrese su segunda frase: ");
String aux2;
aux2 = Console.ReadLine().ToString();
string cadenaSalida = $"{aux} {aux2}"; // caracter $ permite ingresar variables sin concatenar
Console.WriteLine("Cadenas concatenadas: "+cadenaSalida);
string cortada = aux.Substring(0,3); //separa las 3 primeras letras de una cadena 
Console.WriteLine("Cadena ingresada cortada en solo 3 letras: "+cortada);
foreach (var item in aux) //structura de iteracion
{
    Console.WriteLine(item);
}
Console.WriteLine("Ingrese palabra a buscar: ");
string buscar= Console.ReadLine().ToString();
bool contiene = aux2.Contains(buscar); // comprueba si es que una palabra esta contenida en una cadena de caracteres
if(contiene){
    Console.WriteLine("Contiene la palabra");
}else{
    Console.WriteLine("No contiene la palabra");
}
Console.WriteLine("Frase ingresada en minuscula seria: ");
string mayuaux2= aux2.ToLower(); //transforma una cadena a minuscula
Console.WriteLine(mayuaux2);
Console.WriteLine("Frase ingresada en mayuscula seria: ");
string minaux2 = aux2.ToUpper(); //tranforma una cadena a mayuscula
Console.WriteLine(minaux2);
Console.WriteLine("Ingrese una ultima frase separada por algun caracter: ");
string palabras=Console.ReadLine().ToString();
string [] palabra= palabras.Split("+"); //separa la palabra en donde aparezca el caracter +
foreach (var item in palabra)
{
    Console.WriteLine(item);
}