namespace Lcc.WinForms
{
        partial class EditForm
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
                        this.Header = new System.Windows.Forms.Panel();
                        this.LabelHeader = new System.Windows.Forms.Label();
                        this.DataArea = new System.Windows.Forms.TableLayoutPanel();
                        this.Body = new System.Windows.Forms.Panel();
                        this.ActionPanel = new Lcc.WinForms.ActionPanel();
                        this.Header.SuspendLayout();
                        this.Body.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // Header
                        // 
                        this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
                        this.Header.Controls.Add(this.LabelHeader);
                        this.Header.Location = new System.Drawing.Point(0, 0);
                        this.Header.Name = "Header";
                        this.Header.Size = new System.Drawing.Size(637, 32);
                        this.Header.TabIndex = 0;
                        // 
                        // LabelHeader
                        // 
                        this.LabelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.LabelHeader.AutoEllipsis = true;
                        this.LabelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
                        this.LabelHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                        this.LabelHeader.Location = new System.Drawing.Point(4, 4);
                        this.LabelHeader.Name = "LabelHeader";
                        this.LabelHeader.Size = new System.Drawing.Size(573, 24);
                        this.LabelHeader.TabIndex = 0;
                        this.LabelHeader.Text = "...";
                        this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        this.LabelHeader.UseMnemonic = false;
                        // 
                        // DataArea
                        // 
                        this.DataArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.DataArea.AutoSize = true;
                        this.DataArea.ColumnCount = 2;
                        this.DataArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.46429F));
                        this.DataArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.53571F));
                        this.DataArea.Location = new System.Drawing.Point(64, 8);
                        this.DataArea.Name = "DataArea";
                        this.DataArea.RowCount = 1;
                        this.DataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.DataArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                        this.DataArea.Size = new System.Drawing.Size(564, 32);
                        this.DataArea.TabIndex = 0;
                        // 
                        // Body
                        // 
                        this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.Body.Controls.Add(this.DataArea);
                        this.Body.Location = new System.Drawing.Point(0, 36);
                        this.Body.Name = "Body";
                        this.Body.Size = new System.Drawing.Size(640, 277);
                        this.Body.TabIndex = 3;
                        // 
                        // ActionPanel
                        // 
                        this.ActionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
                        this.ActionPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        this.ActionPanel.Location = new System.Drawing.Point(0, 317);
                        this.ActionPanel.Name = "ActionPanel";
                        this.ActionPanel.Size = new System.Drawing.Size(637, 80);
                        this.ActionPanel.TabIndex = 4;
                        // 
                        // EditForm
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.Controls.Add(this.ActionPanel);
                        this.Controls.Add(this.Body);
                        this.Controls.Add(this.Header);
                        this.Name = "EditForm";
                        this.Size = new System.Drawing.Size(640, 400);
                        this.Header.ResumeLayout(false);
                        this.Body.ResumeLayout(false);
                        this.Body.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.Panel Header;
                private System.Windows.Forms.TableLayoutPanel DataArea;
                private System.Windows.Forms.Panel Body;
                private System.Windows.Forms.Label LabelHeader;
                private ActionPanel ActionPanel;
        }
}
