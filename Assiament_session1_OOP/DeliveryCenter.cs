using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assiament_session1_OOP
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipment;
        private int count;
        public DeliveryCenter()
        {
            shipment = new Shipment[10];
        }
        public Shipment this[int index]
        {
            get
            {
                if ( index >= 0 && index  < count)
                {
                    return shipment[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    shipment[index] = value;
                }
            }
        }

        public Shipment this[string index]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (index is not null && index.Equals(shipment[i].TrackingCode))
                    {
                        return shipment[i];

                    }
                }
                return default;
            }
        }
        public bool AddShipment(Shipment ship )
        {
           
                if (count < shipment.Length)
                {
                    shipment[count] = ship;
                    count++;
                    return true;       
                }
            return false;
        }
          
        }

  }

