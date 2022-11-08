using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVendas
{
    public partial class visual : Component
    {
        public visual()
        {
            InitializeComponent();
        }

        public visual(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
