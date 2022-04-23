using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Elzar";
alumno1.ApellidoPaterno = "Machado";
alumno1.Matricula = "777";
alumno1.FechaNacimiento = new DateTime(2001, 06, 03);

Alumno alumno2 = new Alumno();
alumno2.Nombres = "Jennifer";
alumno2.ApellidoPaterno = "Moreno";
alumno2.Matricula = "666";
alumno2.FechaNacimiento = new DateTime(2000, 10, 24);

Alumno alumno3 = new Alumno();
alumno3.Nombres = "Cesar";
alumno3.ApellidoPaterno = "Denogei";
alumno3.Matricula = "123";
alumno3.FechaNacimiento = new DateTime(2001, 06, 02);

lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3); 

foreach (Alumno alumnoEnLista in lista)
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto
        + " Matricula: "
        + alumnoEnLista.Matricula
        + " fecha nacimiento: "
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}