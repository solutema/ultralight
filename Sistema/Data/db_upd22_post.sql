SET FOREIGN_KEY_CHECKS=0;

UPDATE formaspago SET tipo=1, pagos=1, id_cuenta=999, autoacred=1 WHERE id_formapago=1;
UPDATE formaspago SET tipo=2, pagos=1, autoacred=1 WHERE id_formapago=2;
UPDATE formaspago SET tipo=3, autoacred=1 WHERE id_formapago=3;
UPDATE formaspago SET tipo=6, pagos=1, autoacred=1 WHERE id_formapago=6;
UPDATE formaspago SET id_cuenta=NULL WHERE id_cuenta=0;

UPDATE facturas SET id_formapago=3 WHERE id_formapago=99;
DELETE FROM formaspago WHERE id_formapago=99;

UPDATE monedas SET iso='USD' WHERE id_moneda=1;
UPDATE monedas SET signo='€', iso='EUR' WHERE id_moneda=2;
UPDATE monedas SET iso='ARS' WHERE id_moneda=3;
REPLACE INTO monedas (id_moneda, nombre, signo, cotizacion, iso) VALUES (4, 'Pesos Uruguayos', 'UYU', 1, 'UYU');
REPLACE INTO monedas (id_moneda, nombre, signo, cotizacion, iso) VALUES (5, 'Pesos Chilenos', 'CLP', 1, 'CLP');
REPLACE INTO monedas (id_moneda, nombre, signo, cotizacion, iso) VALUES (6, 'Reales', 'BRL', 1, 'BRL');

SET FOREIGN_KEY_CHECKS=1;
