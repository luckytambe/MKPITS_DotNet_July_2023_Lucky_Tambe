using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coverload_method_with_0_To_4_parameters
{
    class Player
    {
        int srno;
        string name;
        string team;
        int run;

        public void getdata()
        {
            srno = 1;
            name = "Virat";
            team = "India";
            run = 50;
        }
        public void getdata( int srno )
        {
            this.srno= srno;
        }

        public void getdata( int srno , string name )
        {
            this.srno= srno;
            this.name = name;
        }
        public void getdata ( int srno , string name , string team  )
        {
            this.srno= srno;
            this.name = name;
            this.team = team;
        }
        public void getdata( int srno,string name , string team , int run )
        {
            this.srno= srno;
            this.name = name;
            this.team = team;
            this.run = run;
        }

        public void displaydeta()
        {
            Console.WriteLine("Srno = " + srno);
            Console.WriteLine("Name = "+ name);
            Console.WriteLine("Team = " + team);
            Console.WriteLine("Run = " + run);
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player play  =  new Player();
            play.getdata();
            play.displaydeta();

            Player play1= new Player();
            play1.getdata(2,"jadeja");
            play1.displaydeta();

            Player play2= new Player();
            play2.getdata(3, "bumra","india");
            play2.displaydeta();

            Player play3 = new Player();
            play3.getdata(4,"Dhoni","India",80);
            play3.displaydeta();

            Console.ReadKey();
        }
    }
}
