// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: communicator_objects/unity_message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from communicator_objects/unity_message.proto</summary>
  public static partial class UnityMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for communicator_objects/unity_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihjb21tdW5pY2F0b3Jfb2JqZWN0cy91bml0eV9tZXNzYWdlLnByb3RvEhRj",
            "b21tdW5pY2F0b3Jfb2JqZWN0cxonY29tbXVuaWNhdG9yX29iamVjdHMvdW5p",
            "dHlfb3V0cHV0LnByb3RvGiZjb21tdW5pY2F0b3Jfb2JqZWN0cy91bml0eV9p",
            "bnB1dC5wcm90bxohY29tbXVuaWNhdG9yX29iamVjdHMvaGVhZGVyLnByb3Rv",
            "IqwBCgxVbml0eU1lc3NhZ2USLAoGaGVhZGVyGAEgASgLMhwuY29tbXVuaWNh",
            "dG9yX29iamVjdHMuSGVhZGVyEjcKDHVuaXR5X291dHB1dBgCIAEoCzIhLmNv",
            "bW11bmljYXRvcl9vYmplY3RzLlVuaXR5T3V0cHV0EjUKC3VuaXR5X2lucHV0",
            "GAMgASgLMiAuY29tbXVuaWNhdG9yX29iamVjdHMuVW5pdHlJbnB1dEIfqgIc",
            "TUxBZ2VudHMuQ29tbXVuaWNhdG9yT2JqZWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.UnityOutputReflection.Descriptor, global::MLAgents.CommunicatorObjects.UnityInputReflection.Descriptor, global::MLAgents.CommunicatorObjects.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityMessage), global::MLAgents.CommunicatorObjects.UnityMessage.Parser, new[]{ "Header", "UnityOutput", "UnityInput" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityMessage : pb::IMessage<UnityMessage> {
    private static readonly pb::MessageParser<UnityMessage> _parser = new pb::MessageParser<UnityMessage>(() => new UnityMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.UnityMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityMessage(UnityMessage other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      UnityOutput = other.unityOutput_ != null ? other.UnityOutput.Clone() : null;
      UnityInput = other.unityInput_ != null ? other.UnityInput.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityMessage Clone() {
      return new UnityMessage(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::MLAgents.CommunicatorObjects.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "unity_output" field.</summary>
    public const int UnityOutputFieldNumber = 2;
    private global::MLAgents.CommunicatorObjects.UnityOutput unityOutput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.UnityOutput UnityOutput {
      get { return unityOutput_; }
      set {
        unityOutput_ = value;
      }
    }

    /// <summary>Field number for the "unity_input" field.</summary>
    public const int UnityInputFieldNumber = 3;
    private global::MLAgents.CommunicatorObjects.UnityInput unityInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.UnityInput UnityInput {
      get { return unityInput_; }
      set {
        unityInput_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (!object.Equals(UnityOutput, other.UnityOutput)) return false;
      if (!object.Equals(UnityInput, other.UnityInput)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (unityOutput_ != null) hash ^= UnityOutput.GetHashCode();
      if (unityInput_ != null) hash ^= UnityInput.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (unityOutput_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UnityOutput);
      }
      if (unityInput_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UnityInput);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (unityOutput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnityOutput);
      }
      if (unityInput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnityInput);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityMessage other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::MLAgents.CommunicatorObjects.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.unityOutput_ != null) {
        if (unityOutput_ == null) {
          unityOutput_ = new global::MLAgents.CommunicatorObjects.UnityOutput();
        }
        UnityOutput.MergeFrom(other.UnityOutput);
      }
      if (other.unityInput_ != null) {
        if (unityInput_ == null) {
          unityInput_ = new global::MLAgents.CommunicatorObjects.UnityInput();
        }
        UnityInput.MergeFrom(other.UnityInput);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::MLAgents.CommunicatorObjects.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18: {
            if (unityOutput_ == null) {
              unityOutput_ = new global::MLAgents.CommunicatorObjects.UnityOutput();
            }
            input.ReadMessage(unityOutput_);
            break;
          }
          case 26: {
            if (unityInput_ == null) {
              unityInput_ = new global::MLAgents.CommunicatorObjects.UnityInput();
            }
            input.ReadMessage(unityInput_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
