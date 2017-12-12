/*
 * home
 *
 * The API for the Home Starter project
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// a single temperature zone
    /// </summary>
    [DataContract]
    public partial class TemperatureZone :  IEquatable<TemperatureZone>
    { 
        /// <summary>
        /// the unique identifier for the zone
        /// </summary>
        /// <value>the unique identifier for the zone</value>
        [Required]
        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets InputPosition
        /// </summary>
        [DataMember(Name="inputPosition")]
        public int? InputPosition { get; set; }

        /// <summary>
        /// Gets or Sets OutputPosition
        /// </summary>
        [DataMember(Name="outputPosition")]
        public int? OutputPosition { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone")]
        public string Zone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemperatureZone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InputPosition: ").Append(InputPosition).Append("\n");
            sb.Append("  OutputPosition: ").Append(OutputPosition).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((TemperatureZone)obj);
        }

        /// <summary>
        /// Returns true if TemperatureZone instances are equal
        /// </summary>
        /// <param name="other">Instance of TemperatureZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemperatureZone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    InputPosition == other.InputPosition ||
                    InputPosition != null &&
                    InputPosition.Equals(other.InputPosition)
                ) && 
                (
                    OutputPosition == other.OutputPosition ||
                    OutputPosition != null &&
                    OutputPosition.Equals(other.OutputPosition)
                ) && 
                (
                    Zone == other.Zone ||
                    Zone != null &&
                    Zone.Equals(other.Zone)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (InputPosition != null)
                    hashCode = hashCode * 59 + InputPosition.GetHashCode();
                    if (OutputPosition != null)
                    hashCode = hashCode * 59 + OutputPosition.GetHashCode();
                    if (Zone != null)
                    hashCode = hashCode * 59 + Zone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TemperatureZone left, TemperatureZone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemperatureZone left, TemperatureZone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
