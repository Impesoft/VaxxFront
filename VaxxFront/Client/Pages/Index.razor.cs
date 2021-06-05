using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace VaxxFront.Client.Pages
{
    public partial class Index : ComponentBase
    {
        public string BodyPart { get; set; } = "All";

        private void SelectBodypart(string bodyPart)
        {
            BodyPart = BodyPart == bodyPart ? "All" : bodyPart;
            Console.WriteLine(BodyPart+" clicked");

        }
    }
}