using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteBot.Lib.Interfaces
{
    /// <summary>
    /// Interface detailing an attendee at ignite.
    /// </summary>
    interface IAttendee
    {

        #region members

        /// <summary>
        /// The internal id for the attendee.
        /// </summary>
        int id { get; set; }
        /// <summary>
        /// Whether they're a presentor.
        /// </summary>
        bool isPresentor { get; set; }
        /// <summary>
        /// The email of the attendee.
        /// </summary>
        string email { get; set; }

        #endregion

        #region methods for presentors.

        /// <summary>
        /// Return the persentors for the conference.
        /// </summary>
        /// <returns>List of presentors.</returns>
        IEnumerable<IAttendee> GetPresentors();

        /// <summary>
        /// Retrieve a list of presentors that cover a product/s e.g. Power BI or Azure Machine Learning. In the case of multiple do an or lookup.
        /// </summary>
        /// <param name="productsByName">The products to search by.</param>
        /// <returns></returns>
        IEnumerable<IAttendee> GetPresentorsByProduct(IEnumerable<string> productsByName);

        /// <summary>
        /// Retrieve a list of presentors that are mapped to a theme.
        /// </summary>
        /// <param name="theme">A theme like business intelligence.</param>
        /// <returns></returns>
        IEnumerable<IAttendee> GetPresentorsByTheme(string theme);

        /// <summary>
        /// Retrieve a list of presentors by the track/s e.g. Cloud or Data & Analytics. In the case of multiple tracks do an or lookup.
        /// </summary>
        /// <param name="trackNames">The trakc names to search by.</param>
        /// <returns></returns>
        IEnumerable<IAttendee> GetPresentorsByTrack(IEnumerable<string> trackNames);
        
        #endregion
        
    }
}
