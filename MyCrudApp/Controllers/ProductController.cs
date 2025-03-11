using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyCrudApp.Models;

namespace MyCrudApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string apiUrl = "http://localhost:5012/api/products"; // Sesuaikan dengan API

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Menampilkan daftar produk
       public async Task<IActionResult> Index()
            {
                try
                {
                    var response = await _httpClient.GetAsync(apiUrl);
                    Console.WriteLine($"Status Code: {response.StatusCode}");

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error Response: {await response.Content.ReadAsStringAsync()}");
                        return View(new List<Product>()); 
                    }

                    var responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"API Response: {responseBody}");

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Biar case tidak berpengaruh
                    };

                    var products = JsonSerializer.Deserialize<List<Product>>(responseBody, options);
                    Console.WriteLine($"Jumlah Produk: {products?.Count ?? 0}");

                    return View(products);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return View(new List<Product>());
                }
            }



        // Menampilkan form tambah produk
        public IActionResult Create()
        {
            return View();
        }

        // Menyimpan produk baru ke API
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                var json = JsonSerializer.Serialize(product);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(apiUrl, content);
                Console.WriteLine($"POST Status Code: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"POST Response: {responseBody}");
                    return RedirectToAction("Index");
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"POST Error: {errorMessage}");
                    ModelState.AddModelError(string.Empty, "Gagal menambahkan produk");
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"POST Exception: {ex.Message}");
                ModelState.AddModelError(string.Empty, "Terjadi kesalahan saat menghubungi API.");
                return View(product);
            }
        }
    }
}
