# MyCrudApp

MyCrudApp adalah aplikasi berbasis ASP.NET Core MVC yang berfungsi sebagai CRUD sederhana untuk mengelola produk. Aplikasi ini menggunakan API sebagai backend untuk mengambil dan menyimpan data produk.

## 📂 Struktur Folder
```
MyCrudApp/
│-- Controllers/           # Berisi controller untuk menangani request
│   │-- ProductController.cs
│-- Models/               # Berisi model untuk merepresentasikan data
│   │-- Product.cs
│-- Views/                # Berisi tampilan HTML (Razor Views)
│   │-- Product/
│       │-- Index.cshtml  # Menampilkan daftar produk
│       │-- Create.cshtml # Form untuk menambah produk
│-- wwwroot/              # Berisi file statis seperti CSS dan JS
│-- appsettings.json      # Konfigurasi aplikasi
│-- Program.cs            # Entry point aplikasi
│-- Startup.cs            # Konfigurasi aplikasi dan dependency injection
│-- MyCrudApp.csproj      # File konfigurasi proyek .NET
```

## 🚀 Cara Menjalankan Aplikasi
### 1️⃣ **Clone Repository**
```sh
git clone <repository-url>
cd MyCrudApp
```

### 2️⃣ **Jalankan API Backend**
Pastikan API sudah berjalan di `http://localhost:5012/api/products`. Jika belum, jalankan API terlebih dahulu.

### 3️⃣ **Jalankan Aplikasi**
```sh
dotnet run
```
Atau dengan mode development:
```sh
dotnet watch run
```

### 4️⃣ **Akses Aplikasi di Browser**
Buka `http://localhost:5221/Product/Index` untuk melihat daftar produk.

## 🔧 Konfigurasi API Endpoint
Jika API berjalan di URL yang berbeda, ubah variabel `apiUrl` di `ProductController.cs`:
```csharp
private readonly string apiUrl = "http://localhost:5012/api/products";
```

## 🛠 Fitur yang Tersedia
✅ **Menampilkan daftar produk**
✅ **Menambahkan produk baru**
✅ **Terhubung dengan API backend**

## 📜 Lisensi
Proyek ini menggunakan lisensi MIT.

