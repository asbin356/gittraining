using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aspose.Pdf;
using System.Data;
using System.IO;
using TextAreaMessageToPdf.Models;
using TextAreaMessageToPdf.Data;
using System.Drawing;
using System.Reflection.Metadata;
using Document = Aspose.Pdf.Document;

namespace TextAreaMessageToPdf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var document = new Document
            //{
            //    PageInfo = new PageInfo { Margin = new MarginInfo(28, 28, 28, 40) }
            //};
            //var pdfpage = document.Pages.Add();
            //Table table = new Table
            //{
            //    ColumnWidths = "25% 25% 25% 25%",
            //    DefaultCellPadding = new MarginInfo(10, 5, 10, 5),
            //    Border = new BorderInfo(BorderSide.All,.5f, Aspose.Pdf.Color.Black),
            //    DefaultCellBorder = new BorderInfo(BorderSide.All,.2f, Aspose.Pdf.Color.Black),
            //};

            //DataTable dt = ApplicationDbContext.Getrecord();
            //table.ImportDataTable(dt,true,0,0);
            //document.Pages[1].Paragraphs.Add(table);


            //using(var streamout = new MemoryStream())
            //{
            //    document.Save(streamout);
            //    return new FileContentResult(streamout.ToArray(), "application/pdf")
            //    {
            //        FileDownloadName = "Countryname.pdf"
            //    };
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult pdf1()
        {
            return View();
        }


        public IActionResult pdf()
        {
            return View();
        }

        public IActionResult Exportpdf()
        {
            return View();
        }

        public IActionResult Exportpdf1()
        {
            return View();
        }

        public IActionResult Exportpdf2()
        {
            return View();
        }

        public IActionResult DivToImage()
        {
            return View();
        }

        public IActionResult DivtoImage2()
        {
            return View();
        }

        public IActionResult DivToImage3()
        {
            return View();
        }

        public IActionResult DivToPdf()
        {
            return View();
        }
 
        public IActionResult DivtoPdf1()
        {
            return View();
        }

        public IActionResult TableChartToPdf()
        {
            return View();
        }

        public IActionResult DivtoPdfwithcss()
        {
            return View();
        }

        public IActionResult DivtoPdfwithcss1()
        {
            return View();
        }

        public IActionResult MultiTabInSingle()
        {
            return View();
        }

        public IActionResult MultiTabInSingle2()
        {
            return View();
        }

        public IActionResult Multitab()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
