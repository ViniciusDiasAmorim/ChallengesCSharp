namespace CalcularParDeInteiros
{
    //Desenvolva um programa em C# que resolva o seguinte problema: dado um array de números inteiros,
    //encontre o par de elementos cuja soma seja igual a um valor fornecido. O programa deve retornar
    //os índices dos elementos encontrados ou uma mensagem indicando que nenhum par foi encontrado.
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros serao adicionados");
            int tamanhoDoArray;
            while (!int.TryParse(Console.ReadLine(), out tamanhoDoArray) || tamanhoDoArray <= 0)
            {
                Console.WriteLine("Valor invalido digite um valor inteiro positivo: ");
            }

            int[] valores = new int[tamanhoDoArray];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"{i + 1} Digite o numero que deseja adicionar: ");
                int numeroAdicionado;
                while (!int.TryParse(Console.ReadLine(), out numeroAdicionado))
                {
                    Console.WriteLine("Valor invalido digite um valor inteiro positivo: ");
                }
                valores[i] = numeroAdicionado;
            }
            Console.WriteLine("Qual numero voce deseja saber se existe um par correspondente pela soma de dois numeros do array: ");
            int valorAhSerProcurado;
            while (!int.TryParse(Console.ReadLine(), out valorAhSerProcurado))
            {
                Console.WriteLine("Valor invalido digite um valor inteiro positivo: ");
            }

            bool encontrouPar = false;
            int primeiroAlgarismo = 0;
            int segundoAlgarismo = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = i + 1; j < valores.Length; j++)
                {
                   if (valores[i] + valores[j] == valorAhSerProcurado)
                    {
                        encontrouPar = true;
                        primeiroAlgarismo = valores[i];
                        segundoAlgarismo = valores[j];
                    }        
                }
            }

            if (encontrouPar)
            {
                Console.WriteLine($"A primeira ocorrencia em que a soma de dois numeros da" +
                    $" lista passada eh igual ao numero procurado sao {primeiroAlgarismo} e {segundoAlgarismo}");
            }
            else
            {
                Console.WriteLine("Nenhum par foi encontrado");
            }
        }
    }
}