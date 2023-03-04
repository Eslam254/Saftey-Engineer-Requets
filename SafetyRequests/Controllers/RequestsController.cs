using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using SafetyRequests.Interfaces;
using SafetyRequests.Models;
using SafetyRequests.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyRequests.Controllers
{
    public class RequestsController : Controller
    {
        private readonly SafteyRequestsContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IRequestRepository _requestRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IDepartmentRepository _departmentRepository;
        public RequestsController(SafteyRequestsContext context, IRoleRepository roleRepository , IDepartmentRepository departmentRepository,IRequestRepository requestRepository , IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
            _requestRepository = requestRepository;
            _roleRepository = roleRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var Requests = await _context.Requests.Include(m => m.Department).ToListAsync();
            return View(Requests);
        }
        public async Task<IActionResult> Create()
        {
            var viewModel = new RequestsViewModel
            {
                //Departments = await _context.Departments.OrderBy(m => m.DepartmentName).ToListAsync(),
                Departments = await _departmentRepository.GetAll(),
                EmployeeRoles = await _roleRepository.GetAll()
            };

            return View("RequestsForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments = await _departmentRepository.GetAll();
                model.EmployeeRoles = await _roleRepository.GetAll();
                return View("RequestsForm", model);
            }

            var Requests = new SafetyRequests.Models.DB.Request
            {
                EmployeeName = model.EmployeeName,
                DepartmentId = model.DepartmentId,
                RoleId = model.EmployeeRoleId,
                CreatedDate = DateTime.Now,
                Status = Models.DB.RequestStatus.New,
                PlannedActivity = model.PlannedActivity,
                Equipments = model.Equipments,
                WorkingStartDate = model.WorkingStartDate,
                WorkingEndDate = model.WorkingEndDate
            };

            _context.Requests.Add(Requests);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Request created successfully");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var Request = await _requestRepository.GetById(id);

            if (Request == null)
                return NotFound();

            var viewModel = new RequestsViewModel
            {
                Id = Request.Id,
                EmployeeName = Request.EmployeeName,
                DepartmentId = Request.DepartmentId,
                EmployeeRoleId = Request.RoleId,
                ModifiedDate = DateTime.Now,
                PlannedActivity = Request.PlannedActivity,
                Equipments = Request.Equipments,
                newId = Request.newId,
                Departments = await _context.Departments.OrderBy(m => m.DepartmentName).ToListAsync(),
                EmployeeRoles = await _context.EmployeeRoles.OrderBy(m => m.RoleNqme).ToListAsync(),
            };

            return View("RequestsForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RequestsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Departments =  await _departmentRepository.GetAll();
                model.EmployeeRoles = await  _roleRepository.GetAll();
                return View("RequestsForm", model);
            }

            var req = await  _requestRepository.GetById(model.Id);

            if (req == null)
                return NotFound();

            req.EmployeeName = model.EmployeeName;
            req.RoleId = model.EmployeeRoleId;
            req.Equipments = model.Equipments;
            req.PlannedActivity = model.PlannedActivity;
            req.DepartmentId = model.DepartmentId;
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Request updated successfully");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return BadRequest();

            var req = await _context.Requests.Include(m => m.Department).SingleOrDefaultAsync(m => m.Id == id);

            if (req == null)
                return NotFound();

            return View(req);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var req = await _requestRepository.GetById(id);

            if (req == null)
                return NotFound();

            _context.Requests.Remove(req);
            _context.SaveChanges();

            return Ok();
        }
        public async Task<IActionResult> Approve(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();

            var req = await _requestRepository.GetById(id);

            if (req == null)
                return NotFound();
            req.Status = Models.DB.RequestStatus.Approved;
            req.LastModifiedDate = DateTime.Now;
            _context.SaveChanges();

            return Ok();
        }
        public async Task<IActionResult> Reject(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest();
            
            var req = await _requestRepository.GetById(id);
            if (req.Status == Models.DB.RequestStatus.Rejected)
            {
                ModelState.AddModelError("Request", "Request Already Rejected");
            }
            if (req == null)
                return NotFound();
            req.Status = Models.DB.RequestStatus.Rejected;
            req.LastModifiedDate = DateTime.Now;
            _context.SaveChanges();

            return Ok();
        }

    }
}
