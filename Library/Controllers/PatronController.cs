using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Patron;
using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        IPatron _patron;
        public PatronController(IPatron patron)
        {
            _patron = patron;
        }
        public IActionResult Index()
        {
            var allPatrons = _patron.GetAll();
            var patronModels = allPatrons.Select(p => new PatronDetailModel
            {
                Id = p.Id,
                FirstName = p.FullName ?? "No First Name Provided",
                LastName = p.LastName ?? "No Last Name Provided",
                LibraryCardId = p.LibraryCard.Id,
                OverdueFees = p.LibraryCard.Fees,
                HomeLibraryBranch = p.HomeLibraryBranch.Name
            }).ToList();
            var  model = new PatronIndexModel
            {
                Patron = patronModels
            };
            return View(model);
        }
        public IActionResult Detail(int Id)
        {
            var patron = _patron.Get(Id);
            var model = new PatronDetailModel
            {
                LastName = patron.LastName,
                FirstName = patron.FullName,
                Address = patron.Address,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name,
                TelephoneNumber = patron.TelephoneNumber,
                OverdueFees = patron.LibraryCard.Fees,
                MemberSince = patron.LibraryCard.Created,
                AssetCheckedOut = _patron.GetCheckouts(Id).ToList() ?? new List<Checkout>(),
                CheckoutHistorie = _patron.GetCheckoutHistories(Id),
                Holds = _patron.GetHolds(Id)

            };
            return View(model);

        }
    }
}