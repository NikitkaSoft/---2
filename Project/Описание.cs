using System;

namespace Project
{
    internal class Описание_Авто
    {
        private string название;
        private decimal цена;

        public Описание_Авто(string название, decimal цена)
        {
            this.название = название;
            this.цена = цена;
        }

        public string ПолучитьНазвание() => название;
        public decimal ПолучитьЦену() => цена;
    }
}