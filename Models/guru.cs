using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class Guru
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [Required]
    [StringLength(100)]
    public string NamaLengkap { get; set; }

    public virtual User User { get; set; }
}
