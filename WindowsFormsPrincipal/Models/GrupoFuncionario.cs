using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Models
{
    public class GrupoFuncionario
    {
        public int Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}
