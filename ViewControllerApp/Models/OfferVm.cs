using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewControllerApp.Models
{
    public class OfferVm
    {
        public IEnumerable<CategoryType> SelectedItems { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }

    public class Category
    {
        public CategoryType Id { get; set; }
        public string Text { get; set; }
    }

    public enum CategoryType
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth  
    }
}
