/*
 * Ready4Tech API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace IO.Swagger.Models;

/// <summary>
///     Input request for DawnDusk Calculation
/// </summary>
[DataContract]
public class DawnDuskCalculationInputRequest : IEquatable<DawnDuskCalculationInputRequest>
{
    /// <summary>
    ///     Coordinate of the location
    /// </summary>
    /// <value>Coordinate of the location</value>
    [Required]
    [DataMember(Name = "Coordinates")]
    public AllOfDawnDuskCalculationInputRequestCoordinates Coordinates { get; set; }

    /// <summary>
    ///     Date for the DawnDusk calculation
    /// </summary>
    /// <value>Date for the DawnDusk calculation</value>
    [Required]
    [DataMember(Name = "Date")]
    public DateTime? Date { get; set; }

    /// <summary>
    ///     Returns true if DawnDuskCalculationInputRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of DawnDuskCalculationInputRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DawnDuskCalculationInputRequest other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;

        return
            (
                Coordinates == other.Coordinates ||
                (Coordinates != null &&
                 Coordinates.Equals(other.Coordinates))
            ) &&
            (
                Date == other.Date ||
                (Date != null &&
                 Date.Equals(other.Date))
            );
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DawnDuskCalculationInputRequest {\n");
        sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

    /// <summary>
    ///     Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((DawnDuskCalculationInputRequest)obj);
    }

    /// <summary>
    ///     Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            // Suitable nullity checks etc, of course :)
            if (Coordinates != null)
                hashCode = hashCode * 59 + Coordinates.GetHashCode();
            if (Date != null)
                hashCode = hashCode * 59 + Date.GetHashCode();
            return hashCode;
        }
    }

    #region Operators

#pragma warning disable 1591

    public static bool operator ==(DawnDuskCalculationInputRequest left, DawnDuskCalculationInputRequest right) =>
        Equals(left, right);

    public static bool operator !=(DawnDuskCalculationInputRequest left, DawnDuskCalculationInputRequest right) =>
        !Equals(left, right);

#pragma warning restore 1591

    #endregion Operators
}