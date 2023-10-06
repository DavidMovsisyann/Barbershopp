using Barbershopp.Models;
using BarberShopp.Entities;
using BarberShopp.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Barbershopp.Controllers
{
    public class PagesController : Controller
    {
        private readonly IBarberServicesService _servService;
        private readonly IEmployeeService _empService;
        private readonly IBookingHistoryService _bookHistoryService;
        private readonly IUserService _userService;

        public PagesController(IBarberServicesService servService, IEmployeeService employeeService, IBookingHistoryService bookingHistoryService, IUserService userService)
        {
            _servService = servService;
            _empService = employeeService;
            _bookHistoryService = bookingHistoryService;
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> Home()
        {
            var model = new HomePageModels()
            {
                Employees = await _empService.GetEmployees(),
                Services = await _servService.GetServices()
            };
            return View("Views/WebPages/Home2.cshtml", model);
        }
        [HttpGet]
        public IActionResult AboutUs()
        {
            return View("Views/WebPages/AboutUs.cshtml");
        }
        [HttpGet]
        public async Task<IActionResult> Barbers()
        {
            var model = new HomePageModels()
            {
                Employees = await _empService.GetEmployees(),
                Services = await _servService.GetServices(),
            };
            return View("Views/WebPages/Barbers.cshtml", model);
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Book(HomePageModels model)
        {

            var model1 = new HomePageModels()
            {
                Employees = await _empService.GetEmployees(),
                Services = await _servService.GetServices(),
            };
            await _bookHistoryService.AddBookingHistory(model.Booking);
            return RedirectToAction("Home", "Pages");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View("Areas/Identity/Pages/Account/Login.cshtml");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View("Areas/Identity/Pages/Account/Register.cshtml");
        }

        [HttpPost]
        public RedirectToActionResult RegisterNewUser(UserEntity user)
        {
            _userService.AddUser(user);
            return RedirectToAction("Barbers", "Pages");
        }
        [HttpGet]
        public async Task<List<DateTime>> GetBusyDates(string employeeName)
        {
            List<DateTime> busyDates = new List<DateTime>();
            var bookings = await _bookHistoryService.GetBookingHistorys();
            var employee = await _empService.GetEmployeeByName(employeeName);
            foreach (var booking in bookings.Where(a=>a.EmployeeName==employeeName))
            {
                busyDates.Add(booking.BookedDate);
            }
            busyDates.Add(employee.BusyTime);
            return busyDates;
        }
    }
}
