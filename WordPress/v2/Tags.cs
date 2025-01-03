﻿using System.Runtime.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    [DataContract]
    public class Tags
    {
        public static string Endpoint { get { return "tags"; } }

        /// <summary>
        /// Unique identifier for the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ulong? id  { get; set; }

        /// <summary>
        /// Number of published posts for the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public uint count { get; set; }

        /// <summary>
        /// HTML description of the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string description { get; set; }

        /// <summary>
        /// URL of the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string link { get; set; }

        /// <summary>
        /// HTML title for the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the term unique to its type.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string slug{ get; set; }

        /// <summary>
        /// Type attribution for the term.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string taxonomy { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public object meta { get; set; }
    }
}
