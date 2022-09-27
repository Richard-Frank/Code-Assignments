using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
    public class CBrass : CInstrument
    {
        private string _sFinish;

        public string Finish
        {
            get { return _sFinish; }
            set { _sFinish = value; }
        }

        private int _iValveCount;

        public int ValveCount
        {
           get { return _iValveCount; }
           set { _iValveCount = value; }
        }

      

        public CBrass()
        {
        }

        public CBrass(string finish, int valvecount, float _cost, string _manufacturer, string _model, InstrumentType _instrumentType)
        {
            _sFinish = finish;
            _iValveCount = valvecount;
            this.Cost = _cost;
            this.Manufacturer = _manufacturer;
            this.Model = _model;
            this.InstrumentType = _instrumentType;

        }
    }
}
