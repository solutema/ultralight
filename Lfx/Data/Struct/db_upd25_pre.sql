SET FOREIGN_KEY_CHECKS=0;

ALTER TABLE personas_tipos ALTER COLUMN id_tipo_persona DROP DEFAULT;
ALTER TABLE personas_tipos CHANGE id_tipo_persona id_tipo_persona INTEGER AUTO_INCREMENT NOT NULL;
ALTER TABLE tickets_estados ALTER COLUMN id_ticket_estado DROP DEFAULT;
ALTER TABLE tickets_estados CHANGE id_ticket_estado id_ticket_estado INTEGER AUTO_INCREMENT NOT NULL;

SET FOREIGN_KEY_CHECKS=1;