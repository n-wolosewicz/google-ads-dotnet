// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/errors/youtube_video_registration_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/errors/youtube_video_registration_error.proto</summary>
  public static partial class YoutubeVideoRegistrationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/errors/youtube_video_registration_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static YoutubeVideoRegistrationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lcnJvcnMveW91dHViZV92aWRl",
            "b19yZWdpc3RyYXRpb25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY1LmVycm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKq",
            "AQohWW91dHViZVZpZGVvUmVnaXN0cmF0aW9uRXJyb3JFbnVtIoQBCh1Zb3V0",
            "dWJlVmlkZW9SZWdpc3RyYXRpb25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARITCg9WSURFT19OT1RfRk9VTkQQAhIYChRWSURFT19OT1Rf",
            "QUNDRVNTSUJMRRADEhYKElZJREVPX05PVF9FTElHSUJMRRAEQv0BCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZXJyb3JzQiJZb3V0dWJlVmlkZW9S",
            "ZWdpc3RyYXRpb25FcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9lcnJvcnM7ZXJy",
            "b3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjUuRXJyb3JzygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjU6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Errors.YoutubeVideoRegistrationErrorEnum), global::Google.Ads.GoogleAds.V5.Errors.YoutubeVideoRegistrationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Errors.YoutubeVideoRegistrationErrorEnum.Types.YoutubeVideoRegistrationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing YouTube video registration errors.
  /// </summary>
  public sealed partial class YoutubeVideoRegistrationErrorEnum : pb::IMessage<YoutubeVideoRegistrationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<YoutubeVideoRegistrationErrorEnum> _parser = new pb::MessageParser<YoutubeVideoRegistrationErrorEnum>(() => new YoutubeVideoRegistrationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<YoutubeVideoRegistrationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Errors.YoutubeVideoRegistrationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoRegistrationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoRegistrationErrorEnum(YoutubeVideoRegistrationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public YoutubeVideoRegistrationErrorEnum Clone() {
      return new YoutubeVideoRegistrationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as YoutubeVideoRegistrationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(YoutubeVideoRegistrationErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(YoutubeVideoRegistrationErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the YoutubeVideoRegistrationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing YouTube video registration errors.
      /// </summary>
      public enum YoutubeVideoRegistrationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Video to be registered wasn't found.
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_FOUND")] VideoNotFound = 2,
        /// <summary>
        /// Video to be registered is not accessible (e.g. private).
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_ACCESSIBLE")] VideoNotAccessible = 3,
        /// <summary>
        /// Video to be registered is not eligible (e.g. mature content).
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_ELIGIBLE")] VideoNotEligible = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
