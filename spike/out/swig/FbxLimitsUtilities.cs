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

public class FbxLimitsUtilities : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxLimitsUtilities(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLimitsUtilities obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLimitsUtilities() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxLimitsUtilities(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxLimitsUtilities(FbxNode pNode) : this(examplePINVOKE.new_FbxLimitsUtilities(FbxNode.getCPtr(pNode)), true) {
  }

  public void SetAuto(FbxLimitsUtilities.EType pType, bool pAuto) {
    examplePINVOKE.FbxLimitsUtilities_SetAuto(swigCPtr, (int)pType, pAuto);
  }

  public bool GetAuto(FbxLimitsUtilities.EType pType) {
    bool ret = examplePINVOKE.FbxLimitsUtilities_GetAuto(swigCPtr, (int)pType);
    return ret;
  }

  public void SetEnable(FbxLimitsUtilities.EType pType, bool pEnable) {
    examplePINVOKE.FbxLimitsUtilities_SetEnable(swigCPtr, (int)pType, pEnable);
  }

  public bool GetEnable(FbxLimitsUtilities.EType pType) {
    bool ret = examplePINVOKE.FbxLimitsUtilities_GetEnable(swigCPtr, (int)pType);
    return ret;
  }

  public void SetDefault(FbxLimitsUtilities.EType pType, FbxVector4 pDefault) {
    examplePINVOKE.FbxLimitsUtilities_SetDefault(swigCPtr, (int)pType, FbxVector4.getCPtr(pDefault));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetDefault(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetDefault(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetMin(FbxLimitsUtilities.EType pType, FbxVector4 pMin) {
    examplePINVOKE.FbxLimitsUtilities_SetMin(swigCPtr, (int)pType, FbxVector4.getCPtr(pMin));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetMin(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetMin(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetMax(FbxLimitsUtilities.EType pType, FbxVector4 pMax) {
    examplePINVOKE.FbxLimitsUtilities_SetMax(swigCPtr, (int)pType, FbxVector4.getCPtr(pMax));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetMax(FbxLimitsUtilities.EType pType) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetMax(swigCPtr, (int)pType), true);
    return ret;
  }

  public void SetRotationType(FbxLimitsUtilities.ERotationType pType) {
    examplePINVOKE.FbxLimitsUtilities_SetRotationType(swigCPtr, (int)pType);
  }

  public FbxLimitsUtilities.ERotationType GetRotationType() {
    FbxLimitsUtilities.ERotationType ret = (FbxLimitsUtilities.ERotationType)examplePINVOKE.FbxLimitsUtilities_GetRotationType(swigCPtr);
    return ret;
  }

  public FbxLimitsUtilities.ERotationClampType GetRotationClampType() {
    FbxLimitsUtilities.ERotationClampType ret = (FbxLimitsUtilities.ERotationClampType)examplePINVOKE.FbxLimitsUtilities_GetRotationClampType(swigCPtr);
    return ret;
  }

  public void SetRotationAxis(FbxVector4 pRotationAxis) {
    examplePINVOKE.FbxLimitsUtilities_SetRotationAxis(swigCPtr, FbxVector4.getCPtr(pRotationAxis));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetRotationAxis() {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetRotationAxis(swigCPtr), true);
    return ret;
  }

  public void SetAxisLength(double pLength) {
    examplePINVOKE.FbxLimitsUtilities_SetAxisLength(swigCPtr, pLength);
  }

  public double GetAxisLength() {
    double ret = examplePINVOKE.FbxLimitsUtilities_GetAxisLength(swigCPtr);
    return ret;
  }

  public void UpdateAutomatic(FbxNode pNode) {
    examplePINVOKE.FbxLimitsUtilities_UpdateAutomatic(swigCPtr, FbxNode.getCPtr(pNode));
  }

  public FbxVector4 GetEndPointTranslation(FbxNode pNode) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetEndPointTranslation(swigCPtr, FbxNode.getCPtr(pNode)), true);
    return ret;
  }

  public FbxVector4 GetEndSite(FbxNode pNode) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxLimitsUtilities_GetEndSite(swigCPtr, FbxNode.getCPtr(pNode)), true);
    return ret;
  }

  public FbxNode mNode {
    set {
      examplePINVOKE.FbxLimitsUtilities_mNode_set(swigCPtr, FbxNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxLimitsUtilities_mNode_get(swigCPtr);
      FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
      return ret;
    } 
  }

  public double mAxisLength {
    set {
      examplePINVOKE.FbxLimitsUtilities_mAxisLength_set(swigCPtr, value);
    } 
    get {
      double ret = examplePINVOKE.FbxLimitsUtilities_mAxisLength_get(swigCPtr);
      return ret;
    } 
  }

  public enum EType {
    eTranslation,
    eRotation,
    eScaling
  }

  public enum ERotationType {
    eQuaternion,
    eEuler
  }

  public enum ERotationClampType {
    eRectangular,
    eEllipsoid
  }

}

}
