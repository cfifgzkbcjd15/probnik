using probnik.Data;
using System.Collections.Generic;

namespace probnik.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Posts> Posts{ get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}