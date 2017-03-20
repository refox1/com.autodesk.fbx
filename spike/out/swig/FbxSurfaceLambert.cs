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

public class FbxSurfaceLambert : FbxSurfaceMaterial {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSurfaceLambert(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxSurfaceLambert_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSurfaceLambert obj) {
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
      examplePINVOKE.FbxSurfaceLambert_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public virtual FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxSurfaceLambert_GetClassId(swigCPtr), true);
    return ret;
  }

  public static FbxSurfaceLambert Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public static FbxSurfaceLambert Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Emissive {
    set {
      examplePINVOKE.FbxSurfaceLambert_Emissive_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Emissive_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t EmissiveFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_EmissiveFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_EmissiveFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Ambient {
    set {
      examplePINVOKE.FbxSurfaceLambert_Ambient_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Ambient_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t AmbientFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_AmbientFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_AmbientFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Diffuse {
    set {
      examplePINVOKE.FbxSurfaceLambert_Diffuse_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Diffuse_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t DiffuseFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_DiffuseFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_DiffuseFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t NormalMap {
    set {
      examplePINVOKE.FbxSurfaceLambert_NormalMap_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_NormalMap_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t Bump {
    set {
      examplePINVOKE.FbxSurfaceLambert_Bump_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_Bump_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t BumpFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_BumpFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_BumpFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t TransparentColor {
    set {
      examplePINVOKE.FbxSurfaceLambert_TransparentColor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_TransparentColor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t TransparencyFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_TransparencyFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_TransparencyFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t DisplacementColor {
    set {
      examplePINVOKE.FbxSurfaceLambert_DisplacementColor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_DisplacementColor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t DisplacementFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_DisplacementFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_DisplacementFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t VectorDisplacementColor {
    set {
      examplePINVOKE.FbxSurfaceLambert_VectorDisplacementColor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_VectorDisplacementColor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxVectorTemplate3T_double_t_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_double_t VectorDisplacementFactor {
    set {
      examplePINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_double_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_double_t(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sEmissiveDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sEmissiveDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sEmissiveFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sEmissiveFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sAmbientDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sAmbientDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sAmbientFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sAmbientFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sDiffuseDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sDiffuseDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sDiffuseFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sDiffuseFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sBumpDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sBumpDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sNormalMapDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sNormalMapDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sBumpFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sBumpFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sTransparentDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sTransparentDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sTransparencyFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sTransparencyFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sDisplacementDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sDisplacementDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sDisplacementFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sDisplacementFactorDefault_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_FbxVectorTemplate3T_double_t sVectorDisplacementDefault {
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSurfaceLambert_sVectorDisplacementDefault_get();
      SWIGTYPE_p_FbxVectorTemplate3T_double_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxVectorTemplate3T_double_t(cPtr, false);
      return ret;
    } 
  }

  public static double sVectorDisplacementFactorDefault {
    get {
      double ret = examplePINVOKE.FbxSurfaceLambert_sVectorDisplacementFactorDefault_get();
      return ret;
    } 
  }

}

}
