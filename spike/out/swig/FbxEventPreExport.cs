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

public class FbxEventPreExport : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxEventPreExport(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventPreExport obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventPreExport() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxEventPreExport(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string GetEventName() {
    string ret = examplePINVOKE.FbxEventPreExport_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventPreExport(FbxDocument pDocument) : this(examplePINVOKE.new_FbxEventPreExport(FbxDocument.getCPtr(pDocument)), true) {
  }

  public FbxDocument mDocument {
    set {
      examplePINVOKE.FbxEventPreExport_mDocument_set(swigCPtr, FbxDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxEventPreExport_mDocument_get(swigCPtr);
      FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
      return ret;
    } 
  }

}

}
