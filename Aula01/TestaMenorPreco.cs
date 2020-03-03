using System;

namespace chaosAlgorithmBeginning.Aula01
{
    internal class TestaMenorPreco
    {
        public TestaMenorPreco()
        {
            double[] Precos = new double[5];
            Precos[0] = 1000000;   
            Precos[1] = 46000;
            Precos[2] = 16000;
            Precos[3] = 46000;
            Precos[4] = 17000;

            int maisBarato = 0;

            #region Lógica pseudo código
            // executa do 0 ate 0 4 inclusive {
            //     se preco atual < preco do mais barato {
            //         mais barato = atual;
            //     }
            //     atual = atual + 1;
            // }

            //imprime o mais barato;
            //imprime o preco do mais barato;
            #endregion

            for (int atual = 0; atual <= 4; atual = atual +1)
            {
                if (Precos[atual] < Precos[maisBarato]) {
                    maisBarato = atual;
                }
            }

            Console.WriteLine($"Carro mais barato: {maisBarato}.");
            Console.WriteLine($"Valor do carro é: {Precos[maisBarato]}.");
        }
    }    
}