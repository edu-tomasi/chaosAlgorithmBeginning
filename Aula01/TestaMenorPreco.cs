using System;

namespace chaosAlgorithmBeginning.Aula01
{
    internal class TestaMenorPreco
    {
        public TestaMenorPreco()
        {
            Produto[] produtos = {
                new Produto("Lamborghini",1000000),
                new Produto("Jeep", 46000),
                new Produto("Brasília", 16000),
                new Produto("Smart", 46000),
                new Produto("Fusca", 17000),
                null,
                null,
                null,
                null
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

            int maisBarato = buscarMenor(produtos, 0, 4);

            Console.WriteLine(maisBarato);
            Console.WriteLine($"O carro {produtos[maisBarato].getNome()} é o mais barato, e custa {produtos[maisBarato].getPreco()}.");

            int maisCaro = buscarMaior(produtos, 0, 4);
            Console.WriteLine(maisCaro);
            Console.WriteLine($"O carro {produtos[maisCaro].getNome()} é o mais caro, e custa {produtos[maisCaro].getPreco()}.");
        }

        private static int buscarMenor(Produto[] produtos, int inicio, int termino)
        {
            int maisBarato = inicio;
            for (int atual = inicio; atual <= termino; atual ++)
            {  
                if (produtos[atual].getPreco() < produtos[maisBarato].getPreco()) {
                    maisBarato = atual;
                }
            }
            return maisBarato;
        }

        private static int buscarMaior(Produto[] produtos, int inicio, int termino) 
        {
            int maisCaro = inicio;
            for (int atual = inicio; atual <= termino; atual++)
            {
                if (produtos[atual].getPreco() > produtos[maisCaro].getPreco())
                {
                    maisCaro = atual;
                }
            }

            return maisCaro;
        }
    }    
}