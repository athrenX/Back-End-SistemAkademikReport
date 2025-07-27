# Sistem Pemantauan Akademik Siswa SMA

Ini adalah proyek backend untuk Sistem Pemantauan Akademik Siswa, yang dibangun untuk mengelola data akademik sekolah, memfasilitasi komunikasi, dan memungkinkan pemantauan oleh guru, siswa, dan orang tua.

---

## 🚀 Fitur Utama

Sistem ini memiliki fungsionalitas yang disesuaikan untuk setiap peran pengguna:

* **Admin Sistem**
    * Mengelola seluruh akun pengguna (tambah, edit, hapus).
    * Mengelola data master seperti kelas, mata pelajaran, dan tahun ajaran.
    * Menetapkan guru mata pelajaran dan wali kelas.
    * Mengatur penempatan siswa di kelas.

* **Guru Mata Pelajaran**
    * Melihat jadwal mengajar pribadi.
    * Menginput dan mengedit nilai harian serta ujian siswa.
    * Mencatat kehadiran siswa per sesi pelajaran.
    * Melihat rekapitulasi nilai dan kehadiran.

* **Wali Kelas**
    * Memantau daftar siswa di kelas perwaliannya.
    * Melihat progres akademik dan kehadiran semua siswa di kelasnya.
    * Mengirim pengumuman penting ke siswa dan orang tua.
    * Melakukan verifikasi untuk akun orang tua yang terhubung dengan siswa.

* **Siswa**
    * Melihat profil, nilai akademik, dan riwayat kehadiran pribadi.
    * Melihat jadwal pelajaran mingguan.
    * Menerima pengumuman dari wali kelas.

* **Orang Tua**
    * Menghubungkan akunnya dengan data akademik anak.
    * Memantau nilai, kehadiran, dan jadwal pelajaran anak.
    * Menerima notifikasi dan pengumuman penting dari sekolah.

---

## 🛠️ Teknologi yang Digunakan

* **Backend**: .NET 8 (C#)
* **Database**: MySQL
* **Object-Relational Mapper (ORM)**: Entity Framework Core 8

---

## ⚙️ Panduan Instalasi dan Konfigurasi

Ikuti langkah-langkah berikut untuk menjalankan proyek ini di lingkungan lokal.

### Prasyarat

Pastikan perangkat lunak berikut sudah terinstal di komputer Anda:
* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* [Git](https://git-scm.com/downloads)
* MySQL Server

### Langkah-langkah Instalasi

1.  **Clone Repositori**
    Buka terminal dan jalankan perintah berikut untuk mengunduh proyek.
    ```bash
    git clone [https://github.com/NAMA_USER_ANDA/SistemAkademik.git](https://github.com/NAMA_USER_ANDA/SistemAkademik.git)
    cd SistemAkademik
    ```

2.  **Konfigurasi Koneksi Database**
    Buka file `appsettings.json` dan sesuaikan bagian `ConnectionStrings` dengan konfigurasi MySQL Anda.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=sistem_akademik_db;User=root;Password=PASSWORD_ANDA;"
    }
    ```

3.  **Instal Dependensi**
    Jalankan perintah ini untuk mengunduh semua paket yang dibutuhkan oleh proyek.
    ```bash
    dotnet restore
    ```

4.  **Buat Database (Migrasi)**
    Perintah ini akan secara otomatis membuat database `sistem_akademik_db` beserta semua tabelnya berdasarkan model yang ada.
    ```bash
    dotnet ef database update
    ```

5.  **Jalankan Proyek**
    Gunakan perintah berikut untuk menjalankan server backend.
    ```bash
    dotnet run
    ```
    Aplikasi akan berjalan dan siap menerima permintaan. URL akan ditampilkan di terminal (contoh: `http://localhost:5123`).

---

## 📄 Dokumentasi API (Swagger)

Setelah proyek berhasil dijalankan, Anda dapat mengakses dokumentasi API interaktif (Swagger UI) untuk melihat semua endpoint yang tersedia dan langsung mencobanya.

Buka browser dan navigasi ke:
**`http://localhost:<PORT>/swagger`**

Ganti `<PORT>` dengan nomor port yang ditampilkan di terminal saat Anda menjalankan proyek.

---

## 📊 Skema Database

Struktur database dirancang untuk mendukung semua fungsionalitas yang ada. Model Entity Framework Core dibuat berdasarkan skema relasional berikut:

![Skema Database](https://dbdiagram.io/d/68856629cca18e685ce1bd2e)

---

Dibuat oleh **[GENERASI EduTech
]**
