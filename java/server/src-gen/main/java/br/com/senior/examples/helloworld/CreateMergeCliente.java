/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.Cliente;
import br.com.senior.examples.helloworld.Cliente;

/**
 * The 'createMerge' request primitive for the Cliente entity.
 */
@CommandDescription(name="createMergeCliente", kind=CommandKind.CreateMerge, requestPrimitive="createMergeCliente", responsePrimitive="createMergeClienteResponse")
public interface CreateMergeCliente extends MessageHandler {
    
    public Cliente createMergeCliente(Cliente toCreateMerge);
    
}
