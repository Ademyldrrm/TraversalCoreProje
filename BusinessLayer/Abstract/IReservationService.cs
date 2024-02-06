using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
       
       List<Reservation> TGetListReservationByWithApproval(int id);
       List<Reservation> TGetListReservationByAccepted(int id);
       List<Reservation> TGetListReservatonByPrevious(int id);
    }
}
