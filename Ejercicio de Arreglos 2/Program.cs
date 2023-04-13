void matriz()
{

    Console.WriteLine("Ingrese la cantidad de alumnos deseados: ");
    int cantidadalumnos = int.Parse(Console.ReadLine());


    string[] nombre = new string[cantidadalumnos];
    int[] notas = new int[cantidadalumnos];

    for (int i = 0; i < cantidadalumnos; i++)
    {
        Console.WriteLine("Ingrese el nombre del estudiante {0}: ", i + 1);
        nombre[i] = Console.ReadLine();

        Console.WriteLine("Ingrese la nota del estudiante {0}: ", i + 1);
        notas[i] = int.Parse(Console.ReadLine());
    }




    // Se inicializan ambas variables con la primera nota para que no de ningún tipo de error
    int mayor = notas[0];
    int menor = notas[0];
    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > mayor)
        {
            mayor = notas[i];

        }
        if (notas[i] < menor)
        {
            menor = notas[i];
        }
    }
    Console.WriteLine("La nota mayor es de: " + mayor);
    Console.WriteLine("La nota menor es de: " + menor);

}
matriz();
