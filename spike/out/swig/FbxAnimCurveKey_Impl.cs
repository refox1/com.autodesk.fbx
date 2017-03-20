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

public class FbxAnimCurveKey_Impl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveKey_Impl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveKey_Impl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveKey_Impl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxAnimCurveKey_Impl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void Set(FbxTime pTime, float pValue) {
    examplePINVOKE.FbxAnimCurveKey_Impl_Set(swigCPtr, FbxTime.getCPtr(pTime), pValue);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0, float pData1, float pData2) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0, pData1, pData2);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0, float pData1) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0, pData1);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_2(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_3(swigCPtr, FbxTime.getCPtr(pTime), pValue);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float GetValue() {
    float ret = examplePINVOKE.FbxAnimCurveKey_Impl_GetValue(swigCPtr);
    return ret;
  }

  public virtual void SetValue(float pValue) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetValue(swigCPtr, pValue);
  }

  public virtual FbxAnimCurveDef.EInterpolationType GetInterpolation() {
    FbxAnimCurveDef.EInterpolationType ret = (FbxAnimCurveDef.EInterpolationType)examplePINVOKE.FbxAnimCurveKey_Impl_GetInterpolation(swigCPtr);
    return ret;
  }

  public virtual void SetInterpolation(FbxAnimCurveDef.EInterpolationType pInterpolation) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetInterpolation(swigCPtr, (int)pInterpolation);
  }

  public virtual FbxAnimCurveDef.ETangentMode GetTangentMode(bool pIncludeOverrides) {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)examplePINVOKE.FbxAnimCurveKey_Impl_GetTangentMode__SWIG_0(swigCPtr, pIncludeOverrides);
    return ret;
  }

  public virtual FbxAnimCurveDef.ETangentMode GetTangentMode() {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)examplePINVOKE.FbxAnimCurveKey_Impl_GetTangentMode__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual void SetTangentMode(FbxAnimCurveDef.ETangentMode pTangentMode) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentMode(swigCPtr, (int)pTangentMode);
  }

  public virtual FbxAnimCurveDef.EWeightedMode GetTangentWeightMode() {
    FbxAnimCurveDef.EWeightedMode ret = (FbxAnimCurveDef.EWeightedMode)examplePINVOKE.FbxAnimCurveKey_Impl_GetTangentWeightMode(swigCPtr);
    return ret;
  }

  public virtual void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode, FbxAnimCurveDef.EWeightedMode pMask) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightMode__SWIG_0(swigCPtr, (int)pTangentWeightMode, (int)pMask);
  }

  public virtual void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightMode__SWIG_1(swigCPtr, (int)pTangentWeightMode);
  }

  public virtual void SetTangentWeightAndAdjustTangent(FbxAnimCurveDef.EDataIndex pIndex, double pWeight) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightAndAdjustTangent(swigCPtr, (int)pIndex, pWeight);
  }

  public virtual FbxAnimCurveDef.EVelocityMode GetTangentVelocityMode() {
    FbxAnimCurveDef.EVelocityMode ret = (FbxAnimCurveDef.EVelocityMode)examplePINVOKE.FbxAnimCurveKey_Impl_GetTangentVelocityMode(swigCPtr);
    return ret;
  }

  public virtual void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode, FbxAnimCurveDef.EVelocityMode pMask) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentVelocityMode__SWIG_0(swigCPtr, (int)pTangentVelocityMode, (int)pMask);
  }

  public virtual void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentVelocityMode__SWIG_1(swigCPtr, (int)pTangentVelocityMode);
  }

  public virtual FbxAnimCurveDef.EConstantMode GetConstantMode() {
    FbxAnimCurveDef.EConstantMode ret = (FbxAnimCurveDef.EConstantMode)examplePINVOKE.FbxAnimCurveKey_Impl_GetConstantMode(swigCPtr);
    return ret;
  }

  public virtual void SetConstantMode(FbxAnimCurveDef.EConstantMode pMode) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetConstantMode(swigCPtr, (int)pMode);
  }

  public virtual float GetDataFloat(FbxAnimCurveDef.EDataIndex pIndex) {
    float ret = examplePINVOKE.FbxAnimCurveKey_Impl_GetDataFloat(swigCPtr, (int)pIndex);
    return ret;
  }

  public virtual void SetDataFloat(FbxAnimCurveDef.EDataIndex pIndex, float pValue) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetDataFloat(swigCPtr, (int)pIndex, pValue);
  }

  public virtual void SetTangentVisibility(FbxAnimCurveDef.ETangentVisibility pVisibility) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetTangentVisibility(swigCPtr, (int)pVisibility);
  }

  public virtual FbxAnimCurveDef.ETangentVisibility GetTangentVisibility() {
    FbxAnimCurveDef.ETangentVisibility ret = (FbxAnimCurveDef.ETangentVisibility)examplePINVOKE.FbxAnimCurveKey_Impl_GetTangentVisibility(swigCPtr);
    return ret;
  }

  public virtual void SetBreak(bool pVal) {
    examplePINVOKE.FbxAnimCurveKey_Impl_SetBreak(swigCPtr, pVal);
  }

  public virtual bool GetBreak() {
    bool ret = examplePINVOKE.FbxAnimCurveKey_Impl_GetBreak(swigCPtr);
    return ret;
  }

}

}
