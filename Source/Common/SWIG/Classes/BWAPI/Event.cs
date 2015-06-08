/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class Event : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Event(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Event obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Event() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_Event(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is Event)
      equal = (((Event)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Event obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Event obj1, Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Event obj1, Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Event() : this(bwapiPINVOKE.new_Event__SWIG_0(), true) {
  }

  public Event(Event other) : this(bwapiPINVOKE.new_Event__SWIG_1(Event.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public Event opAssign(Event other) {
    Event ret = new Event(bwapiPINVOKE.Event_opAssign(swigCPtr, Event.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Event other) {
    bool ret = bwapiPINVOKE.Event_opEquals(swigCPtr, Event.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event MatchStart() {
    Event ret = new Event(bwapiPINVOKE.Event_MatchStart(), true);
    return ret;
  }

  public static Event MatchEnd(bool isWinner) {
    Event ret = new Event(bwapiPINVOKE.Event_MatchEnd(isWinner), true);
    return ret;
  }

  public static Event MatchFrame() {
    Event ret = new Event(bwapiPINVOKE.Event_MatchFrame(), true);
    return ret;
  }

  public static Event MenuFrame() {
    Event ret = new Event(bwapiPINVOKE.Event_MenuFrame(), true);
    return ret;
  }

  public static Event SendText(string text) {
    Event ret = new Event(bwapiPINVOKE.Event_SendText__SWIG_0(text), true);
    return ret;
  }

  public static Event SendText() {
    Event ret = new Event(bwapiPINVOKE.Event_SendText__SWIG_1(), true);
    return ret;
  }

  public static Event ReceiveText(Player player, string text) {
    Event ret = new Event(bwapiPINVOKE.Event_ReceiveText__SWIG_0(Player.getCPtr(player), text), true);
    return ret;
  }

  public static Event ReceiveText(Player player) {
    Event ret = new Event(bwapiPINVOKE.Event_ReceiveText__SWIG_1(Player.getCPtr(player)), true);
    return ret;
  }

  public static Event PlayerLeft(Player player) {
    Event ret = new Event(bwapiPINVOKE.Event_PlayerLeft(Player.getCPtr(player)), true);
    return ret;
  }

  public static Event PlayerDropped(Player player) {
    Event ret = new Event(bwapiPINVOKE.Event_PlayerDropped(Player.getCPtr(player)), true);
    return ret;
  }

  public static Event NukeDetect(Position target) {
    Event ret = new Event(bwapiPINVOKE.Event_NukeDetect(Position.getCPtr(target)), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Event UnitDiscover(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitDiscover(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitEvade(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitEvade(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitShow(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitShow(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitHide(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitHide(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitCreate(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitCreate(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitDestroy(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitDestroy(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitMorph(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitMorph(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event UnitRenegade(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitRenegade(Unit.getCPtr(unit)), true);
    return ret;
  }

  public static Event SaveGame(string gameName) {
    Event ret = new Event(bwapiPINVOKE.Event_SaveGame__SWIG_0(gameName), true);
    return ret;
  }

  public static Event SaveGame() {
    Event ret = new Event(bwapiPINVOKE.Event_SaveGame__SWIG_1(), true);
    return ret;
  }

  public static Event UnitComplete(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_UnitComplete(Unit.getCPtr(unit)), true);
    return ret;
  }

  public EventType_Enum getType() {
    EventType_Enum ret = (EventType_Enum)bwapiPINVOKE.Event_getType(swigCPtr);
    return ret;
  }

  public Position getPosition() {
    Position ret = new Position(bwapiPINVOKE.Event_getPosition(swigCPtr), true);
    return ret;
  }

  public string getText() {
    string ret = bwapiPINVOKE.Event_getText(swigCPtr);
    return ret;
  }

  public Unit getUnit() {
    IntPtr cPtr = bwapiPINVOKE.Event_getUnit(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public Player getPlayer() {
    IntPtr cPtr = bwapiPINVOKE.Event_getPlayer(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public bool isWinner() {
    bool ret = bwapiPINVOKE.Event_isWinner(swigCPtr);
    return ret;
  }

  public Event setType(EventType_Enum type) {
    Event ret = new Event(bwapiPINVOKE.Event_setType(swigCPtr, (int)type), false);
    return ret;
  }

  public Event setPosition(Position position) {
    Event ret = new Event(bwapiPINVOKE.Event_setPosition(swigCPtr, Position.getCPtr(position)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Event setText(string text) {
    Event ret = new Event(bwapiPINVOKE.Event_setText(swigCPtr, text), false);
    return ret;
  }

  public Event setUnit(Unit unit) {
    Event ret = new Event(bwapiPINVOKE.Event_setUnit(swigCPtr, Unit.getCPtr(unit)), false);
    return ret;
  }

  public Event setPlayer(Player player) {
    Event ret = new Event(bwapiPINVOKE.Event_setPlayer(swigCPtr, Player.getCPtr(player)), false);
    return ret;
  }

  public Event setWinner(bool isWinner) {
    Event ret = new Event(bwapiPINVOKE.Event_setWinner(swigCPtr, isWinner), false);
    return ret;
  }

}

}