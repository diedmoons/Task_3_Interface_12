using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
   public class Videoplayer : Player
    {
        bool _onvideo;

        public int SoundAmplification { get; set; }
        public override double Value {
            get
            {
                return (double)Powerspeaker * Yearissue + Convert.ToDouble(_onvideo);
            }
        }
       public Videoplayer() { }
        public Videoplayer(string model, int powerspeaker, int yearissue/*, bool on, bool onvideo*/)
        {
            Model = model;
            Powerspeaker = powerspeaker;
            Yearissue = yearissue;
            On = true;
            _onvideo = true;
        }


     /*   public Videoplayer(bool onvideo)
        {
            _onvideo = onvideo;
        }
    */

        public void OnVideo()
        {
            if (_onvideo == false)
                _onvideo = true;
        }

        public void OfVideo()
        {
            if (_onvideo == true)
                _onvideo = false;
        }

        public string GetInfo()
        {
            string info = "";
            info += Environment.NewLine;
            info += "Модель: ";
            info += Model.ToString();
            info += Environment.NewLine;
            info += "Мощность динамика: ";
            info += Powerspeaker.ToString();
            info += Environment.NewLine;
            info += "Год выпуска: ";
            info += Yearissue.ToString();
            info += Environment.NewLine;

            return info;
        }


    }
}
