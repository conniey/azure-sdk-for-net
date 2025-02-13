// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The array of costs of a lab services SKU. </summary>
    public partial class AvailableLabServicesSkuCost
    {
        /// <summary> Initializes a new instance of <see cref="AvailableLabServicesSkuCost"/>. </summary>
        internal AvailableLabServicesSkuCost()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailableLabServicesSkuCost"/>. </summary>
        /// <param name="meterId"> The meter id. </param>
        /// <param name="quantity"> The quantity of units charged. </param>
        /// <param name="extendedUnit"> The extended unit. </param>
        internal AvailableLabServicesSkuCost(string meterId, float? quantity, string extendedUnit)
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
        }

        /// <summary> The meter id. </summary>
        public string MeterId { get; }
        /// <summary> The quantity of units charged. </summary>
        public float? Quantity { get; }
        /// <summary> The extended unit. </summary>
        public string ExtendedUnit { get; }
    }
}
