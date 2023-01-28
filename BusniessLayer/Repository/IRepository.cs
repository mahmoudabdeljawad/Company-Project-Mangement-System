using BusniessLayer.DTO;
using BusniessLayer.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public interface IRepository
    {
        //Admin//control member teamleader project manger dashboard
     
     
        ////projectMangerPage
        
        //TeamLeaderProject
        public string CurrentLogedInId();

        //dutyyyy

        //work
        List<State> AllState();


    }
}
