public enum deportes{
    atletismo,
    voley,
    futbol
};


public class Alumno
{

    private int Id { get; set; }
    private string Nombre { get; set; }
    private string Apellido { get; set; }
    private int Dni { get; set; }
    public deportes Deporte { get; set; }
    public int Curso { get; set; }
    
    public int id { get=>Id; set=>Id=value; }
    public string nombre  { get=>Nombre; set=>Nombre=value; }
    public string apellido  { get=>Apellido;  }
    public int dni  { get=>dni;  }
    public deportes deporte {get=>Deporte;} 

public
 
   Alumno(int ID,string nombre,string apellido,int DNI,int Curso,int Deporte){
    this.Id=ID;
    this.Nombre=nombre;
    this.Apellido=apellido;
    this.Dni=DNI;
    this.Curso=Curso;
    this.Deporte=(deportes)Deporte;
   }

}