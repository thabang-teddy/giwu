using Admin.ViewModel.BibleBookList;
using AutoMapper;
using DataAccess.Models;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Admin.Controllers
{
    public class BookListsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public BookListsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<BibleBookListDatatableViewModel> objBibleBookListList = new();
            return View(objBibleBookListList);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var objBibleBookListList = _mapper.Map<List<BibleBookListDatatableViewModel>>(_unitOfWork.BibleBookLists.GetAll().ToList());
                return Ok(objBibleBookListList);
            }
            catch (Exception ex)
            {
                return Ok(new List<object>());
            }
        }

        public IActionResult Details(Guid id)
        {
            var objBibleBookListList = _mapper.Map<BibleBookListDetailsViewModel>(_unitOfWork.BibleBookLists.Get(x => x.Id == id));
            return View(objBibleBookListList);
        }

        public IActionResult Edit(Guid? id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            BibleBookList? bibleVersionFromDb = _unitOfWork.BibleBookLists.Get(u => u.Id == id);

            if (bibleVersionFromDb == null)
            {
                return NotFound();
            }

            var newBibleBookList = _mapper.Map<BibleBookListEditViewModel>(bibleVersionFromDb);
            if (!string.IsNullOrEmpty(bibleVersionFromDb.BookList))
            {
                newBibleBookList.BookLists = JsonConvert.DeserializeObject<List<BibleBookListItemViewModel>>(bibleVersionFromDb.BookList);
            }
            return View(newBibleBookList);
        }

        [HttpPost]
        public IActionResult Edit(BibleBookListEditViewModel newBibleBookList)
        {
            if (ModelState.IsValid)
            {
                BibleBookList? bibleBookListFromDb = _unitOfWork.BibleBookLists.Get(u => u.Id == newBibleBookList.Id);

                if (bibleBookListFromDb == null)
                {
                    return NotFound();
                }

                bibleBookListFromDb.Name = newBibleBookList.Name;
                bibleBookListFromDb.BookList = newBibleBookList.BookList;
                bibleBookListFromDb.CreatedDate = newBibleBookList.CreatedDate;
                bibleBookListFromDb.LastUpdatedDate = newBibleBookList.LastUpdatedDate;

                _unitOfWork.BibleBookLists.Update(bibleBookListFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Edit", new { id = newBibleBookList.Id });
            }

            return View(newBibleBookList);
        }

    }
}
