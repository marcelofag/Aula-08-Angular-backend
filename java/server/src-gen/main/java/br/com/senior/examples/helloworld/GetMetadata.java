/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.GetMetadataOutput;
import br.com.senior.examples.helloworld.GetMetadataInput;

/**
 * Default 'getMetadata' query. Every service must handle this command and return metadata in the format requested.
 */
@CommandDescription(name="getMetadata", kind=CommandKind.Query, requestPrimitive="getMetadata", responsePrimitive="getMetadataResponse")
public interface GetMetadata extends MessageHandler {
    
    public GetMetadataOutput getMetadata(GetMetadataInput request);
    
}
