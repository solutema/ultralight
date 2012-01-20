SET FOREIGN_KEY_CHECKS=0;

UPDATE comprob SET nombre=CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) WHERE nombre='';
UPDATE recibos SET nombre=CONCAT(LPAD(recibos.pv, 4, '0'), '-', LPAD(recibos.numero, 8, '0')) WHERE nombre='';

REPLACE INTO "documentos_tipos" ("id_tipo", "letra", "nombre", "obs", "estado", "fecha", "tabla", "tipo", "direc_ctacte", "mueve_stock", "situacionorigen", "situaciondestino", "numerar_guardar", "imprimir_guardar", "numerar_imprimir", "imprimir_repetir", "imprimir_modificar") VALUES
	(1, 'FA', 'Factura A', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(2, 'FB', 'Factura B', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(3, 'FC', 'Factura C', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1.0000, -1.0000, 1000, 999, 0, 0, 1, 1, 0),
	(4, 'FE', 'Factura E', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(5, 'FM', 'Factura M', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Factura', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(11, 'NCA', 'Nota de Crédito A', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(12, 'NCB', 'Nota de Crédito B', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(13, 'NCC', 'Nota de Crédito C', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(14, 'NCE', 'Nota de Crédito E', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(15, 'NCM', 'Nota de Crédito M', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeCredito', -1.0000, 1.0000, 999, 1, 0, 0, 1, 0, 0),
	(21, 'NDA', 'Nota de Débito A', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(22, 'NDB', 'Nota de Débito B', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(23, 'NDC', 'Nota de Débito C', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(24, 'NDE', 'Nota de Débito E', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(25, 'NDM', 'Nota de Débito M', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.NotaDeDebito', 1.0000, -1.0000, 1, 999, 0, 0, 1, 0, 0),
	(31, 'T', 'Ticket', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Ticket', 1.0000, 1.0000, 1, 999, 0, 0, 1, 0, 0),
	(41, 'R', 'Remito', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Remito', 0.0000, 1.0000, 1, 999, 0, 0, 1, 1, 0),
	(42, 'NV', 'Nota de Venta', NULL, 0, '0000-00-00 00:00:00', 'comprob', NULL, 0.0000, 0.0000, NULL, NULL, 0, 0, 1, 1, 0),
	(51, 'PS', 'Presupuesto', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Presupuesto', 0.0000, 0.0000, NULL, NULL, 1, 0, 1, 0, 1),
	(53, 'RC', 'Recibo de Cobro', NULL, 0, '0000-00-00 00:00:00', 'recibos', 'Lbl.Comprobantes.ReciboDeCobro', -1.0000, 0.0000, NULL, NULL, 1, 1, 0, 1, 0),
	(54, 'RCP', 'Recibo de Pago', NULL, 0, '0000-00-00 00:00:00', 'recibos', 'Lbl.Comprobantes.ReciboDePago', 1.0000, 0.0000, NULL, NULL, 1, 0, 0, 1, 0),
	(55, 'NP', 'Nota de Pedido', NULL, 0, '0000-00-00 00:00:00', 'comprob', NULL, 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 0, 0),
	(56, 'PD', 'Pedido', NULL, 0, '0000-00-00 00:00:00', 'comprob', 'Lbl.Comprobantes.Pedido', 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 0, 0),
	(58, 'Listado', 'Listados', NULL, 0, NULL, 'comprob', NULL, 0.0000, 0.0000, NULL, NULL, 0, 0, 0, 1, 0);

SET FOREIGN_KEY_CHECKS=1;