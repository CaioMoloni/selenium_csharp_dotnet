using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SauceDemoAutomation.Utilities.UserEnum;

namespace SauceDemoAutomation.Utilities
{
    public static class UserCredentials
    {
        public static (string username, string password) GetCredentials(User user)
        {
            string username = "";
            string password = "";

            switch (user)
            {
                case User.StandardUser:
                    username = "standard_user";
                    password = "secret_sauce";
                    break;
                case User.LockedOutUser:
                    username = "locked_out_user";
                    password = "secret_sauce";
                    break;
                case User.ProblemUser:
                    username = "problem_user";
                    password = "secret_sauce";
                    break;
                case User.PerformanceGlitchUser:
                    username = "performance_glitch_user";
                    password = "secret_sauce";
                    break;
                default:
                    break;
            }

            return (username, password);
        }
    }
}
