// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/language_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/language_constant.proto</summary>
  public static partial class LanguageConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/language_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanguageConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2xhbmd1YWdl",
            "X2NvbnN0YW50LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVz",
            "b3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29n",
            "bGUvYXBpL3Jlc291cmNlLnByb3RvIroCChBMYW5ndWFnZUNvbnN0YW50EkgK",
            "DXJlc291cmNlX25hbWUYASABKAlCMeBBA/pBKwopZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL0xhbmd1YWdlQ29uc3RhbnQSFAoCaWQYBiABKANCA+BBA0gA",
            "iAEBEhYKBGNvZGUYByABKAlCA+BBA0gBiAEBEhYKBG5hbWUYCCABKAlCA+BB",
            "A0gCiAEBEhwKCnRhcmdldGFibGUYCSABKAhCA+BBA0gDiAEBOlDqQU0KKWdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9MYW5ndWFnZUNvbnN0YW50EiBsYW5n",
            "dWFnZUNvbnN0YW50cy97Y3JpdGVyaW9uX2lkfUIFCgNfaWRCBwoFX2NvZGVC",
            "BwoFX25hbWVCDQoLX3RhcmdldGFibGVChwIKJmNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTIucmVzb3VyY2VzQhVMYW5ndWFnZUNvbnN0YW50UHJvdG9Q",
            "AVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxMi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjEyLlJlc291cmNlc8oCIkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMlxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTI6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.LanguageConstant), global::Google.Ads.GoogleAds.V12.Resources.LanguageConstant.Parser, new[]{ "ResourceName", "Id", "Code", "Name", "Targetable" }, new[]{ "Id", "Code", "Name", "Targetable" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A language.
  /// </summary>
  public sealed partial class LanguageConstant : pb::IMessage<LanguageConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanguageConstant> _parser = new pb::MessageParser<LanguageConstant>(() => new LanguageConstant());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanguageConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.LanguageConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanguageConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanguageConstant(LanguageConstant other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      code_ = other.code_;
      name_ = other.name_;
      targetable_ = other.targetable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanguageConstant Clone() {
      return new LanguageConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the language constant.
    /// Language constant resource names have the form:
    ///
    /// `languageConstants/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 6;
    private long id_;
    /// <summary>
    /// Output only. The ID of the language constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 7;
    private string code_;
    /// <summary>
    /// Output only. The language code, for example, "en_US", "en_AU", "es", "fr", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Code {
      get { return code_ ?? ""; }
      set {
        code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCode {
      get { return code_ != null; }
    }
    /// <summary>Clears the value of the "code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCode() {
      code_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 8;
    private string name_;
    /// <summary>
    /// Output only. The full name of the language in English, for example, "English (US)",
    /// "Spanish", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "targetable" field.</summary>
    public const int TargetableFieldNumber = 9;
    private bool targetable_;
    /// <summary>
    /// Output only. Whether the language is targetable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Targetable {
      get { if ((_hasBits0 & 2) != 0) { return targetable_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        targetable_ = value;
      }
    }
    /// <summary>Gets whether the "targetable" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTargetable {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "targetable" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTargetable() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanguageConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanguageConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Code != other.Code) return false;
      if (Name != other.Name) return false;
      if (Targetable != other.Targetable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasCode) hash ^= Code.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasTargetable) hash ^= Targetable.GetHashCode();
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
      if (HasId) {
        output.WriteRawTag(48);
        output.WriteInt64(Id);
      }
      if (HasCode) {
        output.WriteRawTag(58);
        output.WriteString(Code);
      }
      if (HasName) {
        output.WriteRawTag(66);
        output.WriteString(Name);
      }
      if (HasTargetable) {
        output.WriteRawTag(72);
        output.WriteBool(Targetable);
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
      if (HasId) {
        output.WriteRawTag(48);
        output.WriteInt64(Id);
      }
      if (HasCode) {
        output.WriteRawTag(58);
        output.WriteString(Code);
      }
      if (HasName) {
        output.WriteRawTag(66);
        output.WriteString(Name);
      }
      if (HasTargetable) {
        output.WriteRawTag(72);
        output.WriteBool(Targetable);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasTargetable) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanguageConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasCode) {
        Code = other.Code;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasTargetable) {
        Targetable = other.Targetable;
      }
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
          case 48: {
            Id = input.ReadInt64();
            break;
          }
          case 58: {
            Code = input.ReadString();
            break;
          }
          case 66: {
            Name = input.ReadString();
            break;
          }
          case 72: {
            Targetable = input.ReadBool();
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
          case 48: {
            Id = input.ReadInt64();
            break;
          }
          case 58: {
            Code = input.ReadString();
            break;
          }
          case 66: {
            Name = input.ReadString();
            break;
          }
          case 72: {
            Targetable = input.ReadBool();
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
