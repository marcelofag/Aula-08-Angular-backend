/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.Cliente;
import br.com.senior.examples.helloworld.Cliente.Id;

/**
 * The 'retrieve' request primitive for the Cliente entity.
 */
@CommandDescription(name="retrieveCliente", kind=CommandKind.Retrieve, requestPrimitive="retrieveCliente", responsePrimitive="retrieveClienteResponse")
public interface RetrieveCliente extends MessageHandler {
    
    public Cliente retrieveCliente(Cliente.Id id);
    
}
