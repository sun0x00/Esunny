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

public class TapAPIHisMatchQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIHisMatchQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIHisMatchQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIHisMatchQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPIHisMatchQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string SettleDate {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_SettleDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_SettleDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double MatchPrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchQty {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchStreamID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchCmbNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchCmbNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchCmbNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeMatchNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ExchangeMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ExchangeMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchUpperStreamID {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchUpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchUpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountFeeCurrencyGroup {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountFeeCurrency {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountFeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char IsManualFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_IsManualFee_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_IsManualFee_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountOtherFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountOtherFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_AccountOtherFee_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFee_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperFeeCurrencyGroup {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperFeeCurrency {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperFeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char IsUpperManualFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_IsUpperManualFee_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_IsUpperManualFee_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperOtherFee {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperOtherFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperOtherFee_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchDateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_MatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperMatchDateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperMatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_UpperMatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint CloseQty {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CloseQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_CloseQty_get(swigCPtr);
      return ret;
    } 
  }

  public string SettleGroupNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_SettleGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_SettleGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OperatorNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OperatorNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OperatorNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OperateTime {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OperateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPIHisMatchQryRsp_OperateTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIHisMatchQryRsp() : this(TapTradeWrapperAPIPINVOKE.new_TapAPIHisMatchQryRsp(), true) {
  }

}

}