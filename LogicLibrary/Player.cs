using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
     public abstract class Player : IEquipment
     {
        public string Model { get; set; }
        int Memory { get; set; } // объём памяти
        public virtual double Value { get { return Powerspeaker * Yearissue; }}      
       // protected string _bodycolor; // цвет корпуса
        protected int Powerspeaker; // мощность динамика 
        protected int Yearissue; // год выпуска
        protected bool On;
        protected List<string> Songs = new List<string>();


        public string PlayMusic(string songName) 
        {
            foreach (string tmp in Songs)
            {
                if (tmp == songName)
                    return tmp;
            }
            return null;
        }

        public void OnPlayer()
        {
            if (On == false)
                On = true;
        }

        public void OfPlayer()
        {
            if (On == true)
                On = false;
        }

        public int GetMemory()
        {
            return Memory;
        }


    }
    
}
