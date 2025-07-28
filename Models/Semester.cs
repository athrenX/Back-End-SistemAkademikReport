using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public enum SemesterKe
{
    Ganjil,
    Genap
}

public class Semester
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(9)]
    public string TahunAjaran { get; set; }

    [Required]
    [EnumDataType(typeof(SemesterKe))]
    public SemesterKe SemesterKe { get; set; }

    public virtual ICollection<WaliKelas> WaliKelas { get; set; }
    public virtual ICollection<HistoryKelasSiswa> HistoryKelasSiswa { get; set; }
    public virtual ICollection<Nilai> Nilai { get; set; }
}
    