﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateLogEntryAPI
    {
        [DataMember]
        public EngineInvokeRequestAPI engineInvokeRequest
        {
            get;
            set;
        }

        [DataMember]
        public EngineInvokeResponseAPI engineInvokeResponse
        {
            get;
            set;
        }

        [DataMember]
        public List<StateLogEntryInvokePairAPI> stateLogEntryInvokePairs
        {
            get;
            set;
        }

        [DataMember]
        public String timeStamp
        {
            get;
            set;
        }

        [DataMember]
        public String isActive
        {
            get;
            set;
        }
    }
}