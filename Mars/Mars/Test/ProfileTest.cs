using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mars.Test
{
    [TestFixture]
    public class ProfileTest : CommonDriver
    {
        [Test,Order(1)]
        public void CreateLanguage(string Language, string Level)
        {
            var profilePageObj = new Mars.Pages.ProfilePage();
            profilePageObj.CreateLanguage(Language, Level);
        }

        [Test,Order(2)]
        public void CreateSkill(string Skill, string Level)
        {
            var profilePageObj = new Mars.Pages.ProfilePage();
            profilePageObj.CreateSkill(Skill, Level);
        }
        [Test,Order(3)]
        public void CreateEducation(String Country, String University, String Title, String Degree, String GraduationYear)
        {
            var profilePageObj = new Mars.Pages.ProfilePage();
            profilePageObj.CreateEducation(Country, University, Title, Degree, GraduationYear);
        }
    }
}
