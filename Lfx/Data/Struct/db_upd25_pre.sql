SET FOREIGN_KEY_CHECKS=0;

DELETE FROM personas_tipos WHERE id_tipo_persona=0 OR id_tipo_persona IS NULL;
DELETE FROM tickets_estados WHERE id_ticket_estado=0 OR id_ticket_estado IS NULL;

ALTER TABLE personas_tipos ALTER COLUMN id_tipo_persona DROP DEFAULT;
ALTER TABLE personas_tipos CHANGE id_tipo_persona id_tipo_persona INTEGER AUTO_INCREMENT NOT NULL;
ALTER TABLE tickets_estados ALTER COLUMN id_ticket_estado DROP DEFAULT;
ALTER TABLE tickets_estados CHANGE id_ticket_estado id_ticket_estado INTEGER AUTO_INCREMENT NOT NULL;

SET FOREIGN_KEY_CHECKS=1;