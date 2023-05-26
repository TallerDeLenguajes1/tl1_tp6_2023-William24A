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
int a; //Las variables deben declararse antes de ser usadas, cuando existen casos de do while
//debemos iniciar antes del ingresar al do
do{
    Console.WriteLine("Elija una opcion"); //Escribe la linea que esta entre comillas
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Producto");
    Console.WriteLine("4-Division");
    Console.WriteLine("5-Datos de un número");
    Console.WriteLine("6-Maximo y minimo");
    Console.WriteLine("7-Salir");
    Console.WriteLine("Ingrese una opcion:");

    float A, B;//vaiables a sumar,restar,dividir o multiplicar
    bool control = int.TryParse(Console.ReadLine(), out a); //usamos este codigo para transformar una cadena a entero
    if(control){
            switch(a){
            case 1:
                Console.WriteLine("Ingrese los valores a sumar: ");
                //en este caso usamos una cadena para ingresar un float
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A+B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Ingrese los valores a restar: ");
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A-B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Ingrese los valores a multiplicar: ");
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A*B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Ingrese los valores a dividir: ");
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    Console.WriteLine(A/B);
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("Ingrese un número:");
                if(float.TryParse(Console.ReadLine(), out A)){
                    Console.WriteLine("El valor absoluto de "+A+" es: "+Math.Abs(A));
                    Console.WriteLine("El cuadrado del numero "+A+" es: "+Math.Pow(A,2));
                    if(A>=0){
                        Console.WriteLine("La raiz del numero "+A+" es: "+Math.Sqrt(A));
                    }
                    Console.WriteLine("El valor del seno es: "+Math.Asin(A));
                    Console.WriteLine("El valor del coseno es: "+Math.Acos(A));
                    Console.WriteLine("El valor entero es: "+(int)Math.Floor(A));
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
                }
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadKey();
                break;
            case 6:
                Console.WriteLine("Ingrese los valores a comparar: ");
                if(float.TryParse(Console.ReadLine(), out A) && float.TryParse(Console.ReadLine(), out B) ){
                    if(A>=B){
                        Console.WriteLine("El maximo es: "+A);
                        Console.WriteLine("El minimo es: "+B);
                    }else{
                        Console.WriteLine("El maximo es: "+B);
                        Console.WriteLine("El minimo es: "+A);
                    }
                }else{
                    Console.WriteLine("Debe ingresar numeros.");
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
}while( a < 7);

