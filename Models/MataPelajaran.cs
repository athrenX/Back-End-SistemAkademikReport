using System.ComponentModel.DataAnnotations;

namespace SistemAkademik.Models;

public class MataPelajaran
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(100)]
    public string NamaMapel { get; set; }
}
