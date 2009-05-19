SET FOREIGN_KEY_CHECKS=0;
UPDATE recibos SET tipo_fac='RC';

REPLACE INTO "sys_plantillas" ("id_plantilla","codigo","nombre","definicion","tamanopapel","landscape","copias","membrete","defxml") VALUES (9,'*','Comprobante Predeterminado','','a4',0,1,0,'<Plantilla Copias=\"1\" Membrete=\"0\" Fuente=\"Bitstream Vera Sans\" TamanoFuente=\"10\"><Campo Valor=\"{Fecha}\" X=\"1850\" Y=\"136\" Ancho=\"320\" Alto=\"52\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente}\" X=\"300\" Y=\"436\" Ancho=\"1380\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{FormaPago}\" X=\"1910\" Y=\"466\" Ancho=\"510\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cliente.Domicilio}\" X=\"300\" Y=\"520\" Ancho=\"1410\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{IVA}\" X=\"300\" Y=\"572\" Ancho=\"870\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{CUIT}\" X=\"1910\" Y=\"532\" Ancho=\"520\" Alto=\"64\" Alineacion=\"Near\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Total}\" X=\"1850\" Y=\"1534\" Ancho=\"570\" Alto=\"76\" Alineacion=\"Center\" AlineacionRenglon=\"Center\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Detalles}\" X=\"320\" Y=\"700\" Ancho=\"1420\" Alto=\"730\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Cantidades}\" X=\"50\" Y=\"700\" Ancho=\"110\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Importes}\" X=\"2000\" Y=\"700\" Ancho=\"400\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{SonPesos}\" X=\"50\" Y=\"1550\" Ancho=\"1740\" Alto=\"130\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{Precios}\" X=\"1600\" Y=\"700\" Ancho=\"390\" Alto=\"720\" Alineacion=\"Far\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /><Campo Valor=\"{espejo}\" X=\"0\" Y=\"1740\" Ancho=\"2480\" Alto=\"1830\" Alineacion=\"Near\" AlineacionRenglon=\"Near\" AnchoBorde=\"0\" ColorBorde=\"16777215\" ColorFondo=\"16777215\" ColorTexto=\"-16777216\" /></Plantilla>');

DELETE FROM "documentos_tipos";
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('1','Factura A','A','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('2','Factura B','B','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('3','Factura C','C','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('4','Factura E','E','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('5','Factura M','M','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('11','Nota de Cr�dito A','NCA','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('12','Nota de Cr�dito B','NCB','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('13','Nota de Cr�dito C','NCC','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('14','Nota de Cr�dito E','NCE','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('15','Nota de Cr�dito M','NCM','1','999','1','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('21','Nota de D�bito A','NDA','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('22','Nota de D�bito B','NDB','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('23','Nota de D�bito C','NDC','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('24','Nota de D�bito E','NDE','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('25','Nota de D�bito M','NDM','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('31','Ticket','T','1','1','999','0','1','0','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('41','Remito','R','1','1','999','0','1','1','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('51','Presupuesto','PS','0',NULL,NULL,'1','1','0','1');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('53','Recibo de Cobro','RC','0',NULL,NULL,'1','0','1','0');
insert into documentos_tipos (id_tipo, nombre, letra, mueve_stock, situacionorigen, situaciondestino, numerar_guardar, numerar_imprimir, imprimir_repetir, imprimir_modificar) values('54','Recibo de Pago','RCP','0',NULL,NULL,'0','0','1','0');

SET FOREIGN_KEY_CHECKS=1;
