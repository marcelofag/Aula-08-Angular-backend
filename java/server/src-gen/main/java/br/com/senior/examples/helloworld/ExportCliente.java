/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.ExportClienteOutput;
import br.com.senior.examples.helloworld.ExportClienteInput;

@CommandDescription(name="exportCliente", kind=CommandKind.Query, requestPrimitive="exportCliente", responsePrimitive="exportClienteResponse")
public interface ExportCliente extends MessageHandler {
    
    public ExportClienteOutput exportCliente(ExportClienteInput request);
    
}
