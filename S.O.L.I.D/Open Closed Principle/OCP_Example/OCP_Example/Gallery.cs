using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example
{
    public class Gallery
    {
        private List<Car> cars = new List<Car>();

        public Gallery()
        {
            cars.Add(new Sedan());
            cars.Add(new Jeep());
        }

        public void Showroom()
        {
            foreach (var car in cars)
            {
                car.Show();
            }
        }
    }

}
