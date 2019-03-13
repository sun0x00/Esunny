//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapQuoteWrapperApi
{
    /// <summary>
    /// TapQuoteAPI 对外功能接口。包含了用户可以调用的功能函数。
    /// </summary>
    public class ITapQuoteAPI : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ITapQuoteAPI(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapQuoteAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~ITapQuoteAPI()
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
                        QTapQuoteApiPINVOKE.delete_ITapQuoteAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// 设置API的回调接口对象。
        /// 系统对API的通知将通过设置的回调对象通知给使用者。ITapQuoteAPINofify是API的回调接口，
        /// 用户需要继承实现此接口类对象来完成用户需要的功能。
        /// 如果用户没有设置回调接口，则API不会向用户返回任何有用的信息。
        /// 同步操作
        /// </summary>
        /// <param name="apiNotify">实现了ITapQuoteAPINotify接口的对象</param>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int SetAPINotify(ITapQuoteAPINotify apiNotify)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetAPINotify(swigCPtr, ITapQuoteAPINotify.getCPtr(apiNotify));
            return ret;
        }

        /// <summary>
        /// 设置服务器的IP地址和端口。等到调用Login时真正发起连接。同步操作
        /// </summary>
        /// <param name="IP">IP地址</param>
        /// <param name="port">端口号</param>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int SetHostAddress(string IP, ushort port)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetHostAddress(swigCPtr, IP, port);
            return ret;
        }

        /// <summary>
        /// 发起登录请求。API将先连接服务，建立链路，发起登录认证。
        /// 在使用函数函数前用户需要完成服务器的设置SetHostAddress()，并且创建TapAPIQuoteLoginAuth类型的用户信息，
        /// 并且需要设置好回调接口。
        /// 连接建立后的用户验证回馈信息通过回调OnLogin()返回给用户。
        /// 登录成功后API会自动进行API的初始化，API向服务器请求基础数据，查询完以后会通过回调OnAPIReady()
        /// 指示用户API初始化完成，可以进行后续的操作了。
        /// 异步操作
        /// </summary>
        /// <param name="loginAuth">登录验证信息。包含登录需要的验证信息。</param>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int Login(TapAPIQuoteLoginAuth loginAuth)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Login(swigCPtr, TapAPIQuoteLoginAuth.getCPtr(loginAuth));
            return ret;
        }

        /// <summary>
        /// 断开和服务器的链路连接。
        /// 调用函数后API将登出并断开与服务器的连接。
        /// 异步操作
        /// </summary>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int Disconnect()
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Disconnect(swigCPtr);
            return ret;
        }

        /// <summary>
        /// 得到所有品种，异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID。</param>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int QryCommodity(out uint sessionID)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryCommodity(swigCPtr, out sessionID);
            return ret;
        }

        /// <summary>
        /// 查询系统中指定品种的合约信息
        /// 使用此函数前需要先QryCommodity()取得品种信息，然后选择需要的品种将信息填入TapAPICommodity结构体中完成查询请求。
        /// 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID;</param>
        /// <param name="qryReq">查询系统中指定品种的合约信息请求的结构体，该参数各字段为可选字段，可以用以下方法查询：1.全部留空：查所有合约；
        /// 2.仅交易所编码有效：查该交易所下所有品种的合约；
        /// 3.交易所编码和品种类型有效：查该交易所下指定品种类型的合约；
        /// 4.交易所编码、品种类型和品种编码都有效：查该品种下的所有合约
        /// </param>
        /// <returns>0 请求成功；非0 错误码</returns>
        public virtual int QryContract(out uint sessionID, TapAPICommodity qryReq)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryContract(swigCPtr, out sessionID, TapAPICommodity.getCPtr(qryReq));
            return ret;
        }

        /// <summary>
        /// 订阅指定合约的行情
        /// 函数向服务器请求contract描述的合约的行情信息，行情订阅成功后服务器将持续向用户推送行情信息，
        /// 直到用户退订行情信息或者断开于服务器的通信。调用此函数前先获取合约信息，然后从合约信息中取出合约填入contract。
        /// 异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID。</param>
        /// <param name="contract">指定合约</param>
        /// <returns> 0 请求成功 非0 错误码</returns>
        public virtual int SubscribeQuote(out uint sessionID, TapAPIContract contract)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
            return ret;
        }

        /// <summary>
        /// 退订指定合约的行情，退订已经订阅的行情信息。异步操作
        /// </summary>
        /// <param name="sessionID">返回请求的会话ID</param>
        /// <param name="contract">指定合约</param>
        /// <returns>0 请求成功 非0 错误码</returns>
        public virtual int UnSubscribeQuote(out uint sessionID, TapAPIContract contract)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_UnSubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
            return ret;
        }

    }

}
