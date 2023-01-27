using System.Linq; //Libreria para trabajar con colecciones de datos. 
// La usas para buscar las posiciones de los numeros del arreglo que mas de 3 digitos. 

class Ejercicio6 {
  public static void Main (string[] args) {
    int[] _numeros = new int[10];

    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Ingrese el numero entero en la posicion " + (i+1) + ":");
      string _entradaConsola = Console.ReadLine();
      if(!int.TryParse(_entradaConsola, out _numeros[i]))
      {
        Console.WriteLine("Debe ingresar un numero entero, vuelva a intentarlo");
        i--;
        continue;
      }
    }
    var _posicion = Enumerable.Range(0, _numeros.Length)
                             .Where(x => _numeros[x].ToString().Length > 3)
                             .Select(x => x+1);
    if(_posicion.Count() == 0)
    {
        Console.WriteLine("No hay numeros con mas de 3 digitos.");

        Console.WriteLine();
        Console.Write("Pulsa cualquier tecla para salir.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Los numeros con mas de 3 digitos se encuentran en las posiciones: ");
        foreach(int _lugar in _posicion)
        {
            Console.Write(_lugar + " ");
        }

        Console.WriteLine();
        Console.Write("Pulsa cualquier tecla para salir.");
        Console.ReadLine();
    }
  }
}
