class Ejercicio8 {
  public static void Main (string[] args) {
    int[] _numeros = new int[10];
    int _numerosNegativos = 0;

    for (int i = 0; i < 10; i++) {
        Console.WriteLine("Introduce el número entero en la posición " + (i + 1) + ":");
        string input = Console.ReadLine();
        bool _numValido = int.TryParse(input, out int _numero);
        if(_numValido){
          _numeros[i] = _numero;
          if (_numero < 0) {
              _numerosNegativos++;
          }
        }else{
          Console.WriteLine("Entrada no valida, vuelve a intentarlo.");
          i--;
        }
    }

    Console.WriteLine("Hay " + _numerosNegativos + " números negativos en el arreglo.");

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();
  }
}
