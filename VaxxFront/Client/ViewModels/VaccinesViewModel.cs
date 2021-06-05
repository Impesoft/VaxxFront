using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaxxFront.Client.Models;

namespace VaxxFront.Client.ViewModels
{
    public class VaccinesViewModel
    {
        public ICollection<Vaccine> Vaccines { get; set; }
    }
}