//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-6.0
//LIST<T> list = new List<T>();

//Crear una lista de enteros
List<int> lista = new List<int>();
//Agregar elementos a la lista
lista.Add(1);
lista.Add(2);
lista.Add(3);
lista.Add(4);
lista.Add(5);

Console.WriteLine("Elementos de la lista");
//Imprimir la lista foreach
foreach (int item in lista)
{
    Console.WriteLine(item);
}

//Eliminar un elemento de la lista
lista.Remove(3);
Console.WriteLine("Eliminar un elemento de la lista lista.Remove(3)");	   


Console.WriteLine("Elementos de la lista");
//Remover un elemento de la lista
lista.Remove(3);
//Imprimir la lista usando un indice
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}
//crar una lista de criptomoneda
List<Criptomoneda> criptomonedas = new List<Criptomoneda>();
//agregar elementos a la lista
criptomonedas.Add(new Criptomoneda("Bitcoin","BTC", 10000));
criptomonedas.Add(new Criptomoneda("Ethereum", "ETH",2000));
criptomonedas.Add(new Criptomoneda("Ripple","XRP" ,1000));
criptomonedas.Add(new Criptomoneda("Litecoin","LTC", 500));

Console.WriteLine("Elementos de la lista");
//Imprimir la lista foreach
foreach (Criptomoneda item in criptomonedas)
{
    Console.WriteLine(item.ToString());
}
 
 

class Criptomoneda
{
    public string nombre;
    public string simbolo;
    public double precio;
    public Criptomoneda(string nombre, string simbolo, double precio)
    {
        this.nombre = nombre;
        this.simbolo = simbolo;
        this.precio = precio;
    }
    
    public override string ToString()
    {
        return "Nombre: " + nombre + " Simbolo: " + simbolo + " Precio: " + precio;
    }
   
}//end class criptomoneda
    





