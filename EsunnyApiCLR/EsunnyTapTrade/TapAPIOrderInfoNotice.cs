//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi
{
    /// <summary>
    /// 报单通知结构
    /// </summary>
    public class TapAPIOrderInfoNotice : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIOrderInfoNotice(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderInfoNotice obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIOrderInfoNotice()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        TapTradeWrapperPINVOKE.delete_TapAPIOrderInfoNotice(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 会话ID
        /// </summary>
        public uint SessionID
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_SessionID_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_SessionID_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 错误码
        /// </summary>
        public uint ErrorCode
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_ErrorCode_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_ErrorCode_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托完整信息
        /// </summary>
        public TapAPIOrderInfo OrderInfo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_OrderInfo_set(swigCPtr, TapAPIOrderInfo.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = TapTradeWrapperPINVOKE.TapAPIOrderInfoNotice_OrderInfo_get(swigCPtr);
                TapAPIOrderInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderInfo(cPtr, false);
                return ret;
            }
        }

        public TapAPIOrderInfoNotice() : this(TapTradeWrapperPINVOKE.new_TapAPIOrderInfoNotice(), true)
        {
        }

    }

}
