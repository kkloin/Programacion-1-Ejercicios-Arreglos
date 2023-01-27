class Ejercicio1 {
  public static void Main (string[] args) {
    int[] _numeros = new int[10];
    int _mayorValor = 0;
    int _mayorPosicion = 0;
    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Ingrese un numero entero: ");

      while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {  
          Console.WriteLine("Lo que usted escribio no es un numero entero. Ingrese un valor valido");
      }
      if (_numeros[i] > _mayorValor) {
        _mayorValor = _numeros[i];
        _mayorPosicion = i;
      }
    }
    Console.WriteLine("El numero de mayor valor es " + _mayorValor + " y se encuentra en la posicion " + _mayorPosicion);

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();
  }

}
