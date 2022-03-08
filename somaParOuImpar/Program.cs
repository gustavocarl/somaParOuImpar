using System;

namespace somaParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado, somaPar = 0, somaImpar = 0;
            //Recebe três variáveis numeroDigitado, somaPar e somaImpar
            Console.WriteLine("Caso o número digitado seja maior que 1000 o programa será encerrado e irá apresentar o resultado!!!");
            //Indica para o usuário se ele digitar um número maior que 1000 o programa será encerrado apresentando o resultado
            do
            {
                Console.WriteLine("Por favor, informe um número: ");//É pedido para o usuário informar o número a ser digitado
                numeroDigitado = Convert.ToInt32(Console.ReadLine());//A variável numeroDigitado receberá o valor
                if ((numeroDigitado <= 1000) & (numeroDigitado > 0))//Cria uma condição para aceitar somente números menores que 1000
                {
                    if (numeroDigitado % 2 == 0)//Se o resto da divisão divido por 2 for igual a 0 ele entra nessa condição
                    {
                        somaPar += numeroDigitado;//somaPar irá somar somaPar com numeroDigitado
                    }
                    else
                    {
                        somaImpar += numeroDigitado;//Senão somaImpar irá somar somaImpar com numeroDigitado
                    }
                }
            } while (numeroDigitado <= 1000);//É usado o laço de repetição do while para indicar se o número for menor que 1000 continuar sendo digitado
            Console.WriteLine("A soma dos números pares é: {0}", somaPar);//Apresenta o resultado da soma dos números pares
            Console.WriteLine("A soma dos números ímpares é: {0}", somaImpar);//Apresenta o resultado da soma dos números impáres
        }
    }
}
