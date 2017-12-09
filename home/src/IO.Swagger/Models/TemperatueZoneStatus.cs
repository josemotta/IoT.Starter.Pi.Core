/*
 * home-api
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
    /// status of a single zone
    /// </summary>
    [DataContract]
    public partial class TemperatueZoneStatus :  IEquatable<TemperatueZoneStatus>
    { 
        /// <summary>
        /// the unique identifier for the zone
        /// </summary>
        /// <value>the unique identifier for the zone</value>
        [Required]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// the name of the zone
        /// </summary>
        /// <value>the name of the zone</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// the temperature in the zone
        /// </summary>
        /// <value>the temperature in the zone</value>
        [Required]
        [DataMember(Name="value")]
        public double? Value { get; set; }
        /// <summary>
        /// the temperature units
        /// </summary>
        /// <value>the temperature units</value>
        public enum UnitsEnum
        { 
            /// <summary>
            /// Enum CelciusEnum for "celcius"
            /// </summary>
            [EnumMember(Value = "celcius")]
            CelciusEnum = 1,
            
            /// <summary>
            /// Enum FahrenheitEnum for "fahrenheit"
            /// </summary>
            [EnumMember(Value = "fahrenheit")]
            FahrenheitEnum = 2
        }

        /// <summary>
        /// the temperature units
        /// </summary>
        /// <value>the temperature units</value>
        [DataMember(Name="units")]
        public UnitsEnum? Units { get; set; }

        /// <summary>
        /// the timestamp when the temperature was measured
        /// </summary>
        /// <value>the timestamp when the temperature was measured</value>
        [Required]
        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemperatueZoneStatus {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TemperatueZoneStatus)obj);
        }

        /// <summary>
        /// Returns true if TemperatueZoneStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of TemperatueZoneStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemperatueZoneStatus other)
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
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Units == other.Units ||
                    Units != null &&
                    Units.Equals(other.Units)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
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
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Units != null)
                    hashCode = hashCode * 59 + Units.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TemperatueZoneStatus left, TemperatueZoneStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemperatueZoneStatus left, TemperatueZoneStatus right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
