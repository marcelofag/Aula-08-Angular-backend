namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    			
    ///<summary>
    /// Output payload for command helloWorld
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.1")]
    public class HelloWorldOutput
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public string HelloWorldMessage { get; set; }
        
        /// <summary>
        /// Constructor for HelloWorldOutput
        /// </summary>
        /// <param name="helloWorldMessage">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public HelloWorldOutput(string helloWorldMessage)
        {
            this.HelloWorldMessage = helloWorldMessage;
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
