try
        {
            System.Console.WriteLine("Ingrese su edad");
            string input = Console.ReadLine()!;
            int edad = int.Parse(input);

            if (edad < 0 || edad > 120)
            {
                throw new EdadInvalidaExepcion("La edad debe estar entre 0 y 120 años");
            }

            System.Console.WriteLine($"Edad valida ${edad}");
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Error: Debes introducir un número válido");
        }
        catch (EdadInvalidaExepcion ex)
        {
            Console.WriteLine($"Error de validación: {ex.Message}");
        }
        finally{
            System.Console.WriteLine("Proceso de validación finalizado");
        }