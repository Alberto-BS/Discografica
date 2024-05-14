// See https://aka.ms/new-console-template for more 
using Discografica;

Cancion pepinillo = new Cancion (3, 30);
Cancion melissa = new Cancion (3, 30);
Cancion fantasmas = new Cancion (3, 30);

ListaReproduccion lista = new ListaReproduccion();
lista.AddCanciones(pepinillo);
lista.AddCanciones (melissa);
lista.AddCanciones (fantasmas);

Console.WriteLine(lista.DuracionTotal);
 