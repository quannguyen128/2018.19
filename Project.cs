using System;

namespace _2018._19
{
    public class Project
    {
        //PK 
        //Name
        //Leader = FK team lead 
        //Required Hours
        //client - fk
        //deadline - DateTime 
        public int projectID {get; set;}
        public string projName {get; set;}
        public string projLeader {get; set;}
        public int hours {get; set;}
        public int clientID {get; set;}
        public DateTime deadline {get; set;}
         
    }
    
}