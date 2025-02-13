// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Sampling settings for Diagnostic. </summary>
    public partial class SamplingSettings
    {
        /// <summary> Initializes a new instance of <see cref="SamplingSettings"/>. </summary>
        public SamplingSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SamplingSettings"/>. </summary>
        /// <param name="samplingType"> Sampling type. </param>
        /// <param name="percentage"> Rate of sampling for fixed-rate sampling. </param>
        internal SamplingSettings(SamplingType? samplingType, double? percentage)
        {
            SamplingType = samplingType;
            Percentage = percentage;
        }

        /// <summary> Sampling type. </summary>
        public SamplingType? SamplingType { get; set; }
        /// <summary> Rate of sampling for fixed-rate sampling. </summary>
        public double? Percentage { get; set; }
    }
}
