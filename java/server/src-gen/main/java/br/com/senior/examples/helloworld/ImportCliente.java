/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.ImportClienteOutput;
import br.com.senior.examples.helloworld.ImportClienteInput;

@CommandDescription(name="importCliente", kind=CommandKind.Action, requestPrimitive="importCliente", responsePrimitive="importClienteResponse")
public interface ImportCliente extends MessageHandler {
    
    public ImportClienteOutput importCliente(ImportClienteInput request);
    
}
