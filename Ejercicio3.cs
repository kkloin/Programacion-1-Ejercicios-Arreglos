class Ejercicio3 {
    public static void Main(string[] args) {
        int[] _numeros = new int[10];
        int _mayorValorPrimo = 0;
        int _posicionMayor = 0;
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingrese un numero entero: ");

            while (!int.TryParse(Console.ReadLine(), out _numeros[i])) {
                Console.WriteLine("Ingrese un valor valido");
            }
            if (NumPrimo(_numeros[i]) && _numeros[i] > _mayorValorPrimo) {
                _mayorValorPrimo = _numeros[i];
                _posicionMayor = i;
            }
        }
        Console.WriteLine("El mayor numero primo es " + _mayorValorPrimo + " y se encuentra en la posicion " + _posicionMayor);
    }
    public static bool NumPrimo(int _num) {
        if (_num <= 1) return false;
        if (_num <= 3) return true;
        if (_num % 2 == 0 || _num % 3 == 0) return false;
        for (int i = 5; i * i <= _num; i = i + 6)
            if (_num % i == 0 || _num % (i + 2) == 0)
                return false;
        return true;
    }
}
