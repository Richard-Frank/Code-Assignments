using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RF.VehicleTracker.BL;

namespace RF.VehicleTracker.SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVehicle" in both code and config file together.
    [ServiceContract]
    public interface IVehicle
    {
        [OperationContract]
        CVehicleList GetVehicles();

        [OperationContract]
        void Insert(Guid colorId, Guid makeId, Guid modelId, string vin, int year);

        [OperationContract]
        void Update(Guid id, Guid colorId, Guid makeId, Guid modelId, string vin, int year);

        [OperationContract]
        void Delete(Guid id);

        [OperationContract]
        CVehicle GetById(Guid id);

        [OperationContract]
        void UpdateObj(CVehicle vehicle);

        [OperationContract]
        void DeleteObj(CVehicle vehicle);
    }
}
