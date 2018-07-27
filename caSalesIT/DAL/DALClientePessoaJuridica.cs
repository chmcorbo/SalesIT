using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using caSalesIT.Dominio;

namespace caSalesIT.DAL
{
    class DALClientePessoaJuridica
    {        
        List<ClientePessoaJuridica> _lstClientes;

        public DALClientePessoaJuridica()
        {
            _lstClientes = new List<ClientePessoaJuridica>();
        }

        public ClientePessoaJuridica ObterPorCodigo(Int32 pCodigo)
        {
            ClientePessoaJuridica _cliente = _lstClientes.Where(c => c.Codigo == pCodigo).FirstOrDefault();
            return _cliente.Clone() as ClientePessoaJuridica;
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
