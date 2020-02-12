namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public string name;
        public double latitude;
        public double longitude;

        public TacoBell(string name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        
        string ITrackable.Name
        {
            get; set;
        }
        Point ITrackable.Location
        {
            get;set;
        }
    }
}