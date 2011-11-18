SET FOREIGN_KEY_CHECKS=0;

INSERT INTO alicuotas (id_alicuota, porcentaje, nombre) VALUES (3, 27, 'IVA 27%');

UPDATE personas SET fecha=fechaalta WHERE fecha IS NULL;
UPDATE personas SET fecha=contrasena_fecha WHERE fecha IS NULL;
UPDATE personas SET fecha=NOW() WHERE fecha IS NULL;


INSERT INTO tipo_doc SET id_tipo_doc=7, nombre='Pasaporte';


INSERT INTO articulos_rubros (id_rubro, nombre, estado, fecha, id_alicuota) VALUES (1, 'Productos o servicios IVA 21%', 1, NOW(), 1);
INSERT INTO articulos_rubros (id_rubro, nombre, estado, fecha, id_alicuota) VALUES (2, 'Productos o servicios IVA 10.5%', 1, NOW(), 2);


INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (18,'Artículos: Marcas','Lbl.Articulos.Marca');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (19,'Artículos: Márgenes','Lbl.Articulos.Margen');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (20,'Artículos: Categorías','Lbl.Articulos.Categoria');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (21,'Artículos: Rubros','Lbl.Articulos.Rubro');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (22,'Artículos: Situaciones','Lbl.Articulos.Situacion');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (23,'Bancos: Cheques Emitido','Lbl.Bancos.ChequeEmitido');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (24,'Bancos: Cheques Recibido','Lbl.Bancos.ChequeRecibido');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (25,'Cajas: Conceptos','Lbl.Cajas.Concepto');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (26,'Cajas: Vencimientos','Lbl.Cajas.Vencimiento');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (27,'Comprobantes: Tipos de Comprobante','Lbl.Comprobantes.Tipo');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (28,'Comprobantes: Puntos de Venta','Lbl.Comprobantes.PuntoDeVenta');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (29,'Localidades','Lbl.Entidades.Localidad');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (30,'Sucursales','Lbl.Entidades.Sucursales');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (31,'Monedas','Lbl.Entidades.Monedas');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (32,'Impresoras','Lbl.Impresion.Impresoras');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (33,'Comprobantes: Plantillas','Lbl.Impresion.Plantillas');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (34,'Impuestos: Alícuotas','Lbl.Impuestos.Alicuotas');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (35,'Formas de Pago','Lbl.Pagos.FormaDePago');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (36,'Formas de Pago: Planes','Lbl.Pagos.Plan');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (37,'Formas de Pago: Cupones','Lbl.Pagos.Cupon');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (38,'Personas: Grupos','Lbl.Personas.Grupo');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (39,'Personas: Proveedores','Lbl.Personas.Proveedor');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (40,'Tareas: Estados','Lbl.Tareas.Estado');
INSERT INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES (41,'Tareas: Categorías','Lbl.Tareas.Tipo');


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
