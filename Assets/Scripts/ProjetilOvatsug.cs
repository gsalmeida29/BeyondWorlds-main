using System;

class Program
{
    static void Main()
    {
        double velocidade = 20.0; // m/s
        double anguloGraus = 45.0;
        double gravidade = 9.81;

        double angulo = anguloGraus * Math.PI / 180.0;

        double vx = velocidade * Math.Cos(angulo);
        double vy = velocidade * Math.Sin(angulo);

        Console.WriteLine("Tempo | X | Y");

        for (double t = 0; t <= 3; t += 0.1)
        {
            double x = vx * t;
            double y = vy * t - 0.5 * gravidade * t * t;

            if (y < 0)
                break;

            Console.WriteLine($"{t:F1}s | {x:F2}m | {y:F2}m");
        }
    }
}