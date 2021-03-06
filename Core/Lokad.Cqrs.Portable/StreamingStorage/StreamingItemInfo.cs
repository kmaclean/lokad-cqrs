﻿#region (c) 2010-2011 Lokad - CQRS for Windows Azure - New BSD License 

// Copyright (c) Lokad 2010-2011, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Lokad.Cqrs.StreamingStorage
{
    public sealed class StreamingItemInfo
    {
        public string ETag { get; private set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public NameValueCollection Metadata { get; private set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public IDictionary<string, string> Properties { get; private set; }

        //public string FullPath { get; private set; }
        //public string Name { get; private set; }

        public StreamingItemInfo(
            //string name,
            //string fullPath,
            string eTag,
            NameValueCollection metadata,
            IDictionary<string, string> properties)
        {
            //Name = name;
            //FullPath = fullPath;

            ETag = eTag;
            Metadata = metadata;
            Properties = properties;
        }
    }
}