
class Ejercicio7 {
  public static void Main (string[] args) {
    int[] _numeros = new int[10];
    int _suma = 0;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Ingrese un número entero:");
      while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {
        Console.WriteLine("Por favor ingrese un número valido:");
      }
      _suma += _numeros[i];
    }
    int _promedioNumeros = _suma / 10;
    Console.WriteLine("El promedio entero de los datos del arreglo es " + _promedioNumeros);

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();
  }
}
