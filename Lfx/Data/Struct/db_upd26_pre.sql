SET FOREIGN_KEY_CHECKS=0;

UPDATE personas SET fecha=fechaalta WHERE fecha IS NULL;
UPDATE personas SET fecha=contrasena_fecha WHERE fecha IS NULL;
UPDATE personas SET fecha=NOW() WHERE fecha IS NULL;

SET FOREIGN_KEY_CHECKS=1;
