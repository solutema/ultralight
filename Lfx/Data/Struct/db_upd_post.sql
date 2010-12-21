SET FOREIGN_KEY_CHECKS=0;

REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('1','Global','Global');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('2','Personas','Lbl.Personas.Persona');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('3','Artículos','Lbl.Articulos.Articulo');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('4','Cajas','Lbl.Cajas.Caja');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('5','Cuentas Corrientes','Lbl.CuentasCorrientes.CuentaCorriente');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('6','Comprobantes: Comprobantes con Artículos','Lbl.Comprobantes.ComprobanteConArticulos');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('7','Recibos de Cobro','Lbl.Comprobantes.ReciboDeCobro');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('8','Recibos de Pago','Lbl.Comprobantes.ReciboDePago');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('9','Comprobantes: Facturas','Lbl.Comprobantes.Factura');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('10','Bancos: Chequeras','Lbl.Bancos.Chequera');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('11','Bancos: Cheques','Lbl.Bancos.Cheque');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('12','Tareas','Lbl.Tareas.Tarea');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('13','Comprobantes: Recibos de Pago','Lbl.Comprobantes.ReciboDePago');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('14','Comprobantes: Recibos de Cobro','Lbl.Comprobantes.ReciboDeCobro');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('15','Comprobantes: Presupuestos','Lbl.Comprobantes.Presupuesto');
REPLACE INTO "sys_permisos_objetos" ("id_objeto", "nombre", "tipo") VALUES ('16','Comprobantes: Remitos','Lbl.Comprobantes.Remito');

REPLACE INTO "sys_permisos" ("id_permiso", "id_objeto", "id_persona", "items", "ops") VALUES (1, 1, 1, null, 65536);

UPDATE ciudades SET iva=1 WHERE id_ciudad=24;

REPLACE INTO impresoras (id_impresora, nombre, id_sucursal, tipo, estacion, carga, fiscal_modelo, dispositivo, fiscal_bps, fiscal_ultimoz, lsa, talonario, fecha, estado)
	SELECT id_pv, CONCAT('PV ', numero), id_sucursal, tipo, REPLACE(LEFT(REPLACE(estacion, '\\\\', ''), LOCATE('\\', REPLACE(estacion, '\\\\', ''))), '\\', ''), 
	carga, modelo, REVERSE(REPLACE(LEFT(REPLACE(REVERSE(estacion), '\\\\', ''), LOCATE('\\', REPLACE(REVERSE(estacion), '\\\\', ''))), '\\', '')), bps, ultimoz, lsa, detalonario, NOW(), 1 FROM pvs WHERE tipo=1 AND id_pv NOT IN (SELECT id_impresora FROM impresoras);

REPLACE INTO impresoras (id_impresora, nombre, id_sucursal, tipo, estacion, carga, fiscal_modelo, dispositivo, fiscal_bps, fiscal_ultimoz, lsa, talonario, fecha, estado)
	SELECT id_pv, CONCAT('PV ', numero), id_sucursal, tipo, estacion, carga, modelo, CONCAT('COM', puerto), bps, ultimoz, lsa, detalonario, NOW(), 1 FROM pvs WHERE tipo=2 AND id_pv NOT IN (SELECT id_impresora FROM impresoras);

REPLACE INTO documentos_tipos SET id_tipo=58, nombre='Listados', letra='Listado', imprimir_repetir=1;

REPLACE INTO impresoras (id_impresora, nombre, id_sucursal, tipo, estacion, carga, dispositivo, talonario, fecha, estado)
	VALUES (10, 'Vista Previa en Pantalla', NULL, 1, NULL, 0, 'lazaro!preview', 0, NOW(), 1);
REPLACE INTO impresoras (id_impresora, nombre, id_sucursal, tipo, estacion, carga, dispositivo, talonario, fecha, estado)
	VALUES (11, 'Predeterminada del Sistema', NULL, 1, NULL, 0, 'lazaro!default', 0, NOW(), 1);

UPDATE cajas SET nombre=REPLACE(nombre, 'Caja Diaria', 'Caja Efectivo');

SET FOREIGN_KEY_CHECKS=1;