namespace ASP21.Models
{
    public static class Dados
    {
            //Dados da aplicação
        private static List<Cliente> lista_cliente = new List<Cliente>();
        public static List<Cliente> todos_os_clientes() { 
            //Todos os clientes da aplicação

            return lista_cliente;
        }

    }
}
