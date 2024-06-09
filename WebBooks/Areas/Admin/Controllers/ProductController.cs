using Microsoft.AspNetCore.Mvc;
using WebBooks.DataAccess.Repository.IRepository;

namespace WebBooks.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        ProductController (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
