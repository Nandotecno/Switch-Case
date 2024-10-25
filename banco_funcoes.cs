using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Banco
{
    internal class banco_funcoes
    {
        private SQLiteConnection _conexao;
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public void criarBancoDeDados()
        {
            string dbPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Alunos.db3");
            _conexao = new SQLiteConnection(dbPath);
            _conexao.CreateTable<Alunos>();
        }

        public void inserirAluno(string nome, string idade)
        {
            _conexao.Query<Alunos>("INSERT INTO alunos(nome, idade) VALUES('"+nome+"',"+idade+")");
        }

        public List<Alunos> getAlunos()
        { 
            return _conexao.Query<Alunos>("SELECT * FROM Alunos");
        }

        public void excluirAluno(string id)
        {
            _conexao.Query<Alunos>("DELETE FROM Alunos where id = " + id);
        }
    }
}
