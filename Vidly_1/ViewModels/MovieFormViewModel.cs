using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_1.Models;

namespace Vidly_1.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}