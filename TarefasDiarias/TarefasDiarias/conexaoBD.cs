﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TarefasDiarias
{
    class conexaoBD
    {
        private string conexaoBanco = "Server =localhost;Database=AppCrud;Uid=root;Pwd=''";

        public MySqlConnection Conectar()
        {
          MySqlConnection conexao = new MySqlConnection(conexaoBanco);
           
            conexao.Open();
            return conexao;
        }
    }
}
