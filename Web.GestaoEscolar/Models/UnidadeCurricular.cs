using System.ComponentModel.DataAnnotations;

namespace GestaoEscolar;

public class UnidadeCurricular
{
    public Guid Id {get; set; }

    [Required(ErrorMessage = "O campo nome é obrigatorio!")]
    [StringLength(50, ErrorMessage="O campo nome deve ter entre 3 e 50 caracteres!")]
    [MinLength(3, ErrorMessage="O campo nome deve ter entre 3 e 50 caracteres!")]
    public string Nome {get; set;}

    [Required(ErrorMessage = "O campo Carga Horaria é obrigatorio!")]
    [Display(Name = "Carga Horaria")]
    [Range(1, 400, ErrorMessage="A carga horaria deve estar entre 1h a 400h")]
    public int CargaHoraria {get; set;}


    [Required(ErrorMessage = "O campo Sigla é obrigatorio!")]
    [StringLength(10, ErrorMessage="O campo Sigla deve ter entre 3 e 50 caracteres!")]
    [MinLength(3, ErrorMessage="O campo Sigla deve ter entre 3 e 50 caracteres!")]
    public string Sigla {get;set;}
}
