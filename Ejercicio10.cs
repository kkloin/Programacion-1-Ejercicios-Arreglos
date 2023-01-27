class Ejercicio10 {
    public static void Main (string[] args) {

        int[] _numeros = new int[10];
        int _numDivisor = 0;
        int _divExactos = 0;

        Console.WriteLine("Ingresa 10 numeros:");
        for (int i = 0; i < 10; i++) {
            while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {
                Console.WriteLine("Por favor ingresa un numero valido:");
            }
        }
        Console.WriteLine("Ingresa un numero para buscar sus divisores en el arreglo:");
        while (!int.TryParse(Console.ReadLine(), out _numDivisor)) {
                Console.WriteLine("Por favor ingresa un numero valido:");
        }
        for (int i = 0; i < 10; i++) {
            if (_numeros[i] % _numDivisor == 0) {
                _divExactos++;
            }
        }
        Console.WriteLine("El numero {0} tiene {1} divisores exactos entre los numeros del arreglo", _numDivisor, _divExactos);

        Console.WriteLine();
        Console.Write("Pulsa cualquier tecla para salir.");
        Console.ReadLine();
    }
}