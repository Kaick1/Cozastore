using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Tamanho")]
 public class Tamanho
 {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage ="Por favor, informe a Sigla")]
    [StringLength(5, ErrorMessage = "A sigla deve possuir no máximo 5 caracteres")]
    public string Sigla { get; set; }

    [Required(ErrorMessage = "Por favor, informe um tamanho")]
    public string Nome { get; set; }

 }
