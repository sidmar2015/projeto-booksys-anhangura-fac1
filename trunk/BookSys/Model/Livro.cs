using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSys.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public string Lingua { get; set; }
        public int Paginas { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Isbn { get; set; }
    }
}