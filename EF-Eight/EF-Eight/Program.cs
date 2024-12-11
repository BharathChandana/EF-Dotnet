using EF_Eight.DAL;
using EF_Eight.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Eight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TouristPlaceContext dal = new TouristPlaceContext();
            TouristPlace tp1 = new TouristPlace();
            tp1.TouristPlaceId = 1;
            tp1.TouristPlaceName = "Charminar";
            tp1.Description = "The Charminar is a monument located in Hyderabad, " +
                "Telangana, India. Constructed in 1591, the landmark is a symbol" +
                " of Hyderabad and officially incorporated in the emblem of Telangana.";
            tp1.Location = DbGeography.FromText("POINT(17.3616 78.4747)");
            dal.touristPlaces.Add(tp1);

            TouristPlace tp2 = new TouristPlace();
            tp2.TouristPlaceId = 2;
            tp2.TouristPlaceName = "Golconda Fort";
            tp2.Description = "Golconda is a fortified citadel and ruined city" +
                " located on the western outskirts of Hyderabad, Telangana, India. " +
                "The fort was originally built by Kakatiya ruler Pratāparudra in the " +
                "11th century out of mud walls";
            tp2.Location = DbGeography.FromText("POINT(17.3842 78.4019)");
            dal.touristPlaces.Add(tp2);

            TouristPlace tp3 = new TouristPlace();
            tp3.TouristPlaceId = 3;
            tp3.TouristPlaceName = "Salar Jung Museum";
            tp3.Description = "The Salar Jung Museum is an art museum" +
                " located at Dar-ul-Shifa, on the southern bank of the " +
                "Musi River in the city of Hyderabad, Telangana, India. " +
                "It is one of the notable National Museums of India";
            tp3.Location = DbGeography.FromText("POINT(17.3716 78.4802)");
            dal.touristPlaces.Add(tp3);

            TouristPlace tp4 = new TouristPlace();
            tp4.TouristPlaceId = 4;
            tp4.TouristPlaceName = "Tank Bund";
            tp4.Description = "The Tank Bund Road is a road in Secunderabad, Hyderabad," +
                " India. The Tank Bund dams Hussain Sagar lake on the eastern side and connects " +
                "the twin cities of Hyderabad and Secunderabad." +
                " It has become an attraction with 33 statues of famous people from the region";
            tp4.Location = DbGeography.FromText("POINT(17.4239 78.4738)");
            dal.touristPlaces.Add(tp4);

            TouristPlace tp5 = new TouristPlace();
            tp5.TouristPlaceId = 5;
            tp5.TouristPlaceName = "Birla Mandir";
            tp5.Description = "Birla Mandir is a Hindu temple built on a 280 feet high hillock" +
                " called Naubath Pahad on a 13 acres plot in Hyderabad, Telangana, India." +
                " The construction took ten years and was opened in 1976 by " +
                "Swami Ranganathananda of Ramakrishna Mission";
            tp5.Location = DbGeography.FromText("POINT(17.4062 78.4691)");
            dal.touristPlaces.Add(tp5);

            dal.SaveChanges();
            var CustomerLocation = DbGeography.FromText("POINT(17.4357 78.4446)");
            var nearestPlaces = (from x in dal.touristPlaces
                                 orderby x.Location.Distance(CustomerLocation)
                                 select x
                               );
            Console.WriteLine("Nearest places to the Customer location :");
            foreach (var p in nearestPlaces)
            {
                Console.WriteLine( p.TouristPlaceName + " " + "Distance :" +
                    p.Location.Distance(CustomerLocation));
            }
            Console.ReadKey();
        }
    }
}
