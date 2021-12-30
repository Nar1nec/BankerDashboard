using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_Forms_
{
    class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public string Telephone_number { get; set; }

        //Адрес
        public string Address { get; set; }


        //Паспортные данные
        public string Number_pass { get; set; }
        public string Series { get; set; }

        //Дата рождения
        public string Date_Birth { get; set; }
    }
}
