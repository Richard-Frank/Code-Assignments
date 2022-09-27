using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Enumerations;

 namespace HeidsMusic.Interfaces
{
    public interface IInstrument
    {
        bool Save();
        bool Load();

        string Manufacturer { get; set; }
        float Cost { get; set; }
        string Model { get; set; }
        InstrumentType InstrumentType { get; set; }
    }

    public interface IInstruments
    {
        void Save();
        
    }
}


