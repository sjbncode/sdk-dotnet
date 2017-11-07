﻿using System;
using System.Runtime.Serialization;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Utils
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class NotificationMessageAPI
    {
        /// <summary>
        /// The media type for the message. Currently the platform only supports: text/html or text/plain
        /// </summary>
        [DataMember]
        public String mediaType
        {
            get;
            set;
        }

        /// <summary>
        /// The message string in the correct format for the media type.
        /// </summary>
        [DataMember]
        public String message
        {
            get;
            set;
        }
    }
}
