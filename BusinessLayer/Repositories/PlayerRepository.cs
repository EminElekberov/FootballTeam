﻿using BusinessLayer.Repositories.Model;
using DataAccessLayer.Abstract;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IPlayerDal _playerDal;

        public PlayerRepository(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public Player GetById(Guid id)
        {
            return _playerDal.GetById(id);
        }

        public List<Player> GetList()
        {
            return _playerDal.GetAllList();
        }

        public void TAdd(Player t)
        {
            _playerDal.Insert(t);
        }

        public void TDelete(Player t)
        {
            _playerDal.Delete(t);
        }

        public void TUpdate(Player t)
        {
            _playerDal.Update(t);
        }
    }
}
