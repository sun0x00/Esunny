//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapQuoteWrapperApi {

public class ITapQuoteAPI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ITapQuoteAPI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapQuoteAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ITapQuoteAPI() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapQuoteApiPINVOKE.delete_ITapQuoteAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual int SetAPINotify(ITapQuoteAPINotify apiNotify) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetAPINotify(swigCPtr, ITapQuoteAPINotify.getCPtr(apiNotify));
    return ret;
  }

  public virtual int SetHostAddress(string IP, ushort port) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetHostAddress(swigCPtr, IP, port);
    return ret;
  }

  public virtual int Login(TapAPIQuoteLoginAuth loginAuth) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Login(swigCPtr, TapAPIQuoteLoginAuth.getCPtr(loginAuth));
    return ret;
  }

  public virtual int Disconnect() {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Disconnect(swigCPtr);
    return ret;
  }

  public virtual int QryCommodity(out uint sessionID) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryCommodity(swigCPtr, out sessionID);
    return ret;
  }

  public virtual int QryContract(out uint sessionID, TapAPICommodity qryReq) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryContract(swigCPtr, out sessionID, TapAPICommodity.getCPtr(qryReq));
    return ret;
  }

  public virtual int SubscribeQuote(out uint sessionID, TapAPIContract contract) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
    return ret;
  }

  public virtual int UnSubscribeQuote(out uint sessionID, TapAPIContract contract) {
    int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_UnSubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
    return ret;
  }

}

}
