using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class Nilai
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Siswa")]
    public Guid SiswaId { get; set; }

    [ForeignKey("MataPelajaran")]
    public Guid MapelId { get; set; }

    [ForeignKey("JenisNilai")]
    public Guid JenisNilaiId { get; set; }

    public float NilaiAngka { get; set; }
    public DateTime Tanggal { get; set; }

    [ForeignKey("Semester")]
    public Guid SemesterId { get; set; }

    public virtual Siswa Siswa { get; set; }
    public virtual MataPelajaran MataPelajaran { get; set; }
    public virtual JenisNilai JenisNilai { get; set; }
    public virtual Semester Semester { get; set; }
}