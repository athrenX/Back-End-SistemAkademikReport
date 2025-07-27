using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class Kehadiran
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Siswa")]
    public Guid SiswaId { get; set; }

    [ForeignKey("JadwalPelajaran")]
    public Guid JadwalId { get; set; }
    
    public DateTime Tanggal { get; set; }

    [Required]
    [StringLength(10)]
    public string Status { get; set; } // Contoh: "Hadir", "Izin", "Sakit", "Alpa"

    public virtual Siswa Siswa { get; set; }
    public virtual JadwalPelajaran JadwalPelajaran { get; set; }
}