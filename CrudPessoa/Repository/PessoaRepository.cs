﻿using CrudPessoa.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoa.Repository
{
    public class PessoaRepository
    {
        public void Inserir(Pessoa pessoa) 
        { 
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();
            conexao.Execute("INSERT INTO PESSOA (NOME, CPF, EMAIL) VALUES (@nome, @cpf, @email);",
            new
            {
                nome = pessoa.Nome,
                cpf = pessoa.Cpf,
                email = pessoa.Email
            });
        }

        public void Atualizar(Pessoa pessoa)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE PESSOA SET NOME = @nome, CPF = @cpf, EMAIL = @email WHERE ID = @id",
            new
            {
                nome = pessoa.Nome,
                cpf = pessoa.Cpf,
                email = pessoa.Email,
                id = pessoa.Id
            });
        }

        public void Deletar(int id)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM PESSOA WHERE ID = @id",
            new
            {
                id
            });
        }

        public Pessoa BuscarPessoaPeloId(int id)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();
            return conexao.QueryFirstOrDefault<Pessoa>("SELECT * FROM PESSOA WHERE ID = @id",
            new
            {
                id
            });
        }

        public IEnumerable<Pessoa> BuscarTodasPessoas()
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Pessoa>("SELECT * FROM PESSOA");
        }
    }
}
