/* Database: Oracle. Generation date: 2019-10-19 11:38:33:053 */
/* Entity ClienteEntity */
create table cliente (
	id VARCHAR(255),
	nome VARCHAR(255) NOT NULL,
	data_nascimento DATE NOT NULL /* dataNascimento */,
	credito_habilitado BOOLEAN /* creditoHabilitado */,
	cpf VARCHAR(255) NOT NULL,
	id_foto VARCHAR(255) /* idFoto */,
	ext VARCHAR2(4000)
);



/* Join Tables */

/* Primary Key Constraints */
alter table cliente add constraint pk_cliente_id primary key(id);

/* Foreign Key Constraints */

/* Unique Key Constraints */
