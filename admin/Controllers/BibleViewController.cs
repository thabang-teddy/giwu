using DataAccess.Models;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BibleViewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BibleViewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<BibleVersion> objBibleVersionList = new();
            return View(objBibleVersionList);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<BibleVersion> objBibleVersionList = _unitOfWork.BibleVersions.GetAll().ToList();
            return Json(new { data = objBibleVersionList });
        }

    }
}
