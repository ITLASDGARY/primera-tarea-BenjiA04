namespace MiCli;

// TODO: Declara una constante e intenta cambiar su valor para ver el error
public class Ejercicio3_ErrorIntencional
{
    public static string UsarConstanteCorrectamente()
    {
        // TODO: Declara una constante int
        const int constante = 15;
        // TODO: Intenta cambiar su valor en la siguiente línea (esto causará un error)
        // Valor = 18;
        // TODO: Lee el error que te da Visual Studio
        Console.WriteLine(constante);
        // TODO: Comenta la línea que causa el error
        // TODO: Retorna un mensaje con el valor de la constante
        return $"Este es el valor de mi constante: {constante}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(UsarConstanteCorrectamente());
    }
}
