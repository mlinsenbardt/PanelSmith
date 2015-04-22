﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;

namespace PanelSmithDAL.Repositories
{
    public class UserProfileRepository : IUserProfileRepository, IDisposable
    {
        private UsersContext context;

        public UserProfileRepository(UsersContext context)
        {
            this.context = context;
        }

        public IEnumerable<UserProfile> GetProfiles()
        {
            return context.UserProfiles.ToList();
        }

        public UserProfile GetProfileByID(int id)
        {
            return context.UserProfiles.Find(id);
        }

        public void UpdateProfileAvatar(UserProfile user)
        {
            context.UserProfiles.Add(user);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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