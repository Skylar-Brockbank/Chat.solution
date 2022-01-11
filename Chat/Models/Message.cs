namespace Chat.Models
{
  public class Message
  {
    public int MessageId {get;set;}
    public int SenderId {get;set;}
    public int RecieverId {get;set;}

    public virtual ApplicationUser Sender {get;set;}
    public virtual ApplicationUser Reciever {get;set;}
  }
}