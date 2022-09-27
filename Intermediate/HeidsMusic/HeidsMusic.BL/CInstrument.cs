using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.Enumerations;

namespace HeidsMusic.BL
{
   

    public abstract class CInstrument : IInstrument
    {
        private string _sManufacturer;
        private float _fCost;
        private string _sModel;
        private InstrumentType _IinstrumentType;
 
        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Load()
        {
            throw new NotImplementedException();
        }

        public string Manufacturer
        {
            get
            {
                return _sManufacturer;
            }
            set
            {
                _sManufacturer = value;
            }
        }

        public float Cost
        {
            get
            {
                return _fCost;
            }

            set
            {
                _fCost = value;
            }
        }

        public string Model
        {
            get
            {
                return _sModel;
            }
            set
            {
                _sModel = value;
            }
        }

        public CInstrument()
        {

        }

        public CInstrument(float cost, InstrumentType insterumentType, string manufacturer, string model)
        {
            _fCost = cost;
            _IinstrumentType = insterumentType;
            _sManufacturer = manufacturer;
            _sModel = model;     
        }


        public InstrumentType InstrumentType
        {
            get
            {
                return _IinstrumentType;
            }
            set
            {
                _IinstrumentType = value;
            }
        }
    }
}
