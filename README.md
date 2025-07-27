# Sistem Pemantauan Akademik Siswa SMA

Ini adalah proyek backend untuk Sistem Pemantauan Akademik Siswa, yang dibangun untuk mengelola data akademik sekolah, memfasilitasi komunikasi, dan memungkinkan pemantauan oleh guru, siswa, dan orang tua.

---
## 🚀 Fitur Utama

Sistem ini memiliki fungsionalitas yang disesuaikan untuk setiap peran pengguna:

* **Admin Sistem**
    * [cite_start]Mengelola seluruh akun pengguna (tambah, edit, hapus). [cite: 6]
    * [cite_start]Mengelola data master seperti kelas, mata pelajaran, dan tahun ajaran. [cite: 6]
    * [cite_start]Menetapkan guru mata pelajaran dan wali kelas. [cite: 6]
    * [cite_start]Mengatur penempatan siswa di kelas. [cite: 6]

* **Guru Mata Pelajaran**
    * [cite_start]Melihat jadwal mengajar pribadi. [cite: 8]
    * [cite_start]Menginput dan mengedit nilai harian serta ujian siswa. [cite: 8]
    * [cite_start]Mencatat kehadiran siswa per sesi pelajaran. [cite: 8]
    * [cite_start]Melihat rekapitulasi nilai dan kehadiran. [cite: 8]

* **Wali Kelas**
    * [cite_start]Memantau daftar siswa di kelas perwaliannya. [cite: 10]
    * [cite_start]Melihat progres akademik dan kehadiran semua siswa di kelasnya. [cite: 10]
    * [cite_start]Mengirim pengumuman penting ke siswa dan orang tua. [cite: 10]
    * [cite_start]Melakukan verifikasi untuk akun orang tua yang terhubung dengan siswa. [cite: 10]

* **Siswa**
    * [cite_start]Melihat profil, nilai akademik, dan riwayat kehadiran pribadi. [cite: 12]
    * [cite_start]Melihat jadwal pelajaran mingguan. [cite: 12]
    * [cite_start]Menerima pengumuman dari wali kelas. [cite: 12]

* **Orang Tua**
    * [cite_start]Menghubungkan akunnya dengan data akademik anak. [cite: 14]
    * [cite_start]Memantau nilai, kehadiran, dan jadwal pelajaran anak. [cite: 14]
    * [cite_start]Menerima notifikasi dan pengumuman penting dari sekolah. [cite: 14]

---
## 🛠️ Teknologi yang Digunakan

* **Backend**: .NET 8 (C#)
* **Database**: MySQL
* **Object-Relational Mapper (ORM)**: Entity Framework Core 8

---
## ⚙️ Instalasi dan Konfigurasi Lokal

Untuk menjalankan proyek ini di komputer lokal Anda, ikuti langkah-langkah berikut:

1.  **Instal .NET 8 SDK**
    * Cek apakah .NET sudah terinstal dengan membuka terminal dan menjalankan perintah:
        ```bash
        dotnet --version
        ```
    * Jika perintah tersebut gagal atau versinya bukan 8.x.x, unduh dan instal .NET 8 SDK dari [situs resmi Microsoft](https://dotnet.microsoft.com/download).

2.  **Clone Repositori Ini**
    ```bash
    git clone [https://github.com/NAMA_USER_ANDA/SistemAkademik.git](https://github.com/NAMA_USER_ANDA/SistemAkademik.git)
    cd SistemAkademik
    ```

3.  **Konfigurasi Database**
    * Buka file `appsettings.json`.
    * Ubah `ConnectionStrings` agar sesuai dengan konfigurasi MySQL lokal Anda.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=sistem_akademik_db;User=root;Password=PASSWORD_ANDA;"
    }
    ```

4.  **Restore Semua Package yang Dibutuhkan**
    ```bash
    dotnet restore
    ```

5.  **Buat Database Menggunakan Entity Framework Core**
    * Perintah ini akan membaca model dan membuat semua tabel di database MySQL Anda.
    ```bash
    dotnet ef database update
    ```

6.  **Jalankan Proyek**
    ```bash
    dotnet run
    ```
    Aplikasi sekarang akan berjalan dan dapat diakses melalui `http://localhost:<port>`.

---
## 📊 Skema Database

Struktur database dirancang untuk mendukung semua fungsionalitas yang ada. Model Entity Framework Core dibuat berdasarkan skema relasional berikut:

![Skema Database](https://i.imgur.com/uR1j9sM.png)

---

Dibuat oleh [Nama Anda]
