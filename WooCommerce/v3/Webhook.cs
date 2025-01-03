﻿using System;
using System.Runtime.Serialization;

namespace WooCommerceNET.WooCommerce.v3
{
    [DataContract]
    public class Webhook : v2.Webhook { }

    [DataContract]
    public class WebhookDelivery
    {
        /// <summary>
        /// Unique identifier for the resource.
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ulong? id { get; set; }

        /// <summary>
        /// The delivery duration, in seconds.     
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string duration { get; set; }

        /// <summary>
        /// A friendly summary of the response including the HTTP response code, message, and body        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string summary { get; set; }

        /// <summary>
        /// The URL where the webhook was delivered
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string request_url { get; set; }

        /// <summary>
        /// Array of request headers (see Request Headers Attributes)
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RequestHeaders request_headers { get; set; }

        /// <summary>
        /// The request body, this matches the API response for the given resource        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string request_body { get; set; }

        /// <summary>
        /// The HTTP response code from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string response_code { get; set; }

        /// <summary>
        /// The HTTP response message from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string response_message { get; set; }

        /// <summary>
        /// Array of the response headers from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public RequestHeaders response_headers { get; set; }

        /// <summary>
        /// The response body from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string response_body { get; set; }

        /// <summary>
        /// The date the webhook delivery was logged, in the site’s timezone.     
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the webhook delivery was logged, GMT.   
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created_gmt { get; set; }
    }
    
    [DataContract]
    public class RequestHeaders
    {
        /// <summary>
        /// The request user agent, defaults to “WooCommerce/{version} Hookshot (WordPress/{version})”
        /// </summary>
        [DataMember(Name = "User-Agent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// The request content-type, defaults to “application/json”
        /// </summary>
        [DataMember(Name = "Content-Type", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// The webhook topic
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Topic", EmitDefaultValue = false)]
        public string XWCWebhookTopic { get; set; }

        /// <summary>
        /// The webhook resource
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Resource", EmitDefaultValue = false)]
        public string XWCWebhookResource { get; set; }

        /// <summary>
        /// The webhook event
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Event", EmitDefaultValue = false)]
        public string XWCWebhookEvent { get; set; }

        /// <summary>
        /// A base64 encoded HMAC-SHA256 hash of the payload
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Signature", EmitDefaultValue = false)]
        public string XWCWebhookSignature { get; set; }

        /// <summary>
        /// The webhook’s ID
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-ID", EmitDefaultValue = false)]
        public uint XWCWebhookID { get; set; }

        /// <summary>
        /// The delivery ID
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Delivery-ID", EmitDefaultValue = false)]
        public uint XWCWebhookDeliveryID { get; set; }

    }

}
