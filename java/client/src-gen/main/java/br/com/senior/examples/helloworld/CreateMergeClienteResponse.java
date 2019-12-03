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
 * Response method for createMergeCliente
 */
@CommandDescription(name="createMergeClienteResponse", kind=CommandKind.ResponseCommand, requestPrimitive="createMergeClienteResponse")
public interface CreateMergeClienteResponse extends MessageHandler {

	void createMergeClienteResponse(Cliente response);
	
	void createMergeClienteResponseError(ErrorPayload error);

}
