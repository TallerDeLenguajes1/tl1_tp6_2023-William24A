// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
Console.WriteLine("Ingrese un numero:");
string A = Console.ReadLine();
int a =Int32.Parse(A);
int inv;
int invdo = 0;
while(a>=10){
    inv = a%10;
    a=a/10;
    invdo = invdo*10 + inv;
}

invdo = invdo*10 + a;


Console.WriteLine("valor de a invertido:"+invdo);