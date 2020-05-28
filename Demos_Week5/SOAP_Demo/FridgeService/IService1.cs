using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace FridgeService
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IFridge    {
        
        [OperationContract]
        void AddFood(int quantity, string food);
        
        [OperationContract]
        void SubtractFood(int quantity, string food);
        
        [OperationContract]
        Dictionary<string, int> Food();
        
        [OperationContract]
        void EmptyFridge();
    }
}