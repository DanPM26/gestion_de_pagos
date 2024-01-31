using System;

public class SistemadePagos
{
    public static void Main(string[] args)
    {
        string nombre;
        // Solicitar nombre del emplead@
        Console.WriteLine("Escribe tu nombre");
        nombre = Console.ReadLine();
        // Lista de empleados
        string[] lista_empleados = { "Julian Aurelio Jimenez", "Alicia Montalvo Torres", "Mariana Ponce Rupit", "Oscar Oliva Oliva" };
        int[] datos_trabajador = new int[4];
        int[] puesto = { 1, 2, 3 };
        int[] salario = { 30, 25, 20, 18 };
        int entrada = 9;
        int salida = 4;

        for (int i = 0; i < lista_empleados.Length; i++)
        {
            if (nombre == lista_empleados[i] && i < datos_trabajador.Length)
            {
                datos_trabajador[i] = puesto[i];
                Console.WriteLine("El puesto de " + nombre + " es: " + datos_trabajador[i]);
                Console.WriteLine("El salario de " + nombre + " es: " + salario[i]);

                int conteo = 0; 

                // Repetir la pregunta de entrada y salida hasta que se realicen 15 intentos
                while (conteo < 15)
                {
                    Console.WriteLine("Escribe tu hora de entrada");
                    int entrada_empleado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Escribe tu hora de salida");
                    int salida_empleado = Convert.ToInt32(Console.ReadLine());

                    if (entrada_empleado == entrada && salida_empleado == salida)
                    {
                        conteo++;
                    }
                }

                if (conteo == 15)
                {
                    datos_trabajador[i] = salario[i];
                    double salario_final = datos_trabajador[i] + (0.10 * datos_trabajador[i]);
                    Console.WriteLine("Felicidades " + nombre + ", recibiste un bono. Este es tu salario final: " + salario_final);
                }
                else if (conteo <= 20)
                {
                    double salario_final = datos_trabajador[i] - (0.15 * datos_trabajador[i]);
                    Console.WriteLine("Lo sentimos " + nombre + ", recibiste un descuento. Favor de revisar tu caso en RRHH. Este es tu salario final: " + salario_final);
                }
                break;
            }
        }

    }
}
