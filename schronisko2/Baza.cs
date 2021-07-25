using System;
using System.Collections.Generic;
using System.Text;

namespace schronisko2
{
    public abstract class Baza
    {
        public abstract class Animal
        {
            public string name{ get; protected set; }
            public string rasa { get; protected set; }
            public int wiek { get; protected set; }
            public int Length { get; }

            public void setName(String name)
            {
                this.name = name;
            }
        }
        protected abstract void dajglos();
                 


    }
}



