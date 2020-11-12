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
    /// <summary>Resource name for the <c>DetailPlacementView</c> resource.</summary>
    public sealed partial class DetailPlacementViewName : gax::IResourceName, sys::IEquatable<DetailPlacementViewName>
    {
        /// <summary>The possible contents of <see cref="DetailPlacementViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
            /// </summary>
            CustomerDetailPlacementView = 1,
        }

        private static gax::PathTemplate s_customerDetailPlacementView = new gax::PathTemplate("customers/{customer}/detailPlacementViews/{detail_placement_view}");

        /// <summary>Creates a <see cref="DetailPlacementViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DetailPlacementViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DetailPlacementViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DetailPlacementViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DetailPlacementViewName"/> with the pattern
        /// <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailPlacementViewId">
        /// The <c>DetailPlacementView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DetailPlacementViewName"/> constructed from the provided ids.
        /// </returns>
        public static DetailPlacementViewName FromCustomerDetailPlacementView(string customerId, string detailPlacementViewId) =>
            new DetailPlacementViewName(ResourceNameType.CustomerDetailPlacementView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), detailPlacementViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(detailPlacementViewId, nameof(detailPlacementViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DetailPlacementViewName"/> with pattern
        /// <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailPlacementViewId">
        /// The <c>DetailPlacementView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailPlacementViewName"/> with pattern
        /// <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
        /// </returns>
        public static string Format(string customerId, string detailPlacementViewId) =>
            FormatCustomerDetailPlacementView(customerId, detailPlacementViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DetailPlacementViewName"/> with pattern
        /// <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailPlacementViewId">
        /// The <c>DetailPlacementView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailPlacementViewName"/> with pattern
        /// <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>.
        /// </returns>
        public static string FormatCustomerDetailPlacementView(string customerId, string detailPlacementViewId) =>
            s_customerDetailPlacementView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(detailPlacementViewId, nameof(detailPlacementViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailPlacementViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DetailPlacementViewName"/> if successful.</returns>
        public static DetailPlacementViewName Parse(string detailPlacementViewName) => Parse(detailPlacementViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailPlacementViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailPlacementViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DetailPlacementViewName"/> if successful.</returns>
        public static DetailPlacementViewName Parse(string detailPlacementViewName, bool allowUnparsed) =>
            TryParse(detailPlacementViewName, allowUnparsed, out DetailPlacementViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DetailPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailPlacementViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailPlacementViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailPlacementViewName, out DetailPlacementViewName result) =>
            TryParse(detailPlacementViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DetailPlacementViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailPlacementViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailPlacementViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailPlacementViewName, bool allowUnparsed, out DetailPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(detailPlacementViewName, nameof(detailPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerDetailPlacementView.TryParseName(detailPlacementViewName, out resourceName))
            {
                result = FromCustomerDetailPlacementView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(detailPlacementViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DetailPlacementViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string detailPlacementViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            DetailPlacementViewId = detailPlacementViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DetailPlacementViewName"/> class from the component parts of
        /// pattern <c>customers/{customer}/detailPlacementViews/{detail_placement_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailPlacementViewId">
        /// The <c>DetailPlacementView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DetailPlacementViewName(string customerId, string detailPlacementViewId) : this(ResourceNameType.CustomerDetailPlacementView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), detailPlacementViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(detailPlacementViewId, nameof(detailPlacementViewId)))
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
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>DetailPlacementView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DetailPlacementViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerDetailPlacementView: return s_customerDetailPlacementView.Expand(CustomerId, DetailPlacementViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DetailPlacementViewName);

        /// <inheritdoc/>
        public bool Equals(DetailPlacementViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DetailPlacementViewName a, DetailPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DetailPlacementViewName a, DetailPlacementViewName b) => !(a == b);
    }

    public partial class DetailPlacementView
    {
        /// <summary>
        /// <see cref="DetailPlacementViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal DetailPlacementViewName ResourceNameAsDetailPlacementViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DetailPlacementViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}
