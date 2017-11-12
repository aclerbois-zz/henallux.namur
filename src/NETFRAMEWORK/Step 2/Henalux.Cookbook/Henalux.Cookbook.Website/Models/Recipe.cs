using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Henalux.Cookbook.Website.Models
{
    public class Recipe
    {
        public int Id { get; set; }

      public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual RecipeStyle 
    }
}
