﻿#region (c) 2010-2011 Lokad - CQRS for Windows Azure - New BSD License 

// Copyright (c) Lokad 2010-2011, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

using System;
using System.Runtime.Serialization;

namespace Lokad.Cqrs.StreamingStorage
{
    [Serializable]
    public class StreamingContainerNotFoundException : StreamingBaseException
    {
        public StreamingContainerNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected StreamingContainerNotFoundException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}