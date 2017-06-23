namespace BaggageClaim
{
    /// <summary>
    ///     Provides information about arriving flights and the carousels where baggage from each flight is available for
    ///     pickup.
    /// </summary>
    public class BaggageInfo
    {
        public BaggageInfo(int flightNumber, string @from, int carousel)
        {
            FlightNumber = flightNumber;
            From = @from;
            Carousel = carousel;
        }

        public int FlightNumber { get; set; }
        public string From { get; set; }
        public int Carousel { get; set; }
    }
}