SET FOREIGN_KEY_CHECKS=0;

UPDATE personas SET saldo_ctacte = (SELECT SUM(importe)  FROM ctacte WHERE ctacte.id_cliente=personas.id_persona);
DROP TABLE IF EXISTS sys_proxystatus;

SET FOREIGN_KEY_CHECKS=1;
