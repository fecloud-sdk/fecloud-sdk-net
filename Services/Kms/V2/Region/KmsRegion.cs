using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2
{
    public class KmsRegion
    {
        public static readonly Region EU_WEST_0 = new Region("eu-west-0",
            "https://kms.eu-west-0.prod-cloud-ocb.orange-business.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("KMS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "eu-west-0", EU_WEST_0 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}