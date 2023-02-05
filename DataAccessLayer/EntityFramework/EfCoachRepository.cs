using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfCoachRepository: GenericRepository<Coach>, ICoachesDal
    {
    }
}
