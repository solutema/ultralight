SET FOREIGN_KEY_CHECKS=0;

UPDATE personas SET fecha=fechaalta WHERE fecha IS NULL;
UPDATE personas SET fecha=contrasena_fecha WHERE fecha IS NULL;
UPDATE personas SET fecha=NOW() WHERE fecha IS NULL;

INSERT INTO tipo_doc SET id_tipo_doc=7, nombre='Pasaporte';

/*
	Renombrar campos
	articulos.fecha_creado	-> fecha
	tickets.fecha_ingreso	-> fecha
*/

/* Renombrar tablas
	alicuotas			-> impu_alicuotas
	chequeras			-> bancos_chequeras
	ciudades			-> localidades
	conceptos			-> cajas_conceptos
	documentos_tipos	-> comprob_tipos
	marcas				-> articulos_marcas
	margenes			-> articulos_margenes
	pvs					-> comprob_pvs
	situaciones			-> impu_situaciones
	talonarios			-> comprob_talonarios
	tipo_doc			-> personas_tipodoc
*/

DROP TABLE IF EXISTS quickpaste;
DROP TABLE IF EXISTS sys_accessbase;
DROP TABLE IF EXISTS sys_accesslist;

SET FOREIGN_KEY_CHECKS=1;
