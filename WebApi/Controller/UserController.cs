using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.DBoperate;

namespace WebApi.Controller
{
    public class UserController : ApiController 
    {

        BaseService baseservice = new BaseService();


        public string   GetUser()
        {
            int count = 0;

            IList i = baseservice.loadEntityList("select u from WkTUser u ");


            var res = i.Count.ToString();


            return res;
            //var userList = new List<Users> { 
            //new Users{ Id=1,UName="张三",UAge=12,UAddress="海淀区"},
            //new Users{Id=2,UName="李四",UAge=23,UAddress="昌平区"},
            //new Users{Id=3,UName="王五",UAge=34,UAddress="朝阳区"}
            //};

            //var temp = (from u in userList
            //            select u).ToList();
            //return temp;
        }


    }
}