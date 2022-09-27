using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
    public class CWoodwind : CInstrument
    {

        private int _reedsize;

        public int Reedsize
        {
            get { return _reedsize; }
            set { _reedsize = value; }
        }

        private string _reedtype;

        public string Reedtype
        {
            get { return _reedtype; }
            set { _reedtype = value; }
        }
       
        public CWoodwind()
        {
        }

        public CWoodwind(string reedtype, int reedsize, float _cost, string _manufacturer, string _model, InstrumentType _instrumentType)
        {
            _reedsize = reedsize;
            _reedtype = reedtype;
            this.Cost = _cost;
            this.Manufacturer = _manufacturer;
            this.Model = _model;
            this.InstrumentType = _instrumentType;

        }
    }
}
