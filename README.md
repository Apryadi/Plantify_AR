
<div align="center">
  <img src="Logo.png" alt="Plantify AR Logo" width="400">
</div>

Plantify AR adalah sebuah aplikasi *Augmented Reality* (AR) yang mensimulasikan siklus pertumbuhan tanaman. Dengan memanfaatkan teknologi AR (berbasis Vuforia), pengguna dapat belajar dan berinteraksi secara langsung dengan berbagai jenis tanaman, seperti Jagung dan Padi, dari tahap bibit hingga panen.

## Fitur Utama
- **Simulasi Pertumbuhan:** Melakukan simulasi siklus hidup tanaman mulai dari benih, pertumbuhan, hingga dewasa.
- **Interaksi Perawatan Tanaman:** Fitur interaktif untuk menyiram (*Siram*) dan memberi pupuk (*Pupuk*) guna mendukung pertumbuhan tanaman.
- **Teknologi Augmented Reality:** Menampilkan model 3D tanaman di dunia nyata menggunakan *Vuforia Engine*.
- **Berbagai Jenis Tanaman:** Menyediakan beberapa jenis tanaman seperti Jagung (*Corn*) dan Padi (*Paddy*).

## Kebutuhan Sistem
Untuk menjalankan, merombak, atau mem-build *project* ini, Anda membutuhkan:
- **Unity Editor** (disarankan menggunakan versi *LTS* terbaru yang mendukung *Universal Render Pipeline/URP*).
- **Vuforia Engine AR** *Package*.
- **Android SDK / NDK** & **iOS Build Support** (jika ingin di-build ke perangkat *mobile*).

## Struktur Proyek
- `Assets/` - Direktori utama penyimpanan aset-aset proyek.
  - `Scenes/` - Kumpulan *scene* Unity seperti *OnBoarding*, *Halaman Awal*, dan *scene* AR utama.
  - `jagung/` & `Padi/` - Folder berisi *3D models* dan animasi tanaman terkait.
  - `Editor/Vuforia/` - Konfigurasi editor untuk Vuforia.
- `Packages/` - Daftar dependensi paket *Unity* (seperti *Timeline*, *Cinemachine*, dsb).
- `ProjectSettings/` - Pengaturan dari proyek *Unity*, input *settings*, dan kualitas grafis.

## Panduan Instalasi dan Penggunaan
1. **Clone/Download** *repository* atau salin *folder* proyek ini ke *storage* lokal Anda.
2. Buka **Unity Hub**, klik **Add** lalu pilih *folder* `Plantify_AR`.
3. Buka proyek tersebut (tunggu beberapa saat untuk proses import *libraries* dan aset).
4. Buka menu **File > Build Settings** dan pastikan *scene* yang digunakan berada pada urutan yang benar (Contoh: `onBoarding.unity` diletakkan pertama).
5. Pastikan layar Vuforia *Configuration* (di menu **Window > Vuforia Configuration**) sudah memuat *App License Key* yang valid jika diperlukan (terutama jika ingin membangun aplikasi final).
6. Tekan tombol **Play** di Unity Editor untuk mencoba secara virtual (menggunakan *webcam*), atau *build* proyek ke *device* Android/iOS melalui menu **Build System** atau **Build and Run**.

## Cara Bermain
- Arahkan kamera aplikasi ke *marker* atau area pelacakan Vuforia.
- Menekan tombol interaktif (misalnya untuk menyiram/siram) akan memicu animasi pertumbuhan pada model tanaman yang tersorot.
- Jelajahi dan pelajari proses tumbuhan dengan menyelesaikan tahap-tahapan yang disediakan.

---
*Dibuat menggunakan Unity 3D.*