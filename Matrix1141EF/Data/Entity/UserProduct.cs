namespace Matrix1141EF.Data.Entity
{
    public class UserProduct : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
