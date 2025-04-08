using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public struct Запись_продаж
    {
        private int количество;
        private int день;
        private Описание_Авто товар;

        public Запись_продаж(int количество, int день, Описание_Авто товар)
        {
            if (количество <= 0) throw new ArgumentException("Количество должно быть положительным");
            if (день < 1 || день > 31) throw new ArgumentException("День должен быть от 1 до 31");

            this.количество = количество;
            this.день = день;
            this.товар = товар ?? throw new ArgumentNullException(nameof(товар));
        }

        public int ПолучитьКоличество() => количество;
        public int ПолучитьДень() => день;
        public Описание_Авто ПолучитьТовар() => товар;
        public decimal ПолучитьСумму() => количество * товар.ПолучитьЦену();
    }
}