using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewControllerApp.Models;

namespace ViewControllerApp.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private MenuRepository _repository;
        private const string ViewName = "Menu";

        public MenuViewComponent(MenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentController = RouteData.Values["controller"].ToString();
            var currentAction = RouteData.Values["action"].ToString();

            var menuItems = await Task.FromResult(
                _repository.GetMenu(
                    currentController, 
                    currentAction
                )
            );
            return View(ViewName, menuItems);
        }
    }
}
