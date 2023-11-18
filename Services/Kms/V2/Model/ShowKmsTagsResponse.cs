using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FeCloud.SDK.Core;

namespace FeCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowKmsTagsResponse : SdkResponse
    {

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagItem> Tags { get; set; }

        [JsonProperty("existTagsNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExistTagsNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKmsTagsResponse {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  existTagsNum: ").Append(ExistTagsNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKmsTagsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKmsTagsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ExistTagsNum == input.ExistTagsNum ||
                    (this.ExistTagsNum != null &&
                    this.ExistTagsNum.Equals(input.ExistTagsNum))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ExistTagsNum != null)
                    hashCode = hashCode * 59 + this.ExistTagsNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
