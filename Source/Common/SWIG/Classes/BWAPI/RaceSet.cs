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

public partial class RaceSet : global::System.IDisposable 
#if !SWIG_DOTNET_3
    , global::System.Collections.Generic.ICollection<Race>
#endif
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RaceSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RaceSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RaceSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_RaceSet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<Race> Values {
    get {
      System.Collections.Generic.ICollection<Race> values = new System.Collections.Generic.List<Race>();
      global::System.IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (global::System.ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(Race item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Race[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Race[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Race> keyList = new System.Collections.Generic.List<Race>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Race currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Race> System.Collections.Generic.IEnumerable<Race>.GetEnumerator() {
    return new RaceSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new RaceSetEnumerator(this);
  }

  public RaceSetEnumerator GetEnumerator() {
    return new RaceSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class RaceSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Race>
  {
    private RaceSet collectionRef;
    private System.Collections.Generic.IList<Race> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public RaceSetEnumerator(RaceSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Race>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Race Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return ( Race)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        Race currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
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
#endif
  

  public RaceSet() : this(bwapiPINVOKE.new_RaceSet__SWIG_0(), true) {
  }

  public RaceSet(RaceSet other) : this(bwapiPINVOKE.new_RaceSet__SWIG_1(RaceSet.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.RaceSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.RaceSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.RaceSet_Clear(swigCPtr);
  }

  public Race getitem(Race key) {
    Race ret = new Race(bwapiPINVOKE.RaceSet_getitem(swigCPtr, Race.getCPtr(key)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Race key) {
    bool ret = bwapiPINVOKE.RaceSet_ContainsKey(swigCPtr, Race.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(Race key) {
    bwapiPINVOKE.RaceSet_Add(swigCPtr, Race.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Race key) {
    bool ret = bwapiPINVOKE.RaceSet_Remove(swigCPtr, Race.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = bwapiPINVOKE.RaceSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Race get_next_key(global::System.IntPtr swigiterator) {
    Race ret = new Race(bwapiPINVOKE.RaceSet_get_next_key(swigCPtr, swigiterator), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
