using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIMS.BO
{
    public class UserBO
    {
        #region Constructor

        public UserBO()
        {

        }

        #endregion

        #region Variable Declaration

        private string sUsername = string.Empty;
        private string sPassword = string.Empty;

        #endregion

        #region Proerties

        public string Username
        {
            get
            {
                return sUsername;
            }
            set
            {
                sUsername = value;
            }
        }

        public string Password
        {
            get
            {
                return sPassword;
            }
            set
            {
                sPassword = value;
            }

        }

        #endregion
    }
}
