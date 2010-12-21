INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('bancos', 'Bancos', 0, NULL);
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.read', 'Ver chequeras', 1, 'bancos');
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.create', 'Crear chequeras', 1, 'bancos');
INSERT INTO sys_accessbase (id_acceso, nombre, tipo, parent) VALUES ('chequeras.write', 'Modificar chequeras', 1, 'bancos');
