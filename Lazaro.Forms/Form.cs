using System;
using System.Collections.Generic;
using System.Text;

namespace Lazaro.Forms
{
        public class Form
        {
                public Lws.Data.Table DataTable;
                public FormSectionCollection Sections;

                public Form()
                {
                        Sections = new FormSectionCollection(this);
                }
        }
}
