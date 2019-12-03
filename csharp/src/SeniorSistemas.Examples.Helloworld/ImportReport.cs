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
    public class ImportReport
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Id { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public DateTime? StartTime { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public DateTime? EndTime { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Uri { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string BeanClass { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public string ServiceClass { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public Layoutdto Layout { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? SucessCount { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? ErrorsCount { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? FilteredCount { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? SkippedCount { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public IList<ImportError> ImportErrors { get; set; }
        
        /// <summary>
        /// Constructor for ImportReport
        /// </summary>
        /// <param name="id">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="startTime">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="endTime">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="uri">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="beanClass">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="serviceClass">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="layout">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="sucessCount">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="errorsCount">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="filteredCount">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="skippedCount">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ImportReport(string id, DateTime? startTime, DateTime? endTime, string uri, string beanClass, string serviceClass, Layoutdto layout, long? sucessCount, long? errorsCount, long? filteredCount, long? skippedCount)
        {
            this.Id = id;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Uri = uri;
            this.BeanClass = beanClass;
            this.ServiceClass = serviceClass;
            this.Layout = layout;
            this.SucessCount = sucessCount;
            this.ErrorsCount = errorsCount;
            this.FilteredCount = filteredCount;
            this.SkippedCount = skippedCount;
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
