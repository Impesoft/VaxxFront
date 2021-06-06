using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroductionToAspMVC.Models;

namespace VaxxFront.Client.Models
{
    public class Vaccine : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string BodyPart { get; set; }
        public string Company { get; set; }
    }
}