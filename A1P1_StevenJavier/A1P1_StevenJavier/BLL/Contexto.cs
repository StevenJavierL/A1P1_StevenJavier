using Microsoft.EntityFrameworkCore;

namespace A1P1_StevenJavier.BLL
{
    public class Contexto : DbContext
    {
        private Contexto _contexto;

        public void DBontexto (Contexto contexto)
        {
            _contexto = contexto;
        }
    }
}
