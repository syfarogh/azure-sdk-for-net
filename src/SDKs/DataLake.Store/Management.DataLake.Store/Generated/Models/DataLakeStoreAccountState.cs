// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataLakeStoreAccountState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataLakeStoreAccountState
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Suspended")]
        Suspended
    }
    internal static class DataLakeStoreAccountStateEnumExtension
    {
        internal static string ToSerializedValue(this DataLakeStoreAccountState? value)  =>
            value == null ? null : ((DataLakeStoreAccountState)value).ToSerializedValue();

        internal static string ToSerializedValue(this DataLakeStoreAccountState value)
        {
            switch( value )
            {
                case DataLakeStoreAccountState.Active:
                    return "Active";
                case DataLakeStoreAccountState.Suspended:
                    return "Suspended";
            }
            return null;
        }

        internal static DataLakeStoreAccountState? ParseDataLakeStoreAccountState(this string value)
        {
            switch( value )
            {
                case "Active":
                    return DataLakeStoreAccountState.Active;
                case "Suspended":
                    return DataLakeStoreAccountState.Suspended;
            }
            return null;
        }
    }
}