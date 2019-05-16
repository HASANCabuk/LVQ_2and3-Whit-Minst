using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVQ__WITH_MNIST
{
    class Data
    {
        public int cls;
        public double distance;
        public List<double> vector;
        public Data(int c, double d, List<double> v)
        {
            cls = c;
            distance = d;
            vector = v;
        }
        public Data()
        {
        }
    }
}
