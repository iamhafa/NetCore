using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCore.Data;
using NetCore.Models;
using NetCore.Models.Process;

namespace NetCore.Controllers
{
    public class ExamController : Controller
    {
        private readonly ApplicationDBContext _context;
        private ExcelProcess _excelPro = new ExcelProcess();

        public ExamController(ApplicationDBContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public IConfiguration Configuration{get;}


        // GET: Exam
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exams.ToListAsync());
        }

        // GET: Exam/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .FirstOrDefaultAsync(m => m.SubjectID == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // GET: Exam/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectID", "SubjectName", "SubjectType", "StudentName", "Class", "PointOfStudent")] Exam exam, IFormFile file)
        {
            if (file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
                else
                {
                    //rename file when upload to server
                    //tao duong dan /Uploads/Excels de luu file upload len server
                    var fileName = "Exam_File";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName + fileExtension);
                    var fileLocation = new FileInfo(filePath).ToString();

                    if (ModelState.IsValid)
                    {
                        
                        //upload file to server
                        if (file.Length > 0)
                        {
                            _context.Add(exam);
                            await _context.SaveChangesAsync();
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                //save file to server
                                await file.CopyToAsync(stream);
                                //read data from file and write to database
                                //_excelPro la doi tuong xu ly file excel ExcelProcess
                                var dt = _excelPro.ExcelToDataTable(fileLocation);
                                //ghi du lieu datatable vao database
                                WriteInformaticsResults(dt);
                            }
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
            }
            return View(exam);
        }

        private int WriteInformaticsResults(DataTable dt){
            try
            {
                var con = Configuration.GetConnectionString("ApplicationDBContext");
                SqlBulkCopy bulkcopy = new SqlBulkCopy(con);
                bulkcopy.DestinationTableName = "Exams";
                bulkcopy.ColumnMappings.Add(0, "SubjectID");
                bulkcopy.ColumnMappings.Add(1, "SubjectName");
                bulkcopy.ColumnMappings.Add(2, "SubjectType");
                bulkcopy.ColumnMappings.Add(3, "StudentName");
                bulkcopy.ColumnMappings.Add(4, "Class");
                bulkcopy.ColumnMappings.Add(5, "PointOfStudent");
                bulkcopy.WriteToServer(dt);
            }
            catch{
                return 0;
            }
            return dt.Rows.Count;
        }



        // GET: Exam/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            return View(exam);
        }

        // POST: Exam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SubjectID", "SubjectName", "SubjectType", "StudentName", "Class", "PointOfStudent")] Exam exam)
        {
            if (id != exam.SubjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamExists(exam.SubjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(exam);
        }

        // GET: Exam/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .FirstOrDefaultAsync(m => m.SubjectID == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // POST: Exam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var exam = await _context.Exams.FindAsync(id);
            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamExists(string id)
        {
            return _context.Exams.Any(e => e.SubjectID == id);
        }
    }
}
