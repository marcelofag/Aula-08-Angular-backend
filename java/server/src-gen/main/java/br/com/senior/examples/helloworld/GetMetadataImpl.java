/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import org.springframework.context.annotation.Lazy;
import org.springframework.stereotype.Component;

import br.com.senior.messaging.model.HandlerImpl;
import br.com.senior.messaging.model.MessageHandler;
import br.com.senior.messaging.model.ServiceException;
import br.com.senior.messaging.model.SilentServiceException;
import br.com.senior.messaging.ErrorCategory;
import java.io.IOException;
import br.com.senior.MetadataService;
import javax.inject.Inject;

@Lazy
@HandlerImpl
@Component("examples.hello_world.getMetadata")
public class GetMetadataImpl implements GetMetadata, MessageHandler {
	
	private MetadataService metadataService;

	@Inject
	public GetMetadataImpl(MetadataService metadataService) {
		this.metadataService = metadataService; 
	}

	@Override
	public GetMetadataOutput getMetadata(GetMetadataInput request) {
		String format = (request.metadataFormat == null || request.metadataFormat.isEmpty()) ? "sd.xml" : request.metadataFormat;
		try {
			String content = metadataService.getMetadata("examples", "hello_world", format);
			return new GetMetadataOutput(content);
		} catch (IllegalArgumentException e) {
			throw new SilentServiceException(ErrorCategory.OBJECT_NOT_FOUND, "The metadataFormat does not exists", e);
		} catch (IOException e) {
			throw new ServiceException(ErrorCategory.INTERNAL_ERROR, "Could not read metadata due to an I/O error", e);
		}
	}
}
