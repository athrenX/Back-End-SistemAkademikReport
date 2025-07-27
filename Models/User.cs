using System.ComponentModel.DataAnnotations;

namespace SistemAkademik.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]

    [StringLength(50)]
    public string username { get; set; }
    [Required]

    [StringLength(255)]
    public string PasswordHash { get; set; }
    [Required]
    [StringLength(10)]

    public string Role { get; set; } //"admin", "Guru", "Siswa", "ortu", "wali_kelas"
    public bool Status { get; set; }

}