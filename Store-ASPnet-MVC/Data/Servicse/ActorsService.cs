using Microsoft.EntityFrameworkCore;
using Store_ASPnet_MVC.Data.Base;
using Store_ASPnet_MVC.Models;

namespace Store_ASPnet_MVC.Data.Servicse
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorsService(AppDBContext context): base(context) { }
    }
}
