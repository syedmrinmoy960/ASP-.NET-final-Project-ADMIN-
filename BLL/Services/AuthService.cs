using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
     public  class AuthService
    {
        public static TokenModel Auth(AdminModel us)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(us);
            var tok = DataAccessFactory.AuthDataAccess().Authenticate(dbuser);
            var toke = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Token, TokenModel>())).Map<TokenModel>(tok);
            return toke;
        }

      /*  public static object Auth(AdminModel admin)
        {
            throw new NotImplementedException();
        }*/

        public static bool CheckValidityToken(string tok)
        {
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(tok);
            return rs;
        }

        public static bool Logout(string token)
        {
            return DataAccessFactory.AuthDataAccess().Logout(token);
        }
    }
}
