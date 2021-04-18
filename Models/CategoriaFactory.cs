namespace SistemaCadastro.Models
{
    public class CategoriaFactory
    {
        public ICategoria CriarCategoria(string tipo)
        {
            ICategoria categoria = new CategoriaA();

            if (tipo.Equals("A"))
            {
                 categoria = new CategoriaA();
            }
            if (tipo.Equals("B"))
            {
                categoria = new CategoriaB();
            }
            return categoria;
        }
    }
}
