using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VaxxFront.Client.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace VaxxFront.Client.Shared
{
    public partial class VaccinList
    {
        private async Task UpdateList()
        {
            Console.WriteLine("Update List Requested");
            Vaccines = await Http.GetFromJsonAsync<List<Vaccine>>("https://vaxxapi.azurewebsites.net/api/Vaccine/" + ((VaccineBodyPart != "All") ? "ForBodyPart/" + _vaccinBodyPart : ""));
            StateHasChanged();
            //  Vaccines = Vaccines.Where(x => x.BodyPart == VaccineBodyPart).ToList();
        }

        protected override void OnParametersSet()
        {
            if (_VaccinBodyPart != VaccineBodyPart)
            {
                _VaccinBodyPart = VaccineBodyPart;
            }
        }
    }
}