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
    public class ImportError
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public ErrorType? ErrorType { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? LineNumber { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Bean { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Message { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string ExceptionClass { get; set; }
        
        /// <summary>
        /// Constructor for ImportError
        /// </summary>
        /// <param name="errorType">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="lineNumber">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="bean">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="message">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="exceptionClass">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ImportError(ErrorType? errorType, long? lineNumber, string bean, string message, string exceptionClass)
        {
            this.ErrorType = errorType;
            this.LineNumber = lineNumber;
            this.Bean = bean;
            this.Message = message;
            this.ExceptionClass = exceptionClass;
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
