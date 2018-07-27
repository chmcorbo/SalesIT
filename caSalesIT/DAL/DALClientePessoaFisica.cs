using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using caSalesIT.Dominio;

namespace caSalesIT.DAL
{
    class DALClientePessoaFisica
    {
        private ArrayList _clientesPessoaFisica;

        public DALClientePessoaFisica()
        {
            _clientesPessoaFisica = new ArrayList();
        }

        public void Incluir(ClientePessoaFisica pCliente)
        {
            _clientesPessoaFisica.Add(pCliente);
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
            _clientesPessoaFisica.Remove(_clienteExcluir);
        }

        public ClientePessoaFisica ObterPorCodigo(Int32 pCodigo)
        {
            ClientePessoaFisica _cliente = new ClientePessoaFisica();
            Boolean _clienteEncontrado = false;
            foreach (ClientePessoaFisica c in _clientesPessoaFisica)
            {
                if (c.Codigo==pCodigo)
                {
                    _cliente = c.Clone() as ClientePessoaFisica;
                    _clienteEncontrado = true;
                }
            }
            if (_clienteEncontrado)
                return _cliente;
            else
                return null;
        }

        public ArrayList Listar()
        {
            return _clientesPessoaFisica;
        }
    }
}
