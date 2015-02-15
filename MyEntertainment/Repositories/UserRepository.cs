using MyEntertainment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyEntertainment.Repositories
{
    public class UserRepository : IUserRepository
    {
            private myEntertainmentDb db = null;

            public UserRepository()
            {
                this.db = new myEntertainmentDb();
            }

            public UserRepository(myEntertainmentDb db)
            {
                this.db = db;
            }

            public IEnumerable<UserModel> GetAll()
            {
                return db.UserTvShowModels.ToList();
            }

            public UserModel GetUserByID(string userID)
            {
                return db.UserTvShowModels.SingleOrDefault(user => user.userID == userID);
            }

            public void InsertUser(UserModel obj)
            {
                db.UserTvShowModels.Add(obj);
            }

            public void UpdateTVShows(string tvshow, UserModel obj)
            {
                obj.tvShows += "," + tvshow;
                db.Entry(obj).State = EntityState.Modified;
            }

            public void UpdateUser(UserModel obj)
            {
                db.Entry(obj).State = EntityState.Modified;
            }

            public void DeleteUser(string userid)
            {
                UserModel existing = db.UserTvShowModels.Find(userid);
                db.UserTvShowModels.Remove(existing);
            }

            public void Save()
            {
                db.SaveChanges();
            }

            private bool disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
    }
}