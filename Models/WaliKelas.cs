using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class WaliKelas
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("Guru")]
    public Guid GuruId { get; set; }

    [ForeignKey("Kelas")]
    public Guid KelasId { get; set; }

    [ForeignKey("Semester")]
    public Guid SemesterId { get; set; }

    public virtual Guru Guru { get; set; }
    public virtual Kelas Kelas { get; set; }
    public virtual Semester Semester { get; set; }
}
