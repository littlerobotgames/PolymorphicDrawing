using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public interface IGraphic2DFactory
    {
        string Name { get; }
        public IGraphic2D Create();
    }
}
