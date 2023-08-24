using System.ComponentModel.DataAnnotations;

namespace Animais.Models
{
    public class AnimaisModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Idade é obrigatório.")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "O campo Raça é obrigatório.")]
        public string Raça { get; set; }

        [Required(ErrorMessage = "O campo Porte é obrigatório.")]
        public string Porte { get; set; }
    }
}
