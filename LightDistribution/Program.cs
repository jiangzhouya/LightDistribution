using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dtest = new double[2];
            dtest[0] = 1.1;
            dtest[1] = 1.2;

            Console.WriteLine(dtest[0]);
            Console.ReadKey();
        }
        /// <summary>
        /// 给定一个光源的位置，给定一个位置，返回该位置的归一化光强值（0 ~ 1）
        /// </summary>
        /// <param 位置坐标="x"></param>
        /// <param 位置坐标="y"></param>
        /// <param 光源中心点="positionX"></param>
        /// <param 光源中心点="positionY"></param>
        /// <returns></returns>
        public double LihgtDensity(double[] pos,double[] source )
        {
            pos = new double[2];
            source = new double[2];
            double density = 0;
            // 计算位置到光源中心的距离
            double r = Math.Pow(Math.Pow(pos[0] - source[0], 2) + System.Math.Pow(pos[1]-source[1], 2), 0.5);
            density = Math.Exp(-(Math.Pow(r, 2) / (2)));
            return density;
        }
    }
    
}
