using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Routing;

namespace ViewControllerApp.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool Active { get; set; }

        public MenuItem(string text, string controller, string action)
        {
            Text = text;
            Controller = controller;
            Action = action;
        }
    }

    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }
    }

    public class MenuRepository
    {
        public Menu GetMenu(string controller, string action)
        {
            var items = new List<MenuItem>
            {
                new MenuItem("Главная", "Home", "Index"),
                new MenuItem("Контакты", "Home", "Contact"),
                new MenuItem("О проекте", "Home", "About")
            };
            items.FirstOrDefault(i => i.Controller == controller && i.Action == action).Active = true;
            return new Menu{MenuItems = items};
        }
    }
}
