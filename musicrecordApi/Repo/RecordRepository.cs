using musicrecordApi.Models;

namespace musicrecordApi.Repo
{
    public class RecordRepository
    {
        private List<Record> records = new();

        public RecordRepository()
        {
            records.Add(new Record { Artist = "Luthor", Title = "Helvede", Duration = 180, Downloads = 100, PublicationYear = 2004 });
            records.Add(new Record { Artist = "Martin", Title = "For evigt", Duration = 180, Downloads = 100, PublicationYear = 2004 });
            records.Add(new Record { Artist = "Luthor", Title = "For evigt", Duration = 180, Downloads = 100, PublicationYear = 2004 });
        }

        public List<Record>? GetAllRecords(string? artist=null,string? title=null)
        {
           List<Record> recordings = new List<Record>(records);
            if(artist != null)
            {
                recordings=recordings.Where(r=>r.Artist.Contains(artist)).ToList();
            }
            if(title != null)
            {
                recordings=recordings.Where(r => r.Title.Contains(title)).ToList();
            }
            return recordings;
        }

    }
}
