// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An intent detected from the utterance.
    /// </summary>
    public partial class IntentModel
    {
        /// <summary>
        /// Initializes a new instance of the IntentModel class.
        /// </summary>
        public IntentModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntentModel class.
        /// </summary>
        /// <param name="intent">Name of the intent, as defined in
        /// LUIS.</param>
        /// <param name="score">Associated prediction score for the intent
        /// (float).</param>
        public IntentModel(string intent = default(string), double? score = default(double?))
        {
            Intent = intent;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the intent, as defined in LUIS.
        /// </summary>
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

        /// <summary>
        /// Gets or sets associated prediction score for the intent (float).
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Score > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Score", 1);
            }
            if (Score < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Score", 0);
            }
        }
    }
}