using System.ComponentModel.DataAnnotations;

namespace ScoutApi.Models
{
    public class Equipe
    {
        public int Id { get;  set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        public string Estado { get; set; }
        public string Modalidade { get; set; }
        
    }
}
