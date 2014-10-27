﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Reflection;
using ManyWho.Flow.SDK.Draw.Elements;
using ManyWho.Flow.SDK.Attributes;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Run.Elements.Type;
/*!

Copyright 2014 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/
namespace ManyWho.Flow.SDK.Draw.Log
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    [ObjectAPI("Log")]
    public class LogAPI : ElementAPI
    {
        [DataMember]
        [PropertyAPI("StateId")]
        public string StateId
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("FlowId")]
        public string FlowId
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("FlowDeveloperName")]
        public string FlowDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        [PropertyAPI("Entries")]
        public Dictionary<string, LogEntryAPI> Entries
        {
            get;
            set;
        }
    }
}