//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FbxSdk {

public class FbxExternalDocumentInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxExternalDocumentInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxExternalDocumentInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxExternalDocumentInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxExternalDocumentInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxString mDocumentName {
    set {
      examplePINVOKE.FbxExternalDocumentInfo_mDocumentName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxExternalDocumentInfo_mDocumentName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mClassName {
    set {
      examplePINVOKE.FbxExternalDocumentInfo_mClassName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxExternalDocumentInfo_mClassName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mParentFullName {
    set {
      examplePINVOKE.FbxExternalDocumentInfo_mParentFullName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxExternalDocumentInfo_mParentFullName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mFilePathUrl {
    set {
      examplePINVOKE.FbxExternalDocumentInfo_mFilePathUrl_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxExternalDocumentInfo_mFilePathUrl_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxExternalDocumentInfo() : this(examplePINVOKE.new_FbxExternalDocumentInfo(), true) {
  }

}

}
