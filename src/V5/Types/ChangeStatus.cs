// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/resources/change_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/resources/change_status.proto</summary>
  public static partial class ChangeStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/resources/change_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9yZXNvdXJjZXMvY2hhbmdlX3N0",
            "YXR1cy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUucmVzb3VyY2Vz",
            "Gitnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9hZF90eXBlLnByb3Rv",
            "GkBnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3N1Yl90eXBlLnByb3RvGjxnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "NS9lbnVtcy9hZHZlcnRpc2luZ19jaGFubmVsX3R5cGUucHJvdG8aO2dvb2ds",
            "ZS9hZHMvZ29vZ2xlYWRzL3Y1L2VudW1zL2NoYW5nZV9zdGF0dXNfb3BlcmF0",
            "aW9uLnByb3RvGj9nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9jaGFu",
            "Z2Vfc3RhdHVzX3Jlc291cmNlX3R5cGUucHJvdG8aMmdvb2dsZS9hZHMvZ29v",
            "Z2xlYWRzL3Y1L2VudW1zL2NyaXRlcmlvbl90eXBlLnByb3RvGi9nb29nbGUv",
            "YWRzL2dvb2dsZWFkcy92NS9lbnVtcy9mZWVkX29yaWdpbi5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpQLCgxDaGFuZ2VTdGF0dXMS",
            "RAoNcmVzb3VyY2VfbmFtZRgBIAEoCUIt4EED+kEnCiVnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQ2hhbmdlU3RhdHVzEkAKFWxhc3RfY2hhbmdlX2RhdGVf",
            "dGltZRgDIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EED",
            "EnAKDXJlc291cmNlX3R5cGUYBCABKA4yVC5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52NS5lbnVtcy5DaGFuZ2VTdGF0dXNSZXNvdXJjZVR5cGVFbnVtLkNoYW5n",
            "ZVN0YXR1c1Jlc291cmNlVHlwZUID4EEDEkAKCGNhbXBhaWduGBEgASgJQing",
            "QQP6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkgAiAEB",
            "Ej8KCGFkX2dyb3VwGBIgASgJQijgQQP6QSIKIGdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9BZEdyb3VwSAGIAQESbAoPcmVzb3VyY2Vfc3RhdHVzGAggASgO",
            "Mk4uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51bXMuQ2hhbmdlU3RhdHVz",
            "T3BlcmF0aW9uRW51bS5DaGFuZ2VTdGF0dXNPcGVyYXRpb25CA+BBAxJdCgth",
            "ZF9ncm91cF9hZBgJIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1",
            "ZUIq4EED+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFk",
            "EmsKEmFkX2dyb3VwX2NyaXRlcmlvbhgKIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZUIx4EED+kErCilnb29nbGVhZHMuZ29vZ2xlYXBpcy5j",
            "b20vQWRHcm91cENyaXRlcmlvbhJsChJjYW1wYWlnbl9jcml0ZXJpb24YCyAB",
            "KAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCMuBBA/pBLAoqZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduQ3JpdGVyaW9uElEKBGZl",
            "ZWQYDCABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCJeBBA/pB",
            "HwodZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0ZlZWQSWgoJZmVlZF9pdGVt",
            "GA0gASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQingQQP6QSMK",
            "IWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkSXRlbRJhCg1hZF9ncm91",
            "cF9mZWVkGA4gASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQizg",
            "QQP6QSYKJGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwRmVlZBJi",
            "Cg1jYW1wYWlnbl9mZWVkGA8gASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmlu",
            "Z1ZhbHVlQi3gQQP6QScKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1w",
            "YWlnbkZlZWQScAoVYWRfZ3JvdXBfYmlkX21vZGlmaWVyGBAgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQjPgQQP6QS0KK2dvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9BZEdyb3VwQmlkTW9kaWZpZXI6XepBWgolZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0NoYW5nZVN0YXR1cxIxY3VzdG9tZXJzL3tj",
            "dXN0b21lcn0vY2hhbmdlU3RhdHVzL3tjaGFuZ2Vfc3RhdHVzfUILCglfY2Ft",
            "cGFpZ25CCwoJX2FkX2dyb3VwQv4BCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjUucmVzb3VyY2VzQhFDaGFuZ2VTdGF0dXNQcm90b1ABWkpnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMv",
            "djUvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY1LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY1",
            "XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY1OjpSZXNv",
            "dXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V5.Enums.AdTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.AdvertisingChannelSubTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.AdvertisingChannelTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.CriterionTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.FeedOriginReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Resources.ChangeStatus), global::Google.Ads.GoogleAds.V5.Resources.ChangeStatus.Parser, new[]{ "ResourceName", "LastChangeDateTime", "ResourceType", "Campaign", "AdGroup", "ResourceStatus", "AdGroupAd", "AdGroupCriterion", "CampaignCriterion", "Feed", "FeedItem", "AdGroupFeed", "CampaignFeed", "AdGroupBidModifier" }, new[]{ "Campaign", "AdGroup" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the status of returned resource.
  /// </summary>
  public sealed partial class ChangeStatus : pb::IMessage<ChangeStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeStatus> _parser = new pb::MessageParser<ChangeStatus>(() => new ChangeStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangeStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Resources.ChangeStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus(ChangeStatus other) : this() {
      resourceName_ = other.resourceName_;
      LastChangeDateTime = other.LastChangeDateTime;
      resourceType_ = other.resourceType_;
      campaign_ = other.campaign_;
      adGroup_ = other.adGroup_;
      resourceStatus_ = other.resourceStatus_;
      AdGroupAd = other.AdGroupAd;
      AdGroupCriterion = other.AdGroupCriterion;
      CampaignCriterion = other.CampaignCriterion;
      Feed = other.Feed;
      FeedItem = other.FeedItem;
      AdGroupFeed = other.AdGroupFeed;
      CampaignFeed = other.CampaignFeed;
      AdGroupBidModifier = other.AdGroupBidModifier;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus Clone() {
      return new ChangeStatus(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the change status.
    /// Change status resource names have the form:
    ///
    /// `customers/{customer_id}/changeStatus/{change_status_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_change_date_time" field.</summary>
    public const int LastChangeDateTimeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_lastChangeDateTime_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string lastChangeDateTime_;
    /// <summary>
    /// Output only. Time at which the most recent change has occurred on this resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastChangeDateTime {
      get { return lastChangeDateTime_; }
      set {
        lastChangeDateTime_ = value;
      }
    }


    /// <summary>Field number for the "resource_type" field.</summary>
    public const int ResourceTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType resourceType_ = global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified;
    /// <summary>
    /// Output only. Represents the type of the changed resource. This dictates what fields
    /// will be set. For example, for AD_GROUP, campaign and ad_group fields will
    /// be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 17;
    private string campaign_;
    /// <summary>
    /// Output only. The Campaign affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_ ?? ""; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 18;
    private string adGroup_;
    /// <summary>
    /// Output only. The AdGroup affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_ ?? ""; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroup {
      get { return adGroup_ != null; }
    }
    /// <summary>Clears the value of the "ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroup() {
      adGroup_ = null;
    }

    /// <summary>Field number for the "resource_status" field.</summary>
    public const int ResourceStatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation resourceStatus_ = global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified;
    /// <summary>
    /// Output only. Represents the status of the changed resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation ResourceStatus {
      get { return resourceStatus_; }
      set {
        resourceStatus_ = value;
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _single_adGroupAd_codec = pb::FieldCodec.ForClassWrapper<string>(74);
    private string adGroupAd_;
    /// <summary>
    /// Output only. The AdGroupAd affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_; }
      set {
        adGroupAd_ = value;
      }
    }


    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _single_adGroupCriterion_codec = pb::FieldCodec.ForClassWrapper<string>(82);
    private string adGroupCriterion_;
    /// <summary>
    /// Output only. The AdGroupCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupCriterion {
      get { return adGroupCriterion_; }
      set {
        adGroupCriterion_ = value;
      }
    }


    /// <summary>Field number for the "campaign_criterion" field.</summary>
    public const int CampaignCriterionFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _single_campaignCriterion_codec = pb::FieldCodec.ForClassWrapper<string>(90);
    private string campaignCriterion_;
    /// <summary>
    /// Output only. The CampaignCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignCriterion {
      get { return campaignCriterion_; }
      set {
        campaignCriterion_ = value;
      }
    }


    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 12;
    private static readonly pb::FieldCodec<string> _single_feed_codec = pb::FieldCodec.ForClassWrapper<string>(98);
    private string feed_;
    /// <summary>
    /// Output only. The Feed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Feed {
      get { return feed_; }
      set {
        feed_ = value;
      }
    }


    /// <summary>Field number for the "feed_item" field.</summary>
    public const int FeedItemFieldNumber = 13;
    private static readonly pb::FieldCodec<string> _single_feedItem_codec = pb::FieldCodec.ForClassWrapper<string>(106);
    private string feedItem_;
    /// <summary>
    /// Output only. The FeedItem affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FeedItem {
      get { return feedItem_; }
      set {
        feedItem_ = value;
      }
    }


    /// <summary>Field number for the "ad_group_feed" field.</summary>
    public const int AdGroupFeedFieldNumber = 14;
    private static readonly pb::FieldCodec<string> _single_adGroupFeed_codec = pb::FieldCodec.ForClassWrapper<string>(114);
    private string adGroupFeed_;
    /// <summary>
    /// Output only. The AdGroupFeed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupFeed {
      get { return adGroupFeed_; }
      set {
        adGroupFeed_ = value;
      }
    }


    /// <summary>Field number for the "campaign_feed" field.</summary>
    public const int CampaignFeedFieldNumber = 15;
    private static readonly pb::FieldCodec<string> _single_campaignFeed_codec = pb::FieldCodec.ForClassWrapper<string>(122);
    private string campaignFeed_;
    /// <summary>
    /// Output only. The CampaignFeed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignFeed {
      get { return campaignFeed_; }
      set {
        campaignFeed_ = value;
      }
    }


    /// <summary>Field number for the "ad_group_bid_modifier" field.</summary>
    public const int AdGroupBidModifierFieldNumber = 16;
    private static readonly pb::FieldCodec<string> _single_adGroupBidModifier_codec = pb::FieldCodec.ForClassWrapper<string>(130);
    private string adGroupBidModifier_;
    /// <summary>
    /// Output only. The AdGroupBidModifier affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupBidModifier {
      get { return adGroupBidModifier_; }
      set {
        adGroupBidModifier_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangeStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (LastChangeDateTime != other.LastChangeDateTime) return false;
      if (ResourceType != other.ResourceType) return false;
      if (Campaign != other.Campaign) return false;
      if (AdGroup != other.AdGroup) return false;
      if (ResourceStatus != other.ResourceStatus) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (CampaignCriterion != other.CampaignCriterion) return false;
      if (Feed != other.Feed) return false;
      if (FeedItem != other.FeedItem) return false;
      if (AdGroupFeed != other.AdGroupFeed) return false;
      if (CampaignFeed != other.CampaignFeed) return false;
      if (AdGroupBidModifier != other.AdGroupBidModifier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (lastChangeDateTime_ != null) hash ^= LastChangeDateTime.GetHashCode();
      if (ResourceType != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) hash ^= ResourceType.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasAdGroup) hash ^= AdGroup.GetHashCode();
      if (ResourceStatus != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) hash ^= ResourceStatus.GetHashCode();
      if (adGroupAd_ != null) hash ^= AdGroupAd.GetHashCode();
      if (adGroupCriterion_ != null) hash ^= AdGroupCriterion.GetHashCode();
      if (campaignCriterion_ != null) hash ^= CampaignCriterion.GetHashCode();
      if (feed_ != null) hash ^= Feed.GetHashCode();
      if (feedItem_ != null) hash ^= FeedItem.GetHashCode();
      if (adGroupFeed_ != null) hash ^= AdGroupFeed.GetHashCode();
      if (campaignFeed_ != null) hash ^= CampaignFeed.GetHashCode();
      if (adGroupBidModifier_ != null) hash ^= AdGroupBidModifier.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (lastChangeDateTime_ != null) {
        _single_lastChangeDateTime_codec.WriteTagAndValue(output, LastChangeDateTime);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ResourceStatus);
      }
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(output, AdGroupAd);
      }
      if (adGroupCriterion_ != null) {
        _single_adGroupCriterion_codec.WriteTagAndValue(output, AdGroupCriterion);
      }
      if (campaignCriterion_ != null) {
        _single_campaignCriterion_codec.WriteTagAndValue(output, CampaignCriterion);
      }
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(output, Feed);
      }
      if (feedItem_ != null) {
        _single_feedItem_codec.WriteTagAndValue(output, FeedItem);
      }
      if (adGroupFeed_ != null) {
        _single_adGroupFeed_codec.WriteTagAndValue(output, AdGroupFeed);
      }
      if (campaignFeed_ != null) {
        _single_campaignFeed_codec.WriteTagAndValue(output, CampaignFeed);
      }
      if (adGroupBidModifier_ != null) {
        _single_adGroupBidModifier_codec.WriteTagAndValue(output, AdGroupBidModifier);
      }
      if (HasCampaign) {
        output.WriteRawTag(138, 1);
        output.WriteString(Campaign);
      }
      if (HasAdGroup) {
        output.WriteRawTag(146, 1);
        output.WriteString(AdGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (lastChangeDateTime_ != null) {
        _single_lastChangeDateTime_codec.WriteTagAndValue(ref output, LastChangeDateTime);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ResourceStatus);
      }
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(ref output, AdGroupAd);
      }
      if (adGroupCriterion_ != null) {
        _single_adGroupCriterion_codec.WriteTagAndValue(ref output, AdGroupCriterion);
      }
      if (campaignCriterion_ != null) {
        _single_campaignCriterion_codec.WriteTagAndValue(ref output, CampaignCriterion);
      }
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(ref output, Feed);
      }
      if (feedItem_ != null) {
        _single_feedItem_codec.WriteTagAndValue(ref output, FeedItem);
      }
      if (adGroupFeed_ != null) {
        _single_adGroupFeed_codec.WriteTagAndValue(ref output, AdGroupFeed);
      }
      if (campaignFeed_ != null) {
        _single_campaignFeed_codec.WriteTagAndValue(ref output, CampaignFeed);
      }
      if (adGroupBidModifier_ != null) {
        _single_adGroupBidModifier_codec.WriteTagAndValue(ref output, AdGroupBidModifier);
      }
      if (HasCampaign) {
        output.WriteRawTag(138, 1);
        output.WriteString(Campaign);
      }
      if (HasAdGroup) {
        output.WriteRawTag(146, 1);
        output.WriteString(AdGroup);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (lastChangeDateTime_ != null) {
        size += _single_lastChangeDateTime_codec.CalculateSizeWithTag(LastChangeDateTime);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      if (HasCampaign) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasAdGroup) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceStatus);
      }
      if (adGroupAd_ != null) {
        size += _single_adGroupAd_codec.CalculateSizeWithTag(AdGroupAd);
      }
      if (adGroupCriterion_ != null) {
        size += _single_adGroupCriterion_codec.CalculateSizeWithTag(AdGroupCriterion);
      }
      if (campaignCriterion_ != null) {
        size += _single_campaignCriterion_codec.CalculateSizeWithTag(CampaignCriterion);
      }
      if (feed_ != null) {
        size += _single_feed_codec.CalculateSizeWithTag(Feed);
      }
      if (feedItem_ != null) {
        size += _single_feedItem_codec.CalculateSizeWithTag(FeedItem);
      }
      if (adGroupFeed_ != null) {
        size += _single_adGroupFeed_codec.CalculateSizeWithTag(AdGroupFeed);
      }
      if (campaignFeed_ != null) {
        size += _single_campaignFeed_codec.CalculateSizeWithTag(CampaignFeed);
      }
      if (adGroupBidModifier_ != null) {
        size += _single_adGroupBidModifier_codec.CalculateSizeWithTag(AdGroupBidModifier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangeStatus other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.lastChangeDateTime_ != null) {
        if (lastChangeDateTime_ == null || other.LastChangeDateTime != "") {
          LastChangeDateTime = other.LastChangeDateTime;
        }
      }
      if (other.ResourceType != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        ResourceType = other.ResourceType;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasAdGroup) {
        AdGroup = other.AdGroup;
      }
      if (other.ResourceStatus != global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        ResourceStatus = other.ResourceStatus;
      }
      if (other.adGroupAd_ != null) {
        if (adGroupAd_ == null || other.AdGroupAd != "") {
          AdGroupAd = other.AdGroupAd;
        }
      }
      if (other.adGroupCriterion_ != null) {
        if (adGroupCriterion_ == null || other.AdGroupCriterion != "") {
          AdGroupCriterion = other.AdGroupCriterion;
        }
      }
      if (other.campaignCriterion_ != null) {
        if (campaignCriterion_ == null || other.CampaignCriterion != "") {
          CampaignCriterion = other.CampaignCriterion;
        }
      }
      if (other.feed_ != null) {
        if (feed_ == null || other.Feed != "") {
          Feed = other.Feed;
        }
      }
      if (other.feedItem_ != null) {
        if (feedItem_ == null || other.FeedItem != "") {
          FeedItem = other.FeedItem;
        }
      }
      if (other.adGroupFeed_ != null) {
        if (adGroupFeed_ == null || other.AdGroupFeed != "") {
          AdGroupFeed = other.AdGroupFeed;
        }
      }
      if (other.campaignFeed_ != null) {
        if (campaignFeed_ == null || other.CampaignFeed != "") {
          CampaignFeed = other.CampaignFeed;
        }
      }
      if (other.adGroupBidModifier_ != null) {
        if (adGroupBidModifier_ == null || other.AdGroupBidModifier != "") {
          AdGroupBidModifier = other.AdGroupBidModifier;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_lastChangeDateTime_codec.Read(input);
            if (lastChangeDateTime_ == null || value != "") {
              LastChangeDateTime = value;
            }
            break;
          }
          case 32: {
            ResourceType = (global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
            break;
          }
          case 74: {
            string value = _single_adGroupAd_codec.Read(input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 82: {
            string value = _single_adGroupCriterion_codec.Read(input);
            if (adGroupCriterion_ == null || value != "") {
              AdGroupCriterion = value;
            }
            break;
          }
          case 90: {
            string value = _single_campaignCriterion_codec.Read(input);
            if (campaignCriterion_ == null || value != "") {
              CampaignCriterion = value;
            }
            break;
          }
          case 98: {
            string value = _single_feed_codec.Read(input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 106: {
            string value = _single_feedItem_codec.Read(input);
            if (feedItem_ == null || value != "") {
              FeedItem = value;
            }
            break;
          }
          case 114: {
            string value = _single_adGroupFeed_codec.Read(input);
            if (adGroupFeed_ == null || value != "") {
              AdGroupFeed = value;
            }
            break;
          }
          case 122: {
            string value = _single_campaignFeed_codec.Read(input);
            if (campaignFeed_ == null || value != "") {
              CampaignFeed = value;
            }
            break;
          }
          case 130: {
            string value = _single_adGroupBidModifier_codec.Read(input);
            if (adGroupBidModifier_ == null || value != "") {
              AdGroupBidModifier = value;
            }
            break;
          }
          case 138: {
            Campaign = input.ReadString();
            break;
          }
          case 146: {
            AdGroup = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_lastChangeDateTime_codec.Read(ref input);
            if (lastChangeDateTime_ == null || value != "") {
              LastChangeDateTime = value;
            }
            break;
          }
          case 32: {
            ResourceType = (global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V5.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
            break;
          }
          case 74: {
            string value = _single_adGroupAd_codec.Read(ref input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 82: {
            string value = _single_adGroupCriterion_codec.Read(ref input);
            if (adGroupCriterion_ == null || value != "") {
              AdGroupCriterion = value;
            }
            break;
          }
          case 90: {
            string value = _single_campaignCriterion_codec.Read(ref input);
            if (campaignCriterion_ == null || value != "") {
              CampaignCriterion = value;
            }
            break;
          }
          case 98: {
            string value = _single_feed_codec.Read(ref input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 106: {
            string value = _single_feedItem_codec.Read(ref input);
            if (feedItem_ == null || value != "") {
              FeedItem = value;
            }
            break;
          }
          case 114: {
            string value = _single_adGroupFeed_codec.Read(ref input);
            if (adGroupFeed_ == null || value != "") {
              AdGroupFeed = value;
            }
            break;
          }
          case 122: {
            string value = _single_campaignFeed_codec.Read(ref input);
            if (campaignFeed_ == null || value != "") {
              CampaignFeed = value;
            }
            break;
          }
          case 130: {
            string value = _single_adGroupBidModifier_codec.Read(ref input);
            if (adGroupBidModifier_ == null || value != "") {
              AdGroupBidModifier = value;
            }
            break;
          }
          case 138: {
            Campaign = input.ReadString();
            break;
          }
          case 146: {
            AdGroup = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
