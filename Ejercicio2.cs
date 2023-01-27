class Ejercicio2 {
  public static void Main (string[] args) {

    int[] _numeros = new int[10];
    int _mayorValorPar = 0;
    int _mayorPosicion = 0;

    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Ingrese un numero entero: ");

      while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {
          Console.WriteLine("Ingrese un valor valido");
      }

      if (_numeros[i] % 2 == 0 && _numeros[i] > _mayorValorPar) {
        _mayorValorPar = _numeros[i];
        _mayorPosicion = i;
      }
    }
    Console.WriteLine("El mayor numero par es " + _mayorValorPar + " y se encuentra en la posicion " + _mayorPosicion);

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();
  }
}
