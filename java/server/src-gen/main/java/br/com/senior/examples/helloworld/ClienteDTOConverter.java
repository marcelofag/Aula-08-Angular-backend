/**
 * This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
 */
package br.com.senior.examples.helloworld;

import java.util.IdentityHashMap;
import br.com.senior.messaging.customspringdata.CustomDTOConverter;
import br.com.senior.messaging.customspringdata.CustomFieldPermission;
import java.util.stream.Collectors;
import br.com.senior.examples.helloworld.Cliente;
import javax.inject.Inject;
import org.springframework.stereotype.Component;
import org.springframework.context.annotation.Lazy;

@Component
@Lazy
public final class ClienteDTOConverter {
	
	private CustomFieldPermission customFieldPermission;
	
	@Inject
	public void setCustomFieldPermission(CustomFieldPermission customFieldPermission) {
		this.customFieldPermission = customFieldPermission;
	}
	
	public ClienteEntity toEntity(Cliente dto) {
		return toEntity(dto, new IdentityHashMap<>());
	}
	
	ClienteEntity toEntity(Cliente dto, java.util.Map<Object, Object> converted) {
		if (dto == null) {
			return null;
		}
		ClienteEntity entity = (ClienteEntity) converted.get(dto);
		if (entity != null) {
			return entity;
		}
		entity = new ClienteEntity();
		converted.put(dto, entity);
		return mergeEntity(entity, dto, converted);
	}
	
	public ClienteEntity mergeEntity(ClienteEntity entity, Cliente dto) {
		return mergeEntity(entity, dto, new IdentityHashMap<>());
	}
	
	ClienteEntity mergeEntity(ClienteEntity entity, Cliente dto, java.util.Map<Object, Object> converted) {
		entity.setId(dto.id);
		entity.setNome(dto.nome);
		entity.setDataNascimento(dto.dataNascimento);
		entity.setCreditoHabilitado(dto.creditoHabilitado);
		entity.setCpf(dto.cpf);
		entity.setIdFoto(dto.idFoto);
		entity.setCheckPermission(customFieldPermission);
		CustomDTOConverter.copyCustomFieldsToEntity(dto, entity);
		return entity;
	}
	
	public java.util.List<ClienteEntity> toEntityList(java.util.List<Cliente> dtos) {
		return toEntityList(dtos, new IdentityHashMap<>());
	}
	
	java.util.List<ClienteEntity> toEntityList(java.util.List<Cliente> dtos, java.util.Map<Object, Object> converted) {
		java.util.List<ClienteEntity> entities = null;
		if (dtos != null) {
			entities = dtos.stream().map(dto -> toEntity(dto, converted)).collect(Collectors.toList());
		}	
		return entities;
	}
	
	public Cliente toDTO(ClienteEntity entity) {
		return toDTO(entity, new IdentityHashMap<>());
	}
	
	Cliente toDTO(ClienteEntity entity, java.util.Map<Object, Object> converted) {
		if (entity == null) {
			return null;
		}
		Cliente dto = (Cliente) converted.get(entity);
		if (dto != null) {
			return dto;
		}
        dto = new Cliente();
        converted.put(entity, dto);

		dto.id = entity.getId();
		dto.nome = entity.getNome();
		dto.dataNascimento = entity.getDataNascimento();
		dto.creditoHabilitado = entity.getCreditoHabilitado();
		dto.cpf = entity.getCpf();
		dto.idFoto = entity.getIdFoto();
		entity.setCheckPermission(customFieldPermission);
		CustomDTOConverter.copyCustomFieldsToDTO(entity, dto);
        return dto;
    }
    
    public java.util.List<Cliente> toDTOList(java.util.List<ClienteEntity> entities) {
    	return toDTOList(entities, new IdentityHashMap<>());
    }
    
    java.util.List<Cliente> toDTOList(java.util.List<ClienteEntity> entities, java.util.Map<Object, Object> converted) {
    	java.util.List<Cliente> dtos = null;
    	if (entities != null) {
    		dtos = entities.stream().map(entity -> toDTO(entity, converted)).collect(Collectors.toList());
    	}
    	return dtos;
    }
    
}	
