//using System.Diagnostics;
//using Business.Services.Obs.Abstract;
//using Entities.ObsEntities;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace ObsWebUI.MyMiddlewares
{
    public class Mid1
    {
        public static void MyMiddleware1(HttpContext context)
        {

            Debug.WriteLine(context.Request.HttpContext.User.Identity.IsAuthenticated); //security
            Debug.WriteLine(context.Request.Host.Value);//ip address 
            Debug.WriteLine(context.Request.Path);//ip address 

           // return Task.CompletedTask;
        }
    }
}
