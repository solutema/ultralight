
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (1, 'Río Grande', 'V9420', 35, 5043);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (2, 'Tolhuin', 'V9420', 35, 5046);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (3, 'Ushuaia', 'V9410', 35, 5048);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (6, 'La Plata', 'B1900', 14, 26324);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (7, 'Ciudad Autónoma de Buenos Aires', 'C1000', 13, 5001);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (8, 'Rosario', 'S2000', 33, 20949);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (9, 'Río Gallegos', 'Z9400', 32, 6286);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (10, 'Mar del Plata', 'B7600', 14, 20900);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (11, 'Mendoza', 'M5500', 25, 5495);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (12, 'Viedma', 'R8500', 28, 13268);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (13, 'Capital Federal', 'C', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (14, 'Buenos Aires', 'B', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (15, 'Catamarca', 'K', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (16, 'Chaco', 'H', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (17, 'Chubut', 'U', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (18, 'Córdoba', 'X', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (19, 'Corrientes', 'W', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (20, 'Entre Ríos', 'E', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (21, 'Formosa', 'P', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (22, 'Jujuy', 'Y', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (23, 'La Pampa', 'L', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (24, 'La Rioja', 'F', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (25, 'Mendoza', 'M', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (26, 'Misiones', 'N', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (27, 'Neuquén', 'Q', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (28, 'Río Negro', 'R', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (29, 'Salta', 'A', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (30, 'San Juan', 'J', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (31, 'San Luis', 'D', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (32, 'Santa Cruz', 'Z', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (33, 'Santa Fe', 'S', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (34, 'Santiago del Estero', 'G', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (35, 'Tierra del Fuego', 'V', NULL, 0);
INSERT INTO ciudades (id_ciudad, nombre, cp, parent, ca) VALUES (36, 'Tucumán', 'T', NULL, 0);


INSERT INTO monedas (id_moneda, nombre, signo, cotizacion) VALUES (1, 'Dólares', 'USD', 1);
INSERT INTO monedas (id_moneda, nombre, signo, cotizacion) VALUES (2, 'Euros', 'E', 0.7972);
INSERT INTO monedas (id_moneda, nombre, signo, cotizacion) VALUES (3, 'Pesos', '$', 2.92);

INSERT INTO alicuotas (id_alicuota, porcentaje, nombre) VALUES (1, 21, 'IVA 21%');
INSERT INTO alicuotas (id_alicuota, porcentaje, nombre) VALUES (2, 10.5, 'IVA 10.5%');

INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (1, 'DNI');
INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (2, 'LE');
INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (3, 'LC');
INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (4, 'CI');
INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (5, 'CUIL');
INSERT INTO tipo_doc (id_tipo_doc, nombre) VALUES (6, 'CUIT');

INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (1, 'Cliente');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (2, 'Proveedor');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (3, 'Cliente y Proveedor');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (4, 'Usuario del Sistema');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (5, 'Cliente y Usuario del Sistema');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (6, 'Proveedor y Usuario del Sistema');
INSERT INTO personas_tipos (id_tipo_persona, nombre) VALUES (7, 'Cliente, Proveedor y Usuario del Sistema');

INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (1, 'Consumidor Final', 'CF', 'B', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (2, 'Responsable Inscripto', 'RI', 'A', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (3, 'Responsable No Inscripto', 'NI', 'A', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (4, 'Responsable Monotributista', 'M', 'B', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (5, 'Exento', 'EX', 'B', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (6, 'No Resposable', 'NR', 'B', 'C');
INSERT INTO situaciones (id_situacion, nombre, abrev, comprob, comprob2) VALUES (7, 'No Categorizado', 'NC', 'B', 'C');

INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (1, 'Depósito 1', 1, 1, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (2, 'Depósito 2', 1, 2, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (3, 'Depósito 3', 1, 3, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (4, 'Depósito 4', 1, 4, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (5, 'Depósito 5', 1, 5, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (997, 'Scrap', 0, 0, 0);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (998, 'Proveedor', 0, 0, 0);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (999, 'Cliente', 0, 0, 0);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (1000, 'Producción', 0, 0, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (1001, 'Reparación/Devolución/RMA', 0, 0, 0);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (1002, 'Exposición', 1, 0, 1);
INSERT INTO articulos_situaciones (id_situacion, nombre, cuenta_stock, deposito, facturable) VALUES (1003, 'Préstamo/Comodato', 0, 0, 1);

INSERT INTO bancos (id_banco, nombre, estado) VALUES (1, 'Banco de la Nación Argentina', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (2, 'Banco Macro / Bansud', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (3, 'Banco Francés', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (4, 'Banco HSBC / BNL', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (5, 'Banco Santander Río', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (6, 'Banco Galicia', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (7, 'Banco de la Provincia de Buenos Aires', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (8, 'Banco Credicoop Coop. Ltda.', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (9, 'Banco Itaú', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (10, 'Banco Ciudad de Buenos Aires', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (11, 'Banco del Buen Ayre', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (12, 'Banco Central de la República Argentina', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (13, 'Banco Suquia', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (14, 'Banco Privado de Inversiones S.A.', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (15, 'Banque Nationale de Paris', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (16, 'Banco General de Negocios', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (17, 'Banco Hipotecario', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (18, 'Citibank', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (19, 'Banco de la República Oriental del Uruguay', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (20, 'Banco do Brasil', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (21, 'Banco Société Générale', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (22, 'BankBoston', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (23, 'HSBC Bank Argentina', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (24, 'Banco Patagonia', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (25, 'The Bank of New York', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (26, 'Banco Santa Cruz', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (99, 'Otro', 1);
INSERT INTO bancos (id_banco, nombre, estado) VALUES (100, 'Banco de la Provincia de Tierra del Fuego', 1);

INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (10000,'Ingresos',0,100,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (11000,'Ingresos por facturación',0,110,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (12000,'Ingresos por créditos recibidos',0,100,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (13000,'Ingresos por intereses ganados',0,100,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (13010,'Ingresos por comisiones ganadas',0,100,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (14000,'Ingresos por aportes de socio',0,100,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (20000,'Egresos',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (21000,'Compra de mercaderías / materias primas',0,210,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (22000,'Compra de bienes de uso',0,220,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (22010,'Compra de inmuebles',0,220,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (22020,'Compra de vehículos',0,220,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (22030,'Compra de maquinaria y herramientas',0,220,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23000,'Gastos fijos',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23010,'Salarios',0,231,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23015,'Comisiones por ventas',0,231,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23020,'Impuestos por ventas',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23030,'Impuestos varios',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23040,'Aportes y cargas por salarios',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23050,'Servicios',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23060,'Alquileres',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23070,'Gastos bancarios',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23080,'Publicidad',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23090,'Mantenimiento de inmuebles',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23100,'Mantenimiento de vehículos',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23110,'Mantenimiento de maquinarias y herramientas',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23120,'Seguros',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23990,'Retiro de socio',0,230,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (24000,'Gastos variables',0,240,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (24010,'Gestión de cobro',0,240,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (24100,'Elementos e insumos de trabajo',0,240,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25000,'Gastos varios',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25010,'Transporte de personas y combustible',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25011,'Transporte de cargas',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25020,'Donaciones',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25030,'Papelería',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25040,'Intereses pagados',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25050,'Refrigerios',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25060,'Gastos de representación',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (25070,'Pago de créditos',0,200,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (26000,'Pérdidas',0,260,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (26010,'Redondeos',0,260,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (26020,'Mercadería defectuosa, vencida o dañada',0,260,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (26030,'Devoluciones',0,260,1);
INSERT INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (30000,'Ajustes y movimientos',0,300,1);

insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('1','Factura A','A','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('2','Factura B','B','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('3','Factura C','C','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('4','Factura E','E','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('5','Factura M','M','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('11','Nota de Crédito A','NCA','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('12','Nota de Crédito B','NCB','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('13','Nota de Crédito C','NCC','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('14','Nota de Crédito E','NCE','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('15','Nota de Crédito M','NCM','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('21','Nota de Débito A','NDA','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('22','Nota de Débito B','NDB','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('23','Nota de Débito C','NDC','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('24','Nota de Débito E','NDE','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('25','Nota de Débito M','NDM','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('31','Ticket','T','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('41','Remito','R','1','1','999','0','1','1','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('51','Presupuesto','PS','0',NULL,NULL,'1','1','0','1');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('53','Recibo de Cobro','RC','0',NULL,NULL,'1','0','1','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('54','Recibo de Pago','RCP','0',NULL,NULL,'0','0','1','0');

INSERT INTO formaspago (id_formapago, nombre, estado) VALUES (1, 'Efectivo', 1);
INSERT INTO formaspago (id_formapago, nombre, estado) VALUES (2, 'Cheque', 1);
INSERT INTO formaspago (id_formapago, nombre, estado) VALUES (3, 'Cuenta Corriente', 1);
INSERT INTO formaspago (id_formapago, nombre, estado) VALUES (4, 'Tarjeta', 1);
INSERT INTO formaspago (id_formapago, nombre, estado) VALUES (6, 'Depósito en Cuenta', 1);

INSERT INTO margenes (id_margen, nombre, sumar, porcentaje, porcentaje2, porcentaje3, sumar2, predet, obs, estado) VALUES (1, '0%', 0, 0, 0, 0, 0, 0, '', 1);
INSERT INTO margenes (id_margen, nombre, sumar, porcentaje, porcentaje2, porcentaje3, sumar2, predet, obs, estado) VALUES (2, '30%', 0, 30, 0, 0, 0, 1, '', 1);
INSERT INTO margenes (id_margen, nombre, sumar, porcentaje, porcentaje2, porcentaje3, sumar2, predet, obs, estado) VALUES (3, '40%', 0, 40, 0, 0, 0, 0, '', 1);
INSERT INTO margenes (id_margen, nombre, sumar, porcentaje, porcentaje2, porcentaje3, sumar2, predet, obs, estado) VALUES (4, '50%', 0, 50, 0, 0, 0, 0, '', 1);
INSERT INTO margenes (id_margen, nombre, sumar, porcentaje, porcentaje2, porcentaje3, sumar2, predet, obs, estado) VALUES (5, '100%', 0, 100, 0, 0, 0, 0, '', 1);

INSERT INTO tickets_estados VALUES (1, 'Nuevo');
INSERT INTO tickets_estados VALUES (5, 'Activo');
INSERT INTO tickets_estados VALUES (10, 'Presupuestado');
INSERT INTO tickets_estados VALUES (20, 'Iniciado');
INSERT INTO tickets_estados VALUES (25, 'Reabierto');
INSERT INTO tickets_estados VALUES (30, 'Terminado');
INSERT INTO tickets_estados VALUES (35, 'Terminado sin Aprobar');
INSERT INTO tickets_estados VALUES (40, 'Verificado');
INSERT INTO tickets_estados VALUES (50, 'Entregado');
INSERT INTO tickets_estados VALUES (80, 'Abandonado');
INSERT INTO tickets_estados VALUES (90, 'Cancelado');

INSERT INTO tickets_tipos VALUES (1, 'Cita', '', 1);
INSERT INTO tickets_tipos VALUES (2, 'Reunión', '', 1);
INSERT INTO tickets_tipos VALUES (99, 'Otra', '', 1);









INSERT INTO personas (id_persona, tipo, id_grupo, vendedor, nombre, apellido, razon_social, nombre_visible, contrasena, id_tipo_doc, num_doc, cuit, id_situacion, domicilio, id_ciudad, telefono, email, tipo_fac, obs, estado) VALUES (1, 4, NULL, 1, 'Administrador', '', '', 'Administrador', 'admin', NULL, '', '', 1, '', NULL, '', '', '', '', 1);
INSERT INTO personas (id_persona, tipo, id_grupo, vendedor, nombre, apellido, razon_social, nombre_visible, contrasena, id_tipo_doc, num_doc, cuit, id_situacion, domicilio, id_ciudad, telefono, email, tipo_fac, obs, estado) VALUES (999, 1, NULL, 0, '', '', '', 'Consumidor Final', '', NULL, '', '', 1, '', NULL, '', '', '', '', 1);

INSERT INTO articulos_codigos (id_codigo, nombre, id_proveedor) VALUES (1, 'Código 1', NULL);
INSERT INTO articulos_codigos (id_codigo, nombre, id_proveedor) VALUES (2, 'Código 2', NULL);
INSERT INTO articulos_codigos (id_codigo, nombre, id_proveedor) VALUES (3, 'Código 3', NULL);
INSERT INTO articulos_codigos (id_codigo, nombre, id_proveedor) VALUES (4, 'Código 4', NULL);

INSERT INTO cuentas (id_cuenta, id_banco, numero, nombre, tipo, id_moneda) VALUES (999, NULL, '', 'Caja Diaria', 0, 3);
INSERT INTO cuentas (id_cuenta, id_banco, numero, nombre, tipo, id_moneda) VALUES (1000, NULL, '', 'Cheques', 0, 3);
INSERT INTO cuentas (id_cuenta, id_banco, numero, nombre, tipo, id_moneda) VALUES (1001, NULL, '', 'Dólares', 0, 1);

INSERT INTO sucursales (id_sucursal, nombre, id_ciudad, id_cuenta_caja, id_cuenta_cheques) VALUES (1, 'Sucursal 1', 1, 999, 1001);


insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('accounts','Cuentas','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('accounts.admin','Administrar cuentas','1','accounts');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('accounts.read','Ver cuentas','2','accounts');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('accounts.write','Hacer movimientos','2','accounts');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('ctacte','Cuentas corrientes','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('ctacte.read','Ver cuentas corrientes','2','ctacte');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('ctacte.write','Hacer movimientos','2','ctacte');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('documents','Comprobantes','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('documents.create','Crear comprobantes','2','documents');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('documents.print','Imprimir comprobantes','2','documents');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('documents.read','Ver comprobantes','2','documents');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('documents.write','Modificar comprobantes','2','documents');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('global','General','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('global.admin','Administrar el sistema','1','global');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('global.backup','Copias de respaldo','1','global');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('global.total','Acceso total','1','global');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('people','Personas','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('people.access','Editar permisos','1','people');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('people.create','Crear personas','2','people');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('people.read','Ver personas','2','people');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('people.write','Modificar personas','2','people');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('products','Artículos','0',NULL);
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('products.create','Crear artículos','2','products');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('products.read','Ver artículos','2','products');
insert into "sys_accessbase" ("id_acceso", "nombre", "tipo", "parent") values('products.write','Modificar artículos','2','products');
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('bancos', 'Bancos', 0, NULL);
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.read', 'Ver chequeras', 1, 'bancos');
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.create', 'Crear chequeras', 1, 'bancos');
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.write', 'Modificar chequeras', 1, 'bancos');


INSERT INTO "sys_accesslist" VALUES ('global.total', '1', '*');


insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('1','1','Mastercard','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('2','1','Visa','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('3','1','American Express','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('4','1','Carta Franca','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('5','1','Cabal','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('6','1','Naranja','5.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('7','2','Visa Electrón','0.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('8','2','Maestro','0.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('98','2','Otra Tarjeta de Débito','0.0000','0',NULL,'21');
insert into "tarjetas" ("id_tarjeta", "credeb", "nombre", "comision", "autoacred", "id_cuenta", "dias_normal") values('99','1','Otra Tarjeta de Crédito','5.0000','0',NULL,'21');


insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(1,NULL,'1 cuota sin interés','1','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(2,NULL,'2 cuotas sin interés','2','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(3,NULL,'3 cuotas sin interés','3','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(4,NULL,'4 cuotas','4','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(5,NULL,'5 cuotas','5','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(6,NULL,'6 cuotas sin interés','6','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(7,NULL,'7 cuotas','7','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(8,NULL,'8 cuotas','8','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(9,NULL,'9 cuotas sin interés','9','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(11,NULL,'11 cuotas','11','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(12,NULL,'12 cuotas sin interés','12','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(99,NULL,'Desconocido','1','0.00000000','0.00000000');
insert into "tarjetas_planes" ("id_plan", "id_tarjeta", "nombre", "cuotas", "interes", "comision") values(100,NULL,'Plan Zeta','0','0.00000000','0.00000000');


INSERT INTO pvs (id_pv, id_sucursal, tipo, estacion) VALUES (1, 1, 1, '');


INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Empresa.CUIT', '00-00000000-0', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Empresa.Nombre', 'Nombre de la Empresa', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Empresa.Situacion', '2', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Moneda.Decimales', '2', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Moneda.DecimalesCosto', '2', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Moneda.DecimalesFinal', '2', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Moneda.Redondeo', '0', '0.05');
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Stock.CodigoPredet', '1', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Stock.Decimales', '0', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Stock.DepositoPredet', '1', 0);
INSERT INTO sys_config (estacion, grupo, nombre, valor, id_sucursal) VALUES ('*', '', 'Sistema.Stock.Multideposito', '1', 0);

INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (2,NULL,2,'&Artículos','','articulos',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (3,NULL,3,'&Personas','','personas',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (4,NULL,4,'C&omprobantes','','comprob',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (5,NULL,5,'C&uentas','','cuentas',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (7,NULL,7,'&Tareas','','tickets',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (11,NULL,98,'&Varios','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (17,3,1,'&Clientes','LISTADO CLIENTES','inicio',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (18,3,2,'Nuevo Cliente','CREAR CLIENTE','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (19,4,1,'&Facturas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (20,4,3,'&Presupuestos','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (21,4,2,'&Notas de Crédito y Débito','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (22,4,4,'&Recibos','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (23,19,2,'Listado Facturas &A','LISTADO COMPROBANTES F A','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (24,19,5,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (25,19,6,'&Nueva Factura','CREAR B','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (27,19,9,'&Anular','ANULAR FACTURA','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (28,20,1,'&Listado','LISTADO COMPROBANTES PS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (29,20,2,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (30,20,3,'&Nuevo','CREAR PS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (31,22,1,'&Listado','LISTADO RECIBOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (32,22,2,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (33,22,3,'Nuevo Recibo de Cobro','CREAR RECIBO','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (34,5,1,'Caja &Diaria','CAJA','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (35,5,2,'&Cuentas Corrientes','CTACTE','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (36,5,5,'Cupones de &Tarjetas','TARJETAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (37,5,3,'T&odas las Cuentas','CUENTAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (41,7,1,'&Listado','LISTADO TICKETS','inicio',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (42,7,3,'&Nueva','CREAR TICKET','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (53,19,3,'Listado Facturas &B','LISTADO COMPROBANTES F B','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (54,19,8,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (55,21,1,'Listado Notas de &Crédito','LISTADO COMPROBANTES NC *','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (56,21,2,'Listado Notas de &Débito','LISTADO COMPROBANTES ND *','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (57,19,1,'&Listado Facturas','LISTADO COMPROBANTES F *','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (60,7,4,'No&vedad','CREAR TICKET NOVEDAD','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (61,7,5,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (70,21,3,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (71,21,4,'&Nueva Nota de Crédito/Débito','CREAR NCB','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (76,5,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (77,5,4,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (78,5,6,'C&heques','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (79,138,1,'&Ciudades','LISTADO CIUDADES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (80,4,5,'Re&mitos','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (81,80,1,'&Listado','LISTADO COMPROBANTES R','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (82,80,3,'&Nuevo','CREAR R','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (83,80,2,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (84,133,2,'Conceptos','LISTADO CONCEPTOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (90,3,4,'&Proveedores','LISTADO PROVEEDORES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (91,3,5,'Nuevo Proveedor','CREAR PROVEEDOR','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (92,3,3,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (93,11,1,'Reporte de Ingresos y Gastos','REPORTE RENTABILIDAD','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (95,7,2,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (98,2,1,'&Listado','LISTADO ARTICULOS','inicio',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (99,2,2,'&Nuevo','CREAR ARTICULO','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (100,2,3,'&Entrada y Salida','MOVIM ARTICULOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (101,2,5,'&Manejo de Pedidos','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (102,2,4,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (103,143,1,'&Rubros','LISTADO ARTICULOS_RUBROS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (104,143,2,'&Categorías','LISTADO ARTICULOS_CATEG','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (105,143,3,'&Marcas','LISTADO MARCAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (106,2,99,'&Ticker','TICKER MOSTRADOR','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (109,101,2,'&Pedidos','LISTADO PEDIDOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (110,101,3,'&Remitos de Compra','LISTADO RP','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (111,101,4,'&Facturas de Compra','LISTADO FP','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (112,101,1,'&Notas de Pedido','LISTADO NP','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (113,101,5,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (114,101,6,'Artículos a Pedir','LISTADO ARTICULOS APEDIR','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (115,101,7,'Artículos Pedidos','LISTADO ARTICULOS PEDIDOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (116,138,2,'Sucursales','LISTADO SUCURSALES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (121,138,3,'Puntos de Venta','LISTADO PVS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (122,19,7,'Nuevo &Ticket','CREAR T','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (123,19,4,'Listado Tickets','LISTADO COMPROBANTES T','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (126,76,4,'Chequeras','LISTADO CHEQUERAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (127,78,2,'&Emitidos','LISTADO CHEQUES EMITIDOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (128,3,6,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (129,3,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (130,78,1,'&Recibidos','LISTADO CHEQUES RECIBIDOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (133,5,7,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (134,22,3,'&Recibo Rápido','CREAR RECIBO_RAPIDO','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (135,4,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (136,22,4,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (137,22,5,'Nuevo Recibo de Pago','CREAR RECIBO_PAGO','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (138,11,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (139,76,3,'Bancos','LISTADO BANCOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (140,76,5,'Tarjetas','LISTADO TARJETAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (141,76,6,'Planes de Tarjetas','LISTADO PLANES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (142,2,6,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (143,2,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (144,143,4,'&Alícuotas','LISTADO ALICUOTAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (145,143,5,'Már&genes','LISTADO MARGENES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (146,143,6,'Situaciones y Depósitos','LISTADO SITUACIONES','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (147,129,1,'&Grupos','LISTADO PERSONAS_GRUPOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (148,135,1,'&Plantillas','LISTADO PLANTILLAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (149,135,2,'&Tipos de Comprobante','LISTADO TIPO_FAC','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (150,133,1,'Cuentas','LISTADO CUENTAS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (151,76,2,'Conceptos','LISTADO CUENTAS_CONCEPTOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (152,5,8,'&Vencimientos','LISTADO VENCIMIENTOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (153,5,9,'-','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (154,7,99,'Tablas','','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (155,154,1,'&Tipos de Tarea','LISTADO TICKETS_TIPOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (156,154,2,'&Estados','LISTADO TICKETS_ESTADOS','',1);
INSERT INTO "sys_menu" ("id_menu","parent","orden","nombre","funcion","web","visible") values (157,76,1,'Cuentas','LISTADO CUENTAS','',1);


INSERT INTO sys_plantillas (id_plantilla,codigo,nombre,definicion,tamanopapel,landscape,copias,membrete,defxml) VALUES (1,'*','Comprobante Predeterminado','','a4',0,1,0,'<Plantilla Copias=\"1\" Membrete=\"0\" Fuente=\"Bitstream Vera Sans\" TamanoFuente=\"10\"><Campo Valor=\"{Fecha}\" X=\"1850\" Y=\"136\" Ancho=\"320\" Alto=\"52\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente}\" X=\"300\" Y=\"436\" Ancho=\"1380\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{FormaPago}\" X=\"1910\" Y=\"466\" Ancho=\"510\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente.Domicilio}\" X=\"300\" Y=\"520\" Ancho=\"1410\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{IVA}\" X=\"300\" Y=\"572\" Ancho=\"870\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{CUIT}\" X=\"1910\" Y=\"532\" Ancho=\"520\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Total}\" X=\"1850\" Y=\"1534\" Ancho=\"570\" Alto=\"76\" Alineacion=\"Center\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Detalles}\" X=\"320\" Y=\"700\" Ancho=\"1420\" Alto=\"730\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cantidades}\" X=\"50\" Y=\"700\" Ancho=\"110\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Importes}\" X=\"2000\" Y=\"700\" Ancho=\"400\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{SonPesos}\" X=\"50\" Y=\"1550\" Ancho=\"1740\" Alto=\"130\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Precios}\" X=\"1600\" Y=\"700\" Ancho=\"390\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{espejo}\" X=\"0\" Y=\"1740\" Ancho=\"2480\" Alto=\"1830\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /></Plantilla>');
INSERT INTO sys_plantillas (id_plantilla,codigo,nombre,definicion,tamanopapel,landscape,copias,membrete,defxml) VALUES (2,'R','Remito','','a4',0,1,0,'<Plantilla Copias=\"1\" Membrete=\"0\" Fuente=\"Bitstream Vera Sans\" TamanoFuente=\"10\"><Campo Valor=\"{Fecha}\" X=\"1850\" Y=\"136\" Ancho=\"320\" Alto=\"52\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente}\" X=\"300\" Y=\"436\" Ancho=\"1380\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{FormaPago}\" X=\"1910\" Y=\"466\" Ancho=\"510\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente.Domicilio}\" X=\"300\" Y=\"520\" Ancho=\"1410\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{IVA}\" X=\"300\" Y=\"572\" Ancho=\"870\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{CUIT}\" X=\"1910\" Y=\"532\" Ancho=\"520\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Total}\" X=\"1850\" Y=\"1534\" Ancho=\"570\" Alto=\"76\" Alineacion=\"Center\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Detalles}\" X=\"320\" Y=\"700\" Ancho=\"1420\" Alto=\"730\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cantidades}\" X=\"50\" Y=\"700\" Ancho=\"110\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Importes}\" X=\"2000\" Y=\"700\" Ancho=\"400\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{SonPesos}\" X=\"50\" Y=\"1550\" Ancho=\"1740\" Alto=\"130\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Precios}\" X=\"1600\" Y=\"700\" Ancho=\"390\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{espejo}\" X=\"0\" Y=\"1740\" Ancho=\"2480\" Alto=\"1830\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /></Plantilla>');
INSERT INTO sys_plantillas (id_plantilla,codigo,nombre,definicion) values (3,'RC','Recibo','<Plantilla Copias="1" Membrete="0" Fuente="Bitstream Vera Serif" TamanoFuente="10"><Campo Valor="Recibo Nº {Numero}" X="70" Y="320" Ancho="1600" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Serif" TamanoFuente="18" /><Campo Valor="{Valores}" X="70" Y="790" Ancho="1600" Alto="600" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Sans Mono" TamanoFuente="9" /><Campo Valor="Recibimos de: {Cliente}" X="70" Y="550" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="La cantidad de: {Total}" X="70" Y="720" Ancho="1600" Alto="70" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="-8355712" ColorFondo="-2368553" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Fecha: {Fecha}" X="70" Y="490" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Empresa}" X="80" Y="70" Ancho="1580" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="-1053468" ColorTexto="-6862080" Wrap="0" Fuente="Bitstream Vera Sans" TamanoFuente="18" /><Campo Valor="{Empresa.Domicilio} - Tel. {Empresa.Telefono} - {Empresa.Ciudad}" X="80" Y="220" Ancho="1580" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Son pesos {SonPesos}.-" X="70" Y="1430" Ancho="1600" Alto="150" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="CUIT/DNI: {Cliente.Documento}" X="70" Y="620" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="70" Y="60" Ancho="1600" Alto="240" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="5" ColorBorde="-32768" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Vendedor}" X="870" Y="2280" Ancho="800" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="870" Y="2260" Ancho="800" Alto="1" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-16777216" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{espejo}" X="1670" Y="0" Ancho="1830" Alto="2500" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="En concepto de: {concepto}" X="70" Y="1610" Ancho="1600" Alto="380" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /></Plantilla>');
INSERT INTO sys_plantillas (id_plantilla,codigo,nombre,definicion) values (4,'RCP','Recibo de Pago','<Plantilla Copias="1" Membrete="0" Fuente="Bitstream Vera Serif" TamanoFuente="10"><Campo Valor="Recibo Nº {Numero}" X="70" Y="320" Ancho="1600" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Serif" TamanoFuente="18" /><Campo Valor="{Valores}" X="70" Y="790" Ancho="1600" Alto="600" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Sans Mono" TamanoFuente="9" /><Campo Valor="Recibimos de: {Cliente}" X="70" Y="550" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="La cantidad de: {Total}" X="70" Y="720" Ancho="1600" Alto="70" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="-8355712" ColorFondo="-2368553" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Fecha: {Fecha}" X="70" Y="490" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Empresa}" X="80" Y="70" Ancho="1580" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="-1053468" ColorTexto="-6862080" Wrap="0" Fuente="Bitstream Vera Sans" TamanoFuente="18" /><Campo Valor="{Empresa.Domicilio} - Tel. {Empresa.Telefono} - {Empresa.Ciudad}" X="80" Y="220" Ancho="1580" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Son pesos {SonPesos}.-" X="70" Y="1430" Ancho="1600" Alto="150" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="CUIT/DNI: {Cliente.Documento}" X="70" Y="620" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="70" Y="60" Ancho="1600" Alto="240" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="5" ColorBorde="-32768" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Vendedor}" X="870" Y="2280" Ancho="800" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="870" Y="2260" Ancho="800" Alto="1" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-16777216" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{espejo}" X="1670" Y="0" Ancho="1830" Alto="2500" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="En concepto de: {concepto}" X="70" Y="1610" Ancho="1600" Alto="380" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /></Plantilla>');


INSERT INTO "sys_tags" ("fieldtype", "label", "fieldname", "tablename", "id_tag", "fieldnullable", "fielddefault") VALUES ('text','Extra1','extra1','personas','1','0',NULL);

