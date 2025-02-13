// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareDicomImageCreatedEventDataConverter))]
    public partial class HealthcareDicomImageCreatedEventData
    {
        internal static HealthcareDicomImageCreatedEventData DeserializeHealthcareDicomImageCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> partitionName = default;
            Optional<string> imageStudyInstanceUid = default;
            Optional<string> imageSeriesInstanceUid = default;
            Optional<string> imageSopInstanceUid = default;
            Optional<string> serviceHostName = default;
            Optional<long> sequenceNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
            }
            return new HealthcareDicomImageCreatedEventData(partitionName.Value, imageStudyInstanceUid.Value, imageSeriesInstanceUid.Value, imageSopInstanceUid.Value, serviceHostName.Value, Optional.ToNullable(sequenceNumber));
        }

        internal partial class HealthcareDicomImageCreatedEventDataConverter : JsonConverter<HealthcareDicomImageCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareDicomImageCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override HealthcareDicomImageCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareDicomImageCreatedEventData(document.RootElement);
            }
        }
    }
}
