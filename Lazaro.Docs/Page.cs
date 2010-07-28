using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Docs
{
        public class Page
        {
                public Section Header = null, Footer = null;
                public List<Section> Sections = new List<Section>();

                public Page()
                {
                        this.Sections.Clear();
                        this.Sections.Add(new Section("Body"));
                }

                public List<Element> Elements
                {
                        get
                        {
                                return this.Sections[0].Elements;
                        }
                }
        }
}
