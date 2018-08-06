using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using clSalesIT.Model;

namespace clSalesIT.DAL
{
    public class DALClientePessoaFisica
    {
        private List<ClientePessoaFisica> _lstClientes;

        public DALClientePessoaFisica()
        {
            _lstClientes = new List<ClientePessoaFisica>();
            ClientePessoaFisica _cliente;

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 1;
            _cliente.Nome = "ANGELA MOREIRA DOS SANTOS CAMARGO";
            _cliente.CPF = "037.926.069-76";
            _cliente.Bairro = "Benfica";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("09/02/1989");
            _cliente.DataCadastro = Convert.ToDateTime("13/01/2018"); ;
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 2;
            _cliente.Nome = "EDUARDA LEOBET";
            _cliente.CPF = "060.413.249-22";
            _cliente.Bairro = "São Cristóvão";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("21/04/1992 ");
            _cliente.DataCadastro = Convert.ToDateTime("13/01/2018"); ;
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 3;
            _cliente.Nome = "FLAVIANA GASPAR";
            _cliente.CPF = "059.513.239-16";
            _cliente.Bairro = "São João de Meriti";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("26/08/1996");
            _cliente.DataCadastro = Convert.ToDateTime("14/02/2018"); ;
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 4;
            _cliente.Nome = "GEOVANA BRAMBATTI VANZIN";
            _cliente.CPF = "006.670.080-98";
            _cliente.Bairro = "Olinda";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("24/04/1985");
            _cliente.DataCadastro = Convert.ToDateTime("08/02/2017"); ;
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 5;
            _cliente.Nome = "MARCELA MANENTI POZZO";
            _cliente.CPF = "038.465.329-40";
            _cliente.Bairro = "Taquara";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("18/08/1990");
            _cliente.DataCadastro = Convert.ToDateTime("14/04/2017"); ;
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaFisica();
            _cliente.Codigo = 6;
            _cliente.Nome = "RODRIGO DA SILVA OLIBONI";
            _cliente.CPF = "055.845.839-44";
            _cliente.Bairro = "Saracuruna";
            _cliente.Estado = "RJ";
            _cliente.Data_Nascimento = Convert.ToDateTime("27/07/1985");
            _cliente.DataCadastro = Convert.ToDateTime("11/07/2017"); ;
            _lstClientes.Add(_cliente);
        }

        public void Incluir(ClientePessoaFisica pCliente)
        {
            _lstClientes.Add(pCliente);
        }

        public void Alterar(ClientePessoaFisica pCliente)
        {
            ClientePessoaFisica _clienteAlterado = ObterPorCodigo(pCliente.Codigo);

            _clienteAlterado.Nome = pCliente.Nome;
            _clienteAlterado.Endereco = pCliente.Endereco;
            _clienteAlterado.Bairro = pCliente.Bairro;
            _clienteAlterado.Cidade = pCliente.Cidade;
            _clienteAlterado.Estado = pCliente.Estado;
            _clienteAlterado.CPF = pCliente.CPF;
            _clienteAlterado.RG = pCliente.RG;
            _clienteAlterado.Data_Nascimento = pCliente.Data_Nascimento;
        }

        public void Excluir(Int32 pCodigo)
        {
            ClientePessoaFisica _clienteExcluir = ObterPorCodigo(pCodigo);
            _lstClientes.Remove(_clienteExcluir);

        }

        public List<ClientePessoaFisica> ListarPorNome(String pNome)
        {
            List<ClientePessoaFisica> _lista =  from cliente in _lstClientes
                                                where cliente.Nome.Contains(pNome)
                                                select cliente) .ToList<ClientePessoaFisica>();

            return _lista;

        }

        public ClientePessoaFisica ObterPorCodigo(Int32 pCodigo)
        {
            ClientePessoaFisica _cliente = null;
            _cliente = (from cliente in _lstClientes
            where (cliente.Codigo == pCodigo)
            select cliente).FirstOrDefault();

            return _cliente;
        }


        public List<ClientePessoaFisica> Listar()
        {
            return _lstCliente;
        }
    }
}
