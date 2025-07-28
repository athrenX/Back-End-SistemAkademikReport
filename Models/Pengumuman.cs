using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class Pengumuman
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Isi { get; set; }

    [ForeignKey("Kelas")]
    public Guid KelasId { get; set; }

    [ForeignKey("User")]
    public Guid DibuatOleh { get; set; }

    [Required]
    public DateTime Tanggal { get; set; } = DateTime.Now;

    public virtual Kelas Kelas { get; set; }
    public virtual User User { get; set; }
}
