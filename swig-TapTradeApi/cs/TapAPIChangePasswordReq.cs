//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi {

public class TapAPIChangePasswordReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIChangePasswordReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIChangePasswordReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIChangePasswordReq() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIChangePasswordReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char PasswordType {
    set {
      TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_PasswordType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_PasswordType_get(swigCPtr);
      return ret;
    } 
  }

  public string OldPassword {
    set {
      TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_OldPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_OldPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIChangePasswordReq_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIChangePasswordReq() : this(TapTradeWrapperPINVOKE.new_TapAPIChangePasswordReq(), true) {
  }

}

}
