# MyRestApiDotnet & MyCrudApp

Proyek ini terdiri dari dua bagian utama:

1. **MyRestApiDotnet** - API berbasis .NET untuk mengelola produk.
2. **MyCrudApp** - Aplikasi berbasis ASP.NET MVC yang berfungsi sebagai front-end untuk mengakses dan mengelola produk melalui API.

## 1. MyRestApiDotnet
### Teknologi yang digunakan
- .NET 8
- Entity Framework Core
- SQL Server
- Swagger

### Cara Menjalankan
#### 1. Clone repository
```bash
git clone https://github.com/username/repository.git
cd MyRestApiDotnet
```

#### 2. Konfigurasi Database
- Buka `appsettings.json`, sesuaikan connection string dengan database Anda.
- Jalankan migrasi database:
```bash
dotnet ef database update
```

#### 3. Jalankan API
```bash
dotnet run
```
API akan berjalan di `http://localhost:5012/`.

#### 4. Mengakses Swagger
Buka browser dan akses `http://localhost:5012/swagger` untuk dokumentasi API.

---

## 2. MyCrudApp
### Teknologi yang digunakan
- ASP.NET MVC
- Razor View Engine
- HttpClient untuk konsumsi API

### Cara Menjalankan
#### 1. Clone repository
```bash
cd MyCrudApp
```

#### 2. Konfigurasi API Endpoint
- Buka `ProductController.cs`, pastikan variabel `apiUrl` mengarah ke API yang benar, misalnya:
```csharp
private readonly string apiUrl = "http://localhost:5012/api/products";
```

#### 3. Jalankan Aplikasi
```bash
dotnet run
```
Aplikasi akan berjalan di `http://localhost:5221/`.

### Struktur Folder
```
MyRestApiDotnet/
│-- Controllers/
│   ├── ProductsController.cs
│-- Models/
│   ├── Product.cs
│-- Data/
│   ├── ApplicationDbContext.cs
│-- appsettings.json
│-- Program.cs
│
MyCrudApp/
│-- Controllers/
│   ├── ProductController.cs
│-- Views/
│   ├── Product/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│-- Models/
│   ├── Product.cs
│-- Program.cs
│-- appsettings.json
```

## 3. Auto Restart Saat Ada Perubahan
Gunakan perintah berikut untuk otomatis merestart aplikasi saat ada perubahan:
```bash
dotnet watch run
```

## 4. Push ke GitHub
Tambahkan `.gitignore` agar file yang tidak perlu tidak ikut di-push:
```bash
# .gitignore untuk proyek .NET
bin/
obj/
*.db
appsettings.json
```
Lalu jalankan:
```bash
git add .
git commit -m "Initial commit"
git push origin main
```

