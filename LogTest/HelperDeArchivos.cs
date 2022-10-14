static class HelperDeArchivos
{

    static string Nombre_ArchivoconExt = "atletismo.csv";
    static FileStream atlestismo = new FileStream(Nombre_ArchivoconExt, FileMode.OpenOrCreate);
    static StreamWriter sw = new StreamWriter(atlestismo);
    static string Nombre_ArchivoconExt2 = "voley.csv";
    static FileStream voley = new FileStream(Nombre_ArchivoconExt2, FileMode.OpenOrCreate);
    static StreamWriter sw2 = new StreamWriter(voley);
    static string Nombre_ArchivoconExt3 = "futbol.csv";
    static FileStream futbol = new FileStream(Nombre_ArchivoconExt3, FileMode.OpenOrCreate);
    static StreamWriter sw3 = new StreamWriter(futbol);
    public static void EscribirContenido(string Nombre_deporte, Alumno A1)

    {
        try
        {
            switch (Nombre_deporte)
            {
                case "atletismo":


                    sw.WriteLine(A1.id + ";" + A1.apellido + ";" + A1.nombre + ";" + A1.Deporte);
                    break;
                case "voley":


                    sw2.WriteLine(A1.id + ";" + A1.apellido + ";" + A1.nombre + ";" + A1.Deporte);
                    break;
                case "futbol":


                    sw3.WriteLine(A1.id + ";" + A1.apellido + ";" + A1.nombre + ";" + A1.Deporte);
                    break;

            }
        }
        catch (System.Exception ex)
        {

            throw new Exception("contexto del error ",ex);
        }



    }
    public static void cerrar_archivos()
    {
        sw.Close();
        sw2.Close();
        sw3.Close();
    }
    public static void LimpiarContenido(string Nombre_Archivo)
    {
        File.Delete(Nombre_Archivo);
        FileStream MiArchivo = new FileStream(Nombre_Archivo, FileMode.CreateNew);
    }

}