using System;
using  System.Globalization;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, ladoMaior, lado1, lado2, perimetro, area;

            string[] valores = Console.ReadLine().Split(' ');
            a = float.Parse(valores[0], CultureInfo.InvariantCulture);//a recebe float.parse do vetor valores na posição 0 sem variação de ponto ou virgula
            b = float.Parse(valores[1], CultureInfo.InvariantCulture);//se não usar quando colocar o "." não vai identificar que é um número com ponto flutuante, apenas com ","
            c = float.Parse(valores[2], CultureInfo.InvariantCulture);

            if (a > b && a>c){
                ladoMaior = a;
                lado1 = b;
                lado2 = c;
            }
            else if (b>c){
                ladoMaior = b;
                lado1 = a;
                lado2 = c;
            }
            else{
                ladoMaior = c;
                lado1 = a;
                lado2 = b;
            }

            if (ladoMaior < lado1 +lado2){
                perimetro = ladoMaior + lado1 + lado2;
                Console.WriteLine("Perimetro = "+ perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = "+ area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
