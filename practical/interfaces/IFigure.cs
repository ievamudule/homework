using System.Collections.Generic;
using System.Linq;

namespace interfaces
{
    public interface IFigure
    {
        
        public double CalculatePerimeter(List<double> edges){
            return edges.Sum();
        }
        public double CalculateArea(){

        }
    }
}