﻿using Bridge;

namespace System
{
    /// <summary>
    /// Provides an object representation of a uniform resource identifier (URI) and easy access to the parts of the URI.
    /// </summary>
    [External]
    [Reflectable]
    public class Uri
    {
        public extern Uri(string uriString);

        public extern string AbsoluteUri
        {
            [Template("getAbsoluteUri()")]
            get;
        }

        [Template("System.Uri.equals({uri1}, {uri2})")]
        public static extern bool operator ==(Uri uri1, Uri uri2);

        [Template("System.Uri.notEquals({uri1}, {uri2})")]
        public static extern bool operator !=(Uri uri1, Uri uri2);
    }
}