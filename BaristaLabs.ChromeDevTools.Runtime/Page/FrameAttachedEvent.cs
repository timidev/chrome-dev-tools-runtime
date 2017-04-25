namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when frame has been attached to its parent.
    /// </summary>
    public sealed class FrameAttachedEvent : IEvent
    {
        /// <summary>
        /// Id of the frame that has been attached.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Parent frame identifier.
        /// </summary>
        [JsonProperty("parentFrameId")]
        public string ParentFrameId
        {
            get;
            set;
        }
    }
}