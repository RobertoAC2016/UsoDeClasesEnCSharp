
Console.WriteLine("Uso de Clases Sealed, Public y Static!\n\n\n");
////La diferencia entre una clases Sealed y Publica o alguna otra, es q la sealed no puede ser heredada

////Para poder acceder a la propiedad de luces, primero creamos e instanciamos un objeto de tipo Departamento

////Paso 1
//departamento midepa = new departamento();// <--

////Paso 2
//var estadoDeLasLuces = midepa.luces;    //  <-- Luego accedemos a la propidad

//Console.WriteLine($"Como estan las luces ahorita: {estadoDeLasLuces}");

//midepa.Encenderluces();

//estadoDeLasLuces = midepa.luces;

//Console.WriteLine($"Como estan las luces ahorita: {estadoDeLasLuces}");


//Console.WriteLine("\n\n\n");

//veamos aora como acceder a una clase de tipo static

var estadoDelMotor = Auto.EstadoDelMotorEncendido;
//no podemos acceder a la propiedad EstadoDelMotorEncendido porque es privada, si la cambiamos a publica ya tendremos
//Acceso
Console.WriteLine($"El motor esta : {estadoDelMotor}");

Auto.CambiarEstado();

Auto.DimeElEstadoDelMotorDelAuto();

//El modo de acceso a una clase statica es directo, no se necesita instanaciar un tipo de clase, como en la
//clase public



public static class Auto
{
    public static bool EstadoDelMotorEncendido { get; set; } = false;
    public static void DimeElEstadoDelMotorDelAuto()
    {
        Console.WriteLine($"El motor esta encendido: {EstadoDelMotorEncendido}");
    }
    public static void CambiarEstado()
    {
        EstadoDelMotorEncendido = !EstadoDelMotorEncendido;
    }
}


public class Casa
{
    //Generamos sus propiedades q solo tienen valores, los metodos son aquellos que tienen una accion
    public int cuartos { get; set; }
    //  GET y SET, son utilizados en las propiedades para asiganr valores y recuperarlos
    public int puertas { get; set; }
    public int ventanas { get; set; }
    public bool estacionamiento { get; set; }
    //vamos a generar un metodo q sera encender las luces
    public bool luces { get; set; } = true;
    public void Encenderluces()
    {
        this.luces = !this.luces;
    }
}

//Ahora vamos a crear una clase q herede de casa

public class departamento : Casa
{
    //  vamos a agregar solo un metodo mas q sera apagar el gas
    public bool gas { get; set; } = true;
    public void ApagarOEncenderElGas()
    {
        this.gas = !this.gas;
    }
}

//  ahora veamos q pasa si queremos heredar de una cl;ase sealeed
//Si sellamos la clase casa con el modificador SEALED, ninguna clase podra heredar esa clase sellada
//Ahora como podemos invicar los metodos de apagar luces en casa del objeto departamento

//primero creamos un objeto del tipo departamento

//TIPO de OBJETO
//el erro es q debemos invocar las instrucciones antes de su declaracion































