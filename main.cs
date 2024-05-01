using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //Exemplo de entrada "10 + 10", "20 * 364", "4 raiz".
        string[] Result = Console.ReadLine().Split(" ");

        string Operacao = Result[1];
        double X = Convert.ToDouble(Result[0]);
        double XY = 0;
        if (Operacao != "raiz")
        {
            double Y = Convert.ToDouble(Result[2]);
            if (Operacao == "*")
                XY = X * Y;
            if (Operacao == "/")
                XY = X / Y;
            if (Operacao == "+")
                XY = X + Y;
            if (Operacao == "-")
                XY = X - Y;
            if (Operacao == "%")
                XY = X % Y;
            Console.WriteLine("Resultado: " + XY);
        }

        else
        {
            XY = Math.Sqrt(X);
            Console.WriteLine("Resultado: " + XY);
        }
    }
}