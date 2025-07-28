using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemAkademik.Models;

public class OrtuSiswa
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [ForeignKey("OrangTua")]
    public Guid OrangTuaId { get; set; }

    [ForeignKey("Siswa")]
    public Guid SiswaId { get; set; }

    public bool Verifikasi { get; set; } = false;

    public virtual OrangTua OrangTua { get; set; }
    public virtual Siswa Siswa { get; set; }
}
