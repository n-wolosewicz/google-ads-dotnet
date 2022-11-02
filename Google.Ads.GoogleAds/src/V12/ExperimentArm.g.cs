// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/experiment_arm.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/experiment_arm.proto</summary>
  public static partial class ExperimentArmReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/experiment_arm.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExperimentArmReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2V4cGVyaW1l",
            "bnRfYXJtLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvIsQDCg1FeHBlcmltZW50QXJtEkUKDXJlc291",
            "cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0V4cGVyaW1lbnRBcm0SPwoKZXhwZXJpbWVudBgIIAEoCUIr4EEF+kEl",
            "CiNnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRXhwZXJpbWVudBIRCgRuYW1l",
            "GAMgASgJQgPgQQISDwoHY29udHJvbBgEIAEoCBIVCg10cmFmZmljX3NwbGl0",
            "GAUgASgDEjkKCWNhbXBhaWducxgGIAMoCUIm+kEjCiFnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQ2FtcGFpZ24SRgoTaW5fZGVzaWduX2NhbXBhaWducxgH",
            "IAMoCUIp4EED+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFp",
            "Z246bepBagomZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0V4cGVyaW1lbnRB",
            "cm0SQGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2V4cGVyaW1lbnRBcm1zL3t0",
            "cmlhbF9pZH1+e3RyaWFsX2FybV9pZH1ChAIKJmNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTIucmVzb3VyY2VzQhJFeHBlcmltZW50QXJtUHJvdG9QAVpL",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YxMi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjEyLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYxMlxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMTI6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.ExperimentArm), global::Google.Ads.GoogleAds.V12.Resources.ExperimentArm.Parser, new[]{ "ResourceName", "Experiment", "Name", "Control", "TrafficSplit", "Campaigns", "InDesignCampaigns" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Google ads experiment for users to experiment changes on multiple
  /// campaigns, compare the performance, and apply the effective changes.
  /// </summary>
  public sealed partial class ExperimentArm : pb::IMessage<ExperimentArm>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExperimentArm> _parser = new pb::MessageParser<ExperimentArm>(() => new ExperimentArm());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExperimentArm> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.ExperimentArmReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentArm() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentArm(ExperimentArm other) : this() {
      resourceName_ = other.resourceName_;
      experiment_ = other.experiment_;
      name_ = other.name_;
      control_ = other.control_;
      trafficSplit_ = other.trafficSplit_;
      campaigns_ = other.campaigns_.Clone();
      inDesignCampaigns_ = other.inDesignCampaigns_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentArm Clone() {
      return new ExperimentArm(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the experiment arm.
    /// Experiment arm resource names have the form:
    ///
    /// `customers/{customer_id}/experimentArms/{TrialArm.trial_id}~{TrialArm.trial_arm_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "experiment" field.</summary>
    public const int ExperimentFieldNumber = 8;
    private string experiment_ = "";
    /// <summary>
    /// Immutable. The experiment to which the ExperimentArm belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Experiment {
      get { return experiment_; }
      set {
        experiment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Required. The name of the experiment arm. It must have a minimum length of 1 and
    /// maximum length of 1024. It must be unique under an experiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "control" field.</summary>
    public const int ControlFieldNumber = 4;
    private bool control_;
    /// <summary>
    /// Whether this arm is a control arm. A control arm is the arm against
    /// which the other arms are compared.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Control {
      get { return control_; }
      set {
        control_ = value;
      }
    }

    /// <summary>Field number for the "traffic_split" field.</summary>
    public const int TrafficSplitFieldNumber = 5;
    private long trafficSplit_;
    /// <summary>
    /// Traffic split of the trial arm. The value should be between 1 and 100
    /// and must total 100 between the two trial arms.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TrafficSplit {
      get { return trafficSplit_; }
      set {
        trafficSplit_ = value;
      }
    }

    /// <summary>Field number for the "campaigns" field.</summary>
    public const int CampaignsFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_campaigns_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> campaigns_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of campaigns in the trial arm. The max length is one.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Campaigns {
      get { return campaigns_; }
    }

    /// <summary>Field number for the "in_design_campaigns" field.</summary>
    public const int InDesignCampaignsFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_inDesignCampaigns_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> inDesignCampaigns_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The in design campaigns in the treatment experiment arm.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> InDesignCampaigns {
      get { return inDesignCampaigns_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExperimentArm);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExperimentArm other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Experiment != other.Experiment) return false;
      if (Name != other.Name) return false;
      if (Control != other.Control) return false;
      if (TrafficSplit != other.TrafficSplit) return false;
      if(!campaigns_.Equals(other.campaigns_)) return false;
      if(!inDesignCampaigns_.Equals(other.inDesignCampaigns_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Experiment.Length != 0) hash ^= Experiment.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Control != false) hash ^= Control.GetHashCode();
      if (TrafficSplit != 0L) hash ^= TrafficSplit.GetHashCode();
      hash ^= campaigns_.GetHashCode();
      hash ^= inDesignCampaigns_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Control != false) {
        output.WriteRawTag(32);
        output.WriteBool(Control);
      }
      if (TrafficSplit != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(TrafficSplit);
      }
      campaigns_.WriteTo(output, _repeated_campaigns_codec);
      inDesignCampaigns_.WriteTo(output, _repeated_inDesignCampaigns_codec);
      if (Experiment.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Experiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Control != false) {
        output.WriteRawTag(32);
        output.WriteBool(Control);
      }
      if (TrafficSplit != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(TrafficSplit);
      }
      campaigns_.WriteTo(ref output, _repeated_campaigns_codec);
      inDesignCampaigns_.WriteTo(ref output, _repeated_inDesignCampaigns_codec);
      if (Experiment.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Experiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Experiment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Experiment);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Control != false) {
        size += 1 + 1;
      }
      if (TrafficSplit != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TrafficSplit);
      }
      size += campaigns_.CalculateSize(_repeated_campaigns_codec);
      size += inDesignCampaigns_.CalculateSize(_repeated_inDesignCampaigns_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExperimentArm other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Experiment.Length != 0) {
        Experiment = other.Experiment;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Control != false) {
        Control = other.Control;
      }
      if (other.TrafficSplit != 0L) {
        TrafficSplit = other.TrafficSplit;
      }
      campaigns_.Add(other.campaigns_);
      inDesignCampaigns_.Add(other.inDesignCampaigns_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Name = input.ReadString();
            break;
          }
          case 32: {
            Control = input.ReadBool();
            break;
          }
          case 40: {
            TrafficSplit = input.ReadInt64();
            break;
          }
          case 50: {
            campaigns_.AddEntriesFrom(input, _repeated_campaigns_codec);
            break;
          }
          case 58: {
            inDesignCampaigns_.AddEntriesFrom(input, _repeated_inDesignCampaigns_codec);
            break;
          }
          case 66: {
            Experiment = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Name = input.ReadString();
            break;
          }
          case 32: {
            Control = input.ReadBool();
            break;
          }
          case 40: {
            TrafficSplit = input.ReadInt64();
            break;
          }
          case 50: {
            campaigns_.AddEntriesFrom(ref input, _repeated_campaigns_codec);
            break;
          }
          case 58: {
            inDesignCampaigns_.AddEntriesFrom(ref input, _repeated_inDesignCampaigns_codec);
            break;
          }
          case 66: {
            Experiment = input.ReadString();
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
