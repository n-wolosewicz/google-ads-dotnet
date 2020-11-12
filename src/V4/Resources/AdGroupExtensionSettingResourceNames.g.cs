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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>AdGroupExtensionSetting</c> resource.</summary>
    public sealed partial class AdGroupExtensionSettingName : gax::IResourceName, sys::IEquatable<AdGroupExtensionSettingName>
    {
        /// <summary>The possible contents of <see cref="AdGroupExtensionSettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
            /// </summary>
            CustomerAdGroupExtensionSetting = 1,
        }

        private static gax::PathTemplate s_customerAdGroupExtensionSetting = new gax::PathTemplate("customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}");

        /// <summary>Creates a <see cref="AdGroupExtensionSettingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupExtensionSettingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupExtensionSettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupExtensionSettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupExtensionSettingName"/> with the pattern
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupExtensionSettingId">
        /// The <c>AdGroupExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AdGroupExtensionSettingName"/> constructed from the provided ids.
        /// </returns>
        public static AdGroupExtensionSettingName FromCustomerAdGroupExtensionSetting(string customerId, string adGroupExtensionSettingId) =>
            new AdGroupExtensionSettingName(ResourceNameType.CustomerAdGroupExtensionSetting, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupExtensionSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupExtensionSettingId, nameof(adGroupExtensionSettingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupExtensionSettingName"/> with
        /// pattern <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupExtensionSettingId">
        /// The <c>AdGroupExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupExtensionSettingName"/> with pattern
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupExtensionSettingId) =>
            FormatCustomerAdGroupExtensionSetting(customerId, adGroupExtensionSettingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupExtensionSettingName"/> with
        /// pattern <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupExtensionSettingId">
        /// The <c>AdGroupExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupExtensionSettingName"/> with pattern
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupExtensionSetting(string customerId, string adGroupExtensionSettingId) =>
            s_customerAdGroupExtensionSetting.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupExtensionSettingId, nameof(adGroupExtensionSettingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupExtensionSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupExtensionSettingName"/> if successful.</returns>
        public static AdGroupExtensionSettingName Parse(string adGroupExtensionSettingName) =>
            Parse(adGroupExtensionSettingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupExtensionSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupExtensionSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupExtensionSettingName"/> if successful.</returns>
        public static AdGroupExtensionSettingName Parse(string adGroupExtensionSettingName, bool allowUnparsed) =>
            TryParse(adGroupExtensionSettingName, allowUnparsed, out AdGroupExtensionSettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupExtensionSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupExtensionSettingName, out AdGroupExtensionSettingName result) =>
            TryParse(adGroupExtensionSettingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupExtensionSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupExtensionSettingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupExtensionSettingName, bool allowUnparsed, out AdGroupExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupExtensionSettingName, nameof(adGroupExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupExtensionSetting.TryParseName(adGroupExtensionSettingName, out resourceName))
            {
                result = FromCustomerAdGroupExtensionSetting(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupExtensionSettingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupExtensionSettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupExtensionSettingId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupExtensionSettingId = adGroupExtensionSettingId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupExtensionSettingName"/> class from the component parts of
        /// pattern <c>customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupExtensionSettingId">
        /// The <c>AdGroupExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupExtensionSettingName(string customerId, string adGroupExtensionSettingId) : this(ResourceNameType.CustomerAdGroupExtensionSetting, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupExtensionSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupExtensionSettingId, nameof(adGroupExtensionSettingId)))
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
        /// The <c>AdGroupExtensionSetting</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AdGroupExtensionSettingId { get; }

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
                case ResourceNameType.CustomerAdGroupExtensionSetting: return s_customerAdGroupExtensionSetting.Expand(CustomerId, AdGroupExtensionSettingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupExtensionSettingName);

        /// <inheritdoc/>
        public bool Equals(AdGroupExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupExtensionSettingName a, AdGroupExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupExtensionSettingName a, AdGroupExtensionSettingName b) => !(a == b);
    }

    public partial class AdGroupExtensionSetting
    {
        /// <summary>
        /// <see cref="AdGroupExtensionSettingName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AdGroupExtensionSettingName ResourceNameAsAdGroupExtensionSettingName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupExtensionSettingName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExtensionFeedItemName"/>-typed view over the <see cref="ExtensionFeedItems"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ExtensionFeedItemName> ExtensionFeedItemsAsExtensionFeedItemNames
        {
            get => new gax::ResourceNameList<ExtensionFeedItemName>(ExtensionFeedItems, s => string.IsNullOrEmpty(s) ? null : ExtensionFeedItemName.Parse(s, allowUnparsed: true));
        }
    }
}
