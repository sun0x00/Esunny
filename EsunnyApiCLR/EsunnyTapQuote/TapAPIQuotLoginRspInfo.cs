//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteWrapperApi
{
    /// <summary>
    /// ��¼������Ϣ
    /// </summary>
    public class TapAPIQuotLoginRspInfo : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal TapAPIQuotLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuotLoginRspInfo obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~TapAPIQuotLoginRspInfo()
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
                        TapQuoteWrapperPINVOKE.delete_TapAPIQuotLoginRspInfo(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }
        /// <summary>
        /// �û���
        /// </summary>
        public string UserNo
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserNo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserNo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public int UserType
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserType_set(swigCPtr, value);
            }
            get
            {
                int ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserType_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ǳƣ�GBK�����ʽ
        /// </summary>
        public string UserName
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserName_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_UserName_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ������ʱ����
        /// </summary>
        public string QuoteTempPassword
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �û��Լ����õ�Ԥ����Ϣ
        /// </summary>
        public string ReservedInfo
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϴε�¼�ĵ�ַ
        /// </summary>
        public string LastLoginIP
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϴε�¼ʹ�õĶ˿�
        /// </summary>
        public uint LastLoginProt
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_set(swigCPtr, value);
            }
            get
            {
                uint ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϴε�¼��ʱ��
        /// </summary>
        public string LastLoginTime
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϴ��˳���ʱ��
        /// </summary>
        public string LastLogoutTime
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ��ǰ��������
        /// </summary>
        public string TradeDate
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_TradeDate_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_TradeDate_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// �ϴν���ʱ��
        /// </summary>
        public string LastSettleTime
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ϵͳ����ʱ��
        /// </summary>
        public string StartTime
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_StartTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_StartTime_get(swigCPtr);
                return ret;
            }
        }
        /// <summary>
        /// ϵͳ��ʼ��ʱ��
        /// </summary>
        public string InitTime
        {
            set
            {
                TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_InitTime_set(swigCPtr, value);
            }
            get
            {
                string ret = TapQuoteWrapperPINVOKE.TapAPIQuotLoginRspInfo_InitTime_get(swigCPtr);
                return ret;
            }
        }

        public TapAPIQuotLoginRspInfo() : this(TapQuoteWrapperPINVOKE.new_TapAPIQuotLoginRspInfo(), true)
        {
        }

    }

}