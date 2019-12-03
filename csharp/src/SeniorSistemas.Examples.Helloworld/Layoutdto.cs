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
    public class Layoutdto
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? Id { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Description { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public FileFormat? FileFormat { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public ErrorStrategy? ErrorStrategy { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Delimiter { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? SkipLines { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public IList<Fielddto> Fields { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public IList<Hookdto> Hooks { get; set; }
        
        /// <summary>
        /// Constructor for Layoutdto
        /// </summary>
        /// <param name="id">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="description">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="fileFormat">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="errorStrategy">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="skipLines">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="fields">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public Layoutdto(long? id, string description, FileFormat? fileFormat, ErrorStrategy? errorStrategy, long? skipLines, IList<Fielddto> fields)
        {
            this.Id = id;
            this.Description = description;
            this.FileFormat = fileFormat;
            this.ErrorStrategy = errorStrategy;
            this.SkipLines = skipLines;
            this.Fields = fields;
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
