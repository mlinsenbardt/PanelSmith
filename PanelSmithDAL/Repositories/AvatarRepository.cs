using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;
using PanelSmithDAL.Repositories;

namespace PanelSmithDAL.Repositories
{
    public class AvatarRepository : IAvatarRepository, IDisposable
    {

            private UsersContext context;

            public AvatarRepository(UsersContext context)
            {
                this.context = context;
            }

            public Avatar GetAvatarByUserID(int userId)
            {
                return context.Avatars.Where(a => a.UserID == userId).First();
            }

            public void InsertAvatar(Avatar avatar)
            {
                context.Avatars.Add(avatar);
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
