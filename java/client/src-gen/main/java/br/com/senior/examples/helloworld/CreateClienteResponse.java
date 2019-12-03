/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;	

import br.com.senior.messaging.ErrorPayload;
import br.com.senior.messaging.model.CommandDescription;
import br.com.senior.messaging.model.CommandKind;
import br.com.senior.messaging.model.MessageHandler;
import br.com.senior.examples.helloworld.Cliente;

/**
 * Response method for createCliente
 */
@CommandDescription(name="createClienteResponse", kind=CommandKind.ResponseCommand, requestPrimitive="createClienteResponse")
public interface CreateClienteResponse extends MessageHandler {

	void createClienteResponse(Cliente response);
	
	void createClienteResponseError(ErrorPayload error);

}
