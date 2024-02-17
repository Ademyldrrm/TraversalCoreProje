﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> GetDestinationWithGuide(int id)
        {
            using (var context = new Context())
            {
                var values = context.Destinations.Where(x => x.DestinationId == id).Include(x=>x.Guide).ToList();
                return values;
            }
        }
    }
}
