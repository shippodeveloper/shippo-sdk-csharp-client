using System;
using Newtonsoft.Json.Linq;

namespace ShippoSDK
{
    public class ShippoSdkException : Exception
    {
        public override string Message { get; }
        public string Name { get; }

        public ShippoSdkException(string message)
            : base(message)
        {
            var exceptionData = JObject.Parse(message);
            Console.WriteLine(exceptionData);
            if (exceptionData["error"] == null) return;
            Message = exceptionData["error"]["message"].ToString();
            Name = exceptionData["error"]["name"].ToString();
        }
    }
}