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
    public class Hookdto
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public HookFunction? HookFunction { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Script { get; set; }
        
        /// <summary>
        /// Constructor for Hookdto
        /// </summary>
        /// <param name="hookFunction">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="script">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public Hookdto(HookFunction? hookFunction, string script)
        {
            this.HookFunction = hookFunction;
            this.Script = script;
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
