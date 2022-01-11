namespace Chat.Models
{
  public class Message
  {
    public int MessageId {get;set;}
    public string SenderId {get;set;}
    public string RecieverId {get;set;}
    public string Text {get;set;}

  }
}