// See https://aka.ms/new-console-template for more information
//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
//Dictionary<TKey,TValue> Objeto
//TKey: Tipo de dato de la llave
//TValue: Tipo de dato del valor

//Crear un diccionario de criptomonedas nombre edad
Dictionary<string, int> MyDicionario = new Dictionary<string, int>();
//Agregar elementos al diccionario
 MyDicionario.Add("Alex", 24);
 MyDicionario.Add("Juan", 25);
 MyDicionario.Add("Pedro", 26);
 MyDicionario.Add("Maria", 27);

//Recorrer el diccionario
foreach (KeyValuePair<string, int> item in MyDicionario)
{
    Console.WriteLine("Nombre: {0}, Edad: {1}", item.Key, item.Value);
}

//elininar un elemento del diccionario
MyDicionario.Remove("Pedro");

//otbener el valor de un elemento del diccionario
Console.WriteLine("La edad de Juan es: {0}", MyDicionario["Juan"]);


//Recorrer el diccionario
foreach (KeyValuePair<string, int> item in MyDicionario)
{
    Console.WriteLine("Nombre: {0}, Edad: {1}", item.Key, item.Value);
}




