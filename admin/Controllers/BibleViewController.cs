using Admin.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BibleViewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public BibleViewController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<BibleVersionDatatableViewModel> objBibleVersionList = new();
            return View(objBibleVersionList);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objBibleVersionList = _mapper.Map<List<BibleVersionDatatableViewModel>>(_unitOfWork.BibleVersions.GetAll().ToList());
            return Json(new { data = objBibleVersionList });
        }

        public IActionResult Details(Guid id)
        {
            var objBibleVersionList = _mapper.Map<BibleVersionViewModel>(_unitOfWork.BibleVersions.Get(x => x.Id == id));
            return View(objBibleVersionList);
        }

        public IActionResult GetChapter(Guid id)
        {
            return Ok(new { success = true});
        }

    }
}
