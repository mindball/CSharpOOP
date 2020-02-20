using Example3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Director encapsulate the process to construct a bicycle
// It sets required attribute and start building process using a concrete builder.
// It contains the flow or algorithm to be followed to create a bicycle
// i.e. assembling bicycle by getting parts from a builder
// and coordinating with inventory/departments and notifying stockholders

//if client want to get a road bicycle then he just need to modify arguments of
//Construct method of the BicycleBuildDirector as given below:
//Create class RoadBicycleBuilder : IBicycleBuilder {...}
//Bicycle bicycle = buildDirector.Construct(new RoadBicycleBuilder(), "Blue", 24);
//In this way, by using different builders with same director, client is able to create different types of bicycles.
namespace Example3.Models
{
    public class BicycleBuildDirector
    {
        SellDepartment sellDepartment = new SellDepartment();
        public Bicycle Construct(IBicycleBuilder builder, string colour, int height)
        {
            // Start Process and Notify user
            Console.WriteLine("We have sarted process for Bicycle manufacturing");
            // Follow the process and set attributes given
            builder.SetFrame();
            builder.SetGears();
            builder.SetColour(colour);
            builder.SetHeight(height);
            builder.PutTires();
            builder.PutAccessaries();

            Bicycle bicycle = builder.GetBicycle();
            // Coordinate with other departments/inventories
            sellDepartment.GenerateInvoice(bicycle);
            // End Process and Notify user
            Console.WriteLine("{0} is ready for your disposal.\n ** Happy Riding ! **", bicycle.GetType());
            return bicycle;
        }
    }
}
