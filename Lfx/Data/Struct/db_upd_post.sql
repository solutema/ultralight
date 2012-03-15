SET FOREIGN_KEY_CHECKS=0;

UPDATE comprob SET nombre=CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) WHERE nombre='';
UPDATE recibos SET nombre=CONCAT(LPAD(recibos.pv, 4, '0'), '-', LPAD(recibos.numero, 8, '0')) WHERE nombre='';
UPDATE comprob SET cancelado=total WHERE tipo_fac IN ('R', 'NV', 'PS', 'NP', 'PD');
UPDATE sys_plantillas SET estado=1;
UPDATE documentos_tipos SET estado=1;
UPDATE articulos SET unidad_stock='u' WHERE unidad_stock='' OR unidad_stock IS NULL;
DELETE FROM sys_log WHERE comando='LogOff';
UPDATE sys_log SET comando='LogOn' WHERE comando='Logon';
UPDATE ciudades SET iva=1 WHERE id_ciudad=24;


REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "fecha", "signo", "iso", "cotizacion", "decimales") VALUES
	(1, 'Dólares', NULL, 1, NULL, 'USD', 'USD', 1.0000, 2),
	(2, 'Euros', NULL, 1, NULL, '€', 'EUR', 1.0000, 2),
	(3, 'Pesos Argentinos', NULL, 1, NULL, '$', 'ARS', 1.0000, 2),
	(4, 'Pesos Uruguayos', NULL, 1, NULL, '$', 'UYU', 1.0000, 2),
	(5, 'Pesos Chilenos', NULL, 1, NULL, '$', 'CLP', 1.0000, 0),
	(6, 'Reales', NULL, 1, NULL, 'R$', 'BRL', 1.0000, 2),
	(7, 'Guaraníes', NULL, 1, NULL, 'Gs', 'PYG', 1.0000, 2),
	(8, 'Pesos Bolivianos', NULL, 1, NULL, '$', 'BOB', 1.0000, 2),
	(9, 'Soles', NULL, 1, NULL, 'S/.', 'PEN', 1.0000, 2),
	(11, 'Pesos Colombianos', NULL, 1, NULL, '$', 'COP', 1.0000, 2),
	(12, 'Bolívares', NULL, 1, NULL, 'Bs', 'VEF', 1.0000, 2),
	(13, 'Colones de Costa Rica', NULL, 1, NULL, 'C', 'CRC', 1.0000, 2),
	(14, 'Pesos Cubanos', NULL, 1, NULL, 'P', 'CUP', 1.0000, 2),
	(15, 'Colones de El Salvador', NULL, 1, NULL, '$', 'SVC', 1.0000, 2),
	(16, 'Quetzales', NULL, 1, NULL, 'Q', 'GTQ', 1.0000, 2),
	(17, 'Pesos Mexicanos', NULL, 1, NULL, '$', 'MXN', 1.0000, 2),
	(18, 'Córdobas', NULL, 1, NULL, 'C$', 'NIO', 1.0000, 2),
	(19, 'Balboas', NULL, 1, NULL, 'B/.', 'PAB', 1.0000, 2),
	(20, 'Pesos Dominicanos', NULL, 1, NULL, 'RD$', 'DOP', 1.0000, 2),
	(21, 'Lempira ', NULL, 1, NULL, 'L', 'HNL', 1.0000, 2);


REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "fecha", "iso", "clavefis", "clavejur", "claveban", "id_moneda", "iva1", "iva2") VALUES
	(1, 'Argentina', NULL, 1, NULL, 'AR', 1, 6, 82, 3, 21.0000, 10.5000),
	(2, 'España', NULL, 1, NULL, 'ES', 1, 20, 81, 2, 18.0000, 8.0000),
	(3, 'Chile', NULL, 1, NULL, 'CL', 4, 16, 80, 5, 19.0000, 0.0000),
	(4, 'México', NULL, 1, NULL, 'MX', 8, 24, 83, 17, 16.0000, 11.0000),
	(5, 'Uruguay', NULL, 1, NULL, 'UY', 4, 19, 80, 4, 22.0000, 10.0000),
	(6, 'Paraguay', NULL, 1, NULL, 'PY', 4, NULL, 80, 7, 10.0000, 5.0000),
	(7, 'Bolivia', NULL, 1, NULL, 'BO', 4, 14, 80, 8, 13.0000, 0.0000),
	(8, 'Colombia', NULL, 1, NULL, 'CO', 10, 14, 80, 11, 16.0000, 1.0000),
	(9, 'Venezuela', NULL, 1, NULL, 'VE', 4, 15, 80, 12, 12.0000, 8.0000),
	(10, 'Ecuador', NULL, 1, NULL, 'EC', 4, 25, 80, 1, 12.0000, 0.0000),
	(11, 'Perú', NULL, 1, NULL, 'PE', 1, 25, 80, 9, 18.0000, 0.0000),
	(12, 'Panamá', NULL, 1, NULL, 'PA', 4, 25, 80, 19, 7.0000, 0.0000),
	(13, 'Guatemala', NULL, 1, NULL, 'GT', 12, 26, 80, 16, 12.0000, 0.0000),
	(14, 'El Salvador', NULL, 1, NULL, 'SV', 11, 14, 80, 15, 13.0000, 0.0000),
	(15, 'República Dominicana', NULL, 1, NULL, 'DO', 9, 18, 80, 20, 16.0000, 0.0000),
	(16, 'Cuba', NULL, 1, NULL, 'CU', NULL, NULL, 80, 14, 0.0000, 0.0000),
	(17, 'Brazil', NULL, 1, NULL, 'BR', 4, 27, 80, 6, 18.0000, 7.0000),
	(18, 'Costa Rica', NULL, 1, NULL, 'CR', 4, NULL, 80, 13, 13.0000, 0.0000),
	(19, 'Honduras', NULL, 1, NULL, 'HN', 4, NULL, 80, 21, 12.0000, 0.0000),
	(20, 'Nicaragua', NULL, 1, NULL, 'NI', 4, NULL, 80, 18, 15.0000, 0.0000),
	(99, 'Estados Unidos', NULL, 1, NULL, 'US', 22, 23, 80, 1, 0.0000, 0.0000);

