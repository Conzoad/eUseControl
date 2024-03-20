using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entityes.Auth;
using eUseControl.Domain.Entityes.GeneralResponce;
using eUseControl.Domain.Entityes.User;
using eUseControl.Domain.Entityes.User.DbModel;

namespace eUseControl.Busineslogic.IAdministration
{
    internal interface ISession
    {
        RResponceData UserLoginAction(ULoginData data);
        UCoockieData GenCoockieAlgo(User dataUser);
    }
}
