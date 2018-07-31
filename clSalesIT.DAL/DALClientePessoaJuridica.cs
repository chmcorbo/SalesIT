using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clSalesIT.Model;

namespace clSalesIT.DAL
{
    public class DALClientePessoaJuridica
    {        
        List<ClientePessoaJuridica> _lstClientes;

        public DALClientePessoaJuridica()
        {
            _lstClientes = new List<ClientePessoaJuridica>();
            ClientePessoaJuridica _cliente;

            _cliente = new ClientePessoaJuridica();
            _cliente.Codigo = 1;
            _cliente.Nome = "AVGE";
        }

        public ClientePessoaJuridica ObterPorCodigo(Int32 pCodigo)
        {
            ClientePessoaJuridica _cliente = (from cliente in _lstClientes
                                              where cliente.Codigo == pCodigo
                                              select cliente) as ClientePessoaJuridica;

            return _cliente.Clone() as ClientePessoaJuridica;
        }

        public List<ClientePessoaJuridica> ListarPorNome(String pNome)
        {
            List<ClientePessoaJuridica> _lista = (from cliente in _lstClientes
                                                  where cliente.Nome.Contains(pNome)
                                                  select cliente).ToList<ClientePessoaJuridica>();
            return _lista;
        }

        public ClientePessoaJuridica ObterPorCNPJ(String pCNPJ)
        {
             ClientePessoaJuridica _cliente = (from cliente in _lstClientes
                                              where cliente.CNPJ == pCNPJ
                                              select cliente) as ClientePessoaJuridica;
            return _cliente;
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
            
            _clienteAlterado.CNPJ= pCliente.CNPJ;
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
