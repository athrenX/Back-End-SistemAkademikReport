using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class LogAktivitas
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [Required]
    public string Aksi { get; set; }

    [Required]
    public DateTime Waktu { get; set; } = DateTime.Now;

    public virtual User User { get; set; }
}
