using Admin.ViewModel.BibleVersion;
using DataAccess.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Models;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

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
            return PartialView("~/Views/Shared/Modals/_ReadModalData.cshtml", verseList);
        }

        public IActionResult Create()
        {
            BibleVersionCreateViewModel viewModel = new()
            {
                Table = "",
                Abbreviation = "",
                Language = "",
                Version = "",
                BookListSources = _mapper.Map<List<SelectListItem>>(_unitOfWork.BibleVersions.GetAll().ToList()),
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(BibleVersionCreateViewModel newBibleVersion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bibleVersion = _mapper.Map<BibleVersion>(newBibleVersion);

                    if (newBibleVersion.BookListSource != Guid.Empty)
                    {
                        BibleVersion? bibleVersionFromDb = _unitOfWork.BibleVersions.Get(u => u.Id == newBibleVersion.BookListSource);

                        if (bibleVersionFromDb != null)
                        {
                            bibleVersion.BibleBookListId = bibleVersionFromDb.BibleBookListId;
                        }
                    }

                    bibleVersion.Id = Guid.NewGuid();
                    _unitOfWork.BibleVersions.Add(bibleVersion);
                    _unitOfWork.Save();

                    return RedirectToAction("Edit", new { id = bibleVersion.Id });
                }
                catch (Exception)
                {
                }
            }

            newBibleVersion.BookListSources = _mapper.Map<List<SelectListItem>>(_unitOfWork.BibleVersions.GetAll().ToList());
            return View(newBibleVersion);

        }

        public IActionResult Edit(Guid? id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            BibleVersion? bibleVersionFromDb = _unitOfWork.BibleVersions.Get(u => u.Id == id);

            if (bibleVersionFromDb == null)
            {
                return NotFound();
            }

            var newBibleVersion = _mapper.Map<BibleVersionEditViewModel>(bibleVersionFromDb);

            newBibleVersion.BookListSources = _mapper.Map<List<SelectListItem>>(_unitOfWork.BibleVersions.GetAll().ToList());
            return View(newBibleVersion);
        }

        [HttpPost]
        public IActionResult Edit(BibleVersionEditViewModel newBibleVersion)
        {
            if (ModelState.IsValid)
            {
                BibleVersion? bibleVersionFromDb = _unitOfWork.BibleVersions.Get(u => u.Id == newBibleVersion.Id);

                if (bibleVersionFromDb == null)
                {
                    return NotFound();
                }

                bibleVersionFromDb.Table = newBibleVersion.Table;
                bibleVersionFromDb.Abbreviation = newBibleVersion.Abbreviation;
                bibleVersionFromDb.Language = newBibleVersion.Language;
                bibleVersionFromDb.Version = newBibleVersion.Version;
                bibleVersionFromDb.InfoText = newBibleVersion.InfoText;
                bibleVersionFromDb.InfoURL = newBibleVersion.InfoURL;
                bibleVersionFromDb.Publisher = newBibleVersion.Publisher;
                bibleVersionFromDb.Copyright = newBibleVersion.Copyright;
                bibleVersionFromDb.CopyrightInfo = newBibleVersion.CopyrightInfo;

                _unitOfWork.BibleVersions.Update(bibleVersionFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Edit", new { id = newBibleVersion.Id });
            }

            return View(newBibleVersion);
        }

    }
}
