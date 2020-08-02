using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritenceApp
{
    class Game
    {
        public int noOfplayers;
        public int Country;
        public string Coachname;
        private int now;
  
        public Game()
        {

        }
        public Game(int _noOfplayers, int _country,string _coachName)
        {
            noOfplayers = _noOfplayers;
            Country = _country;
            Coachname = _coachName;

        }
        static void WorldCup()
        { 
            DateTime dt = new DateTime(2007); 
            Console.WriteLine(dt);

        }

        public void Display()
        {
            Console.WriteLine(" details");
        }


    }

    class Cricket : Game
    {
     

        public Cricket()
        {

        }
        public Cricket(int _noofplayers, int _country, string _coachname) :base(_noofplayers, _country, _coachname)
        {
            noOfplayers = _noofplayers;
            Country = _country;
            Coachname = _coachname;
        }
        public override void ShowCricket()
        {
            Console.WriteLine("Cricket details");
        }
    }
     class FootBall : Game
    {
        
        public int noofPlayers;
        public string LeagueName;
        public int counTry;

        public FootBall()
        {

        }
       public  FootBall(int _noofPlayers, string _leagueName, int _counTry) : base(_noofPlayers,_counTry, _leagueName)
        {
            noofPlayers = _noofPlayers;
            LeagueName = _leagueName;
            counTry = _counTry;
        }
        static void ShowFootBall()
        {
            Console.WriteLine("football details");
        }

    }
   

    class Program 
    {
        static void Main()
        {
            Console.WriteLine("------------------CricketInformation----------------");
            Cricket India = new Cricket();
            Cricket Australia = new Cricket();
             India.



            Console.WriteLine("------------------FootBallInformation----------------");
            FootBall Spain = new FootBall();
            FootBall England = new FootBall();

            Game g = new Game();



        }
    }
}
