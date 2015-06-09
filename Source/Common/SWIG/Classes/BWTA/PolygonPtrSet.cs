//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SWIG.BWTA {
 
	// defaults
	using System; 
	using System.Runtime.InteropServices; 
	// BWAPI
	using BWAPI;

public partial class PolygonPtrSet : global::System.IDisposable 
#if !SWIG_DOTNET_3
    , global::System.Collections.Generic.ICollection<Polygon>
#endif
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PolygonPtrSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PolygonPtrSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolygonPtrSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwtaPINVOKE.delete_PolygonPtrSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<Polygon> Values {
    get {
      System.Collections.Generic.ICollection<Polygon> values = new System.Collections.Generic.List<Polygon>();
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
 
  public bool Contains(Polygon item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(Polygon[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( Polygon[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<Polygon> keyList = new System.Collections.Generic.List<Polygon>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      Polygon currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< Polygon> System.Collections.Generic.IEnumerable<Polygon>.GetEnumerator() {
    return new PolygonPtrSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new PolygonPtrSetEnumerator(this);
  }

  public PolygonPtrSetEnumerator GetEnumerator() {
    return new PolygonPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class PolygonPtrSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< Polygon>
  {
    private PolygonPtrSet collectionRef;
    private System.Collections.Generic.IList<Polygon> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public PolygonPtrSetEnumerator(PolygonPtrSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<Polygon>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  Polygon Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return ( Polygon)currentObject;
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
        Polygon currentKey = keyCollection[currentIndex];
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
  

  public PolygonPtrSet() : this(bwtaPINVOKE.new_PolygonPtrSet__SWIG_0(), true) {
  }

  public PolygonPtrSet(PolygonPtrSet other) : this(bwtaPINVOKE.new_PolygonPtrSet__SWIG_1(PolygonPtrSet.getCPtr(other)), true) {
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwtaPINVOKE.PolygonPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwtaPINVOKE.PolygonPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwtaPINVOKE.PolygonPtrSet_Clear(swigCPtr);
  }

  public Polygon getitem(Polygon key) {
    global::System.IntPtr cPtr = bwtaPINVOKE.PolygonPtrSet_getitem(swigCPtr, Polygon.getCPtr(key));
    Polygon ret = (cPtr == global::System.IntPtr.Zero) ? null : new Polygon(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(Polygon key) {
    bool ret = bwtaPINVOKE.PolygonPtrSet_ContainsKey(swigCPtr, Polygon.getCPtr(key));
    return ret;
  }

  public void Add(Polygon key) {
    bwtaPINVOKE.PolygonPtrSet_Add(swigCPtr, Polygon.getCPtr(key));
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Polygon key) {
    bool ret = bwtaPINVOKE.PolygonPtrSet_Remove(swigCPtr, Polygon.getCPtr(key));
    return ret;
  }

  public global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = bwtaPINVOKE.PolygonPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public Polygon get_next_key(global::System.IntPtr swigiterator) {
    global::System.IntPtr cPtr = bwtaPINVOKE.PolygonPtrSet_get_next_key(swigCPtr, swigiterator);
    Polygon ret = (cPtr == global::System.IntPtr.Zero) ? null : new Polygon(cPtr, false);
    if (bwtaPINVOKE.SWIGPendingException.Pending) throw bwtaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
