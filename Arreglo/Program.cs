class Prograam
{
    static void Main(string[] args)
    {

            //arreglo de enteros
        int[] arreglo = new int[5];
        //Crear e inicializar un arreglo
        int[] arreglo2 = {1,2,3,4,5};
        //Acceder al primer  elemento del arreglo2
        Console.WriteLine(arreglo2[0]);

        //actulizar elemento 2 del arreglo
        arreglo2[1] = 10;
        Console.WriteLine(arreglo2[1]);
        imprimirArreglo(arreglo2);
        //Inicializar arreglo de contactos 
        Contacto[] contactos = new Contacto[5];
        contactos[0] = new Contacto("Juan","123456","juan@mail.com");
        contactos[1] = new Contacto("Pedro","123456","pedro@gmail.com");
        contactos[2] = new Contacto("Maria","123456","maria@gmail.com");
        contactos[3] = new Contacto("Luis","123456","luis@gmail.com");
        contactos[4] = new Contacto("Ana","123456","ana@gmail.com");    
        imprimirArreglo(contactos);


        //llenarArreglo(arreglo);
        //imprimirArreglo(arreglo);
    }



    //metodo para llenar el arreglo
    static void llenarArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine("Ingrese el valor de la posicion {0}", i);
            arreglo[i] =Convert.ToInt32(Console.ReadLine());
        }
    }

    //metodo para imprimir el arreglo
    static void imprimirArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine("El valor de la posicion {0} es {1}", i, arreglo[i]);
        }
    }

    static void imprimirArreglo(Contacto[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine("El valor de la posicion {0} es {1}", i, arreglo[i].Nombre);
        }
    }   

}