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
    /// 委托查询请求结构
    /// </summary>
    public class TapAPIOrderQryReq : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIOrderQryReq(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderQryReq obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIOrderQryReq()
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
                        TapTradeWrapperPINVOKE.delete_TapAPIOrderQryReq(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// 资金账号
        /// </summary>
        public string AccountNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 交易所编号
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种类型
        /// </summary>
        public char CommodityType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 品种编码类型
        /// </summary>
        public string CommodityNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_CommodityNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托类型
        /// </summary>
        public char OrderType
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderType_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托来源
        /// </summary>
        public char OrderSource
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderSource_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderSource_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托有效类型
        /// </summary>
        public char TimeInForce
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_TimeInForce_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_TimeInForce_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 有效日期(GTD情况下使用)
        /// </summary>
        public string ExpireTime
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ExpireTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ExpireTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否风险报单
        /// </summary>
        public char IsRiskOrder
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsRiskOrder_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsRiskOrder_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 服务器标识
        /// </summary>
        public char ServerFlag
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ServerFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_ServerFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托编号
        /// </summary>
        public string OrderNo
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_OrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否为录入委托单
        /// </summary>
        public char IsBackInput
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsBackInput_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsBackInput_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 委托成交删除标
        /// </summary>
        public char IsDeleted
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsDeleted_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsDeleted_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// 是否为T+1单
        /// </summary>
        public char IsAddOne
        {
            set
            {
                TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsAddOne_set(swigCPtr, value);
            }
            get
            {
                char ret = TapTradeWrapperPINVOKE.TapAPIOrderQryReq_IsAddOne_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIOrderQryReq() : this(TapTradeWrapperPINVOKE.new_TapAPIOrderQryReq(), true)
        {
        }

    }

}
