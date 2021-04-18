using System;

namespace SistemaCadastro.Models
{
    public class CategoriaB : ICategoria
    {
        public decimal CalcularPreco(decimal custo)
        {
            decimal taxa = 1.1m;
            return Decimal.Multiply(custo, taxa);
        }
    }
}
