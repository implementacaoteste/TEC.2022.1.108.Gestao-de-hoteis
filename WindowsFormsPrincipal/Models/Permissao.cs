using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Permissao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<GrupoFuncionario> Grupos { get; set; }
    }
}
 