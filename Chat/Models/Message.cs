namespace Chat.Models
{
  public class Message
  {
    public int MessageId {get;set;}
    public int UserAId {get;set;}
    public int UserBId {get;set;}

    public virtual ApplicationUser UserA {get;set;}
    public virtual ApplicationUser UserB {get;set;}
  }
}