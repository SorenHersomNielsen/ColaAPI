using ColaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColaAPI.Manager
{
    public class ColaManager
    {
        private static int NextId = 1;

        public readonly static List<Cola> ColaList = new List<Cola>()
        {
            new Cola {Id = NextId++, Brand = "Fanta", Producent = "Cola-Cola"},
            new Cola {Id = NextId++, Brand = "Pepsi max", Producent = "Pepsi"},
            new Cola {Id = NextId++, Brand = "Cola-Cola", Producent = "Cola-Cola"}
        };

        public List<Cola> GetAll()
        {
            return new List<Cola>(ColaList);
        }

        public Cola GetByID(int id)
        {
            return ColaList.Find(ColaList => ColaList.Id == id);
        }

        public Cola Add(Cola NewCola)
        {
            NewCola.Id = NextId++;
            ColaList.Add(NewCola);
            return NewCola;
        }

        public Cola Update(int id, Cola Updates)
        {
            Cola cola = ColaList.Find(ColaList => ColaList.Id == id);
            if (cola == null)
            {
                return null;
            }
            cola.Brand = Updates.Brand;
            cola.Producent = Updates.Producent;
            return cola;
        }

        public Cola Delete(int id)
        {
            Cola cola = ColaList.Find(ColaList => ColaList.Id == id);
            if (cola == null)
            {
                return null;
            }
            ColaList.Remove(cola);
            return cola;
        }
    }
}
