//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapTradeWrapperApi
{
    /// <summary>
    /// ƽ����Ϣ
    /// </summary>
    public class TapAPICloseInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPICloseInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICloseInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPICloseInfo()
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
                        QTapTradeApiPINVOKE.delete_TapAPICloseInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// �ͻ��ʽ��ʺ�
        /// </summary>
        public string AccountNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_AccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_AccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϼ��ʽ��˺�
        /// </summary>
        public string ParentAccountNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ParentAccountNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ParentAccountNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string ExchangeNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ������
        /// </summary>
        public char CommodityType
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ�������
        /// </summary>
        public string CommodityNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��Լ
        /// </summary>
        public string ContractNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ContractNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ContractNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ִ�м۸�
        /// </summary>
        public string StrikePrice
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_StrikePrice_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_StrikePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ſ���
        /// </summary>
        public char CallOrPutFlag
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CallOrPutFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CallOrPutFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string OpenOrderExchangeNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ������
        /// </summary>
        public char OpenOrderCommodityType
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderCommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderCommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ�������
        /// </summary>
        public string OpenOrderCommodityNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderCommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderCommodityNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string CloseOrderExchangeNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderExchangeNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderExchangeNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ������
        /// </summary>
        public char CloseOrderCommodityType
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderCommodityType_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderCommodityType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ�������
        /// </summary>
        public string CloseOrderCommodityNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderCommodityNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderCommodityNo_get(swigCPtr);
                return ret;
            }
        }

        public char OpenMatchSource
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchSource_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchSource_get(swigCPtr);
                return ret;
            }
        }

        public char CloseMatchSource
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchSource_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchSource_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ƽ��һ�ߵ���������
        /// </summary>
        public char CloseSide
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseSide_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseSide_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ƽ�ֳɽ���
        /// </summary>
        public uint CloseQty
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseQty_set(swigCPtr, value);
            }
            get
            {
                uint ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseQty_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ֳɽ���
        /// </summary>
        public double OpenPrice
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenPrice_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenPrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ƽ�ֳɽ���
        /// </summary>
        public double ClosePrice
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ClosePrice_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ClosePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��������ʶ
        /// </summary>
        public char OpenServerFlag
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenServerFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenServerFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί�б���
        /// </summary>
        public string OpenOrderNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenOrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���سɽ���
        /// </summary>
        public string OpenMatchNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �������ɽ���
        /// </summary>
        public string OpenExchangeMatchNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenExchangeMatchNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenExchangeMatchNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ɽ�ʱ��
        /// </summary>
        public string OpenMatchDateTime
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchDateTime_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenMatchDateTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��������ʶ
        /// </summary>
        public char CloseServerFlag
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseServerFlag_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseServerFlag_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ί�б���
        /// </summary>
        public string CloseOrderNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseOrderNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���سɽ���
        /// </summary>
        public string CloseMatchNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �������ɽ���
        /// </summary>
        public string CloseExchangeMatchNo
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseExchangeMatchNo_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseExchangeMatchNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ɽ�ʱ��
        /// </summary>
        public string CloseMatchDateTime
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchDateTime_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseMatchDateTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ƽ������
        /// </summary>
        public uint CloseStreamId
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseStreamId_set(swigCPtr, value);
            }
            get
            {
                uint ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseStreamId_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ƽ��ʽ
        /// </summary>
        public char OpenCloseMode
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_OpenCloseMode_set(swigCPtr, value);
            }
            get
            {
                char ret = QTapTradeApiPINVOKE.TapAPICloseInfo_OpenCloseMode_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ÿ�ֳ������������
        /// </summary>
        public double ContractSize
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ContractSize_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ContractSize_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ʒ�ֱ�����
        /// </summary>
        public string CommodityCurrencyGroup
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityCurrencyGroup_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityCurrencyGroup_get(swigCPtr);
                return ret;
            }
        }

        /// <summary>
        /// Ʒ�ֱ���
        /// </summary>
        public string CommodityCurrency
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityCurrency_set(swigCPtr, value);
            }
            get
            {
                string ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CommodityCurrency_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������
        /// </summary>
        public double PreSettlePrice
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_PreSettlePrice_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_PreSettlePrice_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ȩ������ȡ
        /// </summary>
        public double PremiumIncome
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_PremiumIncome_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_PremiumIncome_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// Ȩ����֧��
        /// </summary>
        public double PremiumPay
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_PremiumPay_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_PremiumPay_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ƽ��ӯ��
        /// </summary>
        public double CloseProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_CloseProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_CloseProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// δ����ƽӯ
        /// </summary>
        public double UnExpProfit
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_UnExpProfit_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_UnExpProfit_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ���ƽӯ
        /// </summary>
        public double ClosePL
        {
            set
            {
                QTapTradeApiPINVOKE.TapAPICloseInfo_ClosePL_set(swigCPtr, value);
            }
            get
            {
                double ret = QTapTradeApiPINVOKE.TapAPICloseInfo_ClosePL_get(swigCPtr);
                return ret;
            }
        }

        public TapAPICloseInfo() : this(QTapTradeApiPINVOKE.new_TapAPICloseInfo(), true)
        {
        }

    }

}