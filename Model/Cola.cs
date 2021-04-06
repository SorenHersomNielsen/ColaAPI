using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaAPI.Model
{
    public class Cola
    {
        public Cola()
        {

        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string producent;

        public string Producent
        {
            get { return producent; }
            set { producent = value; }
        }

    }
}
