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

public class FbxRenamingStrategy : FbxRenamingStrategyInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxRenamingStrategy(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxRenamingStrategy_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRenamingStrategy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxRenamingStrategy() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxRenamingStrategy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxRenamingStrategy(FbxRenamingStrategy.EDirection pMod, bool pOnCreationRun) : this(examplePINVOKE.new_FbxRenamingStrategy__SWIG_0((int)pMod, pOnCreationRun), true) {
  }

  public FbxRenamingStrategy(FbxRenamingStrategy.EDirection pMod) : this(examplePINVOKE.new_FbxRenamingStrategy__SWIG_1((int)pMod), true) {
  }

  public override bool Rename(FbxNameHandler pName) {
    bool ret = examplePINVOKE.FbxRenamingStrategy_Rename(swigCPtr, FbxNameHandler.getCPtr(pName));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Clear() {
    examplePINVOKE.FbxRenamingStrategy_Clear(swigCPtr);
  }

  public override FbxRenamingStrategyInterface Clone() {
    global::System.IntPtr cPtr = examplePINVOKE.FbxRenamingStrategy_Clone(swigCPtr);
    FbxRenamingStrategyInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxRenamingStrategyInterface(cPtr, false);
    return ret;
  }

  public void SetClashSoverType(FbxRenamingStrategy.EClashType pType) {
    examplePINVOKE.FbxRenamingStrategy_SetClashSoverType(swigCPtr, (int)pType);
  }

  public static string NoPrefixName(string pName) {
    string ret = examplePINVOKE.FbxRenamingStrategy_NoPrefixName__SWIG_0(pName);
    return ret;
  }

  public static string NoPrefixName(FbxString pName) {
    string ret = examplePINVOKE.FbxRenamingStrategy_NoPrefixName__SWIG_1(FbxString.getCPtr(pName));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string GetNameSpace() {
    string ret = examplePINVOKE.FbxRenamingStrategy_GetNameSpace(swigCPtr);
    return ret;
  }

  public virtual void SetInNameSpaceSymbol(FbxString pNameSpaceSymbol) {
    examplePINVOKE.FbxRenamingStrategy_SetInNameSpaceSymbol(swigCPtr, FbxString.getCPtr(pNameSpaceSymbol));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetOutNameSpaceSymbol(FbxString pNameSpaceSymbol) {
    examplePINVOKE.FbxRenamingStrategy_SetOutNameSpaceSymbol(swigCPtr, FbxString.getCPtr(pNameSpaceSymbol));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetCaseSensibility(bool pIsCaseSensitive) {
    examplePINVOKE.FbxRenamingStrategy_SetCaseSensibility(swigCPtr, pIsCaseSensitive);
  }

  public virtual void SetReplaceNonAlphaNum(bool pReplaceNonAlphaNum) {
    examplePINVOKE.FbxRenamingStrategy_SetReplaceNonAlphaNum(swigCPtr, pReplaceNonAlphaNum);
  }

  public virtual void SetFirstNotNum(bool pFirstNotNum) {
    examplePINVOKE.FbxRenamingStrategy_SetFirstNotNum(swigCPtr, pFirstNotNum);
  }

  public virtual bool RenameUnparentNameSpace(FbxNode pNode, bool pIsRoot) {
    bool ret = examplePINVOKE.FbxRenamingStrategy_RenameUnparentNameSpace__SWIG_0(swigCPtr, FbxNode.getCPtr(pNode), pIsRoot);
    return ret;
  }

  public virtual bool RenameUnparentNameSpace(FbxNode pNode) {
    bool ret = examplePINVOKE.FbxRenamingStrategy_RenameUnparentNameSpace__SWIG_1(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public virtual bool RemoveImportNameSpaceClash(FbxNode pNode) {
    bool ret = examplePINVOKE.FbxRenamingStrategy_RemoveImportNameSpaceClash(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public virtual void GetParentsNameSpaceList(FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxString_p_t pNameSpaceList) {
    examplePINVOKE.FbxRenamingStrategy_GetParentsNameSpaceList(swigCPtr, FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxString_p_t.getCPtr(pNameSpaceList));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool PropagateNameSpaceChange(FbxNode pNode, FbxString OldNS, FbxString NewNS) {
    bool ret = examplePINVOKE.FbxRenamingStrategy_PropagateNameSpaceChange(swigCPtr, FbxNode.getCPtr(pNode), FbxString.getCPtr(OldNS), FbxString.getCPtr(NewNS));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EDirection {
    eToFBX,
    eFromFBX
  }

  public enum EClashType {
    eNameClashAuto,
    eNameClashType1,
    eNameClashType2
  }

}

}
