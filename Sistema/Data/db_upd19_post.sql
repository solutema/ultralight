SET FOREIGN_KEY_CHECKS=0;

UPDATE facturas SET id_formapago=4 WHERE id_formapago=5;
UPDATE formaspago SET nombre='Tarjeta' WHERE id_formapago=4;
DELETE FROM formaspago WHERE id_formapago=5;
UPDATE formaspago SET nombre='Depósito en Cuenta' WHERE id_formapago=6;
UPDATE sys_config SET nombre='Documentos.RC.NumerarAlGuardar' WHERE nombre='Documentos.R.NumerarAlGuardar';
UPDATE sys_config SET nombre='Documentos.RC.ImprimirAlGuardar' WHERE nombre='Documentos.R.ImprimirAlGuardar';
UPDATE recibos SET tipo_fac='RC' WHERE tipo_fac='' OR tipo_fac IS NULL;
UPDATE recibos SET id_concepto=11000 WHERE id_concepto=0 OR id_concepto IS NULL;
INSERT IGNORE INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (23015,'Comisiones por ventas',0,231,1);
INSERT IGNORE INTO cuentas_conceptos ("id_concepto","nombre","es","grupo","fijo") VALUES (13010,'Ingresos por comisiones ganadas',0,100,1);

INSERT IGNORE INTO sys_plantillas (codigo,nombre) values ('RC','Recibo');
INSERT IGNORE INTO sys_plantillas (codigo,nombre) values ('RCP','Recibo de Pago');
UPDATE sys_plantillas SET defxml='<Plantilla Copias="1" Membrete="0" Fuente="Bitstream Vera Serif" TamanoFuente="10"><Campo Valor="Recibo Nº {Numero}" X="70" Y="320" Ancho="1600" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Serif" TamanoFuente="18" /><Campo Valor="{Valores}" X="70" Y="790" Ancho="1600" Alto="600" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-4144960" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" Fuente="Bitstream Vera Sans Mono" TamanoFuente="9" /><Campo Valor="Recibimos de: {Cliente}" X="70" Y="550" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="La cantidad de: {Total}" X="70" Y="720" Ancho="1600" Alto="70" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="-8355712" ColorFondo="-2368553" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Fecha: {Fecha}" X="70" Y="490" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Empresa}" X="80" Y="70" Ancho="1580" Alto="130" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="-1053468" ColorTexto="-6862080" Wrap="0" Fuente="Bitstream Vera Sans" TamanoFuente="18" /><Campo Valor="{Empresa.Domicilio} - Tel. {Empresa.Telefono} - {Empresa.Ciudad}" X="80" Y="220" Ancho="1580" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="Son pesos {SonPesos}.-" X="70" Y="1430" Ancho="1600" Alto="150" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="CUIT/DNI: {Cliente.Documento}" X="70" Y="620" Ancho="1600" Alto="60" Alineacion="Near" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="70" Y="60" Ancho="1600" Alto="240" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="5" ColorBorde="-32768" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{Vendedor}" X="870" Y="2280" Ancho="800" Alto="70" Alineacion="Center" AlineacionRenglon="Center" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="" X="870" Y="2260" Ancho="800" Alto="1" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="1" ColorBorde="-16777216" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="{espejo}" X="1670" Y="0" Ancho="1830" Alto="2500" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /><Campo Valor="En concepto de: {concepto}" X="70" Y="1610" Ancho="1600" Alto="380" Alineacion="Near" AlineacionRenglon="Near" AnchoBorde="0" ColorBorde="16777215" ColorFondo="16777215" ColorTexto="-16777216" Wrap="0" /></Plantilla>' WHERE (defxml='' OR defxml IS NULL) AND codigo IN ('RC', 'RCP');

SET FOREIGN_KEY_CHECKS=1;
