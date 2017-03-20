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

public class FbxConstraintRotation : FbxConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxConstraintRotation(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxConstraintRotation_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxConstraintRotation obj) {
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
      examplePINVOKE.FbxConstraintRotation_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxConstraintRotation_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxConstraintRotation Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxConstraintRotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintRotation(cPtr, false);
    return ret;
  }

  public new static FbxConstraintRotation Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxConstraintRotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintRotation(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectX {
    set {
      examplePINVOKE.FbxConstraintRotation_AffectX_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_AffectX_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectY {
    set {
      examplePINVOKE.FbxConstraintRotation_AffectY_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_AffectY_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectZ {
    set {
      examplePINVOKE.FbxConstraintRotation_AffectZ_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_AffectZ_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Rotation {
    set {
      examplePINVOKE.FbxConstraintRotation_Rotation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_Rotation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ConstraintSources {
    set {
      examplePINVOKE.FbxConstraintRotation_ConstraintSources_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_ConstraintSources_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ConstrainedObject {
    set {
      examplePINVOKE.FbxConstraintRotation_ConstrainedObject_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_ConstrainedObject_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t(cPtr, false);
      return ret;
    } 
  }

  public void AddConstraintSource(FbxObject pObject, double pWeight) {
    examplePINVOKE.FbxConstraintRotation_AddConstraintSource__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pWeight);
  }

  public void AddConstraintSource(FbxObject pObject) {
    examplePINVOKE.FbxConstraintRotation_AddConstraintSource__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public override int GetConstraintSourceCount() {
    int ret = examplePINVOKE.FbxConstraintRotation_GetConstraintSourceCount(swigCPtr);
    return ret;
  }

  public override FbxObject GetConstraintSource(int pIndex) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_GetConstraintSource(swigCPtr, pIndex);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public void SetConstrainedObject(FbxObject pObject) {
    examplePINVOKE.FbxConstraintRotation_SetConstrainedObject(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public override FbxObject GetConstrainedObject() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxConstraintRotation_GetConstrainedObject(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

}

}
