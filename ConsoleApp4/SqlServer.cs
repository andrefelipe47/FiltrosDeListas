using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SqlServer
    {
        public List<Entidades.Pizza> ListarPizzas()
        {
            var pizzas = new List<Entidades.Pizza>();

            pizzas.Add(new Entidades.Pizza()
            {
                Id = 1,
                Tamanho = "P",
                Fatias = 4
            });
            pizzas.Add(new Entidades.Pizza()
            {
                Id = 2,
                Tamanho = "M",
                Fatias = 6
            });
            pizzas.Add(new Entidades.Pizza()
            {
                Id = 3,
                Tamanho = "G",
                Fatias = 8
            });

            return pizzas;
        }
        public List<Entidades.Caixa> ListarCaixas()
        {
            var pizzas = new List<Entidades.Caixa>();

            pizzas.Add(new Entidades.Caixa()
            {
                TamanhoCaixa = "P"
            });
            pizzas.Add(new Entidades.Caixa()
            {
                TamanhoCaixa = "M"
            });
            return pizzas;
        }
    }
}
