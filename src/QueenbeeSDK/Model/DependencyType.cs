/* 
 * Queenbee Recipe Schema
 *
 * Schema documentation for Queenbee Recipes
 *
 * The version of the OpenAPI document: 1.17.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace QueenbeeSDK.Model
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DependencyType
    {
        /// <summary>
        /// Enum Recipe for value: recipe
        /// </summary>
        [EnumMember(Value = "recipe")]
        Recipe = 1,

        /// <summary>
        /// Enum Operator for value: operator
        /// </summary>
        [EnumMember(Value = "operator")]
        Operator = 2

    }

}
