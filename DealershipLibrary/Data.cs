using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    class Data
    {
        //Propreties
        public List<Sedan> Sedans { get; set; }
        public List<Truck> Trucks { get; set; }
        public List<Coupe> Coupes { get; set; }


        //Constructors
        public Data()
        {
            Sedans = new List<Sedan>
            {
                new Sedan("Sedan", 5000, true, "Subaru", "blue", "Automatic", false, false),
                new Sedan("Sedan", 50000, false, "Subaru", "white", "Automatic", true, false),
                new Sedan("Sedan", 5000, true, "Subaru", "blue", "Automatic", false, false),
                new Sedan("Sedan", 50000, false, "Subaru", "white", "Automatic", true, false),
                new Sedan("Sedan", 42000, true, "Acura", "white", "Manual", true, true),
                new Sedan("Sedan", 52000, false, "Acura", "grey", "Automatic", false, false),
                new Sedan("Sedan", 1000, false, "toyota", "white", "Automatic", false, false),
                new Sedan("Sedan", 2000, true, "toyota", "blue", "Manual", true, true),
                new Sedan("Sedan", 33000, true, "Acura", "grey", "Automatic", true, true),
                new Sedan("Sedan", 12000, false, "Subaru", "white", "Manual", false, false)
            };

            Trucks = new List<Truck>
            {
                new Truck("Truck", 56000, true, "Ram", "white", "Automatic", 5.5, "Crew", true, false),
                new Truck("Truck", 55000, false, "Ford", "grey", "Automatic", 6, "Crew", false, false),
                new Truck("Truck", 12000, true, "Chevy", "pink", "Manual", 5.5, "Crew", true, false),
                new Truck("Truck", 15000, true, "Ram", "white", "Automatic", 5.5, "Crew", true, false),
                new Truck("Truck", 1000, false, "Ford", "blue", "Automatic", 6, "Crew", false, false),
                new Truck("Truck", 3000, true, "Chevy", "grey", "Manual", 5.5, "Crew", true, false),
                new Truck("Truck", 18000, true, "Ram", "blue", "Automatic", 5.5, "Crew", true, true),
                new Truck("Truck", 63000, false, "Ford", "Purple", "Automatic", 6, "Crew", false, false),
                new Truck("Truck", 7000, true, "Chevy", "pink", "Manual", 5.5, "Crew", true, true),
                new Truck("Truck", 22000, true, "Ram", "white", "Automatic", 5.5, "Crew", true, false)
            };

            Coupes = new List<Coupe>
            {
                new Coupe("Coupe", 50000, false, "Acura", "black", "Manual", false),
                new Coupe("Coupe", 67000, false, "toyota", "grey", "Automatic", false),
                new Coupe("Coupe", 5000, true, "Subaru", "white", "Manual", false),
                new Coupe("Coupe", 1000, true, "Acura", "black", "Manual", true),
                new Coupe("Coupe", 4000, false, "toyota", "grey", "Automatic", true),
                new Coupe("Coupe", 14000, true, "Subaru", "blue", "Manual", false),
                new Coupe("Coupe", 25000, true, "Acura", "white", "Manual", false),
                new Coupe("Coupe", 18000, false, "toyota", "white", "Automatic", false),
                new Coupe("Coupe", 22000, true, "Subaru", "blue", "Manual", true),
                new Coupe("Coupe", 2000, false, "Acura", "black", "Manual", false)
            };

        }



    }
}
