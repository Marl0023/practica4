using Practica4;
int opc;
string continuar;
Product product=new Product();
do {
    Console.WriteLine("Bienvenidos al sistema de registro de productos:\n");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Modificar producto");
    Console.WriteLine("0. Salir");
    do {
        Console.Write("Ingrese una opcion: ");
        opc=int.Parse(Console.ReadLine());
    }while (opc < 0 || opc>3);
    switch (opc)
    {
        case 1:
            product.Registrar();
            break;
        case 2:
            product.Mostrar();
            break;
        case 3: 
            product.Modificar();
            break;

    }
    Console.Write("\nRegresar al menu [SI] o para salir cualquier tecla: ");
    continuar = Console.ReadLine().ToUpper().Trim();
    Console.Clear();
} while (continuar=="SI");
Console.ReadKey();