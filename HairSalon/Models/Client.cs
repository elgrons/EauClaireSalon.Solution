namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }

    public Date ApptDate { get; set; }

    public int StylistId { get; set; }
    public Stylist Styist { get; set; }
  }
}