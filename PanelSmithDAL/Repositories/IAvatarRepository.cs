using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;

namespace PanelSmithDAL.Repositories
{
    public interface IAvatarRepository : IDisposable
    {
        Avatar GetAvatarByUserID(int userId);
        void InsertAvatar(Avatar avatar);
    }
}
