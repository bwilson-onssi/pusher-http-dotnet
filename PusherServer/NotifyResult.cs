using System;
using System.Net;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using PusherServer.Exceptions;
using PusherServer.Util;
using RestSharp;

namespace PusherServer
{
    internal class NotifyResult : RequestResult, INotifyResult
    {
        private readonly IDictionary<string, string> _eventIds;

        /// <summary>
        /// Constructs a new instance of a NotifyResult based upon a passed in Rest Response
        /// </summary>
        /// <param name="response">The Rest Response which will form the basis of this Notify Result</param>
        public NotifyResult(IRestResponse response) : base(response)
        {
            EventIdData eventIdData = null;
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                eventIdData = serializer.Deserialize<EventIdData>(response.Content);
            }
            catch (Exception)
            {
                string msg =
                    string.Format("The response body from the Pusher HTTP endpoint could not be parsed as JSON: {0}{1}",
                                  Environment.NewLine,
                                  response.Content);
                throw new NotifyResponseException(msg);
            }

            _eventIds = new ReadOnlyDictionary<string, string>(eventIdData.event_ids);
        }

        /// <inheritDoc/>
        public IDictionary<string, string> EventIds
        {
            get { return this._eventIds; }
        }
    }
}
