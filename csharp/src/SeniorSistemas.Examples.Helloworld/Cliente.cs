namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.

    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    ///<summary>
    /// Entidade que representa o cliente
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.1")]
    public class Cliente
    {
        
        ///<summary>Identifier for id-based queries/actions involving Cliente.</summary>
        public class Id
        {
            ///<summary>The value of the identifier of the object of interest.</summary>
            public string IdValue { get; set; }
            ///<summary>A convenience accessor for the value of the id property.</summary>
            public string GetClienteId
            {
                get { return IdValue; }
            }
        }
        
        ///<summary>Paged results for queries involving Cliente.</summary>
        public class PagedResults
        {
            ///<summary>The contents of the query.</summary>
            public IList<Cliente> Contents { get; set; }
        }
        
        ///<summary>Paged request for queries involving Cliente.</summary>                    
        public class PageRequest
        {
        
            ///<summary>The optional offset for the request.</summary>
            public long? Offset { get; set; }
            
            ///<summary>The optional size limit for the response.</summary>
            public int? Size { get; set; }
        }
        
        ///<summary>
        /// Chave primaria
        ///</summary>
        public string Id { get; set; }
        ///<summary>
        /// Nome do cliente
        ///</summary>
        public string Nome { get; set; }
        
        ///<summary>
        /// Data de nascimento
        ///</summary>
        public DateTime? DataNascimento { get; set; }
        
        ///<summary>
        /// Tem credito habilitado
        ///</summary>
        public bool? CreditoHabilitado { get; set; }
        
        ///<summary>
        /// CPF do cliente
        ///</summary>
        public string Cpf { get; set; }
        
        ///<summary>
        /// id da foto
        ///</summary>
        public string IdFoto { get; set; }
        
        /// <summary>
        /// Constructor for Cliente
        /// </summary>
        /// <param name="nome">
        ///<summary>
        /// Nome do cliente
        ///</summary>
        /// </param>
        /// <param name="dataNascimento">
        ///<summary>
        /// Data de nascimento
        ///</summary>
        /// </param>
        /// <param name="cpf">
        ///<summary>
        /// CPF do cliente
        ///</summary>
        /// </param>
        public Cliente(string nome, DateTime? dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
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
