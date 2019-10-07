namespace YourBabyDiary.DAL.Entities
{
    public class Event: BaseEntity
    {
        public virtual Baby Baby { get; set; }
        public int BabyId { get; set; }
    }
}
