namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            int opcion = 0;
            int dato = 0;

            while(opcion != 8)
            {
                Console.WriteLine("Escoja una opción");
                Console.WriteLine("1.- Insertar en el principio\n" +
                                  "2.- Insertar en el final\n" +
                                  "3.- Eliminar en el principio\n" +
                                  "4.- Eliminar en el final\n" +
                                  "5.- Imprimir lista\n" +
                                  "6.- Insertar en medio\n" +
                                  "7.- Eliminar en medio\n"+
                                  "8.- Salir");
                string opcionS = Console.ReadLine();
                if(opcionS == "")
                {
                    Console.WriteLine("Favor de elegir una opción");
                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingrese un valor");
                            dato = Convert.ToInt32(Console.ReadLine());
                            lista.InsertarPrincipio(dato);
                            break;
                        case "2":
                            Console.WriteLine("Ingrese un valor");
                            dato = Convert.ToInt32(Console.ReadLine());
                            lista.InsertarFinal(dato);
                            break;
                        case "3":

                            lista.EliminarPrincipio();
                            break;
                        case "4":
                            lista.EliminarFinal();
                            break;
                        case "5":

                            lista.ImprimirLista();
                            break;
                        case "6":
                            Console.WriteLine("Ingrese un valor");
                            dato = Convert.ToInt32(Console.ReadLine());
                            lista.InsertarMedio(dato);
                            break;
                        case "7":
                            lista.EliminarMedio();
                            break;
                        case "8":
                            opcion = Convert.ToInt32(opcionS);
                            break;
                        default:
                            Console.WriteLine("Valor no contemplado, intente de nuevo");
                            break;
                    }
                }

            }

        }
    }
}