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

public class FbxIOBase : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxIOBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxIOBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxIOBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxIOBase_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxIOBase_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxIOBase_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxIOBase Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxIOBase_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxIOBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOBase(cPtr, false);
    return ret;
  }

  public new static FbxIOBase Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxIOBase_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxIOBase ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOBase(cPtr, false);
    return ret;
  }

  public virtual bool Initialize(string pFileName, int pFileFormat, FbxIOSettings pIOSettings) {
    bool ret = examplePINVOKE.FbxIOBase_Initialize__SWIG_0(swigCPtr, pFileName, pFileFormat, FbxIOSettings.getCPtr(pIOSettings));
    return ret;
  }

  public virtual bool Initialize(string pFileName, int pFileFormat) {
    bool ret = examplePINVOKE.FbxIOBase_Initialize__SWIG_1(swigCPtr, pFileName, pFileFormat);
    return ret;
  }

  public virtual bool Initialize(string pFileName) {
    bool ret = examplePINVOKE.FbxIOBase_Initialize__SWIG_2(swigCPtr, pFileName);
    return ret;
  }

  public virtual FbxString GetFileName() {
    FbxString ret = new FbxString(examplePINVOKE.FbxIOBase_GetFileName(swigCPtr), true);
    return ret;
  }

  public FbxStatus GetStatus() {
    FbxStatus ret = new FbxStatus(examplePINVOKE.FbxIOBase_GetStatus(swigCPtr), false);
    return ret;
  }

}

}
