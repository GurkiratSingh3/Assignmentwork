using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C0731779_
{
    class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }
    class TravellingVillages
    {
        public void Solution()
        {
            Village Alst = new Village("Alst", false);
            Village Schvenig = new Village("Schvenig", false);
            Village Maeland = new Village("Maeland", false);
            Village Helmholtz = new Village("Helmholtz", false);
            Village Wessig = new Village("Wesig", false);
            Village Uster = new Village("Uster", true);
            Village Badden = new Village("Badden", false);

            Alst.nextVillage = Schvenig;
            Alst.prevVillage = null;
            Alst.DistanceTravelled = 14;

            Schvenig.nextVillage = Maeland;
            Schvenig.prevVillage = Alst;
            Schvenig.DistanceTravelled = 9;

            Schvenig.nextVillage = Helmholtz;
            Schvenig.prevVillage = Maeland;
            Schvenig.DistanceTravelled = 28;


        }
         
    }
    class Village
    {
        public Village Alst;
        Village Schvenig;
        Village Maeland;
        Village Helmholtz;
        Village Wessig;
        Village Uster;
        Village Badden;
        

        public Village(string VillageName, bool isHere)
        {
            isAstrildeHere = isHere;
            AstrildeLocation = VillageName;
        }
        public Village nextVillage;
        public Village prevVillage;
        public bool isAstrildeHere;
        public string AstrildeLocation;
        public int DistanceTravelled;

    }
}