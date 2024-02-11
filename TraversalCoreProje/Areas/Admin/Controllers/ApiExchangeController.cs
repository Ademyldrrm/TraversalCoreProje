using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using TraversalCoreProje.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {

           List<BookingExhangeViewModel> bookingExhangeViewModels = new List<BookingExhangeViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "8c85645887msh3a89864ff8bb639p1bc7d3jsn39178563452f" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
             var values=JsonConvert.DeserializeObject<BookingExhangeViewModel>(body);
               return View(values.exchange_rates);
            }
        }
    }
}
