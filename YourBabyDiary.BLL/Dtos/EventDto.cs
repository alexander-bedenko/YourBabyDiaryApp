namespace YourBabyDiary.BLL.Dtos
{
    public class EventDto: BaseDto
    {
        public virtual BabyDto Baby { get; set; }
        public int BabyId { get; set; }
    }
}
