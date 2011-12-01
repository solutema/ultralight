SET FOREIGN_KEY_CHECKS=0;

INSERT INTO alicuotas (id_alicuota, porcentaje, nombre) VALUES (3, 27, 'IVA 27%');
INSERT INTO alicuotas (id_alicuota, porcentaje, nombre) VALUES (4, 0, 'IVA 0%');

UPDATE personas SET fecha=fechaalta WHERE fecha IS NULL;
UPDATE personas SET fecha=contrasena_fecha WHERE fecha IS NULL;
UPDATE personas SET fecha=NOW() WHERE fecha IS NULL;


INSERT INTO tipo_doc SET id_tipo_doc=7, nombre='Pasaporte';


INSERT INTO articulos_rubros (id_rubro, nombre, estado, fecha, id_alicuota) VALUES (1, 'Productos o servicios IVA 21%', 1, NOW(), 1);
INSERT INTO articulos_rubros (id_rubro, nombre, estado, fecha, id_alicuota) VALUES (2, 'Productos o servicios IVA 10.5%', 1, NOW(), 2);


REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (1,'Global',NULL,0,'0000-00-00 00:00:00','Global',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (2,'Personas',NULL,0,'0000-00-00 00:00:00','Lbl.Personas.Persona',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (3,'Artículos',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Articulo',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (4,'Cajas',NULL,0,'0000-00-00 00:00:00','Lbl.Cajas.Caja',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (5,'Cuentas Corrientes',NULL,0,'0000-00-00 00:00:00','Lbl.CuentasCorrientes.CuentaCorriente',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (6,'Comprobantes: Comprobantes con Artículos',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.ComprobanteConArticulos',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (7,'Comprobantes: Recibos',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Recibo',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (8,'Comprobantes: Tickets',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Ticket',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (9,'Comprobantes: Facturas',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Factura',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (10,'Bancos: Chequeras',NULL,0,'0000-00-00 00:00:00','Lbl.Bancos.Chequera',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (11,'Bancos: Cheques',NULL,0,'0000-00-00 00:00:00','Lbl.Bancos.Cheque',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (12,'Tareas',NULL,0,'0000-00-00 00:00:00','Lbl.Tareas.Tarea',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (13,'Comprobantes: Recibos de Pago',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.ReciboDePago',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (14,'Comprobantes: Recibos de Cobro',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.ReciboDeCobro',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (15,'Comprobantes: Presupuestos',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Presupuesto',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (16,'Comprobantes: Remitos',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Remito',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (17,'Comprobantes: Comprobantes Facturables',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.ComprobanteFacturable',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (18,'Artículos: Marcas',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Marca',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (19,'Artículos: Márgenes',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Margen',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (20,'Artículos: Categorías',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Categoria',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (21,'Artículos: Rubros',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Rubro',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (22,'Artículos: Situaciones',NULL,0,'0000-00-00 00:00:00','Lbl.Articulos.Situacion',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (23,'Bancos: Cheques Emitido',NULL,0,'0000-00-00 00:00:00','Lbl.Bancos.ChequeEmitido',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (24,'Bancos: Cheques Recibido',NULL,0,'0000-00-00 00:00:00','Lbl.Bancos.ChequeRecibido',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (25,'Cajas: Conceptos',NULL,0,'0000-00-00 00:00:00','Lbl.Cajas.Concepto',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (26,'Cajas: Vencimientos',NULL,0,'0000-00-00 00:00:00','Lbl.Cajas.Vencimiento',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (27,'Comprobantes: Tipos de Comprobante',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.Tipo',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (28,'Comprobantes: Puntos de Venta',NULL,0,'0000-00-00 00:00:00','Lbl.Comprobantes.PuntoDeVenta',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (29,'Localidades',NULL,0,'0000-00-00 00:00:00','Lbl.Entidades.Localidad',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (30,'Sucursales',NULL,0,'0000-00-00 00:00:00','Lbl.Entidades.Sucursales',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (31,'Monedas',NULL,0,'0000-00-00 00:00:00','Lbl.Entidades.Monedas',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (32,'Impresoras',NULL,0,'0000-00-00 00:00:00','Lbl.Impresion.Impresoras',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (33,'Comprobantes: Plantillas',NULL,0,'0000-00-00 00:00:00','Lbl.Impresion.Plantillas',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (34,'Impuestos: Alícuotas',NULL,0,'0000-00-00 00:00:00','Lbl.Impuestos.Alicuotas',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (35,'Formas de Pago',NULL,0,'0000-00-00 00:00:00','Lbl.Pagos.FormaDePago',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (36,'Formas de Pago: Planes',NULL,0,'0000-00-00 00:00:00','Lbl.Pagos.Plan',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (37,'Formas de Pago: Cupones',NULL,0,'0000-00-00 00:00:00','Lbl.Pagos.Cupon',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (38,'Personas: Grupos',NULL,0,'0000-00-00 00:00:00','Lbl.Personas.Grupo',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (39,'Personas: Proveedores',NULL,0,'0000-00-00 00:00:00','Lbl.Personas.Proveedor',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (40,'Tareas: Estados',NULL,0,'0000-00-00 00:00:00','Lbl.Tareas.Estado',NULL,NULL,NULL,NULL,NULL,NULL);
REPLACE INTO "sys_permisos_objetos" ("id_objeto","nombre","obs","estado","fecha","tipo","extra1_nombre","extra2_nombre","extra3_nombre","extraa_nombre","extrab_nombre","extrac_nombre") VALUES (41,'Tareas: Categorías',NULL,0,'0000-00-00 00:00:00','Lbl.Tareas.Tipo',NULL,NULL,NULL,NULL,NULL,NULL);



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
