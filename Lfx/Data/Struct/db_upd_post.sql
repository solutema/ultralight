SET FOREIGN_KEY_CHECKS=0;

UPDATE documentos_tipos SET tipobase='Lbl.Comprobantes.ComprobanteFacturable'
	WHERE tipo IN ('Lbl.Comprobantes.Factura', 'Lbl.Comprobantes.NotaDeCredito', 'Lbl.Comprobantes.NotaDeDebito', 'Lbl.Comprobantes.Ticket');

UPDATE documentos_tipos SET tipobase='Lbl.Comprobantes.Recibo'
	WHERE tipo IN ('Lbl.Comprobantes.ReciboDeCobro', 'Lbl.Comprobantes.ReciboDePago');

SET FOREIGN_KEY_CHECKS=1;