using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace HolaSilverlightWCF4.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SimpleService
    {
        [OperationContract]
        public void DoWork()
        {
            // Agregue aquí la implementación de la operación
            return;
        }

        // Agregue aquí más operaciones y márquelas con [OperationContract]
        [OperationContract]
        public string HelloWorld() 
        {
            return "Hello World SiverLight!!!";

        }
    }
}
