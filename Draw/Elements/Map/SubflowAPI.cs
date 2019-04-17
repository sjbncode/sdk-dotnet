using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    public class SubflowAPI
    {
        public SubflowAPI(FlowIdAPI flowId)
        {
            this.flowId = flowId;
        }

        /// <summary>
        /// The identifier of the flow that is called as subflow
        /// </summary>
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }
    }
}