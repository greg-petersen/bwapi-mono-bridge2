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

public partial class PositionVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<Position>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PositionVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PositionVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PositionVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_PositionVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PositionVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Position element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Position this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(Position[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Position[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Position[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<Position> global::System.Collections.Generic.IEnumerable<Position>.GetEnumerator() {
    return new PositionVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new PositionVectorEnumerator(this);
  }

  public PositionVectorEnumerator GetEnumerator() {
    return new PositionVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class PositionVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Position>
  {
    private PositionVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public PositionVectorEnumerator(PositionVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Position Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Position)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    bwapiPINVOKE.PositionVector_Clear(swigCPtr);
  }

  public void Add(Position x) {
    bwapiPINVOKE.PositionVector_Add(swigCPtr, Position.getCPtr(x));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.PositionVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = bwapiPINVOKE.PositionVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    bwapiPINVOKE.PositionVector_reserve(swigCPtr, n);
  }

  public PositionVector() : this(bwapiPINVOKE.new_PositionVector__SWIG_0(), true) {
  }

  public PositionVector(PositionVector other) : this(bwapiPINVOKE.new_PositionVector__SWIG_1(PositionVector.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public PositionVector(int capacity) : this(bwapiPINVOKE.new_PositionVector__SWIG_2(capacity), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private Position getitemcopy(int index) {
    Position ret = new Position(bwapiPINVOKE.PositionVector_getitemcopy(swigCPtr, index), true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Position getitem(int index) {
    Position ret = new Position(bwapiPINVOKE.PositionVector_getitem(swigCPtr, index), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Position val) {
    bwapiPINVOKE.PositionVector_setitem(swigCPtr, index, Position.getCPtr(val));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(PositionVector values) {
    bwapiPINVOKE.PositionVector_AddRange(swigCPtr, PositionVector.getCPtr(values));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public PositionVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = bwapiPINVOKE.PositionVector_GetRange(swigCPtr, index, count);
    PositionVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new PositionVector(cPtr, true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Position x) {
    bwapiPINVOKE.PositionVector_Insert(swigCPtr, index, Position.getCPtr(x));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, PositionVector values) {
    bwapiPINVOKE.PositionVector_InsertRange(swigCPtr, index, PositionVector.getCPtr(values));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    bwapiPINVOKE.PositionVector_RemoveAt(swigCPtr, index);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    bwapiPINVOKE.PositionVector_RemoveRange(swigCPtr, index, count);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static PositionVector Repeat(Position value, int count) {
    global::System.IntPtr cPtr = bwapiPINVOKE.PositionVector_Repeat(Position.getCPtr(value), count);
    PositionVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new PositionVector(cPtr, true);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    bwapiPINVOKE.PositionVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    bwapiPINVOKE.PositionVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, PositionVector values) {
    bwapiPINVOKE.PositionVector_SetRange(swigCPtr, index, PositionVector.getCPtr(values));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
