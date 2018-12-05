using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public interface IEquipment
    {
        string Model { get; set; }
        //double Value { get; }
       // int PlayMusic(string songName);
        void OnPlayer();
        void OfPlayer();
        string PlayMusic(string songName);

    }
}
