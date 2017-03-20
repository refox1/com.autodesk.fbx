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

public class FbxSkeleton : FbxNodeAttribute {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSkeleton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxSkeleton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSkeleton obj) {
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
      examplePINVOKE.FbxSkeleton_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSkeleton_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxSkeleton_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSkeleton Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkeleton_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSkeleton ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSkeleton(cPtr, false);
    return ret;
  }

  public new static FbxSkeleton Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkeleton_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSkeleton ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSkeleton(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)examplePINVOKE.FbxSkeleton_GetAttributeType(swigCPtr);
    return ret;
  }

  public void Reset() {
    examplePINVOKE.FbxSkeleton_Reset(swigCPtr);
  }

  public void SetSkeletonType(FbxSkeleton.EType pSkeletonType) {
    examplePINVOKE.FbxSkeleton_SetSkeletonType(swigCPtr, (int)pSkeletonType);
  }

  public FbxSkeleton.EType GetSkeletonType() {
    FbxSkeleton.EType ret = (FbxSkeleton.EType)examplePINVOKE.FbxSkeleton_GetSkeletonType(swigCPtr);
    return ret;
  }

  public bool GetSkeletonTypeIsSet() {
    bool ret = examplePINVOKE.FbxSkeleton_GetSkeletonTypeIsSet(swigCPtr);
    return ret;
  }

  public FbxSkeleton.EType GetSkeletonTypeDefaultValue() {
    FbxSkeleton.EType ret = (FbxSkeleton.EType)examplePINVOKE.FbxSkeleton_GetSkeletonTypeDefaultValue(swigCPtr);
    return ret;
  }

  public double GetLimbLengthDefaultValue() {
    double ret = examplePINVOKE.FbxSkeleton_GetLimbLengthDefaultValue(swigCPtr);
    return ret;
  }

  public double GetLimbNodeSizeDefaultValue() {
    double ret = examplePINVOKE.FbxSkeleton_GetLimbNodeSizeDefaultValue(swigCPtr);
    return ret;
  }

  public bool SetLimbNodeColor(FbxColor pColor) {
    bool ret = examplePINVOKE.FbxSkeleton_SetLimbNodeColor(swigCPtr, FbxColor.getCPtr(pColor));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxColor GetLimbNodeColor() {
    FbxColor ret = new FbxColor(examplePINVOKE.FbxSkeleton_GetLimbNodeColor(swigCPtr), true);
    return ret;
  }

  public bool GetLimbNodeColorIsSet() {
    bool ret = examplePINVOKE.FbxSkeleton_GetLimbNodeColorIsSet(swigCPtr);
    return ret;
  }

  public FbxColor GetLimbNodeColorDefaultValue() {
    FbxColor ret = new FbxColor(examplePINVOKE.FbxSkeleton_GetLimbNodeColorDefaultValue(swigCPtr), true);
    return ret;
  }

  public bool IsSkeletonRoot() {
    bool ret = examplePINVOKE.FbxSkeleton_IsSkeletonRoot(swigCPtr);
    return ret;
  }

  public static string sSize {
    set {
      examplePINVOKE.FbxSkeleton_sSize_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxSkeleton_sSize_get();
      return ret;
    } 
  }

  public static string sLimbLength {
    set {
      examplePINVOKE.FbxSkeleton_sLimbLength_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxSkeleton_sLimbLength_get();
      return ret;
    } 
  }

  public static double sDefaultSize {
    get {
      double ret = examplePINVOKE.FbxSkeleton_sDefaultSize_get();
      return ret;
    } 
  }

  public static double sDefaultLimbLength {
    get {
      double ret = examplePINVOKE.FbxSkeleton_sDefaultLimbLength_get();
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t Size {
    set {
      examplePINVOKE.FbxSkeleton_Size_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSkeleton_Size_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t LimbLength {
    set {
      examplePINVOKE.FbxSkeleton_LimbLength_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSkeleton_LimbLength_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(examplePINVOKE.FbxSkeleton_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EType {
    eRoot,
    eLimb,
    eLimbNode,
    eEffector
  }

}

}
