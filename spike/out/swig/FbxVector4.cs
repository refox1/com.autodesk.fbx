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

public class FbxVector4 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxVector4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxVector4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxVector4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxVector4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxVector4() : this(examplePINVOKE.new_FbxVector4__SWIG_0(), true) {
  }

  public FbxVector4(FbxVector4 pVector4) : this(examplePINVOKE.new_FbxVector4__SWIG_1(FbxVector4.getCPtr(pVector4)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxVector4(double pX, double pY, double pZ, double pW) : this(examplePINVOKE.new_FbxVector4__SWIG_2(pX, pY, pZ, pW), true) {
  }

  public FbxVector4(double pX, double pY, double pZ) : this(examplePINVOKE.new_FbxVector4__SWIG_3(pX, pY, pZ), true) {
  }

  public FbxVector4(SWIGTYPE_p_double pValue) : this(examplePINVOKE.new_FbxVector4__SWIG_4(SWIGTYPE_p_double.getCPtr(pValue)), true) {
  }

  public FbxVector4(SWIGTYPE_p_FbxVectorTemplate3T_double_t pValue) : this(examplePINVOKE.new_FbxVector4__SWIG_5(SWIGTYPE_p_FbxVectorTemplate3T_double_t.getCPtr(pValue)), true) {
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(double pX, double pY, double pZ, double pW) {
    examplePINVOKE.FbxVector4_Set__SWIG_0(swigCPtr, pX, pY, pZ, pW);
  }

  public void Set(double pX, double pY, double pZ) {
    examplePINVOKE.FbxVector4_Set__SWIG_1(swigCPtr, pX, pY, pZ);
  }

  public double DotProduct(FbxVector4 pVector) {
    double ret = examplePINVOKE.FbxVector4_DotProduct(swigCPtr, FbxVector4.getCPtr(pVector));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxVector4 CrossProduct(FbxVector4 pVector) {
    FbxVector4 ret = new FbxVector4(examplePINVOKE.FbxVector4_CrossProduct(swigCPtr, FbxVector4.getCPtr(pVector)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool AxisAlignmentInEulerAngle(FbxVector4 pAB, FbxVector4 pA, FbxVector4 pB, FbxVector4 pAngles) {
    bool ret = examplePINVOKE.FbxVector4_AxisAlignmentInEulerAngle(FbxVector4.getCPtr(pAB), FbxVector4.getCPtr(pA), FbxVector4.getCPtr(pB), FbxVector4.getCPtr(pAngles));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Length() {
    double ret = examplePINVOKE.FbxVector4_Length(swigCPtr);
    return ret;
  }

  public double SquareLength() {
    double ret = examplePINVOKE.FbxVector4_SquareLength(swigCPtr);
    return ret;
  }

  public double Distance(FbxVector4 pVector) {
    double ret = examplePINVOKE.FbxVector4_Distance(swigCPtr, FbxVector4.getCPtr(pVector));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Normalize() {
    examplePINVOKE.FbxVector4_Normalize(swigCPtr);
  }

  public void SetXYZ(FbxQuaternion pQuat) {
    examplePINVOKE.FbxVector4_SetXYZ(swigCPtr, FbxQuaternion.getCPtr(pQuat));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsZero(int pSize) {
    bool ret = examplePINVOKE.FbxVector4_IsZero__SWIG_0(swigCPtr, pSize);
    return ret;
  }

  public bool IsZero() {
    bool ret = examplePINVOKE.FbxVector4_IsZero__SWIG_1(swigCPtr);
    return ret;
  }

  public void FixIncorrectValue() {
    examplePINVOKE.FbxVector4_FixIncorrectValue(swigCPtr);
  }

  public int Compare(FbxVector4 pV, double pThreshold) {
    int ret = examplePINVOKE.FbxVector4_Compare__SWIG_0(swigCPtr, FbxVector4.getCPtr(pV), pThreshold);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(FbxVector4 pV) {
    int ret = examplePINVOKE.FbxVector4_Compare__SWIG_1(swigCPtr, FbxVector4.getCPtr(pV));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
