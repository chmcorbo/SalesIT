using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using caSalesIT.Dominio;
using caSalesIT.DAL;

namespace caSalesIT
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientePessoaFisica _clientePessoaFisica;
            DALClientePessoaFisica _dalCliente = new DALClientePessoaFisica();
            String _repostaUsuario = String.Empty;

            while (true)
            {
                _clientePessoaFisica = new ClientePessoaFisica();

                Console.Write("Nome: ");
                _clientePessoaFisica.Nome = Console.ReadLine();

                Console.Write("Endereço: ");
                _clientePessoaFisica.Endereco = Console.ReadLine();

                Console.Write("Bairro: ");
                _clientePessoaFisica.Bairro = Console.ReadLine();

                Console.Write("Cidade: ");
                _clientePessoaFisica.Cidade = Console.ReadLine();

                Console.Write("Estado: ");
                _clientePessoaFisica.Estado = Console.ReadLine();

                _dalCliente.Incluir(_clientePessoaFisica);

                Console.Write("Deseja incluir novos clientes (S/N)? ");
                _repostaUsuario = Console.ReadLine();

                if (_repostaUsuario.ToUpper() == "N")
                    break;
            }

            Console.Clear();
            
            ClientePessoaFisica _cliente;
            
            ArrayList _listaClientes = _dalCliente.Listar();

            for (int x=0;x<_listaClientes.Count;x++)
            {
                if (_listaClientes[x] is ClientePessoaFisica)
                {
                    _cliente = _listaClientes[x] as ClientePessoaFisica;
                    Console.WriteLine("Nome {0} ", _cliente.Nome);
                    Console.WriteLine("Endereço {0} ", _cliente.Endereco);
                    Console.WriteLine("Bairro {0} ", _cliente.Bairro);
                    Console.WriteLine("Cidade {0} ", _cliente.Cidade);
                    Console.WriteLine("Estado {0} ", _cliente.Estado);
                    Console.WriteLine("Idade {0} ", _cliente.ObterIdade().ToString());
                }
                
            }

        }
    }
}


