using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Cor")]
 public class Cor
 {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O nome deve conter no máximo 30 caracteres")]
    public string Nome { get; set; }
    
    [Display(Name = "Código Hexa", Prompt = "Ex. #000000")]
    [Required(ErrorMessage = "Por favor, informe o Código Hexa")]
    [StringLength(7, ErrorMessage = "O código deve conter no máximo 30 caracteres")]
    public string CodigoHexa { get; set; }
 }
