using System;
namespace CreativeGurus.Weather.Wunderground
{
	public class QueryOptions
	{
        public QueryOptions()
        {
            this.UsePWS = true;
            this.UseBestFct = true;
            this.Language = "EN";
        }

		/// <summary>
		/// City name to query
		/// </summary>
		/// <value>The city.</value>
		public string City { get; set; }

		/// <summary>
		/// US state name to query
		/// </summary>
		/// <value>The state.</value>
		public string State { get; set; }

		/// <summary>
		/// Country name to query
		/// </summary>
		/// <value>The country.</value>
		public string Country { get; set; }

		/// <summary>
		/// Latitude GPS to query
		/// </summary>
		/// <value>The latitude.</value>
		public string Latitude { get; set; }

		/// <summary>
		/// Longitude GPS to query
		/// </summary>
		/// <value>The longitude.</value>
		public string Longitude { get; set; }

		/// <summary>
		/// Language to return data in (Default = EN / US English)
		/// </summary>
		/// <value>The language.</value>
		public string Language { get; set; }

        /// <summary>
        /// Indicates if Personal Weather Station data should be returned.  Default = true
        /// </summary>
        /// <value>The use pws.</value>
        public bool UsePWS { get; set; }

		/// <summary>
		/// Use Weather Undergrond Best Forecast for forecast.  Default = true
		/// </summary>
		/// <value>The use best fct.</value>
		public bool UseBestFct { get; set; }

		/// <summary>
		/// Allows the detected IP address of the client to be overwritten with the provided IP address.
		/// </summary>
		/// <value>The ip address.</value>
		public string IpAddress { get; set; }

		/// <summary>
		/// Airport identifier code to query
		/// </summary>
		/// <value>The airport code.</value>
		public string AirportCode { get; set; }

		/// <summary>
		/// Weather Underground Link Id to query.
		/// </summary>
		/// <value>The link identifier.</value>
		public string LinkId { get; set; }

		/// <summary>
		/// US Zip code to query
		/// </summary>
		/// <value>The zip code.</value>
		public string ZipCode { get; set; }

		/// <summary>
		/// Personal Weather Station id to query
		/// </summary>
		/// <value>The PWSI.</value>
		public string PWSId { get; set; }
	}
}