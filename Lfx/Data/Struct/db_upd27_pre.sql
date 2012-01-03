SET FOREIGN_KEY_CHECKS=0;

ESTO CORRESPONDE A 25 PRE:

DELETE FROM personas_tipos WHERE id_tipo_persona=0 OR id_tipo_persona IS NULL;
DELETE FROM tickets_estados WHERE id_ticket_estado=0 OR id_ticket_estado IS NULL;

ALTER TABLE personas_tipos ALTER COLUMN id_tipo_persona DROP DEFAULT;
ALTER TABLE personas_tipos CHANGE id_tipo_persona id_tipo_persona INTEGER AUTO_INCREMENT NOT NULL;
ALTER TABLE tickets_estados ALTER COLUMN id_ticket_estado DROP DEFAULT;
ALTER TABLE tickets_estados CHANGE id_ticket_estado id_ticket_estado INTEGER AUTO_INCREMENT NOT NULL;

/*
	Renombrar campos
	articulos.fecha_creado	-> fecha
	articulos_categorias.requierens -> seguimiento
	tickets.fecha_ingreso	-> fecha
*/

/* Renombrar tablas
	alicuotas			-> impu_alicuotas
	chequeras			-> bancos_chequeras
	ciudades			-> localidades
	conceptos			-> cajas_conceptos
	documentos_tipos	-> docu_tipos
	marcas				-> articulos_marcas
	margenes			-> articulos_margenes
	pvs					-> comprob_pvs
	situaciones			-> impu_situaciones
	talonarios			-> comprob_talonarios
	tipo_doc			-> personas_tipodoc
	tickets*			-> tareas*
	sys_plantillas		-> docu_plantillas
	tarjetas_planes		-> formaspago_planes
	tarjetas_cupones	-> formaspago_cupones
*/

SET FOREIGN_KEY_CHECKS=1;
