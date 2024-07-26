


try
{
    int prueba = Convert.ToInt32(Console.ReadLine());
    Boolean respuesta;
    Console.WriteLine("Hola ingrese un Número");
    string numero = Console.ReadLine();
    int numero1;

    respuesta=int.TryParse(numero, out numero1);

    if (respuesta)
    {
        Console.WriteLine("El número ingresado es: " + numero1.ToString());

    }
    else
    {
        throw new Exception("El valor ingresado, no corresponde a un número.");

    }


}
catch(Exception ex)
{
    Console.WriteLine("Ocurrió el siguiente error al ejecutar el programa: "+ex.Message);
    Console.WriteLine("Por favor comuníquese con el área de TI.");
    Console.WriteLine("Correo enviado exitosamente");
    Console.WriteLine("Log guardado exitosamente");
    Console.WriteLine("Transacciones reversadas correctamente");
}
finally
{
    Console.WriteLine("Presione enter para salir del programa.");
}



