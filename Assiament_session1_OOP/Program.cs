namespace Assiament_session1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01 

            /*
             Consider the following code:

            public struct DeliveryAddress
                    {
                         public string City; public string Street;
                    }

            public class Customer
                 {
                      public string Name;
                 }

             a) What happens when a DeliveryAddress variable 
            is copied into another variable and the copy is modified?

            ans =>DeliveryAddress(value type) It will not affect the original object, and its values ​​will not change.

            b)What happens when a Customer variable is copied into another variable
            and one variable modifies the object

            ans =>Customer(reference type) The values ​​of both objects will change to the new value 
            because they are aliases for the same object on the heap.
             */

            #endregion

            #region Question02

            /*
             Consider the following struct:
             public struct Shipment
                    {
                        public string Description;
                        public double Weight; 
                        public decimal DeliveryFee;
                    }

            a) Identify at least three problems with this design from an encapsulation perspective.

            ans => First, direct access to data fields means there are no rules governing the data;
            any data assigned is accepted immediately.

            Second, maintenance is difficult because modifications can have ripple effects outside the class.

           Thirdly, this makes the debugging process more difficult,
            as bugs are present in more than one class.

            Fourthly, it lacks flexibility; if you extract a specific part of the project for use elsewhere,
            it will cause errors in other classes.
      ======================================================================================================
            b) How can private fields and public properties improve this design?

            ans => Making a field private prevents code in other classes from accessing it directly,
            effectively acting as a form of protection.

            Public properties safeguard the field's data by enforcing specific rules;
            data is stored in the field only if it meets these criteria.

            This approach also helps with debugging and maintenance—for instance,
            if I need to rename the field, I only have to make the change in one place,
            since the main code interacts with the properties rather than accessing the field directly.
             */

            #endregion

            #region part2_Practical

            // ============================================================================
            #endregion
            Console.WriteLine("Enter Shipment 1 Data ");
            Console.Write("Tracking Code :");
            string trackCode =  Console.ReadLine()!;

            Console.Write("Description :");
            string description = Console.ReadLine()!;

            Console.Write("Weight :");
            float.TryParse(Console.ReadLine()!,out float weight);

            Console.Write("Delivery Fee:");
            decimal.TryParse(Console.ReadLine()!, out decimal deliveryFee);

            Console.Write("City:");
            string city= Console.ReadLine()!;

            Console.Write("Street:");
            string Street = Console.ReadLine()!; 

            Console.Write("Building Number:");
            int.TryParse(Console.ReadLine()!, out int buildingNumber);

            DeliveryAddress DA = new DeliveryAddress();
            DA.city = city;
            DA.street = Street;
            DA.BuildingNumber = buildingNumber;
            Shipment ship = new Shipment(trackCode, description, weight, deliveryFee, DA);
            DeliveryCenter DC = new DeliveryCenter();          
            bool isAdded = DC.AddShipment(ship);
            if (isAdded)
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else Console.WriteLine("Shipment not added !");

            Console.WriteLine("--- All Shipments ---");
            Console.WriteLine(ship.PrintShipment());

            Console.Write("Enter a tracking code to search:");
            
            string code = Console.ReadLine()!; // handeld inside the Delivery Center
            if (!string.IsNullOrWhiteSpace(DC[code].TrackingCode))
            {
                Console.WriteLine(DC[code].PrintShipment());
            }
            else
            {
                Console.WriteLine("Shipment Not Found!");
            }



                Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress DV1 = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            Console.WriteLine(DV1.GetFullAddress());
            DeliveryAddress DV2 = DV1;
            DV2.street = "TypeMakramEbeid Street,";// value
            DV2.BuildingNumber = 10;                                       
            Console.WriteLine($"First Object {DV1.GetFullAddress()}\n Second Object{DV2.GetFullAddress()}");



        }
    }
}
