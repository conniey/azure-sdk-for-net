// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    public partial class ProjectData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourcePlatform))
            {
                writer.WritePropertyName("sourcePlatform"u8);
                writer.WriteStringValue(SourcePlatform.Value.ToString());
            }
            if (Optional.IsDefined(AzureAuthenticationInfo))
            {
                writer.WritePropertyName("azureAuthenticationInfo"u8);
                writer.WriteObjectValue(AzureAuthenticationInfo);
            }
            if (Optional.IsDefined(TargetPlatform))
            {
                writer.WritePropertyName("targetPlatform"u8);
                writer.WriteStringValue(TargetPlatform.Value.ToString());
            }
            if (Optional.IsDefined(SourceConnectionInfo))
            {
                writer.WritePropertyName("sourceConnectionInfo"u8);
                writer.WriteObjectValue(SourceConnectionInfo);
            }
            if (Optional.IsDefined(TargetConnectionInfo))
            {
                writer.WritePropertyName("targetConnectionInfo"u8);
                writer.WriteObjectValue(TargetConnectionInfo);
            }
            if (Optional.IsCollectionDefined(DatabasesInfo))
            {
                writer.WritePropertyName("databasesInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DatabasesInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProjectData DeserializeProjectData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProjectSourcePlatform> sourcePlatform = default;
            Optional<AzureActiveDirectoryApp> azureAuthenticationInfo = default;
            Optional<ProjectTargetPlatform> targetPlatform = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<ConnectionInfo> sourceConnectionInfo = default;
            Optional<ConnectionInfo> targetConnectionInfo = default;
            Optional<IList<DatabaseInfo>> databasesInfo = default;
            Optional<ProjectProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourcePlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourcePlatform = new ProjectSourcePlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureAuthenticationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureAuthenticationInfo = AzureActiveDirectoryApp.DeserializeAzureActiveDirectoryApp(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetPlatform = new ProjectTargetPlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceConnectionInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetConnectionInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("databasesInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DatabaseInfo> array = new List<DatabaseInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseInfo.DeserializeDatabaseInfo(item));
                            }
                            databasesInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProjectProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProjectData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToNullable(sourcePlatform), azureAuthenticationInfo.Value, Optional.ToNullable(targetPlatform), Optional.ToNullable(creationTime), sourceConnectionInfo.Value, targetConnectionInfo.Value, Optional.ToList(databasesInfo), Optional.ToNullable(provisioningState));
        }
    }
}
