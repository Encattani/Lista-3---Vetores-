namespace Aula1304
{
    public class Program
    {
        static void Main(string[] args)
        {


            //ex1.Exercicio1();   
            //ex2.Exercicio2();
            //ex3.Exercicio3();       
            //ex4.Exercicio4();
            //ex5.Exercicio5();
            ex6.Exercicio6();


        }
        #region exercicioS


        #endregion



        #region Metodos
        //ExA
        public static int[] LerEntradas(int NumeroDeEntradas)
        {
            int[] arrayNumeros = new int[NumeroDeEntradas];

            for (int i = 0; i < NumeroDeEntradas; i++)
            {
                Console.WriteLine("Entre com um numero: ");
                arrayNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arrayNumeros;
        }

        //ExB
        public static void ImprimirNumeros(int[] arrayNum)
        {
            foreach (int num in arrayNum)
                Console.WriteLine(num + " ");
        }

        //ExB
        public static int[] LerMatriculas(int num)
        {
            int[] matriculas = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com a matricula ({i}):");
                int novaMatricula = Convert.ToInt32(Console.ReadLine());

                if (ValidarMatricula(novaMatricula, matriculas))
                {
                    matriculas[i] = novaMatricula;
                }

                else
                {
                    i--;
                }


            }
            return matriculas;
        }

        //ExB
        public static bool ValidarMatricula(int novaMatricula, int[] matriculas)
        {
            bool EumaNovaMatricula = true;
            foreach (int matricula in matriculas)
            {
                if (matricula == novaMatricula)
                {
                    Console.WriteLine("Matricula já consta no vetor.");
                    return false;
                }
            }
            return EumaNovaMatricula;

        }

        //ExC
        public static int[] GerarAleatorios(int nr)
        {
            Random r = new Random(); // criando uma nova instância da classe Random
            int[] numeros = new int[nr]; // criando um vetor de tamanho N para armazenar os números aleatórios

            for (int i = 0; i < nr; i++)
            {
                numeros[i] = r.Next(0, 999); // gerando um número aleatório e adicionando ao vetor
            }

            return numeros; // retornando o vetor com os números aleatórios gerados
        }

        //ExD
        public static int[] GerarOrdenado(int NumeroOrdenado)
        {
            int numero = 0;
            int[] dados = new int[100];
            int count = 0;

            do
            {
                Console.WriteLine("Entre com valor");
                numero = Convert.ToInt32(Console.ReadLine());
                count++;
            } while (numero != 999);

            count--;

            int[] vetorInvertido = new int[count];

            for (int i = count - 1; i >= 0; i--)
                vetorInvertido[(count - 1) - i] = dados[i];
            foreach (var num in vetorInvertido)
                Console.WriteLine(num);

            return vetorInvertido;
        }

        //Inverter Ordem
        public char[] InverterOrdem(char[] vetorChar)
        {
            char[] vetorRetorno = new char[vetorChar.Length];

            for (int i = vetorChar.Length - 1; i >= 0; i--)
                vetorRetorno[(vetorChar.Length - 1) - i] = vetorChar[i];

            return vetorRetorno;

        }

        public static void InverterOrdemFast(char[] vetorChar)
        {
            for (int i = 0; i < vetorChar.Length / 2; i++)
            {
                int indexOposto = (vetorChar.Length - 1) - i;
                char aux = vetorChar[i];
                vetorChar[i] = vetorChar[indexOposto];
                vetorChar[indexOposto] = aux;
            }

        }

        //metodo ex5

        public static string MediaNotas()
        {
            Console.WriteLine("Insira o valor da nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor da nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double mediaNotas = (nota1 + nota2) / 2;

            string aprovacao;

            if (mediaNotas > 6)
            {
                Console.WriteLine("APROVADO.");
                aprovacao = "APROVADO";
            }

            else
            {
                Console.WriteLine("REPROVADO");
                aprovacao = "REPROVADO";

            }



            return aprovacao;


        }

        public static int SomaImpar()
        {           
            int numImpar = 0;
            int contador = 0;

            int[] numeros=new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

                do
                {
                    if (numeros[contador] % 2 != 0)
                    {
                        numImpar += numeros[contador];
                    }
                    contador++;

                } while (contador <= 9);

                Console.WriteLine("A soma dos impares é: " + numImpar);
            

            return numImpar;
        }

        public static int SomaImpar(int[] numeros)
        {
            int numImpar = 0;
            int contador = 0;

            do
            {
                if (numeros[contador] % 2 != 0)
                {
                    numImpar += numeros[contador];
                }
                contador++;

            } while (contador < numeros.Length);

            Console.WriteLine("A soma dos impares é: " + numImpar);


            return numImpar;
        }
        #endregion

    }
}