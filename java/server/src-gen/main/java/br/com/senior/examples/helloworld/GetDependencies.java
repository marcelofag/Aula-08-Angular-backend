/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.GetDependenciesOutput;

/**
 * Returns a list with all dependencies from this service, along with their respective versions
 */
@CommandDescription(name="getDependencies", kind=CommandKind.Query, requestPrimitive="getDependencies", responsePrimitive="getDependenciesResponse")
public interface GetDependencies extends MessageHandler {
    
    public GetDependenciesOutput getDependencies();
    
}
