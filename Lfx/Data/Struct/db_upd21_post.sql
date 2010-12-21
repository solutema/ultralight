SET FOREIGN_KEY_CHECKS=0;

SET @tdf=(SELECT id_tarjeta FROM tarjetas WHERE nombre='TDF');
UPDATE facturas SET id_formapago=1000 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@tdf AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=1000 WHERE id_tarjeta=@tdf;
UPDATE tarjetas SET id_tarjeta=1000 WHERE id_tarjeta=@tdf;

SET @lared=(SELECT id_tarjeta FROM tarjetas WHERE nombre='La Red Intercomercial');
UPDATE facturas SET id_formapago=1001 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@lared AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=1001 WHERE id_tarjeta=@lared;
UPDATE tarjetas SET id_tarjeta=1001 WHERE id_tarjeta=@lared;

SET @mcard=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Mastercard');
UPDATE facturas SET id_formapago=101 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@mcard AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=101 WHERE id_tarjeta=@mcard;
UPDATE tarjetas SET id_tarjeta=101 WHERE id_tarjeta=@mcard;

SET @visa=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Visa');
UPDATE facturas SET id_formapago=102 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@visa AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=102 WHERE id_tarjeta=@visa;
UPDATE tarjetas SET id_tarjeta=102 WHERE id_tarjeta=@visa;

SET @amex=(SELECT id_tarjeta FROM tarjetas WHERE nombre='American Express');
UPDATE facturas SET id_formapago=103 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@amex AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=103 WHERE id_tarjeta=@amex;
UPDATE tarjetas SET id_tarjeta=103 WHERE id_tarjeta=@amex;

SET @cfranca=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Carta Franca');
UPDATE facturas SET id_formapago=104 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@cfranca AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=104 WHERE id_tarjeta=@cfranca;
UPDATE tarjetas SET id_tarjeta=104 WHERE id_tarjeta=@cfranca;

SET @cabal=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Cabal');
UPDATE facturas SET id_formapago=105 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@cabal AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=105 WHERE id_tarjeta=@cabal;
UPDATE tarjetas SET id_tarjeta=105 WHERE id_tarjeta=@cabal;

SET @naranja=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Naranja');
UPDATE facturas SET id_formapago=106 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@naranja AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=106 WHERE id_tarjeta=@naranja;
UPDATE tarjetas SET id_tarjeta=106 WHERE id_tarjeta=@naranja;

SET @velec=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Visa Electrón');
UPDATE facturas SET id_formapago=107 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@velec AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=107 WHERE id_tarjeta=@velec;
UPDATE tarjetas SET id_tarjeta=107 WHERE id_tarjeta=@velec;

SET @maestro=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Maestro');
UPDATE facturas SET id_formapago=108 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@maestro AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=108 WHERE id_tarjeta=@maestro;
UPDATE tarjetas SET id_tarjeta=108 WHERE id_tarjeta=@maestro;

SET @visa=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Tarjeta Fueguina');
UPDATE facturas SET id_formapago=102 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@visa AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=102 WHERE id_tarjeta=@visa;
DELETE FROM tarjetas WHERE id_tarjeta=@visa;

SET @otracr=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Otra Tarjeta de Crédito');
UPDATE tarjetas_cupones SET id_tarjeta=4 WHERE id_tarjeta=@otracr;
UPDATE tarjetas SET id_tarjeta=4 WHERE id_tarjeta=@otracr;

SET @otradb=(SELECT id_tarjeta FROM tarjetas WHERE nombre='Otra Tarjeta de Débito');
UPDATE facturas SET id_formapago=5 WHERE id_formapago=4 AND id_factura IN (SELECT id_factura FROM tarjetas_cupones WHERE id_tarjeta=@otradb AND tarjetas_cupones.id_factura=facturas.id_factura);
UPDATE tarjetas_cupones SET id_tarjeta=5 WHERE id_tarjeta=@otradb;
UPDATE tarjetas SET id_tarjeta=5 WHERE id_tarjeta=@otradb;

REPLACE INTO formaspago (id_formapago, nombre, estado, tipo, id_cuenta, descuento, retencion, autopres, autoacred, dias_acred)
	VALUES (101, 'MasterCard', 1, 4, NULL, 0, 3, 1, 0, 3),
	 (102, 'Visa', 1, 4, NULL, 0, 4, 1, 0, 3),
	 (103, 'American Express', 1, 4, NULL, 0, 3, 1, 0, 3),
	 (104, 'Carta Franca', 1, 4, NULL, 0, 3, 1, 0, 3),
	 (105, 'Cabal', 1, 4, NULL, 0, 3, 1, 0, 3),
	 (106, 'Naranja', 1, 4, NULL, 0, 3, 1, 0, 21),
	 (107, 'Visa Electrón', 1, 4, NULL, 0, 1.5, 1, 0, 3),
	 (108, 'Maestro', 1, 4, NULL, 0, 1.5, 1, 0, 3),
	 (5, 'Otra Tarjeta de Débito', 1, 4, NULL, 0, 1.5, 1, 0, 3),
	 (4, 'Otra Tarjeta de Crédito', 1, 4, NULL, 0, 3, 1, 0, 3),
	 (1000, 'TDF', 1, 4, NULL, 0, 8, 1, 0, 21),
	 (1001, 'La Red Intercomercial', 1, 4, NULL, 0, 10, 0, 0, 21),
	 (109, 'Actual', 1, 4, NULL, 0, 3, 1, 0, 3);

UPDATE formaspago SET tipo=1, pagos=1, id_cuenta=999, autoacred=1 WHERE id_formapago=1;
UPDATE formaspago SET tipo=2, pagos=1, autoacred=1 WHERE id_formapago=2;
UPDATE formaspago SET tipo=3, autoacred=1 WHERE id_formapago=3;
UPDATE formaspago SET tipo=6, pagos=1, autoacred=1 WHERE id_formapago=6;
UPDATE formaspago SET id_cuenta=NULL WHERE id_cuenta=0;

UPDATE facturas SET id_formapago=3 WHERE id_formapago=99;
DELETE FROM formaspago WHERE id_formapago=99;


SET FOREIGN_KEY_CHECKS=1;