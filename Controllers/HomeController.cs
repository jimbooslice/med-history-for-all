using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using med_history_for_all.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace med_history_for_all.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


//         public interface IFormFile
// {
//     string ContentType { get; }
//     string ContentDisposition { get; }
//     IHeaderDictionary Headers { get; }
//     long Length { get; }
//     string Name { get; }
//     string FileName { get; }
//     Stream OpenReadStream();
//     void CopyTo(Stream target);
//     Task CopyToAsync(Stream target, CancellationToken cancellationToken = null);
// }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {

            // var uploads = Path.Combine(_environment.WebRootPath, "uploads");
            // if (file.Length > 0)

            // {

            //     using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))

            //     {

            //         await file.CopyToAsync(fileStream);
            //     }
            // }
            return RedirectToAction("Index");
        }
    }
}
