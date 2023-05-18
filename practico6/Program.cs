// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
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
}
