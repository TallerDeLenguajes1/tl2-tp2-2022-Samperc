// See https://aka.ms/new-console-template for more information
using NLog;


Logger Logger = NLog.LogManager.GetCurrentClassLogger();
Logger.Info("Program start");
string alumno;
string apellido;
int DNI, curso;
int bandera = 0;
int ID = 0;
Console.WriteLine("Cuanto alumnos desea ingresar? \n");
int numero_alumnos=int.Parse(Console.ReadLine());
List<Alumno> alumnos=new List<Alumno>();

for (int i = 0; i < numero_alumnos; i++)
{
    try
    {
        Console.WriteLine($"Ingrese el nombre del Alumno {i} \n");
        alumno = Console.ReadLine();
        Console.WriteLine($"Ingrese el Apellido del Alumno {i} \n");
        apellido = Console.ReadLine();
        Console.WriteLine($"Ingrese el DNI: \n");
        DNI = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el curso: \n");
        curso = int.Parse(Console.ReadLine());

    }
    catch (System.FormatException ex)
    {   
        Logger.Error(ex.Message);
        Console.WriteLine(ex.Message);
        alumno = "sinNombre ";
        apellido = " sinApellido";
        DNI = 0;
        curso = 0;
    }
    int eleccion;
    try
    {
        Console.WriteLine("Ingrese el deporte: \n");
        Console.WriteLine("0 para Atletismo");
        Console.WriteLine("1 para  Voley ");
        Console.WriteLine("2 para futbol");
        eleccion = int.Parse(Console.ReadLine());


    }
    catch (System.Exception ex)
    {    Logger.Error(ex.Message);
        Console.WriteLine(ex.Message);
         eleccion = 0;
    }
   

    string perro = Enum.GetName(typeof(deportes), eleccion);


    try
    {   alumnos.Add(new Alumno(i, alumno, apellido, DNI, curso, eleccion));


        HelperDeArchivos.EscribirContenido(perro, alumnos[i]);
    }
    catch (System.OutOfMemoryException ex)
    {    Logger.Error(ex.Message);
        Console.WriteLine(ex.Message);

    }

    catch (Exception ex)
    {    Logger.Error(ex.Message);
            
        Console.WriteLine(ex.Message);

    }

} 
HelperDeArchivos.cerrar_archivos();
Logger.Info("Program Finish");
    

   