REPLACE INTO "documentos_tipos" ("id_tipo", "letra", "letrasola", "nombre", "nombrelargo", "obs", "estado", "fecha", "tabla", "tipo", "venta", "compra", "permitedisciva", "siempredisciva", "cargapapel", "direc_ctacte", "mueve_stock", "situacionorigen", "situaciondestino", "numerar_guardar", "imprimir_guardar", "numerar_imprimir", "imprimir_repetir", "imprimir_modificar") VALUES
	(1, 'FA', 'A', 'Factura A', 'Factura A', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(2, 'FB', 'B', 'Factura B', 'Factura B', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(3, 'FC', 'C', 'Factura C', 'Factura C', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1000, 999, 0, 0, 1, 1, 0),
	(4, 'FE', 'E', 'Factura E', 'Factura E', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(5, 'FM', 'M', 'Factura M', 'Factura M', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(11, 'NCA', 'A', 'Nota créd. A', 'Nota de crédito A', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', 1, 1, 0, 0, 1, -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(12, 'NCB', 'B', 'Nota créd. B', 'Nota de crédito B', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', 1, 1, 0, 0, 1, -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(13, 'NCC', 'C', 'Nota créd. C', 'Nota de crédito C', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', 1, 1, 0, 0, 1, -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(14, 'NCE', 'E', 'Nota créd. E', 'Nota de crédito E', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', 1, 1, 0, 0, 1, -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(15, 'NCM', 'M', 'Nota créd. M', 'Nota de crédito M', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', 1, 1, 0, 0, 1, -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(21, 'NDA', 'A', 'Nota déb. A', 'Nota de débito A', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(22, 'NDB', 'B', 'Nota déb. B', 'Nota de débito B', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(23, 'NDC', 'C', 'Nota déb. C', 'Nota de débito C', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(24, 'NDE', 'E', 'Nota déb. E', 'Nota de débito E', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(25, 'NDM', 'M', 'Nota déb. M', 'Nota de débito M', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1, 1, 0, 0, 1, 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(31, 'T', '', 'Ticket', 'Ticket', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Ticket', 1, 1, 0, 0, 0, 1.0000, 1.0000, 1, 999, 0, 0, 1, 0, 0),
	(41, 'R', '', 'Remito', 'Remito', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Remito', 1, 1, 0, 0, 1, 0.0000, 1.0000, 1, 999, 0, 0, 1, 1, 0),
	(42, 'NV', '', 'Nota de venta', 'Nota de venta', NULL, 1, '0000-00-00 00:00:00', 'comprob', NULL, 1, 1, 0, 0, 0, 0.0000, 0.0000, NULL, NULL, 0, 0, 1, 1, 0),
	(51, 'PS', '', 'Presupuesto', 'Presupuesto', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Presupuesto', 1, 1, 0, 0, 0, 0.0000, 0.0000, NULL, NULL, 1, 0, 1, 0, 1),
	(53, 'RC', '', 'Recibo de cobro', 'Recibo de cobro', NULL, 1, '0000-00-00 00:00:00', 'recibos', 'Lbl.Comprobantes.ReciboDeCobro', 1, 0, 0, 0, 0, -1.0000, 0.0000, NULL, NULL, 1, 1, 0, 1, 0),
	(54, 'RCP', '', 'Recibo de pago', 'Recibo de pago', NULL, 1, '0000-00-00 00:00:00', 'recibos', 'Lbl.Comprobantes.ReciboDePago', 1, 0, 0, 0, 0, 1.0000, 0.0000, NULL, NULL, 1, 0, 0, 1, 0),
	(55, 'NP', '', 'Nota de pedido', 'Nota de pedido', NULL, 1, '0000-00-00 00:00:00', 'comprob', NULL, 1, 1, 0, 0, 0, 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 0, 0),
	(56, 'PD', '', 'Pedido', 'Pedido', NULL, 1, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Pedido', 1, 1, 0, 0, 0, 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 0, 0),
	(58, 'Listado', '', 'Listados', 'Listados', NULL, 1, NULL, 'comprob', NULL, 1, 0, 0, 0, 0, 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 1, 0);

START TRANSACTION WITH CONSISTENT SNAPSHOT;
INSERT INTO sys_log (fecha, estacion, usuario, comando, tabla, item_id, extra1) SELECT fecha, '', id_persona, 'Comment', tablas, item_id, obs FROM sys_comments;
DELETE FROM sys_comments;
COMMIT;
UPDATE sys_log SET tabla=NULL WHERE comando='LogOn' OR comando='LogOnFail';

SET FOREIGN_KEY_CHECKS=1;