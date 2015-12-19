namespace Lfc.Inicio
{
        partial class ControlComprobantes
        {
                /// <summary> 
                /// Variable del diseñador requerida.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary> 
                /// Limpiar los recursos que se estén utilizando.
                /// </summary>
                /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
                protected override void Dispose(bool disposing)
                {
                        if (disposing && (components != null)) {
                                components.Dispose();
                        }
                        base.Dispose(disposing);
                }

                #region Código generado por el Diseñador de componentes

                /// <summary> 
                /// Método necesario para admitir el Diseñador. No se puede modificar 
                /// el contenido del método con el editor de código.
                /// </summary>
                private void InitializeComponent()
                {
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlComprobantes));
                        this.PanelBotones = new System.Windows.Forms.FlowLayoutPanel();
                        this.BotonListadoFacturas = new Lfc.Inicio.Boton();
                        this.BotonListadoRecibos = new Lfc.Inicio.Boton();
                        this.BotonCrearFactura = new Lfc.Inicio.Boton();
                        this.BotonCrearRecibo = new Lfc.Inicio.Boton();
                        this.label1 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.ListaComprob = new System.Windows.Forms.ListBox();
                        this.PanelBotones.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // PanelBotones
                        // 
                        this.PanelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PanelBotones.BackColor = System.Drawing.Color.DarkOrange;
                        this.PanelBotones.Controls.Add(this.BotonListadoFacturas);
                        this.PanelBotones.Controls.Add(this.BotonListadoRecibos);
                        this.PanelBotones.Controls.Add(this.BotonCrearFactura);
                        this.PanelBotones.Controls.Add(this.BotonCrearRecibo);
                        this.PanelBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                        this.PanelBotones.Location = new System.Drawing.Point(0, 92);
                        this.PanelBotones.Name = "PanelBotones";
                        this.PanelBotones.Size = new System.Drawing.Size(480, 48);
                        this.PanelBotones.TabIndex = 2;
                        // 
                        // BotonListadoFacturas
                        // 
                        this.BotonListadoFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonListadoFacturas.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonListadoFacturas.Image = ((System.Drawing.Image)(resources.GetObject("BotonListadoFacturas.Image")));
                        this.BotonListadoFacturas.Location = new System.Drawing.Point(361, 3);
                        this.BotonListadoFacturas.Name = "BotonListadoFacturas";
                        this.BotonListadoFacturas.Size = new System.Drawing.Size(115, 41);
                        this.BotonListadoFacturas.TabIndex = 0;
                        this.BotonListadoFacturas.Text = "Facturas";
                        this.BotonListadoFacturas.Click += new System.EventHandler(this.BotonListadoFacturas_Click);
                        // 
                        // BotonListadoRecibos
                        // 
                        this.BotonListadoRecibos.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonListadoRecibos.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonListadoRecibos.Image = ((System.Drawing.Image)(resources.GetObject("BotonListadoRecibos.Image")));
                        this.BotonListadoRecibos.Location = new System.Drawing.Point(241, 3);
                        this.BotonListadoRecibos.Name = "BotonListadoRecibos";
                        this.BotonListadoRecibos.Size = new System.Drawing.Size(112, 41);
                        this.BotonListadoRecibos.TabIndex = 1;
                        this.BotonListadoRecibos.Text = "Recibos";
                        this.BotonListadoRecibos.Click += new System.EventHandler(this.BotonListadoRecibos_Click);
                        // 
                        // BotonCrearFactura
                        // 
                        this.BotonCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonCrearFactura.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCrearFactura.Image = ((System.Drawing.Image)(resources.GetObject("BotonCrearFactura.Image")));
                        this.BotonCrearFactura.Location = new System.Drawing.Point(85, 3);
                        this.BotonCrearFactura.Name = "BotonCrearFactura";
                        this.BotonCrearFactura.Size = new System.Drawing.Size(148, 41);
                        this.BotonCrearFactura.TabIndex = 2;
                        this.BotonCrearFactura.Text = "Nueva factura";
                        this.BotonCrearFactura.Click += new System.EventHandler(this.BotonCrearFactura_Click);
                        // 
                        // BotonCrearRecibo
                        // 
                        this.BotonCrearRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
                        this.BotonCrearRecibo.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.BotonCrearRecibo.Image = ((System.Drawing.Image)(resources.GetObject("BotonCrearRecibo.Image")));
                        this.BotonCrearRecibo.Location = new System.Drawing.Point(328, 50);
                        this.BotonCrearRecibo.Name = "BotonCrearRecibo";
                        this.BotonCrearRecibo.Size = new System.Drawing.Size(148, 41);
                        this.BotonCrearRecibo.TabIndex = 3;
                        this.BotonCrearRecibo.Text = "Nuevo recibo";
                        this.BotonCrearRecibo.Click += new System.EventHandler(this.BotonCrearRecibo_Click);
                        // 
                        // label1
                        // 
                        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label1.Location = new System.Drawing.Point(8, 233);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(461, 56);
                        this.label1.TabIndex = 7;
                        this.label1.Text = "Puede realizar otras operaciones desde el menú \"Comprobantes\", como por ejemplo c" +
    "rear recibos de pago, remitos, presupuestos, notas de crédito y débito, etc.";
                        this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                        this.label1.UseMnemonic = false;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Font = new System.Drawing.Font("Bitstream Vera Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.label2.Location = new System.Drawing.Point(64, 152);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(141, 15);
                        this.label2.TabIndex = 8;
                        this.label2.Text = "Actividad reciente";
                        // 
                        // ListaComprob
                        // 
                        this.ListaComprob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.ListaComprob.BackColor = System.Drawing.Color.OrangeRed;
                        this.ListaComprob.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.ListaComprob.ForeColor = System.Drawing.Color.White;
                        this.ListaComprob.FormattingEnabled = true;
                        this.ListaComprob.ItemHeight = 15;
                        this.ListaComprob.Location = new System.Drawing.Point(88, 172);
                        this.ListaComprob.Name = "ListaComprob";
                        this.ListaComprob.Size = new System.Drawing.Size(368, 60);
                        this.ListaComprob.TabIndex = 0;
                        this.ListaComprob.TabStop = false;
                        // 
                        // ControlComprobantes
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.OrangeRed;
                        this.Controls.Add(this.ListaComprob);
                        this.Controls.Add(this.label2);
                        this.Controls.Add(this.PanelBotones);
                        this.Controls.Add(this.label1);
                        this.Descripcion = "Administre diferentes tipos de comprobantes, como ser facturas y tickets, recibos" +
    ", remitos y presupuestos.";
                        this.ForeColor = System.Drawing.Color.White;
                        this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
                        this.Name = "ControlComprobantes";
                        this.Size = new System.Drawing.Size(480, 297);
                        this.Text = "Comprobantes";
                        this.Controls.SetChildIndex(this.label1, 0);
                        this.Controls.SetChildIndex(this.PanelBotones, 0);
                        this.Controls.SetChildIndex(this.label2, 0);
                        this.Controls.SetChildIndex(this.ListaComprob, 0);
                        this.PanelBotones.ResumeLayout(false);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.FlowLayoutPanel PanelBotones;
                private Boton BotonListadoFacturas;
                private Boton BotonListadoRecibos;
                private Boton BotonCrearFactura;
                private Boton BotonCrearRecibo;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.ListBox ListaComprob;
        }
}
