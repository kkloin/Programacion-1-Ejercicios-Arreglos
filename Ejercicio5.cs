class Ejercicio5 {
    public static void Main (string[] args) {
        
        int[] _numeros = new int[10];
        int _mayorNumPrimo = 0;
        int _mayorPosicion = 0;
        int _mayorNumPrimoPar = 0;

        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingrese un número entero:");
            while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {
                Console.WriteLine("Lo que escribiste no es una entrada valida. Por favor ingrese un número entero:");
            }
        }

        for (int i = 0; i < 10; i++) {
            int _digitosPares = 0;
            if (NumPrimo(_numeros[i])) {
                if (_numeros[i] > _mayorNumPrimo) {
                    _mayorNumPrimo = _numeros[i];
                    _mayorPosicion
         = i;
                }
                int temp = _numeros[i];
                while (temp > 0) {
                    int digit = temp % 10;
                    if (digit % 2 == 0) {
                        _digitosPares++;
                    }
                    temp /= 10;
                }
                if (_digitosPares > _mayorNumPrimoPar) {
                    _mayorNumPrimoPar = _digitosPares;
                    _mayorPosicion
         = i;
                }
            }
        }

        Console.WriteLine("El número primo con mayor cantidad de dígitos pares se encuentra en la posición " + _mayorPosicion + " del arreglo y es " + _mayorNumPrimo);
        
        Console.WriteLine();
        Console.Write("Pulsa cualquier tecla para salir.");
        Console.ReadLine();
    }

    public static bool NumPrimo(int _num) {
        if (_num <= 1)
            return false;
        if (_num <= 3)
            return true;
        if (_num % 2 == 0 || _num % 3 == 0)
            return false;
        for (int i = 5; i * i <= _num; i = i + 6)
            if (_num % i == 0 || _num % (i + 2) == 0)
                return false;
        return true;
    }
}
