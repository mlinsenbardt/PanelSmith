using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace PanelSmithDAL.Models
{
    public class UserInitializer : System.Data.Entity.CreateDatabaseIfNotExists<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var users = new List<UserProfile>
            {
            new UserProfile{UserName="mlinsenbardt"},
            new UserProfile{UserName="Carson"},
            new UserProfile{UserName="Meredith"},
            new UserProfile{UserName="Arturo"},
            new UserProfile{UserName="Gytis"},
            new UserProfile{UserName="Yan"},
            new UserProfile{UserName="Peggy"},
            new UserProfile{UserName="Laura"},
            new UserProfile{UserName="Nino"}
            };
            users.ForEach(s => context.UserProfiles.Add(s));
            context.SaveChanges();

            var logins = new List<LoginModel>
            {
            new LoginModel{UserName="mlinsenbardt",Password="Ih2b1nD&1nD"},
            new LoginModel{UserName="Carson",Password="123456"},
            new LoginModel{UserName="Meredith",Password="234567"},
            new LoginModel{UserName="Arturo",Password="345678"},
            new LoginModel{UserName="Gytis",Password="456789"},
            new LoginModel{UserName="Yan",Password="567890"},
            new LoginModel{UserName="Peggy",Password="213445"},
            new LoginModel{UserName="Laura",Password="8745983"},
            new LoginModel{UserName="Nino",Password="892374"}
            };
            logins.ForEach(s => context.LoginModels.Add(s));
            context.SaveChanges();

            var projects = new List<Project>
            {
            new Project{UserID=1,ProjectName="Horses"},
            new Project{UserID=2,ProjectName="Comic2"},
            new Project{UserID=3,ProjectName="Comic3"},
            new Project{UserID=4,ProjectName="Comic4"},
            new Project{UserID=5,ProjectName="Comic5"},
            new Project{UserID=6,ProjectName="Comic6"},
            new Project{UserID=7,ProjectName="Comic7"}
            };
            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();

            var pages = new List<Page>
            {
            new Page{ProjectID=1},
            new Page{ProjectID=1},
            new Page{ProjectID=1},
            new Page{ProjectID=2},
            new Page{ProjectID=2},
            new Page{ProjectID=2},
            new Page{ProjectID=3},
            new Page{ProjectID=4},
            new Page{ProjectID=4},
            new Page{ProjectID=5},
            new Page{ProjectID=6},
            new Page{ProjectID=7},
            };
            pages.ForEach(s => context.Pages.Add(s));
            context.SaveChanges();
        }
    }
}
