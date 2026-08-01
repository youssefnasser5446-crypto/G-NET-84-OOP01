using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiament_session1_OOP
{
    internal struct Shipment
    {
        private string? trackingCode;
        private string? description;
        private float weight;
        private decimal deliveryFee;
        public Shipment(string? _trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress(); // default value 
        }
        public Shipment(string? _trackingCode,string _description,float _weight,decimal _deliveryFee, DeliveryAddress _destination)
        {
            if (!string.IsNullOrWhiteSpace(_trackingCode))
            {
                TrackingCode = _trackingCode;
            }
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
            Destination = _destination; // default value 
        }
        public DeliveryAddress Destination { set; get; }

        public string TrackingCode
        {
            private set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
           
            get
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    return trackingCode;
                else
                    return "";
            }
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
            get
            {
                if (description is not null)
                    return description;
                else
                    return "no description";
            }
        }
        public float Weight {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

            get
            {             
                    return weight;   
            }
        }

        public decimal DeliveryFee
        {
            private set {
                if (value > 0)
                    deliveryFee = value;
            }
            get
            {
                return deliveryFee;
            }
        }
        public float EstimatedCost
        {
            get
            {
                return (float)DeliveryFee + (weight * 5);
            }
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }
        public string PrintShipment()
        {
            return $"Full Address : {Destination.GetFullAddress()}\n trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee} ";
        }
    }
}
