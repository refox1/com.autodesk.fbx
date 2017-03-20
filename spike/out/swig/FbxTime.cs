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

public class FbxTime : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTime(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTime obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTime() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_FbxTime(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTime(long pTime) : this(examplePINVOKE.new_FbxTime__SWIG_0(pTime), true) {
  }

  public FbxTime() : this(examplePINVOKE.new_FbxTime__SWIG_1(), true) {
  }

  public static void SetGlobalTimeMode(FbxTime.EMode pTimeMode, double pFrameRate) {
    examplePINVOKE.FbxTime_SetGlobalTimeMode__SWIG_0((int)pTimeMode, pFrameRate);
  }

  public static void SetGlobalTimeMode(FbxTime.EMode pTimeMode) {
    examplePINVOKE.FbxTime_SetGlobalTimeMode__SWIG_1((int)pTimeMode);
  }

  public static FbxTime.EMode GetGlobalTimeMode() {
    FbxTime.EMode ret = (FbxTime.EMode)examplePINVOKE.FbxTime_GetGlobalTimeMode();
    return ret;
  }

  public static void SetGlobalTimeProtocol(FbxTime.EProtocol pTimeProtocol) {
    examplePINVOKE.FbxTime_SetGlobalTimeProtocol((int)pTimeProtocol);
  }

  public static FbxTime.EProtocol GetGlobalTimeProtocol() {
    FbxTime.EProtocol ret = (FbxTime.EProtocol)examplePINVOKE.FbxTime_GetGlobalTimeProtocol();
    return ret;
  }

  public static double GetFrameRate(FbxTime.EMode pTimeMode) {
    double ret = examplePINVOKE.FbxTime_GetFrameRate((int)pTimeMode);
    return ret;
  }

  public static FbxTime.EMode ConvertFrameRateToTimeMode(double pFrameRate, double pPrecision) {
    FbxTime.EMode ret = (FbxTime.EMode)examplePINVOKE.FbxTime_ConvertFrameRateToTimeMode__SWIG_0(pFrameRate, pPrecision);
    return ret;
  }

  public static FbxTime.EMode ConvertFrameRateToTimeMode(double pFrameRate) {
    FbxTime.EMode ret = (FbxTime.EMode)examplePINVOKE.FbxTime_ConvertFrameRateToTimeMode__SWIG_1(pFrameRate);
    return ret;
  }

  public void Set(long pTime) {
    examplePINVOKE.FbxTime_Set(swigCPtr, pTime);
  }

  public long Get() {
    long ret = examplePINVOKE.FbxTime_Get(swigCPtr);
    return ret;
  }

  public void SetMilliSeconds(long pMilliSeconds) {
    examplePINVOKE.FbxTime_SetMilliSeconds(swigCPtr, pMilliSeconds);
  }

  public long GetMilliSeconds() {
    long ret = examplePINVOKE.FbxTime_GetMilliSeconds(swigCPtr);
    return ret;
  }

  public void SetSecondDouble(double pTime) {
    examplePINVOKE.FbxTime_SetSecondDouble(swigCPtr, pTime);
  }

  public double GetSecondDouble() {
    double ret = examplePINVOKE.FbxTime_GetSecondDouble(swigCPtr);
    return ret;
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField, FbxTime.EMode pTimeMode) {
    examplePINVOKE.FbxTime_SetTime__SWIG_0(swigCPtr, pHour, pMinute, pSecond, pFrame, pField, (int)pTimeMode);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField) {
    examplePINVOKE.FbxTime_SetTime__SWIG_1(swigCPtr, pHour, pMinute, pSecond, pFrame, pField);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame) {
    examplePINVOKE.FbxTime_SetTime__SWIG_2(swigCPtr, pHour, pMinute, pSecond, pFrame);
  }

  public void SetTime(int pHour, int pMinute, int pSecond) {
    examplePINVOKE.FbxTime_SetTime__SWIG_3(swigCPtr, pHour, pMinute, pSecond);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField, int pResidual, FbxTime.EMode pTimeMode) {
    examplePINVOKE.FbxTime_SetTime__SWIG_4(swigCPtr, pHour, pMinute, pSecond, pFrame, pField, pResidual, (int)pTimeMode);
  }

  public bool GetTime(SWIGTYPE_p_int pHour, SWIGTYPE_p_int pMinute, SWIGTYPE_p_int pSecond, SWIGTYPE_p_int pFrame, SWIGTYPE_p_int pField, SWIGTYPE_p_int pResidual, FbxTime.EMode pTimeMode) {
    bool ret = examplePINVOKE.FbxTime_GetTime__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(pHour), SWIGTYPE_p_int.getCPtr(pMinute), SWIGTYPE_p_int.getCPtr(pSecond), SWIGTYPE_p_int.getCPtr(pFrame), SWIGTYPE_p_int.getCPtr(pField), SWIGTYPE_p_int.getCPtr(pResidual), (int)pTimeMode);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTime(SWIGTYPE_p_int pHour, SWIGTYPE_p_int pMinute, SWIGTYPE_p_int pSecond, SWIGTYPE_p_int pFrame, SWIGTYPE_p_int pField, SWIGTYPE_p_int pResidual) {
    bool ret = examplePINVOKE.FbxTime_GetTime__SWIG_1(swigCPtr, SWIGTYPE_p_int.getCPtr(pHour), SWIGTYPE_p_int.getCPtr(pMinute), SWIGTYPE_p_int.getCPtr(pSecond), SWIGTYPE_p_int.getCPtr(pFrame), SWIGTYPE_p_int.getCPtr(pField), SWIGTYPE_p_int.getCPtr(pResidual));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime GetFramedTime(bool pRound) {
    FbxTime ret = new FbxTime(examplePINVOKE.FbxTime_GetFramedTime__SWIG_0(swigCPtr, pRound), true);
    return ret;
  }

  public FbxTime GetFramedTime() {
    FbxTime ret = new FbxTime(examplePINVOKE.FbxTime_GetFramedTime__SWIG_1(swigCPtr), true);
    return ret;
  }

  public void SetFrame(long pFrames, FbxTime.EMode pTimeMode) {
    examplePINVOKE.FbxTime_SetFrame__SWIG_0(swigCPtr, pFrames, (int)pTimeMode);
  }

  public void SetFrame(long pFrames) {
    examplePINVOKE.FbxTime_SetFrame__SWIG_1(swigCPtr, pFrames);
  }

  public void SetFramePrecise(double pFrames, FbxTime.EMode pTimeMode) {
    examplePINVOKE.FbxTime_SetFramePrecise__SWIG_0(swigCPtr, pFrames, (int)pTimeMode);
  }

  public void SetFramePrecise(double pFrames) {
    examplePINVOKE.FbxTime_SetFramePrecise__SWIG_1(swigCPtr, pFrames);
  }

  public int GetHourCount() {
    int ret = examplePINVOKE.FbxTime_GetHourCount(swigCPtr);
    return ret;
  }

  public int GetMinuteCount() {
    int ret = examplePINVOKE.FbxTime_GetMinuteCount(swigCPtr);
    return ret;
  }

  public int GetSecondCount() {
    int ret = examplePINVOKE.FbxTime_GetSecondCount(swigCPtr);
    return ret;
  }

  public long GetFrameCount(FbxTime.EMode pTimeMode) {
    long ret = examplePINVOKE.FbxTime_GetFrameCount__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public long GetFrameCount() {
    long ret = examplePINVOKE.FbxTime_GetFrameCount__SWIG_1(swigCPtr);
    return ret;
  }

  public double GetFrameCountPrecise(FbxTime.EMode pTimeMode) {
    double ret = examplePINVOKE.FbxTime_GetFrameCountPrecise__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public double GetFrameCountPrecise() {
    double ret = examplePINVOKE.FbxTime_GetFrameCountPrecise__SWIG_1(swigCPtr);
    return ret;
  }

  public long GetFieldCount(FbxTime.EMode pTimeMode) {
    long ret = examplePINVOKE.FbxTime_GetFieldCount__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public long GetFieldCount() {
    long ret = examplePINVOKE.FbxTime_GetFieldCount__SWIG_1(swigCPtr);
    return ret;
  }

  public int GetResidual(FbxTime.EMode pTimeMode) {
    int ret = examplePINVOKE.FbxTime_GetResidual__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public int GetResidual() {
    int ret = examplePINVOKE.FbxTime_GetResidual__SWIG_1(swigCPtr);
    return ret;
  }

  public static bool IsDropFrame(FbxTime.EMode pTimeMode) {
    bool ret = examplePINVOKE.FbxTime_IsDropFrame__SWIG_0((int)pTimeMode);
    return ret;
  }

  public static bool IsDropFrame() {
    bool ret = examplePINVOKE.FbxTime_IsDropFrame__SWIG_1();
    return ret;
  }

  public char GetFrameSeparator(FbxTime.EMode pTimeMode) {
    char ret = examplePINVOKE.FbxTime_GetFrameSeparator__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public char GetFrameSeparator() {
    char ret = examplePINVOKE.FbxTime_GetFrameSeparator__SWIG_1(swigCPtr);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    string ret = examplePINVOKE.FbxTime_GetTimeString__SWIG_0(swigCPtr, pTimeString, pTimeStringSize, pInfo, (int)pTimeMode, (int)pTimeFormat);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo, FbxTime.EMode pTimeMode) {
    string ret = examplePINVOKE.FbxTime_GetTimeString__SWIG_1(swigCPtr, pTimeString, pTimeStringSize, pInfo, (int)pTimeMode);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo) {
    string ret = examplePINVOKE.FbxTime_GetTimeString__SWIG_2(swigCPtr, pTimeString, pTimeStringSize, pInfo);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize) {
    string ret = examplePINVOKE.FbxTime_GetTimeString__SWIG_3(swigCPtr, pTimeString, pTimeStringSize);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    FbxString ret = new FbxString(examplePINVOKE.FbxTime_GetTimeString__SWIG_4(swigCPtr, (int)pStart, (int)pEnd, (int)pTimeMode, (int)pTimeFormat), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd, FbxTime.EMode pTimeMode) {
    FbxString ret = new FbxString(examplePINVOKE.FbxTime_GetTimeString__SWIG_5(swigCPtr, (int)pStart, (int)pEnd, (int)pTimeMode), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd) {
    FbxString ret = new FbxString(examplePINVOKE.FbxTime_GetTimeString__SWIG_6(swigCPtr, (int)pStart, (int)pEnd), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart) {
    FbxString ret = new FbxString(examplePINVOKE.FbxTime_GetTimeString__SWIG_7(swigCPtr, (int)pStart), true);
    return ret;
  }

  public FbxString GetTimeString() {
    FbxString ret = new FbxString(examplePINVOKE.FbxTime_GetTimeString__SWIG_8(swigCPtr), true);
    return ret;
  }

  public bool SetTimeString(string pTime, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    bool ret = examplePINVOKE.FbxTime_SetTimeString__SWIG_0(swigCPtr, pTime, (int)pTimeMode, (int)pTimeFormat);
    return ret;
  }

  public bool SetTimeString(string pTime, FbxTime.EMode pTimeMode) {
    bool ret = examplePINVOKE.FbxTime_SetTimeString__SWIG_1(swigCPtr, pTime, (int)pTimeMode);
    return ret;
  }

  public bool SetTimeString(string pTime) {
    bool ret = examplePINVOKE.FbxTime_SetTimeString__SWIG_2(swigCPtr, pTime);
    return ret;
  }

  public static long GetOneFrameValue(FbxTime.EMode pTimeMode) {
    long ret = examplePINVOKE.FbxTime_GetOneFrameValue__SWIG_0((int)pTimeMode);
    return ret;
  }

  public static long GetOneFrameValue() {
    long ret = examplePINVOKE.FbxTime_GetOneFrameValue__SWIG_1();
    return ret;
  }

  public enum EMode {
    eDefaultMode,
    eFrames120,
    eFrames100,
    eFrames60,
    eFrames50,
    eFrames48,
    eFrames30,
    eFrames30Drop,
    eNTSCDropFrame,
    eNTSCFullFrame,
    ePAL,
    eFrames24,
    eFrames1000,
    eFilmFullFrame,
    eCustom,
    eFrames96,
    eFrames72,
    eFrames59dot94,
    eModesCount
  }

  public enum EProtocol {
    eSMPTE,
    eFrameCount,
    eDefaultProtocol
  }

  public enum EElement {
    eHours,
    eMinutes,
    eSeconds,
    eFrames,
    eField,
    eResidual
  }

  public enum EOldMode {
    eOLD_DEFAULT_MODE,
    eOLD_CINEMA,
    eOLD_PAL,
    eOLD_FRAMES30,
    eOLD_NTSC_DROP_FRAME,
    eOLD_FRAMES50,
    eOLD_FRAMES60,
    eOLD_FRAMES100,
    eOLD_FRAMES120,
    eOLD_NTSC_FULL_FRAME,
    eOLD_FRAMES30_DROP,
    eOLD_FRAMES1000
  }

}

}
