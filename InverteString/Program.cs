namespace InverteString
{
    //Você recebe uma string que contém uma série de palavras separadas por espaço.Escreva uma função em C# para inverter a ordem das palavras na string,
    //mantendo a ordem das letras em cada palavra. Por exemplo, se a entrada for "Desenvolvedor de Software", a saída deve ser "Software de Desenvolvedor".
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase que deseja inverter:");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(' ');
            string fraseInvertida = "";

            for (int i = palavras.Length - 1; i >= 0; i--)
            {
                fraseInvertida += palavras[i];

                if (i > 0)
                {
                    fraseInvertida += " ";
                }
            }

            Console.WriteLine(fraseInvertida);
        }
    }
}