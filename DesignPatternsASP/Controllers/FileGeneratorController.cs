using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Security.Permissions;
using Tools.FileGenerator;

namespace DesignPatternsASP.Controllers
{
    public class FileGeneratorController : Controller
    {
        private IUnitOfWork _unitOfWork;

        private FileGeneratorBuilder _fileGeneratorBuilder;

        public FileGeneratorController(IUnitOfWork unitOfWork, FileGeneratorBuilder fileGeneratorBuilder)
        {
            _unitOfWork = unitOfWork;

            _fileGeneratorBuilder = fileGeneratorBuilder;   
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var user = _unitOfWork.Users.Get();

                List<string> content = user.Select(u => u.UserFullName).ToList();

                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";

                var generatorDirector = new FileDirector(_fileGeneratorBuilder);

                if (optionFile == 1)
                {
                    generatorDirector.GenerateSimpleJsonFile(content, path);
                }
                else
                {
                    generatorDirector.GenerateSimplePipesFile(content, path);
                }


                var fileGenerator = _fileGeneratorBuilder.GetFileGenerator();

                fileGenerator.Save();


                return Json("Archivo Generado");
            }
            catch (Exception Exp)
            {
                return BadRequest();
            }

        }
    }
}
