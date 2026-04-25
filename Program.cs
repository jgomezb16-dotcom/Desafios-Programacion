using System;

internal class Program
{
    static bool VerificarGanador(string[,] tablero, string ficha)
    {
        // Revisar filas
        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] == ficha && tablero[i, 1] == ficha && tablero[i, 2] == ficha)
                return true;
        }

        // Revisar columnas
        for (int i = 0; i < 3; i++)
        {
            if (tablero[0, i] == ficha && tablero[1, i] == ficha && tablero[2, i] == ficha)
                return true;
        }

        // Revisar diagonales
        if (tablero[0, 0] == ficha && tablero[1, 1] == ficha && tablero[2, 2] == ficha)
            return true;

        if (tablero[0, 2] == ficha && tablero[1, 1] == ficha && tablero[2, 0] == ficha)
            return true;

        return false;
    }

    static void Main(string[] args)
    {
        string[,] tablero = new string[,]
        {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };

        string jugadorActual = "X";
        int turnos = 0;
        bool juegoTerminado = false;

        while (!juegoTerminado)
        {
            // Mostrar tablero
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("| " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2] + " |");
                Console.WriteLine("-------------");
            }

            // Pedir fila
            Console.WriteLine("Jugador " + jugadorActual + ", ingresa la fila (0, 1 o 2):");
            int fila = int.Parse(Console.ReadLine());

            // Pedir columna
            Console.WriteLine("Ingresa la columna (0, 1 o 2):");
            int columna = int.Parse(Console.ReadLine());

            // Validar que la casilla este vacia
            if (tablero[fila, columna] != " ")
            {
                Console.WriteLine("Esa casilla ya esta ocupada, intenta de nuevo.");
            }
            else
            {
                // Colocar la ficha
                tablero[fila, columna] = jugadorActual;
                turnos++;

                // Verificar ganador
                if (VerificarGanador(tablero, jugadorActual))
                {
                    // Mostrar tablero final
                    Console.WriteLine("-------------");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("| " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2] + " |");
                        Console.WriteLine("-------------");
                    }
                    Console.WriteLine("Jugador " + jugadorActual + " ha ganado!");
                    juegoTerminado = true;
                }
                else if (turnos == 9)
                {
                    Console.WriteLine("Empate!");
                    juegoTerminado = true;
                }
                else
                {
                    // Cambiar turno
                    if (jugadorActual == "X")
                        jugadorActual = "O";
                    else
                        jugadorActual = "X";
                }
            }
        }
    }
}