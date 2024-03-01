namespace ASP21.Models
{
    public static class Dados
    {
        //Dados da aplicação
        private static List<Cliente> lista_cliente = new List<Cliente>();
        public static List<Cliente> todos_os_clientes()
        {
            //Todos os clientes da aplicação

            return lista_cliente;
        }

        public static void adicionar_cliente(Cliente clientTemp)
        {
            //buscar o id disponivel
            int id = 0;
            if (lista_cliente.Count != 0)
            {
                id = lista_cliente.Last<Cliente>().id + 1;
            }
            //guardar os dados
            clientTemp.id = id;
            lista_cliente.Add(clientTemp);
        }

        
    }
}
