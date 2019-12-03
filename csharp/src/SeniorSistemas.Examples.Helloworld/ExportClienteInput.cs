namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    			
    ///<summary>
    /// Input payload for command exportCliente
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.1")]
    public class ExportClienteInput
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public ExportConfig Config { get; set; }
        
        /// <summary>
        /// Constructor for ExportClienteInput
        /// </summary>
        /// <param name="config">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ExportClienteInput(ExportConfig config)
        {
            this.Config = config;
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
