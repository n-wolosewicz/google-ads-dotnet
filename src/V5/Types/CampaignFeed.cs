// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/resources/campaign_feed.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/resources/campaign_feed.proto</summary>
  public static partial class CampaignFeedReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/resources/campaign_feed.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignFeedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "ZmVlZC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUucmVzb3VyY2Vz",
            "GjZnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9jb21tb24vbWF0Y2hpbmdfZnVu",
            "Y3Rpb24ucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y1L2VudW1zL2Zl",
            "ZWRfbGlua19zdGF0dXMucHJvdG8aNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y1",
            "L2VudW1zL3BsYWNlaG9sZGVyX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmll",
            "bGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8a",
            "Hmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9h",
            "bm5vdGF0aW9ucy5wcm90byLlBAoMQ2FtcGFpZ25GZWVkEkQKDXJlc291cmNl",
            "X25hbWUYASABKAlCLeBBBfpBJwolZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L0NhbXBhaWduRmVlZBJRCgRmZWVkGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVm",
            "LlN0cmluZ1ZhbHVlQiXgQQX6QR8KHWdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9GZWVkElkKCGNhbXBhaWduGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0",
            "cmluZ1ZhbHVlQingQQX6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9D",
            "YW1wYWlnbhJdChFwbGFjZWhvbGRlcl90eXBlcxgEIAMoDjJCLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnY1LmVudW1zLlBsYWNlaG9sZGVyVHlwZUVudW0uUGxh",
            "Y2Vob2xkZXJUeXBlEksKEW1hdGNoaW5nX2Z1bmN0aW9uGAUgASgLMjAuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjUuY29tbW9uLk1hdGNoaW5nRnVuY3Rpb24S",
            "VQoGc3RhdHVzGAYgASgOMkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51",
            "bXMuRmVlZExpbmtTdGF0dXNFbnVtLkZlZWRMaW5rU3RhdHVzQgPgQQM6XupB",
            "WwolZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduRmVlZBIyY3Vz",
            "dG9tZXJzL3tjdXN0b21lcn0vY2FtcGFpZ25GZWVkcy97Y2FtcGFpZ25fZmVl",
            "ZH1C/gEKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NS5yZXNvdXJjZXNC",
            "EUNhbXBhaWduRmVlZFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9yZXNvdXJjZXM7cmVz",
            "b3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjUuUmVzb3Vy",
            "Y2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcUmVzb3VyY2Vz6gIlR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjU6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V5.Common.MatchingFunctionReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Resources.CampaignFeed), global::Google.Ads.GoogleAds.V5.Resources.CampaignFeed.Parser, new[]{ "ResourceName", "Feed", "Campaign", "PlaceholderTypes", "MatchingFunction", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign feed.
  /// </summary>
  public sealed partial class CampaignFeed : pb::IMessage<CampaignFeed>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignFeed> _parser = new pb::MessageParser<CampaignFeed>(() => new CampaignFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Resources.CampaignFeedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignFeed() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignFeed(CampaignFeed other) : this() {
      resourceName_ = other.resourceName_;
      Feed = other.Feed;
      Campaign = other.Campaign;
      placeholderTypes_ = other.placeholderTypes_.Clone();
      matchingFunction_ = other.matchingFunction_ != null ? other.matchingFunction_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignFeed Clone() {
      return new CampaignFeed(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign feed.
    /// Campaign feed resource names have the form:
    ///
    /// `customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_feed_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string feed_;
    /// <summary>
    /// Immutable. The feed to which the CampaignFeed belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Feed {
      get { return feed_; }
      set {
        feed_ = value;
      }
    }


    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the CampaignFeed belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = value;
      }
    }


    /// <summary>Field number for the "placeholder_types" field.</summary>
    public const int PlaceholderTypesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeEnum.Types.PlaceholderType> _repeated_placeholderTypes_codec
        = pb::FieldCodec.ForEnum(34, x => (int) x, x => (global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeEnum.Types.PlaceholderType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeEnum.Types.PlaceholderType> placeholderTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeEnum.Types.PlaceholderType>();
    /// <summary>
    /// Indicates which placeholder types the feed may populate under the connected
    /// campaign. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V5.Enums.PlaceholderTypeEnum.Types.PlaceholderType> PlaceholderTypes {
      get { return placeholderTypes_; }
    }

    /// <summary>Field number for the "matching_function" field.</summary>
    public const int MatchingFunctionFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V5.Common.MatchingFunction matchingFunction_;
    /// <summary>
    /// Matching function associated with the CampaignFeed.
    /// The matching function is used to filter the set of feed items selected.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V5.Common.MatchingFunction MatchingFunction {
      get { return matchingFunction_; }
      set {
        matchingFunction_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus status_ = global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified;
    /// <summary>
    /// Output only. Status of the campaign feed.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignFeed other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Feed != other.Feed) return false;
      if (Campaign != other.Campaign) return false;
      if(!placeholderTypes_.Equals(other.placeholderTypes_)) return false;
      if (!object.Equals(MatchingFunction, other.MatchingFunction)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (feed_ != null) hash ^= Feed.GetHashCode();
      if (campaign_ != null) hash ^= Campaign.GetHashCode();
      hash ^= placeholderTypes_.GetHashCode();
      if (matchingFunction_ != null) hash ^= MatchingFunction.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(output, Feed);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(output, Campaign);
      }
      placeholderTypes_.WriteTo(output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
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
      if (feed_ != null) {
        _single_feed_codec.WriteTagAndValue(ref output, Feed);
      }
      if (campaign_ != null) {
        _single_campaign_codec.WriteTagAndValue(ref output, Campaign);
      }
      placeholderTypes_.WriteTo(ref output, _repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
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
      if (feed_ != null) {
        size += _single_feed_codec.CalculateSizeWithTag(Feed);
      }
      if (campaign_ != null) {
        size += _single_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      size += placeholderTypes_.CalculateSize(_repeated_placeholderTypes_codec);
      if (matchingFunction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MatchingFunction);
      }
      if (Status != global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignFeed other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.feed_ != null) {
        if (feed_ == null || other.Feed != "") {
          Feed = other.Feed;
        }
      }
      if (other.campaign_ != null) {
        if (campaign_ == null || other.Campaign != "") {
          Campaign = other.Campaign;
        }
      }
      placeholderTypes_.Add(other.placeholderTypes_);
      if (other.matchingFunction_ != null) {
        if (matchingFunction_ == null) {
          MatchingFunction = new global::Google.Ads.GoogleAds.V5.Common.MatchingFunction();
        }
        MatchingFunction.MergeFrom(other.MatchingFunction);
      }
      if (other.Status != global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 18: {
            string value = _single_feed_codec.Read(input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 26: {
            string value = _single_campaign_codec.Read(input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 34:
          case 32: {
            placeholderTypes_.AddEntriesFrom(input, _repeated_placeholderTypes_codec);
            break;
          }
          case 42: {
            if (matchingFunction_ == null) {
              MatchingFunction = new global::Google.Ads.GoogleAds.V5.Common.MatchingFunction();
            }
            input.ReadMessage(MatchingFunction);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
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
          case 18: {
            string value = _single_feed_codec.Read(ref input);
            if (feed_ == null || value != "") {
              Feed = value;
            }
            break;
          }
          case 26: {
            string value = _single_campaign_codec.Read(ref input);
            if (campaign_ == null || value != "") {
              Campaign = value;
            }
            break;
          }
          case 34:
          case 32: {
            placeholderTypes_.AddEntriesFrom(ref input, _repeated_placeholderTypes_codec);
            break;
          }
          case 42: {
            if (matchingFunction_ == null) {
              MatchingFunction = new global::Google.Ads.GoogleAds.V5.Common.MatchingFunction();
            }
            input.ReadMessage(MatchingFunction);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V5.Enums.FeedLinkStatusEnum.Types.FeedLinkStatus) input.ReadEnum();
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
