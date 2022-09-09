using AgeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ageapp.Service
{
    public  class StatusService : IStatusService
    {
        public string ShowStatus(CollectorModel model)
        {   
            int age = DateTime.Now.Year - model.DateofBirth.Year;
            if (age > 18)
            {
               return "He is an Adult";
            }
         
            else if(age >15 && age < 18) 
            {
                return "He is Reaching Puberty";
            }
            else
            {
                return "He is a Kid";
            }
        
         }


     
    }
}
