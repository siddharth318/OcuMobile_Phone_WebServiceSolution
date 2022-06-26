using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OcuMobile_Phone_WebService.Model;

namespace OcuMobile_Phone_WebService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MobileController : Controller
    {
        public List<Mobile> Get_Mobiles()
        {
            List<Mobile> mob = new List<Mobile>();
            mob.Add(new Mobile() { MobileID = 1, MobileName = "OnePlus", Cost = 20000f });
            mob.Add(new Mobile() { MobileID = 2, MobileName = "IPhone 13", Cost = 100000f });
            mob.Add(new Mobile() { MobileID = 3, MobileName = "Samsung", Cost = 80000f });
            return mob;

        }
    }
}
