SET FOREIGN_KEY_CHECKS=0;

UPDATE formaspago SET tipo=8 WHERE id_formapago=8;
UPDATE sys_log SET extra1=NULL WHERE extra1='';
UPDATE formaspago SET nombre='Caja/Cuenta' WHERE id_formapago=6;
UPDATE pvs SET numero=id_pv;

UPDATE sys_log SET extra1=NULL WHERE extra1='';
UPDATE formaspago SET nombre='Cheque Propio' WHERE id_formapago=2;
UPDATE chequeras SET cheques_total=hasta-desde+1;
UPDATE chequeras SET cheques_emitidos=(SELECT COUNT(id_cheque) FROM bancos_cheques WHERE bancos_cheques.id_chequera=chequeras.id_chequera);
REPLACE INTO formaspago (id_formapago, nombre, estado, tipo, id_caja, descuento, retencion, autopres, autoacred, dias_acred, pagos, adelantacuotas, id_concepto) VALUES ('7','Comprobante de Retención de Impuestos','1','7',NULL,'0.0000','0.0000','0','0','0','0','0',NULL);
REPLACE INTO formaspago (id_formapago, nombre, estado, tipo, id_caja, descuento, retencion, autopres, autoacred, dias_acred, pagos, adelantacuotas, id_concepto) VALUES ('8','Cheque de Terceros','1','8',NULL,'0.0000','0.0000','0','0','0','0','0',NULL);
UPDATE bancos_cheques SET nombre=CONCAT('Nº ', FORMAT(numero, 0), ' por $ ', FORMAT(importe, 2), ' emitido por ', emitidopor) WHERE emitido=0;
UPDATE bancos_cheques SET nombre=CONCAT('Nº ', FORMAT(numero, 0), ' por $ ', FORMAT(importe, 2)) WHERE emitido=1;
UPDATE formaspago SET pagos=1, cobros=1;
UPDATE formaspago SET pagos=0 WHERE tipo=4;
UPDATE formaspago SET cobros=0 WHERE tipo=2;
DROP TABLE IF EXISTS chat;
DROP TABLE IF EXISTS chat_contacts;

UPDATE pvs SET tipo_fac='F,NC,ND' WHERE tipo_fac='';

UPDATE sys_plantillas SET codigo='FA' WHERE codigo='A'; 
UPDATE sys_plantillas SET codigo='FB' WHERE codigo='B';
UPDATE sys_plantillas SET codigo='FC' WHERE codigo='C';
UPDATE sys_plantillas SET codigo='FE' WHERE codigo='E';
UPDATE sys_plantillas SET codigo='FM' WHERE codigo='M';
UPDATE comprob SET tipo_fac='FA' WHERE tipo_fac='A'; 
UPDATE comprob SET tipo_fac='FB' WHERE tipo_fac='B';
UPDATE comprob SET tipo_fac='FC' WHERE tipo_fac='C';
UPDATE comprob SET tipo_fac='FE' WHERE tipo_fac='E';
UPDATE comprob SET tipo_fac='FM' WHERE tipo_fac='M';

UPDATE documentos_tipos SET letra='FA' WHERE letra='A'; 
UPDATE documentos_tipos SET letra='FB' WHERE letra='B';
UPDATE documentos_tipos SET letra='FC' WHERE letra='C';
UPDATE documentos_tipos SET letra='FE' WHERE letra='E';
UPDATE documentos_tipos SET letra='FM' WHERE letra='M';

UPDATE sys_config SET nombre=REPLACE(nombre, '.A.', '.FA.');
UPDATE sys_config SET nombre=REPLACE(nombre, '.B.', '.FB.');

UPDATE comprob SET impresa=1 WHERE compra>0;
UPDATE comprob SET cancelado=total WHERE tipo_fac IN ('NCA', 'NCB', 'NCC', 'NCE', 'NCM');

SET FOREIGN_KEY_CHECKS=1;