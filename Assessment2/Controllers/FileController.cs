using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System;
using Assessment2.Models;

namespace Assessment2.Controllers
{
    public class FileController : Controller
    {
        public IActionResult File()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                try
                {
                    using (var streamReader = new StreamReader(file.OpenReadStream(), Encoding.UTF8))
                    {
                        string fileContent = streamReader.ReadToEnd();

                        var GetFile = new FileModel();
                        var lines = fileContent.Split('\n');

                        // Create a new Book instance
                       

                        // Parse each line
                        foreach (var line in lines)
                        {
                            var parts = line.Split(':');
                            if (parts.Length == 2)
                            {
                                var key = parts[0].Trim();
                                var value = parts[1].Trim();

                                // Assign values to the Book properties
                                switch (key)
                                {
                                    case "BookID":
                                        GetFile.FileID = value;
                                        break;
                                    case "BookName":
                                        GetFile.FileName = value;
                                        break;
                                    case "Author":
                                        GetFile.Author = value;
                                        break;
                                        // Add more cases as needed
                                }
                            }
                        }


                        // Assuming you have a PartialView for displaying the table content
                        return PartialView("Table", GetFile);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions, log errors, or return an error response
                    return PartialView("Error", ex.Message);
                }
            }

            return PartialView("Error", "Invalid file");
        }
    }
}
