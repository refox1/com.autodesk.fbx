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

public class FbxTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTransform() : this(examplePINVOKE.new_FbxTransform(), true) {
  }

  public FbxTransform.EInheritType GetInheritType() {
    FbxTransform.EInheritType ret = (FbxTransform.EInheritType)examplePINVOKE.FbxTransform_GetInheritType(swigCPtr);
    return ret;
  }

  public void SetInheritType(FbxTransform.EInheritType pType) {
    examplePINVOKE.FbxTransform_SetInheritType(swigCPtr, (int)pType);
  }

  public FbxLimits GetTranslationLimits() {
    FbxLimits ret = new FbxLimits(examplePINVOKE.FbxTransform_GetTranslationLimits(swigCPtr), false);
    return ret;
  }

  public FbxLimits GetRotationLimits() {
    FbxLimits ret = new FbxLimits(examplePINVOKE.FbxTransform_GetRotationLimits(swigCPtr), false);
    return ret;
  }

  public FbxLimits GetScalingLimits() {
    FbxLimits ret = new FbxLimits(examplePINVOKE.FbxTransform_GetScalingLimits(swigCPtr), false);
    return ret;
  }

  public FbxRotationOrder GetRotationOrder() {
    FbxRotationOrder ret = new FbxRotationOrder(examplePINVOKE.FbxTransform_GetRotationOrder(swigCPtr), false);
    return ret;
  }

  public bool HasROffset() {
    bool ret = examplePINVOKE.FbxTransform_HasROffset(swigCPtr);
    return ret;
  }

  public bool HasRPivot() {
    bool ret = examplePINVOKE.FbxTransform_HasRPivot(swigCPtr);
    return ret;
  }

  public bool HasSOffset() {
    bool ret = examplePINVOKE.FbxTransform_HasSOffset(swigCPtr);
    return ret;
  }

  public bool HasSPivot() {
    bool ret = examplePINVOKE.FbxTransform_HasSPivot(swigCPtr);
    return ret;
  }

  public bool HasPreRM() {
    bool ret = examplePINVOKE.FbxTransform_HasPreRM(swigCPtr);
    return ret;
  }

  public bool HasPostRM() {
    bool ret = examplePINVOKE.FbxTransform_HasPostRM(swigCPtr);
    return ret;
  }

  public void SetROffset(FbxVector4 pROffset) {
    examplePINVOKE.FbxTransform_SetROffset(swigCPtr, FbxVector4.getCPtr(pROffset));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRPivot(FbxVector4 pRPivot) {
    examplePINVOKE.FbxTransform_SetRPivot(swigCPtr, FbxVector4.getCPtr(pRPivot));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSOffset(FbxVector4 pSOffset) {
    examplePINVOKE.FbxTransform_SetSOffset(swigCPtr, FbxVector4.getCPtr(pSOffset));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSPivot(FbxVector4 pSPivot) {
    examplePINVOKE.FbxTransform_SetSPivot(swigCPtr, FbxVector4.getCPtr(pSPivot));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPreRM(FbxVector4 pPreR) {
    examplePINVOKE.FbxTransform_SetPreRM(swigCPtr, FbxVector4.getCPtr(pPreR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPostRM(FbxVector4 pPostR) {
    examplePINVOKE.FbxTransform_SetPostRM(swigCPtr, FbxVector4.getCPtr(pPostR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetRotationSpaceForLimitOnly() {
    bool ret = examplePINVOKE.FbxTransform_GetRotationSpaceForLimitOnly(swigCPtr);
    return ret;
  }

  public void SetRotationSpaceForLimitOnly(bool pRotationSpaceForLimitOnly) {
    examplePINVOKE.FbxTransform_SetRotationSpaceForLimitOnly(swigCPtr, pRotationSpaceForLimitOnly);
  }

  public void DoF2LT(FbxVector4 pLT, FbxVector4 pDoF, FbxAMatrix pLRM, FbxAMatrix pLSM) {
    examplePINVOKE.FbxTransform_DoF2LT(swigCPtr, FbxVector4.getCPtr(pLT), FbxVector4.getCPtr(pDoF), FbxAMatrix.getCPtr(pLRM), FbxAMatrix.getCPtr(pLSM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LT2DoF(FbxVector4 pDoF, FbxVector4 pLT, FbxAMatrix pLRM, FbxAMatrix pLSM) {
    examplePINVOKE.FbxTransform_LT2DoF(swigCPtr, FbxVector4.getCPtr(pDoF), FbxVector4.getCPtr(pLT), FbxAMatrix.getCPtr(pLRM), FbxAMatrix.getCPtr(pLSM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DoF2LRM(FbxAMatrix pLRM, FbxVector4 pRDoF, bool pForLimit) {
    examplePINVOKE.FbxTransform_DoF2LRM__SWIG_0(swigCPtr, FbxAMatrix.getCPtr(pLRM), FbxVector4.getCPtr(pRDoF), pForLimit);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DoF2LRM(FbxAMatrix pLRM, FbxVector4 pRDoF) {
    examplePINVOKE.FbxTransform_DoF2LRM__SWIG_1(swigCPtr, FbxAMatrix.getCPtr(pLRM), FbxVector4.getCPtr(pRDoF));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LRM2DoF(FbxVector4 pRDoF, FbxAMatrix pLRM, bool pForLimit) {
    examplePINVOKE.FbxTransform_LRM2DoF__SWIG_0(swigCPtr, FbxVector4.getCPtr(pRDoF), FbxAMatrix.getCPtr(pLRM), pForLimit);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LRM2DoF(FbxVector4 pRDoF, FbxAMatrix pLRM) {
    examplePINVOKE.FbxTransform_LRM2DoF__SWIG_1(swigCPtr, FbxVector4.getCPtr(pRDoF), FbxAMatrix.getCPtr(pLRM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LSM2GSM(FbxAMatrix pGSM, FbxAMatrix pPGSM, FbxAMatrix pLSM, FbxAMatrix pLRM, FbxVector4 pPLS) {
    examplePINVOKE.FbxTransform_LSM2GSM(swigCPtr, FbxAMatrix.getCPtr(pGSM), FbxAMatrix.getCPtr(pPGSM), FbxAMatrix.getCPtr(pLSM), FbxAMatrix.getCPtr(pLRM), FbxVector4.getCPtr(pPLS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GTRSM2GX(FbxAMatrix pGX, FbxVector4 pGT, FbxAMatrix pGRM, FbxAMatrix pGSM) {
    examplePINVOKE.FbxTransform_GTRSM2GX(swigCPtr, FbxAMatrix.getCPtr(pGX), FbxVector4.getCPtr(pGT), FbxAMatrix.getCPtr(pGRM), FbxAMatrix.getCPtr(pGSM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum EInheritType {
    eInheritRrSs,
    eInheritRSrs,
    eInheritRrs
  }

}

}
