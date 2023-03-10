using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
        public int StylistId { get; set; }

        public string StylistName { get; set; }

        public string Speciality { get; set; }
        public Date ClientAppt { get; set; }

        public List<Client> Clients { get; set; }
    }
}