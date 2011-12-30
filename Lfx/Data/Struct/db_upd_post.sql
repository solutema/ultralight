UPDATE comprob SET nombre=CONCAT(LPAD(comprob.pv, 4, '0'), '-', LPAD(comprob.numero, 8, '0')) WHERE nombre='';
UPDATE recibos SET nombre=CONCAT(LPAD(recibos.pv, 4, '0'), '-', LPAD(recibos.numero, 8, '0')) WHERE nombre='';
