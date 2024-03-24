using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2
{
    internal class Doctor
    {
        public string Name {  get; set; }
        public int Id { get; set; }
        public string Speciality {  get; set; }

        public Doctor() 
        {  
        }
        public Doctor(string aname,int aid, string aspeciality) 
        {
            Name=aname;
            Id=aid;
            Speciality=aspeciality;
        }

        public void greeting(string aname)
        {
            Console.WriteLine("Good morning "+aname);
        }

    }
}
