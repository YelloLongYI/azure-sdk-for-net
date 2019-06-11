// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list Kusto database principals operation request.
    /// </summary>
    public partial class DatabasePrincipalListRequest
    {
        /// <summary>
        /// Initializes a new instance of the DatabasePrincipalListRequest
        /// class.
        /// </summary>
        public DatabasePrincipalListRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabasePrincipalListRequest
        /// class.
        /// </summary>
        /// <param name="value">The list of Kusto database principals.</param>
        public DatabasePrincipalListRequest(IList<DatabasePrincipal> value = default(IList<DatabasePrincipal>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Kusto database principals.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<DatabasePrincipal> Value { get; set; }

    }
}