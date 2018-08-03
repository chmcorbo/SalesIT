using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clSalesIT.Model;

namespace clSalesIT.DAL
{
    public class DALClientePessoaJuridica
    {
        private List<ClientePessoaJuridica> _lstClientes;

        public DALClientePessoaJuridica()
        {
            _lstClientes = new List<ClientePessoaJuridica>();
            ClientePessoaJuridica _cliente;
            // Inclusão de clientes

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 1;
            _cliente.Nome = "Contábil Rio";
            _cliente.CNPJ = "45.558.284/0001-74";
            _cliente.Estado = "RJ";
            _cliente.DataCadastro = Convert.ToDateTime("15/01/2017");
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 2;
            _cliente.Nome = "Audit Master Assessoria Jurídica";
            _cliente.CNPJ = "67.583.286/0001-56";
            _cliente.Estado = "RJ";
            _cliente.DataCadastro = Convert.ToDateTime("23/02/2017");
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 3;
            _cliente.Nome = "RioKasa Empreendimentos imobilitários";
            _cliente.CNPJ = "34.030.525/0001-91";
            _cliente.Estado = "SP";
            _cliente.DataCadastro = Convert.ToDateTime("13/04/2015");
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 4;
            _cliente.Nome = "GAX Locadora de geradores";
            _cliente.CNPJ = "24.714.664/0001-80";
            _cliente.Estado = "RJ";
            _cliente.DataCadastro = Convert.ToDateTime("25/03/2017");
            _lstClientes.Add(_cliente);

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 5;
            _cliente.Nome = "Licitus Consultoria e Empreendimentos";
            _cliente.CNPJ = "06.917.384/0001-98";
            _cliente.Estado = "SP";
            _cliente.DataCadastro = Convert.ToDateTime("18/05/2016");
            _lstClientes.Add(_cliente);
        }

        public ClientePessoaJuridica ObterPorCodigo(Int32 pCodigo)
        {
            ClientePessoaJuridica _cliente = null;

            _cliente = (from cliente in _lstClientes
                        where (cliente.Codigo == pCodigo)
                        select cliente).FirstOrDefault();

            return _cliente;
        }

        public List<ClientePessoaJuridica> ListarPorNome(String pNome)
        {
            List<ClientePessoaJuridica> _lista = (from cliente in _lstClientes
                                                  where cliente.Nome.Contains(pNome)
                                                  select cliente).ToList<ClientePessoaJuridica>();
            return _lista;
        }

        public List<ClientePessoaJuridica> ObterPorCNPJ(String pCNPJ)
        {
            _lstClientes = (from cliente in _lstClientes
                            where cliente.CNPJ.Contains(pCNPJ)
                            select cliente).ToList<ClientePessoaJuridica>();
            return _lstClientes;
        }

        public void Incluir(ClientePessoaJuridica pCliente)
        {
            _lstClientes.Add(pCliente);
        }

        public void Alterar(ClientePessoaJuridica pCliente)
        {
            ClientePessoaJuridica _clienteAlterado = ObterPorCodigo(pCliente.Codigo);
            _clienteAlterado.Nome = pCliente.Nome;
            _clienteAlterado.Endereco = pCliente.Endereco;
            _clienteAlterado.Bairro = pCliente.Bairro;
            _clienteAlterado.Cidade = pCliente.Cidade;
            _clienteAlterado.Estado = pCliente.Estado;

            _clienteAlterado.CNPJ = pCliente.CNPJ;
            _clienteAlterado.InscricaoEstadual = pCliente.InscricaoEstadual;
            _clienteAlterado.DataContratoSocial = pCliente.DataContratoSocial;
        }

        public void Excluir(Int32 pCodigo)
        {
            ClientePessoaJuridica _clienteExcluir = ObterPorCodigo(pCodigo);
            _lstClientes.Remove(_clienteExcluir);
        }

        public List<ClientePessoaJuridica> Listar()
        {
            return _lstClientes;
        }

    }
}
