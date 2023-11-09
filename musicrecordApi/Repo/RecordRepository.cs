using musicrecordApi.Models;

namespace musicrecordApi.Repo
{
    public class RecordRepository
    {
        private List<Record> records = new();

        public RecordRepository()
        {
            records.Add(new Record { Artist = "Luthor", Title = "For evigt", Duration = 180, Downloads = 100, PublicationYear = 2004 });
            
        }
    }
}
