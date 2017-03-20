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

public class FbxHungryAllocator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxHungryAllocator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxHungryAllocator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxHungryAllocator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxHungryAllocator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxHungryAllocator(uint pRecordSize) : this(examplePINVOKE.new_FbxHungryAllocator__SWIG_0(pRecordSize), true) {
  }

  public FbxHungryAllocator(FbxHungryAllocator pOther) : this(examplePINVOKE.new_FbxHungryAllocator__SWIG_1(FbxHungryAllocator.getCPtr(pOther)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reserve(uint pRecordCount) {
    examplePINVOKE.FbxHungryAllocator_Reserve(swigCPtr, pRecordCount);
  }

  public SWIGTYPE_p_void AllocateRecords(uint pRecordCount) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxHungryAllocator_AllocateRecords__SWIG_0(swigCPtr, pRecordCount);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void AllocateRecords() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxHungryAllocator_AllocateRecords__SWIG_1(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void FreeMemory(SWIGTYPE_p_void arg0) {
    examplePINVOKE.FbxHungryAllocator_FreeMemory(swigCPtr, SWIGTYPE_p_void.getCPtr(arg0));
  }

  public uint GetRecordSize() {
    uint ret = examplePINVOKE.FbxHungryAllocator_GetRecordSize(swigCPtr);
    return ret;
  }

}

}
