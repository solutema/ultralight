using System;
using System.Collections.Generic;
using System.Text;

namespace Lbl.Articulos
{
        public class Item
        {
                public string Serie;
                public Situacion Situacion;

                public Item(string serie, Situacion situacion)
                {
                        this.Serie = serie;
                        this.Situacion = situacion;
                }
        }

        public class ColeccionItem : System.Collections.CollectionBase
        {
                public void Add(Item comp)
                {
                        List.Add(comp);
                }

                public virtual Item this[int index]
                {
                        get
                        {
                                return (Item)this.List[index];
                        }
                }

                public bool Contains(string serie, Situacion situacion)
                {
                        foreach (Item Itm in this.List) {
                                if (Itm.Situacion.Id == situacion.Id && Itm.Serie == serie)
                                        return true;
                        }
                        return false;
                }
        }
}
