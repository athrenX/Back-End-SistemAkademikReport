using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public enum JenisKelamin
{
    Laki_Laki,
    Perempuan
}

public class Siswa
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [ForeignKey("User")]
    public Guid UserId { get; set; }
    [Required]
    [StringLength(20)]
    public string NISN { get; set; }
    [Required]
    [StringLength(100)]
    public string NamaLengkap { get; set; }
    [EnumDataType(typeof(JenisKelamin))]
    public JenisKelamin JenisKelamin { get; set; }
    public DateTime? TanggalLahir { get; set; }
    public virtual User User { get; set; }
}