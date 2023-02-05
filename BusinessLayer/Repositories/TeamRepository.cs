using BusinessLayer.Repositories.Model;
using DataAccessLayer.Abstract;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ITeamDal _teamDal;

        public TeamRepository(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public Team GetById(Guid id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetList()
        {
            return _teamDal.GetAllList();
        }

        public void TAdd(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
