SET FOREIGN_KEY_CHECKS=0;
UPDATE bancos_cheques SET id_chequera=(SELECT chequeras.id_chequera FROM chequeras WHERE bancos_cheques.numero BETWEEN desde AND hasta);
SET FOREIGN_KEY_CHECKS=1;
