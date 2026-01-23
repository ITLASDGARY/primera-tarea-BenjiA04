namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        string nombre = "Benjamin Alcequiez";
        string carrera = "Ingenieria de Software.";
        string hobby = "Ver series y peliculas, comer y leer mangas.";
        // TODO: Retorna un string con las tres variables en líneas separadas
        return $"Mi nombre es {nombre}\n Estudio la carrera de {carrera}\n Mis hobbys son {hobby}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
