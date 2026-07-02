Algoritmo CalcularSLA

    Definir fechaCreacion, fechaResolucion Como Cadena
    Definir horasLaborales Como Real
    Definir quedenDias Como Logico
    Definir esFinDeSemana Como Logico
    Definir horasDelDia Como Real

    Escribir "Ingrese la fecha y hora de creación del ticket:"
    Leer fechaCreacion

    Escribir "Ingrese la fecha y hora de resolución del ticket:"
    Leer fechaResolucion

    horasLaborales <- 0
    quedenDias <- Verdadero

    Mientras quedenDias Hacer

        Si esFinDeSemana Entonces

            // Avanzar al siguiente día

        Sino

            // Calcular las horas laborales del día
            // (Horario de atención: 9:00 a.m. a 5:00 p.m.)

            horasLaborales <- horasLaborales + horasDelDia

            // Avanzar al siguiente día

        FinSi

        // Si ya no quedan más días por recorrer
        // quedenDias <- Falso

    FinMientras

    Si horasLaborales <= 8 Entonces
        Escribir "CUMPLIDO"
    Sino
        Escribir "INCUMPLIDO: ", horasLaborales - 8, " horas de más"
    FinSi

FinAlgoritmo