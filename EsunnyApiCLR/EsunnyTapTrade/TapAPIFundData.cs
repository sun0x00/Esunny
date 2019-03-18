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

public class TapAPIFundData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFundData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFundData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIFundData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIFundData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIFundData_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIFundData_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIFundData_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeRate {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_TradeRate_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_TradeRate_get(swigCPtr);
      return ret;
    } 
  }

  public char FutureAlg {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_FutureAlg_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIFundData_FutureAlg_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionAlg {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_OptionAlg_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIFundData_OptionAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreUnExpProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreUnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreUnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreLMEPositionProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreLMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreLMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreEquity {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double PreAvailable1 {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreAvailable1_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreAvailable1_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMarketEquity {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PreMarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PreMarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double CashInValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CashInValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CashInValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashOutValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CashOutValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CashOutValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashAdjustValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CashAdjustValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CashAdjustValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashPledged {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CashPledged_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CashPledged_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenFee {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_FrozenFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_FrozenFee_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenDeposit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_FrozenDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_FrozenDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFee {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_AccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_AccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public double SwapInValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_SwapInValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_SwapInValue_get(swigCPtr);
      return ret;
    } 
  }

  public double SwapOutValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_SwapOutValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_SwapOutValue_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenFund {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_FrozenFund_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_FrozenFund_get(swigCPtr);
      return ret;
    } 
  }

  public double UnExpProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_UnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_UnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double ExpProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_ExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_ExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LmePositionProfit {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_LmePositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_LmePositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountIntialMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_AccountIntialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_AccountIntialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitalMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_UpperInitalMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_UpperInitalMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Discount {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_Discount_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_Discount_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Equity {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_Equity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_Equity_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_Available_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double CanDraw {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_CanDraw_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_CanDraw_get(swigCPtr);
      return ret;
    } 
  }

  public double MarketEquity {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_MarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_MarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double AuthMoney {
    set {
      TapTradeWrapperPINVOKE.TapAPIFundData_AuthMoney_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIFundData_AuthMoney_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFundData() : this(TapTradeWrapperPINVOKE.new_TapAPIFundData(), true) {
  }

}

}
