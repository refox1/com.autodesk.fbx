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

public class FbxEventPopulateSystemLibrary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxEventPopulateSystemLibrary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventPopulateSystemLibrary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventPopulateSystemLibrary() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxEventPopulateSystemLibrary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string GetEventName() {
    string ret = examplePINVOKE.FbxEventPopulateSystemLibrary_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventPopulateSystemLibrary(FbxLibrary pLibrary) : this(examplePINVOKE.new_FbxEventPopulateSystemLibrary(FbxLibrary.getCPtr(pLibrary)), true) {
  }

  public FbxLibrary GetLibrary() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxEventPopulateSystemLibrary_GetLibrary(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

}

}
