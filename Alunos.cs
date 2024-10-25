using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Banco
{
    internal class Alunos
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string nome { get; set; }

        public string idade { get; set; }
    }
}
