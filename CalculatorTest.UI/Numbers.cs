using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.UI
{
    public class Numbers
    {
        [Required]
        public int value1 { get; set; }
        [Required]
        public int value2 { get; set; }
    }
}
