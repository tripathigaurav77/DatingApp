namespace API.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderUserName { get; set; }
        public AppUser Sender { get; set; }
        public int ReciepientId { get; set; }
        public string ReciepiendUsername { get; set; }
        public AppUser Reciepient { get; set; }
        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; } = DateTime.UtcNow;
        public bool SenderDeleted { get; set; }
        public bool ReciepientDeleted { get; set; }
    }
}