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
    /// 交易或风控消息查询请求结构
    /// </summary>
    public class TapAPITradeMessageReq : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPITradeMessageReq(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeMessageReq obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPITradeMessageReq()
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
                        TapTradeWrapperPINVOKE.delete_TapAPITradeMessageReq(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 客户资金帐号
        /// </summary>
        public string AccountNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradeMessageReq_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradeMessageReq_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 账号属性编码
        /// </summary>
        public string AccountAttributeNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradeMessageReq_AccountAttributeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradeMessageReq_AccountAttributeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 开始发送时间
        /// </summary>
        public string BenginSendDateTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradeMessageReq_BenginSendDateTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradeMessageReq_BenginSendDateTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 结束发送时间
        /// </summary>
        public string EndSendDateTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPITradeMessageReq_EndSendDateTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPITradeMessageReq_EndSendDateTime_get(swigCPtr);
                return ret;
            }
        }

        public TapAPITradeMessageReq() : this(TapTradeWrapperPINVOKE.new_TapAPITradeMessageReq(), true)
        {
        }

    }

}
