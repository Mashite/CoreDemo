﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _NotificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _NotificationDal = notificationDal;
        }

        public void Add(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _NotificationDal.GetListAll();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
