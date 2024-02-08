using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }


        public void TDelete(Reservation t)
        {

            _reservationDal.Delete(t);
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> TGetListReservationByAccepted(int id)
        {
            return _reservationDal.GetListReservationByAccepted(id);
        }

        public List<Reservation> TGetListReservationByWithApproval(int id)
        {
            return _reservationDal.GetListReservationByWithApproval(id);


        }

        public List<Reservation> TGetListReservatonByPrevious(int id)
        {
            return _reservationDal.GetListReservatonByPrevious(id);
        }

        public void TInsert(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TUpdate(Reservation t)
        {
           _reservationDal.Update(t);
        }
    }
    }
