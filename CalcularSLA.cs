using System;
public class CalcularSLA
{
    public static void Main (string[]args){

     //Declaración de variables
    DateTime fechaCreacion, fechaResolucion, finDelDia;
    double horasLaborales, horasDelDia;
    bool quedanDias, esFinDeSemana;

    //Datos de entrada
    Console.WriteLine("Ingrese la fecha y hora de creación del ticket: ");
    fechaCreacion = Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine("Ingrese la fecha y hora de resolución del ticket");
    fechaResolucion = Convert.ToDateTime(Console.ReadLine());
    
    //Proceso
    horasLaborales = 0;
    quedanDias = true;

        while (quedanDias)
        {
            esFinDeSemana = (fechaCreacion.DayOfWeek == DayOfWeek.Saturday || fechaCreacion.DayOfWeek == DayOfWeek.Sunday);
            if (esFinDeSemana)
            {
                fechaCreacion = fechaCreacion.AddDays(1);
            }
            else
            {
                if(fechaCreacion.Date == fechaResolucion.Date)
                {
                    finDelDia = fechaResolucion;
                }
                else
                {
                    finDelDia = fechaCreacion.Date.AddHours(17);
                }
                horasDelDia = (finDelDia - fechaCreacion).TotalHours;
                horasLaborales = horasDelDia + horasLaborales;
                fechaCreacion = fechaCreacion.AddDays(1).Date.AddHours(9);
            }
            quedanDias = (fechaCreacion.Date <= fechaResolucion.Date);

        }

        if(horasLaborales <= 8)
        {
            Console.WriteLine("Cumplido");
        }
        else
        {
            Console.WriteLine("Incumplido: " + (horasLaborales-8) + " horas de más");
        }






    }

    














}