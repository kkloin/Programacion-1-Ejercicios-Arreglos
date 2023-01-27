int[] _numeros = new int[10];
int _cuentaNum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingresa un número entero:");
    string _entradaConsola = Console.ReadLine();
    int _numEntero;
    if (int.TryParse(_entradaConsola, out _numEntero)) //Comprobación de que es un número entero.
    {
        _numeros[i] = _numEntero;
        double firstDigit = char.GetNumericValue(_entradaConsola[0]);
        if (NumPrimo(firstDigit))
        {
            _cuentaNum++;
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida, por favor ingresa un número entero.");
        i--;
    }
}
Console.WriteLine("Existen " + _cuentaNum + " números que comienzan con un digito primo.");

    Console.WriteLine();
    Console.Write("Pulsa cualquier tecla para salir.");
    Console.ReadLine();

// Funcion para determinar si un numero es primo o no
bool NumPrimo (double _num)
{
    if (_num <= 1) return false;
    if (_num <= 3) return true;
    if (_num % 2 == 0 || _num % 3 == 0) return false;
    for (int i = 5; i * i <= _num; i = i + 6)
        if (_num % i == 0 || _num % (i + 2) == 0)
            return false;
    return true;
}
