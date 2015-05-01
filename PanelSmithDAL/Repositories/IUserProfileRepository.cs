using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;

namespace PanelSmithDAL.Repositories
{
    public interface IUserProfileRepository : IDisposable
    {
        IEnumerable<UserProfile> GetProfiles();
        UserProfile GetProfileByID(int profileId);
        void UpdateProfileAvatar(Avatar user);
    }
}
