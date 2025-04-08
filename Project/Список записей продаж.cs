using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Список_продаж
    {
        private Dictionary<Автомобили, List<Запись_продаж>> продажи = new Dictionary<Автомобили, List<Запись_продаж>>();

        public void ДобавитьПродажу(Автомобили тип, Запись_продаж запись)
        {
            if (!продажи.ContainsKey(тип))
                продажи[тип] = new List<Запись_продаж>(); 

            продажи[тип].Add(запись);
        }

        public List<Запись_продаж> ПолучитьПродажи(Автомобили тип) =>
            продажи.ContainsKey(тип) ? продажи[тип] : new List<Запись_продаж>();

        public decimal ПолучитьСуммуПоКатегории(Автомобили тип) =>
            ПолучитьПродажи(тип).Sum(продажа => продажа.ПолучитьСумму());
    }
}
