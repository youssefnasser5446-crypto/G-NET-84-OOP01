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


        }
    }
}
