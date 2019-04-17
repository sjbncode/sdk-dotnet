using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Run.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowStackFrameAPI
    {

        [DataMember]
        public FlowIdAPI FlowId
        {
            get;
            set;
        }


        [DataMember]
        public Guid? MapElementId
        {
            get;
            set;
        }


        [DataMember]
        public ISet<Guid> ValueElementIds
        {
            get;
            set;
        }
    }
} 