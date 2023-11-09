namespace musicrecordApi.Models
{
    public class Record
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public int Duration { get; set; }

        public int PublicationYear { get; set; }

        public int Downloads { get; set; }
    }
}
