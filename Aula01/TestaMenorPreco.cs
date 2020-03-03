using System;

namespace chaosAlgorithmBeginning.Aula01
{
    internal class TestaMenorPreco
    {
        public TestaMenorPreco()
        {
            Produto[] Produtos = new Produto[5] {
                new Produto("Lamborghini",1000000),
                new Produto("Jeep", 46000),
                new Produto("Brasília", 16000),
                new Produto("Smart", 46000),
                new Produto("Fusca", 17000)
            };

            #region Logica pseudo codigo
            // executa do 0 ate 0 4 inclusive {
            //     se preco atual < preco do mais barato {
            //         mais barato = atual;
            //     }
            //     atual = atual + 1;
            // }

            //imprime o mais barato;
            //imprime o preco do mais barato;
            #endregion

            int maisBarato = buscarMenor(Produtos);

            Console.WriteLine(maisBarato);
            Console.WriteLine($"O carro {Produtos[maisBarato].getNome()} é o mais barato, e custa {Produtos[maisBarato].getPreco()}");

           
        }

        private static int buscarMenor(Produto[] Produtos)
            {
                int maisBarato = 0;
                for (int atual = 0; atual <= 4; atual = atual +1)
                {  
                    if (Produtos[atual].getPreco() < Produtos[maisBarato].getPreco()) {
                        maisBarato = atual;
                    }
                }
                return maisBarato;
            }
    }    
}