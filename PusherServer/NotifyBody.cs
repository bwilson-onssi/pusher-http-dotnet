namespace PusherServer
{
    /// <summary>
    /// Represents the payload to be sent when notifying
    /// </summary>
    internal class NotifyBody
    {
        /// <summary>
        /// The interests the payload should be triggered on.
        /// </summary>
        public string[] interests { get; set; }

        /// <summary>
        /// The APNs event data
        /// </summary>
        public object apns { get; set; }
    }
}
