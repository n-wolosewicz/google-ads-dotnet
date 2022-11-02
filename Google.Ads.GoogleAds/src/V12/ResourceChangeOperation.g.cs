// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/resource_change_operation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/resource_change_operation.proto</summary>
  public static partial class ResourceChangeOperationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/resource_change_operation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceChangeOperationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvcmVzb3VyY2VfY2hh",
            "bmdlX29wZXJhdGlvbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEy",
            "LmVudW1zInoKG1Jlc291cmNlQ2hhbmdlT3BlcmF0aW9uRW51bSJbChdSZXNv",
            "dXJjZUNoYW5nZU9wZXJhdGlvbhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIKCgZDUkVBVEUQAhIKCgZVUERBVEUQAxIKCgZSRU1PVkUQBEL2AQoi",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5lbnVtc0IcUmVzb3VyY2VD",
            "aGFuZ2VPcGVyYXRpb25Qcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEyL2VudW1zO2VudW1z",
            "ogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEyLkVudW1zygIeR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjEyXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjEyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.ResourceChangeOperationEnum), global::Google.Ads.GoogleAds.V12.Enums.ResourceChangeOperationEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.ResourceChangeOperationEnum.Types.ResourceChangeOperation) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing resource change operations
  /// in the ChangeEvent resource.
  /// </summary>
  public sealed partial class ResourceChangeOperationEnum : pb::IMessage<ResourceChangeOperationEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceChangeOperationEnum> _parser = new pb::MessageParser<ResourceChangeOperationEnum>(() => new ResourceChangeOperationEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResourceChangeOperationEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.ResourceChangeOperationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceChangeOperationEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceChangeOperationEnum(ResourceChangeOperationEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceChangeOperationEnum Clone() {
      return new ResourceChangeOperationEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResourceChangeOperationEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResourceChangeOperationEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResourceChangeOperationEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ResourceChangeOperationEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The operation on the changed resource in change_event resource.
      /// </summary>
      public enum ResourceChangeOperation {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified operation unknown
        /// in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The resource was created.
        /// </summary>
        [pbr::OriginalName("CREATE")] Create = 2,
        /// <summary>
        /// The resource was modified.
        /// </summary>
        [pbr::OriginalName("UPDATE")] Update = 3,
        /// <summary>
        /// The resource was removed.
        /// </summary>
        [pbr::OriginalName("REMOVE")] Remove = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
