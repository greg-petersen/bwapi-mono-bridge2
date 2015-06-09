//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SWIG.BWAPI {

public partial class AIModule : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AIModule(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AIModule obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AIModule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_AIModule(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is AIModule)
      equal = (((AIModule)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(AIModule obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(AIModule obj1, AIModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(AIModule obj1, AIModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public AIModule() : this(bwapiPINVOKE.new_AIModule(), true) {
  }

  public virtual void onStart() {
    bwapiPINVOKE.AIModule_onStart(swigCPtr);
  }

  public virtual void onEnd(bool isWinner) {
    bwapiPINVOKE.AIModule_onEnd(swigCPtr, isWinner);
  }

  public virtual void onFrame() {
    bwapiPINVOKE.AIModule_onFrame(swigCPtr);
  }

  public virtual void onSendText(string text) {
    bwapiPINVOKE.AIModule_onSendText(swigCPtr, text);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onReceiveText(Player player, string text) {
    bwapiPINVOKE.AIModule_onReceiveText(swigCPtr, Player.getCPtr(player), text);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onPlayerLeft(Player player) {
    bwapiPINVOKE.AIModule_onPlayerLeft(swigCPtr, Player.getCPtr(player));
  }

  public virtual void onNukeDetect(Position target) {
    bwapiPINVOKE.AIModule_onNukeDetect(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onUnitDiscover(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitDiscover(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitEvade(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitEvade(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitShow(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitShow(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitHide(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitHide(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitCreate(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitCreate(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitDestroy(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitDestroy(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitMorph(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitMorph(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitRenegade(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitRenegade(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onSaveGame(string gameName) {
    bwapiPINVOKE.AIModule_onSaveGame(swigCPtr, gameName);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onUnitComplete(Unit unit) {
    bwapiPINVOKE.AIModule_onUnitComplete(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onPlayerDropped(Player player) {
    bwapiPINVOKE.AIModule_onPlayerDropped(swigCPtr, Player.getCPtr(player));
  }

}

}
