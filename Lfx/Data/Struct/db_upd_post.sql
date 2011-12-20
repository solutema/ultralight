SET FOREIGN_KEY_CHECKS=0;

REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (1,'DNI','Documento Nacional de Identidad','Argentina, España y Perú',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (2,'LE','Libreta de Enrolamiento','Argentina',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (3,'LC','Libreta Cívica','Argentina',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (4,'CI','Cédula de Identidad','Bolivia, Brazil, Chile, Costa Rica, Ecuador, Honduras, Nicaragua, Panamá, Paraguay, Uruguay y Venezuela',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (5,'CUIL','CUIL','Argentina',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (6,'CUIT','CUIT','Argentina',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (7,'Pasaporte','',NULL,1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (8,'CURP','Clave Única de Registro de Población','México',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (9,'CIE','Cédula de Identidad y Electoral','República Dominicana',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (10,'CC','Cédula de Ciudadanía','Colombia',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (11,'DUI','Documento Único de Identidad','El Salvador',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (12,'DPI','Documento Personal de Identificación','Guatemala',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (14,'NIT','Número de Identificación Tributaria','Bolivia, Colombia, El Salvador',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (15,'RIF','Registro Único de Información Fiscal','Venezuela',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (16,'RUT','Rol Único Tributario','Chile',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (17,'RUN','Rol Único Nacional','Chile',1,1);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (18,'RNC','Registro Nacional del Contribuyente','República Dominicana',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (19,'RUT','Registro Único Tributario','Uruguay',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (20,'NIF','Número de identificación fiscal','España',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (21,'NIE','Número de identificación de extranjero','España',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (22,'SSN','Social Security Number ','Estados Unidos',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (23,'TIN','Taxpayer Identification Number','Estados Unidos',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (24,'RFC','Registro Federal de Contribuyentes','México',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (25,'RUC','Registro Único de Contribuyentes','Panamá, Perú y en Ecuador',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (26,'RTU','Registro Tributario Unificado','Guatemala',1,3);
REPLACE INTO "tipo_doc" ("id_tipo_doc", "nombre", "descripcion", "obs", "estado", "fisjur") VALUES (27,'CPF','Cadastro de Pessoas Físicas','Brazil',1,3);


REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (1,'Dólares',NULL,1,'USD','USD',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (2,'Euros',NULL,1,'€','EUR',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (3,'Pesos Argentinos',NULL,1,'$','ARS',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (4,'Pesos Uruguayos',NULL,1,'$','UYU',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (5,'Pesos Chilenos',NULL,1,'$','CLP',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (6,'Reales',NULL,1,'R$','BRL',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (7,'Guaraníes',NULL,1,'Gs','PYG',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (8,'Pesos Bolivianos',NULL,1,'$','BOB',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (9,'Soles',NULL,1,'S/.','PEN',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (11,'Pesos Colombianos',NULL,1,'$','COP',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (12,'Bolívares',NULL,1,'Bs','VEF',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (13,'Colones de Costa Rica',NULL,1,'C','CRC',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (14,'Pesos Cubanos',NULL,1,'P','CUP',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (15,'Colones de El Salvador',NULL,1,'$','SVC',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (16,'Quetzales',NULL,1,'Q','GTQ',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (17,'Pesos Mexicanos',NULL,1,'$','MXN',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (18,'Córdobas',NULL,1,'C$','NIO',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (19,'Balboas',NULL,1,'B/.','PAB',1);
REPLACE INTO "monedas" ("id_moneda", "nombre", "obs", "estado", "signo", "iso", "cotizacion") VALUES (20,'Pesos Dominicanos',NULL,1,'RD$','DOP',1);


REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (1,'Argentina',NULL,1,'AR',1,6,3);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (2,'España',NULL,1,'ES',1,20,2);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (3,'Chile',NULL,1,'CL',4,16,5);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (4,'México',NULL,1,'MX',8,24,17);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (5,'Uruguay',NULL,1,'UY',4,19,4);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (6,'Paraguay',NULL,1,'PY',4,0,7);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (7,'Bolivia',NULL,1,'BO',4,14,8);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (8,'Colombia',NULL,1,'CO',10,14,11);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (9,'Venezuela',NULL,1,'VE',4,15,12);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (10,'Ecuador',NULL,1,'EC',4,25,NULL);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (11,'Perú',NULL,1,'PE',1,25,9);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (12,'Panamá',NULL,1,'PA',4,25,19);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (13,'Guatemala',NULL,1,'GT',12,26,16);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (14,'El Salvador',NULL,1,'SV',11,14,15);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (15,'República Dominicana',NULL,1,'DO',9,18,20);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (16,'Cuba',NULL,1,'CU',0,0,14);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (17,'Brazil',NULL,1,'BR',4,27,6);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (18,'Costa Rica',NULL,1,'CR',4,0,13);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (19,'Honduras',NULL,'0','HN',4,0,NULL);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (20,'Nicaragua',NULL,'0','NI',4,0,18);
REPLACE INTO "paises" ("id_pais", "nombre", "obs", "estado", "iso", "clavejur", "clavefis", "id_moneda") VALUES (99,'Estados Unidos',NULL,1,'US',22,23,1);


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

UPDATE situaciones SET nombrecorto='Cons. Final' WHERE id_situacion=1;
UPDATE situaciones SET nombrecorto='Resp. Inscr.' WHERE id_situacion=2;
UPDATE situaciones SET nombrecorto='Resp. No Inscr.' WHERE id_situacion=3;
UPDATE situaciones SET nombrecorto='Monotrib.' WHERE id_situacion=4;
UPDATE situaciones SET nombrecorto='Exento' WHERE id_situacion=5;
UPDATE situaciones SET nombrecorto='No Resp.' WHERE id_situacion=6;
UPDATE situaciones SET nombrecorto='No Categ.' WHERE id_situacion=6;

UPDATE documentos_tipos SET tabla=NULL WHERE tabla='';
UPDATE documentos_tipos SET tipo=NULL WHERE tipo='';

UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.Presupuesto' WHERE tabla IS NULL AND letra='PS';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.Factura' WHERE tabla IS NULL AND letra IN ('FA', 'FB', 'FC', 'FE', 'FM');
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.NotaDeCredito' WHERE tabla IS NULL AND letra IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM');
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.NotaDeDebito' WHERE tabla IS NULL AND letra IN ('NDA', 'NDB', 'NDC', 'NDE', 'NDM');
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.ReciboDeCobro' WHERE tabla IS NULL AND letra='RC';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.ReciboDePago' WHERE tabla IS NULL AND letra='RCP';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.Ticket' WHERE tabla IS NULL AND letra='T';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.Remito' WHERE tabla IS NULL AND letra='R';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.Pedido' WHERE tabla IS NULL AND letra='PD';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.NotaDePedido' WHERE tabla IS NULL AND letra='NP';
UPDATE documentos_tipos SET tipo='Lbl.Comprobantes.NotaDeVenta' WHERE tabla IS NULL AND letra='NV';

UPDATE documentos_tipos SET tabla='comprob' WHERE tabla IS NULL;
UPDATE documentos_tipos SET tabla='recibos' WHERE tabla IS NULL AND letra IN ('RC', 'RCP');

UPDATE sys_log SET comando='Save' WHERE comando='SAVE';
UPDATE sys_log SET comando='LogonFail' WHERE comando='LOGON.FAIL';
UPDATE sys_log SET comando='Logon' WHERE comando='LOGON';
UPDATE sys_log SET comando='Save' WHERE comando='CREATE';
UPDATE sys_log SET comando='Quit' WHERE comando='QUIT';
UPDATE sys_log SET comando='Save' WHERE comando='EDIT';

UPDATE sys_plantillas SET codigo='Lbl.Comprobantes.ComprobanteConArticulos' WHERE codigo='*';

UPDATE ciudades a SET id_provincia=(SELECT parent FROM (SELECT id_ciudad, parent, nivel FROM ciudades WHERE nivel=1) AS X WHERE id_ciudad=a.parent) WHERE id_provincia IS NULL AND nivel=2;
DELETE FROM ciudades WHERE nivel=1;
UPDATE ciudades SET parent=id_provincia WHERE nivel>0;
UPDATE ciudades SET id_pais=1 WHERE id_pais=0 AND parent IS NULL;

SET FOREIGN_KEY_CHECKS=1;
