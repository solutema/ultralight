using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Docs
{
        public class Section
        {
                public string Name;
                public List<Element> Elements = null;

                public Section(string name)
                {
                        this.Name = name;
                }
        }
}
