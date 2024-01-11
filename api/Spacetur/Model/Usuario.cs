using System.ComponentModel.DataAnnotations.Schema;

namespace Spacetur.Model
{
   [Table("Usuarios")]
    public class Usuario{
            [Column("id")]
        public int Id {get; set;}
          [Column(" usuario_nome")] 
        public string Nome {get;  set;} = string.Empty;
          [Column(" usuario_cpf")]
        public string Cpf {get;  set;} = string.Empty;
         [Column(" usuario_email")]
        public string Email {get;  set;} = string.Empty;
        [Column(" usuario_senha")]
        public string Senha {get;  set;} = string.Empty;
        [Column(" usuario_telefone")]

        public string Telefone{get;  set;} = string.Empty;
               [Column("usuario_destino")]
        public string Destino{get;  set;} = string.Empty;
    }   

}
