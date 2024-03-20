using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entityes.Auth;
using eUseControl.Domain.Entityes.GeneralResponce;
using eUseControl.Domain.Entityes.User;
using eUseControl.Domain.Entityes.User.DbModel;

namespace eUseControl.Businesslogic.Interface
{
    internal interface ISession
    {
        RResponceData UserLoginAction(ULoginData data);
        CoockieDataUs GenCoockie(User dataUser);
    }
}
