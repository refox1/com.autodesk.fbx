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

public class FbxAMatrix : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAMatrix(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAMatrix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAMatrix() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxAMatrix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxAMatrix() : this(examplePINVOKE.new_FbxAMatrix__SWIG_0(), true) {
  }

  public FbxAMatrix(FbxAMatrix pOther) : this(examplePINVOKE.new_FbxAMatrix__SWIG_1(FbxAMatrix.getCPtr(pOther)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxAMatrix(FbxVector4 pT, FbxVector4 pR, FbxVector4 pS) : this(examplePINVOKE.new_FbxAMatrix__SWIG_2(FbxVector4.getCPtr(pT), FbxVector4.getCPtr(pR), FbxVector4.getCPtr(pS)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public double Get(int pY, int pX) {
    double ret = examplePINVOKE.FbxAMatrix_Get(swigCPtr, pY, pX);
    return ret;
  }

  public FbxVector4 GetT() {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetT(swigCPtr), true);
    return ret;
  }

  public FbxVector4 GetR() {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetR__SWIG_0(swigCPtr), true);
    return ret;
  }

  public FbxQuaternion GetQ() {
    FbxQuaternion ret = new FbxQuaternion(examplePINVOKE.FbxAMatrix_GetQ(swigCPtr), true);
    return ret;
  }

  public FbxVector4 GetS() {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetS(swigCPtr), true);
    return ret;
  }

  public FbxVector4 GetRow(int pY) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetRow(swigCPtr, pY), true);
    return ret;
  }

  public FbxVector4 GetColumn(int pX) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetColumn(swigCPtr, pX), true);
    return ret;
  }

  public void SetIdentity() {
    examplePINVOKE.FbxAMatrix_SetIdentity(swigCPtr);
  }

  public void SetT(FbxVector4 pT) {
    examplePINVOKE.FbxAMatrix_SetT(swigCPtr, FbxVector4.getCPtr(pT));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetR(FbxVector4 pR) {
    examplePINVOKE.FbxAMatrix_SetR__SWIG_0(swigCPtr, FbxVector4.getCPtr(pR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetQ(FbxQuaternion pQ) {
    examplePINVOKE.FbxAMatrix_SetQ(swigCPtr, FbxQuaternion.getCPtr(pQ));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetS(FbxVector4 pS) {
    examplePINVOKE.FbxAMatrix_SetS(swigCPtr, FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTRS(FbxVector4 pT, FbxVector4 pR, FbxVector4 pS) {
    examplePINVOKE.FbxAMatrix_SetTRS__SWIG_0(swigCPtr, FbxVector4.getCPtr(pT), FbxVector4.getCPtr(pR), FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTQS(FbxVector4 pT, FbxQuaternion pQ, FbxVector4 pS) {
    examplePINVOKE.FbxAMatrix_SetTQS(swigCPtr, FbxVector4.getCPtr(pT), FbxQuaternion.getCPtr(pQ), FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 MultT(FbxVector4 pVector4) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_MultT(swigCPtr, FbxVector4.getCPtr(pVector4)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector4 MultR(FbxVector4 pVector4) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_MultR(swigCPtr, FbxVector4.getCPtr(pVector4)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxQuaternion MultQ(FbxQuaternion pQuaternion) {
    FbxQuaternion ret = new FbxQuaternion(examplePINVOKE.FbxAMatrix_MultQ(swigCPtr, FbxQuaternion.getCPtr(pQuaternion)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector4 MultS(FbxVector4 pVector4) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_MultS(swigCPtr, FbxVector4.getCPtr(pVector4)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxAMatrix Inverse() {
    FbxAMatrix ret = new FbxAMatrix(examplePINVOKE.FbxAMatrix_Inverse(swigCPtr), true);
    return ret;
  }

  public FbxAMatrix Transpose() {
    FbxAMatrix ret = new FbxAMatrix(examplePINVOKE.FbxAMatrix_Transpose(swigCPtr), true);
    return ret;
  }

  public FbxAMatrix Slerp(FbxAMatrix pOther, double pWeight) {
    FbxAMatrix ret = new FbxAMatrix(examplePINVOKE.FbxAMatrix_Slerp(swigCPtr, FbxAMatrix.getCPtr(pOther), pWeight), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_a_4__a_4__double Double44() {
    SWIGTYPE_p_a_4__a_4__double ret = new SWIGTYPE_p_a_4__a_4__double(examplePINVOKE.FbxAMatrix_Double44(swigCPtr), false);
    return ret;
  }

  public bool IsIdentity(double pThreshold) {
    bool ret = examplePINVOKE.FbxAMatrix_IsIdentity__SWIG_0(swigCPtr, pThreshold);
    return ret;
  }

  public bool IsIdentity() {
    bool ret = examplePINVOKE.FbxAMatrix_IsIdentity__SWIG_1(swigCPtr);
    return ret;
  }

  public FbxAMatrix(FbxVector4 pT, FbxQuaternion pQ, FbxVector4 pS) : this(examplePINVOKE.new_FbxAMatrix__SWIG_3(FbxVector4.getCPtr(pT), FbxQuaternion.getCPtr(pQ), FbxVector4.getCPtr(pS)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTRS(FbxVector4 pT, FbxAMatrix pRM, FbxVector4 pS) {
    examplePINVOKE.FbxAMatrix_SetTRS__SWIG_1(swigCPtr, FbxVector4.getCPtr(pT), FbxAMatrix.getCPtr(pRM), FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(int pY, FbxVector4 pRow) {
    examplePINVOKE.FbxAMatrix_SetRow(swigCPtr, pY, FbxVector4.getCPtr(pRow));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTOnly(FbxVector4 pT) {
    examplePINVOKE.FbxAMatrix_SetTOnly(swigCPtr, FbxVector4.getCPtr(pT));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetROnly(FbxVector4 pR) {
    examplePINVOKE.FbxAMatrix_SetROnly(swigCPtr, FbxVector4.getCPtr(pR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetQOnly(FbxQuaternion pQ) {
    examplePINVOKE.FbxAMatrix_SetQOnly(swigCPtr, FbxQuaternion.getCPtr(pQ));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetROnly() {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetROnly(swigCPtr), true);
    return ret;
  }

  public FbxQuaternion GetUnnormalizedQ() {
    FbxQuaternion ret = new FbxQuaternion(examplePINVOKE.FbxAMatrix_GetUnnormalizedQ(swigCPtr), true);
    return ret;
  }

  public void SetR(FbxVector4 pV, int pOrd) {
    examplePINVOKE.FbxAMatrix_SetR__SWIG_1(swigCPtr, FbxVector4.getCPtr(pV), pOrd);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetR(int pOrd) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxAMatrix_GetR__SWIG_1(swigCPtr, pOrd), true);
    return ret;
  }

  public void MultRM(FbxVector4 pR) {
    examplePINVOKE.FbxAMatrix_MultRM(swigCPtr, FbxVector4.getCPtr(pR));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void MultSM(FbxVector4 pS) {
    examplePINVOKE.FbxAMatrix_MultSM(swigCPtr, FbxVector4.getCPtr(pS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsRightHand() {
    bool ret = examplePINVOKE.FbxAMatrix_IsRightHand(swigCPtr);
    return ret;
  }

  public double Determinant() {
    double ret = examplePINVOKE.FbxAMatrix_Determinant(swigCPtr);
    return ret;
  }

  public int Compare(FbxAMatrix pM, double pThreshold) {
    int ret = examplePINVOKE.FbxAMatrix_Compare__SWIG_0(swigCPtr, FbxAMatrix.getCPtr(pM), pThreshold);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxAMatrix pM) {
    int ret = examplePINVOKE.FbxAMatrix_Compare__SWIG_1(swigCPtr, FbxAMatrix.getCPtr(pM));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
