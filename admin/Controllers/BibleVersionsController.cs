using Admin.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BibleVersionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public BibleVersionsController(IUnitOfWork unitOfWork, IMapper mapper)
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
            return Ok(objBibleVersionList);
        }

        public IActionResult Details(Guid id)
        {
            var objBibleVersionList = _mapper.Map<BibleVersionViewModel>(_unitOfWork.BibleVersions.Get(x => x.Id == id, "BibleBookList"));
            return View(objBibleVersionList);
        }

        [HttpPost]
        public IActionResult GetChapter(ChapterRequestViewModel reguest)
        {
            if (string.IsNullOrEmpty(reguest.Bible))
            {
                return NotFound();
            }

            var verseList = _unitOfWork.BibleVerses.GetChapterVerses(reguest.Bible, reguest.Book, reguest.Chapter);

            // return Ok(new { success = true, data = _mapper.Map<List<BibleVerseViewModel>>(verseList) });
            return PartialView("~/Views/BibleView/Partial/ReadModal .cshtml", verseList);
        }
    }
}
