using BizLand.Models;
using System.Collections.Generic;

namespace BizLand.ViewModels
{
    public class HomeViewModel
    {
        public List<Features> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonials> Testimonials { get; set; }
    }
}
