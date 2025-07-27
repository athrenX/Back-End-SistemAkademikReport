using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class JadwalPelajaran
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Kelas")]
    public Guid KelasId { get; set; }

    [ForeignKey("MataPelajaran")]
    public Guid MapelId { get; set; }

    [ForeignKey("Guru")]
    public Guid GuruId { get; set; }

    [Required]
    [StringLength(10)]
    public string Hari { get; set; } // Contoh: "Senin", "Selasa"

    public TimeSpan JamMulai { get; set; }
    public TimeSpan JamSelesai { get; set; }

    public virtual Kelas Kelas { get; set; }
    public virtual MataPelajaran MataPelajaran { get; set; }
    public virtual Guru Guru { get; set; }
}