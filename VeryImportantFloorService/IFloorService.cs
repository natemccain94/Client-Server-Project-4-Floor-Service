using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VeryImportantFloorService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IFloorService
    {
        /// <summary>
        /// Gets the floor plate one value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetFloorPlateOneVal();

        /// <summary>
        /// Gets the floor plate two value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetFloorPlateTwoVal();

        /// <summary>
        /// Gets the floor plate three value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetFloorPlateThreeVal();

        /// <summary>
        /// Gets the floor plate four value.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetFloorPlateFourVal();
    }
}
