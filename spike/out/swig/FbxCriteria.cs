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

public class FbxCriteria : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxCriteria(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCriteria obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxCriteria() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxCriteria(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxCriteria ObjectType(FbxClassId pClassId) {
    FbxCriteria ret = new FbxCriteria(examplePINVOKE.FbxCriteria_ObjectType(FbxClassId.getCPtr(pClassId)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxCriteria ObjectTypeStrict(FbxClassId pClassId) {
    FbxCriteria ret = new FbxCriteria(examplePINVOKE.FbxCriteria_ObjectTypeStrict(FbxClassId.getCPtr(pClassId)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxCriteria IsProperty() {
    FbxCriteria ret = new FbxCriteria(examplePINVOKE.FbxCriteria_IsProperty(), true);
    return ret;
  }

  public FbxQuery GetQuery() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxCriteria_GetQuery(swigCPtr);
    FbxQuery ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxQuery(cPtr, false);
    return ret;
  }

  public FbxCriteria() : this(examplePINVOKE.new_FbxCriteria__SWIG_0(), true) {
  }

  public FbxCriteria(FbxCriteria pCriteria) : this(examplePINVOKE.new_FbxCriteria__SWIG_1(FbxCriteria.getCPtr(pCriteria)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxCriteria(FbxQuery pQuery) : this(examplePINVOKE.new_FbxCriteria__SWIG_2(FbxQuery.getCPtr(pQuery)), true) {
  }

}

}
