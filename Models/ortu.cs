using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class OrangTua
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("User")]
    public Guid UserId { get; set; }



    [Required]
    [StringLength(100)]
    public string Nama { get; set; }

    [StringLength(20)]
    public string Telepon { get; set; }

    public virtual User User { get; set; }
}
