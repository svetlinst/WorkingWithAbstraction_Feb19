using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        public List<string> Beds { get; set; } = new List<string>();

        public void AddPatient(string patientName)
        {
            if (HasVacantBeds())
            {
                this.Beds.Add(patientName);
            }
        }

        public bool HasVacantBeds()
        {
            var occupiedBeds = this.Beds.Count;
            if (occupiedBeds<3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
