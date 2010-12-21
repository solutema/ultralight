ALTER TABLE documentos_tipos ADD (letra VARCHAR(50) NOT NULL);
UPDATE documentos_tipos SET letra=id_tipo;

SET FOREIGN_KEY_CHECKS=0;
UPDATE tarjetas_cupones SET id_plan=6 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=6);
UPDATE tarjetas_cupones SET id_plan=9 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=9);
UPDATE tarjetas_cupones SET id_plan=10 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=10);
UPDATE tarjetas_cupones SET id_plan=12 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=12);
UPDATE tarjetas_cupones SET id_plan=18 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=18);
UPDATE tarjetas_cupones SET id_plan=24 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE cuotas=24);
UPDATE tarjetas_cupones SET id_plan=100 WHERE id_plan=(SELECT id_plan FROM tarjetas_planes WHERE nombre='Plan Zeta');

UPDATE tarjetas_planes SET id_plan=1006 WHERE cuotas=6;
UPDATE tarjetas_planes SET id_plan=1009 WHERE cuotas=9;
UPDATE tarjetas_planes SET id_plan=1010 WHERE cuotas=10;
UPDATE tarjetas_planes SET id_plan=1012 WHERE cuotas=12;
UPDATE tarjetas_planes SET id_plan=1018 WHERE cuotas=18;
UPDATE tarjetas_planes SET id_plan=1024 WHERE cuotas=24;
UPDATE tarjetas_planes SET id_plan=1100 WHERE nombre='Plan Zeta';

UPDATE tarjetas_planes SET id_plan=6 WHERE id_plan=1006;
UPDATE tarjetas_planes SET id_plan=9 WHERE id_plan=1009;
UPDATE tarjetas_planes SET id_plan=10 WHERE id_plan=1010;
UPDATE tarjetas_planes SET id_plan=12 WHERE id_plan=1012;
UPDATE tarjetas_planes SET id_plan=18 WHERE id_plan=1018;
UPDATE tarjetas_planes SET id_plan=24 WHERE id_plan=1024;
UPDATE tarjetas_planes SET id_plan=100 WHERE nombre='Plan Zeta';

REPLACE INTO tarjetas_planes SET id_plan=4, cuotas=4, id_tarjeta=null, nombre='4 cuotas';
REPLACE INTO tarjetas_planes SET id_plan=5, cuotas=5, id_tarjeta=null, nombre='5 cuotas';
REPLACE INTO tarjetas_planes SET id_plan=7, cuotas=7, id_tarjeta=null, nombre='7 cuotas';
REPLACE INTO tarjetas_planes SET id_plan=8, cuotas=8, id_tarjeta=null, nombre='8 cuotas';
REPLACE INTO tarjetas_planes SET id_plan=11, cuotas=11, id_tarjeta=null, nombre='11 cuotas';
SET FOREIGN_KEY_CHECKS=1;
