using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IColor" in both code and config file together.
    [ServiceContract]
    public interface IColor
    {
        [OperationContract]
        void InsertObj(CColor color);

        [OperationContract]
        CColorList GetColors();

        [OperationContract]
        void Insert(string description);

        [OperationContract]
        void Update(Guid id, string description);

        [OperationContract]
        void Delete(Guid id);

        [OperationContract]
        CColor GetById(Guid id);

        [OperationContract]
        void UpdateObj(CColor color);

        [OperationContract]
        void DeleteObj(CColor color);

    }
}
