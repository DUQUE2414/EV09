using System;

try
{
    Console.WriteLine("Ingrese su edad");
    string input = Console.ReadLine()!;
    int edad = int.Parse(input);

    if (edad < 0 || edad > 120)
    {
        throw new EdadInvalidaExepcion("La edad debe estar entre 0 y 120 años");
    }

    Console.WriteLine($"Edad valida {edad}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Debes introducir un número válido");
}
catch (EdadInvalidaExepcion ex)
{
    Console.WriteLine($"Error de validación: {ex.Message}");
}
finally
{
    Console.WriteLine("Proceso de validación finalizado");
}
class EdadInvalidaExepcion : Exception
{
    public EdadInvalidaExepcion(string mensaje) : base(mensaje) { }
}
