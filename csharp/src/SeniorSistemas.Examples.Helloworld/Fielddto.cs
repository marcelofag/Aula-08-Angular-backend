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
    public class Fielddto
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? Id { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Name { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public FieldType? FieldType { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? Start { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? Size { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string MaskPattern { get; set; }
        
        /// <summary>
        /// Constructor for Fielddto
        /// </summary>
        /// <param name="id">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="name">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="fieldType">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public Fielddto(long? id, string name, FieldType? fieldType)
        {
            this.Id = id;
            this.Name = name;
            this.FieldType = fieldType;
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
