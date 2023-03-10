using System.ComponentModel.DataAnnotations;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }

    public DateTime ApptDate { get; set; }

    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}