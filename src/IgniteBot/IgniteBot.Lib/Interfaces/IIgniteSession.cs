using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteBot.Lib.Interfaces
{
    /// <summary>
    /// Interface detailing a session at ignite.
    /// </summary>
    interface IIgniteSession
    {

        #region members

        /// <summary>
        /// The internal id of the session.
        /// </summary>
        int id { get; set; }
        /// <summary>
        /// the name of the session.
        /// </summary>
        string name { get; set; }
        /// <summary>
        /// The description of the session. Multi line can be very long.
        /// </summary>
        string description { get; set; }
        /// <summary>
        /// The objective of the session. Multi line can be very long.
        /// </summary>
        string objective { get; set; }
        /// <summary>
        /// The registrants user id for the presentor. should reference IAttendee on hydration.
        /// </summary>
        int presentorId { get; set; }
        /// <summary>
        /// The audiences targeted for the session.
        /// </summary>
        IEnumerable<string> audience { get; set; }
        /// <summary>
        /// The product that the session is based on. 
        /// </summary>
        string primaryProduct { get; set; }
        /// <summary>
        /// The theme for the session e.g. Business Intelligence.
        /// </summary>
        string theme { get; set; }
        /// <summary>
        /// The starting time of the session.
        /// </summary>
        DateTime startDate { get; set; }
        /// <summary>
        /// The ending time of the session.
        /// </summary>
        DateTime endDate { get; set; }
        #endregion
        
        #region get a single session

        /// <summary>
        /// A function to get a session by it's id.
        /// </summary>
        /// <param name="sessionId">The internal id of a session.</param>
        /// <returns></returns>
        IIgniteSession GetIgniteSessionBySessionId(int sessionId);
        
        #endregion

        #region search functions

        /// <summary>
        /// Retrieve a list of sessions by the track/s e.g. Cloud or Data & Analytics. In the case of multiple tracks do an or lookup.
        /// </summary>
        /// <param name="trackName">The list of track names to search with.</param>
        /// <returns>A list of sessions corresponding to the search criteria.</returns>
        List<IIgniteSession> SearchForSessionsByTrack(IEnumerable<string> trackName);

        /// <summary>
        /// Retrieve a list of sessions that matches a wildcard search across the session names.
        /// </summary>
        /// <param name="sessionName">The substring of the session name to search for.</param>
        /// <returns>A list of sessions corresponding to the search criteria.</returns>
        List<IIgniteSession> SearchForSessionsBySessionName(string sessionName);

        /// <summary>
        /// Retrieve a list of sessions that cover a product/s e.g. Power BI or Azure Machine Learning. In the case of multiple do an or lookup.
        /// </summary>
        /// <param name="productName">A list of the products to search with.</param>
        /// <returns>A list of session corresponding to the search criteria</returns>
        List<IIgniteSession> SearchForSessionsByProduct(IEnumerable<string> productName);

        #endregion
        
    }
}
