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

public class FbxPluginData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxPluginData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPluginData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPluginData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxPluginData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxPluginData() : this(examplePINVOKE.new_FbxPluginData__SWIG_0(), true) {
  }

  public FbxPluginData(FbxPluginData pOther) : this(examplePINVOKE.new_FbxPluginData__SWIG_1(FbxPluginData.getCPtr(pOther)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxEmitter mQueryEmitter {
    set {
      examplePINVOKE.FbxPluginData_mQueryEmitter_set(swigCPtr, FbxEmitter.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxPluginData_mQueryEmitter_get(swigCPtr);
      FbxEmitter ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxEmitter(cPtr, false);
      return ret;
    } 
  }

  public FbxManager mSDKManager {
    set {
      examplePINVOKE.FbxPluginData_mSDKManager_set(swigCPtr, FbxManager.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxPluginData_mSDKManager_get(swigCPtr);
      FbxManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxManager(cPtr, false);
      return ret;
    } 
  }

  public FbxPluginContainer mPluginContainer {
    set {
      examplePINVOKE.FbxPluginData_mPluginContainer_set(swigCPtr, FbxPluginContainer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxPluginData_mPluginContainer_get(swigCPtr);
      FbxPluginContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPluginContainer(cPtr, false);
      return ret;
    } 
  }

}

}
