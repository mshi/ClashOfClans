/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class FT_ConnectProcessResultHandler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FT_ConnectProcessResultHandler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FT_ConnectProcessResultHandler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FT_ConnectProcessResultHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FT_ConnectProcessResultHandler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public FT_ConnectProcessResultHandler() : this(RakNetPINVOKE.new_FT_ConnectProcessResultHandler(), true) {
    SwigDirectorConnect();
  }

  public virtual void OnConnectedToServer() {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_OnConnectedToServer(swigCPtr);
  }

  public virtual void OnFailedToConnect() {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_OnFailedToConnect(swigCPtr);
  }

  public virtual void OnLostConnection() {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_OnLostConnection(swigCPtr);
  }

  public virtual void OnDisconnectedFromServer() {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_OnDisconnectedFromServer(swigCPtr);
  }

  public virtual void DebugReceive(int flag) {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_DebugReceive(swigCPtr, flag);
  }

  public virtual void ReceiveLog() {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_ReceiveLog__SWIG_0(swigCPtr);
  }

  public virtual void ReceiveLog(string str) {
    RakNetPINVOKE.FT_ConnectProcessResultHandler_ReceiveLog__SWIG_1(swigCPtr, str);
  }

  public virtual PluginReceiveResult OnRead(BitStream bsIn) {
    PluginReceiveResult ret = (PluginReceiveResult)RakNetPINVOKE.FT_ConnectProcessResultHandler_OnRead(swigCPtr, BitStream.getCPtr(bsIn));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnConnectedToServer", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateFT_ConnectProcessResultHandler_0(SwigDirectorOnConnectedToServer);
    if (SwigDerivedClassHasMethod("OnFailedToConnect", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateFT_ConnectProcessResultHandler_1(SwigDirectorOnFailedToConnect);
    if (SwigDerivedClassHasMethod("OnLostConnection", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateFT_ConnectProcessResultHandler_2(SwigDirectorOnLostConnection);
    if (SwigDerivedClassHasMethod("OnDisconnectedFromServer", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateFT_ConnectProcessResultHandler_3(SwigDirectorOnDisconnectedFromServer);
    if (SwigDerivedClassHasMethod("DebugReceive", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateFT_ConnectProcessResultHandler_4(SwigDirectorDebugReceive);
    if (SwigDerivedClassHasMethod("ReceiveLog", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateFT_ConnectProcessResultHandler_5(SwigDirectorReceiveLog__SWIG_0);
    if (SwigDerivedClassHasMethod("ReceiveLog", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateFT_ConnectProcessResultHandler_6(SwigDirectorReceiveLog__SWIG_1);
    if (SwigDerivedClassHasMethod("OnRead", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateFT_ConnectProcessResultHandler_7(SwigDirectorOnRead);
    RakNetPINVOKE.FT_ConnectProcessResultHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(FT_ConnectProcessResultHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnConnectedToServer() {
    OnConnectedToServer();
  }

  private void SwigDirectorOnFailedToConnect() {
    OnFailedToConnect();
  }

  private void SwigDirectorOnLostConnection() {
    OnLostConnection();
  }

  private void SwigDirectorOnDisconnectedFromServer() {
    OnDisconnectedFromServer();
  }

  private void SwigDirectorDebugReceive(int flag) {
    DebugReceive(flag);
  }

  private void SwigDirectorReceiveLog__SWIG_0() {
    ReceiveLog();
  }

  private void SwigDirectorReceiveLog__SWIG_1(string str) {
    ReceiveLog(str);
  }

  private int SwigDirectorOnRead(IntPtr bsIn) {
    return (int)OnRead((bsIn == IntPtr.Zero) ? null : new BitStream(bsIn, false));
  }

  public delegate void SwigDelegateFT_ConnectProcessResultHandler_0();
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_1();
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_2();
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_3();
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_4(int flag);
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_5();
  public delegate void SwigDelegateFT_ConnectProcessResultHandler_6(string str);
  public delegate int SwigDelegateFT_ConnectProcessResultHandler_7(IntPtr bsIn);

  private SwigDelegateFT_ConnectProcessResultHandler_0 swigDelegate0;
  private SwigDelegateFT_ConnectProcessResultHandler_1 swigDelegate1;
  private SwigDelegateFT_ConnectProcessResultHandler_2 swigDelegate2;
  private SwigDelegateFT_ConnectProcessResultHandler_3 swigDelegate3;
  private SwigDelegateFT_ConnectProcessResultHandler_4 swigDelegate4;
  private SwigDelegateFT_ConnectProcessResultHandler_5 swigDelegate5;
  private SwigDelegateFT_ConnectProcessResultHandler_6 swigDelegate6;
  private SwigDelegateFT_ConnectProcessResultHandler_7 swigDelegate7;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes5 = new Type[] {  };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(BitStream) };
}

}
