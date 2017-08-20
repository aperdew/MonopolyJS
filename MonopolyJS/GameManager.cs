using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonopolyJS.Models;

namespace MonopolyJS
{
    public class GameManager
    {
        public GameManager()
        {

        }

        public List<PropertyModel> getListOfProperties()
        {
            List<PropertyModel> listOfProperties = new List<PropertyModel>
            {
                new PropertyModel() { Name = " Mediterranean Ave", Value = 60, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 2, Rent = 2, Color = "purple"},
                new PropertyModel() { Name = " Baltic Ave", Value = 60, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 4, Rent = 4, Color = "purple"},
                new PropertyModel() { Name = " Oriental Ave", Value = 100, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 7, Rent = 6, Color = "light blue"},
                new PropertyModel() { Name = " Vermont Ave", Value = 100, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 9, Rent = 6, Color = "light blue"},
                new PropertyModel() { Name = " Connecticut Ave", Value = 120, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 10, Rent = 8, Color = "light blue"},
                new PropertyModel() { Name = " St. Charles Place", Value = 140, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 12, Rent = 10, Color = "violet"},
                new PropertyModel() { Name = " States Ave", Value = 140, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 14, Rent = 10, Color = "violet"},
                new PropertyModel() { Name = " Virginia Ave", Value = 160, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 15, Rent = 12, Color = "violet"},
                new PropertyModel() { Name = " St. James Place", Value = 180, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 17, Rent = 14, Color = "orange"},
                new PropertyModel() { Name = " Tennessee Ave", Value = 180, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 19, Rent = 14, Color = "orange"},
                new PropertyModel() { Name = " New York Ave", Value = 200, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 20, Rent = 16, Color = "orange"},
                new PropertyModel() { Name = " Kentucky Ave", Value = 220, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 22, Rent = 18, Color = "red"},
                new PropertyModel() { Name = " Indiana Ave", Value = 220, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 24, Rent = 18, Color = "red"},
                new PropertyModel() { Name = " Illinois Ave", Value = 240, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 25, Rent = 20, Color = "red"},
                new PropertyModel() { Name = " Atlantic Ave", Value = 260, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 27, Rent = 22, Color = "yellow"},
                new PropertyModel() { Name = " Ventnor Ave", Value = 260, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 28, Rent = 22, Color = "yellow"},
                new PropertyModel() { Name = "  Marvin Gardens", Value = 280, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 30, Rent = 24, Color = "yellow"},
                new PropertyModel() { Name = " Pacific Ave", Value = 300, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 32, Rent = 26, Color = "green"},
                new PropertyModel() { Name = " North Carolina Ave", Value = 300, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 33, Rent = 26, Color = "green"},
                new PropertyModel() { Name = " Pennsylvania Ave", Value = 320, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 35, Rent = 28, Color = "green"},
                new PropertyModel() { Name = " Park Place", Value = 350, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 38, Rent = 35, Color = "dark blue"},
                new PropertyModel() { Name = " Boardwalk", Value = 400, NumOfHouses = 0, NumOfHotels = 0,
                                      CostPerHouse = 0, CostPerHotel = 0, Owner = null, Position = 40, Rent = 50, Color = "dark blue"},
                //to do: add utilities and railroads

            };

            return listOfProperties;
        }
    }
}