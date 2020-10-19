/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Triangle
    /// </summary>
    [DataContract(Name = "Triangle")]
    public partial class Triangle : AbstractOpenAPISchema, IEquatable<Triangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class
        /// with the <see cref="EquilateralTriangle" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EquilateralTriangle.</param>
        public Triangle(EquilateralTriangle actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class
        /// with the <see cref="IsoscelesTriangle" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IsoscelesTriangle.</param>
        public Triangle(IsoscelesTriangle actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class
        /// with the <see cref="ScaleneTriangle" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ScaleneTriangle.</param>
        public Triangle(ScaleneTriangle actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(EquilateralTriangle))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IsoscelesTriangle))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ScaleneTriangle))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: EquilateralTriangle, IsoscelesTriangle, ScaleneTriangle");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `EquilateralTriangle`. If the actual instanct is not `EquilateralTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EquilateralTriangle</returns>
        public EquilateralTriangle GetEquilateralTriangle()
        {
            return (EquilateralTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IsoscelesTriangle`. If the actual instanct is not `IsoscelesTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IsoscelesTriangle</returns>
        public IsoscelesTriangle GetIsoscelesTriangle()
        {
            return (IsoscelesTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ScaleneTriangle`. If the actual instanct is not `ScaleneTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ScaleneTriangle</returns>
        public ScaleneTriangle GetScaleneTriangle()
        {
            return (ScaleneTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Triangle {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, _serializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Triangle
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Triangle</returns>
        public static Triangle FromJson(string jsonString)
        {
            Triangle newTriangle = null;
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                newTriangle = new Triangle(JsonConvert.DeserializeObject<EquilateralTriangle>(jsonString, newTriangle._serializerSettings));
                matchedTypes.Add("EquilateralTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into EquilateralTriangle: %s", jsonString, exception.ToString()));
            }

            try
            {
                newTriangle = new Triangle(JsonConvert.DeserializeObject<IsoscelesTriangle>(jsonString, newTriangle._serializerSettings));
                matchedTypes.Add("IsoscelesTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into IsoscelesTriangle: %s", jsonString, exception.ToString()));
            }

            try
            {
                newTriangle = new Triangle(JsonConvert.DeserializeObject<ScaleneTriangle>(jsonString, newTriangle._serializerSettings));
                matchedTypes.Add("ScaleneTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `%s` into ScaleneTriangle: %s", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newTriangle;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Triangle).AreEqual;
        }

        /// <summary>
        /// Returns true if Triangle instances are equal
        /// </summary>
        /// <param name="input">Instance of Triangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Triangle input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
