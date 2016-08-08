namespace PusherServer
{
    /// <summary>
    /// Represents the payload to be sent when notifying
    /// </summary>
    internal class NotifyBody
    {
        /// <summary>
        /// The event data
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// The interests the payload should be triggered on.
        /// </summary>
        public string[] interests { get; set; }

        /// <summary>
        /// The id of a socket to be excluded from receiving the event.
        /// </summary>
        public string socket_id { get; set; }
    }
}
