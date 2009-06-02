using System;
using System.Collections.Generic;
using System.Text;

namespace Lcc.Edicion.Articulos
{
        public class General : Lcc.Edicion.ControlEdicion
        {
        
                public void DesdeElemento(Lbl.ElementoDeDatos elemento)
                {
                        return;
                }

                public Lbl.ElementoDeDatos HaciaElemento()
                {
                        return null;
                }

                private void InitializeComponent()
                {
                        this.SuspendLayout();
                        // 
                        // General
                        // 
                        this.Name = "General";
                        this.Size = new System.Drawing.Size(633, 805);
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }
        }
}
