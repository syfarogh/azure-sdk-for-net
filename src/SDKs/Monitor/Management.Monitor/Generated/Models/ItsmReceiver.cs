// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Itsm receiver.
    /// </summary>
    public partial class ItsmReceiver
    {
        /// <summary>
        /// Initializes a new instance of the ItsmReceiver class.
        /// </summary>
        public ItsmReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItsmReceiver class.
        /// </summary>
        /// <param name="name">The name of the Itsm receiver. Names must be
        /// unique across all receivers within an action group.</param>
        /// <param name="workspaceId">OMS LA instance identifier.</param>
        /// <param name="connectionId">Unique identification of ITSM connection
        /// among multiple defined in above workspace.</param>
        /// <param name="ticketConfiguration">JSON blob for the configurations
        /// of the ITSM action. CreateMultipleWorkItems option will be part of
        /// this blob as well.</param>
        /// <param name="region">Region in which workspace resides. Supported
        /// values:'centralindia','japaneast','southeastasia','australiasoutheast','uksouth','westcentralus','canadacentral','eastus','westeurope'</param>
        public ItsmReceiver(string name, string workspaceId, string connectionId, string ticketConfiguration, string region)
        {
            Name = name;
            WorkspaceId = workspaceId;
            ConnectionId = connectionId;
            TicketConfiguration = ticketConfiguration;
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Itsm receiver. Names must be unique
        /// across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets OMS LA instance identifier.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets unique identification of ITSM connection among
        /// multiple defined in above workspace.
        /// </summary>
        [JsonProperty(PropertyName = "connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets JSON blob for the configurations of the ITSM action.
        /// CreateMultipleWorkItems option will be part of this blob as well.
        /// </summary>
        [JsonProperty(PropertyName = "ticketConfiguration")]
        public string TicketConfiguration { get; set; }

        /// <summary>
        /// Gets or sets region in which workspace resides. Supported
        /// values:'centralindia','japaneast','southeastasia','australiasoutheast','uksouth','westcentralus','canadacentral','eastus','westeurope'
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (WorkspaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspaceId");
            }
            if (ConnectionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionId");
            }
            if (TicketConfiguration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TicketConfiguration");
            }
            if (Region == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Region");
            }
        }
    }
}
