// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/
/*Console.WriteLine("Ingrese un numero positivo:");
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
int a;
do{
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Producto");
    Console.WriteLine("4-Division");
    Console.WriteLine("5-Salir");
    Console.WriteLine("Ingrese una opcion:");

    float A, B;
    bool control = int.TryParse(Console.ReadLine(), out a);
    if(control){
            switch(a){
            case 1:
                Console.WriteLine("Ingrese los valores a sumar: ")
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A+B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.")
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Ingrese los valores a restar: ")
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A-B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.")
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Ingrese los valores a multiplicar: ")
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A*B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.")
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Ingrese los valores a dividir: ")
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A/B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.")
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Muchas gracias por elegirnos.");
                break;
            }
    }else{
        Console.WriteLine("No ingreso un numero. Presione una tecla para continuar.");
        Console.ReadKey();
    }
}while( a < 5);

