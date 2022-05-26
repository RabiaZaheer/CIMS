using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CIMS.BO;
using CIMS.DL;


namespace CIMS.BL
{
    public class UserBL
    {
        #region Constructor
        public UserBL()
        {
        }
        #endregion

        #region Method

        #region DoLoginValidation Method
        public static Boolean DoLoginValidation(UserBO objUserBO1)
        {

            Boolean status;

            UserBO objUserBOReturnVal = new UserBO();
            objUserBOReturnVal = UserDL.FetchLoginDetails(objUserBO1);

            string sUname = objUserBO1.Username;
            string sPwd = objUserBO1.Password;

            sUname = sUname.Trim().ToLower();
            sPwd = sPwd.Trim().ToLower();

            string stUname = objUserBOReturnVal.Username;
            string stPwd = objUserBOReturnVal.Password;

            stUname = stUname.Trim().ToLower();
            stPwd = stPwd.Trim().ToLower();

            if ((sUname.Equals(stUname)) && (sPwd.Equals(stPwd)))
                status = true;
            else
                status = false;
            return status;
        }

        #endregion

        #region RegisterNewUser Method
        public static int RegisterNewUser(UserBO objUserBO)
        {
            int status;
            status = UserDL.StoreNewUserDetails(objUserBO);

            return status;
        }
        #endregion

        #endregion

    }
}
