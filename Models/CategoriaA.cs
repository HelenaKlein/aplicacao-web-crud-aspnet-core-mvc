using System;

namespace SistemaCadastro.Models
{
    public class CategoriaA : ICategoria
    {
        public decimal CalcularPreco(decimal custo)
        {
          decimal taxa = 1.2m;
          return Decimal.Multiply(custo, taxa);
        }
    }
}
