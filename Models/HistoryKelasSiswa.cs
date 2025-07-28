using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class HistoryKelasSiswa
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Siswa")]
    public Guid SiswaId { get; set; }

    [ForeignKey("Kelas")]
    public Guid KelasId { get; set; }

    [ForeignKey("Semester")]
    public Guid SemesterId { get; set; }

    public bool Aktif { get; set; } = true;

    public virtual Siswa Siswa { get; set; }
    public virtual Kelas Kelas { get; set; }
    public virtual Semester Semester { get; set; }
}
