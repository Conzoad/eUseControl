using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Busineslogic.core.Level;
using eUseControl.Businesslogic.Interface;
using eUseControl.Domain.Entityes.Auth;
using eUseControl.Domain.Entityes.GeneralResponce;
using eUseControl.Domain.Entityes.User;
using eUseControl.Domain.Entityes.User.DbModel;

namespace eUseControl.Businesslogic.mainbl
{
    public class SessionBL : UserAPI, ISession
    {
        public RResponceData UserLoginAction(ULoginData data)
        {
            return ULASessionCheck(data);
        }

        public CoockieDataUs GenCoockie(User dataUser)
        {
            return UserCoockieGenerationAlg(dataUser);
        }
    }
}
