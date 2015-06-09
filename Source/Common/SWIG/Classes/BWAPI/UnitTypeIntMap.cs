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

public partial class UnitTypeIntMap : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<UnitType, int>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeIntMap(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnitTypeIntMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeIntMap() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitTypeIntMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public int this[UnitType key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(UnitType key, out int value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(int);
    return false;
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

  public global::System.Collections.Generic.ICollection<UnitType> Keys {
    get {
      global::System.Collections.Generic.ICollection<UnitType> keys = new global::System.Collections.Generic.List<UnitType>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<int> Values {
    get {
      global::System.Collections.Generic.ICollection<int> vals = new global::System.Collections.Generic.List<int>();
      foreach (global::System.Collections.Generic.KeyValuePair<UnitType, int> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(global::System.Collections.Generic.KeyValuePair<UnitType, int> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<UnitType, int> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<UnitType, int> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<UnitType, int>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<UnitType, int>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<UnitType> keyList = new global::System.Collections.Generic.List<UnitType>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      UnitType currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<UnitType, int>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<UnitType, int>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<UnitType, int>>.GetEnumerator() {
    return new UnitTypeIntMapEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new UnitTypeIntMapEnumerator(this);
  }

  public UnitTypeIntMapEnumerator GetEnumerator() {
    return new UnitTypeIntMapEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitTypeIntMapEnumerator : global::System.Collections.IEnumerator, 
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<UnitType, int>>
  {
    private UnitTypeIntMap collectionRef;
    private global::System.Collections.Generic.IList<UnitType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnitTypeIntMapEnumerator(UnitTypeIntMap collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<UnitType>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<UnitType, int> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<UnitType, int>)currentObject;
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
        UnitType currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<UnitType, int>(currentKey, collectionRef[currentKey]);
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
  

  public UnitTypeIntMap() : this(bwapiPINVOKE.new_UnitTypeIntMap__SWIG_0(), true) {
  }

  public UnitTypeIntMap(UnitTypeIntMap other) : this(bwapiPINVOKE.new_UnitTypeIntMap__SWIG_1(UnitTypeIntMap.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bwapiPINVOKE.UnitTypeIntMap_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bwapiPINVOKE.UnitTypeIntMap_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bwapiPINVOKE.UnitTypeIntMap_Clear(swigCPtr);
  }

  private int getitem(UnitType key) {
    int ret = bwapiPINVOKE.UnitTypeIntMap_getitem(swigCPtr, UnitType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(UnitType key, int x) {
    bwapiPINVOKE.UnitTypeIntMap_setitem(swigCPtr, UnitType.getCPtr(key), x);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(UnitType key) {
    bool ret = bwapiPINVOKE.UnitTypeIntMap_ContainsKey(swigCPtr, UnitType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(UnitType key, int val) {
    bwapiPINVOKE.UnitTypeIntMap_Add(swigCPtr, UnitType.getCPtr(key), val);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(UnitType key) {
    bool ret = bwapiPINVOKE.UnitTypeIntMap_Remove(swigCPtr, UnitType.getCPtr(key));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = bwapiPINVOKE.UnitTypeIntMap_create_iterator_begin(swigCPtr);
    return ret;
  }

  private UnitType get_next_key(global::System.IntPtr swigiterator) {
    UnitType ret = new UnitType(bwapiPINVOKE.UnitTypeIntMap_get_next_key(swigCPtr, swigiterator), false);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    bwapiPINVOKE.UnitTypeIntMap_destroy_iterator(swigCPtr, swigiterator);
  }

}

}
