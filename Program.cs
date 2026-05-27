using System;
using System.ComponentModel.Design;

namespace proyecto_GT13GP06
{
	class Program
	{
		static void Main(string[] args)
        {
            int seleccionMenu = 0; 

            do
            {   
            Console.WriteLine("Librería y Papelería Universitaria UES");
            Console.WriteLine("======================================================\n");

            //menú principal
            Console.WriteLine("Seleccione una opción del menú para continuar.");
            Console.Write(@"
            1. Registro de usuario 
            2. Catálogo de servicios 
            3. Gestión de pedido 
            4. Facturación y liquidación 
            5. Búsqueda de servicio por código 
            6. Ordenar servicios por precio 
            7. Salir: 
            Ingrese aquí: ");

            //lee la entrada del usuario segun el menú y verifica si es un número valido
            if (!int.TryParse(Console.ReadLine(), out seleccionMenu) || seleccionMenu <= 0 || seleccionMenu > 7)
            {
                Console.WriteLine("Entrada inválida. Debe ser un número en base a las opciones del menú.\n");
                continue;
            }

            }while(seleccionMenu <= 0 || seleccionMenu > 7);

            
        }
	}


}
