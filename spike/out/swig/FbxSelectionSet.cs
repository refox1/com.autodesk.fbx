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

public class FbxSelectionSet : FbxCollection {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSelectionSet(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxSelectionSet_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSelectionSet obj) {
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
      examplePINVOKE.FbxSelectionSet_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSelectionSet_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxSelectionSet_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSelectionSet Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSelectionSet_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSelectionSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSelectionSet(cPtr, false);
    return ret;
  }

  public new static FbxSelectionSet Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxSelectionSet_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSelectionSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSelectionSet(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t SelectionSetAnnotation {
    set {
      examplePINVOKE.FbxSelectionSet_SelectionSetAnnotation_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxSelectionSet_SelectionSetAnnotation_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public void GetFaceSelection(FbxObject pObj, SWIGTYPE_p_FbxArrayT_int_t pPolygonIndexArray) {
    examplePINVOKE.FbxSelectionSet_GetFaceSelection(swigCPtr, FbxObject.getCPtr(pObj), SWIGTYPE_p_FbxArrayT_int_t.getCPtr(pPolygonIndexArray));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetEdgeSelection(FbxObject pObj, SWIGTYPE_p_FbxArrayT_int_t pEdgeIndexArray) {
    examplePINVOKE.FbxSelectionSet_GetEdgeSelection(swigCPtr, FbxObject.getCPtr(pObj), SWIGTYPE_p_FbxArrayT_int_t.getCPtr(pEdgeIndexArray));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetVertexSelection(FbxObject pObj, SWIGTYPE_p_FbxArrayT_int_t pVertexIndexArray) {
    examplePINVOKE.FbxSelectionSet_GetVertexSelection(swigCPtr, FbxObject.getCPtr(pObj), SWIGTYPE_p_FbxArrayT_int_t.getCPtr(pVertexIndexArray));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSelectionNodesAndDirectObjects(SWIGTYPE_p_FbxArrayT_FbxSelectionNode_p_t pSelectionNodeList, SWIGTYPE_p_FbxArrayT_FbxObject_p_t pDirectObjectList) {
    examplePINVOKE.FbxSelectionSet_GetSelectionNodesAndDirectObjects(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxSelectionNode_p_t.getCPtr(pSelectionNodeList), SWIGTYPE_p_FbxArrayT_FbxObject_p_t.getCPtr(pDirectObjectList));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
