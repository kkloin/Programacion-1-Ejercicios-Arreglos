class Ejercicio9 {

  public static void Main (string[] args) {

    int[] _numerosOriginales = new int[10];
    int[] _numerosFactoriales = new int[10];

    for(int i = 0; i < 10; i++) {
        Console.WriteLine("Ingrese un numero entero: ");
        string _entradaConsola = Console.ReadLine();
        int _numero;
        if(int.TryParse(_entradaConsola, out _numero)){
          _numerosOriginales[i] = _numero;
          _numerosFactoriales[i] = Factorial(_numerosOriginales[i]);
        } else {
          Console.WriteLine("El valor ingresado no es un numero entero, intente nuevamente.");
          i--;
        }
    }
    Console.WriteLine("Los valores del arreglo son: " + string.Join(", ", _numerosOriginales));
    Console.WriteLine("Los factoriales de los valores del arreglo son: " + string.Join(", ", _numerosFactoriales));

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();
  }
    public static int Factorial(int _num) {
    if (_num == 0 || _num == 1) {
        return 1;
    } else {
        return _num * Factorial(_num - 1);
    }
  }
}


