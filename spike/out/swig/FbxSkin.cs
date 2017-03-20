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

public class FbxSkin : FbxDeformer {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSkin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxSkin_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSkin obj) {
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
      examplePINVOKE.FbxSkin_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxSkin_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSkin Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSkin ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSkin(cPtr, false);
    return ret;
  }

  public new static FbxSkin Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSkin ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSkin(cPtr, false);
    return ret;
  }

  public void SetDeformAccuracy(double pDeformAccuracy) {
    examplePINVOKE.FbxSkin_SetDeformAccuracy(swigCPtr, pDeformAccuracy);
  }

  public double GetDeformAccuracy() {
    double ret = examplePINVOKE.FbxSkin_GetDeformAccuracy(swigCPtr);
    return ret;
  }

  public bool SetGeometry(FbxGeometry pGeometry) {
    bool ret = examplePINVOKE.FbxSkin_SetGeometry(swigCPtr, FbxGeometry.getCPtr(pGeometry));
    return ret;
  }

  public FbxGeometry GetGeometry() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_GetGeometry(swigCPtr);
    FbxGeometry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometry(cPtr, false);
    return ret;
  }

  public bool AddCluster(FbxCluster pCluster) {
    bool ret = examplePINVOKE.FbxSkin_AddCluster(swigCPtr, FbxCluster.getCPtr(pCluster));
    return ret;
  }

  public FbxCluster RemoveCluster(FbxCluster pCluster) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_RemoveCluster(swigCPtr, FbxCluster.getCPtr(pCluster));
    FbxCluster ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCluster(cPtr, false);
    return ret;
  }

  public int GetClusterCount() {
    int ret = examplePINVOKE.FbxSkin_GetClusterCount(swigCPtr);
    return ret;
  }

  public FbxCluster GetCluster(int pIndex) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_GetCluster__SWIG_0(swigCPtr, pIndex);
    FbxCluster ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCluster(cPtr, false);
    return ret;
  }

  public override FbxDeformer.EDeformerType GetDeformerType() {
    FbxDeformer.EDeformerType ret = (FbxDeformer.EDeformerType)examplePINVOKE.FbxSkin_GetDeformerType(swigCPtr);
    return ret;
  }

  public void SetSkinningType(FbxSkin.EType pType) {
    examplePINVOKE.FbxSkin_SetSkinningType(swigCPtr, (int)pType);
  }

  public FbxSkin.EType GetSkinningType() {
    FbxSkin.EType ret = (FbxSkin.EType)examplePINVOKE.FbxSkin_GetSkinningType(swigCPtr);
    return ret;
  }

  public void AddControlPointIndex(int pIndex, double pBlendWeight) {
    examplePINVOKE.FbxSkin_AddControlPointIndex__SWIG_0(swigCPtr, pIndex, pBlendWeight);
  }

  public void AddControlPointIndex(int pIndex) {
    examplePINVOKE.FbxSkin_AddControlPointIndex__SWIG_1(swigCPtr, pIndex);
  }

  public int GetControlPointIndicesCount() {
    int ret = examplePINVOKE.FbxSkin_GetControlPointIndicesCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_int GetControlPointIndices() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_GetControlPointIndices(swigCPtr);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_double GetControlPointBlendWeights() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_GetControlPointBlendWeights(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public void SetControlPointIWCount(int pCount) {
    examplePINVOKE.FbxSkin_SetControlPointIWCount(swigCPtr, pCount);
  }

  public override void Compact() {
    examplePINVOKE.FbxSkin_Compact(swigCPtr);
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(examplePINVOKE.FbxSkin_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType, FbxObject pContainer, SWIGTYPE_p_void pSet) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Clone__SWIG_0(swigCPtr, (int)pCloneType, FbxObject.getCPtr(pContainer), SWIGTYPE_p_void.getCPtr(pSet));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType, FbxObject pContainer) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Clone__SWIG_1(swigCPtr, (int)pCloneType, FbxObject.getCPtr(pContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Clone__SWIG_2(swigCPtr, (int)pCloneType);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSkin_Clone__SWIG_3(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public enum EType {
    eRigid,
    eLinear,
    eDualQuaternion,
    eBlend
  }

}

}
