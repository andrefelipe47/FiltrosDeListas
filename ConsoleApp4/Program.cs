using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlServer();

            var pizzas = sql.ListarPizzas();
            pizzas = FiltroPedacos(pizzas, 8);

            var caixas = sql.ListarCaixas();

            pizzas = FiltraPizzaCabeEmCaixa(pizzas, caixas);

            ImprimirRetorno(pizzas);
        }

        static List<Entidades.Pizza> FiltroPedacos(List<Entidades.Pizza> pizzas, int qtdePedacos)
        {
            var listaFiltrada = new List<Entidades.Pizza>();

            foreach (var pizza in pizzas)
            {
                if(qtdePedacos == pizza.Fatias)
                {
                    listaFiltrada.Add(pizza);
                }
            }

            return listaFiltrada;
        }

        static List<Entidades.Pizza> FiltraPizzaCabeEmCaixa(List<Entidades.Pizza> pizzas, List<Entidades.Caixa> caixas)
        {
            var listaFiltrada = new List<Entidades.Pizza>();

            foreach (var caixa in caixas)
            {
                foreach (var pizza in pizzas)
                {
                    if (caixa.TamanhoCaixa == pizza.Tamanho)
                    {
                        listaFiltrada.Add(pizza);
                    }
                }
            }

            return listaFiltrada;
        }
        static void ImprimirRetorno(List<Entidades.Pizza> pizzas)
        {
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.Tamanho);
            }
        }
    }
}
