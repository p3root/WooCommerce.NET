﻿using System.Runtime.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    [DataContract]
    public class PostRevisions
    {
        public static string Endpoint { get { return "revisions"; } }

        /// <summary>
        /// The ID for the author of the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ulong? author { get; set; }

        /// <summary>
        /// The date the object was published, in the site's timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string date { get; set; }

        /// <summary>
        /// The date the object was published, as GMT.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string date_gmt { get; set; }

        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "guid")]
        protected ContentObject guidValue { get; set; }

        [IgnoreDataMember]
        public string guid
        {
            get
            {
                return guidValue.rendered;
            }
            set
            {
                if (guidValue == null)
                    guidValue = new ContentObject();

                guidValue.rendered = value;
            }
        }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ulong? id  { get; set; }

        /// <summary>
        /// The date the object was last modified, in the site's timezone.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string modified { get; set; }

        /// <summary>
        /// The date the object was last modified, as GMT.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string modified_gmt { get; set; }

        /// <summary>
        /// The ID for the parent of the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ulong? parent  { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the object unique to its type.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string slug { get; set; }

        /// <summary>
        /// The title for the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "title")]
        protected ContentObject titleValue { get; set; }

        [IgnoreDataMember]
        public string title
        {
            get
            {
                return titleValue.rendered;
            }
            set
            {
                if (titleValue == null)
                    titleValue = new ContentObject();

                titleValue.rendered = value;
            }
        }

        /// <summary>
        /// The content for the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "content")]
        protected ContentObject contentValue { get; set; }

        [IgnoreDataMember]
        public string content
        {
            get
            {
                return contentValue.rendered;
            }
            set
            {
                if (contentValue == null)
                    contentValue = new ContentObject();

                contentValue.rendered = value;
            }
        }

        /// <summary>
        /// The excerpt for the object.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "excerpt")]
        protected ContentObject excerptValue { get; set; }

        [IgnoreDataMember]
        public string excerpt
        {
            get
            {
                return excerptValue.rendered;
            }
            set
            {
                if (excerptValue == null)
                    excerptValue = new ContentObject();

                excerptValue.rendered = value;
            }
        }

        /// <summary>
        /// Format json string on Serialize
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string FormatJsonS(string json)
        {
            int startIndex = json.IndexOf("{\"rendered\":");
            int endIndex = 0;
            string oldPart = string.Empty;
            string newPart = string.Empty;

            while (startIndex > 0)
            {
                endIndex = json.IndexOf("\"}", startIndex);

                oldPart = json.Substring(startIndex, endIndex - startIndex + 2);
                newPart = oldPart.Substring(12).TrimEnd('}');

                json = json.Replace(oldPart, newPart);

                startIndex = json.IndexOf("{\"rendered\":");
            }

            return json;
        }
    }
}
