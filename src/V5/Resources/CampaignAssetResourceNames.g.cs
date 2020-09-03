// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>CampaignAsset</c> resource.</summary>
    public sealed partial class CampaignAssetName : gax::IResourceName, sys::IEquatable<CampaignAssetName>
    {
        /// <summary>The possible contents of <see cref="CampaignAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
            /// </summary>
            CustomerCampaignAsset = 1
        }

        private static gax::PathTemplate s_customerCampaignAsset = new gax::PathTemplate("customers/{customer}/campaignAssets/{campaign_asset}");

        /// <summary>Creates a <see cref="CampaignAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignAssetName"/> with the pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignAssetId">The <c>CampaignAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignAssetName"/> constructed from the provided ids.</returns>
        public static CampaignAssetName FromCustomerCampaignAsset(string customerId, string campaignAssetId) =>
            new CampaignAssetName(ResourceNameType.CustomerCampaignAsset, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignAssetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignAssetId, nameof(campaignAssetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignAssetName"/> with pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignAssetId">The <c>CampaignAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignAssetName"/> with pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignAssetId) =>
            FormatCustomerCampaignAsset(customerId, campaignAssetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignAssetName"/> with pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignAssetId">The <c>CampaignAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignAssetName"/> with pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>.
        /// </returns>
        public static string FormatCustomerCampaignAsset(string customerId, string campaignAssetId) =>
            s_customerCampaignAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignAssetId, nameof(campaignAssetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/campaignAssets/{campaign_asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignAssetName"/> if successful.</returns>
        public static CampaignAssetName Parse(string campaignAssetName) => Parse(campaignAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/campaignAssets/{campaign_asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignAssetName"/> if successful.</returns>
        public static CampaignAssetName Parse(string campaignAssetName, bool allowUnparsed) =>
            TryParse(campaignAssetName, allowUnparsed, out CampaignAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/campaignAssets/{campaign_asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignAssetName, out CampaignAssetName result) =>
            TryParse(campaignAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignAssetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/campaignAssets/{campaign_asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignAssetName, bool allowUnparsed, out CampaignAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignAssetName, nameof(campaignAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAsset.TryParseName(campaignAssetName, out resourceName))
            {
                result = FromCustomerCampaignAsset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignAssetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignAssetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignAssetId = campaignAssetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignAssetName"/> class from the component parts of pattern
        /// <c>customers/{customer}/campaignAssets/{campaign_asset}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignAssetId">The <c>CampaignAsset</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignAssetName(string customerId, string campaignAssetId) : this(ResourceNameType.CustomerCampaignAsset, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignAssetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignAssetId, nameof(campaignAssetId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>CampaignAsset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CampaignAssetId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignAsset: return s_customerCampaignAsset.Expand(CustomerId, CampaignAssetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignAssetName);

        /// <inheritdoc/>
        public bool Equals(CampaignAssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignAssetName a, CampaignAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignAssetName a, CampaignAssetName b) => !(a == b);
    }

    public partial class CampaignAsset
    {
        /// <summary>
        /// <see cref="CampaignAssetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignAssetName ResourceNameAsCampaignAssetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignAssetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}
