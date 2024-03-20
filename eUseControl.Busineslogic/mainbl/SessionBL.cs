using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BussinesLogic.Core.Levels;
using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entityes.Auth;
using eUseControl.Domain.Entityes.GeneralResponce;
using eUseControl.Domain.Entityes.User;
using eUseControl.Domain.Entityes.User.DbModel;

namespace eUseControl.BussinesLogic.MainBL
{
    public class SessionBL : UserAPI, ISession
    {
        public RResponceData UserLoginAction(ULoginData data)
        {
            return ULASessionCheck(data);
        }

        public UCoockieData GenCoockieAlgo(User dataUser)
        {
            return UserCoockieGenerationAlg(dataUser);
        }
    }
}
