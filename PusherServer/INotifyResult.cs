using System.Collections.Generic;

namespace PusherServer
{
    /// <summary>
    /// Interface for Notify Request Results
    /// </summary>
    public interface INotifyResult: IRequestResult
    {
        /// <summary>
        /// Gets the Event IDs related to this Notify Event
        /// </summary>
        IDictionary<string, string> EventIds { get; }
    }
}
