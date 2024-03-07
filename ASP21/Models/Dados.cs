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

        public static Cliente dados_cliente(int id)
        {
            //devolve os dados do cliente escolhido
            Cliente clientTemp = lista_cliente.Where(i => i.id == id).FirstOrDefault();
            return clientTemp;
        }

        public static void editar_cliente(Cliente c)
        {
            //editar dados do cliente escolhido
            lista_cliente.First<Cliente>(i => i.id == c.id).id = c.id; 
            lista_cliente.First<Cliente>(i => i.id == c.id).nome = c.nome;
            lista_cliente.First<Cliente>(i => i.id == c.id).telefone = c.telefone;
            //lista_cliente.First<cliente>(i =>i.id == c.id).nome =c.nome
        }
        
        public static void eliminar_cliente(int id)
        {
            var clienteTemp = lista_cliente.First<Cliente>(i => i.id == id);
            lista_cliente.Remove(clienteTemp);
        }
    }
}
