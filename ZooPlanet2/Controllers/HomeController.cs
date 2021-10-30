using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooPlanet2.Models;
using Microsoft.EntityFrameworkCore;
using ZooPlanet2.Models.ViewModels;

namespace ZooPlanet2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Habitat")]
        public IActionResult Habitat()
        {
            animalesContext context = new animalesContext();
            //var habitat = context.Especies.Include(x => x.Habitat).OrderBy(x => x.Especie);
            var habitat = context.Especies.Select(x => new Especy { Habitat = x.Habitat}).Distinct();
            HabitatViewModel vm = new HabitatViewModel();
            vm.Habitats = habitat;
            vm.Especies = context.Especies.Include(x => x.IdClaseNavigation);
            return View(vm);
        }

        [Route("Clases")]
        public IActionResult Clases()
        {
            animalesContext conext = new animalesContext();
            var clases = conext.Clases.Include(x => x.Especies).OrderBy(x => x.Nombre);
                return View(clases);
        }

    }
}
