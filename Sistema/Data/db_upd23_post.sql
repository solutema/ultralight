SET FOREIGN_KEY_CHECKS=0;

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

SET FOREIGN_KEY_CHECKS=1;
