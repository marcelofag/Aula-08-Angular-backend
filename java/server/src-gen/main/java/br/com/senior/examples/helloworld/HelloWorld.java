/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import br.com.senior.messaging.model.*;
import br.com.senior.examples.helloworld.HelloWorldOutput;
import br.com.senior.examples.helloworld.HelloWorldInput;

@CommandDescription(name="helloWorld", kind=CommandKind.Query, requestPrimitive="helloWorld", responsePrimitive="helloWorldResponse")
public interface HelloWorld extends MessageHandler {
    
    public HelloWorldOutput helloWorld(HelloWorldInput request);
    
}
