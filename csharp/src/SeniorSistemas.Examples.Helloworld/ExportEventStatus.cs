namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    			
    ///<summary>
    /// TBD
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.1")]
    public class ExportEventStatus
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public string ImporterId { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public EventType? EventType { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? RecordCount { get; set; }
        
        /// <summary>
        /// Constructor for ExportEventStatus
        /// </summary>
        /// <param name="importerId">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="eventType">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="recordCount">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ExportEventStatus(string importerId, EventType? eventType, long? recordCount)
        {
            this.ImporterId = importerId;
            this.EventType = eventType;
            this.RecordCount = recordCount;
        }
        
        public virtual void Validate()
        {
        	Validate(new ArrayList());
        }
        
        internal virtual void Validate(IList validated)
        {
            HelloWorldValidator.Validate(this, validated);
        }
    }
}
