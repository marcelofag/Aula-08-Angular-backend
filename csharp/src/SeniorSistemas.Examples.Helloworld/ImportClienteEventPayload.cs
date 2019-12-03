namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    			
    ///<summary>
    /// Payload for ImportClienteEventPayload
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.1")]
    public class ImportClienteEventPayload
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public ImportEventStatus Eventpl { get; set; }
        
        /// <summary>
        /// Constructor for ImportClienteEventPayload
        /// </summary>
        /// <param name="eventpl">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ImportClienteEventPayload(ImportEventStatus eventpl)
        {
            this.Eventpl = eventpl;
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
