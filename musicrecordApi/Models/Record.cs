namespace musicrecordApi.Models
{
    public class Record
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public int Duration { get; set; }

        public int PublicationYear { get; set; }

        public int Downloads { get; set; }

        public void ValidateTitles()
        {
            if(Title==null)
            {
                throw new ArgumentNullException();
            }
            if(Title.Length==0) 
            { 
            
            }

        }

        public void ArtistValidate()
        {
            if(Artist==null)
            {
                throw new ArgumentNullException();
            }
            if(Artist.Length==0)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
