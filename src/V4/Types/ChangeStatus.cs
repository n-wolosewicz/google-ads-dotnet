// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/change_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/change_status.proto</summary>
  public static partial class ChangeStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/change_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvY2hhbmdlX3N0",
            "YXR1cy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQucmVzb3VyY2Vz",
            "Gjtnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9jaGFuZ2Vfc3RhdHVz",
            "X29wZXJhdGlvbi5wcm90bxo/Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjQvZW51",
            "bXMvY2hhbmdlX3N0YXR1c19yZXNvdXJjZV90eXBlLnByb3RvGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8irAsKDENoYW5nZVN0YXR1cxJECg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQi3gQQP6QScKJWdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DaGFuZ2VTdGF0dXMSQAoVbGFzdF9jaGFuZ2VfZGF0ZV90aW1l",
            "GAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMScAoN",
            "cmVzb3VyY2VfdHlwZRgEIAEoDjJULmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0",
            "LmVudW1zLkNoYW5nZVN0YXR1c1Jlc291cmNlVHlwZUVudW0uQ2hhbmdlU3Rh",
            "dHVzUmVzb3VyY2VUeXBlQgPgQQMSWQoIY2FtcGFpZ24YBSABKAsyHC5nb29n",
            "bGUucHJvdG9idWYuU3RyaW5nVmFsdWVCKeBBA/pBIwohZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0NhbXBhaWduElgKCGFkX2dyb3VwGAYgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQijgQQP6QSIKIGdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9BZEdyb3VwEmwKD3Jlc291cmNlX3N0YXR1cxgIIAEo",
            "DjJOLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmVudW1zLkNoYW5nZVN0YXR1",
            "c09wZXJhdGlvbkVudW0uQ2hhbmdlU3RhdHVzT3BlcmF0aW9uQgPgQQMSXQoL",
            "YWRfZ3JvdXBfYWQYCSABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWVCKuBBA/pBJAoiZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBB",
            "ZBJrChJhZF9ncm91cF9jcml0ZXJpb24YCiABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWVCMeBBA/pBKwopZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0FkR3JvdXBDcml0ZXJpb24SbAoSY2FtcGFpZ25fY3JpdGVyaW9uGAsg",
            "ASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQjLgQQP6QSwKKmdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkNyaXRlcmlvbhJRCgRm",
            "ZWVkGAwgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQiXgQQP6",
            "QR8KHWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkEloKCWZlZWRfaXRl",
            "bRgNIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUIp4EED+kEj",
            "CiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRmVlZEl0ZW0SYQoNYWRfZ3Jv",
            "dXBfZmVlZBgOIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUIs",
            "4EED+kEmCiRnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEZlZWQS",
            "YgoNY2FtcGFpZ25fZmVlZBgPIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJp",
            "bmdWYWx1ZUIt4EED+kEnCiVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2Ft",
            "cGFpZ25GZWVkEnAKFWFkX2dyb3VwX2JpZF9tb2RpZmllchgQIAEoCzIcLmdv",
            "b2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUIz4EED+kEtCitnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQWRHcm91cEJpZE1vZGlmaWVyOl3qQVoKJWdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DaGFuZ2VTdGF0dXMSMWN1c3RvbWVycy97",
            "Y3VzdG9tZXJ9L2NoYW5nZVN0YXR1cy97Y2hhbmdlX3N0YXR1c31C/gEKJWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5yZXNvdXJjZXNCEUNoYW5nZVN0",
            "YXR1c1Byb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXM7cmVzb3VyY2VzogID",
            "R0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuUmVzb3VyY2VzygIhR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjRcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjQ6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationReflection.Descriptor, global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.ChangeStatus), global::Google.Ads.GoogleAds.V4.Resources.ChangeStatus.Parser, new[]{ "ResourceName", "LastChangeDateTime", "ResourceType", "Campaign", "AdGroup", "ResourceStatus", "AdGroupAd", "AdGroupCriterion", "CampaignCriterion", "Feed", "FeedItem", "AdGroupFeed", "CampaignFeed", "AdGroupBidModifier" }, null, null, null, null)
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
      get { return global::Google.Ads.GoogleAds.V4.Resources.ChangeStatusReflection.Descriptor.MessageTypes[0]; }
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
      Campaign = other.Campaign;
      AdGroup = other.AdGroup;
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
    private global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType resourceType_ = global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified;
    /// <summary>
    /// Output only. Represents the type of the changed resource. This dictates what fields
    /// will be set. For example, for AD_GROUP, campaign and ad_group fields will
    /// be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string campaign_;
    /// <summary>
    /// Output only. The Campaign affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }


    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string adGroup_;
    /// <summary>
    /// Output only. The AdGroup affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }


    /// <summary>Field number for the "resource_status" field.</summary>
    public const int ResourceStatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation resourceStatus_ = global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified;
    /// <summary>
    /// Output only. Represents the status of the changed resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation ResourceStatus {
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
      if (ResourceType != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) hash ^= ResourceType.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      if (ResourceStatus != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) hash ^= ResourceStatus.GetHashCode();
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
      if (ResourceType != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
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
      if (ResourceType != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(ref output, Campaign);
      }
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(ref output, AdGroup);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
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
      if (ResourceType != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
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
      if (other.ResourceType != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        ResourceType = other.ResourceType;
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      if (other.ResourceStatus != global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
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
            ResourceType = (global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 50: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
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
            ResourceType = (global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_campaign_codec.Read(ref input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 50: {
            string value = _single_adGroup_codec.Read(ref input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V4.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
