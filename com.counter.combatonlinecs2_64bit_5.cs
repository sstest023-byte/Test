 Offset: 0x18BAB14 VA: 0x6CF6911B14
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF68F786C Offset: 0x18A086C VA: 0x6CF68F786C
	public int get_Count() { }

	// RVA: 0x6CF6911BA8 Offset: 0x18BABA8 VA: 0x6CF6911BA8
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x6CF6911BB0 Offset: 0x18BABB0 VA: 0x6CF6911BB0
	public bool get_IsReadOnly() { }

	// RVA: 0x6CF6911BB8 Offset: 0x18BABB8 VA: 0x6CF6911BB8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF6911BC0 Offset: 0x18BABC0 VA: 0x6CF6911BC0
	public ICollection get_Keys() { }

	// RVA: 0x6CF6911B3C Offset: 0x18BAB3C VA: 0x6CF6911B3C
	private ArrayList get_objectsArray() { }

	// RVA: 0x6CF6911C64 Offset: 0x18BAC64 VA: 0x6CF6911C64
	private Hashtable get_objectsTable() { }

	// RVA: 0x6CF6911CE0 Offset: 0x18BACE0 VA: 0x6CF6911CE0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF6906858 Offset: 0x18AF858 VA: 0x6CF6906858
	public object get_Item(object key) { }

	// RVA: 0x6CF68F76F0 Offset: 0x18A06F0 VA: 0x6CF68F76F0
	public void set_Item(object key, object value) { }

	// RVA: 0x6CF68F7890 Offset: 0x18A0890 VA: 0x6CF68F7890
	public ICollection get_Values() { }

	// RVA: 0x6CF6911ED4 Offset: 0x18BAED4 VA: 0x6CF6911ED4
	public void Add(object key, object value) { }

	// RVA: 0x6CF6911FF8 Offset: 0x18BAFF8 VA: 0x6CF6911FF8
	public void Clear() { }

	// RVA: 0x6CF68F76C4 Offset: 0x18A06C4 VA: 0x6CF68F76C4
	public bool Contains(object key) { }

	// RVA: 0x6CF691208C Offset: 0x18BB08C VA: 0x6CF691208C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x6CF6911D54 Offset: 0x18BAD54 VA: 0x6CF6911D54
	private int IndexOfKey(object key) { }

	// RVA: 0x6CF6906884 Offset: 0x18AF884 VA: 0x6CF6906884
	public void Remove(object key) { }

	// RVA: 0x6CF69120C8 Offset: 0x18BB0C8 VA: 0x6CF69120C8
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x6CF6912180 Offset: 0x18BB180 VA: 0x6CF6912180
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF69121EC Offset: 0x18BB1EC VA: 0x6CF69121EC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF69123C0 Offset: 0x18BB3C0 VA: 0x6CF69123C0
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x6CF69123D0 Offset: 0x18BB3D0 VA: 0x6CF69123D0
	protected virtual void OnDeserialization(object sender) { }

}

// Dll : System.dll
// Namespace: System.Collections.Specialized
[Serializable]
public class StringCollection : Object, IList, ICollection, IEnumerable
{
	// Fields

	private readonly ArrayList data; // 0x10

	// Properties

	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x6CF6913298 Offset: 0x18BC298 VA: 0x6CF6913298
	public string get_Item(int index) { }

	// RVA: 0x6CF6913314 Offset: 0x18BC314 VA: 0x6CF6913314
	public void set_Item(int index, string value) { }

	// RVA: 0x6CF6913338 Offset: 0x18BC338 VA: 0x6CF6913338
	public int get_Count() { }

	// RVA: 0x6CF691335C Offset: 0x18BC35C VA: 0x6CF691335C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x6CF6913364 Offset: 0x18BC364 VA: 0x6CF6913364
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x6CF691336C Offset: 0x18BC36C VA: 0x6CF691336C
	public int Add(string value) { }

	// RVA: 0x6CF6913390 Offset: 0x18BC390 VA: 0x6CF6913390
	public void Clear() { }

	// RVA: 0x6CF69133B4 Offset: 0x18BC3B4 VA: 0x6CF69133B4
	public bool Contains(string value) { }

	// RVA: 0x6CF69133D8 Offset: 0x18BC3D8 VA: 0x6CF69133D8
	public void CopyTo(String[] array, int index) { }

	// RVA: 0x6CF69133FC Offset: 0x18BC3FC VA: 0x6CF69133FC
	public int IndexOf(string value) { }

	// RVA: 0x6CF6913420 Offset: 0x18BC420 VA: 0x6CF6913420
	public void Insert(int index, string value) { }

	// RVA: 0x6CF6913444 Offset: 0x18BC444 VA: 0x6CF6913444
	public bool get_IsSynchronized() { }

	// RVA: 0x6CF691344C Offset: 0x18BC44C VA: 0x6CF691344C
	public void Remove(string value) { }

	// RVA: 0x6CF6913470 Offset: 0x18BC470 VA: 0x6CF6913470
	public void RemoveAt(int index) { }

	// RVA: 0x6CF6913494 Offset: 0x18BC494 VA: 0x6CF6913494
	public object get_SyncRoot() { }

	// RVA: 0x6CF69134B8 Offset: 0x18BC4B8 VA: 0x6CF69134B8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x6CF69134BC Offset: 0x18BC4BC VA: 0x6CF69134BC
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x6CF6913548 Offset: 0x18BC548 VA: 0x6CF6913548
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x6CF69135C4 Offset: 0x18BC5C4 VA: 0x6CF69135C4
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x6CF6913640 Offset: 0x18BC640 VA: 0x6CF6913640
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x6CF69136BC Offset: 0x18BC6BC VA: 0x6CF69136BC
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x6CF6913748 Offset: 0x18BC748 VA: 0x6CF6913748
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x6CF69137C4 Offset: 0x18BC7C4 VA: 0x6CF69137C4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF69137E8 Offset: 0x18BC7E8 VA: 0x6CF69137E8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF691380C Offset: 0x18BC80C VA: 0x6CF691380C
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: 
internal class NameObjectEntry : Object
{
	// Fields

	internal string Key; // 0x10
	internal object Value; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69149B4 Offset: 0x18BD9B4 VA: 0x6CF69149B4
	internal void .ctor(string name, object value) { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
internal class NameObjectKeysEnumerator : Object, IEnumerator
{
	// Fields

	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Properties

	public object Current { get; }

	// Methods

	// RVA: 0x6CF6914A38 Offset: 0x18BDA38 VA: 0x6CF6914A38
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x6CF6914ECC Offset: 0x18BDECC VA: 0x6CF6914ECC
	public bool MoveNext() { }

	// RVA: 0x6CF6914FA4 Offset: 0x18BDFA4 VA: 0x6CF6914FA4
	public void Reset() { }

	// RVA: 0x6CF691502C Offset: 0x18BE02C VA: 0x6CF691502C
	public object get_Current() { }

}

// Dll : System.dll
// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : Object, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	// Fields

	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties

	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x6CF6910D0C Offset: 0x18B9D0C VA: 0x6CF6910D0C
	protected void .ctor() { }

	// RVA: 0x6CF691386C Offset: 0x18BC86C VA: 0x6CF691386C
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x6CF6910DE0 Offset: 0x18B9DE0 VA: 0x6CF6910DE0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x6CF6911ABC Offset: 0x18BAABC VA: 0x6CF6911ABC
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x6CF6910E78 Offset: 0x18B9E78 VA: 0x6CF6910E78
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF6913A50 Offset: 0x18BCA50 VA: 0x6CF6913A50
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF6914184 Offset: 0x18BD184 VA: 0x6CF6914184
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x6CF69138EC Offset: 0x18BC8EC VA: 0x6CF69138EC
	private void Reset() { }

	// RVA: 0x6CF6913998 Offset: 0x18BC998 VA: 0x6CF6913998
	private void Reset(int capacity) { }

	// RVA: 0x6CF69148F4 Offset: 0x18BD8F4 VA: 0x6CF69148F4
	private NameObjectEntry FindEntry(string key) { }

	// RVA: 0x6CF69149AC Offset: 0x18BD9AC VA: 0x6CF69149AC
	protected bool get_IsReadOnly() { }

	// RVA: 0x6CF6911278 Offset: 0x18BA278 VA: 0x6CF6911278
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x6CF6911680 Offset: 0x18BA680 VA: 0x6CF6911680
	protected void BaseRemove(string name) { }

	// RVA: 0x6CF6911260 Offset: 0x18BA260 VA: 0x6CF6911260
	protected object BaseGet(string name) { }

	// RVA: 0x6CF69115D0 Offset: 0x18BA5D0 VA: 0x6CF69115D0
	protected void BaseSet(string name, object value) { }

	// RVA: 0x6CF6911928 Offset: 0x18BA928 VA: 0x6CF6911928
	protected object BaseGet(int index) { }

	// RVA: 0x6CF69119C8 Offset: 0x18BA9C8 VA: 0x6CF69119C8
	protected string BaseGetKey(int index) { }

	// RVA: 0x6CF69149E0 Offset: 0x18BD9E0 VA: 0x6CF69149E0
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x6CF6914A78 Offset: 0x18BDA78 VA: 0x6CF6914A78
	public virtual int get_Count() { }

	// RVA: 0x6CF6914A9C Offset: 0x18BDA9C VA: 0x6CF6914A9C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF6914DA8 Offset: 0x18BDDA8 VA: 0x6CF6914DA8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF6914E1C Offset: 0x18BDE1C VA: 0x6CF6914E1C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF6914E24 Offset: 0x18BDE24 VA: 0x6CF6914E24
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : Object, IEqualityComparer
{
	// Fields

	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties

	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x6CF69148C8 Offset: 0x18BD8C8 VA: 0x6CF69148C8
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x6CF69150CC Offset: 0x18BE0CC VA: 0x6CF69150CC
	public bool Equals(object a, object b) { }

	// RVA: 0x6CF69152CC Offset: 0x18BE2CC VA: 0x6CF69152CC
	public int GetHashCode(object obj) { }

	// RVA: 0x6CF69153D4 Offset: 0x18BE3D4 VA: 0x6CF69153D4
	public IComparer get_Comparer() { }

	// RVA: 0x6CF69153DC Offset: 0x18BE3DC VA: 0x6CF69153DC
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x6CF69140B0 Offset: 0x18BD0B0 VA: 0x6CF69140B0
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x6CF6913FD8 Offset: 0x18BCFD8 VA: 0x6CF6913FD8
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
internal struct ValueListBuilder`1
{
	// Fields

	private Span`1 _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Properties

	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(Span`1 initialSpan) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Length() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public ref T get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Append(T item) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReadOnlySpan`1 AsSpan() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void Grow() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T Pop() { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView`1 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Collections.Generic
internal sealed class IDictionaryDebugView`2 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Collections.Generic
internal sealed class DictionaryKeyCollectionDebugView`2 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Collections.Generic
internal sealed class DictionaryValueCollectionDebugView`2 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
[Serializable]
public struct Enumerator : IEnumerator`1, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
{
	// Fields

	private LinkedList`1 _list; // 0x0
	private LinkedListNode`1 _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(LinkedList`1 list) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
[Serializable]
public class LinkedList`1 : Object, ICollection`1, IEnumerable`1, IEnumerable, ICollection, IReadOnlyCollection`1, ISerializable, IDeserializationCallback
{
	// Fields

	internal LinkedListNode`1 head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const string VersionName; // 0x0
	private const string CountName; // 0x0
	private const string ValuesName; // 0x0

	// Properties

	public int Count { get; }
	public LinkedListNode`1 First { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Count() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public LinkedListNode`1 get_First() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public LinkedListNode`1 AddBefore(LinkedListNode`1 node, T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public LinkedListNode`1 AddFirst(T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public LinkedListNode`1 AddLast(T value) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void AddLast(LinkedListNode`1 node) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Clear() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Contains(T value) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	public void CopyTo(T[] array, int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public LinkedListNode`1 Find(T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Enumerator GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Remove(T value) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void Remove(LinkedListNode`1 node) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void RemoveFirst() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	private void InternalInsertNodeBefore(LinkedListNode`1 node, LinkedListNode`1 newNode) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void InternalInsertNodeToEmptyList(LinkedListNode`1 newNode) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void InternalRemoveNode(LinkedListNode`1 node) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void ValidateNewNode(LinkedListNode`1 node) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void ValidateNode(LinkedListNode`1 node) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
public sealed class LinkedListNode`1 : Object
{
	// Fields

	internal LinkedList`1 list; // 0x0
	internal LinkedListNode`1 next; // 0x0
	internal LinkedListNode`1 prev; // 0x0
	internal T item; // 0x0

	// Properties

	public LinkedListNode`1 Next { get; }
	public T Value { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal void .ctor(LinkedList`1 list, T value) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public LinkedListNode`1 get_Next() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Value() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	internal void Invalidate() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private struct Enumerator : IEnumerator`1, IDisposable, IEnumerator, IDictionaryEnumerator
{
	// Fields

	private SortedList`2 _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties

	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair`2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	internal void .ctor(SortedList`2 sortedList, int getEnumeratorRetType) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public KeyValuePair`2 get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class SortedListKeyEnumerator : Object, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private SortedList`2 _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties

	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(SortedList`2 sortedList) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TKey get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class SortedListValueEnumerator : Object, IEnumerator`1, IDisposable, IEnumerator
{
	// Fields

	private SortedList`2 _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties

	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(SortedList`2 sortedList) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TValue get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class KeyList : Object, IList`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection
{
	// Fields

	private SortedList`2 _dict; // 0x0

	// Properties

	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(SortedList`2 dictionary) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Count() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool get_IsReadOnly() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Add(TKey key) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Clear() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Contains(TKey key) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	public void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Insert(int index, TKey value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TKey get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void set_Item(int index, TKey value) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator`1 GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public int IndexOf(TKey key) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Remove(TKey key) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class ValueList : Object, IList`1, ICollection`1, IEnumerable`1, IEnumerable, ICollection
{
	// Fields

	private SortedList`2 _dict; // 0x0

	// Properties

	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	internal void .ctor(SortedList`2 dictionary) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Count() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool get_IsReadOnly() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Add(TValue key) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Clear() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Contains(TValue value) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	public void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Insert(int index, TValue value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TValue get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void set_Item(int index, TValue value) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator`1 GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public int IndexOf(TValue value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Remove(TValue value) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
[Serializable]
public class SortedList`2 : Object, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary`2, IReadOnlyCollection`1
{
	// Fields

	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private int _size; // 0x0
	private int version; // 0x0
	private IComparer`1 comparer; // 0x0
	private KeyList keyList; // 0x0
	private ValueList valueList; // 0x0
	private object _syncRoot; // 0x0

	// Properties

	public int Capacity { set; }
	public IComparer`1 Comparer { get; }
	public int Count { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(IComparer`1 comparer) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void Add(TKey key, TValue value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair`2 keyValuePair) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair`2 keyValuePair) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair`2 keyValuePair) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void set_Capacity(int value) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IComparer`1 get_Comparer() { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Count() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private KeyList GetKeyListHelper() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private ValueList GetValueListHelper() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Clear() { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool ContainsKey(TKey key) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool ContainsValue(TValue value) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair`2[] array, int arrayIndex) { }

	// RVA: 0x6CF5BD75A8 Offset: 0xB805A8 VA: 0x6CF5BD75A8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	private void EnsureCapacity(int min) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TValue GetByIndex(int index) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator`1 GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private TKey GetKey(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public TValue get_Item(TKey key) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public int IndexOfKey(TKey key) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public int IndexOfValue(TValue value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool TryGetValue(TKey key, ref TValue value) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void RemoveAt(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Remove(TKey key) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x6CF5BD8758 Offset: 0xB81758 VA: 0x6CF5BD8758
	private static bool IsCompatibleKey(object key) { }

}

// Dll : System.dll
// Namespace: System.Collections.Generic
public interface ISet`1 : ICollection`1, IEnumerable`1, IEnumerable
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.IO.Compression
public enum CompressionMode
{
	// Fields

	public int value__; // 0x10
	public const CompressionMode Decompress = 0; // 0x0
	public const CompressionMode Compress = 1; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.IO.Compression
public class GZipStream : Stream
{
	// Fields

	private DeflateStream _deflateStream; // 0x28

	// Properties

	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x6CF69153E4 Offset: 0x18BE3E4 VA: 0x6CF69153E4
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x6CF69153EC Offset: 0x18BE3EC VA: 0x6CF69153EC
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x6CF69154A8 Offset: 0x18BE4A8 VA: 0x6CF69154A8
	public override bool get_CanRead() { }

	// RVA: 0x6CF69154C0 Offset: 0x18BE4C0 VA: 0x6CF69154C0
	public override bool get_CanWrite() { }

	// RVA: 0x6CF69154D8 Offset: 0x18BE4D8 VA: 0x6CF69154D8
	public override bool get_CanSeek() { }

	// RVA: 0x6CF69154F0 Offset: 0x18BE4F0 VA: 0x6CF69154F0
	public override long get_Length() { }

	// RVA: 0x6CF691553C Offset: 0x18BE53C VA: 0x6CF691553C
	public override long get_Position() { }

	// RVA: 0x6CF6915588 Offset: 0x18BE588 VA: 0x6CF6915588
	public override void set_Position(long value) { }

	// RVA: 0x6CF69155D4 Offset: 0x18BE5D4 VA: 0x6CF69155D4
	public override void Flush() { }

	// RVA: 0x6CF6915610 Offset: 0x18BE610 VA: 0x6CF6915610
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF691565C Offset: 0x18BE65C VA: 0x6CF691565C
	public override void SetLength(long value) { }

	// RVA: 0x6CF69156A8 Offset: 0x18BE6A8 VA: 0x6CF69156A8
	public override int ReadByte() { }

	// RVA: 0x6CF69156CC Offset: 0x18BE6CC VA: 0x6CF69156CC
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x6CF6915780 Offset: 0x18BE780 VA: 0x6CF6915780
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF69157C8 Offset: 0x18BE7C8 VA: 0x6CF69157C8
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF69157EC Offset: 0x18BE7EC VA: 0x6CF69157EC
	public override int Read(Span`1 buffer) { }

	// RVA: 0x6CF69159F0 Offset: 0x18BE9F0 VA: 0x6CF69159F0
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x6CF6915AA4 Offset: 0x18BEAA4 VA: 0x6CF6915AA4
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6915AB0 Offset: 0x18BEAB0 VA: 0x6CF6915AB0
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6915AD4 Offset: 0x18BEAD4 VA: 0x6CF6915AD4
	public override void Write(ReadOnlySpan`1 buffer) { }

	// RVA: 0x6CF6915C44 Offset: 0x18BEC44 VA: 0x6CF6915C44
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF6915CFC Offset: 0x18BECFC VA: 0x6CF6915CFC
	public override Task`1 ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6915D20 Offset: 0x18BED20 VA: 0x6CF6915D20
	public override ValueTask`1 ReadAsync(Memory`1 buffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6915E00 Offset: 0x18BEE00 VA: 0x6CF6915E00
	public override Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6915E24 Offset: 0x18BEE24 VA: 0x6CF6915E24
	public override ValueTask WriteAsync(ReadOnlyMemory`1 buffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6915F04 Offset: 0x18BEF04 VA: 0x6CF6915F04
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF69155F8 Offset: 0x18BE5F8 VA: 0x6CF69155F8
	private void CheckDeflateStream() { }

	// RVA: 0x6CF6915F28 Offset: 0x18BEF28 VA: 0x6CF6915F28
	private static void ThrowStreamClosedException() { }

}

// Dll : System.dll
// Namespace: 
private sealed class ReadMethod : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6917030 Offset: 0x18C0030 VA: 0x6CF6917030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69170D0 Offset: 0x18C00D0 VA: 0x6CF69170D0
	public virtual int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF69170E4 Offset: 0x18C00E4 VA: 0x6CF69170E4
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x6CF691718C Offset: 0x18C018C VA: 0x6CF691718C
	public virtual int EndInvoke(IAsyncResult result) { }

}

// Dll : System.dll
// Namespace: 
private sealed class WriteMethod : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69171B4 Offset: 0x18C01B4 VA: 0x6CF69171B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6917254 Offset: 0x18C0254 VA: 0x6CF6917254
	public virtual void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6917268 Offset: 0x18C0268 VA: 0x6CF6917268
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x6CF6917310 Offset: 0x18C0310 VA: 0x6CF6917310
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : System.dll
// Namespace: System.IO.Compression
public class DeflateStream : Stream
{
	// Fields

	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x6CF6915F78 Offset: 0x18BEF78 VA: 0x6CF6915F78
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x6CF691549C Offset: 0x18BE49C VA: 0x6CF691549C
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x6CF6915F84 Offset: 0x18BEF84 VA: 0x6CF6915F84
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x6CF69160E8 Offset: 0x18BF0E8 VA: 0x6CF69160E8
	protected override void Finalize() { }

	// RVA: 0x6CF691618C Offset: 0x18BF18C VA: 0x6CF691618C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF6916248 Offset: 0x18BF248 VA: 0x6CF6916248
	private int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6915DF8 Offset: 0x18BEDF8 VA: 0x6CF6915DF8
	internal ValueTask`1 ReadAsyncMemory(Memory`1 destination, CancellationToken cancellationToken) { }

	// RVA: 0x6CF69158D8 Offset: 0x18BE8D8 VA: 0x6CF69158D8
	internal int ReadCore(Span`1 destination) { }

	// RVA: 0x6CF6916294 Offset: 0x18BF294 VA: 0x6CF6916294
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6916464 Offset: 0x18BF464 VA: 0x6CF6916464
	private void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6915EFC Offset: 0x18BEEFC VA: 0x6CF6915EFC
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory`1 source, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6915BC0 Offset: 0x18BEBC0 VA: 0x6CF6915BC0
	internal void WriteCore(ReadOnlySpan`1 source) { }

	// RVA: 0x6CF69164AC Offset: 0x18BF4AC VA: 0x6CF69164AC
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x6CF6916688 Offset: 0x18BF688 VA: 0x6CF6916688
	public override void Flush() { }

	// RVA: 0x6CF691673C Offset: 0x18BF73C VA: 0x6CF691673C
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x6CF69169A8 Offset: 0x18BF9A8 VA: 0x6CF69169A8
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x6CF6916C14 Offset: 0x18BFC14 VA: 0x6CF6916C14
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6916D54 Offset: 0x18BFD54 VA: 0x6CF6916D54
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6916E94 Offset: 0x18BFE94 VA: 0x6CF6916E94
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF6916ECC Offset: 0x18BFECC VA: 0x6CF6916ECC
	public override void SetLength(long value) { }

	// RVA: 0x6CF6916F04 Offset: 0x18BFF04 VA: 0x6CF6916F04
	public override bool get_CanRead() { }

	// RVA: 0x6CF6916F40 Offset: 0x18BFF40 VA: 0x6CF6916F40
	public override bool get_CanSeek() { }

	// RVA: 0x6CF6916F48 Offset: 0x18BFF48 VA: 0x6CF6916F48
	public override bool get_CanWrite() { }

	// RVA: 0x6CF6916F88 Offset: 0x18BFF88 VA: 0x6CF6916F88
	public override long get_Length() { }

	// RVA: 0x6CF6916FC0 Offset: 0x18BFFC0 VA: 0x6CF6916FC0
	public override long get_Position() { }

	// RVA: 0x6CF6916FF8 Offset: 0x18BFFF8 VA: 0x6CF6916FF8
	public override void set_Position(long value) { }

}

// Dll : System.dll
// Namespace: 
private sealed class UnmanagedReadOrWrite : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69175D4 Offset: 0x18C05D4 VA: 0x6CF69175D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6917FEC Offset: 0x18C0FEC VA: 0x6CF6917FEC
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Dll : System.dll
// Namespace: 
private sealed class SafeDeflateStreamHandle : SafeHandle
{
	// Fields


	// Properties

	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x6CF6918000 Offset: 0x18C1000 VA: 0x6CF6918000
	public override bool get_IsInvalid() { }

	// RVA: 0x6CF6917FD8 Offset: 0x18C0FD8 VA: 0x6CF6917FD8
	private void .ctor() { }

	// RVA: 0x6CF6918010 Offset: 0x18C1010 VA: 0x6CF6918010
	protected override bool ReleaseHandle() { }

}

// Dll : System.dll
// Namespace: System.IO.Compression
internal class DeflateStreamNative : Object
{
	// Fields

	private UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private Byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF6917494 Offset: 0x18C0494 VA: 0x6CF6917494
	private void .ctor() { }

	// RVA: 0x6CF691749C Offset: 0x18C049C VA: 0x6CF691749C
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x6CF6917808 Offset: 0x18C0808 VA: 0x6CF6917808
	protected override void Finalize() { }

	// RVA: 0x6CF6917704 Offset: 0x18C0704 VA: 0x6CF6917704
	public void Dispose(bool disposing) { }

	// RVA: 0x6CF69178A0 Offset: 0x18C08A0 VA: 0x6CF69178A0
	public void Flush() { }

	// RVA: 0x6CF6917A84 Offset: 0x18C0A84 VA: 0x6CF6917A84
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x6CF6917B78 Offset: 0x18C0B78 VA: 0x6CF6917B78
	public void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x6CF691731C Offset: 0x18C031C VA: 0x6CF691731C
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x6CF6917C60 Offset: 0x18C0C60 VA: 0x6CF6917C60
	private int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x6CF69173D8 Offset: 0x18C03D8 VA: 0x6CF69173D8
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x6CF6917E04 Offset: 0x18C0E04 VA: 0x6CF6917E04
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x6CF6917958 Offset: 0x18C0958 VA: 0x6CF6917958
	private void CheckResult(int result, string where) { }

	// RVA: 0x6CF6917660 Offset: 0x18C0660 VA: 0x6CF6917660
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x6CF6917FE8 Offset: 0x18C0FE8 VA: 0x6CF6917FE8
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x6CF69178F4 Offset: 0x18C08F4 VA: 0x6CF69178F4
	private static extern int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x6CF6917AFC Offset: 0x18C0AFC VA: 0x6CF6917AFC
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x6CF6917BE4 Offset: 0x18C0BE4 VA: 0x6CF6917BE4
	private static extern int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

// Dll : System.dll
// Namespace: 
private enum StateFlags
{
	// Fields

	public byte value__; // 0x10
	public const StateFlags None = 0; // 0x0
	public const StateFlags CaptureIdentity = 1; // 0x0
	public const StateFlags CaptureContext = 2; // 0x0
	public const StateFlags ThreadSafeContextCopy = 4; // 0x0
	public const StateFlags PostBlockStarted = 8; // 0x0
	public const StateFlags PostBlockFinished = 16; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static ContextCallback <>9__17_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF6918D88 Offset: 0x18C1D88 VA: 0x6CF6918D88
	private static void .cctor() { }

	// RVA: 0x6CF6918DE4 Offset: 0x18C1DE4 VA: 0x6CF6918DE4
	public void .ctor() { }

	// RVA: 0x6CF6918DEC Offset: 0x18C1DEC VA: 0x6CF6918DEC
	internal void <Complete>b__17_0(object s) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class ContextAwareResult : LazyAsyncResult
{
	// Fields

	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private StateFlags _flags; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF6918098 Offset: 0x18C1098 VA: 0x6CF6918098
	private void SafeCaptureIdentity() { }

	// RVA: 0x6CF691809C Offset: 0x18C109C VA: 0x6CF691809C
	private void CleanupInternal() { }

	// RVA: 0x6CF69180A0 Offset: 0x18C10A0 VA: 0x6CF69180A0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x6CF69180A8 Offset: 0x18C10A8 VA: 0x6CF69180A8
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x6CF69180F8 Offset: 0x18C10F8 VA: 0x6CF69180F8
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x6CF6918170 Offset: 0x18C1170 VA: 0x6CF6918170
	internal object StartPostingAsyncOp() { }

	// RVA: 0x6CF6918178 Offset: 0x18C1178 VA: 0x6CF6918178
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x6CF6918334 Offset: 0x18C1334 VA: 0x6CF6918334
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x6CF691873C Offset: 0x18C173C VA: 0x6CF691873C
	protected override void Cleanup() { }

	// RVA: 0x6CF6918374 Offset: 0x18C1374 VA: 0x6CF6918374
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x6CF6918A00 Offset: 0x18C1A00 VA: 0x6CF6918A00
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x6CF6918CDC Offset: 0x18C1CDC VA: 0x6CF6918CDC
	private void CompleteCallback() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class HttpStatusDescription : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6918E6C Offset: 0x18C1E6C VA: 0x6CF6918E6C
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x6CF6918E70 Offset: 0x18C1E70 VA: 0x6CF6918E70
	internal static string Get(int code) { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class HttpValidationHelpers : Object
{
	// Fields

	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6919508 Offset: 0x18C2508 VA: 0x6CF6919508
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x6CF6919608 Offset: 0x18C2608 VA: 0x6CF6919608
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
public class Keywords : Object
{
	// Fields

	public const EventKeywords Default; // 0x0
	public const EventKeywords Debug; // 0x0
	public const EventKeywords EnterExit; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal sealed class NetEventSource : EventSource
{
	// Fields

	public static readonly NetEventSource Log; // 0x0

	// Properties

	public static bool IsEnabled { get; }

	// Methods

	// RVA: 0x6CF691969C Offset: 0x18C269C VA: 0x6CF691969C
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x6CF6919C48 Offset: 0x18C2C48 VA: 0x6CF6919C48
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x6CF691A114 Offset: 0x18C3114 VA: 0x6CF691A114
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x6CF6919BCC Offset: 0x18C2BCC VA: 0x6CF6919BCC
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x6CF691A230 Offset: 0x18C3230 VA: 0x6CF691A230
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x6CF691A39C Offset: 0x18C339C VA: 0x6CF691A39C
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x6CF691A320 Offset: 0x18C3320 VA: 0x6CF691A320
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x6CF6918840 Offset: 0x18C1840 VA: 0x6CF6918840
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x6CF6918930 Offset: 0x18C1930 VA: 0x6CF6918930
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x6CF691A46C Offset: 0x18C346C VA: 0x6CF691A46C
	private void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x6CF691A4E8 Offset: 0x18C34E8 VA: 0x6CF691A4E8
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x6CF691A5B8 Offset: 0x18C35B8 VA: 0x6CF691A5B8
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x6CF6918264 Offset: 0x18C1264 VA: 0x6CF6918264
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x6CF691A634 Offset: 0x18C3634 VA: 0x6CF691A634
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x6CF691A6B0 Offset: 0x18C36B0 VA: 0x6CF691A6B0
	public static void Associate(object first, object second, string memberName) { }

	// RVA: 0x6CF691A780 Offset: 0x18C3780 VA: 0x6CF691A780
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x6CF69187DC Offset: 0x18C17DC VA: 0x6CF69187DC
	public static bool get_IsEnabled() { }

	// RVA: 0x6CF691978C Offset: 0x18C278C VA: 0x6CF691978C
	public static string IdOf(object value) { }

	// RVA: 0x6CF691AA14 Offset: 0x18C3A14 VA: 0x6CF691AA14
	public static int GetHashCode(object value) { }

	// RVA: 0x6CF6919D30 Offset: 0x18C2D30 VA: 0x6CF6919D30
	public static object Format(object value) { }

	// RVA: 0x6CF6919874 Offset: 0x18C2874 VA: 0x6CF6919874
	private static string Format(FormattableString s) { }

	// RVA: 0x6CF691A808 Offset: 0x18C3808 VA: 0x6CF691A808
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x6CF691AA28 Offset: 0x18C3A28 VA: 0x6CF691AA28
	public void .ctor() { }

	// RVA: 0x6CF691AA30 Offset: 0x18C3A30 VA: 0x6CF691AA30
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class TcpValidationHelpers : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF691AA8C Offset: 0x18C3A8C VA: 0x6CF691AA8C
	public static bool ValidatePortNumber(int port) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class TlsStream : NetworkStream
{
	// Fields

	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF691AA98 Offset: 0x18C3A98 VA: 0x6CF691AA98
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x6CF691AB64 Offset: 0x18C3B64 VA: 0x6CF691AB64
	public void AuthenticateAsClient() { }

	// RVA: 0x6CF691AC64 Offset: 0x18C3C64 VA: 0x6CF691AC64
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x6CF691AD7C Offset: 0x18C3D7C VA: 0x6CF691AD7C
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691ADA0 Offset: 0x18C3DA0 VA: 0x6CF691ADA0
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF691ADC4 Offset: 0x18C3DC4 VA: 0x6CF691ADC4
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x6CF691ADE8 Offset: 0x18C3DE8 VA: 0x6CF691ADE8
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF691AE0C Offset: 0x18C3E0C VA: 0x6CF691AE0C
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF691AE30 Offset: 0x18C3E30 VA: 0x6CF691AE30
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x6CF691AE54 Offset: 0x18C3E54 VA: 0x6CF691AE54
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691AE78 Offset: 0x18C3E78 VA: 0x6CF691AE78
	public override void Close() { }

}

// Dll : System.dll
// Namespace: System.Net
public enum HttpStatusCode
{
	// Fields

	public int value__; // 0x10
	public const HttpStatusCode Continue = 100; // 0x0
	public const HttpStatusCode SwitchingProtocols = 101; // 0x0
	public const HttpStatusCode Processing = 102; // 0x0
	public const HttpStatusCode EarlyHints = 103; // 0x0
	public const HttpStatusCode OK = 200; // 0x0
	public const HttpStatusCode Created = 201; // 0x0
	public const HttpStatusCode Accepted = 202; // 0x0
	public const HttpStatusCode NonAuthoritativeInformation = 203; // 0x0
	public const HttpStatusCode NoContent = 204; // 0x0
	public const HttpStatusCode ResetContent = 205; // 0x0
	public const HttpStatusCode PartialContent = 206; // 0x0
	public const HttpStatusCode MultiStatus = 207; // 0x0
	public const HttpStatusCode AlreadyReported = 208; // 0x0
	public const HttpStatusCode IMUsed = 226; // 0x0
	public const HttpStatusCode MultipleChoices = 300; // 0x0
	public const HttpStatusCode Ambiguous = 300; // 0x0
	public const HttpStatusCode MovedPermanently = 301; // 0x0
	public const HttpStatusCode Moved = 301; // 0x0
	public const HttpStatusCode Found = 302; // 0x0
	public const HttpStatusCode Redirect = 302; // 0x0
	public const HttpStatusCode SeeOther = 303; // 0x0
	public const HttpStatusCode RedirectMethod = 303; // 0x0
	public const HttpStatusCode NotModified = 304; // 0x0
	public const HttpStatusCode UseProxy = 305; // 0x0
	public const HttpStatusCode Unused = 306; // 0x0
	public const HttpStatusCode TemporaryRedirect = 307; // 0x0
	public const HttpStatusCode RedirectKeepVerb = 307; // 0x0
	public const HttpStatusCode PermanentRedirect = 308; // 0x0
	public const HttpStatusCode BadRequest = 400; // 0x0
	public const HttpStatusCode Unauthorized = 401; // 0x0
	public const HttpStatusCode PaymentRequired = 402; // 0x0
	public const HttpStatusCode Forbidden = 403; // 0x0
	public const HttpStatusCode NotFound = 404; // 0x0
	public const HttpStatusCode MethodNotAllowed = 405; // 0x0
	public const HttpStatusCode NotAcceptable = 406; // 0x0
	public const HttpStatusCode ProxyAuthenticationRequired = 407; // 0x0
	public const HttpStatusCode RequestTimeout = 408; // 0x0
	public const HttpStatusCode Conflict = 409; // 0x0
	public const HttpStatusCode Gone = 410; // 0x0
	public const HttpStatusCode LengthRequired = 411; // 0x0
	public const HttpStatusCode PreconditionFailed = 412; // 0x0
	public const HttpStatusCode RequestEntityTooLarge = 413; // 0x0
	public const HttpStatusCode RequestUriTooLong = 414; // 0x0
	public const HttpStatusCode UnsupportedMediaType = 415; // 0x0
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416; // 0x0
	public const HttpStatusCode ExpectationFailed = 417; // 0x0
	public const HttpStatusCode MisdirectedRequest = 421; // 0x0
	public const HttpStatusCode UnprocessableEntity = 422; // 0x0
	public const HttpStatusCode Locked = 423; // 0x0
	public const HttpStatusCode FailedDependency = 424; // 0x0
	public const HttpStatusCode UpgradeRequired = 426; // 0x0
	public const HttpStatusCode PreconditionRequired = 428; // 0x0
	public const HttpStatusCode TooManyRequests = 429; // 0x0
	public const HttpStatusCode RequestHeaderFieldsTooLarge = 431; // 0x0
	public const HttpStatusCode UnavailableForLegalReasons = 451; // 0x0
	public const HttpStatusCode InternalServerError = 500; // 0x0
	public const HttpStatusCode NotImplemented = 501; // 0x0
	public const HttpStatusCode BadGateway = 502; // 0x0
	public const HttpStatusCode ServiceUnavailable = 503; // 0x0
	public const HttpStatusCode GatewayTimeout = 504; // 0x0
	public const HttpStatusCode HttpVersionNotSupported = 505; // 0x0
	public const HttpStatusCode VariantAlsoNegotiates = 506; // 0x0
	public const HttpStatusCode InsufficientStorage = 507; // 0x0
	public const HttpStatusCode LoopDetected = 508; // 0x0
	public const HttpStatusCode NotExtended = 510; // 0x0
	public const HttpStatusCode NetworkAuthenticationRequired = 511; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public class HttpVersion : Object
{
	// Fields

	public static readonly Version Unknown; // 0x0
	public static readonly Version Version10; // 0x8
	public static readonly Version Version11; // 0x10
	public static readonly Version Version20; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF691AEAC Offset: 0x18C3EAC VA: 0x6CF691AEAC
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
private sealed class ReadOnlyIPAddress : IPAddress
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF691C368 Offset: 0x18C5368 VA: 0x6CF691C368
	public void .ctor(long newAddress) { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class IPAddress : Object
{
	// Fields

	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask; // 0x0
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly UInt16[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels; // 0x0

	// Properties

	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x6CF691AF9C Offset: 0x18C3F9C VA: 0x6CF691AF9C
	private bool get_IsIPv4() { }

	// RVA: 0x6CF691AFAC Offset: 0x18C3FAC VA: 0x6CF691AFAC
	private bool get_IsIPv6() { }

	// RVA: 0x6CF691AFBC Offset: 0x18C3FBC VA: 0x6CF691AFBC
	private uint get_PrivateAddress() { }

	// RVA: 0x6CF691AFC4 Offset: 0x18C3FC4 VA: 0x6CF691AFC4
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x6CF691AFD4 Offset: 0x18C3FD4 VA: 0x6CF691AFD4
	private uint get_PrivateScopeId() { }

	// RVA: 0x6CF691AFDC Offset: 0x18C3FDC VA: 0x6CF691AFDC
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x6CF691AFEC Offset: 0x18C3FEC VA: 0x6CF691AFEC
	public void .ctor(long newAddress) { }

	// RVA: 0x6CF691B06C Offset: 0x18C406C VA: 0x6CF691B06C
	public void .ctor(Byte[] address, long scopeid) { }

	// RVA: 0x6CF691B134 Offset: 0x18C4134 VA: 0x6CF691B134
	public void .ctor(ReadOnlySpan`1 address, long scopeid) { }

	// RVA: 0x6CF691B2B0 Offset: 0x18C42B0 VA: 0x6CF691B2B0
	internal void .ctor(UInt16* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x6CF691B368 Offset: 0x18C4368 VA: 0x6CF691B368
	private void .ctor(UInt16[] numbers, uint scopeid) { }

	// RVA: 0x6CF691B39C Offset: 0x18C439C VA: 0x6CF691B39C
	public static bool TryParse(string ipString, ref IPAddress address) { }

	// RVA: 0x6CF691B5CC Offset: 0x18C45CC VA: 0x6CF691B5CC
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x6CF691B664 Offset: 0x18C4664 VA: 0x6CF691B664
	public bool TryWriteBytes(Span`1 destination, ref int bytesWritten) { }

	// RVA: 0x6CF691B770 Offset: 0x18C4770 VA: 0x6CF691B770
	private void WriteIPv6Bytes(Span`1 destination) { }

	// RVA: 0x6CF691B7FC Offset: 0x18C47FC VA: 0x6CF691B7FC
	private void WriteIPv4Bytes(Span`1 destination) { }

	// RVA: 0x6CF691B848 Offset: 0x18C4848 VA: 0x6CF691B848
	public Byte[] GetAddressBytes() { }

	// RVA: 0x6CF691B990 Offset: 0x18C4990 VA: 0x6CF691B990
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x6CF691B9A8 Offset: 0x18C49A8 VA: 0x6CF691B9A8
	public long get_ScopeId() { }

	// RVA: 0x6CF691B9F8 Offset: 0x18C49F8 VA: 0x6CF691B9F8
	public override string ToString() { }

	// RVA: 0x6CF691BB04 Offset: 0x18C4B04 VA: 0x6CF691BB04
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x6CF691BBCC Offset: 0x18C4BCC VA: 0x6CF691BBCC
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x6CF691BD00 Offset: 0x18C4D00 VA: 0x6CF691BD00
	public override bool Equals(object comparand) { }

	// RVA: 0x6CF691BD08 Offset: 0x18C4D08 VA: 0x6CF691BD08
	public override int GetHashCode() { }

	// RVA: 0x6CF691C0F8 Offset: 0x18C50F8 VA: 0x6CF691C0F8
	public IPAddress MapToIPv6() { }

	// RVA: 0x6CF691B0E8 Offset: 0x18C40E8 VA: 0x6CF691B0E8
	private static Byte[] ThrowAddressNullException() { }

	// RVA: 0x6CF691C1D4 Offset: 0x18C51D4 VA: 0x6CF691C1D4
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class IPAddressParser : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF691B408 Offset: 0x18C4408 VA: 0x6CF691B408
	internal static IPAddress Parse(ReadOnlySpan`1 ipSpan, bool tryParse) { }

	// RVA: 0x6CF691BAA4 Offset: 0x18C4AA4 VA: 0x6CF691BAA4
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x6CF691C68C Offset: 0x18C568C VA: 0x6CF691C68C
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x6CF691C5F0 Offset: 0x18C55F0 VA: 0x6CF691C5F0
	private static int IPv4AddressToStringHelper(uint address, Char* addressString) { }

	// RVA: 0x6CF691BA90 Offset: 0x18C4A90 VA: 0x6CF691BA90
	internal static string IPv6AddressToString(UInt16[] address, uint scopeId) { }

	// RVA: 0x6CF691C7B4 Offset: 0x18C57B4 VA: 0x6CF691C7B4
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, uint scopeId) { }

	// RVA: 0x6CF691C6FC Offset: 0x18C56FC VA: 0x6CF691C6FC
	private static void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	// RVA: 0x6CF691C540 Offset: 0x18C5540 VA: 0x6CF691C540
	public static bool Ipv4StringToAddress(ReadOnlySpan`1 ipSpan, ref long address) { }

	// RVA: 0x6CF691C3CC Offset: 0x18C53CC VA: 0x6CF691C3CC
	public static bool Ipv6StringToAddress(ReadOnlySpan`1 ipSpan, UInt16* numbers, int numbersLength, ref uint scope) { }

	// RVA: 0x6CF691C8D4 Offset: 0x18C58D4 VA: 0x6CF691C8D4
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x6CF691CABC Offset: 0x18C5ABC VA: 0x6CF691CABC
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x6CF691CA88 Offset: 0x18C5A88 VA: 0x6CF691CA88
	private static uint ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x6CF691CB24 Offset: 0x18C5B24 VA: 0x6CF691CB24
	private static ushort Reverse(ushort number) { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint
{
	// Fields

	public const int MinPort; // 0x0
	public const int MaxPort; // 0x0
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal const int AnyPort; // 0x0
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties

	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x6CF691CB30 Offset: 0x18C5B30 VA: 0x6CF691CB30
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x6CF691CB5C Offset: 0x18C5B5C VA: 0x6CF691CB5C
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x6CF691CC1C Offset: 0x18C5C1C VA: 0x6CF691CC1C
	public IPAddress get_Address() { }

	// RVA: 0x6CF691CC24 Offset: 0x18C5C24 VA: 0x6CF691CC24
	public int get_Port() { }

	// RVA: 0x6CF691CC2C Offset: 0x18C5C2C VA: 0x6CF691CC2C
	public override string ToString() { }

	// RVA: 0x6CF691CCE8 Offset: 0x18C5CE8 VA: 0x6CF691CCE8
	public override SocketAddress Serialize() { }

	// RVA: 0x6CF691CDA8 Offset: 0x18C5DA8 VA: 0x6CF691CDA8
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x6CF691D054 Offset: 0x18C6054 VA: 0x6CF691D054
	public override bool Equals(object comparand) { }

	// RVA: 0x6CF691D108 Offset: 0x18C6108 VA: 0x6CF691D108
	public override int GetHashCode() { }

	// RVA: 0x6CF691D138 Offset: 0x18C6138 VA: 0x6CF691D138
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
internal enum PipelineInstruction
{
	// Fields

	public int value__; // 0x10
	public const PipelineInstruction Abort = 0; // 0x0
	public const PipelineInstruction Advance = 1; // 0x0
	public const PipelineInstruction Pause = 2; // 0x0
	public const PipelineInstruction Reread = 3; // 0x0
	public const PipelineInstruction GiveStream = 4; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
internal enum PipelineEntryFlags
{
	// Fields

	public int value__; // 0x10
	public const PipelineEntryFlags UserCommand = 1; // 0x0
	public const PipelineEntryFlags GiveDataStream = 2; // 0x0
	public const PipelineEntryFlags CreateDataConnection = 4; // 0x0
	public const PipelineEntryFlags DontLogParameter = 8; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
internal class PipelineEntry : Object
{
	// Fields

	internal string Command; // 0x10
	internal PipelineEntryFlags Flags; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF691F1B4 Offset: 0x18C81B4 VA: 0x6CF691F1B4
	internal void .ctor(string command) { }

	// RVA: 0x6CF691F1DC Offset: 0x18C81DC VA: 0x6CF691F1DC
	internal void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x6CF691DE60 Offset: 0x18C6E60 VA: 0x6CF691DE60
	internal bool HasFlag(PipelineEntryFlags flags) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class CommandStream : NetworkStreamWrapper
{
	// Fields

	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties

	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x6CF691D200 Offset: 0x18C6200 VA: 0x6CF691D200
	internal void .ctor(TcpClient client) { }

	// RVA: 0x6CF691D318 Offset: 0x18C6318 VA: 0x6CF691D318
	internal virtual void Abort(Exception e) { }

	// RVA: 0x6CF691D52C Offset: 0x18C652C VA: 0x6CF691D52C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF691D5C0 Offset: 0x18C65C0 VA: 0x6CF691D5C0
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x6CF691D640 Offset: 0x18C6640 VA: 0x6CF691D640
	internal bool get_RecoverableFailure() { }

	// RVA: 0x6CF691D648 Offset: 0x18C6648 VA: 0x6CF691D648
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x6CF691D660 Offset: 0x18C6660 VA: 0x6CF691D660
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x6CF691DC40 Offset: 0x18C6C40 VA: 0x6CF691DC40
	protected virtual void ClearState() { }

	// RVA: 0x6CF691DC50 Offset: 0x18C6C50 VA: 0x6CF691DC50
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x6CF691DC58 Offset: 0x18C6C58 VA: 0x6CF691DC58
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x6CF691DCE4 Offset: 0x18C6CE4 VA: 0x6CF691DCE4
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x6CF691D6E0 Offset: 0x18C66E0 VA: 0x6CF691D6E0
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x6CF691DDA4 Offset: 0x18C6DA4 VA: 0x6CF691DDA4
	internal void CheckContinuePipeline() { }

	// RVA: 0x6CF691D774 Offset: 0x18C6774 VA: 0x6CF691D774
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x6CF691DE70 Offset: 0x18C6E70 VA: 0x6CF691DE70
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x6CF691E2E4 Offset: 0x18C72E4 VA: 0x6CF691E2E4
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x6CF691E508 Offset: 0x18C7508 VA: 0x6CF691E508
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x6CF691E510 Offset: 0x18C7510 VA: 0x6CF691E510
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691ED50 Offset: 0x18C7D50 VA: 0x6CF691ED50
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691F004 Offset: 0x18C8004 VA: 0x6CF691F004
	protected Encoding get_Encoding() { }

	// RVA: 0x6CF691F00C Offset: 0x18C800C VA: 0x6CF691F00C
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x6CF691F044 Offset: 0x18C8044 VA: 0x6CF691F044
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x6CF691DFA0 Offset: 0x18C6FA0 VA: 0x6CF691DFA0
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x6CF691E80C Offset: 0x18C780C VA: 0x6CF691E80C
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x6CF691F0E4 Offset: 0x18C80E4 VA: 0x6CF691F0E4
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class ResponseDescription : Object
{
	// Fields

	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties

	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x6CF691F20C Offset: 0x18C820C VA: 0x6CF691F20C
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x6CF691F220 Offset: 0x18C8220 VA: 0x6CF691F220
	internal bool get_PositiveCompletion() { }

	// RVA: 0x6CF691F234 Offset: 0x18C8234 VA: 0x6CF691F234
	internal bool get_TransientFailure() { }

	// RVA: 0x6CF691F248 Offset: 0x18C8248 VA: 0x6CF691F248
	internal bool get_PermanentFailure() { }

	// RVA: 0x6CF691F25C Offset: 0x18C825C VA: 0x6CF691F25C
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x6CF691F270 Offset: 0x18C8270 VA: 0x6CF691F270
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class ReceiveState : Object
{
	// Fields

	internal ResponseDescription Resp; // 0x10
	internal int ValidThrough; // 0x18
	internal Byte[] Buffer; // 0x20
	internal CommandStream Connection; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF691F04C Offset: 0x18C804C VA: 0x6CF691F04C
	internal void .ctor(CommandStream connection) { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum FtpLoginState
{
	// Fields

	public byte value__; // 0x10
	public const FtpLoginState NotLoggedIn = 0; // 0x0
	public const FtpLoginState LoggedIn = 1; // 0x0
	public const FtpLoginState LoggedInButNeedsRelogin = 2; // 0x0
	public const FtpLoginState ReloginFailed = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private enum GetPathOption
{
	// Fields

	public int value__; // 0x10
	public const GetPathOption Normal = 0; // 0x0
	public const GetPathOption AssumeFilename = 1; // 0x0
	public const GetPathOption AssumeNoFilename = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass31_0 : Object
{
	// Fields

	public FtpControlStream <>4__this; // 0x10
	public TlsStream tlsStream; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF6920ACC Offset: 0x18C9ACC VA: 0x6CF6920ACC
	public void .ctor() { }

	// RVA: 0x6CF6923B5C Offset: 0x18CCB5C VA: 0x6CF6923B5C
	internal void <PipelineCallback>b__0(IAsyncResult ar) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class FtpControlStream : CommandStream
{
	// Fields

	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties

	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x6CF691F2D8 Offset: 0x18C82D8 VA: 0x6CF691F2D8
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x6CF691F380 Offset: 0x18C8380 VA: 0x6CF691F380
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x6CF691F400 Offset: 0x18C8400 VA: 0x6CF691F400
	internal void .ctor(TcpClient client) { }

	// RVA: 0x6CF691F48C Offset: 0x18C848C VA: 0x6CF691F48C
	internal void AbortConnect() { }

	// RVA: 0x6CF691F518 Offset: 0x18C8518 VA: 0x6CF691F518
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691F914 Offset: 0x18C8914 VA: 0x6CF691F914
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691FAC4 Offset: 0x18C8AC4 VA: 0x6CF691FAC4
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x6CF691FC88 Offset: 0x18C8C88 VA: 0x6CF691FC88
	private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x6CF6920200 Offset: 0x18C9200 VA: 0x6CF6920200
	protected override void ClearState() { }

	// RVA: 0x6CF6920290 Offset: 0x18C9290 VA: 0x6CF6920290
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x6CF6921B10 Offset: 0x18CAB10 VA: 0x6CF6921B10
	protected override PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x6CF6920AD4 Offset: 0x18C9AD4 VA: 0x6CF6920AD4
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, ref bool isSocketReady) { }

	// RVA: 0x6CF6922A34 Offset: 0x18CBA34 VA: 0x6CF6922A34
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, ref string path, ref string directory, ref string filename) { }

	// RVA: 0x6CF69233DC Offset: 0x18CC3DC VA: 0x6CF69233DC
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x6CF6923504 Offset: 0x18CC504 VA: 0x6CF6923504
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x6CF6923614 Offset: 0x18CC614 VA: 0x6CF6923614
	internal long get_ContentLength() { }

	// RVA: 0x6CF692361C Offset: 0x18CC61C VA: 0x6CF692361C
	internal DateTime get_LastModified() { }

	// RVA: 0x6CF6923624 Offset: 0x18CC624 VA: 0x6CF6923624
	internal Uri get_ResponseUri() { }

	// RVA: 0x6CF692362C Offset: 0x18CC62C VA: 0x6CF692362C
	internal string get_BannerMessage() { }

	// RVA: 0x6CF6923644 Offset: 0x18CC644 VA: 0x6CF6923644
	internal string get_WelcomeMessage() { }

	// RVA: 0x6CF692365C Offset: 0x18CC65C VA: 0x6CF692365C
	internal string get_ExitMessage() { }

	// RVA: 0x6CF69215A8 Offset: 0x18CA5A8 VA: 0x6CF69215A8
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x6CF69216E0 Offset: 0x18CA6E0 VA: 0x6CF69216E0
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x6CF6921244 Offset: 0x18CA244 VA: 0x6CF6921244
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x6CF692114C Offset: 0x18CA14C VA: 0x6CF692114C
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x6CF6921A60 Offset: 0x18CAA60 VA: 0x6CF6921A60
	private string GetLoginDirectory(string str) { }

	// RVA: 0x6CF6922F30 Offset: 0x18CBF30 VA: 0x6CF6922F30
	private int GetPortV4(string responseString) { }

	// RVA: 0x6CF6923118 Offset: 0x18CC118 VA: 0x6CF6923118
	private int GetPortV6(string responseString) { }

	// RVA: 0x6CF6922BD4 Offset: 0x18CBBD4 VA: 0x6CF6922BD4
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x6CF6922D48 Offset: 0x18CBD48 VA: 0x6CF6922D48
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x6CF6922910 Offset: 0x18CB910 VA: 0x6CF6922910
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x6CF69232D0 Offset: 0x18CC2D0 VA: 0x6CF69232D0
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x6CF6923674 Offset: 0x18CC674 VA: 0x6CF6923674
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x6CF691FF10 Offset: 0x18C8F10 VA: 0x6CF691FF10
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x6CF6923A48 Offset: 0x18CCA48 VA: 0x6CF6923A48
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class FtpDataStream : Stream, ICloseEx
{
	// Fields

	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Properties

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x6CF691FF94 Offset: 0x18C8F94 VA: 0x6CF691FF94
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x6CF6923C54 Offset: 0x18CCC54 VA: 0x6CF6923C54
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF6923DDC Offset: 0x18CCDDC VA: 0x6CF6923DDC
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x6CF69241B8 Offset: 0x18CD1B8 VA: 0x6CF69241B8
	private void CheckError() { }

	// RVA: 0x6CF69241F8 Offset: 0x18CD1F8 VA: 0x6CF69241F8
	public override bool get_CanRead() { }

	// RVA: 0x6CF6924200 Offset: 0x18CD200 VA: 0x6CF6924200
	public override bool get_CanSeek() { }

	// RVA: 0x6CF6924220 Offset: 0x18CD220 VA: 0x6CF6924220
	public override bool get_CanWrite() { }

	// RVA: 0x6CF6924228 Offset: 0x18CD228 VA: 0x6CF6924228
	public override long get_Length() { }

	// RVA: 0x6CF6924248 Offset: 0x18CD248 VA: 0x6CF6924248
	public override long get_Position() { }

	// RVA: 0x6CF6924268 Offset: 0x18CD268 VA: 0x6CF6924268
	public override void set_Position(long value) { }

	// RVA: 0x6CF692428C Offset: 0x18CD28C VA: 0x6CF692428C
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF6924358 Offset: 0x18CD358 VA: 0x6CF6924358
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF692445C Offset: 0x18CD45C VA: 0x6CF692445C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6924534 Offset: 0x18CD534 VA: 0x6CF6924534
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x6CF69247E4 Offset: 0x18CD7E4 VA: 0x6CF69247E4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF692497C Offset: 0x18CD97C VA: 0x6CF692497C
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x6CF6924B1C Offset: 0x18CDB1C VA: 0x6CF6924B1C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6924C10 Offset: 0x18CDC10 VA: 0x6CF6924C10
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6924CB0 Offset: 0x18CDCB0 VA: 0x6CF6924CB0
	public override void Flush() { }

	// RVA: 0x6CF6924CD4 Offset: 0x18CDCD4 VA: 0x6CF6924CD4
	public override void SetLength(long value) { }

	// RVA: 0x6CF6924CF8 Offset: 0x18CDCF8 VA: 0x6CF6924CF8
	public override bool get_CanTimeout() { }

	// RVA: 0x6CF6924D18 Offset: 0x18CDD18 VA: 0x6CF6924D18
	public override int get_ReadTimeout() { }

	// RVA: 0x6CF6924D3C Offset: 0x18CDD3C VA: 0x6CF6924D3C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x6CF6924D60 Offset: 0x18CDD60 VA: 0x6CF6924D60
	public override int get_WriteTimeout() { }

	// RVA: 0x6CF6924D84 Offset: 0x18CDD84 VA: 0x6CF6924D84
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x6CF6924DA8 Offset: 0x18CDDA8 VA: 0x6CF6924DA8
	internal void SetSocketTimeoutOption(int timeout) { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum FtpOperation
{
	// Fields

	public int value__; // 0x10
	public const FtpOperation DownloadFile = 0; // 0x0
	public const FtpOperation ListDirectory = 1; // 0x0
	public const FtpOperation ListDirectoryDetails = 2; // 0x0
	public const FtpOperation UploadFile = 3; // 0x0
	public const FtpOperation UploadFileUnique = 4; // 0x0
	public const FtpOperation AppendFile = 5; // 0x0
	public const FtpOperation DeleteFile = 6; // 0x0
	public const FtpOperation GetDateTimestamp = 7; // 0x0
	public const FtpOperation GetFileSize = 8; // 0x0
	public const FtpOperation Rename = 9; // 0x0
	public const FtpOperation MakeDirectory = 10; // 0x0
	public const FtpOperation RemoveDirectory = 11; // 0x0
	public const FtpOperation PrintWorkingDirectory = 12; // 0x0
	public const FtpOperation Other = 13; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal enum FtpMethodFlags
{
	// Fields

	public int value__; // 0x10
	public const FtpMethodFlags None = 0; // 0x0
	public const FtpMethodFlags IsDownload = 1; // 0x0
	public const FtpMethodFlags IsUpload = 2; // 0x0
	public const FtpMethodFlags TakesParameter = 4; // 0x0
	public const FtpMethodFlags MayTakeParameter = 8; // 0x0
	public const FtpMethodFlags DoesNotTakeParameter = 16; // 0x0
	public const FtpMethodFlags ParameterIsDirectory = 32; // 0x0
	public const FtpMethodFlags ShouldParseForResponseUri = 64; // 0x0
	public const FtpMethodFlags HasHttpCommand = 128; // 0x0
	public const FtpMethodFlags MustChangeWorkingDirectoryToPath = 256; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal class FtpMethodInfo : Object
{
	// Fields

	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties

	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x6CF6924DF8 Offset: 0x18CDDF8 VA: 0x6CF6924DF8
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x6CF6922A24 Offset: 0x18CBA24 VA: 0x6CF6922A24
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x6CF6922BC4 Offset: 0x18CBBC4 VA: 0x6CF6922BC4
	internal bool get_IsCommandOnly() { }

	// RVA: 0x6CF6923A30 Offset: 0x18CCA30 VA: 0x6CF6923A30
	internal bool get_IsUpload() { }

	// RVA: 0x6CF6923A3C Offset: 0x18CCA3C VA: 0x6CF6923A3C
	internal bool get_IsDownload() { }

	// RVA: 0x6CF6921238 Offset: 0x18CA238 VA: 0x6CF6921238
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x6CF6924E3C Offset: 0x18CDE3C VA: 0x6CF6924E3C
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x6CF6924F9C Offset: 0x18CDF9C VA: 0x6CF6924F9C
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
private enum RequestStage
{
	// Fields

	public int value__; // 0x10
	public const RequestStage CheckForError = 0; // 0x0
	public const RequestStage RequestStarted = 1; // 0x0
	public const RequestStage WriteReady = 2; // 0x0
	public const RequestStage ReadReady = 3; // 0x0
	public const RequestStage ReleaseConnection = 4; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public FtpWebRequest <>4__this; // 0x38
	private TcpClient <client>5__2; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF692A550 Offset: 0x18D3550 VA: 0x6CF692A550
	private void MoveNext() { }

	// RVA: 0x6CF692A850 Offset: 0x18D3850 VA: 0x6CF692A850
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`1 <>9__114_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF692A85C Offset: 0x18D385C VA: 0x6CF692A85C
	private static void .cctor() { }

	// RVA: 0x6CF692A8B8 Offset: 0x18D38B8 VA: 0x6CF692A8B8
	public void .ctor() { }

	// RVA: 0x6CF692A8C0 Offset: 0x18D38C0 VA: 0x6CF692A8C0
	internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }

}

// Dll : System.dll
// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest
{
	// Fields

	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private bool _async; // 0x92
	private bool _aborted; // 0x93
	private bool _timedOut; // 0x94
	private Exception _exception; // 0x98
	private Queue _timerQueue; // 0xA0
	private Callback _timerCallback; // 0xA8
	private bool _enableSsl; // 0xB0
	private FtpControlStream _connection; // 0xB8
	private Stream _stream; // 0xC0
	private RequestStage _requestStage; // 0xC8
	private bool _onceFailed; // 0xCC
	private WebHeaderCollection _ftpRequestHeaders; // 0xD0
	private FtpWebResponse _ftpWebResponse; // 0xD8
	private int _readWriteTimeout; // 0xE0
	private ContextAwareResult _writeAsyncResult; // 0xE8
	private LazyAsyncResult _readAsyncResult; // 0xF0
	private LazyAsyncResult _requestCompleteAsyncResult; // 0xF8
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly Queue s_DefaultTimerQueue; // 0x8

	// Properties

	internal FtpMethodInfo MethodInfo { get; }
	public override string Method { get; set; }
	public string RenameTo { get; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; }
	public long ContentOffset { get; }
	public override long ContentLength { get; }
	public override IWebProxy Proxy { get; set; }
	internal bool Aborted { get; }
	private Queue TimerQueue { get; }
	public override RequestCachePolicy CachePolicy { set; }
	public bool UseBinary { get; }
	public bool UsePassive { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public bool EnableSsl { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool UseDefaultCredentials { get; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x6CF6925564 Offset: 0x18CE564 VA: 0x6CF6925564
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x6CF692556C Offset: 0x18CE56C VA: 0x6CF692556C
	public override string get_Method() { }

	// RVA: 0x6CF6925588 Offset: 0x18CE588 VA: 0x6CF6925588
	public override void set_Method(string value) { }

	// RVA: 0x6CF6925740 Offset: 0x18CE740 VA: 0x6CF6925740
	public string get_RenameTo() { }

	// RVA: 0x6CF6925748 Offset: 0x18CE748 VA: 0x6CF6925748
	public override ICredentials get_Credentials() { }

	// RVA: 0x6CF6925750 Offset: 0x18CE750 VA: 0x6CF6925750
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x6CF6925894 Offset: 0x18CE894 VA: 0x6CF6925894
	public override Uri get_RequestUri() { }

	// RVA: 0x6CF692589C Offset: 0x18CE89C VA: 0x6CF692589C
	public override int get_Timeout() { }

	// RVA: 0x6CF69258A4 Offset: 0x18CE8A4 VA: 0x6CF69258A4
	internal int get_RemainingTimeout() { }

	// RVA: 0x6CF69258AC Offset: 0x18CE8AC VA: 0x6CF69258AC
	public int get_ReadWriteTimeout() { }

	// RVA: 0x6CF69258B4 Offset: 0x18CE8B4 VA: 0x6CF69258B4
	public long get_ContentOffset() { }

	// RVA: 0x6CF69258BC Offset: 0x18CE8BC VA: 0x6CF69258BC
	public override long get_ContentLength() { }

	// RVA: 0x6CF69258C4 Offset: 0x18CE8C4 VA: 0x6CF69258C4
	public override IWebProxy get_Proxy() { }

	// RVA: 0x6CF69258CC Offset: 0x18CE8CC VA: 0x6CF69258CC
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x6CF6925930 Offset: 0x18CE930 VA: 0x6CF6925930
	internal bool get_Aborted() { }

	// RVA: 0x6CF6925938 Offset: 0x18CE938 VA: 0x6CF6925938
	internal void .ctor(Uri uri) { }

	// RVA: 0x6CF6925D54 Offset: 0x18CED54 VA: 0x6CF6925D54
	public override WebResponse GetResponse() { }

	// RVA: 0x6CF6927704 Offset: 0x18D0704 VA: 0x6CF6927704
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x6CF6927DBC Offset: 0x18D0DBC VA: 0x6CF6927DBC
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6926998 Offset: 0x18CF998 VA: 0x6CF6926998
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x6CF6928A80 Offset: 0x18D1A80 VA: 0x6CF6928A80
	private Exception TranslateConnectException(Exception e) { }

	// RVA: 0x6CF69281BC Offset: 0x18D11BC VA: 0x6CF69281BC
	private void CreateConnectionAsync() { }

	// RVA: 0x6CF692824C Offset: 0x18D124C VA: 0x6CF692824C
	private FtpControlStream CreateConnection() { }

	// RVA: 0x6CF6928400 Offset: 0x18D1400 VA: 0x6CF6928400
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x6CF6928BEC Offset: 0x18D1BEC VA: 0x6CF6928BEC
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x6CF6928B80 Offset: 0x18D1B80 VA: 0x6CF6928B80
	private Queue get_TimerQueue() { }

	// RVA: 0x6CF6928810 Offset: 0x18D1810 VA: 0x6CF6928810
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x6CF69273A0 Offset: 0x18D03A0 VA: 0x6CF69273A0
	private void SetException(Exception exception) { }

	// RVA: 0x6CF69264D8 Offset: 0x18CF4D8 VA: 0x6CF69264D8
	private void CheckError() { }

	// RVA: 0x6CF691D630 Offset: 0x18C6630 VA: 0x6CF691D630
	internal void RequestCallback(object obj) { }

	// RVA: 0x6CF6929720 Offset: 0x18D2720 VA: 0x6CF6929720
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x6CF6928D08 Offset: 0x18D1D08 VA: 0x6CF6928D08
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x6CF6926564 Offset: 0x18CF564 VA: 0x6CF6926564
	private RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x6CF6929AE0 Offset: 0x18D2AE0 VA: 0x6CF6929AE0
	public override void Abort() { }

	// RVA: 0x6CF6929F74 Offset: 0x18D2F74 VA: 0x6CF6929F74
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x6CF6929FD8 Offset: 0x18D2FD8 VA: 0x6CF6929FD8
	public bool get_UseBinary() { }

	// RVA: 0x6CF6929FE0 Offset: 0x18D2FE0 VA: 0x6CF6929FE0
	public bool get_UsePassive() { }

	// RVA: 0x6CF692010C Offset: 0x18C910C VA: 0x6CF692010C
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x6CF6929FE8 Offset: 0x18D2FE8 VA: 0x6CF6929FE8
	public bool get_EnableSsl() { }

	// RVA: 0x6CF6929FF0 Offset: 0x18D2FF0 VA: 0x6CF6929FF0
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF692A0B4 Offset: 0x18D30B4 VA: 0x6CF692A0B4
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF6925728 Offset: 0x18CE728 VA: 0x6CF6925728
	private bool get_InUse() { }

	// RVA: 0x6CF6926EC4 Offset: 0x18CFEC4 VA: 0x6CF6926EC4
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x6CF692A308 Offset: 0x18D3308 VA: 0x6CF692A308
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x6CF692A384 Offset: 0x18D3384 VA: 0x6CF692A384
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class FtpWebRequestCreator : Object, IWebRequestCreate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF692A914 Offset: 0x18D3914 VA: 0x6CF692A914
	internal void .ctor() { }

	// RVA: 0x6CF692A91C Offset: 0x18D391C VA: 0x6CF692A91C
	public WebRequest Create(Uri uri) { }

}

// Dll : System.dll
// Namespace: 
internal sealed class EmptyStream : MemoryStream
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF692A9D4 Offset: 0x18D39D4 VA: 0x6CF692A9D4
	internal void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
public class FtpWebResponse : WebResponse, IDisposable
{
	// Fields

	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties

	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }

	// Methods

	// RVA: 0x6CF692A1EC Offset: 0x18D31EC VA: 0x6CF692A1EC
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x6CF6928CF8 Offset: 0x18D1CF8 VA: 0x6CF6928CF8
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x6CF692A974 Offset: 0x18D3974 VA: 0x6CF692A974
	public override Stream GetResponseStream() { }

	// RVA: 0x6CF692A158 Offset: 0x18D3158 VA: 0x6CF692A158
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x6CF692AA70 Offset: 0x18D3A70 VA: 0x6CF692AA70
	public override void Close() { }

	// RVA: 0x6CF692AB54 Offset: 0x18D3B54 VA: 0x6CF692AB54
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF692AC60 Offset: 0x18D3C60 VA: 0x6CF692AC60
	public override Uri get_ResponseUri() { }

	// RVA: 0x6CF692AC68 Offset: 0x18D3C68 VA: 0x6CF692AC68
	public FtpStatusCode get_StatusCode() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class NetworkStreamWrapper : Stream
{
	// Fields

	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties

	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x6CF691D294 Offset: 0x18C6294 VA: 0x6CF691D294
	internal void .ctor(TcpClient client) { }

	// RVA: 0x6CF6920090 Offset: 0x18C9090 VA: 0x6CF6920090
	protected bool get_UsingSecureStream() { }

	// RVA: 0x6CF691F86C Offset: 0x18C886C VA: 0x6CF691F86C
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x6CF692158C Offset: 0x18CA58C VA: 0x6CF692158C
	internal Socket get_Socket() { }

	// RVA: 0x6CF692AC70 Offset: 0x18D3C70 VA: 0x6CF692AC70
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x6CF692AC78 Offset: 0x18D3C78 VA: 0x6CF692AC78
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x6CF692AC80 Offset: 0x18D3C80 VA: 0x6CF692AC80
	public override bool get_CanRead() { }

	// RVA: 0x6CF692ACA0 Offset: 0x18D3CA0 VA: 0x6CF692ACA0
	public override bool get_CanSeek() { }

	// RVA: 0x6CF692ACC0 Offset: 0x18D3CC0 VA: 0x6CF692ACC0
	public override bool get_CanWrite() { }

	// RVA: 0x6CF692ACE0 Offset: 0x18D3CE0 VA: 0x6CF692ACE0
	public override bool get_CanTimeout() { }

	// RVA: 0x6CF692AD00 Offset: 0x18D3D00 VA: 0x6CF692AD00
	public override int get_ReadTimeout() { }

	// RVA: 0x6CF692AD24 Offset: 0x18D3D24 VA: 0x6CF692AD24
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x6CF692AD48 Offset: 0x18D3D48 VA: 0x6CF692AD48
	public override int get_WriteTimeout() { }

	// RVA: 0x6CF692AD6C Offset: 0x18D3D6C VA: 0x6CF692AD6C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x6CF692AD90 Offset: 0x18D3D90 VA: 0x6CF692AD90
	public override long get_Length() { }

	// RVA: 0x6CF692ADB0 Offset: 0x18D3DB0 VA: 0x6CF692ADB0
	public override long get_Position() { }

	// RVA: 0x6CF692ADD0 Offset: 0x18D3DD0 VA: 0x6CF692ADD0
	public override void set_Position(long value) { }

	// RVA: 0x6CF692ADF4 Offset: 0x18D3DF4 VA: 0x6CF692ADF4
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF692AE18 Offset: 0x18D3E18 VA: 0x6CF692AE18
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF692AE3C Offset: 0x18D3E3C VA: 0x6CF692AE3C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF692AE60 Offset: 0x18D3E60 VA: 0x6CF692AE60
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF691E7D4 Offset: 0x18C77D4 VA: 0x6CF691E7D4
	internal void CloseSocket() { }

	// RVA: 0x6CF691D4FC Offset: 0x18C64FC VA: 0x6CF691D4FC
	public void Close(int timeout) { }

	// RVA: 0x6CF692AF0C Offset: 0x18D3F0C VA: 0x6CF692AF0C
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF692AF30 Offset: 0x18D3F30 VA: 0x6CF692AF30
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF692AF54 Offset: 0x18D3F54 VA: 0x6CF692AF54
	public override Task`1 ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF692AF78 Offset: 0x18D3F78 VA: 0x6CF692AF78
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF692AF9C Offset: 0x18D3F9C VA: 0x6CF692AF9C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x6CF692AFC0 Offset: 0x18D3FC0 VA: 0x6CF692AFC0
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF692AFE4 Offset: 0x18D3FE4 VA: 0x6CF692AFE4
	public override void Flush() { }

	// RVA: 0x6CF692B008 Offset: 0x18D4008 VA: 0x6CF692B008
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF692B02C Offset: 0x18D402C VA: 0x6CF692B02C
	public override void SetLength(long value) { }

	// RVA: 0x6CF69283B0 Offset: 0x18D13B0 VA: 0x6CF69283B0
	internal void SetSocketTimeoutOption(int timeout) { }

}

// Dll : System.dll
// Namespace: System.Net
public enum SecurityProtocolType
{
	// Fields

	public int value__; // 0x10
	public const SecurityProtocolType SystemDefault = 0; // 0x0
	public const SecurityProtocolType Ssl3 = 48; // 0x0
	public const SecurityProtocolType Tls = 192; // 0x0
	public const SecurityProtocolType Tls11 = 768; // 0x0
	public const SecurityProtocolType Tls12 = 3072; // 0x0
	public const SecurityProtocolType Tls13 = 12288; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public class Authorization : Object
{
	// Fields

	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties

	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x6CF692B050 Offset: 0x18D4050 VA: 0x6CF692B050
	public void .ctor(string token) { }

	// RVA: 0x6CF692B0F4 Offset: 0x18D40F4 VA: 0x6CF692B0F4
	public void .ctor(string token, bool finished) { }

	// RVA: 0x6CF692B188 Offset: 0x18D4188 VA: 0x6CF692B188
	public string get_Message() { }

	// RVA: 0x6CF692B190 Offset: 0x18D4190 VA: 0x6CF692B190
	public bool get_Complete() { }

}

// Dll : System.dll
// Namespace: System.Net
public class CredentialCache : Object
{
	// Fields


	// Properties

	public static ICredentials DefaultCredentials { get; }
	public static NetworkCredential DefaultNetworkCredentials { get; }

	// Methods

	// RVA: 0x6CF692B198 Offset: 0x18D4198 VA: 0x6CF692B198
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x6CF692B1F0 Offset: 0x18D41F0 VA: 0x6CF692B1F0
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class SystemNetworkCredential : NetworkCredential
{
	// Fields

	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF692B248 Offset: 0x18D4248 VA: 0x6CF692B248
	private void .ctor() { }

	// RVA: 0x6CF692B2A0 Offset: 0x18D42A0 VA: 0x6CF692B2A0
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
public class DnsEndPoint : EndPoint
{
	// Fields

	private string m_Host; // 0x10
	private int m_Port; // 0x18

	// Properties

	public string Host { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x6CF692B2F8 Offset: 0x18D42F8 VA: 0x6CF692B2F8
	public string get_Host() { }

	// RVA: 0x6CF692B300 Offset: 0x18D4300 VA: 0x6CF692B300
	public int get_Port() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public abstract class EndPoint : Object
{
	// Fields


	// Properties

	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x6CF692B308 Offset: 0x18D4308 VA: 0x6CF692B308
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x6CF692B3AC Offset: 0x18D43AC VA: 0x6CF692B3AC
	public virtual SocketAddress Serialize() { }

	// RVA: 0x6CF692B450 Offset: 0x18D4450 VA: 0x6CF692B450
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x6CF691CC14 Offset: 0x18C5C14 VA: 0x6CF691CC14
	protected void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
public enum FtpStatusCode
{
	// Fields

	public int value__; // 0x10
	public const FtpStatusCode Undefined = 0; // 0x0
	public const FtpStatusCode RestartMarker = 110; // 0x0
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120; // 0x0
	public const FtpStatusCode DataAlreadyOpen = 125; // 0x0
	public const FtpStatusCode OpeningData = 150; // 0x0
	public const FtpStatusCode CommandOK = 200; // 0x0
	public const FtpStatusCode CommandExtraneous = 202; // 0x0
	public const FtpStatusCode DirectoryStatus = 212; // 0x0
	public const FtpStatusCode FileStatus = 213; // 0x0
	public const FtpStatusCode SystemType = 215; // 0x0
	public const FtpStatusCode SendUserCommand = 220; // 0x0
	public const FtpStatusCode ClosingControl = 221; // 0x0
	public const FtpStatusCode ClosingData = 226; // 0x0
	public const FtpStatusCode EnteringPassive = 227; // 0x0
	public const FtpStatusCode LoggedInProceed = 230; // 0x0
	public const FtpStatusCode ServerWantsSecureSession = 234; // 0x0
	public const FtpStatusCode FileActionOK = 250; // 0x0
	public const FtpStatusCode PathnameCreated = 257; // 0x0
	public const FtpStatusCode SendPasswordCommand = 331; // 0x0
	public const FtpStatusCode NeedLoginAccount = 332; // 0x0
	public const FtpStatusCode FileCommandPending = 350; // 0x0
	public const FtpStatusCode ServiceNotAvailable = 421; // 0x0
	public const FtpStatusCode CantOpenData = 425; // 0x0
	public const FtpStatusCode ConnectionClosed = 426; // 0x0
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450; // 0x0
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451; // 0x0
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452; // 0x0
	public const FtpStatusCode CommandSyntaxError = 500; // 0x0
	public const FtpStatusCode ArgumentSyntaxError = 501; // 0x0
	public const FtpStatusCode CommandNotImplemented = 502; // 0x0
	public const FtpStatusCode BadCommandSequence = 503; // 0x0
	public const FtpStatusCode NotLoggedIn = 530; // 0x0
	public const FtpStatusCode AccountNeeded = 532; // 0x0
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550; // 0x0
	public const FtpStatusCode ActionAbortedUnknownPageType = 551; // 0x0
	public const FtpStatusCode FileActionAborted = 552; // 0x0
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public enum HttpRequestHeader
{
	// Fields

	public int value__; // 0x10
	public const HttpRequestHeader CacheControl = 0; // 0x0
	public const HttpRequestHeader Connection = 1; // 0x0
	public const HttpRequestHeader Date = 2; // 0x0
	public const HttpRequestHeader KeepAlive = 3; // 0x0
	public const HttpRequestHeader Pragma = 4; // 0x0
	public const HttpRequestHeader Trailer = 5; // 0x0
	public const HttpRequestHeader TransferEncoding = 6; // 0x0
	public const HttpRequestHeader Upgrade = 7; // 0x0
	public const HttpRequestHeader Via = 8; // 0x0
	public const HttpRequestHeader Warning = 9; // 0x0
	public const HttpRequestHeader Allow = 10; // 0x0
	public const HttpRequestHeader ContentLength = 11; // 0x0
	public const HttpRequestHeader ContentType = 12; // 0x0
	public const HttpRequestHeader ContentEncoding = 13; // 0x0
	public const HttpRequestHeader ContentLanguage = 14; // 0x0
	public const HttpRequestHeader ContentLocation = 15; // 0x0
	public const HttpRequestHeader ContentMd5 = 16; // 0x0
	public const HttpRequestHeader ContentRange = 17; // 0x0
	public const HttpRequestHeader Expires = 18; // 0x0
	public const HttpRequestHeader LastModified = 19; // 0x0
	public const HttpRequestHeader Accept = 20; // 0x0
	public const HttpRequestHeader AcceptCharset = 21; // 0x0
	public const HttpRequestHeader AcceptEncoding = 22; // 0x0
	public const HttpRequestHeader AcceptLanguage = 23; // 0x0
	public const HttpRequestHeader Authorization = 24; // 0x0
	public const HttpRequestHeader Cookie = 25; // 0x0
	public const HttpRequestHeader Expect = 26; // 0x0
	public const HttpRequestHeader From = 27; // 0x0
	public const HttpRequestHeader Host = 28; // 0x0
	public const HttpRequestHeader IfMatch = 29; // 0x0
	public const HttpRequestHeader IfModifiedSince = 30; // 0x0
	public const HttpRequestHeader IfNoneMatch = 31; // 0x0
	public const HttpRequestHeader IfRange = 32; // 0x0
	public const HttpRequestHeader IfUnmodifiedSince = 33; // 0x0
	public const HttpRequestHeader MaxForwards = 34; // 0x0
	public const HttpRequestHeader ProxyAuthorization = 35; // 0x0
	public const HttpRequestHeader Referer = 36; // 0x0
	public const HttpRequestHeader Range = 37; // 0x0
	public const HttpRequestHeader Te = 38; // 0x0
	public const HttpRequestHeader Translate = 39; // 0x0
	public const HttpRequestHeader UserAgent = 40; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public interface IAuthenticationModule
{
	// Fields


	// Properties

	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: 0x6CF5BD6E80 Offset: 0xB7FE80 VA: 0x6CF5BD6E80
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x6CF5BD6E44 Offset: 0xB7FE44 VA: 0x6CF5BD6E44
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_AuthenticationType() { }

}

// Dll : System.dll
// Namespace: System.Net
public interface ICertificatePolicy
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

// Dll : System.dll
// Namespace: System.Net
public interface ICredentials
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD6E44 Offset: 0xB7FE44 VA: 0x6CF5BD6E44
	public abstract NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Dll : System.dll
// Namespace: System.Net
public class IPHostEntry : Object
{
	// Fields

	private string hostName; // 0x10
	private String[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties

	public string HostName { get; set; }
	public String[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x6CF692B474 Offset: 0x18D4474 VA: 0x6CF692B474
	public string get_HostName() { }

	// RVA: 0x6CF692B47C Offset: 0x18D447C VA: 0x6CF692B47C
	public void set_HostName(string value) { }

	// RVA: 0x6CF692B484 Offset: 0x18D4484 VA: 0x6CF692B484
	public void set_Aliases(String[] value) { }

	// RVA: 0x6CF692B48C Offset: 0x18D448C VA: 0x6CF692B48C
	public IPAddress[] get_AddressList() { }

	// RVA: 0x6CF692B494 Offset: 0x18D4494 VA: 0x6CF692B494
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x6CF692B49C Offset: 0x18D449C VA: 0x6CF692B49C
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
public interface IWebRequestCreate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public abstract WebRequest Create(Uri uri) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class InternalException : SystemException
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF691DE58 Offset: 0x18C6E58 VA: 0x6CF691DE58
	internal void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class NclUtilities : Object
{
	// Fields

	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties

	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x6CF692B4AC Offset: 0x18D44AC VA: 0x6CF692B4AC
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x6CF692B56C Offset: 0x18D456C VA: 0x6CF692B56C
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x6CF692BABC Offset: 0x18D4ABC VA: 0x6CF692BABC
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x6CF692B5F8 Offset: 0x18D45F8 VA: 0x6CF692B5F8
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x6CF692BAD4 Offset: 0x18D4AD4 VA: 0x6CF692BAD4
	private static object get_LocalAddressesLock() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class ValidationHelper : Object
{
	// Fields

	public static String[] EmptyArray; // 0x0
	internal static readonly Char[] InvalidMethodChars; // 0x8
	internal static readonly Char[] InvalidParamChars; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF692B0E0 Offset: 0x18D40E0 VA: 0x6CF692B0E0
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x6CF692BB70 Offset: 0x18D4B70 VA: 0x6CF692BB70
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x6CF692BB8C Offset: 0x18D4B8C VA: 0x6CF692BB8C
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x6CF692BB98 Offset: 0x18D4B98 VA: 0x6CF692BB98
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class ExceptionHelper : Object
{
	// Fields


	// Properties

	internal static NotImplementedException MethodNotImplementedException { get; }
	internal static NotImplementedException PropertyNotImplementedException { get; }
	internal static WebException TimeoutException { get; }
	internal static NotSupportedException PropertyNotSupportedException { get; }
	internal static WebException RequestAbortedException { get; }

	// Methods

	// RVA: 0x6CF692B3D0 Offset: 0x18D43D0 VA: 0x6CF692B3D0
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x6CF692B32C Offset: 0x18D432C VA: 0x6CF692B32C
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x6CF69264EC Offset: 0x18CF4EC VA: 0x6CF69264EC
	internal static WebException get_TimeoutException() { }

	// RVA: 0x6CF692A0D8 Offset: 0x18D30D8 VA: 0x6CF692A0D8
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x6CF692334C Offset: 0x18CC34C VA: 0x6CF692334C
	internal static WebException get_RequestAbortedException() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebRequestPrefixElement : Object
{
	// Fields

	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties

	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0x6CF692BC9C Offset: 0x18D4C9C VA: 0x6CF692BC9C
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x6CF692BE94 Offset: 0x18D4E94 VA: 0x6CF692BE94
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x6CF692BE9C Offset: 0x18D4E9C VA: 0x6CF692BE9C
	public void .ctor(string P, IWebRequestCreate C) { }

}

// Dll : System.dll
// Namespace: System.Net
public sealed class HttpContinueDelegate : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF692BEC8 Offset: 0x18D4EC8 VA: 0x6CF692BEC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF692BF54 Offset: 0x18D4F54 VA: 0x6CF692BF54
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum TriState
{
	// Fields

	public int value__; // 0x10
	public const TriState Unspecified = 4294967295; // 0x0
	public const TriState False = 0; // 0x0
	public const TriState True = 1; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public class NetworkCredential : Object, ICredentials
{
	// Fields

	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties

	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x6CF6925CEC Offset: 0x18CECEC VA: 0x6CF6925CEC
	public void .ctor(string userName, string password) { }

	// RVA: 0x6CF692A494 Offset: 0x18D3494 VA: 0x6CF692A494
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x6CF6922A08 Offset: 0x18CBA08 VA: 0x6CF6922A08
	public string get_UserName() { }

	// RVA: 0x6CF692BF68 Offset: 0x18D4F68 VA: 0x6CF692BF68
	public void set_UserName(string value) { }

	// RVA: 0x6CF6922A18 Offset: 0x18CBA18 VA: 0x6CF6922A18
	public string get_Password() { }

	// RVA: 0x6CF692BFC0 Offset: 0x18D4FC0 VA: 0x6CF692BFC0
	public void set_Password(string value) { }

	// RVA: 0x6CF6922A10 Offset: 0x18CBA10 VA: 0x6CF6922A10
	public string get_Domain() { }

	// RVA: 0x6CF692BFE0 Offset: 0x18D4FE0 VA: 0x6CF692BFE0
	public void set_Domain(string value) { }

	// RVA: 0x6CF692C044 Offset: 0x18D5044 VA: 0x6CF692C044
	internal string InternalGetUserName() { }

	// RVA: 0x6CF692C038 Offset: 0x18D5038 VA: 0x6CF692C038
	internal string InternalGetPassword() { }

	// RVA: 0x6CF692C04C Offset: 0x18D504C VA: 0x6CF692C04C
	internal string InternalGetDomain() { }

	// RVA: 0x6CF692C054 Offset: 0x18D5054 VA: 0x6CF692C054
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class ProtocolViolationException : InvalidOperationException, ISerializable
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF692C058 Offset: 0x18D5058 VA: 0x6CF692C058
	public void .ctor() { }

	// RVA: 0x6CF692C060 Offset: 0x18D5060 VA: 0x6CF692C060
	public void .ctor(string message) { }

	// RVA: 0x6CF692C068 Offset: 0x18D5068 VA: 0x6CF692C068
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692C070 Offset: 0x18D5070 VA: 0x6CF692C070
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692C078 Offset: 0x18D5078 VA: 0x6CF692C078
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Dll : System.dll
// Namespace: System.Net
public class SocketAddress : Object
{
	// Fields

	internal int m_Size; // 0x10
	internal Byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties

	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x6CF691CF8C Offset: 0x18C5F8C VA: 0x6CF691CF8C
	public AddressFamily get_Family() { }

	// RVA: 0x6CF692C080 Offset: 0x18D5080 VA: 0x6CF692C080
	public int get_Size() { }

	// RVA: 0x6CF692C088 Offset: 0x18D5088 VA: 0x6CF692C088
	public byte get_Item(int offset) { }

	// RVA: 0x6CF692C0FC Offset: 0x18D50FC VA: 0x6CF692C0FC
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x6CF692C218 Offset: 0x18D5218 VA: 0x6CF692C218
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x6CF691CD4C Offset: 0x18C5D4C VA: 0x6CF691CD4C
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x6CF692C470 Offset: 0x18D5470 VA: 0x6CF692C470
	internal IPAddress GetIPAddress() { }

	// RVA: 0x6CF691CFBC Offset: 0x18C5FBC VA: 0x6CF691CFBC
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x6CF692C654 Offset: 0x18D5654 VA: 0x6CF692C654
	public override bool Equals(object comparand) { }

	// RVA: 0x6CF692C740 Offset: 0x18D5740 VA: 0x6CF692C740
	public override int GetHashCode() { }

	// RVA: 0x6CF692C870 Offset: 0x18D5870 VA: 0x6CF692C870
	public override string ToString() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable
{
	// Fields

	private WebExceptionStatus m_Status; // 0x8C
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties

	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x6CF692CAA8 Offset: 0x18D5AA8 VA: 0x6CF692CAA8
	public void .ctor() { }

	// RVA: 0x6CF691E4F4 Offset: 0x18C74F4 VA: 0x6CF691E4F4
	public void .ctor(string message) { }

	// RVA: 0x6CF6928CE8 Offset: 0x18D1CE8 VA: 0x6CF6928CE8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x6CF691F900 Offset: 0x18C8900 VA: 0x6CF691F900
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x6CF692CAB8 Offset: 0x18D5AB8 VA: 0x6CF692CAB8
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x6CF691DCD0 Offset: 0x18C6CD0 VA: 0x6CF691DCD0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x6CF692CAEC Offset: 0x18D5AEC VA: 0x6CF692CAEC
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x6CF692CAD4 Offset: 0x18D5AD4 VA: 0x6CF692CAD4
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x6CF692CBCC Offset: 0x18D5BCC VA: 0x6CF692CBCC
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x6CF692CCBC Offset: 0x18D5CBC VA: 0x6CF692CCBC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692CCCC Offset: 0x18D5CCC VA: 0x6CF692CCCC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692CCD8 Offset: 0x18D5CD8 VA: 0x6CF692CCD8
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692CCE0 Offset: 0x18D5CE0 VA: 0x6CF692CCE0
	public WebExceptionStatus get_Status() { }

	// RVA: 0x6CF692CCE8 Offset: 0x18D5CE8 VA: 0x6CF692CCE8
	public WebResponse get_Response() { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum WebExceptionInternalStatus
{
	// Fields

	public int value__; // 0x10
	public const WebExceptionInternalStatus RequestFatal = 0; // 0x0
	public const WebExceptionInternalStatus ServicePointFatal = 1; // 0x0
	public const WebExceptionInternalStatus Recoverable = 2; // 0x0
	public const WebExceptionInternalStatus Isolated = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
public enum WebExceptionStatus
{
	// Fields

	public int value__; // 0x10
	public const WebExceptionStatus Success = 0; // 0x0
	public const WebExceptionStatus NameResolutionFailure = 1; // 0x0
	public const WebExceptionStatus ConnectFailure = 2; // 0x0
	public const WebExceptionStatus ReceiveFailure = 3; // 0x0
	public const WebExceptionStatus SendFailure = 4; // 0x0
	public const WebExceptionStatus PipelineFailure = 5; // 0x0
	public const WebExceptionStatus RequestCanceled = 6; // 0x0
	public const WebExceptionStatus ProtocolError = 7; // 0x0
	public const WebExceptionStatus ConnectionClosed = 8; // 0x0
	public const WebExceptionStatus TrustFailure = 9; // 0x0
	public const WebExceptionStatus SecureChannelFailure = 10; // 0x0
	public const WebExceptionStatus ServerProtocolViolation = 11; // 0x0
	public const WebExceptionStatus KeepAliveFailure = 12; // 0x0
	public const WebExceptionStatus Pending = 13; // 0x0
	public const WebExceptionStatus Timeout = 14; // 0x0
	public const WebExceptionStatus ProxyNameResolutionFailure = 15; // 0x0
	public const WebExceptionStatus UnknownError = 16; // 0x0
	public const WebExceptionStatus MessageLengthLimitExceeded = 17; // 0x0
	public const WebExceptionStatus CacheEntryNotFound = 18; // 0x0
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19; // 0x0
	public const WebExceptionStatus RequestProhibitedByProxy = 20; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal static class WebExceptionMapping : Object
{
	// Fields

	private static readonly String[] s_Mapping; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF692CCF0 Offset: 0x18D5CF0 VA: 0x6CF692CCF0
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x6CF692CE80 Offset: 0x18D5E80 VA: 0x6CF692CE80
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum WebHeaderCollectionType
{
	// Fields

	public ushort value__; // 0x10
	public const WebHeaderCollectionType Unknown = 0; // 0x0
	public const WebHeaderCollectionType WebRequest = 1; // 0x0
	public const WebHeaderCollectionType WebResponse = 2; // 0x0
	public const WebHeaderCollectionType HttpWebRequest = 3; // 0x0
	public const WebHeaderCollectionType HttpWebResponse = 4; // 0x0
	public const WebHeaderCollectionType HttpListenerRequest = 5; // 0x0
	public const WebHeaderCollectionType HttpListenerResponse = 6; // 0x0
	public const WebHeaderCollectionType FtpWebRequest = 7; // 0x0
	public const WebHeaderCollectionType FtpWebResponse = 8; // 0x0
	public const WebHeaderCollectionType FileWebRequest = 9; // 0x0
	public const WebHeaderCollectionType FileWebResponse = 10; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private enum RfcChar
{
	// Fields

	public byte value__; // 0x10
	public const RfcChar High = 0; // 0x0
	public const RfcChar Reg = 1; // 0x0
	public const RfcChar Ctl = 2; // 0x0
	public const RfcChar CR = 3; // 0x0
	public const RfcChar LF = 4; // 0x0
	public const RfcChar WS = 5; // 0x0
	public const RfcChar Colon = 6; // 0x0
	public const RfcChar Delim = 7; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable
{
	// Fields

	private static readonly HeaderInfoTable HInfo; // 0x0
	private String[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly String[] s_CommonHeaderNames; // 0x8
	private static readonly SByte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly Char[] HttpTrimCharacters; // 0x18
	private static RfcChar[] RfcCharMap; // 0x20

	// Properties

	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x6CF692CEE8 Offset: 0x18D5EE8 VA: 0x6CF692CEE8
	private void NormalizeCommonHeaders() { }

	// RVA: 0x6CF692CFE8 Offset: 0x18D5FE8 VA: 0x6CF692CFE8
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x6CF692D084 Offset: 0x18D6084 VA: 0x6CF692D084
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x6CF692D130 Offset: 0x18D6130 VA: 0x6CF692D130
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x6CF692D170 Offset: 0x18D6170 VA: 0x6CF692D170
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x6CF692D260 Offset: 0x18D6260 VA: 0x6CF692D260
	internal void AddInternal(string name, string value) { }

	// RVA: 0x6CF692D2B4 Offset: 0x18D62B4 VA: 0x6CF692D2B4
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x6CF692D308 Offset: 0x18D6308 VA: 0x6CF692D308
	internal void RemoveInternal(string name) { }

	// RVA: 0x6CF692D364 Offset: 0x18D6364 VA: 0x6CF692D364
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x6CF692D6F4 Offset: 0x18D66F4 VA: 0x6CF692D6F4
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x6CF692D778 Offset: 0x18D6778 VA: 0x6CF692D778
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x6CF692D8EC Offset: 0x18D68EC VA: 0x6CF692D8EC
	public override void Add(string name, string value) { }

	// RVA: 0x6CF692DA9C Offset: 0x18D6A9C VA: 0x6CF692DA9C
	public void Add(string header) { }

	// RVA: 0x6CF692DD6C Offset: 0x18D6D6C VA: 0x6CF692DD6C
	public override void Set(string name, string value) { }

	// RVA: 0x6CF692DF94 Offset: 0x18D6F94 VA: 0x6CF692DF94
	internal void SetInternal(string name, string value) { }

	// RVA: 0x6CF692E1B0 Offset: 0x18D71B0 VA: 0x6CF692E1B0
	public override void Remove(string name) { }

	// RVA: 0x6CF692E2E8 Offset: 0x18D72E8 VA: 0x6CF692E2E8
	public override String[] GetValues(string header) { }

	// RVA: 0x6CF692E4EC Offset: 0x18D74EC VA: 0x6CF692E4EC
	public override string ToString() { }

	// RVA: 0x6CF692E548 Offset: 0x18D7548 VA: 0x6CF692E548
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x6CF692A050 Offset: 0x18D3050 VA: 0x6CF692A050
	public void .ctor() { }

	// RVA: 0x6CF692E7F4 Offset: 0x18D77F4 VA: 0x6CF692E7F4
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x6CF692E8D8 Offset: 0x18D78D8 VA: 0x6CF692E8D8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692EA98 Offset: 0x18D7A98 VA: 0x6CF692EA98
	public override void OnDeserialization(object sender) { }

	// RVA: 0x6CF692EA9C Offset: 0x18D7A9C VA: 0x6CF692EA9C
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692EC1C Offset: 0x18D7C1C VA: 0x6CF692EC1C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF692EC28 Offset: 0x18D7C28 VA: 0x6CF692EC28
	public override string Get(string name) { }

	// RVA: 0x6CF692EF54 Offset: 0x18D7F54 VA: 0x6CF692EF54
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x6CF692EFC8 Offset: 0x18D7FC8 VA: 0x6CF692EFC8
	public override int get_Count() { }

	// RVA: 0x6CF692EFF8 Offset: 0x18D7FF8 VA: 0x6CF692EFF8
	public override string Get(int index) { }

	// RVA: 0x6CF692F038 Offset: 0x18D8038 VA: 0x6CF692F038
	public override string GetKey(int index) { }

	// RVA: 0x6CF692F078 Offset: 0x18D8078 VA: 0x6CF692F078
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class CaseInsensitiveAscii : Object, IEqualityComparer, IComparer
{
	// Fields

	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF692F4CC Offset: 0x18D84CC VA: 0x6CF692F4CC
	public int GetHashCode(object myObject) { }

	// RVA: 0x6CF692F5E4 Offset: 0x18D85E4 VA: 0x6CF692F5E4
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x6CF692F754 Offset: 0x18D8754 VA: 0x6CF692F754
	private int FastGetHashCode(string myString) { }

	// RVA: 0x6CF692F844 Offset: 0x18D8844 VA: 0x6CF692F844
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x6CF692F9C4 Offset: 0x18D89C4 VA: 0x6CF692F9C4
	public void .ctor() { }

	// RVA: 0x6CF692F9CC Offset: 0x18D89CC VA: 0x6CF692F9CC
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
internal class DesignerWebRequestCreate : Object, IWebRequestCreate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6930F0C Offset: 0x18D9F0C VA: 0x6CF6930F0C
	public WebRequest Create(Uri uri) { }

	// RVA: 0x6CF6930E10 Offset: 0x18D9E10 VA: 0x6CF6930E10
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass79_0 : Object
{
	// Fields

	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69308CC Offset: 0x18D98CC VA: 0x6CF69308CC
	public void .ctor() { }

	// RVA: 0x6CF6930F60 Offset: 0x18D9F60 VA: 0x6CF6930F60
	internal Task`1 <GetResponseAsync>b__1() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	// Fields

	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties

	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }

	// Methods

	// RVA: 0x6CF692FA80 Offset: 0x18D8A80 VA: 0x6CF692FA80
	private static object get_InternalSyncObject() { }

	// RVA: 0x6CF692FB4C Offset: 0x18D8B4C VA: 0x6CF692FB4C
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x6CF692FF50 Offset: 0x18D8F50 VA: 0x6CF692FF50
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x6CF6930020 Offset: 0x18D9020 VA: 0x6CF6930020
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x6CF692FDBC Offset: 0x18D8DBC VA: 0x6CF692FDBC
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x6CF69300F8 Offset: 0x18D90F8 VA: 0x6CF69300F8
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x6CF6930328 Offset: 0x18D9328 VA: 0x6CF6930328
	protected void .ctor() { }

	// RVA: 0x6CF693034C Offset: 0x18D934C VA: 0x6CF693034C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6930354 Offset: 0x18D9354 VA: 0x6CF6930354
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6930360 Offset: 0x18D9360 VA: 0x6CF6930360
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6930364 Offset: 0x18D9364 VA: 0x6CF6930364
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x6CF6930368 Offset: 0x18D9368 VA: 0x6CF6930368
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x6CF6930418 Offset: 0x18D9418 VA: 0x6CF6930418
	public virtual string get_Method() { }

	// RVA: 0x6CF6930440 Offset: 0x18D9440 VA: 0x6CF6930440
	public virtual void set_Method(string value) { }

	// RVA: 0x6CF6930468 Offset: 0x18D9468 VA: 0x6CF6930468
	public virtual Uri get_RequestUri() { }

	// RVA: 0x6CF6930490 Offset: 0x18D9490 VA: 0x6CF6930490
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF69304B8 Offset: 0x18D94B8 VA: 0x6CF69304B8
	public virtual long get_ContentLength() { }

	// RVA: 0x6CF69304E0 Offset: 0x18D94E0 VA: 0x6CF69304E0
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x6CF6930508 Offset: 0x18D9508 VA: 0x6CF6930508
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x6CF6930530 Offset: 0x18D9530 VA: 0x6CF6930530
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF6930558 Offset: 0x18D9558 VA: 0x6CF6930558
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x6CF6930580 Offset: 0x18D9580 VA: 0x6CF6930580
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x6CF69305A8 Offset: 0x18D95A8 VA: 0x6CF69305A8
	public virtual int get_Timeout() { }

	// RVA: 0x6CF69305D0 Offset: 0x18D95D0 VA: 0x6CF69305D0
	public virtual WebResponse GetResponse() { }

	// RVA: 0x6CF69305F8 Offset: 0x18D95F8 VA: 0x6CF69305F8
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x6CF6930620 Offset: 0x18D9620 VA: 0x6CF6930620
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6930648 Offset: 0x18D9648 VA: 0x6CF6930648
	public virtual Task`1 GetResponseAsync() { }

	// RVA: 0x6CF69308D4 Offset: 0x18D98D4 VA: 0x6CF69308D4
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x6CF6930924 Offset: 0x18D9924 VA: 0x6CF6930924
	public virtual void Abort() { }

	// RVA: 0x6CF693094C Offset: 0x18D994C VA: 0x6CF693094C
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x6CF6930954 Offset: 0x18D9954 VA: 0x6CF6930954
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x6CF693095C Offset: 0x18D995C VA: 0x6CF693095C
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x6CF6930B28 Offset: 0x18D9B28 VA: 0x6CF6930B28
	private static void .cctor() { }

	// RVA: 0x6CF6930E18 Offset: 0x18D9E18 VA: 0x6CF6930E18
	private Task`1 <GetResponseAsync>b__79_0() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	// Fields

	private bool m_IsFromCache; // 0x18

	// Properties

	public virtual bool IsFromCache { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x6CF69312F8 Offset: 0x18DA2F8 VA: 0x6CF69312F8
	protected void .ctor() { }

	// RVA: 0x6CF6931300 Offset: 0x18DA300 VA: 0x6CF6931300
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6931308 Offset: 0x18DA308 VA: 0x6CF6931308
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6931314 Offset: 0x18DA314 VA: 0x6CF6931314
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6931318 Offset: 0x18DA318 VA: 0x6CF6931318
	public virtual void Close() { }

	// RVA: 0x6CF693131C Offset: 0x18DA31C VA: 0x6CF693131C
	public void Dispose() { }

	// RVA: 0x6CF6931388 Offset: 0x18DA388 VA: 0x6CF6931388
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x6CF6931414 Offset: 0x18DA414 VA: 0x6CF6931414
	public virtual bool get_IsFromCache() { }

	// RVA: 0x6CF693141C Offset: 0x18DA41C VA: 0x6CF693141C
	public virtual Stream GetResponseStream() { }

	// RVA: 0x6CF6931444 Offset: 0x18DA444 VA: 0x6CF6931444
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x6CF693146C Offset: 0x18DA46C VA: 0x6CF693146C
	public virtual WebHeaderCollection get_Headers() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class BufferOffsetSize : Object
{
	// Fields

	internal Byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Properties


	// Methods

	// RVA: 0x6CF6931494 Offset: 0x18DA494 VA: 0x6CF6931494
	internal void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x6CF6931540 Offset: 0x18DA540 VA: 0x6CF6931540
	internal void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Dll : System.dll
// Namespace: System.Net
internal sealed class HeaderParser : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6931560 Offset: 0x18DA560 VA: 0x6CF6931560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69315FC Offset: 0x18DA5FC VA: 0x6CF69315FC
	public virtual String[] Invoke(string value) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class HeaderInfo : Object
{
	// Fields

	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF6931610 Offset: 0x18DA610 VA: 0x6CF6931610
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class HeaderInfoTable : Object
{
	// Fields

	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties

	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x6CF6931664 Offset: 0x18DA664 VA: 0x6CF6931664
	private static String[] ParseSingleValue(string value) { }

	// RVA: 0x6CF69316C8 Offset: 0x18DA6C8 VA: 0x6CF69316C8
	private static String[] ParseMultiValue(string value) { }

	// RVA: 0x6CF69318CC Offset: 0x18DA8CC VA: 0x6CF69318CC
	private static void .cctor() { }

	// RVA: 0x6CF69330E0 Offset: 0x18DC0E0 VA: 0x6CF69330E0
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x6CF69331BC Offset: 0x18DC1BC VA: 0x6CF69331BC
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum CloseExState
{
	// Fields

	public int value__; // 0x10
	public const CloseExState Normal = 0; // 0x0
	public const CloseExState Abort = 1; // 0x0
	public const CloseExState Silent = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal interface ICloseEx
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void CloseEx(CloseExState closeState) { }

}

// Dll : System.dll
// Namespace: 
private class ThreadContext : Object
{
	// Fields

	internal int m_NestedIOCount; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6933250 Offset: 0x18DC250 VA: 0x6CF6933250
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class LazyAsyncResult : Object, IAsyncResult
{
	// Fields

	private static ThreadContext t_ThreadContext; // 0xFFFFFFFFFFFFFFFF
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Properties

	private static ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal bool EndCalled { get; set; }

	// Methods

	// RVA: 0x6CF69331C4 Offset: 0x18DC1C4 VA: 0x6CF69331C4
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x6CF6933258 Offset: 0x18DC258 VA: 0x6CF6933258
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x6CF69332E8 Offset: 0x18DC2E8 VA: 0x6CF69332E8
	internal object get_AsyncObject() { }

	// RVA: 0x6CF69332F0 Offset: 0x18DC2F0 VA: 0x6CF69332F0
	public object get_AsyncState() { }

	// RVA: 0x6CF69332F8 Offset: 0x18DC2F8 VA: 0x6CF69332F8
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x6CF6933300 Offset: 0x18DC300 VA: 0x6CF6933300
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x6CF6933398 Offset: 0x18DC398 VA: 0x6CF6933398
	private bool LazilyCreateEvent(ref ManualResetEvent waitHandle) { }

	// RVA: 0x6CF693354C Offset: 0x18DC54C VA: 0x6CF693354C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x6CF693357C Offset: 0x18DC57C VA: 0x6CF693357C
	public bool get_IsCompleted() { }

	// RVA: 0x6CF693353C Offset: 0x18DC53C VA: 0x6CF693353C
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x6CF69335AC Offset: 0x18DC5AC VA: 0x6CF69335AC
	internal bool get_EndCalled() { }

	// RVA: 0x6CF69335B4 Offset: 0x18DC5B4 VA: 0x6CF69335B4
	internal void set_EndCalled(bool value) { }

	// RVA: 0x6CF69335C0 Offset: 0x18DC5C0 VA: 0x6CF69335C0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x6CF6933794 Offset: 0x18DC794 VA: 0x6CF6933794
	internal void InvokeCallback(object result) { }

	// RVA: 0x6CF693379C Offset: 0x18DC79C VA: 0x6CF693379C
	internal void InvokeCallback() { }

	// RVA: 0x6CF69337A8 Offset: 0x18DC7A8 VA: 0x6CF69337A8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x6CF6933930 Offset: 0x18DC930 VA: 0x6CF6933930
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x6CF69339DC Offset: 0x18DC9DC VA: 0x6CF69339DC
	protected virtual void Cleanup() { }

	// RVA: 0x6CF69339E0 Offset: 0x18DC9E0 VA: 0x6CF69339E0
	internal object InternalWaitForCompletion() { }

	// RVA: 0x6CF69339E8 Offset: 0x18DC9E8 VA: 0x6CF69339E8
	private object WaitForCompletion(bool snap) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class NetRes : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6933C88 Offset: 0x18DCC88 VA: 0x6CF6933C88
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x6CF6933D48 Offset: 0x18DCD48 VA: 0x6CF6933D48
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x6CF6933DA8 Offset: 0x18DCDA8 VA: 0x6CF6933DA8
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Dll : System.dll
// Namespace: 
internal abstract class Queue : Object
{
	// Fields

	private readonly int m_DurationMilliseconds; // 0x10

	// Properties

	internal int Duration { get; }

	// Methods

	// RVA: 0x6CF69357D0 Offset: 0x18DE7D0 VA: 0x6CF69357D0
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x6CF69357F8 Offset: 0x18DE7F8 VA: 0x6CF69357F8
	internal int get_Duration() { }

	// RVA: 0x6CF5BD6E44 Offset: 0xB7FE44 VA: 0x6CF5BD6E44
	internal abstract Timer CreateTimer(Callback callback, object context) { }

}

// Dll : System.dll
// Namespace: 
internal abstract class Timer : Object, IDisposable
{
	// Fields

	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Properties

	internal int StartTime { get; }
	internal int Expiration { get; }
	internal abstract bool HasExpired { get; }

	// Methods

	// RVA: 0x6CF6935800 Offset: 0x18DE800 VA: 0x6CF6935800
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x6CF6935834 Offset: 0x18DE834 VA: 0x6CF6935834
	internal int get_StartTime() { }

	// RVA: 0x6CF693583C Offset: 0x18DE83C VA: 0x6CF693583C
	internal int get_Expiration() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	internal abstract bool Cancel() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	internal abstract bool get_HasExpired() { }

	// RVA: 0x6CF6935848 Offset: 0x18DE848 VA: 0x6CF6935848
	public void Dispose() { }

}

// Dll : System.dll
// Namespace: 
internal sealed class Callback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6935854 Offset: 0x18DE854 VA: 0x6CF6935854
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6935958 Offset: 0x18DE958 VA: 0x6CF6935958
	public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Dll : System.dll
// Namespace: 
private class TimerQueue : Queue
{
	// Fields

	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF693421C Offset: 0x18DD21C VA: 0x6CF693421C
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x6CF693599C Offset: 0x18DE99C VA: 0x6CF693599C
	internal override Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x6CF69354DC Offset: 0x18DE4DC VA: 0x6CF69354DC
	internal bool Fire(ref int nextExpiration) { }

}

// Dll : System.dll
// Namespace: 
private class InfiniteTimerQueue : Queue
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69341FC Offset: 0x18DD1FC VA: 0x6CF69341FC
	internal void .ctor() { }

	// RVA: 0x6CF6935E44 Offset: 0x18DEE44 VA: 0x6CF6935E44
	internal override Timer CreateTimer(Callback callback, object context) { }

}

// Dll : System.dll
// Namespace: 
private enum TimerState
{
	// Fields

	public int value__; // 0x10
	public const TimerState Ready = 0; // 0x0
	public const TimerState Fired = 1; // 0x0
	public const TimerState Cancelled = 2; // 0x0
	public const TimerState Sentinel = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private class TimerNode : Timer
{
	// Fields

	private TimerState m_TimerState; // 0x18
	private Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerNode next; // 0x38
	private TimerNode prev; // 0x40

	// Properties

	internal override bool HasExpired { get; }
	internal TimerNode Next { get; set; }
	internal TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x6CF6935B7C Offset: 0x18DEB7C VA: 0x6CF6935B7C
	internal void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x6CF693596C Offset: 0x18DE96C VA: 0x6CF693596C
	internal void .ctor() { }

	// RVA: 0x6CF6935ED8 Offset: 0x18DEED8 VA: 0x6CF6935ED8
	internal override bool get_HasExpired() { }

	// RVA: 0x6CF6935EE8 Offset: 0x18DEEE8 VA: 0x6CF6935EE8
	internal TimerNode get_Next() { }

	// RVA: 0x6CF6935EF0 Offset: 0x18DEEF0 VA: 0x6CF6935EF0
	internal void set_Next(TimerNode value) { }

	// RVA: 0x6CF6935EF8 Offset: 0x18DEEF8 VA: 0x6CF6935EF8
	internal TimerNode get_Prev() { }

	// RVA: 0x6CF6935F00 Offset: 0x18DEF00 VA: 0x6CF6935F00
	internal void set_Prev(TimerNode value) { }

	// RVA: 0x6CF6935F08 Offset: 0x18DEF08 VA: 0x6CF6935F08
	internal override bool Cancel() { }

	// RVA: 0x6CF6935BD4 Offset: 0x18DEBD4 VA: 0x6CF6935BD4
	internal bool Fire() { }

}

// Dll : System.dll
// Namespace: 
private class InfiniteTimer : Timer
{
	// Fields

	private int cancelled; // 0x18

	// Properties

	internal override bool HasExpired { get; }

	// Methods

	// RVA: 0x6CF6935EAC Offset: 0x18DEEAC VA: 0x6CF6935EAC
	internal void .ctor() { }

	// RVA: 0x6CF6936028 Offset: 0x18DF028 VA: 0x6CF6936028
	internal override bool get_HasExpired() { }

	// RVA: 0x6CF6936030 Offset: 0x18DF030 VA: 0x6CF6936030
	internal override bool Cancel() { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class TimerThread : Object
{
	// Fields

	private static LinkedList`1 s_Queues; // 0x0
	private static LinkedList`1 s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF6933F88 Offset: 0x18DCF88 VA: 0x6CF6933F88
	private static void .cctor() { }

	// RVA: 0x6CF6930BD4 Offset: 0x18D9BD4 VA: 0x6CF6930BD4
	internal static Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x6CF69342AC Offset: 0x18DD2AC VA: 0x6CF69342AC
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x6CF6934C04 Offset: 0x18DDC04 VA: 0x6CF6934C04
	private static void Prod() { }

	// RVA: 0x6CF6934D14 Offset: 0x18DDD14 VA: 0x6CF6934D14
	private static void ThreadProc() { }

	// RVA: 0x6CF6935690 Offset: 0x18DE690 VA: 0x6CF6935690
	private static void StopTimerThread() { }

	// RVA: 0x6CF693566C Offset: 0x18DE66C VA: 0x6CF693566C
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x6CF693570C Offset: 0x18DE70C VA: 0x6CF693570C
	private static void OnDomainUnload(object sender, EventArgs e) { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum CookieVariant
{
	// Fields

	public int value__; // 0x10
	public const CookieVariant Unknown = 0; // 0x0
	public const CookieVariant Plain = 1; // 0x0
	public const CookieVariant Rfc2109 = 2; // 0x0
	public const CookieVariant Rfc2965 = 3; // 0x0
	public const CookieVariant Default = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public sealed class Cookie : Object
{
	// Fields

	internal static readonly Char[] PortSplitDelimiters; // 0x0
	internal static readonly Char[] Reserved2Name; // 0x8
	internal static readonly Char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private Int32[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties

	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal Int32[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x6CF6936054 Offset: 0x18DF054 VA: 0x6CF6936054
	public void .ctor() { }

	// RVA: 0x6CF6936134 Offset: 0x18DF134 VA: 0x6CF6936134
	public string get_Comment() { }

	// RVA: 0x6CF693613C Offset: 0x18DF13C VA: 0x6CF693613C
	public void set_Comment(string value) { }

	// RVA: 0x6CF6936194 Offset: 0x18DF194 VA: 0x6CF6936194
	public void set_CommentUri(Uri value) { }

	// RVA: 0x6CF693619C Offset: 0x18DF19C VA: 0x6CF693619C
	public void set_HttpOnly(bool value) { }

	// RVA: 0x6CF69361A8 Offset: 0x18DF1A8 VA: 0x6CF69361A8
	public void set_Discard(bool value) { }

	// RVA: 0x6CF69361B4 Offset: 0x18DF1B4 VA: 0x6CF69361B4
	public string get_Domain() { }

	// RVA: 0x6CF69361BC Offset: 0x18DF1BC VA: 0x6CF69361BC
	public void set_Domain(string value) { }

	// RVA: 0x6CF6936230 Offset: 0x18DF230 VA: 0x6CF6936230
	private string get__Domain() { }

	// RVA: 0x6CF693630C Offset: 0x18DF30C VA: 0x6CF693630C
	public bool get_Expired() { }

	// RVA: 0x6CF69363C4 Offset: 0x18DF3C4 VA: 0x6CF69363C4
	public void set_Expires(DateTime value) { }

	// RVA: 0x6CF69363CC Offset: 0x18DF3CC VA: 0x6CF69363CC
	public string get_Name() { }

	// RVA: 0x6CF69363D4 Offset: 0x18DF3D4 VA: 0x6CF69363D4
	internal bool InternalSetName(string value) { }

	// RVA: 0x6CF69364D8 Offset: 0x18DF4D8 VA: 0x6CF69364D8
	public string get_Path() { }

	// RVA: 0x6CF69364E0 Offset: 0x18DF4E0 VA: 0x6CF69364E0
	public void set_Path(string value) { }

	// RVA: 0x6CF693654C Offset: 0x18DF54C VA: 0x6CF693654C
	private string get__Path() { }

	// RVA: 0x6CF69362FC Offset: 0x18DF2FC VA: 0x6CF69362FC
	internal bool get_Plain() { }

	// RVA: 0x6CF69365E8 Offset: 0x18DF5E8 VA: 0x6CF69365E8
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x6CF6936640 Offset: 0x18DF640 VA: 0x6CF6936640
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x6CF6937014 Offset: 0x18E0014 VA: 0x6CF6937014
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x6CF693718C Offset: 0x18E018C VA: 0x6CF693718C
	public void set_Port(string value) { }

	// RVA: 0x6CF69374B8 Offset: 0x18E04B8 VA: 0x6CF69374B8
	internal Int32[] get_PortList() { }

	// RVA: 0x6CF69374C0 Offset: 0x18E04C0 VA: 0x6CF69374C0
	private string get__Port() { }

	// RVA: 0x6CF6937588 Offset: 0x18E0588 VA: 0x6CF6937588
	public bool get_Secure() { }

	// RVA: 0x6CF6937590 Offset: 0x18E0590 VA: 0x6CF6937590
	public void set_Secure(bool value) { }

	// RVA: 0x6CF693759C Offset: 0x18E059C VA: 0x6CF693759C
	public string get_Value() { }

	// RVA: 0x6CF69375A4 Offset: 0x18E05A4 VA: 0x6CF69375A4
	public void set_Value(string value) { }

	// RVA: 0x6CF693760C Offset: 0x18E060C VA: 0x6CF693760C
	internal CookieVariant get_Variant() { }

	// RVA: 0x6CF6937614 Offset: 0x18E0614 VA: 0x6CF6937614
	internal string get_DomainKey() { }

	// RVA: 0x6CF6937630 Offset: 0x18E0630 VA: 0x6CF6937630
	public int get_Version() { }

	// RVA: 0x6CF6937638 Offset: 0x18E0638 VA: 0x6CF6937638
	public void set_Version(int value) { }

	// RVA: 0x6CF69376AC Offset: 0x18E06AC VA: 0x6CF69376AC
	private string get__Version() { }

	// RVA: 0x6CF69377B8 Offset: 0x18E07B8 VA: 0x6CF69377B8
	internal static IComparer GetComparer() { }

	// RVA: 0x6CF6937810 Offset: 0x18E0810 VA: 0x6CF6937810
	public override bool Equals(object comparand) { }

	// RVA: 0x6CF69378E0 Offset: 0x18E08E0 VA: 0x6CF69378E0
	public override int GetHashCode() { }

	// RVA: 0x6CF6937A40 Offset: 0x18E0A40 VA: 0x6CF6937A40
	public override string ToString() { }

	// RVA: 0x6CF6937C8C Offset: 0x18E0C8C VA: 0x6CF6937C8C
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum CookieToken
{
	// Fields

	public int value__; // 0x10
	public const CookieToken Nothing = 0; // 0x0
	public const CookieToken NameValuePair = 1; // 0x0
	public const CookieToken Attribute = 2; // 0x0
	public const CookieToken EndToken = 3; // 0x0
	public const CookieToken EndCookie = 4; // 0x0
	public const CookieToken End = 5; // 0x0
	public const CookieToken Equals = 6; // 0x0
	public const CookieToken Comment = 7; // 0x0
	public const CookieToken CommentUrl = 8; // 0x0
	public const CookieToken CookieName = 9; // 0x0
	public const CookieToken Discard = 10; // 0x0
	public const CookieToken Domain = 11; // 0x0
	public const CookieToken Expires = 12; // 0x0
	public const CookieToken MaxAge = 13; // 0x0
	public const CookieToken Path = 14; // 0x0
	public const CookieToken Port = 15; // 0x0
	public const CookieToken Secure = 16; // 0x0
	public const CookieToken HttpOnly = 17; // 0x0
	public const CookieToken Unknown = 18; // 0x0
	public const CookieToken Version = 19; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct RecognizedAttribute
{
	// Fields

	private string m_name; // 0x10
	private CookieToken m_token; // 0x18

	// Properties

	internal CookieToken Token { get; }

	// Methods

	// RVA: 0x6CF6938800 Offset: 0x18E1800 VA: 0x6CF6938800
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x6CF693880C Offset: 0x18E180C VA: 0x6CF693880C
	internal CookieToken get_Token() { }

	// RVA: 0x6CF69384CC Offset: 0x18E14CC VA: 0x6CF69384CC
	internal bool IsEqualTo(string value) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class CookieTokenizer : Object
{
	// Fields

	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties

	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x6CF6937DDC Offset: 0x18E0DDC VA: 0x6CF6937DDC
	internal void .ctor(string tokenStream) { }

	// RVA: 0x6CF6937E14 Offset: 0x18E0E14 VA: 0x6CF6937E14
	internal bool get_EndOfCookie() { }

	// RVA: 0x6CF6937E1C Offset: 0x18E0E1C VA: 0x6CF6937E1C
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x6CF6937E28 Offset: 0x18E0E28 VA: 0x6CF6937E28
	internal bool get_Eof() { }

	// RVA: 0x6CF6937E38 Offset: 0x18E0E38 VA: 0x6CF6937E38
	internal string get_Name() { }

	// RVA: 0x6CF6937E40 Offset: 0x18E0E40 VA: 0x6CF6937E40
	internal void set_Name(string value) { }

	// RVA: 0x6CF6937E48 Offset: 0x18E0E48 VA: 0x6CF6937E48
	internal bool get_Quoted() { }

	// RVA: 0x6CF6937E50 Offset: 0x18E0E50 VA: 0x6CF6937E50
	internal void set_Quoted(bool value) { }

	// RVA: 0x6CF6937E5C Offset: 0x18E0E5C VA: 0x6CF6937E5C
	internal CookieToken get_Token() { }

	// RVA: 0x6CF6937E64 Offset: 0x18E0E64 VA: 0x6CF6937E64
	internal void set_Token(CookieToken value) { }

	// RVA: 0x6CF6937E6C Offset: 0x18E0E6C VA: 0x6CF6937E6C
	internal string get_Value() { }

	// RVA: 0x6CF6937E74 Offset: 0x18E0E74 VA: 0x6CF6937E74
	internal void set_Value(string value) { }

	// RVA: 0x6CF6937E7C Offset: 0x18E0E7C VA: 0x6CF6937E7C
	internal string Extract() { }

	// RVA: 0x6CF6937F04 Offset: 0x18E0F04 VA: 0x6CF6937F04
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x6CF69381A4 Offset: 0x18E11A4 VA: 0x6CF69381A4
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x6CF69382A8 Offset: 0x18E12A8 VA: 0x6CF69382A8
	internal void Reset() { }

	// RVA: 0x6CF6938310 Offset: 0x18E1310 VA: 0x6CF6938310
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x6CF69384F0 Offset: 0x18E14F0 VA: 0x6CF69384F0
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class CookieParser : Object
{
	// Fields

	private CookieTokenizer m_tokenizer; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6938814 Offset: 0x18E1814 VA: 0x6CF6938814
	internal void .ctor(string cookieString) { }

	// RVA: 0x6CF6938884 Offset: 0x18E1884 VA: 0x6CF6938884
	internal Cookie Get() { }

	// RVA: 0x6CF69370C8 Offset: 0x18E00C8 VA: 0x6CF69370C8
	internal static string CheckQuoted(string value) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class Comparer : Object, IComparer
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6938E00 Offset: 0x18E1E00 VA: 0x6CF6938E00
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x6CF6937DD4 Offset: 0x18E0DD4 VA: 0x6CF6937DD4
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: 
internal enum Stamp
{
	// Fields

	public int value__; // 0x10
	public const Stamp Check = 0; // 0x0
	public const Stamp Set = 1; // 0x0
	public const Stamp SetToUnused = 2; // 0x0
	public const Stamp SetToMaxUsed = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private class CookieCollectionEnumerator : Object, IEnumerator
{
	// Fields

	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Properties

	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF6939E3C Offset: 0x18E2E3C VA: 0x6CF6939E3C
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x6CF6939E98 Offset: 0x18E2E98 VA: 0x6CF6939E98
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x6CF6939F3C Offset: 0x18E2F3C VA: 0x6CF6939F3C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x6CF6939FD8 Offset: 0x18E2FD8 VA: 0x6CF6939FD8
	private void System.Collections.IEnumerator.Reset() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class CookieCollection : Object, ICollection, IEnumerable
{
	// Fields

	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	private bool m_IsReadOnly; // 0x29

	// Properties

	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x6CF6938EE4 Offset: 0x18E1EE4 VA: 0x6CF6938EE4
	public void .ctor() { }

	// RVA: 0x6CF6938F8C Offset: 0x18E1F8C VA: 0x6CF6938F8C
	public Cookie get_Item(int index) { }

	// RVA: 0x6CF6939074 Offset: 0x18E2074 VA: 0x6CF6939074
	public void Add(Cookie cookie) { }

	// RVA: 0x6CF69394E4 Offset: 0x18E24E4 VA: 0x6CF69394E4
	public void Add(CookieCollection cookies) { }

	// RVA: 0x6CF6939838 Offset: 0x18E2838 VA: 0x6CF6939838
	public int get_Count() { }

	// RVA: 0x6CF693985C Offset: 0x18E285C VA: 0x6CF693985C
	public bool get_IsSynchronized() { }

	// RVA: 0x6CF6939864 Offset: 0x18E2864 VA: 0x6CF6939864
	public object get_SyncRoot() { }

	// RVA: 0x6CF6939868 Offset: 0x18E2868 VA: 0x6CF6939868
	public void CopyTo(Array array, int index) { }

	// RVA: 0x6CF693988C Offset: 0x18E288C VA: 0x6CF693988C
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0x6CF693995C Offset: 0x18E295C VA: 0x6CF693995C
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x6CF6939964 Offset: 0x18E2964 VA: 0x6CF6939964
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x6CF6939134 Offset: 0x18E2134 VA: 0x6CF6939134
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x6CF6939E18 Offset: 0x18E2E18 VA: 0x6CF6939E18
	internal void RemoveAt(int idx) { }

	// RVA: 0x6CF69397E0 Offset: 0x18E27E0 VA: 0x6CF69397E0
	public IEnumerator GetEnumerator() { }

}

// Dll : System.dll
// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields

	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Properties

	internal string Name { get; }
	internal CookieVariant Variant { get; }

	// Methods

	// RVA: 0x6CF6939FE4 Offset: 0x18E2FE4 VA: 0x6CF6939FE4
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x6CF6939FF0 Offset: 0x18E2FF0 VA: 0x6CF6939FF0
	internal string get_Name() { }

	// RVA: 0x6CF6939FF8 Offset: 0x18E2FF8 VA: 0x6CF6939FF8
	internal CookieVariant get_Variant() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class CookieContainer : Object
{
	// Fields

	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF693A000 Offset: 0x18E3000 VA: 0x6CF693A000
	public void .ctor() { }

	// RVA: 0x6CF693A0F8 Offset: 0x18E30F8 VA: 0x6CF693A0F8
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x6CF693A21C Offset: 0x18E321C VA: 0x6CF693A21C
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x6CF693B058 Offset: 0x18E4058 VA: 0x6CF693B058
	private bool AgeCookies(string domain) { }

	// RVA: 0x6CF693C5BC Offset: 0x18E55BC VA: 0x6CF693C5BC
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x6CF693C74C Offset: 0x18E574C VA: 0x6CF693C74C
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x6CF693C9EC Offset: 0x18E59EC VA: 0x6CF693C9EC
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x6CF693D0C4 Offset: 0x18E60C4 VA: 0x6CF693D0C4
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x6CF693D554 Offset: 0x18E6554 VA: 0x6CF693D554
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List`1 domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x6CF693DD98 Offset: 0x18E6D98 VA: 0x6CF693DD98
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x6CF693DFA4 Offset: 0x18E6FA4 VA: 0x6CF693DFA4
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x6CF693E070 Offset: 0x18E7070 VA: 0x6CF693E070
	internal string GetCookieHeader(Uri uri, ref string optCookie2) { }

	// RVA: 0x6CF693E408 Offset: 0x18E7408 VA: 0x6CF693E408
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private class PathListComparer : Object, IComparer
{
	// Fields

	internal static readonly PathListComparer StaticInstance; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF693E4CC Offset: 0x18E74CC VA: 0x6CF693E4CC
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x6CF693E634 Offset: 0x18E7634 VA: 0x6CF693E634
	public void .ctor() { }

	// RVA: 0x6CF693E63C Offset: 0x18E763C VA: 0x6CF693E63C
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
internal class PathList : Object
{
	// Fields

	private SortedList m_list; // 0x10

	// Properties

	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x6CF693AA28 Offset: 0x18E3A28 VA: 0x6CF693AA28
	public void .ctor() { }

	// RVA: 0x6CF693C728 Offset: 0x18E5728 VA: 0x6CF693C728
	public int get_Count() { }

	// RVA: 0x6CF693AAC8 Offset: 0x18E3AC8 VA: 0x6CF693AAC8
	public int GetCookiesCount() { }

	// RVA: 0x6CF693C598 Offset: 0x18E5598 VA: 0x6CF693C598
	public ICollection get_Values() { }

	// RVA: 0x6CF693AF38 Offset: 0x18E3F38 VA: 0x6CF693AF38
	public object get_Item(string s) { }

	// RVA: 0x6CF693AF5C Offset: 0x18E3F5C VA: 0x6CF693AF5C
	public void set_Item(string s, object value) { }

	// RVA: 0x6CF693DD74 Offset: 0x18E6D74 VA: 0x6CF693DD74
	public IEnumerator GetEnumerator() { }

	// RVA: 0x6CF693AF14 Offset: 0x18E3F14 VA: 0x6CF693AF14
	public object get_SyncRoot() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class CookieException : FormatException, ISerializable
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF693E698 Offset: 0x18E7698 VA: 0x6CF693E698
	public void .ctor() { }

	// RVA: 0x6CF693700C Offset: 0x18E000C VA: 0x6CF693700C
	internal void .ctor(string message) { }

	// RVA: 0x6CF693C590 Offset: 0x18E5590 VA: 0x6CF693C590
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x6CF693E6A0 Offset: 0x18E76A0 VA: 0x6CF693E6A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF693E6A8 Offset: 0x18E76A8 VA: 0x6CF693E6A8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF693E6B0 Offset: 0x18E76B0 VA: 0x6CF693E6B0
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable
{
	// Fields

	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Properties

	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x6CF693E6B8 Offset: 0x18E76B8 VA: 0x6CF693E6B8
	internal void .ctor(Uri uri) { }

	// RVA: 0x6CF693E82C Offset: 0x18E782C VA: 0x6CF693E82C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF693EBC8 Offset: 0x18E7BC8 VA: 0x6CF693EBC8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF693EBD4 Offset: 0x18E7BD4 VA: 0x6CF693EBD4
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF693EE64 Offset: 0x18E7E64 VA: 0x6CF693EE64
	internal bool get_Aborted() { }

	// RVA: 0x6CF693EE74 Offset: 0x18E7E74 VA: 0x6CF693EE74
	public override long get_ContentLength() { }

	// RVA: 0x6CF693EE7C Offset: 0x18E7E7C VA: 0x6CF693EE7C
	public override ICredentials get_Credentials() { }

	// RVA: 0x6CF693EE84 Offset: 0x18E7E84 VA: 0x6CF693EE84
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x6CF693EE8C Offset: 0x18E7E8C VA: 0x6CF693EE8C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF693EE94 Offset: 0x18E7E94 VA: 0x6CF693EE94
	public override string get_Method() { }

	// RVA: 0x6CF693EE9C Offset: 0x18E7E9C VA: 0x6CF693EE9C
	public override void set_Method(string value) { }

	// RVA: 0x6CF693EF70 Offset: 0x18E7F70 VA: 0x6CF693EF70
	public override IWebProxy get_Proxy() { }

	// RVA: 0x6CF693EF78 Offset: 0x18E7F78 VA: 0x6CF693EF78
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x6CF693EF80 Offset: 0x18E7F80 VA: 0x6CF693EF80
	public override int get_Timeout() { }

	// RVA: 0x6CF693EF88 Offset: 0x18E7F88 VA: 0x6CF693EF88
	public override Uri get_RequestUri() { }

	// RVA: 0x6CF693EF90 Offset: 0x18E7F90 VA: 0x6CF693EF90
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x6CF693F258 Offset: 0x18E8258 VA: 0x6CF693F258
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x6CF693F544 Offset: 0x18E8544 VA: 0x6CF693F544
	public override WebResponse GetResponse() { }

	// RVA: 0x6CF693F894 Offset: 0x18E8894 VA: 0x6CF693F894
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x6CF693FB44 Offset: 0x18E8B44 VA: 0x6CF693FB44
	private static void GetResponseCallback(object state) { }

	// RVA: 0x6CF6940110 Offset: 0x18E9110 VA: 0x6CF6940110
	internal void UnblockReader() { }

	// RVA: 0x6CF69401E8 Offset: 0x18E91E8 VA: 0x6CF69401E8
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF6940210 Offset: 0x18E9210 VA: 0x6CF6940210
	public override void Abort() { }

	// RVA: 0x6CF69405B0 Offset: 0x18E95B0 VA: 0x6CF69405B0
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class FileWebRequestCreator : Object, IWebRequestCreate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6930320 Offset: 0x18D9320 VA: 0x6CF6930320
	internal void .ctor() { }

	// RVA: 0x6CF6940680 Offset: 0x18E9680 VA: 0x6CF6940680
	public WebRequest Create(Uri uri) { }

}

// Dll : System.dll
// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx
{
	// Fields

	private FileWebRequest m_request; // 0x70

	// Properties


	// Methods

	// RVA: 0x6CF693FAA8 Offset: 0x18E8AA8 VA: 0x6CF693FAA8
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x6CF69406D8 Offset: 0x18E96D8 VA: 0x6CF69406D8
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x6CF694078C Offset: 0x18E978C VA: 0x6CF694078C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF694083C Offset: 0x18E983C VA: 0x6CF694083C
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x6CF6940878 Offset: 0x18E9878 VA: 0x6CF6940878
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF69409BC Offset: 0x18E99BC VA: 0x6CF69409BC
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6940A84 Offset: 0x18E9A84 VA: 0x6CF6940A84
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6940B64 Offset: 0x18E9B64 VA: 0x6CF6940B64
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x6CF6940C04 Offset: 0x18E9C04 VA: 0x6CF6940C04
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6940CE4 Offset: 0x18E9CE4 VA: 0x6CF6940CE4
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x6CF6940940 Offset: 0x18E9940 VA: 0x6CF6940940
	private void CheckError() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	// Fields

	private bool m_closed; // 0x19
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties

	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x6CF693FE40 Offset: 0x18E8E40 VA: 0x6CF693FE40
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x6CF6940D84 Offset: 0x18E9D84 VA: 0x6CF6940D84
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6940FB8 Offset: 0x18E9FB8 VA: 0x6CF6940FB8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6940FC4 Offset: 0x18E9FC4 VA: 0x6CF6940FC4
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6941154 Offset: 0x18EA154 VA: 0x6CF6941154
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF69411E8 Offset: 0x18EA1E8 VA: 0x6CF69411E8
	public override Uri get_ResponseUri() { }

	// RVA: 0x6CF694116C Offset: 0x18EA16C VA: 0x6CF694116C
	private void CheckDisposed() { }

	// RVA: 0x6CF6941200 Offset: 0x18EA200 VA: 0x6CF6941200
	public override void Close() { }

	// RVA: 0x6CF6941298 Offset: 0x18EA298 VA: 0x6CF6941298
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x6CF6941404 Offset: 0x18EA404 VA: 0x6CF6941404
	public override Stream GetResponseStream() { }

}

// Dll : System.dll
// Namespace: System.Net
public interface IWebProxy
{
	// Fields


	// Properties

	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	public abstract Uri GetProxy(Uri destination) { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public abstract bool IsBypassed(Uri host) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract ICredentials get_Credentials() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class WebProxy : Object, IWebProxy, ISerializable
{
	// Fields

	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties

	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x6CF6941458 Offset: 0x18EA458 VA: 0x6CF6941458
	public void .ctor() { }

	// RVA: 0x6CF694146C Offset: 0x18EA46C VA: 0x6CF694146C
	public void .ctor(Uri Address, bool BypassOnLocal, String[] BypassList, ICredentials Credentials) { }

	// RVA: 0x6CF694174C Offset: 0x18EA74C VA: 0x6CF694174C
	public ICredentials get_Credentials() { }

	// RVA: 0x6CF6941754 Offset: 0x18EA754 VA: 0x6CF6941754
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF69417D0 Offset: 0x18EA7D0 VA: 0x6CF69417D0
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x6CF6941844 Offset: 0x18EA844 VA: 0x6CF6941844
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x6CF6941518 Offset: 0x18EA518 VA: 0x6CF6941518
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x6CF6941AF0 Offset: 0x18EAAF0 VA: 0x6CF6941AF0
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x6CF6941C88 Offset: 0x18EAC88 VA: 0x6CF6941C88
	private bool IsLocal(Uri host) { }

	// RVA: 0x6CF6941DE4 Offset: 0x18EADE4 VA: 0x6CF6941DE4
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x6CF6941ED4 Offset: 0x18EAED4 VA: 0x6CF6941ED4
	public bool IsBypassed(Uri host) { }

	// RVA: 0x6CF6941A28 Offset: 0x18EAA28 VA: 0x6CF6941A28
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x6CF6941FF8 Offset: 0x18EAFF8 VA: 0x6CF6941FF8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6942358 Offset: 0x18EB358 VA: 0x6CF6942358
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6942364 Offset: 0x18EB364 VA: 0x6CF6942364
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6942488 Offset: 0x18EB488 VA: 0x6CF6942488
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x6CF6942490 Offset: 0x18EB490 VA: 0x6CF6942490
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x6CF69424F0 Offset: 0x18EB4F0 VA: 0x6CF69424F0
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x6CF694234C Offset: 0x18EB34C VA: 0x6CF694234C
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x6CF69419DC Offset: 0x18EA9DC VA: 0x6CF69419DC
	private bool GetProxyAuto(Uri destination, ref Uri proxyUri) { }

	// RVA: 0x6CF6941FB4 Offset: 0x18EAFB4 VA: 0x6CF6941FB4
	private bool IsBypassedAuto(Uri destination, ref bool isBypassed) { }

	// RVA: 0x6CF694252C Offset: 0x18EB52C VA: 0x6CF694252C
	private static bool AreAllBypassed(IEnumerable`1 proxies, bool checkFirstOnly) { }

	// RVA: 0x6CF6942830 Offset: 0x18EB830 VA: 0x6CF6942830
	private static Uri ProxyUri(string proxyName) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class AutoWebProxyScriptEngine : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6942520 Offset: 0x18EB520 VA: 0x6CF6942520
	public bool GetProxies(Uri destination, ref IList`1 proxyList) { }

	// RVA: 0x6CF69428CC Offset: 0x18EB8CC VA: 0x6CF69428CC
	public bool GetProxies(Uri destination, ref IList`1 proxyList, ref int syncStatus) { }

}

// Dll : System.dll
// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID : Object
{
	// Fields

	private static String[] m_Strings; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6942D84 Offset: 0x18EBD84 VA: 0x6CF6942D84
	internal static string ToString(int position) { }

	// RVA: 0x6CF6942E00 Offset: 0x18EBE00 VA: 0x6CF6942E00
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
internal static class HttpApi : Object
{
	// Fields

	private static String[] m_Strings; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF69428D8 Offset: 0x18EB8D8 VA: 0x6CF69428D8
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
internal static class SecureStringHelper : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6943438 Offset: 0x18EC438 VA: 0x6CF6943438
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x6CF69435AC Offset: 0x18EC5AC VA: 0x6CF69435AC
	internal static SecureString CreateSecureString(string plainString) { }

}

// Dll : System.dll
// Namespace: System.Net
internal static class UnsafeNclNativeMethods : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal static class Logging : Object
{
	// Fields


	// Properties

	internal static bool On { get; }

	// Methods

	// RVA: 0x6CF692FDB4 Offset: 0x18D8DB4 VA: 0x6CF692FDB4
	internal static bool get_On() { }

}

// Dll : System.dll
// Namespace: 
private class CallbackContext : Object
{
	// Fields

	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Properties


	// Methods

	// RVA: 0x6CF69438E0 Offset: 0x18EC8E0 VA: 0x6CF69438E0
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class ServerCertValidationCallback : Object
{
	// Fields

	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties

	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x6CF6943648 Offset: 0x18EC648 VA: 0x6CF6943648
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x6CF69436C0 Offset: 0x18EC6C0 VA: 0x6CF69436C0
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x6CF69436C8 Offset: 0x18EC6C8 VA: 0x6CF69436C8
	internal void Callback(object state) { }

	// RVA: 0x6CF6943774 Offset: 0x18EC774 VA: 0x6CF6943774
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Dll : System.dll
// Namespace: System.Net
public class AuthenticationManager : Object
{
	// Fields

	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6943924 Offset: 0x18EC924 VA: 0x6CF6943924
	private static void EnsureModules() { }

	// RVA: 0x6CF6943BA0 Offset: 0x18ECBA0 VA: 0x6CF6943BA0
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x6CF6943CA0 Offset: 0x18ECCA0 VA: 0x6CF6943CA0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x6CF694418C Offset: 0x18ED18C VA: 0x6CF694418C
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x6CF69446C4 Offset: 0x18ED6C4 VA: 0x6CF69446C4
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class BasicClient : Object, IAuthenticationModule
{
	// Fields


	// Properties

	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x6CF6944734 Offset: 0x18ED734 VA: 0x6CF6944734
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF6944AE0 Offset: 0x18EDAE0 VA: 0x6CF6944AE0
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x6CF69447E0 Offset: 0x18ED7E0 VA: 0x6CF69447E0
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF6944B7C Offset: 0x18EDB7C VA: 0x6CF6944B7C
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF6944B88 Offset: 0x18EDB88 VA: 0x6CF6944B88
	public string get_AuthenticationType() { }

	// RVA: 0x6CF6943B98 Offset: 0x18ECB98 VA: 0x6CF6943B98
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
public sealed class BindIPEndPoint : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6944BC8 Offset: 0x18EDBC8 VA: 0x6CF6944BC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6944CCC Offset: 0x18EDCCC VA: 0x6CF6944CCC
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

}

// Dll : System.dll
// Namespace: 
private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public BufferedReadStream <>4__this; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF6944EB8 Offset: 0x18EDEB8 VA: 0x6CF6944EB8
	private void MoveNext() { }

	// RVA: 0x6CF69451E0 Offset: 0x18EE1E0 VA: 0x6CF69451E0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class BufferedReadStream : WebReadStream
{
	// Fields

	private readonly BufferOffsetSize readBuffer; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF6944CE0 Offset: 0x18EDCE0 VA: 0x6CF6944CE0
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x6CF6944D08 Offset: 0x18EDD08 VA: 0x6CF6944D08
	protected override Task`1 ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6944E28 Offset: 0x18EDE28 VA: 0x6CF6944E28
	internal bool TryReadFromBuffer(Byte[] buffer, int offset, int size, ref int result) { }

}

// Dll : System.dll
// Namespace: 
internal enum Mode
{
	// Fields

	public int value__; // 0x10
	public const Mode GZip = 0; // 0x0
	public const Mode Deflate = 1; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal class ContentDecodeStream : WebReadStream
{
	// Fields

	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties

	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x6CF694525C Offset: 0x18EE25C VA: 0x6CF694525C
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x6CF6945360 Offset: 0x18EE360 VA: 0x6CF6945360
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x6CF6945338 Offset: 0x18EE338 VA: 0x6CF6945338
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x6CF6945368 Offset: 0x18EE368 VA: 0x6CF6945368
	protected override Task`1 ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF694538C Offset: 0x18EE38C VA: 0x6CF694538C
	internal override Task FinishReading(CancellationToken cancellationToken) { }

}

// Dll : System.dll
// Namespace: System.Net
public enum DecompressionMethods
{
	// Fields

	public int value__; // 0x10
	public const DecompressionMethods None = 0; // 0x0
	public const DecompressionMethods GZip = 1; // 0x0
	public const DecompressionMethods Deflate = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal class DefaultCertificatePolicy : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net
internal class DigestHeaderParser : Object
{
	// Fields

	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static String[] keywords; // 0x0
	private String[] values; // 0x20

	// Properties

	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x6CF694547C Offset: 0x18EE47C VA: 0x6CF694547C
	public void .ctor(string header) { }

	// RVA: 0x6CF6945530 Offset: 0x18EE530 VA: 0x6CF6945530
	public string get_Realm() { }

	// RVA: 0x6CF6945558 Offset: 0x18EE558 VA: 0x6CF6945558
	public string get_Opaque() { }

	// RVA: 0x6CF6945584 Offset: 0x18EE584 VA: 0x6CF6945584
	public string get_Nonce() { }

	// RVA: 0x6CF69455B0 Offset: 0x18EE5B0 VA: 0x6CF69455B0
	public string get_Algorithm() { }

	// RVA: 0x6CF69455DC Offset: 0x18EE5DC VA: 0x6CF69455DC
	public string get_QOP() { }

	// RVA: 0x6CF6945608 Offset: 0x18EE608 VA: 0x6CF6945608
	public bool Parse() { }

	// RVA: 0x6CF6945930 Offset: 0x18EE930 VA: 0x6CF6945930
	private void SkipWhitespace() { }

	// RVA: 0x6CF69459B0 Offset: 0x18EE9B0 VA: 0x6CF69459B0
	private string GetKey() { }

	// RVA: 0x6CF69457A0 Offset: 0x18EE7A0 VA: 0x6CF69457A0
	private bool GetKeywordAndValue(ref string key, ref string value) { }

	// RVA: 0x6CF6945A40 Offset: 0x18EEA40 VA: 0x6CF6945A40
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class DigestSession : Object
{
	// Fields

	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties

	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x6CF6945B68 Offset: 0x18EEB68 VA: 0x6CF6945B68
	private static void .cctor() { }

	// RVA: 0x6CF6945BB8 Offset: 0x18EEBB8 VA: 0x6CF6945BB8
	public void .ctor() { }

	// RVA: 0x6CF6945C28 Offset: 0x18EEC28 VA: 0x6CF6945C28
	public string get_Algorithm() { }

	// RVA: 0x6CF6945C40 Offset: 0x18EEC40 VA: 0x6CF6945C40
	public string get_Realm() { }

	// RVA: 0x6CF6945C58 Offset: 0x18EEC58 VA: 0x6CF6945C58
	public string get_Nonce() { }

	// RVA: 0x6CF6945C70 Offset: 0x18EEC70 VA: 0x6CF6945C70
	public string get_Opaque() { }

	// RVA: 0x6CF6945C88 Offset: 0x18EEC88 VA: 0x6CF6945C88
	public string get_QOP() { }

	// RVA: 0x6CF6945CA0 Offset: 0x18EECA0 VA: 0x6CF6945CA0
	public string get_CNonce() { }

	// RVA: 0x6CF6945D94 Offset: 0x18EED94 VA: 0x6CF6945D94
	public bool Parse(string challenge) { }

	// RVA: 0x6CF6945E70 Offset: 0x18EEE70 VA: 0x6CF6945E70
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x6CF6945FC4 Offset: 0x18EEFC4 VA: 0x6CF6945FC4
	private string HA1(string username, string password) { }

	// RVA: 0x6CF69460E8 Offset: 0x18EF0E8 VA: 0x6CF69460E8
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x6CF69461B8 Offset: 0x18EF1B8 VA: 0x6CF69461B8
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x6CF6946318 Offset: 0x18EF318 VA: 0x6CF6946318
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF69468DC Offset: 0x18EF8DC VA: 0x6CF69468DC
	public DateTime get_LastUse() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class DigestClient : Object, IAuthenticationModule
{
	// Fields

	private static readonly Hashtable cache; // 0x0

	// Properties

	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x6CF69468E4 Offset: 0x18EF8E4 VA: 0x6CF69468E4
	private static Hashtable get_Cache() { }

	// RVA: 0x6CF6946A48 Offset: 0x18EFA48 VA: 0x6CF6946A48
	private static void CheckExpired(int count) { }

	// RVA: 0x6CF69472A0 Offset: 0x18F02A0 VA: 0x6CF69472A0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF6947538 Offset: 0x18F0538 VA: 0x6CF6947538
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF69476B8 Offset: 0x18F06B8 VA: 0x6CF69476B8
	public string get_AuthenticationType() { }

	// RVA: 0x6CF6943B90 Offset: 0x18ECB90 VA: 0x6CF6943B90
	public void .ctor() { }

	// RVA: 0x6CF69476F8 Offset: 0x18F06F8 VA: 0x6CF69476F8
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
private sealed class GetHostAddressesCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69478FC Offset: 0x18F08FC VA: 0x6CF69478FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6948564 Offset: 0x18F1564 VA: 0x6CF6948564
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x6CF6947998 Offset: 0x18F0998 VA: 0x6CF6947998
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x6CF6947AC0 Offset: 0x18F0AC0 VA: 0x6CF6947AC0
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Dll : System.dll
// Namespace: System.Net
public static class Dns : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6947774 Offset: 0x18F0774 VA: 0x6CF6947774
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x6CF69479B8 Offset: 0x18F09B8 VA: 0x6CF69479B8
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6947ACC Offset: 0x18F0ACC VA: 0x6CF6947ACC
	private static bool GetHostByName_icall(string host, ref string h_name, ref String[] h_aliases, ref String[] h_addr_list, int hint) { }

	// RVA: 0x6CF6947AD0 Offset: 0x18F0AD0 VA: 0x6CF6947AD0
	private static bool GetHostByAddr_icall(string addr, ref string h_name, ref String[] h_aliases, ref String[] h_addr_list, int hint) { }

	// RVA: 0x6CF6947AD4 Offset: 0x18F0AD4 VA: 0x6CF6947AD4
	private static bool GetHostName_icall(ref string h_name) { }

	// RVA: 0x6CF6947AD8 Offset: 0x18F0AD8 VA: 0x6CF6947AD8
	private static void Error_11001(string hostName) { }

	// RVA: 0x6CF6947B3C Offset: 0x18F0B3C VA: 0x6CF6947B3C
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, String[] h_aliases, String[] h_addrlist) { }

	// RVA: 0x6CF6947E60 Offset: 0x18F0E60 VA: 0x6CF6947E60
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x6CF6947F8C Offset: 0x18F0F8C VA: 0x6CF6947F8C
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x6CF69480F8 Offset: 0x18F10F8 VA: 0x6CF69480F8
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x6CF6948248 Offset: 0x18F1248 VA: 0x6CF6948248
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x6CF6948160 Offset: 0x18F1160 VA: 0x6CF6948160
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x6CF694841C Offset: 0x18F141C VA: 0x6CF694841C
	public static string GetHostName() { }

	// RVA: 0x6CF6948448 Offset: 0x18F1448 VA: 0x6CF6948448
	public static Task`1 GetHostAddressesAsync(string hostNameOrAddress) { }

}

// Dll : System.dll
// Namespace: 
private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public FixedSizeReadStream <>4__this; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF69486C8 Offset: 0x18F16C8 VA: 0x6CF69486C8
	private void MoveNext() { }

	// RVA: 0x6CF69489E0 Offset: 0x18F19E0 VA: 0x6CF69489E0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class FixedSizeReadStream : WebReadStream
{
	// Fields

	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties

	public long ContentLength { get; }

	// Methods

	// RVA: 0x6CF6948578 Offset: 0x18F1578 VA: 0x6CF6948578
	public long get_ContentLength() { }

	// RVA: 0x6CF6948580 Offset: 0x18F1580 VA: 0x6CF6948580
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	// RVA: 0x6CF69485A8 Offset: 0x18F15A8 VA: 0x6CF69485A8
	protected override Task`1 ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class HttpRequestCreator : Object, IWebRequestCreate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6930318 Offset: 0x18D9318 VA: 0x6CF6930318
	internal void .ctor() { }

	// RVA: 0x6CF6948A5C Offset: 0x18F1A5C VA: 0x6CF6948A5C
	public WebRequest Create(Uri uri) { }

}

// Dll : System.dll
// Namespace: 
private enum NtlmAuthState
{
	// Fields

	public int value__; // 0x10
	public const NtlmAuthState None = 0; // 0x0
	public const NtlmAuthState Challenge = 1; // 0x0
	public const NtlmAuthState Response = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct AuthorizationState
{
	// Fields

	private readonly HttpWebRequest request; // 0x10
	private readonly bool isProxy; // 0x18
	private bool isCompleted; // 0x19
	private NtlmAuthState ntlm_auth_state; // 0x1C

	// Properties

	public bool IsCompleted { get; }
	public NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x6CF6851774 Offset: 0x17FA774 VA: 0x6CF6851774
	public bool get_IsCompleted() { }

	// RVA: 0x6CF685177C Offset: 0x17FA77C VA: 0x6CF685177C
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x6CF6851784 Offset: 0x17FA784 VA: 0x6CF6851784
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x6CF68517A4 Offset: 0x17FA7A4 VA: 0x6CF68517A4
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x6CF68517BC Offset: 0x17FA7BC VA: 0x6CF68517BC
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x6CF6851AD8 Offset: 0x17FAAD8 VA: 0x6CF6851AD8
	public void Reset() { }

	// RVA: 0x6CF6851B5C Offset: 0x17FAB5C VA: 0x6CF6851B5C
	public override string ToString() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c__241`1 : Object
{
	// Fields

	public static readonly <>c__241`1 <>9; // 0x0
	public static Func`2 <>9__241_0; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void .ctor() { }

	// RVA: 0x6CF5BD6744 Offset: 0xB7F744 VA: 0x6CF5BD6744
	internal Nullable`1 <RunWithTimeoutWorker>b__241_0(Task`1 t) { }

}

// Dll : System.dll
// Namespace: 
private struct <RunWithTimeoutWorker>d__241`1 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x0
	public Task`1 workerTask; // 0x0
	public int timeout; // 0x0
	public CancellationTokenSource cts; // 0x0
	public Action abort; // 0x0
	public Func`1 aborted; // 0x0
	private ConfiguredTaskAwaiter <>u__1; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void MoveNext() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private WebCompletionSource <completion>5__2; // 0x40
	private WebOperation <operation>5__3; // 0x48
	private WebException <throwMe>5__4; // 0x50
	private HttpWebResponse <response>5__5; // 0x58
	private WebResponseStream <stream>5__6; // 0x60
	private bool <redirect>5__7; // 0x68
	private bool <mustReadAll>5__8; // 0x69
	private WebOperation <ntlm>5__9; // 0x70
	private BufferOffsetSize <writeBuffer>5__10; // 0x78
	private ConfiguredTaskAwaiter <>u__1; // 0x80
	private ConfiguredTaskAwaiter <>u__2; // 0x90
	private TaskAwaiter`1 <>u__3; // 0xA0
	private ConfiguredTaskAwaiter <>u__4; // 0xA8

	// Properties


	// Methods

	// RVA: 0x6CF6851C5C Offset: 0x17FAC5C VA: 0x6CF6851C5C
	private void MoveNext() { }

	// RVA: 0x6CF6852F48 Offset: 0x17FBF48 VA: 0x6CF6852F48
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <GetResponseFromData>d__244 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	public WebResponseStream stream; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private HttpWebResponse <response>5__2; // 0x48
	private WebException <throwMe>5__3; // 0x50
	private bool <redirect>5__4; // 0x58
	private bool <mustReadAll>5__5; // 0x59
	private ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredTaskAwaiter <>u__2; // 0x70

	// Properties


	// Methods

	// RVA: 0x6CF6852FC4 Offset: 0x17FBFC4 VA: 0x6CF6852FC4
	private void MoveNext() { }

	// RVA: 0x6CF6853A74 Offset: 0x17FCA74 VA: 0x6CF6853A74
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	private MemoryStream <ms>5__2; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF6853AF0 Offset: 0x17FCAF0 VA: 0x6CF6853AF0
	private void MoveNext() { }

	// RVA: 0x6CF6853F48 Offset: 0x17FCF48 VA: 0x6CF6853F48
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable
{
	// Fields

	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private AuthorizationState auth_state; // 0x168
	private AuthorizationState proxy_auth_state; // 0x178
	internal Func`2 ResendContentFactory; // 0x188
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Properties

	public Uri Address { get; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	public static int DefaultMaximumErrorResponseLength { get; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public Version ProtocolVersion { get; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x6CF6948C54 Offset: 0x18F1C54 VA: 0x6CF6948C54
	private static void .cctor() { }

	// RVA: 0x6CF6948AB4 Offset: 0x18F1AB4 VA: 0x6CF6948AB4
	public void .ctor(Uri uri) { }

	// RVA: 0x6CF6948D38 Offset: 0x18F1D38 VA: 0x6CF6948D38
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6948CD8 Offset: 0x18F1CD8 VA: 0x6CF6948CD8
	private void ResetAuthorization() { }

	// RVA: 0x6CF6948E5C Offset: 0x18F1E5C VA: 0x6CF6948E5C
	public Uri get_Address() { }

	// RVA: 0x6CF6948E64 Offset: 0x18F1E64 VA: 0x6CF6948E64
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x6CF6948E6C Offset: 0x18F1E6C VA: 0x6CF6948E6C
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x6CF6948E74 Offset: 0x18F1E74 VA: 0x6CF6948E74
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x6CF6948E88 Offset: 0x18F1E88 VA: 0x6CF6948E88
	private bool get_MethodWithBuffer() { }

	// RVA: 0x6CF6948F84 Offset: 0x18F1F84 VA: 0x6CF6948F84
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x6CF6948F8C Offset: 0x18F1F8C VA: 0x6CF6948F8C
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x6CF6948F94 Offset: 0x18F1F94 VA: 0x6CF6948F94
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x6CF6948FF8 Offset: 0x18F1FF8 VA: 0x6CF6948FF8
	public override long get_ContentLength() { }

	// RVA: 0x6CF6949000 Offset: 0x18F2000 VA: 0x6CF6949000
	internal void set_InternalContentLength(long value) { }

	// RVA: 0x6CF6949008 Offset: 0x18F2008 VA: 0x6CF6949008
	internal bool get_ThrowOnError() { }

	// RVA: 0x6CF6949010 Offset: 0x18F2010 VA: 0x6CF6949010
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x6CF694901C Offset: 0x18F201C VA: 0x6CF694901C
	public override ICredentials get_Credentials() { }

	// RVA: 0x6CF6949024 Offset: 0x18F2024 VA: 0x6CF6949024
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x6CF694902C Offset: 0x18F202C VA: 0x6CF694902C
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x6CF6949084 Offset: 0x18F2084 VA: 0x6CF6949084
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF694908C Offset: 0x18F208C VA: 0x6CF694908C
	public string get_Host() { }

	// RVA: 0x6CF6949194 Offset: 0x18F2194 VA: 0x6CF6949194
	public bool get_KeepAlive() { }

	// RVA: 0x6CF694919C Offset: 0x18F219C VA: 0x6CF694919C
	public int get_ReadWriteTimeout() { }

	// RVA: 0x6CF69491A4 Offset: 0x18F21A4 VA: 0x6CF69491A4
	public override string get_Method() { }

	// RVA: 0x6CF69491AC Offset: 0x18F21AC VA: 0x6CF69491AC
	public override void set_Method(string value) { }

	// RVA: 0x6CF69493D4 Offset: 0x18F23D4 VA: 0x6CF69493D4
	public Version get_ProtocolVersion() { }

	// RVA: 0x6CF69493DC Offset: 0x18F23DC VA: 0x6CF69493DC
	public override IWebProxy get_Proxy() { }

	// RVA: 0x6CF69493E4 Offset: 0x18F23E4 VA: 0x6CF69493E4
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x6CF694959C Offset: 0x18F259C VA: 0x6CF694959C
	public override Uri get_RequestUri() { }

	// RVA: 0x6CF69495A4 Offset: 0x18F25A4 VA: 0x6CF69495A4
	public bool get_SendChunked() { }

	// RVA: 0x6CF69495AC Offset: 0x18F25AC VA: 0x6CF69495AC
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x6CF69495B0 Offset: 0x18F25B0 VA: 0x6CF69495B0
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x6CF69495B8 Offset: 0x18F25B8 VA: 0x6CF69495B8
	public override int get_Timeout() { }

	// RVA: 0x6CF69495C0 Offset: 0x18F25C0 VA: 0x6CF69495C0
	public string get_TransferEncoding() { }

	// RVA: 0x6CF6949614 Offset: 0x18F2614 VA: 0x6CF6949614
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF694968C Offset: 0x18F268C VA: 0x6CF694968C
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x6CF6949694 Offset: 0x18F2694 VA: 0x6CF6949694
	internal bool get_ExpectContinue() { }

	// RVA: 0x6CF694969C Offset: 0x18F269C VA: 0x6CF694969C
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x6CF69496A8 Offset: 0x18F26A8 VA: 0x6CF69496A8
	internal Uri get_AuthUri() { }

	// RVA: 0x6CF69496B0 Offset: 0x18F26B0 VA: 0x6CF69496B0
	internal bool get_ProxyQuery() { }

	// RVA: 0x6CF69496E4 Offset: 0x18F26E4 VA: 0x6CF69496E4
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x6CF69496EC Offset: 0x18F26EC VA: 0x6CF69496EC
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x6CF694946C Offset: 0x18F246C VA: 0x6CF694946C
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x6CF6949704 Offset: 0x18F2704 VA: 0x6CF6949704
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal static Task`1 RunWithTimeout(Func`2 func, int timeout, Action abort, Func`1 aborted, CancellationToken cancellationToken) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private static Task`1 RunWithTimeoutWorker(Task`1 workerTask, int timeout, Action abort, Func`1 aborted, CancellationTokenSource cts) { }

	// RVA: 0x6CF5BD6D7C Offset: 0xB7FD7C VA: 0x6CF5BD6D7C
	private Task`1 RunWithTimeout(Func`2 func) { }

	// RVA: 0x6CF6949924 Offset: 0x18F2924 VA: 0x6CF6949924
	private Task`1 MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF6949A18 Offset: 0x18F2A18 VA: 0x6CF6949A18
	private Task`1 GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6949B10 Offset: 0x18F2B10 VA: 0x6CF6949B10
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x6CF6949BCC Offset: 0x18F2BCC VA: 0x6CF6949BCC
	private WebException GetWebException(Exception e) { }

	// RVA: 0x6CF6949C78 Offset: 0x18F2C78 VA: 0x6CF6949C78
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x6CF6949E1C Offset: 0x18F2E1C VA: 0x6CF6949E1C
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x6CF6949ED8 Offset: 0x18F2ED8 VA: 0x6CF6949ED8
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x6CF694A048 Offset: 0x18F3048 VA: 0x6CF694A048
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x6CF694A168 Offset: 0x18F3168 VA: 0x6CF694A168
	public override WebResponse GetResponse() { }

	// RVA: 0x6CF694A268 Offset: 0x18F3268 VA: 0x6CF694A268
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x6CF6949C50 Offset: 0x18F2C50 VA: 0x6CF6949C50
	internal bool get_Aborted() { }

	// RVA: 0x6CF694A274 Offset: 0x18F3274 VA: 0x6CF694A274
	public override void Abort() { }

	// RVA: 0x6CF694A384 Offset: 0x18F3384 VA: 0x6CF694A384
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF694A3BC Offset: 0x18F33BC VA: 0x6CF694A3BC
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6949410 Offset: 0x18F2410 VA: 0x6CF6949410
	private void CheckRequestStarted() { }

	// RVA: 0x6CF694A3F4 Offset: 0x18F33F4 VA: 0x6CF694A3F4
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x6CF694A410 Offset: 0x18F3410 VA: 0x6CF694A410
	private void RewriteRedirectToGet() { }

	// RVA: 0x6CF694A488 Offset: 0x18F3488 VA: 0x6CF694A488
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x6CF694A950 Offset: 0x18F3950 VA: 0x6CF694A950
	private string GetHeaders() { }

	// RVA: 0x6CF694AFA4 Offset: 0x18F3FA4 VA: 0x6CF694AFA4
	private void DoPreAuthenticate() { }

	// RVA: 0x6CF694B1A0 Offset: 0x18F41A0 VA: 0x6CF694B1A0
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0x6CF694B4AC Offset: 0x18F44AC VA: 0x6CF694B4AC
	private ValueTuple`2 HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF694B738 Offset: 0x18F4738 VA: 0x6CF694B738
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x6CF694B758 Offset: 0x18F4758 VA: 0x6CF694B758
	private ValueTuple`2 GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x6CF694B958 Offset: 0x18F4958 VA: 0x6CF694B958
	private ValueTuple`4 CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x6CF694BE04 Offset: 0x18F4E04 VA: 0x6CF694BE04
	private Task`1 <GetRewriteHandler>b__271_0() { }

	// RVA: 0x6CF694BEE0 Offset: 0x18F4EE0 VA: 0x6CF694BEE0
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	// Fields

	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties

	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x6CF6853FC4 Offset: 0x17FCFC4 VA: 0x6CF6853FC4
	public void .ctor() { }

	// RVA: 0x6CF6853FCC Offset: 0x17FCFCC VA: 0x6CF6853FCC
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x6CF685378C Offset: 0x17FC78C VA: 0x6CF685378C
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x6CF6854294 Offset: 0x17FD294 VA: 0x6CF6854294
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6854630 Offset: 0x17FD630 VA: 0x6CF6854630
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF6854638 Offset: 0x17FD638 VA: 0x6CF6854638
	public override Uri get_ResponseUri() { }

	// RVA: 0x6CF68546CC Offset: 0x17FD6CC VA: 0x6CF68546CC
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x6CF68546D4 Offset: 0x17FD6D4 VA: 0x6CF68546D4
	public virtual string get_StatusDescription() { }

	// RVA: 0x6CF68546EC Offset: 0x17FD6EC VA: 0x6CF68546EC
	public override Stream GetResponseStream() { }

	// RVA: 0x6CF6854788 Offset: 0x17FD788 VA: 0x6CF6854788
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6854794 Offset: 0x17FD794 VA: 0x6CF6854794
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6854954 Offset: 0x17FD954 VA: 0x6CF6854954
	public override void Close() { }

	// RVA: 0x6CF6854984 Offset: 0x17FD984 VA: 0x6CF6854984
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF6854994 Offset: 0x17FD994 VA: 0x6CF6854994
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF6854650 Offset: 0x17FD650 VA: 0x6CF6854650
	private void CheckDisposed() { }

	// RVA: 0x6CF6854080 Offset: 0x17FD080 VA: 0x6CF6854080
	private void FillCookies() { }

}

// Dll : System.dll
// Namespace: System.Net
public interface ICredentialPolicy
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private enum State
{
	// Fields

	public int value__; // 0x10
	public const State None = 0; // 0x0
	public const State PartialSize = 1; // 0x0
	public const State Body = 2; // 0x0
	public const State BodyFinished = 3; // 0x0
	public const State Trailer = 4; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private class Chunk : Object
{
	// Fields

	public Byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF6855840 Offset: 0x17FE840 VA: 0x6CF6855840
	public void .ctor(Byte[] chunk) { }

	// RVA: 0x6CF6854D70 Offset: 0x17FDD70 VA: 0x6CF6854D70
	public int Read(Byte[] buffer, int offset, int size) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class MonoChunkParser : Object
{
	// Fields

	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties

	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x6CF68549A8 Offset: 0x17FD9A8 VA: 0x6CF68549A8
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x6CF6854A54 Offset: 0x17FDA54 VA: 0x6CF6854A54
	public int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6854A58 Offset: 0x17FDA58 VA: 0x6CF6854A58
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6854DD0 Offset: 0x17FDDD0 VA: 0x6CF6854DD0
	public void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6854DF0 Offset: 0x17FDDF0 VA: 0x6CF6854DF0
	private void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x6CF6855710 Offset: 0x17FE710 VA: 0x6CF6855710
	public bool get_WantMore() { }

	// RVA: 0x6CF6855734 Offset: 0x17FE734 VA: 0x6CF6855734
	public bool get_DataAvailable() { }

	// RVA: 0x6CF6855834 Offset: 0x17FE834 VA: 0x6CF6855834
	public int get_ChunkLeft() { }

	// RVA: 0x6CF6855224 Offset: 0x17FE224 VA: 0x6CF6855224
	private State ReadBody(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x6CF6854F2C Offset: 0x17FDF2C VA: 0x6CF6854F2C
	private State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x6CF68558B8 Offset: 0x17FE8B8 VA: 0x6CF68558B8
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x6CF6855358 Offset: 0x17FE358 VA: 0x6CF6855358
	private State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x6CF6855458 Offset: 0x17FE458 VA: 0x6CF6855458
	private State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x6CF6855868 Offset: 0x17FE868 VA: 0x6CF6855868
	private static void ThrowProtocolViolation(string message) { }

}

// Dll : System.dll
// Namespace: 
private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public MonoChunkStream <>4__this; // 0x38
	public Byte[] buffer; // 0x40
	public int offset; // 0x48
	public int size; // 0x4C
	private Byte[] <moreBytes>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF6855D54 Offset: 0x17FED54 VA: 0x6CF6855D54
	private void MoveNext() { }

	// RVA: 0x6CF685613C Offset: 0x17FF13C VA: 0x6CF685613C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <FinishReading>d__8 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public MonoChunkStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40
	private Byte[] <buffer>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF68561B8 Offset: 0x17FF1B8 VA: 0x6CF68561B8
	private void MoveNext() { }

	// RVA: 0x6CF685660C Offset: 0x17FF60C VA: 0x6CF685660C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class MonoChunkStream : WebReadStream
{
	// Fields

	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties

	protected MonoChunkParser Decoder { get; }

	// Methods

	// RVA: 0x6CF6855900 Offset: 0x17FE900 VA: 0x6CF6855900
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x6CF6855908 Offset: 0x17FE908 VA: 0x6CF6855908
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x6CF6855A00 Offset: 0x17FEA00 VA: 0x6CF6855A00
	protected override Task`1 ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6855B1C Offset: 0x17FEB1C VA: 0x6CF6855B1C
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x6CF6855BF4 Offset: 0x17FEBF4 VA: 0x6CF6855BF4
	private static void ThrowExpectingChunkTrailer() { }

	// RVA: 0x6CF6855C4C Offset: 0x17FEC4C VA: 0x6CF6855C4C
	private Task <>n__0(CancellationToken cancellationToken) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class NtlmClient : Object, IAuthenticationModule
{
	// Fields

	private IAuthenticationModule authObject; // 0x10

	// Properties

	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x6CF6856674 Offset: 0x17FF674 VA: 0x6CF6856674
	public void .ctor() { }

	// RVA: 0x6CF68566D8 Offset: 0x17FF6D8 VA: 0x6CF68566D8
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF68567A8 Offset: 0x17FF7A8 VA: 0x6CF68567A8
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x6CF68567B0 Offset: 0x17FF7B0 VA: 0x6CF68567B0
	public string get_AuthenticationType() { }

}

// Dll : System.dll
// Namespace: System.Net
public class ServicePoint : Object
{
	// Fields

	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	private readonly SPKey <Key>k__BackingField; // 0x68
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties

	internal SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x6CF68567F0 Offset: 0x17FF7F0 VA: 0x6CF68567F0
	internal void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x6CF6856AA0 Offset: 0x17FFAA0 VA: 0x6CF6856AA0
	internal SPKey get_Key() { }

	// RVA: 0x6CF6856AA8 Offset: 0x17FFAA8 VA: 0x6CF6856AA8
	private ServicePointScheduler get_Scheduler() { }

	// RVA: 0x6CF6856AB0 Offset: 0x17FFAB0 VA: 0x6CF6856AB0
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x6CF6856AB8 Offset: 0x17FFAB8 VA: 0x6CF6856AB8
	public Uri get_Address() { }

	// RVA: 0x6CF6856AC0 Offset: 0x17FFAC0 VA: 0x6CF6856AC0
	public int get_ConnectionLimit() { }

	// RVA: 0x6CF6856AC8 Offset: 0x17FFAC8 VA: 0x6CF6856AC8
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x6CF6856AD0 Offset: 0x17FFAD0 VA: 0x6CF6856AD0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x6CF6856ADC Offset: 0x17FFADC VA: 0x6CF6856ADC
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x6CF6856AE4 Offset: 0x17FFAE4 VA: 0x6CF6856AE4
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x6CF6856AF0 Offset: 0x17FFAF0 VA: 0x6CF6856AF0
	internal bool get_SendContinue() { }

	// RVA: 0x6CF6856B8C Offset: 0x17FFB8C VA: 0x6CF6856B8C
	internal void set_SendContinue(bool value) { }

	// RVA: 0x6CF6856B98 Offset: 0x17FFB98 VA: 0x6CF6856B98
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x6CF6856C48 Offset: 0x17FFC48 VA: 0x6CF6856C48
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x6CF6856CFC Offset: 0x17FFCFC VA: 0x6CF6856CFC
	private static void PutBytes(Byte[] bytes, uint v, int offset) { }

	// RVA: 0x6CF6856D7C Offset: 0x17FFD7C VA: 0x6CF6856D7C
	internal bool get_UsesProxy() { }

	// RVA: 0x6CF6856D84 Offset: 0x17FFD84 VA: 0x6CF6856D84
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x6CF6856D90 Offset: 0x17FFD90 VA: 0x6CF6856D90
	internal bool get_UseConnect() { }

	// RVA: 0x6CF6856D98 Offset: 0x17FFD98 VA: 0x6CF6856D98
	internal void set_UseConnect(bool value) { }

	// RVA: 0x6CF6856DA4 Offset: 0x17FFDA4 VA: 0x6CF6856DA4
	private bool get_HasTimedOut() { }

	// RVA: 0x6CF6856ED0 Offset: 0x17FFED0 VA: 0x6CF6856ED0
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x6CF6857254 Offset: 0x1800254 VA: 0x6CF6857254
	internal void SetVersion(Version version) { }

	// RVA: 0x6CF685725C Offset: 0x180025C VA: 0x6CF685725C
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x6CF68574B4 Offset: 0x18004B4 VA: 0x6CF68574B4
	internal void FreeServicePoint() { }

	// RVA: 0x6CF68574C4 Offset: 0x18004C4 VA: 0x6CF68574C4
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x6CF68574F8 Offset: 0x18004F8 VA: 0x6CF68574F8
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x6CF685752C Offset: 0x180052C VA: 0x6CF685752C
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

}

// Dll : System.dll
// Namespace: 
internal class SPKey : Object
{
	// Fields

	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties

	public bool UsesProxy { get; }

	// Methods

	// RVA: 0x6CF6858034 Offset: 0x1801034 VA: 0x6CF6858034
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x6CF6858108 Offset: 0x1801108 VA: 0x6CF6858108
	public bool get_UsesProxy() { }

	// RVA: 0x6CF6858168 Offset: 0x1801168 VA: 0x6CF6858168
	public override int GetHashCode() { }

	// RVA: 0x6CF685823C Offset: 0x180123C VA: 0x6CF685823C
	public override bool Equals(object obj) { }

}

// Dll : System.dll
// Namespace: System.Net
public class ServicePointManager : Object
{
	// Fields

	private static ConcurrentDictionary`2 servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties

	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }

	// Methods

	// RVA: 0x6CF68576D0 Offset: 0x18006D0 VA: 0x6CF68576D0
	private static void .cctor() { }

	// RVA: 0x6CF6857780 Offset: 0x1800780 VA: 0x6CF6857780
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x6CF68577D8 Offset: 0x18007D8 VA: 0x6CF68577D8
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x6CF6857830 Offset: 0x1800830 VA: 0x6CF6857830
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x6CF6857888 Offset: 0x1800888 VA: 0x6CF6857888
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x6CF68578E0 Offset: 0x18008E0 VA: 0x6CF68578E0
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x6CF6857938 Offset: 0x1800938 VA: 0x6CF6857938
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x6CF68579C0 Offset: 0x18009C0 VA: 0x6CF68579C0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x6CF6858070 Offset: 0x1801070 VA: 0x6CF6858070
	internal static void RemoveServicePoint(ServicePoint sp) { }

}

// Dll : System.dll
// Namespace: 
private class ConnectionGroup : Object
{
	// Fields

	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private LinkedList`1 connections; // 0x28
	private LinkedList`1 queue; // 0x30

	// Properties

	public ServicePointScheduler Scheduler { get; }

	// Methods

	// RVA: 0x6CF6859B40 Offset: 0x1802B40 VA: 0x6CF6859B40
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x6CF68583E8 Offset: 0x18013E8 VA: 0x6CF68583E8
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x6CF6858A68 Offset: 0x1801A68 VA: 0x6CF6858A68
	public bool IsEmpty() { }

	// RVA: 0x6CF6859188 Offset: 0x1802188 VA: 0x6CF6859188
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x6CF68592DC Offset: 0x18022DC VA: 0x6CF68592DC
	public void Cleanup() { }

	// RVA: 0x6CF68599BC Offset: 0x18029BC VA: 0x6CF68599BC
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x6CF6859598 Offset: 0x1802598 VA: 0x6CF6859598
	public WebOperation GetNextOperation() { }

	// RVA: 0x6CF6859BB0 Offset: 0x1802BB0 VA: 0x6CF6859BB0
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x6CF68593C8 Offset: 0x18023C8 VA: 0x6CF68593C8
	public ValueTuple`2 CreateOrReuseConnection(WebOperation operation, bool force) { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`2 <>9__4_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF685A568 Offset: 0x1803568 VA: 0x6CF685A568
	private static void .cctor() { }

	// RVA: 0x6CF685A5C4 Offset: 0x18035C4 VA: 0x6CF685A5C4
	public void .ctor() { }

	// RVA: 0x6CF685A5CC Offset: 0x18035CC VA: 0x6CF685A5CC
	internal bool <Set>b__4_0(object s) { }

}

// Dll : System.dll
// Namespace: 
private class AsyncManualResetEvent : Object
{
	// Fields

	private TaskCompletionSource`1 m_tcs; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF685A514 Offset: 0x1803514 VA: 0x6CF685A514
	public Task`1 WaitAsync(int millisecondTimeout) { }

	// RVA: 0x6CF68585B4 Offset: 0x18015B4 VA: 0x6CF68585B4
	public void Set() { }

	// RVA: 0x6CF6858C68 Offset: 0x1801C68 VA: 0x6CF6858C68
	public void Reset() { }

	// RVA: 0x6CF6858348 Offset: 0x1801348 VA: 0x6CF6858348
	public void .ctor(bool state) { }

}

// Dll : System.dll
// Namespace: 
private struct <RunScheduler>d__32 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ServicePointScheduler <>4__this; // 0x30
	private ValueTuple`2[] <operationArray>5__2; // 0x38
	private ValueTuple`3[] <idleArray>5__3; // 0x40
	private List`1 <taskList>5__4; // 0x48
	private Task`1 <schedulerTask>5__5; // 0x50
	private bool <finalCleanup>5__6; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF685A668 Offset: 0x1803668 VA: 0x6CF685A668
	private void MoveNext() { }

	// RVA: 0x6CF685B1B0 Offset: 0x18041B0 VA: 0x6CF685B1B0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <WaitAsync>d__46 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public int millisecondTimeout; // 0x30
	public Task workerTask; // 0x38
	private CancellationTokenSource <cts>5__2; // 0x40
	private Task <timeoutTask>5__3; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF685B218 Offset: 0x1804218 VA: 0x6CF685B218
	private void MoveNext() { }

	// RVA: 0x6CF685B6B8 Offset: 0x18046B8 VA: 0x6CF685B6B8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class ServicePointScheduler : Object
{
	// Fields

	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private AsyncManualResetEvent schedulerEvent; // 0x20
	private ConnectionGroup defaultGroup; // 0x28
	private Dictionary`2 groups; // 0x30
	private LinkedList`1 operations; // 0x38
	private LinkedList`1 idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties

	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; }

	// Methods

	// RVA: 0x6CF6858330 Offset: 0x1801330 VA: 0x6CF6858330
	private ServicePoint get_ServicePoint() { }

	// RVA: 0x6CF6858338 Offset: 0x1801338 VA: 0x6CF6858338
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x6CF6858340 Offset: 0x1801340 VA: 0x6CF6858340
	public int get_MaxIdleTime() { }

	// RVA: 0x6CF68568CC Offset: 0x17FF8CC VA: 0x6CF68568CC
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x6CF68584F0 Offset: 0x18014F0 VA: 0x6CF68584F0
	public void Run() { }

	// RVA: 0x6CF68587E0 Offset: 0x18017E0 VA: 0x6CF68587E0
	private Task RunScheduler() { }

	// RVA: 0x6CF68588A8 Offset: 0x18018A8 VA: 0x6CF68588A8
	private void Cleanup() { }

	// RVA: 0x6CF6858ADC Offset: 0x1801ADC VA: 0x6CF6858ADC
	private void RunSchedulerIteration() { }

	// RVA: 0x6CF6858E08 Offset: 0x1801E08 VA: 0x6CF6858E08
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x6CF6859560 Offset: 0x1802560 VA: 0x6CF6859560
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x6CF6858D28 Offset: 0x1801D28 VA: 0x6CF6858D28
	private bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x6CF6859680 Offset: 0x1802680 VA: 0x6CF6859680
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x6CF6859210 Offset: 0x1802210 VA: 0x6CF6859210
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x6CF685974C Offset: 0x180274C VA: 0x6CF685974C
	private void FinalCleanup() { }

	// RVA: 0x6CF68573CC Offset: 0x18003CC VA: 0x6CF68573CC
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x6CF68597CC Offset: 0x18027CC VA: 0x6CF68597CC
	private ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x6CF6859A14 Offset: 0x1802A14 VA: 0x6CF6859A14
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x6CF6859A20 Offset: 0x1802A20 VA: 0x6CF6859A20
	private void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x6CF6859A3C Offset: 0x1802A3C VA: 0x6CF6859A3C
	public static Task`1 WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x6CF6859B3C Offset: 0x1802B3C VA: 0x6CF6859B3C
	private Task <Run>b__31_0() { }

}

// Dll : System.dll
// Namespace: 
internal enum Status
{
	// Fields

	public int value__; // 0x0
	public const Status Running = 0; // 0x0
	public const Status Completed = 1; // 0x0
	public const Status Canceled = 2; // 0x0
	public const Status Faulted = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
internal class Result : Object
{
	// Fields

	private readonly Status <Status>k__BackingField; // 0x0
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x0
	private readonly T <Argument>k__BackingField; // 0x0

	// Properties

	public Status Status { get; }
	public bool Success { get; }
	public ExceptionDispatchInfo Error { get; }
	public T Argument { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Status get_Status() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool get_Success() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Argument() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(T argument) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(Status state, ExceptionDispatchInfo error) { }

}

// Dll : System.dll
// Namespace: 
private struct <WaitForCompletion>d__15 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x0
	public WebCompletionSource`1 <>4__this; // 0x0
	private ConfiguredTaskAwaiter <>u__1; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void MoveNext() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebCompletionSource`1 : Object
{
	// Fields

	private TaskCompletionSource`1 completion; // 0x0
	private Result currentResult; // 0x0

	// Properties

	internal Result CurrentResult { get; }
	internal Task Task { get; }

	// Methods

	// RVA: 0x6CF5BD72B8 Offset: 0xB802B8 VA: 0x6CF5BD72B8
	public void .ctor(bool runAsync) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	internal Result get_CurrentResult() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	internal Task get_Task() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool TrySetCompleted(T argument) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool TrySetCompleted() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool TrySetCanceled() { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public bool TrySetException(Exception error) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void ThrowOnError() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public Task`1 WaitForCompletion() { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebCompletionSource : WebCompletionSource`1
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6852B34 Offset: 0x17FBB34 VA: 0x6CF6852B34
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net
internal enum ReadState
{
	// Fields

	public int value__; // 0x10
	public const ReadState None = 0; // 0x0
	public const ReadState Status = 1; // 0x0
	public const ReadState Headers = 2; // 0x0
	public const ReadState Content = 3; // 0x0
	public const ReadState Aborted = 4; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`4 <>9__16_0; // 0x8
	public static Action`1 <>9__16_1; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF685C8AC Offset: 0x18058AC VA: 0x6CF685C8AC
	private static void .cctor() { }

	// RVA: 0x6CF685C908 Offset: 0x1805908 VA: 0x6CF685C908
	public void .ctor() { }

	// RVA: 0x6CF685C910 Offset: 0x1805910 VA: 0x6CF685C910
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x6CF685C9B0 Offset: 0x18059B0 VA: 0x6CF685C9B0
	internal void <Connect>b__16_1(IAsyncResult asyncResult) { }

}

// Dll : System.dll
// Namespace: 
private struct <Connect>d__16 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebConnection <>4__this; // 0x30
	public WebOperation operation; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private Exception <connectException>5__2; // 0x48
	private IPAddress[] <>7__wrap2; // 0x50
	private int <>7__wrap3; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF685CAA4 Offset: 0x1805AA4 VA: 0x6CF685CAA4
	private void MoveNext() { }

	// RVA: 0x6CF685D4BC Offset: 0x18064BC VA: 0x6CF685D4BC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <CreateStream>d__18 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public WebConnection <>4__this; // 0x30
	public WebOperation operation; // 0x38
	public bool reused; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private NetworkStream <stream>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58
	private ConfiguredTaskAwaiter <>u__2; // 0x68

	// Properties


	// Methods

	// RVA: 0x6CF685D524 Offset: 0x1806524 VA: 0x6CF685D524
	private void MoveNext() { }

	// RVA: 0x6CF685DD10 Offset: 0x1806D10 VA: 0x6CF685DD10
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <InitConnection>d__19 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public WebOperation operation; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public WebConnection <>4__this; // 0x40
	private bool <reused>5__2; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF685DD8C Offset: 0x1806D8C VA: 0x6CF685DD8C
	private void MoveNext() { }

	// RVA: 0x6CF685E4B0 Offset: 0x18074B0 VA: 0x6CF685E4B0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebConnection : Object, IDisposable
{
	// Fields

	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties

	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x6CF685B734 Offset: 0x1804734 VA: 0x6CF685B734
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x6CF685A4EC Offset: 0x18034EC VA: 0x6CF685A4EC
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x6CF685B73C Offset: 0x180473C VA: 0x6CF685B73C
	private bool CanReuse() { }

	// RVA: 0x6CF685B76C Offset: 0x180476C VA: 0x6CF685B76C
	private bool CheckReusable() { }

	// RVA: 0x6CF685B808 Offset: 0x1804808 VA: 0x6CF685B808
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x6CF685B8E4 Offset: 0x18048E4 VA: 0x6CF685B8E4
	private Task`1 CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x6CF685BA00 Offset: 0x1804A00 VA: 0x6CF685BA00
	internal Task`1 InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x6CF685BAF4 Offset: 0x1804AF4 VA: 0x6CF685BAF4
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x6CF685BC74 Offset: 0x1804C74 VA: 0x6CF685BC74
	internal static bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x6CF6859ECC Offset: 0x1802ECC VA: 0x6CF6859ECC
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x6CF685BE40 Offset: 0x1804E40 VA: 0x6CF685BE40
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x6CF685C15C Offset: 0x180515C VA: 0x6CF685C15C
	private void Reset() { }

	// RVA: 0x6CF685C220 Offset: 0x1805220 VA: 0x6CF685C220
	private void Close(bool reset) { }

	// RVA: 0x6CF685C2E8 Offset: 0x18052E8 VA: 0x6CF685C2E8
	private void CloseSocket() { }

	// RVA: 0x6CF6859B50 Offset: 0x1802B50 VA: 0x6CF6859B50
	public bool get_Closed() { }

	// RVA: 0x6CF685C544 Offset: 0x1805544 VA: 0x6CF685C544
	public DateTime get_IdleSince() { }

	// RVA: 0x6CF685A2F8 Offset: 0x18032F8 VA: 0x6CF685A2F8
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x6CF6859028 Offset: 0x1802028 VA: 0x6CF6859028
	public bool Continue(WebOperation next) { }

	// RVA: 0x6CF685C83C Offset: 0x180583C VA: 0x6CF685C83C
	private void Dispose(bool disposing) { }

	// RVA: 0x6CF6859B48 Offset: 0x1802B48 VA: 0x6CF6859B48
	public void Dispose() { }

	// RVA: 0x6CF685C214 Offset: 0x1805214 VA: 0x6CF685C214
	private void ResetNtlm() { }

	// RVA: 0x6CF685C874 Offset: 0x1805874 VA: 0x6CF685C874
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x6CF685C87C Offset: 0x180587C VA: 0x6CF685C87C
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x6CF685C888 Offset: 0x1805888 VA: 0x6CF685C888
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x6CF685C890 Offset: 0x1805890 VA: 0x6CF685C890
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x6CF685C898 Offset: 0x1805898 VA: 0x6CF685C898
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x6CF685C8A0 Offset: 0x18058A0 VA: 0x6CF685C8A0
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

}

// Dll : System.dll
// Namespace: System.Net
internal abstract class WebConnectionStream : Stream
{
	// Fields

	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Properties

	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x6CF685E52C Offset: 0x180752C VA: 0x6CF685E52C
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x6CF685E5EC Offset: 0x18075EC VA: 0x6CF685E5EC
	internal HttpWebRequest get_Request() { }

	// RVA: 0x6CF685E5F4 Offset: 0x18075F4 VA: 0x6CF685E5F4
	internal WebConnection get_Connection() { }

	// RVA: 0x6CF685E5FC Offset: 0x18075FC VA: 0x6CF685E5FC
	internal WebOperation get_Operation() { }

	// RVA: 0x6CF685E604 Offset: 0x1807604 VA: 0x6CF685E604
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x6CF685E620 Offset: 0x1807620 VA: 0x6CF685E620
	public override bool get_CanTimeout() { }

	// RVA: 0x6CF685E628 Offset: 0x1807628 VA: 0x6CF685E628
	public override int get_ReadTimeout() { }

	// RVA: 0x6CF685E630 Offset: 0x1807630 VA: 0x6CF685E630
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x6CF685E690 Offset: 0x1807690 VA: 0x6CF685E690
	public override int get_WriteTimeout() { }

	// RVA: 0x6CF685E698 Offset: 0x1807698 VA: 0x6CF685E698
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x6CF685E6F8 Offset: 0x18076F8 VA: 0x6CF685E6F8
	protected Exception GetException(Exception e) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, ref int result) { }

	// RVA: 0x6CF685E860 Offset: 0x1807860 VA: 0x6CF685E860
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF685EB54 Offset: 0x1807B54 VA: 0x6CF685EB54
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x6CF685ED14 Offset: 0x1807D14 VA: 0x6CF685ED14
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x6CF685EE34 Offset: 0x1807E34 VA: 0x6CF685EE34
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x6CF685EFF4 Offset: 0x1807FF4 VA: 0x6CF685EFF4
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x6CF685F0E8 Offset: 0x18080E8 VA: 0x6CF685F0E8
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF685F2D0 Offset: 0x18082D0 VA: 0x6CF685F2D0
	public override void Flush() { }

	// RVA: 0x6CF685F2D4 Offset: 0x18082D4 VA: 0x6CF685F2D4
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF685F3B8 Offset: 0x18083B8 VA: 0x6CF685F3B8
	internal void InternalClose() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	protected abstract void Close_internal(ref bool disposed) { }

	// RVA: 0x6CF685F3C4 Offset: 0x18083C4 VA: 0x6CF685F3C4
	public override void Close() { }

	// RVA: 0x6CF685F3D8 Offset: 0x18083D8 VA: 0x6CF685F3D8
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x6CF685F424 Offset: 0x1808424 VA: 0x6CF685F424
	public override void SetLength(long a) { }

	// RVA: 0x6CF685F470 Offset: 0x1808470 VA: 0x6CF685F470
	public override bool get_CanSeek() { }

	// RVA: 0x6CF685F478 Offset: 0x1808478 VA: 0x6CF685F478
	public override long get_Length() { }

	// RVA: 0x6CF685F4C4 Offset: 0x18084C4 VA: 0x6CF685F4C4
	public override long get_Position() { }

	// RVA: 0x6CF685F510 Offset: 0x1808510 VA: 0x6CF685F510
	public override void set_Position(long value) { }

}

// Dll : System.dll
// Namespace: 
private enum NtlmAuthState
{
	// Fields

	public int value__; // 0x10
	public const NtlmAuthState None = 0; // 0x0
	public const NtlmAuthState Challenge = 1; // 0x0
	public const NtlmAuthState Response = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct <Initialize>d__42 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebConnectionTunnel <>4__this; // 0x30
	public Stream stream; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private bool <have_auth>5__2; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF685F778 Offset: 0x1808778 VA: 0x6CF685F778
	private void MoveNext() { }

	// RVA: 0x6CF68604A8 Offset: 0x18094A8 VA: 0x6CF68604A8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <ReadHeaders>d__43 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public Stream stream; // 0x38
	public WebConnectionTunnel <>4__this; // 0x40
	private Byte[] <retBuffer>5__2; // 0x48
	private int <status>5__3; // 0x50
	private Byte[] <buffer>5__4; // 0x58
	private MemoryStream <ms>5__5; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68

	// Properties


	// Methods

	// RVA: 0x6CF6860510 Offset: 0x1809510 VA: 0x6CF6860510
	private void MoveNext() { }

	// RVA: 0x6CF6860D50 Offset: 0x1809D50 VA: 0x6CF6860D50
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebConnectionTunnel : Object
{
	// Fields

	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private NtlmAuthState ntlmAuthState; // 0x28
	private bool <Success>k__BackingField; // 0x2C
	private bool <CloseConnection>k__BackingField; // 0x2D
	private int <StatusCode>k__BackingField; // 0x30
	private string <StatusDescription>k__BackingField; // 0x38
	private String[] <Challenge>k__BackingField; // 0x40
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	private Version <ProxyVersion>k__BackingField; // 0x50
	private Byte[] <Data>k__BackingField; // 0x58

	// Properties

	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public String[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public Byte[] Data { get; set; }

	// Methods

	// RVA: 0x6CF685F55C Offset: 0x180855C VA: 0x6CF685F55C
	public HttpWebRequest get_Request() { }

	// RVA: 0x6CF685F564 Offset: 0x1808564 VA: 0x6CF685F564
	public Uri get_ConnectUri() { }

	// RVA: 0x6CF685DC08 Offset: 0x1806C08 VA: 0x6CF685DC08
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x6CF685F56C Offset: 0x180856C VA: 0x6CF685F56C
	public bool get_Success() { }

	// RVA: 0x6CF685F574 Offset: 0x1808574 VA: 0x6CF685F574
	private void set_Success(bool value) { }

	// RVA: 0x6CF685F580 Offset: 0x1808580 VA: 0x6CF685F580
	public bool get_CloseConnection() { }

	// RVA: 0x6CF685F588 Offset: 0x1808588 VA: 0x6CF685F588
	private void set_CloseConnection(bool value) { }

	// RVA: 0x6CF685F594 Offset: 0x1808594 VA: 0x6CF685F594
	public int get_StatusCode() { }

	// RVA: 0x6CF685F59C Offset: 0x180859C VA: 0x6CF685F59C
	private void set_StatusCode(int value) { }

	// RVA: 0x6CF685F5A4 Offset: 0x18085A4 VA: 0x6CF685F5A4
	private void set_StatusDescription(string value) { }

	// RVA: 0x6CF685F5AC Offset: 0x18085AC VA: 0x6CF685F5AC
	public String[] get_Challenge() { }

	// RVA: 0x6CF685F5B4 Offset: 0x18085B4 VA: 0x6CF685F5B4
	private void set_Challenge(String[] value) { }

	// RVA: 0x6CF685F5BC Offset: 0x18085BC VA: 0x6CF685F5BC
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF685F5C4 Offset: 0x18085C4 VA: 0x6CF685F5C4
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x6CF685F5CC Offset: 0x18085CC VA: 0x6CF685F5CC
	public Version get_ProxyVersion() { }

	// RVA: 0x6CF685F5D4 Offset: 0x18085D4 VA: 0x6CF685F5D4
	private void set_ProxyVersion(Version value) { }

	// RVA: 0x6CF685F5DC Offset: 0x18085DC VA: 0x6CF685F5DC
	public Byte[] get_Data() { }

	// RVA: 0x6CF685F5E4 Offset: 0x18085E4 VA: 0x6CF685F5E4
	private void set_Data(Byte[] value) { }

	// RVA: 0x6CF685DC34 Offset: 0x1806C34 VA: 0x6CF685DC34
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x6CF685F5EC Offset: 0x18085EC VA: 0x6CF685F5EC
	private Task`1 ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x6CF685F6E4 Offset: 0x18086E4 VA: 0x6CF685F6E4
	private void FlushContents(Stream stream, int contentLength) { }

}

// Dll : System.dll
// Namespace: 
private struct <Run>d__58 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public WebOperation <>4__this; // 0x38
	private WebRequestStream <requestStream>5__2; // 0x40
	private WebResponseStream <stream>5__3; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF686166C Offset: 0x180A66C VA: 0x6CF686166C
	private void MoveNext() { }

	// RVA: 0x6CF6861CD4 Offset: 0x180ACD4 VA: 0x6CF6861CD4
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebOperation : Object
{
	// Fields

	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	private WebConnection <Connection>k__BackingField; // 0x18
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource`1 requestTask; // 0x40
	private WebCompletionSource`1 requestWrittenTask; // 0x48
	private WebCompletionSource`1 responseTask; // 0x50
	private WebCompletionSource`1 finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties

	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource`1 Finished { get; }

	// Methods

	// RVA: 0x6CF6860DCC Offset: 0x1809DCC VA: 0x6CF6860DCC
	public HttpWebRequest get_Request() { }

	// RVA: 0x6CF6860DD4 Offset: 0x1809DD4 VA: 0x6CF6860DD4
	public WebConnection get_Connection() { }

	// RVA: 0x6CF6860DDC Offset: 0x1809DDC VA: 0x6CF6860DDC
	private void set_Connection(WebConnection value) { }

	// RVA: 0x6CF6860DE4 Offset: 0x1809DE4 VA: 0x6CF6860DE4
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x6CF6860DEC Offset: 0x1809DEC VA: 0x6CF6860DEC
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x6CF6860DF4 Offset: 0x1809DF4 VA: 0x6CF6860DF4
	public BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x6CF6860DFC Offset: 0x1809DFC VA: 0x6CF6860DFC
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x6CF6860E04 Offset: 0x1809E04 VA: 0x6CF6860E04
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6859B60 Offset: 0x1802B60 VA: 0x6CF6859B60
	public bool get_Aborted() { }

	// RVA: 0x6CF6860F98 Offset: 0x1809F98 VA: 0x6CF6860F98
	public bool get_Closed() { }

	// RVA: 0x6CF6860FC4 Offset: 0x1809FC4 VA: 0x6CF6860FC4
	public void Abort() { }

	// RVA: 0x6CF68611B4 Offset: 0x180A1B4 VA: 0x6CF68611B4
	public void Close() { }

	// RVA: 0x6CF68610EC Offset: 0x180A0EC VA: 0x6CF68610EC
	private void SetCanceled() { }

	// RVA: 0x6CF6861260 Offset: 0x180A260 VA: 0x6CF6861260
	private void SetError(Exception error) { }

	// RVA: 0x6CF6861004 Offset: 0x180A004 VA: 0x6CF6861004
	private ValueTuple`2 SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x6CF6861304 Offset: 0x180A304 VA: 0x6CF6861304
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x6CF68613E4 Offset: 0x180A3E4 VA: 0x6CF68613E4
	internal void ThrowIfDisposed() { }

	// RVA: 0x6CF685D43C Offset: 0x180643C VA: 0x6CF685D43C
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x6CF685EAF4 Offset: 0x1807AF4 VA: 0x6CF685EAF4
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x6CF685E2C0 Offset: 0x18072C0 VA: 0x6CF685E2C0
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x6CF686138C Offset: 0x180A38C VA: 0x6CF686138C
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x6CF685C54C Offset: 0x180554C VA: 0x6CF685C54C
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x6CF6861444 Offset: 0x180A444 VA: 0x6CF6861444
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x6CF6852B98 Offset: 0x17FBB98 VA: 0x6CF6852B98
	internal Task`1 GetRequestStreamInternal() { }

	// RVA: 0x6CF6852B80 Offset: 0x17FBB80 VA: 0x6CF6852B80
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x6CF6852CBC Offset: 0x17FBCBC VA: 0x6CF6852CBC
	public Task`1 GetResponseStream() { }

	// RVA: 0x6CF68615C0 Offset: 0x180A5C0 VA: 0x6CF68615C0
	internal WebCompletionSource`1 get_Finished() { }

	// RVA: 0x6CF685C7AC Offset: 0x18057AC VA: 0x6CF685C7AC
	internal void Run() { }

	// RVA: 0x6CF68615C8 Offset: 0x180A5C8 VA: 0x6CF68615C8
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x6CF6852D0C Offset: 0x17FBD0C VA: 0x6CF6852D0C
	internal void Finish(bool ok, Exception error) { }

	// RVA: 0x6CF6861648 Offset: 0x180A648 VA: 0x6CF6861648
	private void <RegisterRequest>b__48_0() { }

}

// Dll : System.dll
// Namespace: 
private struct <ReadAsync>d__28 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public WebReadStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public Byte[] buffer; // 0x40
	public int offset; // 0x48
	public int size; // 0x4C
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF6862694 Offset: 0x180B694 VA: 0x6CF6862694
	private void MoveNext() { }

	// RVA: 0x6CF6862C58 Offset: 0x180BC58 VA: 0x6CF6862C58
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal abstract class WebReadStream : Stream
{
	// Fields

	private readonly WebOperation <Operation>k__BackingField; // 0x28
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties

	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x6CF6861CE0 Offset: 0x180ACE0 VA: 0x6CF6861CE0
	public WebOperation get_Operation() { }

	// RVA: 0x6CF6861CE8 Offset: 0x180ACE8 VA: 0x6CF6861CE8
	protected Stream get_InnerStream() { }

	// RVA: 0x6CF6855990 Offset: 0x17FE990 VA: 0x6CF6855990
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x6CF6861CF0 Offset: 0x180ACF0 VA: 0x6CF6861CF0
	public override long get_Length() { }

	// RVA: 0x6CF6861D28 Offset: 0x180AD28 VA: 0x6CF6861D28
	public override long get_Position() { }

	// RVA: 0x6CF6861D60 Offset: 0x180AD60 VA: 0x6CF6861D60
	public override void set_Position(long value) { }

	// RVA: 0x6CF6861D98 Offset: 0x180AD98 VA: 0x6CF6861D98
	public override bool get_CanSeek() { }

	// RVA: 0x6CF6861DA0 Offset: 0x180ADA0 VA: 0x6CF6861DA0
	public override bool get_CanRead() { }

	// RVA: 0x6CF6861DA8 Offset: 0x180ADA8 VA: 0x6CF6861DA8
	public override bool get_CanWrite() { }

	// RVA: 0x6CF6861DB0 Offset: 0x180ADB0 VA: 0x6CF6861DB0
	public override void SetLength(long value) { }

	// RVA: 0x6CF6861DE8 Offset: 0x180ADE8 VA: 0x6CF6861DE8
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF6861E20 Offset: 0x180AE20 VA: 0x6CF6861E20
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF6861E58 Offset: 0x180AE58 VA: 0x6CF6861E58
	public override void Flush() { }

	// RVA: 0x6CF6861E90 Offset: 0x180AE90 VA: 0x6CF6861E90
	protected Exception GetException(Exception e) { }

	// RVA: 0x6CF6861FF8 Offset: 0x180AFF8 VA: 0x6CF6861FF8
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6862250 Offset: 0x180B250 VA: 0x6CF6862250
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x6CF6862410 Offset: 0x180B410 VA: 0x6CF6862410
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x6CF6862530 Offset: 0x180B530 VA: 0x6CF6862530
	public sealed override Task`1 ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	protected abstract Task`1 ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6855C50 Offset: 0x17FEC50 VA: 0x6CF6855C50
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x6CF6862648 Offset: 0x180B648 VA: 0x6CF6862648
	protected override void Dispose(bool disposing) { }

}

// Dll : System.dll
// Namespace: 
private struct <FinishWriting>d__31 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF6863968 Offset: 0x180C968 VA: 0x6CF6863968
	private void MoveNext() { }

	// RVA: 0x6CF6863C90 Offset: 0x180CC90 VA: 0x6CF6863C90
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public Byte[] buffer; // 0x38
	public int offset; // 0x40
	public int size; // 0x44
	public CancellationToken cancellationToken; // 0x48
	public WebCompletionSource completion; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58
	private TaskAwaiter <>u__2; // 0x68

	// Properties


	// Methods

	// RVA: 0x6CF6863CF8 Offset: 0x180CCF8 VA: 0x6CF6863CF8
	private void MoveNext() { }

	// RVA: 0x6CF68641F8 Offset: 0x180D1F8 VA: 0x6CF68641F8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <ProcessWrite>d__34 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF6864260 Offset: 0x180D260 VA: 0x6CF6864260
	private void MoveNext() { }

	// RVA: 0x6CF68647E0 Offset: 0x180D7E0 VA: 0x6CF68647E0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <Initialize>d__36 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF6864848 Offset: 0x180D848 VA: 0x6CF6864848
	private void MoveNext() { }

	// RVA: 0x6CF6864BAC Offset: 0x180DBAC VA: 0x6CF6864BAC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public bool setInternalLength; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF6864C14 Offset: 0x180DC14 VA: 0x6CF6864C14
	private void MoveNext() { }

	// RVA: 0x6CF68652F8 Offset: 0x180E2F8 VA: 0x6CF68652F8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private BufferOffsetSize <buffer>5__2; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF6865360 Offset: 0x180E360 VA: 0x6CF6865360
	private void MoveNext() { }

	// RVA: 0x6CF686587C Offset: 0x180E87C VA: 0x6CF686587C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF68658E4 Offset: 0x180E8E4 VA: 0x6CF68658E4
	private void MoveNext() { }

	// RVA: 0x6CF6865B60 Offset: 0x180EB60 VA: 0x6CF6865B60
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	private CancellationTokenSource <cts>5__2; // 0x38
	private Task <timeoutTask>5__3; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF6865BC8 Offset: 0x180EBC8 VA: 0x6CF6865BC8
	private void MoveNext() { }

	// RVA: 0x6CF68662C8 Offset: 0x180F2C8 VA: 0x6CF68662C8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream
{
	// Fields

	private static Byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private long totalWritten; // 0x70
	private Byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Properties

	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x6CF685E348 Offset: 0x1807348 VA: 0x6CF685E348
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x6CF6862CD4 Offset: 0x180BCD4 VA: 0x6CF6862CD4
	internal Stream get_InnerStream() { }

	// RVA: 0x6CF6862CDC Offset: 0x180BCDC VA: 0x6CF6862CDC
	public bool get_KeepAlive() { }

	// RVA: 0x6CF6862CE4 Offset: 0x180BCE4 VA: 0x6CF6862CE4
	public override bool get_CanRead() { }

	// RVA: 0x6CF6862CEC Offset: 0x180BCEC VA: 0x6CF6862CEC
	public override bool get_CanWrite() { }

	// RVA: 0x6CF6862CF4 Offset: 0x180BCF4 VA: 0x6CF6862CF4
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x6CF6862D28 Offset: 0x180BD28 VA: 0x6CF6862D28
	internal int get_WriteBufferLength() { }

	// RVA: 0x6CF6862D6C Offset: 0x180BD6C VA: 0x6CF6862D6C
	internal BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x6CF6862E40 Offset: 0x180BE40 VA: 0x6CF6862E40
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x6CF6862F10 Offset: 0x180BF10 VA: 0x6CF6862F10
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686316C Offset: 0x180C16C VA: 0x6CF686316C
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6863268 Offset: 0x180C268 VA: 0x6CF6863268
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6863360 Offset: 0x180C360 VA: 0x6CF6863360
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x6CF6861C00 Offset: 0x180AC00 VA: 0x6CF6861C00
	internal Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x6CF68633F8 Offset: 0x180C3F8 VA: 0x6CF68633F8
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6852BE8 Offset: 0x17FBBE8 VA: 0x6CF6852BE8
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF68634D8 Offset: 0x180C4D8 VA: 0x6CF68634D8
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x6CF68635A8 Offset: 0x180C5A8 VA: 0x6CF68635A8
	private Task WriteChunkTrailer() { }

	// RVA: 0x6CF6853A6C Offset: 0x17FCA6C VA: 0x6CF6853A6C
	internal void KillBuffer() { }

	// RVA: 0x6CF6863674 Offset: 0x180C674 VA: 0x6CF6863674
	public override Task`1 ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6863724 Offset: 0x180C724 VA: 0x6CF6863724
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, ref int result) { }

	// RVA: 0x6CF686375C Offset: 0x180C75C VA: 0x6CF686375C
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x6CF68638D4 Offset: 0x180C8D4 VA: 0x6CF68638D4
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
private struct <ReadAsync>d__40 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public Byte[] buffer; // 0x38
	public int offset; // 0x40
	public int count; // 0x44
	public WebResponseStream <>4__this; // 0x48
	private WebCompletionSource <completion>5__2; // 0x50
	private int <nbytes>5__3; // 0x58
	private Exception <throwMe>5__4; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68
	private ConfiguredTaskAwaiter <>u__2; // 0x78

	// Properties


	// Methods

	// RVA: 0x6CF6867C60 Offset: 0x1810C60 VA: 0x6CF6867C60
	private void MoveNext() { }

	// RVA: 0x6CF68685C0 Offset: 0x18115C0 VA: 0x6CF68685C0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass41_0 : Object
{
	// Fields

	public WebResponseStream <>4__this; // 0x10
	public Byte[] buffer; // 0x18
	public int offset; // 0x20
	public int size; // 0x24

	// Properties


	// Methods

	// RVA: 0x6CF68667DC Offset: 0x180F7DC VA: 0x6CF68667DC
	public void .ctor() { }

	// RVA: 0x6CF686863C Offset: 0x181163C VA: 0x6CF686863C
	internal Task`1 <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x6CF6868678 Offset: 0x1811678 VA: 0x6CF6868678
	internal void <ProcessRead>b__1() { }

	// RVA: 0x6CF68686B8 Offset: 0x18116B8 VA: 0x6CF68686B8
	internal bool <ProcessRead>b__2() { }

}

// Dll : System.dll
// Namespace: 
private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder`1 <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public WebResponseStream <>4__this; // 0x38
	private long <maximumSize>5__2; // 0x40
	private MemoryStream <ms>5__3; // 0x48
	private Byte[] <buffer>5__4; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF68686DC Offset: 0x18116DC VA: 0x6CF68686DC
	private void MoveNext() { }

	// RVA: 0x6CF6868CA8 Offset: 0x1811CA8 VA: 0x6CF6868CA8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <ReadAllAsync>d__48 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebResponseStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public bool resending; // 0x40
	private WebCompletionSource <completion>5__2; // 0x48
	private CancellationTokenSource <timeoutCts>5__3; // 0x50
	private Task <timeoutTask>5__4; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredTaskAwaiter <>u__2; // 0x70

	// Properties


	// Methods

	// RVA: 0x6CF6868D24 Offset: 0x1811D24 VA: 0x6CF6868D24
	private void MoveNext() { }

	// RVA: 0x6CF68696D8 Offset: 0x18126D8 VA: 0x6CF68696D8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: 
private struct <InitReadAsync>d__52 : IAsyncStateMachine
{
	// Fields

	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebResponseStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private BufferOffsetSize <buffer>5__2; // 0x40
	private ReadState <state>5__3; // 0x48
	private int <position>5__4; // 0x4C
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF6869740 Offset: 0x1812740 VA: 0x6CF6869740
	private void MoveNext() { }

	// RVA: 0x6CF6869E30 Offset: 0x1812E30 VA: 0x6CF6869E30
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Dll : System.dll
// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream
{
	// Fields

	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	private string <StatusDescription>k__BackingField; // 0x98
	private Version <Version>k__BackingField; // 0xA0
	private bool <KeepAlive>k__BackingField; // 0xA8
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Properties

	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	// RVA: 0x6CF6866330 Offset: 0x180F330 VA: 0x6CF6866330
	public WebRequestStream get_RequestStream() { }

	// RVA: 0x6CF6866338 Offset: 0x180F338 VA: 0x6CF6866338
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x6CF6866340 Offset: 0x180F340 VA: 0x6CF6866340
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x6CF6866348 Offset: 0x180F348 VA: 0x6CF6866348
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x6CF6866350 Offset: 0x180F350 VA: 0x6CF6866350
	private void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x6CF6866358 Offset: 0x180F358 VA: 0x6CF6866358
	public string get_StatusDescription() { }

	// RVA: 0x6CF6866360 Offset: 0x180F360 VA: 0x6CF6866360
	private void set_StatusDescription(string value) { }

	// RVA: 0x6CF6866368 Offset: 0x180F368 VA: 0x6CF6866368
	public Version get_Version() { }

	// RVA: 0x6CF6866370 Offset: 0x180F370 VA: 0x6CF6866370
	private void set_Version(Version value) { }

	// RVA: 0x6CF6866378 Offset: 0x180F378 VA: 0x6CF6866378
	public bool get_KeepAlive() { }

	// RVA: 0x6CF6866380 Offset: 0x180F380 VA: 0x6CF6866380
	private void set_KeepAlive(bool value) { }

	// RVA: 0x6CF686638C Offset: 0x180F38C VA: 0x6CF686638C
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x6CF686640C Offset: 0x180F40C VA: 0x6CF686640C
	public override bool get_CanRead() { }

	// RVA: 0x6CF6866414 Offset: 0x180F414 VA: 0x6CF6866414
	public override bool get_CanWrite() { }

	// RVA: 0x6CF686641C Offset: 0x180F41C VA: 0x6CF686641C
	private bool get_ChunkedRead() { }

	// RVA: 0x6CF6866424 Offset: 0x180F424 VA: 0x6CF6866424
	private void set_ChunkedRead(bool value) { }

	// RVA: 0x6CF6866430 Offset: 0x180F430 VA: 0x6CF6866430
	public override Task`1 ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF6866550 Offset: 0x180F550 VA: 0x6CF6866550
	private Task`1 ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF68667E4 Offset: 0x180F7E4 VA: 0x6CF68667E4
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, ref int result) { }

	// RVA: 0x6CF68668B0 Offset: 0x180F8B0 VA: 0x6CF68668B0
	private bool get_ExpectContent() { }

	// RVA: 0x6CF6866944 Offset: 0x180F944 VA: 0x6CF6866944
	private void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x6CF6866E58 Offset: 0x180FE58 VA: 0x6CF6866E58
	private Task`1 ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x6CF6866F48 Offset: 0x180FF48 VA: 0x6CF6866F48
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686702C Offset: 0x181002C VA: 0x6CF686702C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF68670C8 Offset: 0x18100C8 VA: 0x6CF68670C8
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x6CF6867154 Offset: 0x1810154 VA: 0x6CF6867154
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x6CF68673EC Offset: 0x18103EC VA: 0x6CF68673EC
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF68674C0 Offset: 0x18104C0 VA: 0x6CF68674C0
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties : Object
{
	// Fields


	// Properties

	public abstract string DomainName { get; }

	// Methods

	// RVA: 0x6CF6869E98 Offset: 0x1812E98 VA: 0x6CF6869E98
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x6CF6869EE4 Offset: 0x1812EE4 VA: 0x6CF6869EE4
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public abstract string get_DomainName() { }

	// RVA: 0x6CF6869EE8 Offset: 0x1812EE8 VA: 0x6CF6869EE8
	protected void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException : Win32Exception
{
	// Fields


	// Properties

	public override int ErrorCode { get; }

	// Methods

	// RVA: 0x6CF6869EF0 Offset: 0x1812EF0 VA: 0x6CF6869EF0
	public void .ctor() { }

	// RVA: 0x6CF6869F54 Offset: 0x1812F54 VA: 0x6CF6869F54
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF6869F5C Offset: 0x1812F5C VA: 0x6CF6869F5C
	public override int get_ErrorCode() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent
{
	// Fields

	public int value__; // 0x10
	public const NetworkInterfaceComponent IPv4 = 0; // 0x0
	public const NetworkInterfaceComponent IPv6 = 1; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal static class IPGlobalPropertiesFactoryPal : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6869E9C Offset: 0x1812E9C VA: 0x6CF6869E9C
	public static IPGlobalProperties Create() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
{
	// Fields


	// Properties

	public override string DomainName { get; }

	// Methods

	// RVA: 0x6CF686A004 Offset: 0x1813004 VA: 0x6CF686A004
	private static extern int getdomainname(Byte[] name, int len) { }

	// RVA: 0x6CF686A090 Offset: 0x1813090 VA: 0x6CF686A090
	public override string get_DomainName() { }

	// RVA: 0x6CF686A21C Offset: 0x181321C VA: 0x6CF686A21C
	protected void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties : CommonUnixIPGlobalProperties
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF686A224 Offset: 0x1813224 VA: 0x6CF686A224
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties : UnixIPGlobalProperties
{
	// Fields


	// Properties

	public override string DomainName { get; }

	// Methods

	// RVA: 0x6CF686A22C Offset: 0x181322C VA: 0x6CF686A22C
	public override string get_DomainName() { }

	// RVA: 0x6CF686A274 Offset: 0x1813274 VA: 0x6CF686A274
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal class MibIPGlobalProperties : UnixIPGlobalProperties
{
	// Fields

	public readonly string StatisticsFile; // 0x10
	public readonly string StatisticsFileIPv6; // 0x18
	public readonly string TcpFile; // 0x20
	public readonly string Tcp6File; // 0x28
	public readonly string UdpFile; // 0x30
	public readonly string Udp6File; // 0x38
	private static readonly Char[] wsChars; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF686A27C Offset: 0x181327C VA: 0x6CF686A27C
	public void .ctor(string procDir) { }

	// RVA: 0x6CF686A3E4 Offset: 0x18133E4 VA: 0x6CF686A3E4
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal : Object
{
	// Fields

	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Properties

	private static bool PlatformNeedsLibCWorkaround { get; }

	// Methods

	// RVA: 0x6CF686A478 Offset: 0x1813478 VA: 0x6CF686A478
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x6CF6869F64 Offset: 0x1812F64 VA: 0x6CF6869F64
	public static IPGlobalProperties Create() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal : Object
{
	// Fields

	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Properties

	internal static object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0x6CF686A4C0 Offset: 0x18134C0 VA: 0x6CF686A4C0
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x6CF686A4C8 Offset: 0x18134C8 VA: 0x6CF686A4C8
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x6CF686A4D0 Offset: 0x18134D0 VA: 0x6CF686A4D0
	internal static object get_ClassSyncObject() { }

	// RVA: 0x6CF686A568 Offset: 0x1813568 VA: 0x6CF686A568
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x6CF686A680 Offset: 0x1813680 VA: 0x6CF686A680
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x6CF686A678 Offset: 0x1813678 VA: 0x6CF686A678
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public enum UnicodeDecodingConformance
{
	// Fields

	public int value__; // 0x10
	public const UnicodeDecodingConformance Auto = 0; // 0x0
	public const UnicodeDecodingConformance Strict = 1; // 0x0
	public const UnicodeDecodingConformance Compat = 2; // 0x0
	public const UnicodeDecodingConformance Loose = 3; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public enum UnicodeEncodingConformance
{
	// Fields

	public int value__; // 0x10
	public const UnicodeEncodingConformance Auto = 0; // 0x0
	public const UnicodeEncodingConformance Strict = 1; // 0x0
	public const UnicodeEncodingConformance Compat = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal : Object
{
	// Fields

	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14
	private bool <UseNagleAlgorithm>k__BackingField; // 0x18
	private bool <Expect100Continue>k__BackingField; // 0x19
	private bool <CheckCertificateName>k__BackingField; // 0x1A
	private int <DnsRefreshTimeout>k__BackingField; // 0x1C
	private bool <EnableDnsRoundRobin>k__BackingField; // 0x20
	private bool <CheckCertificateRevocationList>k__BackingField; // 0x21
	private EncryptionPolicy <EncryptionPolicy>k__BackingField; // 0x24

	// Properties

	internal static SettingsSectionInternal Section { get; }
	internal bool UseNagleAlgorithm { get; set; }
	internal bool Expect100Continue { get; set; }
	internal bool CheckCertificateName { get; set; }
	internal int DnsRefreshTimeout { get; set; }
	internal bool EnableDnsRoundRobin { get; set; }
	internal bool CheckCertificateRevocationList { get; set; }
	internal EncryptionPolicy EncryptionPolicy { get; set; }
	internal bool Ipv6Enabled { get; }

	// Methods

	// RVA: 0x6CF686A688 Offset: 0x1813688 VA: 0x6CF686A688
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x6CF686A6E0 Offset: 0x18136E0 VA: 0x6CF686A6E0
	internal bool get_UseNagleAlgorithm() { }

	// RVA: 0x6CF686A6E8 Offset: 0x18136E8 VA: 0x6CF686A6E8
	internal void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x6CF686A6F4 Offset: 0x18136F4 VA: 0x6CF686A6F4
	internal bool get_Expect100Continue() { }

	// RVA: 0x6CF686A6FC Offset: 0x18136FC VA: 0x6CF686A6FC
	internal void set_Expect100Continue(bool value) { }

	// RVA: 0x6CF686A708 Offset: 0x1813708 VA: 0x6CF686A708
	internal bool get_CheckCertificateName() { }

	// RVA: 0x6CF686A710 Offset: 0x1813710 VA: 0x6CF686A710
	private void set_CheckCertificateName(bool value) { }

	// RVA: 0x6CF686A71C Offset: 0x181371C VA: 0x6CF686A71C
	internal int get_DnsRefreshTimeout() { }

	// RVA: 0x6CF686A724 Offset: 0x1813724 VA: 0x6CF686A724
	internal void set_DnsRefreshTimeout(int value) { }

	// RVA: 0x6CF686A72C Offset: 0x181372C VA: 0x6CF686A72C
	internal bool get_EnableDnsRoundRobin() { }

	// RVA: 0x6CF686A734 Offset: 0x1813734 VA: 0x6CF686A734
	internal void set_EnableDnsRoundRobin(bool value) { }

	// RVA: 0x6CF686A740 Offset: 0x1813740 VA: 0x6CF686A740
	internal bool get_CheckCertificateRevocationList() { }

	// RVA: 0x6CF686A748 Offset: 0x1813748 VA: 0x6CF686A748
	internal void set_CheckCertificateRevocationList(bool value) { }

	// RVA: 0x6CF686A754 Offset: 0x1813754 VA: 0x6CF686A754
	internal EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x6CF686A75C Offset: 0x181375C VA: 0x6CF686A75C
	private void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x6CF686A764 Offset: 0x1813764 VA: 0x6CF686A764
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x6CF686A76C Offset: 0x181376C VA: 0x6CF686A76C
	public void .ctor() { }

	// RVA: 0x6CF686A784 Offset: 0x1813784 VA: 0x6CF686A784
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Cache
internal abstract class RequestCache : Object
{
	// Fields

	internal static readonly Char[] LineSplits; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF686A7F0 Offset: 0x18137F0 VA: 0x6CF686A7F0
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Cache
internal class RequestCacheValidator : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF686A884 Offset: 0x1813884 VA: 0x6CF686A884
	public object CreateValidator() { }

}

// Dll : System.dll
// Namespace: System.Net.Cache
internal class RequestCacheBinding : Object
{
	// Fields

	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Properties

	internal RequestCache Cache { get; }
	internal RequestCacheValidator Validator { get; }

	// Methods

	// RVA: 0x6CF686A8BC Offset: 0x18138BC VA: 0x6CF686A8BC
	internal RequestCache get_Cache() { }

	// RVA: 0x6CF686A8C4 Offset: 0x18138C4 VA: 0x6CF686A8C4
	internal RequestCacheValidator get_Validator() { }

}

// Dll : System.dll
// Namespace: System.Net.Cache
public enum RequestCacheLevel
{
	// Fields

	public int value__; // 0x10
	public const RequestCacheLevel Default = 0; // 0x0
	public const RequestCacheLevel BypassCache = 1; // 0x0
	public const RequestCacheLevel CacheOnly = 2; // 0x0
	public const RequestCacheLevel CacheIfAvailable = 3; // 0x0
	public const RequestCacheLevel Revalidate = 4; // 0x0
	public const RequestCacheLevel Reload = 5; // 0x0
	public const RequestCacheLevel NoCacheNoStore = 6; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Cache
public class RequestCachePolicy : Object
{
	// Fields

	private RequestCacheLevel m_Level; // 0x10

	// Properties

	public RequestCacheLevel Level { get; }

	// Methods

	// RVA: 0x6CF686A8CC Offset: 0x18138CC VA: 0x6CF686A8CC
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x6CF686A944 Offset: 0x1813944 VA: 0x6CF686A944
	public RequestCacheLevel get_Level() { }

	// RVA: 0x6CF686A94C Offset: 0x181394C VA: 0x6CF686A94C
	public override string ToString() { }

}

// Dll : System.dll
// Namespace: System.Net.Cache
public enum HttpRequestCacheLevel
{
	// Fields

	public int value__; // 0x10
	public const HttpRequestCacheLevel Default = 0; // 0x0
	public const HttpRequestCacheLevel BypassCache = 1; // 0x0
	public const HttpRequestCacheLevel CacheOnly = 2; // 0x0
	public const HttpRequestCacheLevel CacheIfAvailable = 3; // 0x0
	public const HttpRequestCacheLevel Revalidate = 4; // 0x0
	public const HttpRequestCacheLevel Reload = 5; // 0x0
	public const HttpRequestCacheLevel NoCacheNoStore = 6; // 0x0
	public const HttpRequestCacheLevel CacheOrNextCacheOnly = 7; // 0x0
	public const HttpRequestCacheLevel Refresh = 8; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Cache
internal class RequestCacheProtocol : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF686A9E4 Offset: 0x18139E4 VA: 0x6CF686A9E4
	public void .ctor(object arg1, object arg2) { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class NetworkStream : Stream
{
	// Fields

	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x6CF686AA24 Offset: 0x1813A24 VA: 0x6CF686AA24
	public void .ctor(Socket socket) { }

	// RVA: 0x6CF686ABD0 Offset: 0x1813BD0 VA: 0x6CF686ABD0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x6CF686AA30 Offset: 0x1813A30 VA: 0x6CF686AA30
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x6CF686ABDC Offset: 0x1813BDC VA: 0x6CF686ABDC
	public override bool get_CanRead() { }

	// RVA: 0x6CF686ABE4 Offset: 0x1813BE4 VA: 0x6CF686ABE4
	public override bool get_CanSeek() { }

	// RVA: 0x6CF686ABEC Offset: 0x1813BEC VA: 0x6CF686ABEC
	public override bool get_CanWrite() { }

	// RVA: 0x6CF686ABF4 Offset: 0x1813BF4 VA: 0x6CF686ABF4
	public override bool get_CanTimeout() { }

	// RVA: 0x6CF686ABFC Offset: 0x1813BFC VA: 0x6CF686ABFC
	public override int get_ReadTimeout() { }

	// RVA: 0x6CF686AE1C Offset: 0x1813E1C VA: 0x6CF686AE1C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x6CF686B064 Offset: 0x1814064 VA: 0x6CF686B064
	public override int get_WriteTimeout() { }

	// RVA: 0x6CF686B0EC Offset: 0x18140EC VA: 0x6CF686B0EC
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x6CF686B170 Offset: 0x1814170 VA: 0x6CF686B170
	public override long get_Length() { }

	// RVA: 0x6CF686B1BC Offset: 0x18141BC VA: 0x6CF686B1BC
	public override long get_Position() { }

	// RVA: 0x6CF686B208 Offset: 0x1814208 VA: 0x6CF686B208
	public override void set_Position(long value) { }

	// RVA: 0x6CF686B254 Offset: 0x1814254 VA: 0x6CF686B254
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF686B2A0 Offset: 0x18142A0 VA: 0x6CF686B2A0
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF686B5E8 Offset: 0x18145E8 VA: 0x6CF686B5E8
	public override int Read(Span`1 destination) { }

	// RVA: 0x6CF686B944 Offset: 0x1814944 VA: 0x6CF686B944
	public override int ReadByte() { }

	// RVA: 0x6CF686B9A8 Offset: 0x18149A8 VA: 0x6CF686B9A8
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF686BCF0 Offset: 0x1814CF0 VA: 0x6CF686BCF0
	public override void Write(ReadOnlySpan`1 source) { }

	// RVA: 0x6CF686BFD0 Offset: 0x1814FD0 VA: 0x6CF686BFD0
	public override void WriteByte(byte value) { }

	// RVA: 0x6CF686C028 Offset: 0x1815028 VA: 0x6CF686C028
	public void Close(int timeout) { }

	// RVA: 0x6CF686C08C Offset: 0x181508C VA: 0x6CF686C08C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF686C194 Offset: 0x1815194 VA: 0x6CF686C194
	protected override void Finalize() { }

	// RVA: 0x6CF686C238 Offset: 0x1815238 VA: 0x6CF686C238
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF686C5B0 Offset: 0x18155B0 VA: 0x6CF686C5B0
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF686C814 Offset: 0x1815814 VA: 0x6CF686C814
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x6CF686CB8C Offset: 0x1815B8C VA: 0x6CF686CB8C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x6CF686CDF0 Offset: 0x1815DF0 VA: 0x6CF686CDF0
	public override Task`1 ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686D43C Offset: 0x181643C VA: 0x6CF686D43C
	public override ValueTask`1 ReadAsync(Memory`1 buffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686D680 Offset: 0x1816680 VA: 0x6CF686D680
	public override Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686DCE4 Offset: 0x1816CE4 VA: 0x6CF686DCE4
	public override ValueTask WriteAsync(ReadOnlyMemory`1 buffer, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686DF24 Offset: 0x1816F24 VA: 0x6CF686DF24
	public override void Flush() { }

	// RVA: 0x6CF686DF28 Offset: 0x1816F28 VA: 0x6CF686DF28
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF686DFB0 Offset: 0x1816FB0 VA: 0x6CF686DFB0
	public override void SetLength(long value) { }

	// RVA: 0x6CF686AEA0 Offset: 0x1813EA0 VA: 0x6CF686AEA0
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x6CF686E138 Offset: 0x1817138 VA: 0x6CF686E138
	internal Socket get_InternalSocket() { }

}

// Dll : System.dll
// Namespace: 
private sealed class CachedEventArgs : Object
{
	// Fields

	public TaskSocketAsyncEventArgs`1 TaskAccept; // 0x10
	public Int32TaskSocketAsyncEventArgs TaskReceive; // 0x18
	public Int32TaskSocketAsyncEventArgs TaskSend; // 0x20
	public AwaitableSocketAsyncEventArgs ValueTaskReceive; // 0x28
	public AwaitableSocketAsyncEventArgs ValueTaskSend; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF68776DC Offset: 0x18206DC VA: 0x6CF68776DC
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: 
private class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
{
	// Fields

	internal AsyncTaskMethodBuilder`1 _builder; // 0x0
	internal bool _accessed; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	internal void .ctor() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal AsyncTaskMethodBuilder`1 GetCompletionResponsibility(ref bool responsibleForReturningToPool) { }

}

// Dll : System.dll
// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs`1
{
	// Fields

	internal bool _wrapExceptionsInIOExceptions; // 0xD1

	// Properties


	// Methods

	// RVA: 0x6CF6877694 Offset: 0x1820694 VA: 0x6CF6877694
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static ContextCallback <>9__14_0; // 0x8
	public static SendOrPostCallback <>9__20_0; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6878350 Offset: 0x1821350 VA: 0x6CF6878350
	private static void .cctor() { }

	// RVA: 0x6CF68783AC Offset: 0x18213AC VA: 0x6CF68783AC
	public void .ctor() { }

	// RVA: 0x6CF68783B4 Offset: 0x18213B4 VA: 0x6CF68783B4
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x6CF6878464 Offset: 0x1821464 VA: 0x6CF6878464
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x6CF6878510 Offset: 0x1821510 VA: 0x6CF6878510
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x6CF687855C Offset: 0x182155C VA: 0x6CF687855C
	internal void <.cctor>b__27_1(object state) { }

}

// Dll : System.dll
// Namespace: 
internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource`1
{
	// Fields

	internal static readonly AwaitableSocketAsyncEventArgs Reserved; // 0x0
	private static readonly Action`1 s_completedSentinel; // 0x8
	private static readonly Action`1 s_availableSentinel; // 0x10
	private Action`1 _continuation; // 0xB8
	private ExecutionContext _executionContext; // 0xC0
	private object _scheduler; // 0xC8
	private short _token; // 0xD0
	private bool <WrapExceptionsInIOExceptions>k__BackingField; // 0xD2

	// Properties

	public bool WrapExceptionsInIOExceptions { get; set; }

	// Methods

	// RVA: 0x6CF68776E4 Offset: 0x18206E4 VA: 0x6CF68776E4
	public void .ctor() { }

	// RVA: 0x6CF68777D8 Offset: 0x18207D8 VA: 0x6CF68777D8
	public bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x6CF68777E0 Offset: 0x18207E0 VA: 0x6CF68777E0
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x6CF686E1CC Offset: 0x18171CC VA: 0x6CF686E1CC
	public bool Reserve() { }

	// RVA: 0x6CF68777EC Offset: 0x18207EC VA: 0x6CF68777EC
	private void Release() { }

	// RVA: 0x6CF687785C Offset: 0x182085C VA: 0x6CF687785C
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x6CF686E334 Offset: 0x1817334 VA: 0x6CF686E334
	public ValueTask`1 ReceiveAsync(Socket socket) { }

	// RVA: 0x6CF686E7A4 Offset: 0x18177A4 VA: 0x6CF686E7A4
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x6CF6877E2C Offset: 0x1820E2C VA: 0x6CF6877E2C
	public ValueTaskSourceStatus GetStatus(short token) { }

	// RVA: 0x6CF6877F0C Offset: 0x1820F0C VA: 0x6CF6877F0C
	public void OnCompleted(Action`1 continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x6CF6877A64 Offset: 0x1820A64 VA: 0x6CF6877A64
	private void InvokeContinuation(Action`1 continuation, object state, bool forceAsync) { }

	// RVA: 0x6CF6878168 Offset: 0x1821168 VA: 0x6CF6878168
	public int GetResult(short token) { }

	// RVA: 0x6CF68781D4 Offset: 0x18211D4 VA: 0x6CF68781D4
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

	// RVA: 0x6CF6877EC0 Offset: 0x1820EC0 VA: 0x6CF6877EC0
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x6CF687811C Offset: 0x182111C VA: 0x6CF687811C
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x6CF68781B0 Offset: 0x18211B0 VA: 0x6CF68781B0
	private void ThrowException(SocketError error) { }

	// RVA: 0x6CF6877D40 Offset: 0x1820D40 VA: 0x6CF6877D40
	private Exception CreateException(SocketError error) { }

	// RVA: 0x6CF6878214 Offset: 0x1821214 VA: 0x6CF6878214
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: 
private struct WSABUF
{
	// Fields

	public int len; // 0x10
	public IntPtr buf; // 0x18

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`1 <>9__14_0; // 0x8
	public static Func`1 <>9__14_1; // 0x10
	public static AsyncCallback <>9__15_0; // 0x18
	public static AsyncCallback <>9__15_1; // 0x20
	public static Func`1 <>9__22_0; // 0x28
	public static Func`1 <>9__22_1; // 0x30
	public static AsyncCallback <>9__23_0; // 0x38
	public static AsyncCallback <>9__23_1; // 0x40
	public static IOAsyncCallback <>9__295_0; // 0x48
	public static IOAsyncCallback <>9__297_0; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF68785A8 Offset: 0x18215A8 VA: 0x6CF68785A8
	private static void .cctor() { }

	// RVA: 0x6CF6878604 Offset: 0x1821604 VA: 0x6CF6878604
	public void .ctor() { }

	// RVA: 0x6CF687860C Offset: 0x182160C VA: 0x6CF687860C
	internal CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x6CF6878660 Offset: 0x1821660 VA: 0x6CF6878660
	internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x6CF68786B0 Offset: 0x18216B0 VA: 0x6CF68786B0
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x6CF68788E4 Offset: 0x18218E4 VA: 0x6CF68788E4
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x6CF6878D14 Offset: 0x1821D14 VA: 0x6CF6878D14
	internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x6CF6878D68 Offset: 0x1821D68 VA: 0x6CF6878D68
	internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x6CF6878DB8 Offset: 0x1821DB8 VA: 0x6CF6878DB8
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x6CF6878FEC Offset: 0x1821FEC VA: 0x6CF6878FEC
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x6CF68792EC Offset: 0x18222EC VA: 0x6CF68792EC
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x6CF687937C Offset: 0x182237C VA: 0x6CF687937C
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x6CF687940C Offset: 0x182240C VA: 0x6CF687940C
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x6CF6879500 Offset: 0x1822500 VA: 0x6CF6879500
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x6CF68795DC Offset: 0x18225DC VA: 0x6CF68795DC
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x6CF68796B8 Offset: 0x18226B8 VA: 0x6CF68796B8
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x6CF687993C Offset: 0x182293C VA: 0x6CF687993C
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x6CF6879A68 Offset: 0x1822A68 VA: 0x6CF6879A68
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x6CF6879C98 Offset: 0x1822C98 VA: 0x6CF6879C98
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x6CF6879F20 Offset: 0x1822F20 VA: 0x6CF6879F20
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x6CF687A388 Offset: 0x1823388 VA: 0x6CF687A388
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x6CF687A610 Offset: 0x1823610 VA: 0x6CF687A610
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x6CF687A70C Offset: 0x182370C VA: 0x6CF687A70C
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x6CF687A9A0 Offset: 0x18239A0 VA: 0x6CF687A9A0
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x6CF687AC40 Offset: 0x1823C40 VA: 0x6CF687AC40
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x6CF687AD48 Offset: 0x1823D48 VA: 0x6CF687AD48
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x6CF687AFF8 Offset: 0x1823FF8 VA: 0x6CF687AFF8
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x6CF687B164 Offset: 0x1824164 VA: 0x6CF687B164
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x6CF687B3F8 Offset: 0x18243F8 VA: 0x6CF687B3F8
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x6CF687B500 Offset: 0x1824500 VA: 0x6CF687B500
	internal void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass240_0 : Object
{
	// Fields

	public SocketAsyncResult sockares; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6874DF4 Offset: 0x181DDF4 VA: 0x6CF6874DF4
	public void .ctor() { }

	// RVA: 0x6CF687B794 Offset: 0x1824794 VA: 0x6CF687B794
	internal void <BeginConnect>b__0(Task`1 t) { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass298_0 : Object
{
	// Fields

	public int sent_so_far; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF68767C4 Offset: 0x181F7C4 VA: 0x6CF68767C4
	public void .ctor() { }

	// RVA: 0x6CF687B8AC Offset: 0x18248AC VA: 0x6CF687B8AC
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass355_0 : Object
{
	// Fields

	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF6876D4C Offset: 0x181FD4C VA: 0x6CF6876D4C
	public void .ctor() { }

	// RVA: 0x6CF687B94C Offset: 0x182494C VA: 0x6CF687B94C
	internal void <QueueIOSelectorJob>b__0(Task t) { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class Socket : Object, IDisposable
{
	// Fields

	private static readonly EventHandler`1 AcceptCompletedHandler; // 0x0
	private static readonly EventHandler`1 ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler`1 SendCompletedHandler; // 0x10
	private static readonly TaskSocketAsyncEventArgs`1 s_rentedSocketSentinel; // 0x18
	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task`1 s_zeroTask; // 0x28
	private CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	internal static bool s_PerfCountersEnabled; // 0x3D
	internal const int DefaultCloseTimeout; // 0x0
	private const int SOCKET_CLOSED_CODE; // 0x0
	private const string TIMEOUT_EXCEPTION_MSG; // 0x0
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private bool useOverlappedIO; // 0x1A
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	internal readonly int ID; // 0x5C
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties

	public static bool OSSupportsIPv4 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public int ReceiveTimeout { set; }
	public int SendTimeout { set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public int Available { get; }
	public bool IsBound { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x6CF686D160 Offset: 0x1816160 VA: 0x6CF686D160
	internal ValueTask`1 ReceiveAsync(Memory`1 buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686E3C4 Offset: 0x18173C4 VA: 0x6CF686E3C4
	private Task`1 ReceiveAsyncApm(Memory`1 buffer, SocketFlags socketFlags) { }

	// RVA: 0x6CF686DA00 Offset: 0x1816A00 VA: 0x6CF686DA00
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory`1 buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x6CF686E800 Offset: 0x1817800 VA: 0x6CF686E800
	private Task`1 SendAsyncApm(ReadOnlyMemory`1 buffer, SocketFlags socketFlags) { }

	// RVA: 0x6CF686EC38 Offset: 0x1817C38 VA: 0x6CF686EC38
	private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs`1 saea) { }

	// RVA: 0x6CF686EEB8 Offset: 0x1817EB8 VA: 0x6CF686EEB8
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x6CF686EDD0 Offset: 0x1817DD0 VA: 0x6CF686EDD0
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x6CF686F038 Offset: 0x1818038 VA: 0x6CF686F038
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x6CF686ED90 Offset: 0x1817D90 VA: 0x6CF686ED90
	private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs`1 saea) { }

	// RVA: 0x6CF686F084 Offset: 0x1818084 VA: 0x6CF686F084
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x6CF686F7C4 Offset: 0x18187C4 VA: 0x6CF686F7C4
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x6CF686F828 Offset: 0x1818828 VA: 0x6CF686F828
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x6CF686F88C Offset: 0x181888C VA: 0x6CF686F88C
	public IntPtr get_Handle() { }

	// RVA: 0x6CF686F8A8 Offset: 0x18188A8 VA: 0x6CF686F8A8
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x6CF686F8B0 Offset: 0x18188B0 VA: 0x6CF686F8B0
	public SocketType get_SocketType() { }

	// RVA: 0x6CF686F8B8 Offset: 0x18188B8 VA: 0x6CF686F8B8
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x6CF686F8C0 Offset: 0x18188C0 VA: 0x6CF686F8C0
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x6CF686FA40 Offset: 0x1818A40 VA: 0x6CF686FA40
	public void set_SendTimeout(int value) { }

	// RVA: 0x6CF686FAA8 Offset: 0x1818AA8 VA: 0x6CF686FAA8
	public void set_DontFragment(bool value) { }

	// RVA: 0x6CF686FB24 Offset: 0x1818B24 VA: 0x6CF686FB24
	public bool get_DualMode() { }

	// RVA: 0x6CF686FC04 Offset: 0x1818C04 VA: 0x6CF686FC04
	public void set_DualMode(bool value) { }

	// RVA: 0x6CF686FC84 Offset: 0x1818C84 VA: 0x6CF686FC84
	private bool get_IsDualMode() { }

	// RVA: 0x6CF686FC9C Offset: 0x1818C9C VA: 0x6CF686FC9C
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x6CF686FCD4 Offset: 0x1818CD4 VA: 0x6CF686FCD4
	public void Connect(IPAddress[] addresses, int port) { }

	// RVA: 0x6CF6870408 Offset: 0x1819408 VA: 0x6CF6870408
	public int Send(Byte[] buffer) { }

	// RVA: 0x6CF6870434 Offset: 0x1819434 VA: 0x6CF6870434
	public int Send(IList`1 buffers, SocketFlags socketFlags) { }

	// RVA: 0x6CF686BC94 Offset: 0x1814C94 VA: 0x6CF686BC94
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x6CF6870B80 Offset: 0x1819B80 VA: 0x6CF6870B80
	public int Receive(Byte[] buffer, SocketFlags socketFlags) { }

	// RVA: 0x6CF6870BAC Offset: 0x1819BAC VA: 0x6CF6870BAC
	public int Receive(Byte[] buffer) { }

	// RVA: 0x6CF686B58C Offset: 0x181458C VA: 0x6CF686B58C
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x6CF6870D00 Offset: 0x1819D00 VA: 0x6CF6870D00
	public int Receive(IList`1 buffers, SocketFlags socketFlags) { }

	// RVA: 0x6CF68712B4 Offset: 0x181A2B4 VA: 0x6CF68712B4
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x6CF686F60C Offset: 0x181860C VA: 0x6CF686F60C
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x6CF686CB18 Offset: 0x1815B18 VA: 0x6CF686CB18
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x6CF686CD94 Offset: 0x1815D94 VA: 0x6CF686CD94
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x6CF686C53C Offset: 0x181553C VA: 0x6CF686C53C
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x6CF686C7B8 Offset: 0x18157B8 VA: 0x6CF686C7B8
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x6CF68719A4 Offset: 0x181A9A4 VA: 0x6CF68719A4
	private static object get_InternalSyncObject() { }

	// RVA: 0x6CF68700A0 Offset: 0x18190A0 VA: 0x6CF68700A0
	internal bool get_CleanedUp() { }

	// RVA: 0x6CF686F2C8 Offset: 0x18182C8 VA: 0x6CF686F2C8
	internal static void InitializeSockets() { }

	// RVA: 0x6CF6871AC4 Offset: 0x181AAC4 VA: 0x6CF6871AC4
	public void Dispose() { }

	// RVA: 0x6CF6871B30 Offset: 0x181AB30 VA: 0x6CF6871B30
	protected override void Finalize() { }

	// RVA: 0x6CF686C104 Offset: 0x1815104 VA: 0x6CF686C104
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x6CF686DFFC Offset: 0x1816FFC VA: 0x6CF686DFFC
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x6CF6871E48 Offset: 0x181AE48 VA: 0x6CF6871E48
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x6CF686F6F0 Offset: 0x18186F0 VA: 0x6CF686F6F0
	private void SocketDefaults() { }

	// RVA: 0x6CF686F524 Offset: 0x1818524 VA: 0x6CF686F524
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, ref int error) { }

	// RVA: 0x6CF6871F78 Offset: 0x181AF78 VA: 0x6CF6871F78
	public int get_Available() { }

	// RVA: 0x6CF68720AC Offset: 0x181B0AC VA: 0x6CF68720AC
	private static int Available_internal(SafeSocketHandle safeHandle, ref int error) { }

	// RVA: 0x6CF68721E4 Offset: 0x181B1E4 VA: 0x6CF68721E4
	private static int Available_icall(IntPtr socket, ref int error) { }

	// RVA: 0x6CF68721E8 Offset: 0x181B1E8 VA: 0x6CF68721E8
	public bool get_IsBound() { }

	// RVA: 0x6CF68721F0 Offset: 0x181B1F0 VA: 0x6CF68721F0
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x6CF68722D8 Offset: 0x181B2D8 VA: 0x6CF68722D8
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, ref int error) { }

	// RVA: 0x6CF6872418 Offset: 0x181B418 VA: 0x6CF6872418
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, ref int error) { }

	// RVA: 0x6CF687241C Offset: 0x181B41C VA: 0x6CF687241C
	public bool get_Blocking() { }

	// RVA: 0x6CF6872424 Offset: 0x181B424 VA: 0x6CF6872424
	public void set_Blocking(bool value) { }

	// RVA: 0x6CF68724E4 Offset: 0x181B4E4 VA: 0x6CF68724E4
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, ref int error) { }

	// RVA: 0x6CF6872608 Offset: 0x181B608 VA: 0x6CF6872608
	internal static void Blocking_icall(IntPtr socket, bool block, ref int error) { }

	// RVA: 0x6CF6872610 Offset: 0x181B610 VA: 0x6CF6872610
	public bool get_Connected() { }

	// RVA: 0x6CF6871F38 Offset: 0x181AF38 VA: 0x6CF6871F38
	public void set_NoDelay(bool value) { }

	// RVA: 0x6CF6872664 Offset: 0x181B664 VA: 0x6CF6872664
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x6CF6872754 Offset: 0x181B754 VA: 0x6CF6872754
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, ref int error) { }

	// RVA: 0x6CF6872894 Offset: 0x181B894 VA: 0x6CF6872894
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, ref int error) { }

	// RVA: 0x6CF6872898 Offset: 0x181B898 VA: 0x6CF6872898
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x6CF6872A28 Offset: 0x181BA28 VA: 0x6CF6872A28
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, ref int error) { }

	// RVA: 0x6CF6872B78 Offset: 0x181BB78 VA: 0x6CF6872B78
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, ref int error) { }

	// RVA: 0x6CF6872B7C Offset: 0x181BB7C VA: 0x6CF6872B7C
	public Socket Accept() { }

	// RVA: 0x6CF6872DEC Offset: 0x181BDEC VA: 0x6CF6872DEC
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x6CF6872EFC Offset: 0x181BEFC VA: 0x6CF6872EFC
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x6CF68731F4 Offset: 0x181C1F4 VA: 0x6CF68731F4
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x6CF687321C Offset: 0x181C21C VA: 0x6CF687321C
	public Socket EndAccept(ref Byte[] buffer, ref int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x6CF6872CAC Offset: 0x181BCAC VA: 0x6CF6872CAC
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, ref int error, bool blocking) { }

	// RVA: 0x6CF6873620 Offset: 0x181C620 VA: 0x6CF6873620
	private static IntPtr Accept_icall(IntPtr sock, ref int error, bool blocking) { }

	// RVA: 0x6CF6873628 Offset: 0x181C628 VA: 0x6CF6873628
	public void Bind(EndPoint localEP) { }

	// RVA: 0x6CF6873854 Offset: 0x181C854 VA: 0x6CF6873854
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, ref int error) { }

	// RVA: 0x6CF6873978 Offset: 0x181C978 VA: 0x6CF6873978
	private static void Bind_icall(IntPtr sock, SocketAddress sa, ref int error) { }

	// RVA: 0x6CF687397C Offset: 0x181C97C VA: 0x6CF687397C
	public void Listen(int backlog) { }

	// RVA: 0x6CF6873A60 Offset: 0x181CA60 VA: 0x6CF6873A60
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, ref int error) { }

	// RVA: 0x6CF6873B84 Offset: 0x181CB84 VA: 0x6CF6873B84
	private static void Listen_icall(IntPtr sock, int backlog, ref int error) { }

	// RVA: 0x6CF6873B88 Offset: 0x181CB88 VA: 0x6CF6873B88
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x6CF6873BFC Offset: 0x181CBFC VA: 0x6CF6873BFC
	public void Connect(string host, int port) { }

	// RVA: 0x6CF68700B0 Offset: 0x18190B0 VA: 0x6CF68700B0
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x6CF6873D40 Offset: 0x181CD40 VA: 0x6CF6873D40
	public bool ConnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x6CF6874B34 Offset: 0x181DB34 VA: 0x6CF6874B34
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6874DFC Offset: 0x181DDFC VA: 0x6CF6874DFC
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6874868 Offset: 0x181D868 VA: 0x6CF6874868
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x6CF6874434 Offset: 0x181D434 VA: 0x6CF6874434
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x6CF6874A70 Offset: 0x181DA70 VA: 0x6CF6874A70
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6873C30 Offset: 0x181CC30 VA: 0x6CF6873C30
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, ref int error, bool blocking) { }

	// RVA: 0x6CF6874F3C Offset: 0x181DF3C VA: 0x6CF6874F3C
	private static void Connect_icall(IntPtr sock, SocketAddress sa, ref int error, bool blocking) { }

	// RVA: 0x6CF6874280 Offset: 0x181D280 VA: 0x6CF6874280
	private bool GetCheckedIPs(SocketAsyncEventArgs e, ref IPAddress[] addresses) { }

	// RVA: 0x6CF6874F4C Offset: 0x181DF4C VA: 0x6CF6874F4C
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x6CF6875154 Offset: 0x181E154 VA: 0x6CF6875154
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x6CF6875030 Offset: 0x181E030 VA: 0x6CF6875030
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, ref int error) { }

	// RVA: 0x6CF6875200 Offset: 0x181E200 VA: 0x6CF6875200
	private static void Disconnect_icall(IntPtr sock, bool reuse, ref int error) { }

	// RVA: 0x6CF6870BD8 Offset: 0x1819BD8 VA: 0x6CF6870BD8
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF68754B0 Offset: 0x181E4B0 VA: 0x6CF68754B0
	private int Receive(Memory`1 buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF6870D5C Offset: 0x1819D5C VA: 0x6CF6870D5C
	public int Receive(IList`1 buffers, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF686B83C Offset: 0x181483C VA: 0x6CF686B83C
	public int Receive(Span`1 buffer, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF686BF44 Offset: 0x1814F44 VA: 0x6CF686BF44
	public int Send(ReadOnlySpan`1 buffer, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF68757E8 Offset: 0x181E7E8 VA: 0x6CF68757E8
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x6CF6871728 Offset: 0x181A728 VA: 0x6CF6871728
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x6CF68718BC Offset: 0x181A8BC VA: 0x6CF68718BC
	public int EndReceive(IAsyncResult asyncResult, ref SocketError errorCode) { }

	// RVA: 0x6CF68756B8 Offset: 0x181E6B8 VA: 0x6CF68756B8
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF6875A78 Offset: 0x181EA78 VA: 0x6CF6875A78
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF6875380 Offset: 0x181E380 VA: 0x6CF6875380
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF6875A80 Offset: 0x181EA80 VA: 0x6CF6875A80
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF6875A88 Offset: 0x181EA88 VA: 0x6CF6875A88
	private int ReceiveFrom(Memory`1 buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, ref SocketError errorCode) { }

	// RVA: 0x6CF6875E44 Offset: 0x181EE44 VA: 0x6CF6875E44
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x6CF6875D04 Offset: 0x181ED04 VA: 0x6CF6875D04
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, ref int error, bool blocking) { }

	// RVA: 0x6CF6875F0C Offset: 0x181EF0C VA: 0x6CF6875F0C
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, ref int error, bool blocking) { }

	// RVA: 0x6CF6870A3C Offset: 0x1819A3C VA: 0x6CF6870A3C
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF6870490 Offset: 0x1819490 VA: 0x6CF6870490
	public int Send(IList`1 buffers, SocketFlags socketFlags, ref SocketError errorCode) { }

	// RVA: 0x6CF6876174 Offset: 0x181F174 VA: 0x6CF6876174
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x6CF6871430 Offset: 0x181A430 VA: 0x6CF6871430
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x6CF6876448 Offset: 0x181F448 VA: 0x6CF6876448
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x6CF6871640 Offset: 0x181A640 VA: 0x6CF6871640
	public int EndSend(IAsyncResult asyncResult, ref SocketError errorCode) { }

	// RVA: 0x6CF6876044 Offset: 0x181F044 VA: 0x6CF6876044
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF68767DC Offset: 0x181F7DC VA: 0x6CF68767DC
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF6875F14 Offset: 0x181EF14 VA: 0x6CF6875F14
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF68767E4 Offset: 0x181F7E4 VA: 0x6CF68767E4
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref int error, bool blocking) { }

	// RVA: 0x6CF68767EC Offset: 0x181F7EC VA: 0x6CF68767EC
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x6CF686AC84 Offset: 0x1813C84 VA: 0x6CF686AC84
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x6CF68768A0 Offset: 0x181F8A0 VA: 0x6CF68768A0
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, ref object obj_val, ref int error) { }

	// RVA: 0x6CF68769DC Offset: 0x181F9DC VA: 0x6CF68769DC
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, ref object obj_val, ref int error) { }

	// RVA: 0x6CF686F928 Offset: 0x1818928 VA: 0x6CF686F928
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x6CF6871CF4 Offset: 0x181ACF4 VA: 0x6CF6871CF4
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, ref int error) { }

	// RVA: 0x6CF68769E0 Offset: 0x181F9E0 VA: 0x6CF68769E0
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, ref int error) { }

	// RVA: 0x6CF68712B8 Offset: 0x181A2B8 VA: 0x6CF68712B8
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x6CF68769E4 Offset: 0x181F9E4 VA: 0x6CF68769E4
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, ref int error) { }

	// RVA: 0x6CF6876B3C Offset: 0x181FB3C VA: 0x6CF6876B3C
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, ref int error) { }

	// RVA: 0x6CF6876B40 Offset: 0x181FB40 VA: 0x6CF6876B40
	public void Close() { }

	// RVA: 0x6CF686C18C Offset: 0x181518C VA: 0x6CF686C18C
	public void Close(int timeout) { }

	// RVA: 0x6CF6876B48 Offset: 0x181FB48 VA: 0x6CF6876B48
	internal static void Close_icall(IntPtr socket, ref int error) { }

	// RVA: 0x6CF6871BD0 Offset: 0x181ABD0 VA: 0x6CF6871BD0
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, ref int error) { }

	// RVA: 0x6CF6876B4C Offset: 0x181FB4C VA: 0x6CF6876B4C
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, ref int error) { }

	// RVA: 0x6CF6876B50 Offset: 0x181FB50 VA: 0x6CF6876B50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x6CF6876BB0 Offset: 0x181FBB0 VA: 0x6CF6876BB0
	private void Linger(IntPtr handle) { }

	// RVA: 0x6CF6872028 Offset: 0x181B028 VA: 0x6CF6872028
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x6CF6875208 Offset: 0x181E208 VA: 0x6CF6875208
	private void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x6CF687525C Offset: 0x181E25C VA: 0x6CF687525C
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x6CF6872618 Offset: 0x181B618 VA: 0x6CF6872618
	private void ThrowIfUdp() { }

	// RVA: 0x6CF687330C Offset: 0x181C30C VA: 0x6CF687330C
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x6CF68730B8 Offset: 0x181C0B8 VA: 0x6CF68730B8
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x6CF6874214 Offset: 0x181D214 VA: 0x6CF6874214
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x6CF6876E08 Offset: 0x181FE08 VA: 0x6CF6876E08
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x6CF6873794 Offset: 0x181C794 VA: 0x6CF6873794
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x6CF6876F74 Offset: 0x181FF74 VA: 0x6CF6876F74
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x6CF6876F78 Offset: 0x181FF78 VA: 0x6CF6876F78
	internal static int get_FamilyHint() { }

	// RVA: 0x6CF6876FFC Offset: 0x181FFFC VA: 0x6CF6876FFC
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x6CF6871A70 Offset: 0x181AA70 VA: 0x6CF6871A70
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x6CF6877000 Offset: 0x1820000 VA: 0x6CF6877000
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception
{
	// Fields

	private EndPoint m_EndPoint; // 0x90

	// Properties

	public override int ErrorCode { get; }
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x6CF687B990 Offset: 0x1824990 VA: 0x6CF687B990
	private static int WSAGetLastError_icall() { }

	// RVA: 0x6CF686F5EC Offset: 0x18185EC VA: 0x6CF686F5EC
	public void .ctor() { }

	// RVA: 0x6CF687B994 Offset: 0x1824994 VA: 0x6CF687B994
	internal void .ctor(int error, string message) { }

	// RVA: 0x6CF686B93C Offset: 0x181493C VA: 0x6CF686B93C
	public void .ctor(int errorCode) { }

	// RVA: 0x6CF6870A34 Offset: 0x1819A34 VA: 0x6CF6870A34
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x6CF687B99C Offset: 0x182499C VA: 0x6CF687B99C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x6CF687B9A4 Offset: 0x18249A4 VA: 0x6CF687B9A4
	public override int get_ErrorCode() { }

	// RVA: 0x6CF687B9AC Offset: 0x18249AC VA: 0x6CF687B9AC
	public override string get_Message() { }

	// RVA: 0x6CF6874B1C Offset: 0x181DB1C VA: 0x6CF6874B1C
	public SocketError get_SocketErrorCode() { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum AddressFamily
{
	// Fields

	public int value__; // 0x10
	public const AddressFamily Unknown = 4294967295; // 0x0
	public const AddressFamily Unspecified = 0; // 0x0
	public const AddressFamily Unix = 1; // 0x0
	public const AddressFamily InterNetwork = 2; // 0x0
	public const AddressFamily ImpLink = 3; // 0x0
	public const AddressFamily Pup = 4; // 0x0
	public const AddressFamily Chaos = 5; // 0x0
	public const AddressFamily NS = 6; // 0x0
	public const AddressFamily Ipx = 6; // 0x0
	public const AddressFamily Iso = 7; // 0x0
	public const AddressFamily Osi = 7; // 0x0
	public const AddressFamily Ecma = 8; // 0x0
	public const AddressFamily DataKit = 9; // 0x0
	public const AddressFamily Ccitt = 10; // 0x0
	public const AddressFamily Sna = 11; // 0x0
	public const AddressFamily DecNet = 12; // 0x0
	public const AddressFamily DataLink = 13; // 0x0
	public const AddressFamily Lat = 14; // 0x0
	public const AddressFamily HyperChannel = 15; // 0x0
	public const AddressFamily AppleTalk = 16; // 0x0
	public const AddressFamily NetBios = 17; // 0x0
	public const AddressFamily VoiceView = 18; // 0x0
	public const AddressFamily FireFox = 19; // 0x0
	public const AddressFamily Banyan = 21; // 0x0
	public const AddressFamily Atm = 22; // 0x0
	public const AddressFamily InterNetworkV6 = 23; // 0x0
	public const AddressFamily Cluster = 24; // 0x0
	public const AddressFamily Ieee12844 = 25; // 0x0
	public const AddressFamily Irda = 26; // 0x0
	public const AddressFamily NetworkDesigners = 28; // 0x0
	public const AddressFamily Max = 29; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum IOControlCode
{
	// Fields

	public long value__; // 0x10
	public const IOControlCode AsyncIO = 2147772029; // 0x0
	public const IOControlCode NonBlockingIO = 2147772030; // 0x0
	public const IOControlCode DataToRead = 1074030207; // 0x0
	public const IOControlCode OobDataRead = 1074033415; // 0x0
	public const IOControlCode AssociateHandle = 2281701377; // 0x0
	public const IOControlCode EnableCircularQueuing = 671088642; // 0x0
	public const IOControlCode Flush = 671088644; // 0x0
	public const IOControlCode GetBroadcastAddress = 1207959557; // 0x0
	public const IOControlCode GetExtensionFunctionPointer = 3355443206; // 0x0
	public const IOControlCode GetQos = 3355443207; // 0x0
	public const IOControlCode GetGroupQos = 3355443208; // 0x0
	public const IOControlCode MultipointLoopback = 2281701385; // 0x0
	public const IOControlCode MulticastScope = 2281701386; // 0x0
	public const IOControlCode SetQos = 2281701387; // 0x0
	public const IOControlCode SetGroupQos = 2281701388; // 0x0
	public const IOControlCode TranslateHandle = 3355443213; // 0x0
	public const IOControlCode RoutingInterfaceQuery = 3355443220; // 0x0
	public const IOControlCode RoutingInterfaceChange = 2281701397; // 0x0
	public const IOControlCode AddressListQuery = 1207959574; // 0x0
	public const IOControlCode AddressListChange = 671088663; // 0x0
	public const IOControlCode QueryTargetPnpHandle = 1207959576; // 0x0
	public const IOControlCode NamespaceChange = 2281701401; // 0x0
	public const IOControlCode AddressListSort = 3355443225; // 0x0
	public const IOControlCode ReceiveAll = 2550136833; // 0x0
	public const IOControlCode ReceiveAllMulticast = 2550136834; // 0x0
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835; // 0x0
	public const IOControlCode KeepAliveValues = 2550136836; // 0x0
	public const IOControlCode AbsorbRouterAlert = 2550136837; // 0x0
	public const IOControlCode UnicastInterface = 2550136838; // 0x0
	public const IOControlCode LimitBroadcasts = 2550136839; // 0x0
	public const IOControlCode BindToInterface = 2550136840; // 0x0
	public const IOControlCode MulticastInterface = 2550136841; // 0x0
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842; // 0x0
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public struct IPPacketInformation
{
	// Fields

	private IPAddress address; // 0x10
	private int networkInterface; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF687BA3C Offset: 0x1824A3C VA: 0x6CF687BA3C
	public override bool Equals(object comparand) { }

	// RVA: 0x6CF687BAD8 Offset: 0x1824AD8 VA: 0x6CF687BAD8
	public override int GetHashCode() { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum IPProtectionLevel
{
	// Fields

	public int value__; // 0x10
	public const IPProtectionLevel Unspecified = 4294967295; // 0x0
	public const IPProtectionLevel Unrestricted = 10; // 0x0
	public const IPProtectionLevel EdgeRestricted = 20; // 0x0
	public const IPProtectionLevel Restricted = 30; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class LingerOption : Object
{
	// Fields

	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Properties

	public bool Enabled { set; }
	public int LingerTime { set; }

	// Methods

	// RVA: 0x6CF6876D18 Offset: 0x181FD18 VA: 0x6CF6876D18
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x6CF687BB1C Offset: 0x1824B1C VA: 0x6CF687BB1C
	public void set_Enabled(bool value) { }

	// RVA: 0x6CF687BB28 Offset: 0x1824B28 VA: 0x6CF687BB28
	public void set_LingerTime(int value) { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class MulticastOption : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum ProtocolType
{
	// Fields

	public int value__; // 0x10
	public const ProtocolType IP = 0; // 0x0
	public const ProtocolType IPv6HopByHopOptions = 0; // 0x0
	public const ProtocolType Icmp = 1; // 0x0
	public const ProtocolType Igmp = 2; // 0x0
	public const ProtocolType Ggp = 3; // 0x0
	public const ProtocolType IPv4 = 4; // 0x0
	public const ProtocolType Tcp = 6; // 0x0
	public const ProtocolType Pup = 12; // 0x0
	public const ProtocolType Udp = 17; // 0x0
	public const ProtocolType Idp = 22; // 0x0
	public const ProtocolType IPv6 = 41; // 0x0
	public const ProtocolType IPv6RoutingHeader = 43; // 0x0
	public const ProtocolType IPv6FragmentHeader = 44; // 0x0
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50; // 0x0
	public const ProtocolType IPSecAuthenticationHeader = 51; // 0x0
	public const ProtocolType IcmpV6 = 58; // 0x0
	public const ProtocolType IPv6NoNextHeader = 59; // 0x0
	public const ProtocolType IPv6DestinationOptions = 60; // 0x0
	public const ProtocolType ND = 77; // 0x0
	public const ProtocolType Raw = 255; // 0x0
	public const ProtocolType Unspecified = 0; // 0x0
	public const ProtocolType Ipx = 1000; // 0x0
	public const ProtocolType Spx = 1256; // 0x0
	public const ProtocolType SpxII = 1257; // 0x0
	public const ProtocolType Unknown = 4294967295; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SelectMode
{
	// Fields

	public int value__; // 0x10
	public const SelectMode SelectRead = 0; // 0x0
	public const SelectMode SelectWrite = 1; // 0x0
	public const SelectMode SelectError = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketAsyncOperation
{
	// Fields

	public int value__; // 0x10
	public const SocketAsyncOperation None = 0; // 0x0
	public const SocketAsyncOperation Accept = 1; // 0x0
	public const SocketAsyncOperation Connect = 2; // 0x0
	public const SocketAsyncOperation Disconnect = 3; // 0x0
	public const SocketAsyncOperation Receive = 4; // 0x0
	public const SocketAsyncOperation ReceiveFrom = 5; // 0x0
	public const SocketAsyncOperation ReceiveMessageFrom = 6; // 0x0
	public const SocketAsyncOperation Send = 7; // 0x0
	public const SocketAsyncOperation SendPackets = 8; // 0x0
	public const SocketAsyncOperation SendTo = 9; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class SendPacketsElement : Object
{
	// Fields

	internal string m_FilePath; // 0x10
	internal Byte[] m_Buffer; // 0x18
	internal int m_Offset; // 0x20
	internal int m_Count; // 0x24
	private bool m_endOfPacket; // 0x28

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketError
{
	// Fields

	public int value__; // 0x10
	public const SocketError Success = 0; // 0x0
	public const SocketError SocketError = 4294967295; // 0x0
	public const SocketError Interrupted = 10004; // 0x0
	public const SocketError AccessDenied = 10013; // 0x0
	public const SocketError Fault = 10014; // 0x0
	public const SocketError InvalidArgument = 10022; // 0x0
	public const SocketError TooManyOpenSockets = 10024; // 0x0
	public const SocketError WouldBlock = 10035; // 0x0
	public const SocketError InProgress = 10036; // 0x0
	public const SocketError AlreadyInProgress = 10037; // 0x0
	public const SocketError NotSocket = 10038; // 0x0
	public const SocketError DestinationAddressRequired = 10039; // 0x0
	public const SocketError MessageSize = 10040; // 0x0
	public const SocketError ProtocolType = 10041; // 0x0
	public const SocketError ProtocolOption = 10042; // 0x0
	public const SocketError ProtocolNotSupported = 10043; // 0x0
	public const SocketError SocketNotSupported = 10044; // 0x0
	public const SocketError OperationNotSupported = 10045; // 0x0
	public const SocketError ProtocolFamilyNotSupported = 10046; // 0x0
	public const SocketError AddressFamilyNotSupported = 10047; // 0x0
	public const SocketError AddressAlreadyInUse = 10048; // 0x0
	public const SocketError AddressNotAvailable = 10049; // 0x0
	public const SocketError NetworkDown = 10050; // 0x0
	public const SocketError NetworkUnreachable = 10051; // 0x0
	public const SocketError NetworkReset = 10052; // 0x0
	public const SocketError ConnectionAborted = 10053; // 0x0
	public const SocketError ConnectionReset = 10054; // 0x0
	public const SocketError NoBufferSpaceAvailable = 10055; // 0x0
	public const SocketError IsConnected = 10056; // 0x0
	public const SocketError NotConnected = 10057; // 0x0
	public const SocketError Shutdown = 10058; // 0x0
	public const SocketError TimedOut = 10060; // 0x0
	public const SocketError ConnectionRefused = 10061; // 0x0
	public const SocketError HostDown = 10064; // 0x0
	public const SocketError HostUnreachable = 10065; // 0x0
	public const SocketError ProcessLimit = 10067; // 0x0
	public const SocketError SystemNotReady = 10091; // 0x0
	public const SocketError VersionNotSupported = 10092; // 0x0
	public const SocketError NotInitialized = 10093; // 0x0
	public const SocketError Disconnecting = 10101; // 0x0
	public const SocketError TypeNotFound = 10109; // 0x0
	public const SocketError HostNotFound = 11001; // 0x0
	public const SocketError TryAgain = 11002; // 0x0
	public const SocketError NoRecovery = 11003; // 0x0
	public const SocketError NoData = 11004; // 0x0
	public const SocketError IOPending = 997; // 0x0
	public const SocketError OperationAborted = 995; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketFlags
{
	// Fields

	public int value__; // 0x10
	public const SocketFlags None = 0; // 0x0
	public const SocketFlags OutOfBand = 1; // 0x0
	public const SocketFlags Peek = 2; // 0x0
	public const SocketFlags DontRoute = 4; // 0x0
	public const SocketFlags MaxIOVectorLength = 16; // 0x0
	public const SocketFlags Truncated = 256; // 0x0
	public const SocketFlags ControlDataTruncated = 512; // 0x0
	public const SocketFlags Broadcast = 1024; // 0x0
	public const SocketFlags Multicast = 2048; // 0x0
	public const SocketFlags Partial = 32768; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketOptionLevel
{
	// Fields

	public int value__; // 0x10
	public const SocketOptionLevel Socket = 65535; // 0x0
	public const SocketOptionLevel IP = 0; // 0x0
	public const SocketOptionLevel IPv6 = 41; // 0x0
	public const SocketOptionLevel Tcp = 6; // 0x0
	public const SocketOptionLevel Udp = 17; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketOptionName
{
	// Fields

	public int value__; // 0x10
	public const SocketOptionName Debug = 1; // 0x0
	public const SocketOptionName AcceptConnection = 2; // 0x0
	public const SocketOptionName ReuseAddress = 4; // 0x0
	public const SocketOptionName KeepAlive = 8; // 0x0
	public const SocketOptionName DontRoute = 16; // 0x0
	public const SocketOptionName Broadcast = 32; // 0x0
	public const SocketOptionName UseLoopback = 64; // 0x0
	public const SocketOptionName Linger = 128; // 0x0
	public const SocketOptionName OutOfBandInline = 256; // 0x0
	public const SocketOptionName DontLinger = 4294967167; // 0x0
	public const SocketOptionName ExclusiveAddressUse = 4294967291; // 0x0
	public const SocketOptionName SendBuffer = 4097; // 0x0
	public const SocketOptionName ReceiveBuffer = 4098; // 0x0
	public const SocketOptionName SendLowWater = 4099; // 0x0
	public const SocketOptionName ReceiveLowWater = 4100; // 0x0
	public const SocketOptionName SendTimeout = 4101; // 0x0
	public const SocketOptionName ReceiveTimeout = 4102; // 0x0
	public const SocketOptionName Error = 4103; // 0x0
	public const SocketOptionName Type = 4104; // 0x0
	public const SocketOptionName ReuseUnicastPort = 12295; // 0x0
	public const SocketOptionName MaxConnections = 2147483647; // 0x0
	public const SocketOptionName IPOptions = 1; // 0x0
	public const SocketOptionName HeaderIncluded = 2; // 0x0
	public const SocketOptionName TypeOfService = 3; // 0x0
	public const SocketOptionName IpTimeToLive = 4; // 0x0
	public const SocketOptionName MulticastInterface = 9; // 0x0
	public const SocketOptionName MulticastTimeToLive = 10; // 0x0
	public const SocketOptionName MulticastLoopback = 11; // 0x0
	public const SocketOptionName AddMembership = 12; // 0x0
	public const SocketOptionName DropMembership = 13; // 0x0
	public const SocketOptionName DontFragment = 14; // 0x0
	public const SocketOptionName AddSourceMembership = 15; // 0x0
	public const SocketOptionName DropSourceMembership = 16; // 0x0
	public const SocketOptionName BlockSource = 17; // 0x0
	public const SocketOptionName UnblockSource = 18; // 0x0
	public const SocketOptionName PacketInformation = 19; // 0x0
	public const SocketOptionName HopLimit = 21; // 0x0
	public const SocketOptionName IPProtectionLevel = 23; // 0x0
	public const SocketOptionName IPv6Only = 27; // 0x0
	public const SocketOptionName NoDelay = 1; // 0x0
	public const SocketOptionName BsdUrgent = 2; // 0x0
	public const SocketOptionName Expedited = 2; // 0x0
	public const SocketOptionName NoChecksum = 1; // 0x0
	public const SocketOptionName ChecksumCoverage = 20; // 0x0
	public const SocketOptionName UpdateAcceptContext = 28683; // 0x0
	public const SocketOptionName UpdateConnectContext = 28688; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketShutdown
{
	// Fields

	public int value__; // 0x10
	public const SocketShutdown Receive = 0; // 0x0
	public const SocketShutdown Send = 1; // 0x0
	public const SocketShutdown Both = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum SocketType
{
	// Fields

	public int value__; // 0x10
	public const SocketType Stream = 1; // 0x0
	public const SocketType Dgram = 2; // 0x0
	public const SocketType Raw = 3; // 0x0
	public const SocketType Rdm = 4; // 0x0
	public const SocketType Seqpacket = 5; // 0x0
	public const SocketType Unknown = 4294967295; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class TcpClient : Object, IDisposable
{
	// Fields

	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties

	public Socket Client { get; set; }

	// Methods

	// RVA: 0x6CF687BB30 Offset: 0x1824B30 VA: 0x6CF687BB30
	public void .ctor() { }

	// RVA: 0x6CF687BB50 Offset: 0x1824B50 VA: 0x6CF687BB50
	public void .ctor(AddressFamily family) { }

	// RVA: 0x6CF687BCC4 Offset: 0x1824CC4 VA: 0x6CF687BCC4
	public Socket get_Client() { }

	// RVA: 0x6CF687BCCC Offset: 0x1824CCC VA: 0x6CF687BCCC
	public void set_Client(Socket value) { }

	// RVA: 0x6CF687BCD4 Offset: 0x1824CD4 VA: 0x6CF687BCD4
	public void Connect(string hostname, int port) { }

	// RVA: 0x6CF687C34C Offset: 0x182534C VA: 0x6CF687C34C
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x6CF687C448 Offset: 0x1825448 VA: 0x6CF687C448
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x6CF687C4B0 Offset: 0x18254B0 VA: 0x6CF687C4B0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x6CF687C4F4 Offset: 0x18254F4 VA: 0x6CF687C4F4
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x6CF687C660 Offset: 0x1825660 VA: 0x6CF687C660
	public NetworkStream GetStream() { }

	// RVA: 0x6CF687C798 Offset: 0x1825798 VA: 0x6CF687C798
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x6CF687C940 Offset: 0x1825940 VA: 0x6CF687C940
	public void Dispose() { }

	// RVA: 0x6CF687C950 Offset: 0x1825950 VA: 0x6CF687C950
	protected override void Finalize() { }

	// RVA: 0x6CF687BC5C Offset: 0x1824C5C VA: 0x6CF687BC5C
	private void initialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public enum TransmitFileOptions
{
	// Fields

	public int value__; // 0x10
	public const TransmitFileOptions UseDefaultWorkerThread = 0; // 0x0
	public const TransmitFileOptions Disconnect = 1; // 0x0
	public const TransmitFileOptions ReuseSocket = 2; // 0x0
	public const TransmitFileOptions WriteBehind = 4; // 0x0
	public const TransmitFileOptions UseSystemThread = 16; // 0x0
	public const TransmitFileOptions UseKernelApc = 32; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	// Fields

	private List`1 blocking_threads; // 0x20
	private Dictionary`2 threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private const int SOCKET_CLOSED; // 0x0
	private const int ABORT_RETRIES; // 0x0
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF686F528 Offset: 0x1818528 VA: 0x6CF686F528
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x6CF687C9F0 Offset: 0x18259F0 VA: 0x6CF687C9F0
	protected override bool ReleaseHandle() { }

	// RVA: 0x6CF68734E4 Offset: 0x181C4E4 VA: 0x6CF68734E4
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x6CF687CF94 Offset: 0x1825F94 VA: 0x6CF687CF94
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x6CF687D184 Offset: 0x1826184 VA: 0x6CF687D184
	private static void .cctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	// Fields

	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	private Exception <ConnectByNameError>k__BackingField; // 0x30
	private Socket <AcceptSocket>k__BackingField; // 0x38
	private int <BytesTransferred>k__BackingField; // 0x40
	private bool <DisconnectReuseSocket>k__BackingField; // 0x44
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x48
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; // 0x50
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; // 0x60
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; // 0x68
	private int <SendPacketsSendSize>k__BackingField; // 0x6C
	private SocketError <SocketError>k__BackingField; // 0x70
	private SocketFlags <SocketFlags>k__BackingField; // 0x74
	private object <UserToken>k__BackingField; // 0x78
	private EventHandler`1 Completed; // 0x80
	private Memory`1 _buffer; // 0x88
	private int _offset; // 0x98
	private int _count; // 0x9C
	private bool _bufferIsExplicitArray; // 0xA0
	private IList`1 _bufferList; // 0xA8
	private List`1 _bufferListInternal; // 0xB0

	// Properties

	private Exception ConnectByNameError { set; }
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	public SocketAsyncOperation LastOperation { get; set; }
	public EndPoint RemoteEndPoint { get; set; }
	public int SendPacketsSendSize { set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { set; }
	public object UserToken { get; set; }
	internal Socket CurrentSocket { get; }
	public Byte[] Buffer { get; }
	public Memory`1 MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList`1 BufferList { get; }

	// Methods

	// RVA: 0x6CF687D218 Offset: 0x1826218 VA: 0x6CF687D218
	private void set_ConnectByNameError(Exception value) { }

	// RVA: 0x6CF687D220 Offset: 0x1826220 VA: 0x6CF687D220
	public Socket get_AcceptSocket() { }

	// RVA: 0x6CF687D228 Offset: 0x1826228 VA: 0x6CF687D228
	public void set_AcceptSocket(Socket value) { }

	// RVA: 0x6CF687D230 Offset: 0x1826230 VA: 0x6CF687D230
	public int get_BytesTransferred() { }

	// RVA: 0x6CF687D238 Offset: 0x1826238 VA: 0x6CF687D238
	private void set_BytesTransferred(int value) { }

	// RVA: 0x6CF687D240 Offset: 0x1826240 VA: 0x6CF687D240
	public SocketAsyncOperation get_LastOperation() { }

	// RVA: 0x6CF687D248 Offset: 0x1826248 VA: 0x6CF687D248
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x6CF687D250 Offset: 0x1826250 VA: 0x6CF687D250
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x6CF687D258 Offset: 0x1826258 VA: 0x6CF687D258
	public void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x6CF687D260 Offset: 0x1826260 VA: 0x6CF687D260
	public void set_SendPacketsSendSize(int value) { }

	// RVA: 0x6CF687D268 Offset: 0x1826268 VA: 0x6CF687D268
	public SocketError get_SocketError() { }

	// RVA: 0x6CF687D270 Offset: 0x1826270 VA: 0x6CF687D270
	public void set_SocketError(SocketError value) { }

	// RVA: 0x6CF687D278 Offset: 0x1826278 VA: 0x6CF687D278
	public void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x6CF687D280 Offset: 0x1826280 VA: 0x6CF687D280
	public object get_UserToken() { }

	// RVA: 0x6CF687D288 Offset: 0x1826288 VA: 0x6CF687D288
	public void set_UserToken(object value) { }

	// RVA: 0x6CF687D290 Offset: 0x1826290 VA: 0x6CF687D290
	public void add_Completed(EventHandler`1 value) { }

	// RVA: 0x6CF687D340 Offset: 0x1826340 VA: 0x6CF687D340
	public void remove_Completed(EventHandler`1 value) { }

	// RVA: 0x6CF687D3F0 Offset: 0x18263F0 VA: 0x6CF687D3F0
	public void .ctor() { }

	// RVA: 0x6CF687774C Offset: 0x182074C VA: 0x6CF687774C
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x6CF687D490 Offset: 0x1826490 VA: 0x6CF687D490
	protected override void Finalize() { }

	// RVA: 0x6CF687D4A0 Offset: 0x18264A0 VA: 0x6CF687D4A0
	private void Dispose(bool disposing) { }

	// RVA: 0x6CF687D4B4 Offset: 0x18264B4 VA: 0x6CF687D4B4
	public void Dispose() { }

	// RVA: 0x6CF6874F44 Offset: 0x181DF44 VA: 0x6CF6874F44
	internal void SetConnectByNameError(Exception error) { }

	// RVA: 0x6CF6876F6C Offset: 0x181FF6C VA: 0x6CF6876F6C
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x6CF687D518 Offset: 0x1826518 VA: 0x6CF687D518
	internal Socket get_CurrentSocket() { }

	// RVA: 0x6CF687D520 Offset: 0x1826520 VA: 0x6CF687D520
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x6CF6876EAC Offset: 0x181FEAC VA: 0x6CF6876EAC
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x6CF687D528 Offset: 0x1826528 VA: 0x6CF687D528
	internal void Complete_internal() { }

	// RVA: 0x6CF687D550 Offset: 0x1826550 VA: 0x6CF687D550
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x6CF687D578 Offset: 0x1826578 VA: 0x6CF687D578
	public Byte[] get_Buffer() { }

	// RVA: 0x6CF687D634 Offset: 0x1826634 VA: 0x6CF687D634
	public Memory`1 get_MemoryBuffer() { }

	// RVA: 0x6CF687D640 Offset: 0x1826640 VA: 0x6CF687D640
	public int get_Offset() { }

	// RVA: 0x6CF687D648 Offset: 0x1826648 VA: 0x6CF687D648
	public int get_Count() { }

	// RVA: 0x6CF687D650 Offset: 0x1826650 VA: 0x6CF687D650
	public IList`1 get_BufferList() { }

	// RVA: 0x6CF687D658 Offset: 0x1826658 VA: 0x6CF687D658
	public void SetBuffer(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF686E248 Offset: 0x1817248 VA: 0x6CF686E248
	public void SetBuffer(Memory`1 buffer) { }

}

// Dll : System.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF687D7D8 Offset: 0x18267D8 VA: 0x6CF687D7D8
	private static void .cctor() { }

	// RVA: 0x6CF687D834 Offset: 0x1826834 VA: 0x6CF687D834
	public void .ctor() { }

	// RVA: 0x6CF687D83C Offset: 0x182683C VA: 0x6CF687D83C
	internal void <Complete>b__27_0(object state) { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult
{
	// Fields

	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory`1 Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList`1 Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties

	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x6CF687308C Offset: 0x181C08C VA: 0x6CF687308C
	public IntPtr get_Handle() { }

	// RVA: 0x6CF687D488 Offset: 0x1826488 VA: 0x6CF687D488
	public void .ctor() { }

	// RVA: 0x6CF6876D54 Offset: 0x181FD54 VA: 0x6CF6876D54
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x6CF6873054 Offset: 0x181C054 VA: 0x6CF6873054
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x6CF68759F8 Offset: 0x181E9F8 VA: 0x6CF68759F8
	public SocketError get_ErrorCode() { }

	// RVA: 0x6CF6873444 Offset: 0x181C444 VA: 0x6CF6873444
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x6CF687D7D4 Offset: 0x18267D4 VA: 0x6CF687D7D4
	internal override void CompleteDisposed() { }

	// RVA: 0x6CF687A1A8 Offset: 0x18231A8 VA: 0x6CF687A1A8
	public void Complete() { }

	// RVA: 0x6CF6874F30 Offset: 0x181DF30 VA: 0x6CF6874F30
	public void Complete(bool synch) { }

	// RVA: 0x6CF68767D4 Offset: 0x181F7D4 VA: 0x6CF68767D4
	public void Complete(int total) { }

	// RVA: 0x6CF6874B24 Offset: 0x181DB24 VA: 0x6CF6874B24
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x6CF68767CC Offset: 0x181F7CC VA: 0x6CF68767CC
	public void Complete(Exception e) { }

	// RVA: 0x6CF6879A60 Offset: 0x1822A60 VA: 0x6CF6879A60
	public void Complete(Socket s) { }

	// RVA: 0x6CF6879C8C Offset: 0x1822C8C VA: 0x6CF6879C8C
	public void Complete(Socket s, int total) { }

}

// Dll : System.dll
// Namespace: System.Net.Sockets
internal enum SocketOperation
{
	// Fields

	public int value__; // 0x10
	public const SocketOperation Accept = 0; // 0x0
	public const SocketOperation Connect = 1; // 0x0
	public const SocketOperation Receive = 2; // 0x0
	public const SocketOperation ReceiveFrom = 3; // 0x0
	public const SocketOperation Send = 4; // 0x0
	public const SocketOperation SendTo = 5; // 0x0
	public const SocketOperation RecvJustCallback = 6; // 0x0
	public const SocketOperation SendJustCallback = 7; // 0x0
	public const SocketOperation Disconnect = 8; // 0x0
	public const SocketOperation AcceptReceive = 9; // 0x0
	public const SocketOperation ReceiveGeneric = 10; // 0x0
	public const SocketOperation SendGeneric = 11; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Mail
public enum SmtpDeliveryFormat
{
	// Fields

	public int value__; // 0x10
	public const SmtpDeliveryFormat SevenBit = 0; // 0x0
	public const SmtpDeliveryFormat International = 1; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Mail
public enum SmtpDeliveryMethod
{
	// Fields

	public int value__; // 0x10
	public const SmtpDeliveryMethod Network = 0; // 0x0
	public const SmtpDeliveryMethod SpecifiedPickupDirectory = 1; // 0x0
	public const SmtpDeliveryMethod PickupDirectoryFromIis = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Security
public class SslClientAuthenticationOptions : Object
{
	// Fields

	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	private string <TargetHost>k__BackingField; // 0x20
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x28

	// Properties

	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { set; }
	public EncryptionPolicy EncryptionPolicy { set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	// RVA: 0x6CF687D8B4 Offset: 0x18268B4 VA: 0x6CF687D8B4
	public string get_TargetHost() { }

	// RVA: 0x6CF687D8BC Offset: 0x18268BC VA: 0x6CF687D8BC
	public void set_TargetHost(string value) { }

	// RVA: 0x6CF687D8C4 Offset: 0x18268C4 VA: 0x6CF687D8C4
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x6CF687D8CC Offset: 0x18268CC VA: 0x6CF687D8CC
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x6CF687D8D4 Offset: 0x18268D4 VA: 0x6CF687D8D4
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x6CF687D970 Offset: 0x1826970 VA: 0x6CF687D970
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x6CF687DA0C Offset: 0x1826A0C VA: 0x6CF687DA0C
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x6CF687DA14 Offset: 0x1826A14 VA: 0x6CF687DA14
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x6CF687DA1C Offset: 0x1826A1C VA: 0x6CF687DA1C
	public void .ctor() { }

}

// Dll : System.dll
// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream
{
	// Fields

	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties

	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x6CF687DA2C Offset: 0x1826A2C VA: 0x6CF687DA2C
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x6CF687DBBC Offset: 0x1826BBC VA: 0x6CF687DBBC
	protected Stream get_InnerStream() { }

	// RVA: 0x6CF687DBC4 Offset: 0x1826BC4 VA: 0x6CF687DBC4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public abstract bool get_IsAuthenticated() { }

}

// Dll : System.dll
// Namespace: System.Net.Security
public enum AuthenticationLevel
{
	// Fields

	public int value__; // 0x10
	public const AuthenticationLevel None = 0; // 0x0
	public const AuthenticationLevel MutualAuthRequested = 1; // 0x0
	public const AuthenticationLevel MutualAuthRequired = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Security
public enum EncryptionPolicy
{
	// Fields

	public int value__; // 0x10
	public const EncryptionPolicy RequireEncryption = 0; // 0x0
	public const EncryptionPolicy AllowNoEncryption = 1; // 0x0
	public const EncryptionPolicy NoEncryption = 2; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF687DCAC Offset: 0x1826CAC VA: 0x6CF687DCAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF687DDB0 Offset: 0x1826DB0 VA: 0x6CF687DDB0
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

// Dll : System.dll
// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF687DDC4 Offset: 0x1826DC4 VA: 0x6CF687DDC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF687DEC8 Offset: 0x1826EC8 VA: 0x6CF687DEC8
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Dll : System.dll
// Namespace: System.Net.Security
public enum SslPolicyErrors
{
	// Fields

	public int value__; // 0x10
	public const SslPolicyErrors None = 0; // 0x0
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1; // 0x0
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2; // 0x0
	public const SslPolicyErrors RemoteCertificateChainErrors = 4; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF687DEDC Offset: 0x1826EDC VA: 0x6CF687DEDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF687DF7C Offset: 0x1826F7C VA: 0x6CF687DF7C
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

// Dll : System.dll
// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF687DF90 Offset: 0x1826F90 VA: 0x6CF687DF90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF687E02C Offset: 0x182702C VA: 0x6CF687E02C
	public virtual X509Certificate Invoke(string hostName) { }

}

// Dll : System.dll
// Namespace: 
private sealed class <>c__DisplayClass21_0 : Object
{
	// Fields

	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF687ECA8 Offset: 0x1827CA8 VA: 0x6CF687ECA8
	public void .ctor() { }

	// RVA: 0x6CF687ECB0 Offset: 0x1827CB0 VA: 0x6CF687ECB0
	internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

}

// Dll : System.dll
// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream
{
	// Fields

	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties

	internal MobileAuthenticatedStream Impl { get; }
	internal string InternalTargetHost { get; }
	public override bool IsAuthenticated { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x6CF687E040 Offset: 0x1827040 VA: 0x6CF687E040
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x6CF687E0B4 Offset: 0x18270B4 VA: 0x6CF687E0B4
	internal string get_InternalTargetHost() { }

	// RVA: 0x6CF687E0D8 Offset: 0x18270D8 VA: 0x6CF687E0D8
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x6CF687E148 Offset: 0x1827148 VA: 0x6CF687E148
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x6CF687E154 Offset: 0x1827154 VA: 0x6CF687E154
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x6CF687E428 Offset: 0x1827428 VA: 0x6CF687E428
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x6CF687E1E4 Offset: 0x18271E4 VA: 0x6CF687E1E4
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x6CF687E2BC Offset: 0x18272BC VA: 0x6CF687E2BC
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x6CF687E54C Offset: 0x182754C VA: 0x6CF687E54C
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x6CF687E5A0 Offset: 0x18275A0 VA: 0x6CF687E5A0
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x6CF687E614 Offset: 0x1827614 VA: 0x6CF687E614
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x6CF687E620 Offset: 0x1827620 VA: 0x6CF687E620
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x6CF687E674 Offset: 0x1827674 VA: 0x6CF687E674
	public override bool get_IsAuthenticated() { }

	// RVA: 0x6CF687E6A0 Offset: 0x18276A0 VA: 0x6CF687E6A0
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x6CF687E6C4 Offset: 0x18276C4 VA: 0x6CF687E6C4
	public override bool get_CanSeek() { }

	// RVA: 0x6CF687E6CC Offset: 0x18276CC VA: 0x6CF687E6CC
	public override bool get_CanRead() { }

	// RVA: 0x6CF687E6E4 Offset: 0x18276E4 VA: 0x6CF687E6E4
	public override bool get_CanTimeout() { }

	// RVA: 0x6CF687E704 Offset: 0x1827704 VA: 0x6CF687E704
	public override bool get_CanWrite() { }

	// RVA: 0x6CF687E71C Offset: 0x182771C VA: 0x6CF687E71C
	public override int get_ReadTimeout() { }

	// RVA: 0x6CF687E748 Offset: 0x1827748 VA: 0x6CF687E748
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x6CF687E784 Offset: 0x1827784 VA: 0x6CF687E784
	public override int get_WriteTimeout() { }

	// RVA: 0x6CF687E7B0 Offset: 0x18277B0 VA: 0x6CF687E7B0
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x6CF687E7EC Offset: 0x18277EC VA: 0x6CF687E7EC
	public override long get_Length() { }

	// RVA: 0x6CF687E814 Offset: 0x1827814 VA: 0x6CF687E814
	public override long get_Position() { }

	// RVA: 0x6CF687E83C Offset: 0x182783C VA: 0x6CF687E83C
	public override void set_Position(long value) { }

	// RVA: 0x6CF687E894 Offset: 0x1827894 VA: 0x6CF687E894
	public override void SetLength(long value) { }

	// RVA: 0x6CF687E8D0 Offset: 0x18278D0 VA: 0x6CF687E8D0
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x6CF687E928 Offset: 0x1827928 VA: 0x6CF687E928
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x6CF687E94C Offset: 0x182794C VA: 0x6CF687E94C
	public override void Flush() { }

	// RVA: 0x6CF687E058 Offset: 0x1827058 VA: 0x6CF687E058
	private void CheckDisposed() { }

	// RVA: 0x6CF687E970 Offset: 0x1827970 VA: 0x6CF687E970
	protected override void Dispose(bool disposing) { }

	// RVA: 0x6CF687EA1C Offset: 0x1827A1C VA: 0x6CF687EA1C
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF687EA70 Offset: 0x1827A70 VA: 0x6CF687EA70
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x6CF687EAC4 Offset: 0x1827AC4 VA: 0x6CF687EAC4
	public override Task`1 ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF687EB20 Offset: 0x1827B20 VA: 0x6CF687EB20
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6CF687EB7C Offset: 0x1827B7C VA: 0x6CF687EB7C
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x6CF687EBE8 Offset: 0x1827BE8 VA: 0x6CF687EBE8
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x6CF687EC30 Offset: 0x1827C30 VA: 0x6CF687EC30
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x6CF687EC9C Offset: 0x1827C9C VA: 0x6CF687EC9C
	public override void EndWrite(IAsyncResult asyncResult) { }

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=6
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=9
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=10
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=12
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=14
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=32
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=44
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=128
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=256
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=256 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A; // 0x0
	internal static readonly __StaticArrayInitTypeSize=32 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5; // 0x100
	internal static readonly __StaticArrayInitTypeSize=32 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374; // 0x120
	internal static readonly long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B; // 0x140
	internal static readonly __StaticArrayInitTypeSize=9 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811; // 0x148
	internal static readonly __StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70; // 0x151
	internal static readonly long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C; // 0x178
	internal static readonly __StaticArrayInitTypeSize=12 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF; // 0x180
	internal static readonly long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885; // 0x190
	internal static readonly __StaticArrayInitTypeSize=128 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3; // 0x198
	internal static readonly __StaticArrayInitTypeSize=44 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8; // 0x218
	internal static readonly __StaticArrayInitTypeSize=6 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A; // 0x244
	internal static readonly __StaticArrayInitTypeSize=128 B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C; // 0x24A
	internal static readonly long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859; // 0x2D0
	internal static readonly __StaticArrayInitTypeSize=14 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5; // 0x2D8
	internal static readonly __StaticArrayInitTypeSize=10 E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A; // 0x2E6

	// Properties


	// Methods

	// RVA: 0x6CF687ECE8 Offset: 0x1827CE8 VA: 0x6CF687ECE8
	internal static uint ComputeStringHash(string s) { }

}

// Dll : System.dll
// Namespace: System.Configuration
public interface IConfigurationSectionHandler
{
	// Fields


	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class AuthenticationModuleElement : ConfigurationElement
{
	// Fields


	// Properties

	protected override ConfigurationPropertyCollection Properties { get; }
	public string Type { get; set; }

	// Methods

	// RVA: 0x6CF687ED64 Offset: 0x1827D64 VA: 0x6CF687ED64
	public void .ctor() { }

	// RVA: 0x6CF687ED9C Offset: 0x1827D9C VA: 0x6CF687ED9C
	public void .ctor(string typeName) { }

	// RVA: 0x6CF687EDD4 Offset: 0x1827DD4 VA: 0x6CF687EDD4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF687EE0C Offset: 0x1827E0C VA: 0x6CF687EE0C
	public string get_Type() { }

	// RVA: 0x6CF687EE44 Offset: 0x1827E44 VA: 0x6CF687EE44
	public void set_Type(string value) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
{
	// Fields


	// Properties

	public AuthenticationModuleElement Item { get; set; }

	// Methods

	// RVA: 0x6CF687EE7C Offset: 0x1827E7C VA: 0x6CF687EE7C
	public void .ctor() { }

	// RVA: 0x6CF687EEB4 Offset: 0x1827EB4 VA: 0x6CF687EEB4
	public AuthenticationModuleElement get_Item(int index) { }

	// RVA: 0x6CF687EEEC Offset: 0x1827EEC VA: 0x6CF687EEEC
	public void set_Item(int index, AuthenticationModuleElement value) { }

	// RVA: 0x6CF687EF24 Offset: 0x1827F24 VA: 0x6CF687EF24
	public AuthenticationModuleElement get_Item(string name) { }

	// RVA: 0x6CF687EF5C Offset: 0x1827F5C VA: 0x6CF687EF5C
	public void set_Item(string name, AuthenticationModuleElement value) { }

	// RVA: 0x6CF687EF94 Offset: 0x1827F94 VA: 0x6CF687EF94
	public void Add(AuthenticationModuleElement element) { }

	// RVA: 0x6CF687EFCC Offset: 0x1827FCC VA: 0x6CF687EFCC
	public void Clear() { }

	// RVA: 0x6CF687F004 Offset: 0x1828004 VA: 0x6CF687F004
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x6CF687F03C Offset: 0x182803C VA: 0x6CF687F03C
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x6CF687F074 Offset: 0x1828074 VA: 0x6CF687F074
	public int IndexOf(AuthenticationModuleElement element) { }

	// RVA: 0x6CF687F0AC Offset: 0x18280AC VA: 0x6CF687F0AC
	public void Remove(AuthenticationModuleElement element) { }

	// RVA: 0x6CF687F0E4 Offset: 0x18280E4 VA: 0x6CF687F0E4
	public void Remove(string name) { }

	// RVA: 0x6CF687F11C Offset: 0x182811C VA: 0x6CF687F11C
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class AuthenticationModulesSection : ConfigurationSection
{
	// Fields


	// Properties

	public AuthenticationModuleElementCollection AuthenticationModules { get; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF687F154 Offset: 0x1828154 VA: 0x6CF687F154
	public void .ctor() { }

	// RVA: 0x6CF687F18C Offset: 0x182818C VA: 0x6CF687F18C
	public AuthenticationModuleElementCollection get_AuthenticationModules() { }

	// RVA: 0x6CF687F1C4 Offset: 0x18281C4 VA: 0x6CF687F1C4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF687F1FC Offset: 0x18281FC VA: 0x6CF687F1FC
	protected override void InitializeDefault() { }

	// RVA: 0x6CF687F234 Offset: 0x1828234 VA: 0x6CF687F234
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class BypassElement : ConfigurationElement
{
	// Fields


	// Properties

	public string Address { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF687F26C Offset: 0x182826C VA: 0x6CF687F26C
	public void .ctor() { }

	// RVA: 0x6CF687F2A4 Offset: 0x18282A4 VA: 0x6CF687F2A4
	public void .ctor(string address) { }

	// RVA: 0x6CF687F2DC Offset: 0x18282DC VA: 0x6CF687F2DC
	public string get_Address() { }

	// RVA: 0x6CF687F314 Offset: 0x1828314 VA: 0x6CF687F314
	public void set_Address(string value) { }

	// RVA: 0x6CF687F34C Offset: 0x182834C VA: 0x6CF687F34C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class BypassElementCollection : ConfigurationElementCollection
{
	// Fields


	// Properties

	public BypassElement Item { get; set; }
	protected override bool ThrowOnDuplicate { get; }

	// Methods

	// RVA: 0x6CF687F384 Offset: 0x1828384 VA: 0x6CF687F384
	public void .ctor() { }

	// RVA: 0x6CF687F3BC Offset: 0x18283BC VA: 0x6CF687F3BC
	public BypassElement get_Item(int index) { }

	// RVA: 0x6CF687F3F4 Offset: 0x18283F4 VA: 0x6CF687F3F4
	public void set_Item(int index, BypassElement value) { }

	// RVA: 0x6CF687F42C Offset: 0x182842C VA: 0x6CF687F42C
	public BypassElement get_Item(string name) { }

	// RVA: 0x6CF687F464 Offset: 0x1828464 VA: 0x6CF687F464
	public void set_Item(string name, BypassElement value) { }

	// RVA: 0x6CF687F49C Offset: 0x182849C VA: 0x6CF687F49C
	protected override bool get_ThrowOnDuplicate() { }

	// RVA: 0x6CF687F4D4 Offset: 0x18284D4 VA: 0x6CF687F4D4
	public void Add(BypassElement element) { }

	// RVA: 0x6CF687F50C Offset: 0x182850C VA: 0x6CF687F50C
	public void Clear() { }

	// RVA: 0x6CF687F544 Offset: 0x1828544 VA: 0x6CF687F544
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x6CF687F57C Offset: 0x182857C VA: 0x6CF687F57C
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x6CF687F5B4 Offset: 0x18285B4 VA: 0x6CF687F5B4
	public int IndexOf(BypassElement element) { }

	// RVA: 0x6CF687F5EC Offset: 0x18285EC VA: 0x6CF687F5EC
	public void Remove(BypassElement element) { }

	// RVA: 0x6CF687F624 Offset: 0x1828624 VA: 0x6CF687F624
	public void Remove(string name) { }

	// RVA: 0x6CF687F65C Offset: 0x182865C VA: 0x6CF687F65C
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement : ConfigurationElement
{
	// Fields


	// Properties

	public string Address { get; set; }
	public int MaxConnection { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF687F694 Offset: 0x1828694 VA: 0x6CF687F694
	public void .ctor() { }

	// RVA: 0x6CF687F6CC Offset: 0x18286CC VA: 0x6CF687F6CC
	public void .ctor(string address, int maxConnection) { }

	// RVA: 0x6CF687F704 Offset: 0x1828704 VA: 0x6CF687F704
	public string get_Address() { }

	// RVA: 0x6CF687F73C Offset: 0x182873C VA: 0x6CF687F73C
	public void set_Address(string value) { }

	// RVA: 0x6CF687F774 Offset: 0x1828774 VA: 0x6CF687F774
	public int get_MaxConnection() { }

	// RVA: 0x6CF687F7AC Offset: 0x18287AC VA: 0x6CF687F7AC
	public void set_MaxConnection(int value) { }

	// RVA: 0x6CF687F7E4 Offset: 0x18287E4 VA: 0x6CF687F7E4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
	// Fields


	// Properties

	public ConnectionManagementElement Item { get; set; }

	// Methods

	// RVA: 0x6CF687F81C Offset: 0x182881C VA: 0x6CF687F81C
	public void .ctor() { }

	// RVA: 0x6CF687F854 Offset: 0x1828854 VA: 0x6CF687F854
	public ConnectionManagementElement get_Item(int index) { }

	// RVA: 0x6CF687F88C Offset: 0x182888C VA: 0x6CF687F88C
	public void set_Item(int index, ConnectionManagementElement value) { }

	// RVA: 0x6CF687F8C4 Offset: 0x18288C4 VA: 0x6CF687F8C4
	public ConnectionManagementElement get_Item(string name) { }

	// RVA: 0x6CF687F8FC Offset: 0x18288FC VA: 0x6CF687F8FC
	public void set_Item(string name, ConnectionManagementElement value) { }

	// RVA: 0x6CF687F934 Offset: 0x1828934 VA: 0x6CF687F934
	public void Add(ConnectionManagementElement element) { }

	// RVA: 0x6CF687F96C Offset: 0x182896C VA: 0x6CF687F96C
	public void Clear() { }

	// RVA: 0x6CF687F9A4 Offset: 0x18289A4 VA: 0x6CF687F9A4
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x6CF687F9DC Offset: 0x18289DC VA: 0x6CF687F9DC
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x6CF687FA14 Offset: 0x1828A14 VA: 0x6CF687FA14
	public int IndexOf(ConnectionManagementElement element) { }

	// RVA: 0x6CF687FA4C Offset: 0x1828A4C VA: 0x6CF687FA4C
	public void Remove(ConnectionManagementElement element) { }

	// RVA: 0x6CF687FA84 Offset: 0x1828A84 VA: 0x6CF687FA84
	public void Remove(string name) { }

	// RVA: 0x6CF687FABC Offset: 0x1828ABC VA: 0x6CF687FABC
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection : ConfigurationSection
{
	// Fields


	// Properties

	public ConnectionManagementElementCollection ConnectionManagement { get; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF687FAF4 Offset: 0x1828AF4 VA: 0x6CF687FAF4
	public void .ctor() { }

	// RVA: 0x6CF687FB2C Offset: 0x1828B2C VA: 0x6CF687FB2C
	public ConnectionManagementElementCollection get_ConnectionManagement() { }

	// RVA: 0x6CF687FB64 Offset: 0x1828B64 VA: 0x6CF687FB64
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class DefaultProxySection : ConfigurationSection
{
	// Fields


	// Properties

	public BypassElementCollection BypassList { get; }
	public bool Enabled { get; set; }
	public ModuleElement Module { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public ProxyElement Proxy { get; }
	public bool UseDefaultCredentials { get; set; }

	// Methods

	// RVA: 0x6CF687FB9C Offset: 0x1828B9C VA: 0x6CF687FB9C
	public void .ctor() { }

	// RVA: 0x6CF687FBD4 Offset: 0x1828BD4 VA: 0x6CF687FBD4
	public BypassElementCollection get_BypassList() { }

	// RVA: 0x6CF687FC0C Offset: 0x1828C0C VA: 0x6CF687FC0C
	public bool get_Enabled() { }

	// RVA: 0x6CF687FC44 Offset: 0x1828C44 VA: 0x6CF687FC44
	public void set_Enabled(bool value) { }

	// RVA: 0x6CF687FC7C Offset: 0x1828C7C VA: 0x6CF687FC7C
	public ModuleElement get_Module() { }

	// RVA: 0x6CF687FCB4 Offset: 0x1828CB4 VA: 0x6CF687FCB4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF687FCEC Offset: 0x1828CEC VA: 0x6CF687FCEC
	public ProxyElement get_Proxy() { }

	// RVA: 0x6CF687FD24 Offset: 0x1828D24 VA: 0x6CF687FD24
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x6CF687FD5C Offset: 0x1828D5C VA: 0x6CF687FD5C
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x6CF687FD94 Offset: 0x1828D94 VA: 0x6CF687FD94
	protected override void PostDeserialize() { }

	// RVA: 0x6CF687FDCC Offset: 0x1828DCC VA: 0x6CF687FDCC
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ModuleElement : ConfigurationElement
{
	// Fields


	// Properties

	protected override ConfigurationPropertyCollection Properties { get; }
	public string Type { get; set; }

	// Methods

	// RVA: 0x6CF687FE04 Offset: 0x1828E04 VA: 0x6CF687FE04
	public void .ctor() { }

	// RVA: 0x6CF687FE3C Offset: 0x1828E3C VA: 0x6CF687FE3C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF687FE74 Offset: 0x1828E74 VA: 0x6CF687FE74
	public string get_Type() { }

	// RVA: 0x6CF687FEAC Offset: 0x1828EAC VA: 0x6CF687FEAC
	public void set_Type(string value) { }

}

// Dll : System.dll
// Namespace: 
public enum AutoDetectValues
{
	// Fields

	public int value__; // 0x10
	public const AutoDetectValues False = 0; // 0x0
	public const AutoDetectValues True = 1; // 0x0
	public const AutoDetectValues Unspecified = 4294967295; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
public enum BypassOnLocalValues
{
	// Fields

	public int value__; // 0x10
	public const BypassOnLocalValues False = 0; // 0x0
	public const BypassOnLocalValues True = 1; // 0x0
	public const BypassOnLocalValues Unspecified = 4294967295; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: 
public enum UseSystemDefaultValues
{
	// Fields

	public int value__; // 0x10
	public const UseSystemDefaultValues False = 0; // 0x0
	public const UseSystemDefaultValues True = 1; // 0x0
	public const UseSystemDefaultValues Unspecified = 4294967295; // 0x0

	// Properties


	// Methods

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ProxyElement : ConfigurationElement
{
	// Fields


	// Properties

	public AutoDetectValues AutoDetect { get; set; }
	public BypassOnLocalValues BypassOnLocal { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public Uri ProxyAddress { get; set; }
	public Uri ScriptLocation { get; set; }
	public UseSystemDefaultValues UseSystemDefault { get; set; }

	// Methods

	// RVA: 0x6CF687FEE4 Offset: 0x1828EE4 VA: 0x6CF687FEE4
	public void .ctor() { }

	// RVA: 0x6CF687FF1C Offset: 0x1828F1C VA: 0x6CF687FF1C
	public AutoDetectValues get_AutoDetect() { }

	// RVA: 0x6CF687FF54 Offset: 0x1828F54 VA: 0x6CF687FF54
	public void set_AutoDetect(AutoDetectValues value) { }

	// RVA: 0x6CF687FF8C Offset: 0x1828F8C VA: 0x6CF687FF8C
	public BypassOnLocalValues get_BypassOnLocal() { }

	// RVA: 0x6CF687FFC4 Offset: 0x1828FC4 VA: 0x6CF687FFC4
	public void set_BypassOnLocal(BypassOnLocalValues value) { }

	// RVA: 0x6CF687FFFC Offset: 0x1828FFC VA: 0x6CF687FFFC
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6880034 Offset: 0x1829034 VA: 0x6CF6880034
	public Uri get_ProxyAddress() { }

	// RVA: 0x6CF688006C Offset: 0x182906C VA: 0x6CF688006C
	public void set_ProxyAddress(Uri value) { }

	// RVA: 0x6CF68800A4 Offset: 0x18290A4 VA: 0x6CF68800A4
	public Uri get_ScriptLocation() { }

	// RVA: 0x6CF68800DC Offset: 0x18290DC VA: 0x6CF68800DC
	public void set_ScriptLocation(Uri value) { }

	// RVA: 0x6CF6880114 Offset: 0x1829114 VA: 0x6CF6880114
	public UseSystemDefaultValues get_UseSystemDefault() { }

	// RVA: 0x6CF688014C Offset: 0x182914C VA: 0x6CF688014C
	public void set_UseSystemDefault(UseSystemDefaultValues value) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class FtpCachePolicyElement : ConfigurationElement
{
	// Fields


	// Properties

	public RequestCacheLevel PolicyLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6880184 Offset: 0x1829184 VA: 0x6CF6880184
	public void .ctor() { }

	// RVA: 0x6CF68801BC Offset: 0x18291BC VA: 0x6CF68801BC
	public RequestCacheLevel get_PolicyLevel() { }

	// RVA: 0x6CF68801F4 Offset: 0x18291F4 VA: 0x6CF68801F4
	public void set_PolicyLevel(RequestCacheLevel value) { }

	// RVA: 0x6CF688022C Offset: 0x182922C VA: 0x6CF688022C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6880264 Offset: 0x1829264 VA: 0x6CF6880264
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x6CF688029C Offset: 0x182929C VA: 0x6CF688029C
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class HttpCachePolicyElement : ConfigurationElement
{
	// Fields


	// Properties

	public TimeSpan MaximumAge { get; set; }
	public TimeSpan MaximumStale { get; set; }
	public TimeSpan MinimumFresh { get; set; }
	public HttpRequestCacheLevel PolicyLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF68802D4 Offset: 0x18292D4 VA: 0x6CF68802D4
	public void .ctor() { }

	// RVA: 0x6CF688030C Offset: 0x182930C VA: 0x6CF688030C
	public TimeSpan get_MaximumAge() { }

	// RVA: 0x6CF6880344 Offset: 0x1829344 VA: 0x6CF6880344
	public void set_MaximumAge(TimeSpan value) { }

	// RVA: 0x6CF688037C Offset: 0x182937C VA: 0x6CF688037C
	public TimeSpan get_MaximumStale() { }

	// RVA: 0x6CF68803B4 Offset: 0x18293B4 VA: 0x6CF68803B4
	public void set_MaximumStale(TimeSpan value) { }

	// RVA: 0x6CF68803EC Offset: 0x18293EC VA: 0x6CF68803EC
	public TimeSpan get_MinimumFresh() { }

	// RVA: 0x6CF6880424 Offset: 0x1829424 VA: 0x6CF6880424
	public void set_MinimumFresh(TimeSpan value) { }

	// RVA: 0x6CF688045C Offset: 0x182945C VA: 0x6CF688045C
	public HttpRequestCacheLevel get_PolicyLevel() { }

	// RVA: 0x6CF6880494 Offset: 0x1829494 VA: 0x6CF6880494
	public void set_PolicyLevel(HttpRequestCacheLevel value) { }

	// RVA: 0x6CF68804CC Offset: 0x18294CC VA: 0x6CF68804CC
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6880504 Offset: 0x1829504 VA: 0x6CF6880504
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x6CF688053C Offset: 0x182953C VA: 0x6CF688053C
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class HttpListenerElement : ConfigurationElement
{
	// Fields


	// Properties

	protected override ConfigurationPropertyCollection Properties { get; }
	public HttpListenerTimeoutsElement Timeouts { get; }
	public bool UnescapeRequestUrl { get; }

	// Methods

	// RVA: 0x6CF6880574 Offset: 0x1829574 VA: 0x6CF6880574
	public void .ctor() { }

	// RVA: 0x6CF68805AC Offset: 0x18295AC VA: 0x6CF68805AC
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68805E4 Offset: 0x18295E4 VA: 0x6CF68805E4
	public HttpListenerTimeoutsElement get_Timeouts() { }

	// RVA: 0x6CF688061C Offset: 0x182961C VA: 0x6CF688061C
	public bool get_UnescapeRequestUrl() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class HttpListenerTimeoutsElement : ConfigurationElement
{
	// Fields


	// Properties

	public TimeSpan DrainEntityBody { get; }
	public TimeSpan EntityBody { get; }
	public TimeSpan HeaderWait { get; }
	public TimeSpan IdleConnection { get; }
	public long MinSendBytesPerSecond { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public TimeSpan RequestQueue { get; }

	// Methods

	// RVA: 0x6CF6880654 Offset: 0x1829654 VA: 0x6CF6880654
	public void .ctor() { }

	// RVA: 0x6CF688068C Offset: 0x182968C VA: 0x6CF688068C
	public TimeSpan get_DrainEntityBody() { }

	// RVA: 0x6CF68806C4 Offset: 0x18296C4 VA: 0x6CF68806C4
	public TimeSpan get_EntityBody() { }

	// RVA: 0x6CF68806FC Offset: 0x18296FC VA: 0x6CF68806FC
	public TimeSpan get_HeaderWait() { }

	// RVA: 0x6CF6880734 Offset: 0x1829734 VA: 0x6CF6880734
	public TimeSpan get_IdleConnection() { }

	// RVA: 0x6CF688076C Offset: 0x182976C VA: 0x6CF688076C
	public long get_MinSendBytesPerSecond() { }

	// RVA: 0x6CF68807A4 Offset: 0x18297A4 VA: 0x6CF68807A4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68807DC Offset: 0x18297DC VA: 0x6CF68807DC
	public TimeSpan get_RequestQueue() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement : ConfigurationElement
{
	// Fields


	// Properties

	public int MaximumErrorResponseLength { get; set; }
	public int MaximumResponseHeadersLength { get; set; }
	public int MaximumUnauthorizedUploadLength { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public bool UseUnsafeHeaderParsing { get; set; }

	// Methods

	// RVA: 0x6CF6880814 Offset: 0x1829814 VA: 0x6CF6880814
	public void .ctor() { }

	// RVA: 0x6CF688084C Offset: 0x182984C VA: 0x6CF688084C
	public int get_MaximumErrorResponseLength() { }

	// RVA: 0x6CF6880884 Offset: 0x1829884 VA: 0x6CF6880884
	public void set_MaximumErrorResponseLength(int value) { }

	// RVA: 0x6CF68808BC Offset: 0x18298BC VA: 0x6CF68808BC
	public int get_MaximumResponseHeadersLength() { }

	// RVA: 0x6CF68808F4 Offset: 0x18298F4 VA: 0x6CF68808F4
	public void set_MaximumResponseHeadersLength(int value) { }

	// RVA: 0x6CF688092C Offset: 0x182992C VA: 0x6CF688092C
	public int get_MaximumUnauthorizedUploadLength() { }

	// RVA: 0x6CF6880964 Offset: 0x1829964 VA: 0x6CF6880964
	public void set_MaximumUnauthorizedUploadLength(int value) { }

	// RVA: 0x6CF688099C Offset: 0x182999C VA: 0x6CF688099C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68809D4 Offset: 0x18299D4 VA: 0x6CF68809D4
	public bool get_UseUnsafeHeaderParsing() { }

	// RVA: 0x6CF6880A0C Offset: 0x1829A0C VA: 0x6CF6880A0C
	public void set_UseUnsafeHeaderParsing(bool value) { }

	// RVA: 0x6CF6880A44 Offset: 0x1829A44 VA: 0x6CF6880A44
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class Ipv6Element : ConfigurationElement
{
	// Fields


	// Properties

	public bool Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6880A7C Offset: 0x1829A7C VA: 0x6CF6880A7C
	public void .ctor() { }

	// RVA: 0x6CF6880AB4 Offset: 0x1829AB4 VA: 0x6CF6880AB4
	public bool get_Enabled() { }

	// RVA: 0x6CF6880AEC Offset: 0x1829AEC VA: 0x6CF6880AEC
	public void set_Enabled(bool value) { }

	// RVA: 0x6CF6880B24 Offset: 0x1829B24 VA: 0x6CF6880B24
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup
{
	// Fields


	// Properties

	public SmtpSection Smtp { get; }

	// Methods

	// RVA: 0x6CF6880B5C Offset: 0x1829B5C VA: 0x6CF6880B5C
	public void .ctor() { }

	// RVA: 0x6CF6880B94 Offset: 0x1829B94 VA: 0x6CF6880B94
	public SmtpSection get_Smtp() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class SmtpSection : ConfigurationSection
{
	// Fields


	// Properties

	public SmtpDeliveryFormat DeliveryFormat { get; set; }
	public SmtpDeliveryMethod DeliveryMethod { get; set; }
	public string From { get; set; }
	public SmtpNetworkElement Network { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory { get; }

	// Methods

	// RVA: 0x6CF6880BCC Offset: 0x1829BCC VA: 0x6CF6880BCC
	public void .ctor() { }

	// RVA: 0x6CF6880C04 Offset: 0x1829C04 VA: 0x6CF6880C04
	public SmtpDeliveryFormat get_DeliveryFormat() { }

	// RVA: 0x6CF6880C3C Offset: 0x1829C3C VA: 0x6CF6880C3C
	public void set_DeliveryFormat(SmtpDeliveryFormat value) { }

	// RVA: 0x6CF6880C74 Offset: 0x1829C74 VA: 0x6CF6880C74
	public SmtpDeliveryMethod get_DeliveryMethod() { }

	// RVA: 0x6CF6880CAC Offset: 0x1829CAC VA: 0x6CF6880CAC
	public void set_DeliveryMethod(SmtpDeliveryMethod value) { }

	// RVA: 0x6CF6880CE4 Offset: 0x1829CE4 VA: 0x6CF6880CE4
	public string get_From() { }

	// RVA: 0x6CF6880D1C Offset: 0x1829D1C VA: 0x6CF6880D1C
	public void set_From(string value) { }

	// RVA: 0x6CF6880D54 Offset: 0x1829D54 VA: 0x6CF6880D54
	public SmtpNetworkElement get_Network() { }

	// RVA: 0x6CF6880D8C Offset: 0x1829D8C VA: 0x6CF6880D8C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6880DC4 Offset: 0x1829DC4 VA: 0x6CF6880DC4
	public SmtpSpecifiedPickupDirectoryElement get_SpecifiedPickupDirectory() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class SmtpNetworkElement : ConfigurationElement
{
	// Fields


	// Properties

	public string ClientDomain { get; set; }
	public bool DefaultCredentials { get; set; }
	public bool EnableSsl { get; set; }
	public string Host { get; set; }
	public string Password { get; set; }
	public int Port { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public string TargetName { get; set; }
	public string UserName { get; set; }

	// Methods

	// RVA: 0x6CF6880DFC Offset: 0x1829DFC VA: 0x6CF6880DFC
	public void .ctor() { }

	// RVA: 0x6CF6880E34 Offset: 0x1829E34 VA: 0x6CF6880E34
	public string get_ClientDomain() { }

	// RVA: 0x6CF6880E6C Offset: 0x1829E6C VA: 0x6CF6880E6C
	public void set_ClientDomain(string value) { }

	// RVA: 0x6CF6880EA4 Offset: 0x1829EA4 VA: 0x6CF6880EA4
	public bool get_DefaultCredentials() { }

	// RVA: 0x6CF6880EDC Offset: 0x1829EDC VA: 0x6CF6880EDC
	public void set_DefaultCredentials(bool value) { }

	// RVA: 0x6CF6880F14 Offset: 0x1829F14 VA: 0x6CF6880F14
	public bool get_EnableSsl() { }

	// RVA: 0x6CF6880F4C Offset: 0x1829F4C VA: 0x6CF6880F4C
	public void set_EnableSsl(bool value) { }

	// RVA: 0x6CF6880F84 Offset: 0x1829F84 VA: 0x6CF6880F84
	public string get_Host() { }

	// RVA: 0x6CF6880FBC Offset: 0x1829FBC VA: 0x6CF6880FBC
	public void set_Host(string value) { }

	// RVA: 0x6CF6880FF4 Offset: 0x1829FF4 VA: 0x6CF6880FF4
	public string get_Password() { }

	// RVA: 0x6CF688102C Offset: 0x182A02C VA: 0x6CF688102C
	public void set_Password(string value) { }

	// RVA: 0x6CF6881064 Offset: 0x182A064 VA: 0x6CF6881064
	public int get_Port() { }

	// RVA: 0x6CF688109C Offset: 0x182A09C VA: 0x6CF688109C
	public void set_Port(int value) { }

	// RVA: 0x6CF68810D4 Offset: 0x182A0D4 VA: 0x6CF68810D4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF688110C Offset: 0x182A10C VA: 0x6CF688110C
	public string get_TargetName() { }

	// RVA: 0x6CF6881144 Offset: 0x182A144 VA: 0x6CF6881144
	public void set_TargetName(string value) { }

	// RVA: 0x6CF688117C Offset: 0x182A17C VA: 0x6CF688117C
	public string get_UserName() { }

	// RVA: 0x6CF68811B4 Offset: 0x182A1B4 VA: 0x6CF68811B4
	public void set_UserName(string value) { }

	// RVA: 0x6CF68811EC Offset: 0x182A1EC VA: 0x6CF68811EC
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
{
	// Fields


	// Properties

	public string PickupDirectoryLocation { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6881224 Offset: 0x182A224 VA: 0x6CF6881224
	public void .ctor() { }

	// RVA: 0x6CF688125C Offset: 0x182A25C VA: 0x6CF688125C
	public string get_PickupDirectoryLocation() { }

	// RVA: 0x6CF6881294 Offset: 0x182A294 VA: 0x6CF6881294
	public void set_PickupDirectoryLocation(string value) { }

	// RVA: 0x6CF68812CC Offset: 0x182A2CC VA: 0x6CF68812CC
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class NetSectionGroup : ConfigurationSectionGroup
{
	// Fields


	// Properties

	public AuthenticationModulesSection AuthenticationModules { get; }
	public ConnectionManagementSection ConnectionManagement { get; }
	public DefaultProxySection DefaultProxy { get; }
	public MailSettingsSectionGroup MailSettings { get; }
	public RequestCachingSection RequestCaching { get; }
	public SettingsSection Settings { get; }
	public WebRequestModulesSection WebRequestModules { get; }

	// Methods

	// RVA: 0x6CF6881304 Offset: 0x182A304 VA: 0x6CF6881304
	public void .ctor() { }

	// RVA: 0x6CF688133C Offset: 0x182A33C VA: 0x6CF688133C
	public AuthenticationModulesSection get_AuthenticationModules() { }

	// RVA: 0x6CF6881374 Offset: 0x182A374 VA: 0x6CF6881374
	public ConnectionManagementSection get_ConnectionManagement() { }

	// RVA: 0x6CF68813AC Offset: 0x182A3AC VA: 0x6CF68813AC
	public DefaultProxySection get_DefaultProxy() { }

	// RVA: 0x6CF68813E4 Offset: 0x182A3E4 VA: 0x6CF68813E4
	public MailSettingsSectionGroup get_MailSettings() { }

	// RVA: 0x6CF688141C Offset: 0x182A41C VA: 0x6CF688141C
	public RequestCachingSection get_RequestCaching() { }

	// RVA: 0x6CF6881454 Offset: 0x182A454 VA: 0x6CF6881454
	public SettingsSection get_Settings() { }

	// RVA: 0x6CF688148C Offset: 0x182A48C VA: 0x6CF688148C
	public WebRequestModulesSection get_WebRequestModules() { }

	// RVA: 0x6CF68814C4 Offset: 0x182A4C4 VA: 0x6CF68814C4
	public static NetSectionGroup GetSectionGroup(Configuration config) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class RequestCachingSection : ConfigurationSection
{
	// Fields


	// Properties

	public FtpCachePolicyElement DefaultFtpCachePolicy { get; }
	public HttpCachePolicyElement DefaultHttpCachePolicy { get; }
	public RequestCacheLevel DefaultPolicyLevel { get; set; }
	public bool DisableAllCaching { get; set; }
	public bool IsPrivateCache { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public TimeSpan UnspecifiedMaximumAge { get; set; }

	// Methods

	// RVA: 0x6CF68814FC Offset: 0x182A4FC VA: 0x6CF68814FC
	public void .ctor() { }

	// RVA: 0x6CF6881534 Offset: 0x182A534 VA: 0x6CF6881534
	public FtpCachePolicyElement get_DefaultFtpCachePolicy() { }

	// RVA: 0x6CF688156C Offset: 0x182A56C VA: 0x6CF688156C
	public HttpCachePolicyElement get_DefaultHttpCachePolicy() { }

	// RVA: 0x6CF68815A4 Offset: 0x182A5A4 VA: 0x6CF68815A4
	public RequestCacheLevel get_DefaultPolicyLevel() { }

	// RVA: 0x6CF68815DC Offset: 0x182A5DC VA: 0x6CF68815DC
	public void set_DefaultPolicyLevel(RequestCacheLevel value) { }

	// RVA: 0x6CF6881614 Offset: 0x182A614 VA: 0x6CF6881614
	public bool get_DisableAllCaching() { }

	// RVA: 0x6CF688164C Offset: 0x182A64C VA: 0x6CF688164C
	public void set_DisableAllCaching(bool value) { }

	// RVA: 0x6CF6881684 Offset: 0x182A684 VA: 0x6CF6881684
	public bool get_IsPrivateCache() { }

	// RVA: 0x6CF68816BC Offset: 0x182A6BC VA: 0x6CF68816BC
	public void set_IsPrivateCache(bool value) { }

	// RVA: 0x6CF68816F4 Offset: 0x182A6F4 VA: 0x6CF68816F4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF688172C Offset: 0x182A72C VA: 0x6CF688172C
	public TimeSpan get_UnspecifiedMaximumAge() { }

	// RVA: 0x6CF6881764 Offset: 0x182A764 VA: 0x6CF6881764
	public void set_UnspecifiedMaximumAge(TimeSpan value) { }

	// RVA: 0x6CF688179C Offset: 0x182A79C VA: 0x6CF688179C
	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey) { }

	// RVA: 0x6CF68817D4 Offset: 0x182A7D4 VA: 0x6CF68817D4
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class SettingsSection : ConfigurationSection
{
	// Fields


	// Properties

	public HttpListenerElement HttpListener { get; }
	public HttpWebRequestElement HttpWebRequest { get; }
	public Ipv6Element Ipv6 { get; }
	public PerformanceCountersElement PerformanceCounters { get; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public ServicePointManagerElement ServicePointManager { get; }
	public SocketElement Socket { get; }
	public WebProxyScriptElement WebProxyScript { get; }
	public WebUtilityElement WebUtility { get; }
	public WindowsAuthenticationElement WindowsAuthentication { get; }

	// Methods

	// RVA: 0x6CF688180C Offset: 0x182A80C VA: 0x6CF688180C
	public void .ctor() { }

	// RVA: 0x6CF6881844 Offset: 0x182A844 VA: 0x6CF6881844
	public HttpListenerElement get_HttpListener() { }

	// RVA: 0x6CF688187C Offset: 0x182A87C VA: 0x6CF688187C
	public HttpWebRequestElement get_HttpWebRequest() { }

	// RVA: 0x6CF68818B4 Offset: 0x182A8B4 VA: 0x6CF68818B4
	public Ipv6Element get_Ipv6() { }

	// RVA: 0x6CF68818EC Offset: 0x182A8EC VA: 0x6CF68818EC
	public PerformanceCountersElement get_PerformanceCounters() { }

	// RVA: 0x6CF6881924 Offset: 0x182A924 VA: 0x6CF6881924
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF688195C Offset: 0x182A95C VA: 0x6CF688195C
	public ServicePointManagerElement get_ServicePointManager() { }

	// RVA: 0x6CF6881994 Offset: 0x182A994 VA: 0x6CF6881994
	public SocketElement get_Socket() { }

	// RVA: 0x6CF68819CC Offset: 0x182A9CC VA: 0x6CF68819CC
	public WebProxyScriptElement get_WebProxyScript() { }

	// RVA: 0x6CF6881A04 Offset: 0x182AA04 VA: 0x6CF6881A04
	public WebUtilityElement get_WebUtility() { }

	// RVA: 0x6CF6881A3C Offset: 0x182AA3C VA: 0x6CF6881A3C
	public WindowsAuthenticationElement get_WindowsAuthentication() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement : ConfigurationElement
{
	// Fields


	// Properties

	public bool Enabled { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6881A74 Offset: 0x182AA74 VA: 0x6CF6881A74
	public void .ctor() { }

	// RVA: 0x6CF6881AAC Offset: 0x182AAAC VA: 0x6CF6881AAC
	public bool get_Enabled() { }

	// RVA: 0x6CF6881AE4 Offset: 0x182AAE4 VA: 0x6CF6881AE4
	public void set_Enabled(bool value) { }

	// RVA: 0x6CF6881B1C Offset: 0x182AB1C VA: 0x6CF6881B1C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement : ConfigurationElement
{
	// Fields


	// Properties

	public bool CheckCertificateName { get; set; }
	public bool CheckCertificateRevocationList { get; set; }
	public int DnsRefreshTimeout { get; set; }
	public bool EnableDnsRoundRobin { get; set; }
	public EncryptionPolicy EncryptionPolicy { get; set; }
	public bool Expect100Continue { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public bool UseNagleAlgorithm { get; set; }

	// Methods

	// RVA: 0x6CF6881B54 Offset: 0x182AB54 VA: 0x6CF6881B54
	public void .ctor() { }

	// RVA: 0x6CF6881B8C Offset: 0x182AB8C VA: 0x6CF6881B8C
	public bool get_CheckCertificateName() { }

	// RVA: 0x6CF6881BC4 Offset: 0x182ABC4 VA: 0x6CF6881BC4
	public void set_CheckCertificateName(bool value) { }

	// RVA: 0x6CF6881BFC Offset: 0x182ABFC VA: 0x6CF6881BFC
	public bool get_CheckCertificateRevocationList() { }

	// RVA: 0x6CF6881C34 Offset: 0x182AC34 VA: 0x6CF6881C34
	public void set_CheckCertificateRevocationList(bool value) { }

	// RVA: 0x6CF6881C6C Offset: 0x182AC6C VA: 0x6CF6881C6C
	public int get_DnsRefreshTimeout() { }

	// RVA: 0x6CF6881CA4 Offset: 0x182ACA4 VA: 0x6CF6881CA4
	public void set_DnsRefreshTimeout(int value) { }

	// RVA: 0x6CF6881CDC Offset: 0x182ACDC VA: 0x6CF6881CDC
	public bool get_EnableDnsRoundRobin() { }

	// RVA: 0x6CF6881D14 Offset: 0x182AD14 VA: 0x6CF6881D14
	public void set_EnableDnsRoundRobin(bool value) { }

	// RVA: 0x6CF6881D4C Offset: 0x182AD4C VA: 0x6CF6881D4C
	public EncryptionPolicy get_EncryptionPolicy() { }

	// RVA: 0x6CF6881D84 Offset: 0x182AD84 VA: 0x6CF6881D84
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x6CF6881DBC Offset: 0x182ADBC VA: 0x6CF6881DBC
	public bool get_Expect100Continue() { }

	// RVA: 0x6CF6881DF4 Offset: 0x182ADF4 VA: 0x6CF6881DF4
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x6CF6881E2C Offset: 0x182AE2C VA: 0x6CF6881E2C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6881E64 Offset: 0x182AE64 VA: 0x6CF6881E64
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x6CF6881E9C Offset: 0x182AE9C VA: 0x6CF6881E9C
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x6CF6881ED4 Offset: 0x182AED4 VA: 0x6CF6881ED4
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class SocketElement : ConfigurationElement
{
	// Fields


	// Properties

	public bool AlwaysUseCompletionPortsForAccept { get; set; }
	public bool AlwaysUseCompletionPortsForConnect { get; set; }
	public IPProtectionLevel IPProtectionLevel { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6881F0C Offset: 0x182AF0C VA: 0x6CF6881F0C
	public void .ctor() { }

	// RVA: 0x6CF6881F44 Offset: 0x182AF44 VA: 0x6CF6881F44
	public bool get_AlwaysUseCompletionPortsForAccept() { }

	// RVA: 0x6CF6881F7C Offset: 0x182AF7C VA: 0x6CF6881F7C
	public void set_AlwaysUseCompletionPortsForAccept(bool value) { }

	// RVA: 0x6CF6881FB4 Offset: 0x182AFB4 VA: 0x6CF6881FB4
	public bool get_AlwaysUseCompletionPortsForConnect() { }

	// RVA: 0x6CF6881FEC Offset: 0x182AFEC VA: 0x6CF6881FEC
	public void set_AlwaysUseCompletionPortsForConnect(bool value) { }

	// RVA: 0x6CF6882024 Offset: 0x182B024 VA: 0x6CF6882024
	public IPProtectionLevel get_IPProtectionLevel() { }

	// RVA: 0x6CF688205C Offset: 0x182B05C VA: 0x6CF688205C
	public void set_IPProtectionLevel(IPProtectionLevel value) { }

	// RVA: 0x6CF6882094 Offset: 0x182B094 VA: 0x6CF6882094
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68820CC Offset: 0x182B0CC VA: 0x6CF68820CC
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement : ConfigurationElement
{
	// Fields


	// Properties

	public int AutoConfigUrlRetryInterval { get; set; }
	public TimeSpan DownloadTimeout { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF6882104 Offset: 0x182B104 VA: 0x6CF6882104
	public void .ctor() { }

	// RVA: 0x6CF688213C Offset: 0x182B13C VA: 0x6CF688213C
	public int get_AutoConfigUrlRetryInterval() { }

	// RVA: 0x6CF6882174 Offset: 0x182B174 VA: 0x6CF6882174
	public void set_AutoConfigUrlRetryInterval(int value) { }

	// RVA: 0x6CF68821AC Offset: 0x182B1AC VA: 0x6CF68821AC
	public TimeSpan get_DownloadTimeout() { }

	// RVA: 0x6CF68821E4 Offset: 0x182B1E4 VA: 0x6CF68821E4
	public void set_DownloadTimeout(TimeSpan value) { }

	// RVA: 0x6CF688221C Offset: 0x182B21C VA: 0x6CF688221C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF6882254 Offset: 0x182B254 VA: 0x6CF6882254
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WebUtilityElement : ConfigurationElement
{
	// Fields


	// Properties

	protected override ConfigurationPropertyCollection Properties { get; }
	public UnicodeDecodingConformance UnicodeDecodingConformance { get; set; }
	public UnicodeEncodingConformance UnicodeEncodingConformance { get; set; }

	// Methods

	// RVA: 0x6CF688228C Offset: 0x182B28C VA: 0x6CF688228C
	public void .ctor() { }

	// RVA: 0x6CF68822C4 Offset: 0x182B2C4 VA: 0x6CF68822C4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68822FC Offset: 0x182B2FC VA: 0x6CF68822FC
	public UnicodeDecodingConformance get_UnicodeDecodingConformance() { }

	// RVA: 0x6CF6882334 Offset: 0x182B334 VA: 0x6CF6882334
	public void set_UnicodeDecodingConformance(UnicodeDecodingConformance value) { }

	// RVA: 0x6CF688236C Offset: 0x182B36C VA: 0x6CF688236C
	public UnicodeEncodingConformance get_UnicodeEncodingConformance() { }

	// RVA: 0x6CF68823A4 Offset: 0x182B3A4 VA: 0x6CF68823A4
	public void set_UnicodeEncodingConformance(UnicodeEncodingConformance value) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WindowsAuthenticationElement : ConfigurationElement
{
	// Fields


	// Properties

	public int DefaultCredentialsHandleCacheSize { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x6CF68823DC Offset: 0x182B3DC VA: 0x6CF68823DC
	public void .ctor() { }

	// RVA: 0x6CF6882414 Offset: 0x182B414 VA: 0x6CF6882414
	public int get_DefaultCredentialsHandleCacheSize() { }

	// RVA: 0x6CF688244C Offset: 0x182B44C VA: 0x6CF688244C
	public void set_DefaultCredentialsHandleCacheSize(int value) { }

	// RVA: 0x6CF6882484 Offset: 0x182B484 VA: 0x6CF6882484
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection : ConfigurationSection
{
	// Fields


	// Properties

	protected override ConfigurationPropertyCollection Properties { get; }
	public WebRequestModuleElementCollection WebRequestModules { get; }

	// Methods

	// RVA: 0x6CF68824BC Offset: 0x182B4BC VA: 0x6CF68824BC
	public void .ctor() { }

	// RVA: 0x6CF68824F4 Offset: 0x182B4F4 VA: 0x6CF68824F4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF688252C Offset: 0x182B52C VA: 0x6CF688252C
	public WebRequestModuleElementCollection get_WebRequestModules() { }

	// RVA: 0x6CF6882564 Offset: 0x182B564 VA: 0x6CF6882564
	protected override void InitializeDefault() { }

	// RVA: 0x6CF688259C Offset: 0x182B59C VA: 0x6CF688259C
	protected override void PostDeserialize() { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
{
	// Fields


	// Properties

	public WebRequestModuleElement Item { get; set; }

	// Methods

	// RVA: 0x6CF68825D4 Offset: 0x182B5D4 VA: 0x6CF68825D4
	public void .ctor() { }

	// RVA: 0x6CF688260C Offset: 0x182B60C VA: 0x6CF688260C
	public WebRequestModuleElement get_Item(int index) { }

	// RVA: 0x6CF6882644 Offset: 0x182B644 VA: 0x6CF6882644
	public void set_Item(int index, WebRequestModuleElement value) { }

	// RVA: 0x6CF688267C Offset: 0x182B67C VA: 0x6CF688267C
	public WebRequestModuleElement get_Item(string name) { }

	// RVA: 0x6CF68826B4 Offset: 0x182B6B4 VA: 0x6CF68826B4
	public void set_Item(string name, WebRequestModuleElement value) { }

	// RVA: 0x6CF68826EC Offset: 0x182B6EC VA: 0x6CF68826EC
	public void Add(WebRequestModuleElement element) { }

	// RVA: 0x6CF6882724 Offset: 0x182B724 VA: 0x6CF6882724
	public void Clear() { }

	// RVA: 0x6CF688275C Offset: 0x182B75C VA: 0x6CF688275C
	protected override ConfigurationElement CreateNewElement() { }

	// RVA: 0x6CF6882794 Offset: 0x182B794 VA: 0x6CF6882794
	protected override object GetElementKey(ConfigurationElement element) { }

	// RVA: 0x6CF68827CC Offset: 0x182B7CC VA: 0x6CF68827CC
	public int IndexOf(WebRequestModuleElement element) { }

	// RVA: 0x6CF6882804 Offset: 0x182B804 VA: 0x6CF6882804
	public void Remove(WebRequestModuleElement element) { }

	// RVA: 0x6CF688283C Offset: 0x182B83C VA: 0x6CF688283C
	public void Remove(string name) { }

	// RVA: 0x6CF6882874 Offset: 0x182B874 VA: 0x6CF6882874
	public void RemoveAt(int index) { }

}

// Dll : System.dll
// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement : ConfigurationElement
{
	// Fields


	// Properties

	public string Prefix { get; set; }
	protected override ConfigurationPropertyCollection Properties { get; }
	public Type Type { get; set; }

	// Methods

	// RVA: 0x6CF68828AC Offset: 0x182B8AC VA: 0x6CF68828AC
	public void .ctor() { }

	// RVA: 0x6CF68828E4 Offset: 0x182B8E4 VA: 0x6CF68828E4
	public void .ctor(string prefix, string type) { }

	// RVA: 0x6CF688291C Offset: 0x182B91C VA: 0x6CF688291C
	public void .ctor(string prefix, Type type) { }

	// RVA: 0x6CF6882954 Offset: 0x182B954 VA: 0x6CF6882954
	public string get_Prefix() { }

	// RVA: 0x6CF688298C Offset: 0x182B98C VA: 0x6CF688298C
	public void set_Prefix(string value) { }

	// RVA: 0x6CF68829C4 Offset: 0x182B9C4 VA: 0x6CF68829C4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x6CF68829FC Offset: 0x182B9FC VA: 0x6CF68829FC
	public Type get_Type() { }

	// RVA: 0x6CF6882A34 Offset: 0x182BA34 VA: 0x6CF6882A34
	public void set_Type(Type value) { }

}

// Dll : System.dll
// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler : Object, IConfigurationSectionHandler
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6882A6C Offset: 0x182BA6C VA: 0x6CF6882A6C
	public void .ctor() { }

	// RVA: 0x6CF6882AA4 Offset: 0x182BAA4 VA: 0x6CF6882AA4
	public virtual object Create(object parent, object configContext, XmlNode section) { }

}

// Dll : System.dll
// Namespace: Unity
internal sealed class ThrowStub : ObjectDisposedException
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6882ADC Offset: 0x182BADC VA: 0x6CF6882ADC
	public static void ThrowNotSupportedException() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class achiev : Object
{
	// Fields

	public string achievName; // 0x10
	public string achievDescription; // 0x18
	public Sprite achievImage; // 0x20
	public int forCompleteCount; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5D7E490 Offset: 0xD27490 VA: 0x6CF5D7E490
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Achievement : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public List`1 achievement; // 0x30
	public GameObject achievementPrefab; // 0x38
	public GameObject achievementContent; // 0x40
	public Text achievementName; // 0x48
	public Image achievementImage; // 0x50
	public Text achievementDescription; // 0x58
	public Image achievementProgress; // 0x60
	public Image achievementCompleted; // 0x68
	public Text progressText; // 0x70

	// Properties


	// Methods

	// RVA: 0x6CF5D7D9CC Offset: 0xD269CC VA: 0x6CF5D7D9CC
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D7DA30 Offset: 0xD26A30 VA: 0x6CF5D7DA30
	private void Update() { }

	// RVA: 0x6CF5D7DAD0 Offset: 0xD26AD0 VA: 0x6CF5D7DAD0
	private void Start() { }

	// RVA: 0x6CF5D7E0B0 Offset: 0xD270B0 VA: 0x6CF5D7E0B0
	public void SetUpdateAchievement() { }

	// RVA: 0x6CF5D7E3E4 Offset: 0xD273E4 VA: 0x6CF5D7E3E4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class SoundGroup : Object
{
	// Fields

	public string soundName; // 0x10
	public AudioClip audioClip; // 0x18
	public float volume; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5D7E780 Offset: 0xD27780 VA: 0x6CF5D7E780
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class AudiosManager : MonoBehaviour
{
	// Fields

	public bool iMute; // 0x20
	public List`1 musicClips; // 0x28
	public static AudiosManager instance; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5D7E498 Offset: 0xD27498 VA: 0x6CF5D7E498
	public void Start() { }

	// RVA: 0x6CF5D7E544 Offset: 0xD27544 VA: 0x6CF5D7E544
	public void PlayingSound(string _soundName) { }

	// RVA: 0x6CF5D7E65C Offset: 0xD2765C VA: 0x6CF5D7E65C
	private int FindSound(string _soundName) { }

	// RVA: 0x6CF5D7E704 Offset: 0xD27704 VA: 0x6CF5D7E704
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ButtonId : MonoBehaviour
{
	// Fields

	private int idbutton; // 0x20
	public CasesSort cs; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5D7E790 Offset: 0xD27790 VA: 0x6CF5D7E790
	public void GetId() { }

	// RVA: 0x6CF5D7EA30 Offset: 0xD27A30 VA: 0x6CF5D7EA30
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class Item : Object
{
	// Fields

	public string itemName; // 0x10
	public float itemPrice; // 0x18
	public Sprite itemSprite; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5D81CA4 Offset: 0xD2ACA4 VA: 0x6CF5D81CA4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class Case : Object
{
	// Fields

	public string caseName; // 0x10
	public Sprite caseImage; // 0x18
	public Sprite caseKeyImage; // 0x20
	public List`1 caseWeaponBlue; // 0x28
	public List`1 caseWeaponPurple; // 0x30
	public List`1 caseWeaponPink; // 0x38
	public List`1 caseWeaponRed; // 0x40
	public List`1 caseWeaponYellow; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5D81CAC Offset: 0xD2ACAC VA: 0x6CF5D81CAC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CasesSort : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public List`1 casesList; // 0x30
	public GameObject[] WeaponLevelPrefabs; // 0x38
	public Image[] weaponImages; // 0x40
	public int startKeyCount; // 0x48
	public GameObject casePrefab; // 0x50
	public GameObject caseContent; // 0x58
	public Text caseName; // 0x60
	public Image caseImg; // 0x68
	public Text caseKeyCount; // 0x70
	public Image caseKeyImg; // 0x78
	public GameObject OpenButton; // 0x80
	public GameObject caseViewPanel; // 0x88
	public GameObject caseRandomPanel; // 0x90
	public GameObject KeyMessagePanel; // 0x98
	public GameObject rollPanel; // 0xA0
	public GameObject lineChecker; // 0xA8
	private bool caseOpen; // 0xB0
	private float rollPower; // 0xB4
	private RaycastHit2D checkSprite; // 0xB8
	private int weaponIndex; // 0xDC
	private int dropId; // 0xE0
	public static float rollSpeed; // 0x0
	public GameObject dropedWeaponPanel; // 0xE8
	public Image dropedWeaponImage; // 0xF0
	public Text droppedWeaponPrice; // 0xF8
	public GameObject sellPanel; // 0x100
	public Text nameSell; // 0x108
	public Image spriteSell; // 0x110
	public Text priceSell; // 0x118
	private float nprice; // 0x120
	private string sName; // 0x128
	public static int iNum; // 0x4
	private bool soundCheck; // 0x130
	private string indexCheck; // 0x138

	// Properties


	// Methods

	// RVA: 0x6CF5D7EA38 Offset: 0xD27A38 VA: 0x6CF5D7EA38
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D7EA9C Offset: 0xD27A9C VA: 0x6CF5D7EA9C
	private void Start() { }

	// RVA: 0x6CF5D7F164 Offset: 0xD28164 VA: 0x6CF5D7F164
	private void Update() { }

	// RVA: 0x6CF5D7EE44 Offset: 0xD27E44 VA: 0x6CF5D7EE44
	private void CreateCases() { }

	// RVA: 0x6CF5D7FA24 Offset: 0xD28A24 VA: 0x6CF5D7FA24
	private void CasesRandom(int caseID) { }

	// RVA: 0x6CF5D7E7D4 Offset: 0xD277D4 VA: 0x6CF5D7E7D4
	public void caseOpenButton(int currentCase) { }

	// RVA: 0x6CF5D7FF40 Offset: 0xD28F40 VA: 0x6CF5D7FF40
	public void CanselButton() { }

	// RVA: 0x6CF5D7FFA4 Offset: 0xD28FA4 VA: 0x6CF5D7FFA4
	public void ApplyButton() { }

	// RVA: 0x6CF5D800AC Offset: 0xD290AC VA: 0x6CF5D800AC
	public void BuyMoreKeys() { }

	// RVA: 0x6CF5D800CC Offset: 0xD290CC VA: 0x6CF5D800CC
	public void SellItem(int c, int l, int w, int n) { }

	// RVA: 0x6CF5D806D0 Offset: 0xD296D0 VA: 0x6CF5D806D0
	public void UseSkin() { }

	// RVA: 0x6CF5D81108 Offset: 0xD2A108 VA: 0x6CF5D81108
	public void SellThisItem() { }

	// RVA: 0x6CF5D81BF0 Offset: 0xD2ABF0 VA: 0x6CF5D81BF0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class IAP_Rewarded : MonoBehaviour
{
	// Fields

	public static bool checkBalance; // 0x0
	public GameObject AdPanel; // 0x20
	public GameObject Menuyoket; // 0x28
	private ObscuredBool cheat; // 0x30
	public ReklamTamEkran reklamcagir3; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF5D81D88 Offset: 0xD2AD88 VA: 0x6CF5D81D88
	private void Awake() { }

	// RVA: 0x6CF5D81ED4 Offset: 0xD2AED4 VA: 0x6CF5D81ED4
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x6CF5D81ED8 Offset: 0xD2AED8 VA: 0x6CF5D81ED8
	public void Exitbuttonum() { }

	// RVA: 0x6CF5D81F2C Offset: 0xD2AF2C VA: 0x6CF5D81F2C
	private void Start() { }

	// RVA: 0x6CF5D8204C Offset: 0xD2B04C VA: 0x6CF5D8204C
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D820B0 Offset: 0xD2B0B0 VA: 0x6CF5D820B0
	private void Update() { }

	// RVA: 0x6CF5D82150 Offset: 0xD2B150 VA: 0x6CF5D82150
	public void GetMoney() { }

	// RVA: 0x6CF5D821D0 Offset: 0xD2B1D0 VA: 0x6CF5D821D0
	public void CancelAd() { }

	// RVA: 0x6CF5D821F0 Offset: 0xD2B1F0 VA: 0x6CF5D821F0
	public void ShowRewardedAd() { }

	// RVA: 0x6CF5D82284 Offset: 0xD2B284 VA: 0x6CF5D82284
	public void videofinished() { }

	// RVA: 0x6CF5D82344 Offset: 0xD2B344 VA: 0x6CF5D82344
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Inventory : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public Transform selectedItem; // 0x30
	public Transform selectedSlot; // 0x38
	public Transform originalSlot; // 0x40
	public Transform canvas; // 0x48
	public bool canGrab; // 0x50
	private int inventorySlotCount; // 0x54
	public GameObject inventorySlots; // 0x58
	public GameObject slotPrefab; // 0x60
	public GameObject itemPrefab; // 0x68
	private int caseId; // 0x70
	private int levelId; // 0x74
	private int weaponId; // 0x78
	public List`1 slots; // 0x80
	public CasesSort casesSort; // 0x88
	public List`1 idInventory; // 0x90

	// Properties


	// Methods

	// RVA: 0x6CF5D823B0 Offset: 0xD2B3B0 VA: 0x6CF5D823B0
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D82414 Offset: 0xD2B414 VA: 0x6CF5D82414
	private void Start() { }

	// RVA: 0x6CF5D827AC Offset: 0xD2B7AC VA: 0x6CF5D827AC
	public void ReloadItems() { }

	// RVA: 0x6CF5D8295C Offset: 0xD2B95C VA: 0x6CF5D8295C
	public void SetItem(string id, int nn) { }

	// RVA: 0x6CF5D831AC Offset: 0xD2C1AC VA: 0x6CF5D831AC
	public void SortItems(int itemLevel) { }

	// RVA: 0x6CF5D83388 Offset: 0xD2C388 VA: 0x6CF5D83388
	private void Update() { }

	// RVA: 0x6CF5D836C4 Offset: 0xD2C6C4 VA: 0x6CF5D836C4
	private void SelectedItemGrabbed(bool i) { }

	// RVA: 0x6CF5D8378C Offset: 0xD2C78C VA: 0x6CF5D8378C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Item : MonoBehaviour
{
	// Fields

	private CasesSort caseSort; // 0x20
	public ObscuredInt _id; // 0x28
	public ObscuredInt _lvl; // 0x3C
	public ObscuredInt _case; // 0x50
	public ObscuredInt _number; // 0x64
	private ObscuredBool cheat; // 0x78

	// Properties


	// Methods

	// RVA: 0x6CF5D83888 Offset: 0xD2C888 VA: 0x6CF5D83888
	private void Start() { }

	// RVA: 0x6CF5D83A40 Offset: 0xD2CA40 VA: 0x6CF5D83A40
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D83AA4 Offset: 0xD2CAA4 VA: 0x6CF5D83AA4
	private void Update() { }

	// RVA: 0x6CF5D83B8C Offset: 0xD2CB8C VA: 0x6CF5D83B8C
	public void SellingItem() { }

	// RVA: 0x6CF5D83C9C Offset: 0xD2CC9C VA: 0x6CF5D83C9C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class LoadPictureCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5D85158 Offset: 0xD2E158 VA: 0x6CF5D85158
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5D851F4 Offset: 0xD2E1F4 VA: 0x6CF5D851F4
	public virtual void Invoke(Texture2D texture) { }

	// RVA: 0x6CF5D85208 Offset: 0xD2E208 VA: 0x6CF5D85208
	public virtual IAsyncResult BeginInvoke(Texture2D texture, AsyncCallback callback, object object) { }

	// RVA: 0x6CF5D85228 Offset: 0xD2E228 VA: 0x6CF5D85228
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <LoadPictureEnumerator>d__27 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public LoadPictureCallback callback; // 0x28
	private WWW <www>5__2; // 0x30

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D84160 Offset: 0xD2D160 VA: 0x6CF5D84160
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5D85234 Offset: 0xD2E234 VA: 0x6CF5D85234
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5D85238 Offset: 0xD2E238 VA: 0x6CF5D85238
	private bool MoveNext() { }

	// RVA: 0x6CF5D852FC Offset: 0xD2E2FC VA: 0x6CF5D852FC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5D85304 Offset: 0xD2E304 VA: 0x6CF5D85304
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5D8533C Offset: 0xD2E33C VA: 0x6CF5D8533C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <RequestSteam>d__25 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Navigation <>4__this; // 0x20
	public string steamId; // 0x28
	private WWW <www>5__2; // 0x30

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D840CC Offset: 0xD2D0CC VA: 0x6CF5D840CC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5D85344 Offset: 0xD2E344 VA: 0x6CF5D85344
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5D85348 Offset: 0xD2E348 VA: 0x6CF5D85348
	private bool MoveNext() { }

	// RVA: 0x6CF5D85754 Offset: 0xD2E754 VA: 0x6CF5D85754
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5D8575C Offset: 0xD2E75C VA: 0x6CF5D8575C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5D85794 Offset: 0xD2E794 VA: 0x6CF5D85794
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Navigation : MonoBehaviour
{
	// Fields

	private int panelNumber; // 0x20
	private ObscuredInt curNumber; // 0x24
	private bool slide; // 0x38
	private ObscuredBool cheat; // 0x3C
	public GameObject profilViewPanel; // 0x48
	public GameObject caseViewPanel; // 0x50
	public GameObject storeViewPanel; // 0x58
	public GameObject inventoryViewPanel; // 0x60
	public GameObject exitDialogPanel; // 0x68
	public GameObject clearSavesPanel; // 0x70
	public Text balanceText; // 0x78
	public Image userAvatar; // 0x80
	public Image rankImage; // 0x88
	public Sprite[] rankSprites; // 0x90
	private ObscuredInt currentRank; // 0x98
	public Text nickName; // 0xB0
	private string steamInfo; // 0xB8
	private JsonData itemData; // 0xC0
	public GameObject enterSteamPanel; // 0xC8
	public GameObject profileStartsPanel; // 0xD0
	public InputField inputId; // 0xD8
	private ObscuredFloat keyPrice; // 0xE0
	private bool isExit; // 0x100

	// Properties


	// Methods

	// RVA: 0x6CF5D83D08 Offset: 0xD2CD08 VA: 0x6CF5D83D08
	private void Start() { }

	// RVA: 0x6CF5D83FFC Offset: 0xD2CFFC VA: 0x6CF5D83FFC
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D84060 Offset: 0xD2D060 VA: 0x6CF5D84060
	private IEnumerator RequestSteam(string steamId) { }

	// RVA: 0x6CF5D840F4 Offset: 0xD2D0F4 VA: 0x6CF5D840F4
	private IEnumerator LoadPictureEnumerator(string url, LoadPictureCallback callback) { }

	// RVA: 0x6CF5D84188 Offset: 0xD2D188 VA: 0x6CF5D84188
	private void Update() { }

	// RVA: 0x6CF5D8479C Offset: 0xD2D79C VA: 0x6CF5D8479C
	private void ResetPanel(int panel) { }

	// RVA: 0x6CF5D84958 Offset: 0xD2D958 VA: 0x6CF5D84958
	public void MainPanel() { }

	// RVA: 0x6CF5D84968 Offset: 0xD2D968 VA: 0x6CF5D84968
	public void StorePanel() { }

	// RVA: 0x6CF5D84978 Offset: 0xD2D978 VA: 0x6CF5D84978
	public void SetPrice(float price) { }

	// RVA: 0x6CF5D849F8 Offset: 0xD2D9F8 VA: 0x6CF5D849F8
	public void BuyKeyButton(int idKey) { }

	// RVA: 0x6CF5D84C58 Offset: 0xD2DC58 VA: 0x6CF5D84C58
	public void InventoryPanel() { }

	// RVA: 0x6CF5D84C68 Offset: 0xD2DC68 VA: 0x6CF5D84C68
	public void ProfilePanel() { }

	// RVA: 0x6CF5D84E34 Offset: 0xD2DE34 VA: 0x6CF5D84E34
	public void SetSteamId() { }

	// RVA: 0x6CF5D84E64 Offset: 0xD2DE64 VA: 0x6CF5D84E64
	public void LogOut() { }

	// RVA: 0x6CF5D84F3C Offset: 0xD2DF3C VA: 0x6CF5D84F3C
	public void Quit_Yes() { }

	// RVA: 0x6CF5D84F9C Offset: 0xD2DF9C VA: 0x6CF5D84F9C
	public void Quit_No() { }

	// RVA: 0x6CF5D84FAC Offset: 0xD2DFAC VA: 0x6CF5D84FAC
	public void ClearSaves() { }

	// RVA: 0x6CF5D85048 Offset: 0xD2E048 VA: 0x6CF5D85048
	public void .ctor() { }

	// RVA: 0x6CF5D8510C Offset: 0xD2E10C VA: 0x6CF5D8510C
	private void <RequestSteam>b__25_0(Texture2D pictureTexture) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Roll : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5D8579C Offset: 0xD2E79C VA: 0x6CF5D8579C
	private void Update() { }

	// RVA: 0x6CF5D85838 Offset: 0xD2E838 VA: 0x6CF5D85838
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Slot : MonoBehaviour
{
	// Fields

	private Inventory inventoryController; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5D85840 Offset: 0xD2E840 VA: 0x6CF5D85840
	private void Start() { }

	// RVA: 0x6CF5D858B4 Offset: 0xD2E8B4 VA: 0x6CF5D858B4
	private void OnMouseEnter() { }

	// RVA: 0x6CF5D858D8 Offset: 0xD2E8D8 VA: 0x6CF5D858D8
	private void OnMouseExit() { }

	// RVA: 0x6CF5D858F4 Offset: 0xD2E8F4 VA: 0x6CF5D858F4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DestroyTimer>d__7 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExplosionScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D85A7C Offset: 0xD2EA7C VA: 0x6CF5D85A7C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5D85AB8 Offset: 0xD2EAB8 VA: 0x6CF5D85AB8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5D85ABC Offset: 0xD2EABC VA: 0x6CF5D85ABC
	private bool MoveNext() { }

	// RVA: 0x6CF5D85BA4 Offset: 0xD2EBA4 VA: 0x6CF5D85BA4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5D85BAC Offset: 0xD2EBAC VA: 0x6CF5D85BAC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5D85BE4 Offset: 0xD2EBE4 VA: 0x6CF5D85BE4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <LightFlash>d__6 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExplosionScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D85A54 Offset: 0xD2EA54 VA: 0x6CF5D85A54
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5D85BEC Offset: 0xD2EBEC VA: 0x6CF5D85BEC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5D85BF0 Offset: 0xD2EBF0 VA: 0x6CF5D85BF0
	private bool MoveNext() { }

	// RVA: 0x6CF5D85CF8 Offset: 0xD2ECF8 VA: 0x6CF5D85CF8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5D85D00 Offset: 0xD2ED00 VA: 0x6CF5D85D00
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5D85D38 Offset: 0xD2ED38 VA: 0x6CF5D85D38
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ExplosionScript : MonoBehaviour
{
	// Fields

	public float despawnTime; // 0x20
	public float lightDuration; // 0x24
	public Light lightFlash; // 0x28
	public AudioClip[] explosionSounds; // 0x30
	public AudioSource audioSource; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5D858FC Offset: 0xD2E8FC VA: 0x6CF5D858FC
	private void Start() { }

	// RVA: 0x6CF5D859F4 Offset: 0xD2E9F4 VA: 0x6CF5D859F4
	private IEnumerator LightFlash() { }

	// RVA: 0x6CF5D85994 Offset: 0xD2E994 VA: 0x6CF5D85994
	private IEnumerator DestroyTimer() { }

	// RVA: 0x6CF5D85AA4 Offset: 0xD2EAA4 VA: 0x6CF5D85AA4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ArmoryGizmo : MonoBehaviour
{
	// Fields

	private int numPoints; // 0x20
	private Vector3[] positions; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5D85D40 Offset: 0xD2ED40 VA: 0x6CF5D85D40
	private void OnDrawGizmos() { }

	// RVA: 0x6CF5D85F98 Offset: 0xD2EF98 VA: 0x6CF5D85F98
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class MenuGizmo : MonoBehaviour
{
	// Fields

	public Transform[] basePoints; // 0x20
	private float distance; // 0x28
	private float size; // 0x2C

	// Properties


	// Methods

	// RVA: 0x6CF5D85FF8 Offset: 0xD2EFF8 VA: 0x6CF5D85FF8
	private void OnDrawGizmos() { }

	// RVA: 0x6CF5D86478 Offset: 0xD2F478 VA: 0x6CF5D86478
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SpawnPointGizmo : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5D8648C Offset: 0xD2F48C VA: 0x6CF5D8648C
	private void OnDrawGizmos() { }

	// RVA: 0x6CF5D8682C Offset: 0xD2F82C VA: 0x6CF5D8682C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class xmlReader : MonoBehaviour
{
	// Fields

	public TextAsset dictonary; // 0x20
	public string languageName; // 0x28
	public int currentLanguage; // 0x30
	public string button1; // 0x38
	public string button2; // 0x40
	public string button3; // 0x48
	public string button4; // 0x50
	public string button5; // 0x58
	public string button6; // 0x60
	public string button7; // 0x68
	public string button8; // 0x70
	public string button9; // 0x78
	public string button10; // 0x80
	public string button11; // 0x88
	public string button12; // 0x90
	public string button13; // 0x98
	public string button14; // 0xA0
	public string button15; // 0xA8
	public string button16; // 0xB0
	public string button17; // 0xB8
	public string button18; // 0xC0
	public string button19; // 0xC8
	public string button20; // 0xD0
	public string button21; // 0xD8
	public string button22; // 0xE0
	public string button23; // 0xE8
	public string button24; // 0xF0
	public string button25; // 0xF8
	public string button26; // 0x100
	public string button27; // 0x108
	public string button28; // 0x110
	public string button29; // 0x118
	public string button30; // 0x120
	public string button31; // 0x128
	public string button32; // 0x130
	public string button33; // 0x138
	public string button34; // 0x140
	public string button35; // 0x148
	public string button36; // 0x150
	public string button37; // 0x158
	public string button38; // 0x160
	public string button39; // 0x168
	public string button40; // 0x170
	public string button41; // 0x178
	public string button42; // 0x180
	public string button43; // 0x188
	public string button44; // 0x190
	public string button45; // 0x198
	public string button46; // 0x1A0
	public string button47; // 0x1A8
	public string button48; // 0x1B0
	public string button49; // 0x1B8
	public string button50; // 0x1C0
	public string button51; // 0x1C8
	public string button52; // 0x1D0
	public string button53; // 0x1D8
	public string button54; // 0x1E0
	public string button55; // 0x1E8
	public string button56; // 0x1F0
	public string button57; // 0x1F8
	public string button58; // 0x200
	public string button59; // 0x208
	public string button60; // 0x210
	public string button61; // 0x218
	public string button62; // 0x220
	public string button63; // 0x228
	public string button64; // 0x230
	public string button65; // 0x238
	public string button66; // 0x240
	public string button67; // 0x248
	public string button68; // 0x250
	public string button69; // 0x258
	public string button70; // 0x260
	public string button71; // 0x268
	public string button72; // 0x270
	public string button73; // 0x278
	public string button74; // 0x280
	public string button75; // 0x288
	public string button76; // 0x290
	public string button77; // 0x298
	public string button78; // 0x2A0
	public string button79; // 0x2A8
	public string button80; // 0x2B0
	public string button81; // 0x2B8
	public string button82; // 0x2C0
	public string button83; // 0x2C8
	public string button84; // 0x2D0
	public string button85; // 0x2D8
	public string button86; // 0x2E0
	public string button87; // 0x2E8
	public string button88; // 0x2F0
	public string button89; // 0x2F8
	public string button90; // 0x300
	public string button91; // 0x308
	public string button92; // 0x310
	public string button93; // 0x318
	public string button94; // 0x320
	public string button95; // 0x328
	public string button96; // 0x330
	public string button97; // 0x338
	public string button98; // 0x340
	public string button99; // 0x348
	public string button100; // 0x350
	public string button101; // 0x358
	public string button102; // 0x360
	public string button103; // 0x368
	public string button104; // 0x370
	public string button105; // 0x378
	public string button106; // 0x380
	public string button107; // 0x388
	public string button108; // 0x390
	public string button109; // 0x398
	public string button110; // 0x3A0
	private List`1 languages; // 0x3A8
	private Dictionary`2 obj; // 0x3B0

	// Properties


	// Methods

	// RVA: 0x6CF5D86834 Offset: 0xD2F834 VA: 0x6CF5D86834
	private void Awake() { }

	// RVA: 0x6CF5D8AF70 Offset: 0xD33F70 VA: 0x6CF5D8AF70
	private void Update() { }

	// RVA: 0x6CF5D86838 Offset: 0xD2F838 VA: 0x6CF5D86838
	private void Reader() { }

	// RVA: 0x6CF5D8C9D4 Offset: 0xD359D4 VA: 0x6CF5D8C9D4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum BuySection
{
	// Fields

	public int value__; // 0x10
	public const BuySection Primary = 0; // 0x0
	public const BuySection Secondary = 1; // 0x0
	public const BuySection Special = 2; // 0x0
	public const BuySection Sniper = 3; // 0x0
	public const BuySection ShotGuns = 4; // 0x0
	public const BuySection HalfPrimary = 5; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class BuyMenu : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public int lastSelectedWeapon; // 0x2C
	public BuySection buySection; // 0x30
	public AudioClip ClickSong; // 0x38
	private AudioSource scoreAudioSource; // 0x40
	private RoomController rc; // 0x48
	private xmlReader xml; // 0x50
	private string languagesPrefsName; // 0x58
	private List`1 primaryWeaponsTmp; // 0x60
	private List`1 secondaryWeaponsTmp; // 0x68
	private List`1 specialWeaponsTmp; // 0x70
	private List`1 grenadeTmp; // 0x78
	private List`1 flashTmp; // 0x80
	private int selectedPrimary; // 0x88
	private int selectedSecondary; // 0x8C
	private int selectedSpecial; // 0x90
	private int selectedGrenade; // 0x94
	private int selectedFlash; // 0x98
	private int selectedC4; // 0x9C
	private GUIStyle guiStyle; // 0xA0

	// Properties


	// Methods

	// RVA: 0x6CF5D8CA50 Offset: 0xD35A50 VA: 0x6CF5D8CA50
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5D8CAB4 Offset: 0xD35AB4 VA: 0x6CF5D8CAB4
	private void Start() { }

	// RVA: 0x6CF5D8D034 Offset: 0xD36034 VA: 0x6CF5D8D034
	private void ObfuscateWeaponCost(List`1 wpmList, int selectedIndex) { }

	// RVA: 0x6CF5D8D18C Offset: 0xD3618C VA: 0x6CF5D8D18C
	public void ApplySelectedWeapons() { }

	// RVA: 0x6CF5D8D5D8 Offset: 0xD365D8 VA: 0x6CF5D8D5D8
	public void ApplySelectedWeaponsGrenades() { }

	// RVA: 0x6CF5D8D7E0 Offset: 0xD367E0 VA: 0x6CF5D8D7E0
	public void ResetSelectedWeapons() { }

	// RVA: 0x6CF5D8D848 Offset: 0xD36848 VA: 0x6CF5D8D848
	public int GetWeaponCost(int type) { }

	// RVA: 0x6CF5D8D9D0 Offset: 0xD369D0 VA: 0x6CF5D8D9D0
	private void OnGUI() { }

	// RVA: 0x6CF5D8DB30 Offset: 0xD36B30 VA: 0x6CF5D8DB30
	private void Update() { }

	// RVA: 0x6CF5D8DC34 Offset: 0xD36C34 VA: 0x6CF5D8DC34
	private void BuyMenuWindow(int windowID) { }

	// RVA: 0x6CF5D8E22C Offset: 0xD3722C VA: 0x6CF5D8E22C
	private void ShowWeaponItems(List`1 weaponListTmp, int selectedIndex, int type) { }

	// RVA: 0x6CF5D95310 Offset: 0xD3E310 VA: 0x6CF5D95310
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum CurrentWindow
{
	// Fields

	public int value__; // 0x10
	public const CurrentWindow Reklam = 0; // 0x0
	public const CurrentWindow Main = 1; // 0x0
	public const CurrentWindow PlayNow = 2; // 0x0
	public const CurrentWindow PlayNowMaybe = 3; // 0x0
	public const CurrentWindow Options = 4; // 0x0
	public const CurrentWindow Profile = 5; // 0x0
	public const CurrentWindow PlayAfter = 6; // 0x0
	public const CurrentWindow SearchNo = 7; // 0x0
	public const CurrentWindow SearchNow = 8; // 0x0
	public const CurrentWindow RoomNameW = 9; // 0x0
	public const CurrentWindow RoomNameCheck = 10; // 0x0
	public const CurrentWindow FindingRoomName = 11; // 0x0
	public const CurrentWindow Information = 12; // 0x0
	public const CurrentWindow None = 13; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AvailableMaps : Object
{
	// Fields

	public string mapName; // 0x10
	public Texture mapPreview; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5D9FDD0 Offset: 0xD48DD0 VA: 0x6CF5D9FDD0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static ShareResultCallback <>9__67_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF5D9FDD8 Offset: 0xD48DD8 VA: 0x6CF5D9FDD8
	private static void .cctor() { }

	// RVA: 0x6CF5D9FE34 Offset: 0xD48E34 VA: 0x6CF5D9FE34
	public void .ctor() { }

	// RVA: 0x6CF5D9FE3C Offset: 0xD48E3C VA: 0x6CF5D9FE3C
	internal void <ShareScreenshot>b__67_0(ShareResult result, string shareTarget) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <JoinCreateRoom>d__86 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ConnectMenu <>4__this; // 0x20
	public string newMapName; // 0x28
	public string newGameMode; // 0x30
	public string newSpecMode; // 0x38
	public float roundDuration; // 0x40
	public int newKillLimit; // 0x44
	public int newMaxPlayers; // 0x48
	public string newRoomName; // 0x50

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D9DC84 Offset: 0xD46C84 VA: 0x6CF5D9DC84
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5D9FF30 Offset: 0xD48F30 VA: 0x6CF5D9FF30
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5D9FF34 Offset: 0xD48F34 VA: 0x6CF5D9FF34
	private bool MoveNext() { }

	// RVA: 0x6CF5DA0444 Offset: 0xD49444 VA: 0x6CF5DA0444
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DA044C Offset: 0xD4944C VA: 0x6CF5DA044C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DA0484 Offset: 0xD49484 VA: 0x6CF5DA0484
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <RefreshRooms>d__85 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ConnectMenu <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D9DC5C Offset: 0xD46C5C VA: 0x6CF5D9DC5C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DA048C Offset: 0xD4948C VA: 0x6CF5DA048C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DA0490 Offset: 0xD49490 VA: 0x6CF5DA0490
	private bool MoveNext() { }

	// RVA: 0x6CF5DA0708 Offset: 0xD49708 VA: 0x6CF5DA0708
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DA0710 Offset: 0xD49710 VA: 0x6CF5DA0710
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DA0748 Offset: 0xD49748 VA: 0x6CF5DA0748
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ShareScreenshot>d__67 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5D95974 Offset: 0xD3E974 VA: 0x6CF5D95974
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DA0750 Offset: 0xD49750 VA: 0x6CF5DA0750
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DA0754 Offset: 0xD49754 VA: 0x6CF5DA0754
	private bool MoveNext() { }

	// RVA: 0x6CF5DA0AC4 Offset: 0xD49AC4 VA: 0x6CF5DA0AC4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DA0ACC Offset: 0xD49ACC VA: 0x6CF5DA0ACC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DA0B04 Offset: 0xD49B04 VA: 0x6CF5DA0B04
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ConnectMenu : MonoBehaviour
{
	// Fields

	public GUISkin guiSKin; // 0x28
	public CurrentWindow currentWindow; // 0x30
	public GameObject roomControllerPrefab; // 0x38
	public GameObject GrenadeSpotPrefab; // 0x40
	public Texture2D background; // 0x48
	public Texture2D defaultMapPreview; // 0x50
	public AudioClip ClickSong; // 0x58
	private AudioSource thisAudioSource; // 0x60
	public AudioSource MainThemeOnly; // 0x68
	public AvailableMaps[] availableMaps; // 0x70
	private Vector2 browseWindowSize; // 0x78
	private Vector2 roomBrowserScroll; // 0x80
	private CloudRegionCode selectedRegion; // 0x88
	private int totalPlayers; // 0x8C
	private int totalRooms; // 0x90
	private string networkVersion; // 0x98
	private bool createRoom; // 0xA0
	private string roomName; // 0xA8
	private Int32[] playerLimits; // 0xB0
	private String[] gameModes; // 0xB8
	private String[] specRoom; // 0xC0
	private String[] languagesName; // 0xC8
	public String[] fromName; // 0xD0
	private Int32[] roundDurations; // 0xD8
	private Int32[] killLimits; // 0xE0
	private int selectedPlayerLimit; // 0xE8
	private int selectedGameMode; // 0xEC
	private int selectedSpecRoom; // 0xF0
	private int selectedLanguages; // 0xF4
	public int selectedFrom; // 0xF8
	private int selectedMap; // 0xFC
	private int selectedKillLimit; // 0x100
	private int startMoney; // 0x104
	public GameObject menutasarim; // 0x108
	private bool loadingMap; // 0x110
	private bool refreshingRooms; // 0x111
	private int roomFieldCurrentlyHovering; // 0x114
	private int selectedRoom; // 0x118
	private int currentPing; // 0x11C
	private RoomInfo[] availableRooms; // 0x120
	private string playerName; // 0x128
	public string tmpPlayerName; // 0x130
	private string tmpRoomName; // 0x138
	private OptionsSettings os; // 0x140
	private string playerNamePrefsName; // 0x148
	private string playerNameJoinPrefsName; // 0x150
	private string playerLimitPrefsName; // 0x158
	private string gameModePrefsName; // 0x160
	private string specRoomPrefsName; // 0x168
	private string languagesPrefsName; // 0x170
	private string fromPrefsName; // 0x178
	private string selectedMapPrefsName; // 0x180
	private string startMoneyPrefsName; // 0x188
	public xmlReader xml; // 0x190
	private bool yoketobje; // 0x198
	private GUIStyle guiStyleCredit; // 0x1A0
	private string RoomWhatis; // 0x1A8
	private string RoomNameWhatis; // 0x1B0

	// Properties


	// Methods

	// RVA: 0x6CF5D95474 Offset: 0xD3E474 VA: 0x6CF5D95474
	public void Roomlist() { }

	// RVA: 0x6CF5D95564 Offset: 0xD3E564 VA: 0x6CF5D95564
	private void Awake() { }

	// RVA: 0x6CF5D9564C Offset: 0xD3E64C VA: 0x6CF5D9564C
	public void CaseSimulator() { }

	// RVA: 0x6CF5D956A0 Offset: 0xD3E6A0 VA: 0x6CF5D956A0
	public void WeaponWorkshop() { }

	// RVA: 0x6CF5D956F4 Offset: 0xD3E6F4 VA: 0x6CF5D956F4
	public void Profile() { }

	// RVA: 0x6CF5D9574C Offset: 0xD3E74C VA: 0x6CF5D9574C
	public void GameOptions() { }

	// RVA: 0x6CF5D9578C Offset: 0xD3E78C VA: 0x6CF5D9578C
	public void Discord() { }

	// RVA: 0x6CF5D957F4 Offset: 0xD3E7F4 VA: 0x6CF5D957F4
	public void InviteFriends() { }

	// RVA: 0x6CF5D9586C Offset: 0xD3E86C VA: 0x6CF5D9586C
	public void FacebookButton() { }

	// RVA: 0x6CF5D958F0 Offset: 0xD3E8F0 VA: 0x6CF5D958F0
	public void TwitterButton() { }

	// RVA: 0x6CF5D95814 Offset: 0xD3E814 VA: 0x6CF5D95814
	public IEnumerator ShareScreenshot() { }

	// RVA: 0x6CF5D9599C Offset: 0xD3E99C VA: 0x6CF5D9599C
	private void Start() { }

	// RVA: 0x6CF5D95F84 Offset: 0xD3EF84 VA: 0x6CF5D95F84
	private void Update() { }

	// RVA: 0x6CF5D96158 Offset: 0xD3F158 VA: 0x6CF5D96158
	private void SearchRoomFinder() { }

	// RVA: 0x6CF5D96710 Offset: 0xD3F710 VA: 0x6CF5D96710
	private void RoomNameCConnect() { }

	// RVA: 0x6CF5D96C5C Offset: 0xD3FC5C VA: 0x6CF5D96C5C
	private void OnGUI() { }

	// RVA: 0x6CF5D97A3C Offset: 0xD40A3C VA: 0x6CF5D97A3C
	private void ProfileWindow(int windowID) { }

	// RVA: 0x6CF5D98428 Offset: 0xD41428 VA: 0x6CF5D98428
	private void CreditControl(int windowID) { }

	// RVA: 0x6CF5D985E8 Offset: 0xD415E8 VA: 0x6CF5D985E8
	private void InformationControl(int windowID) { }

	// RVA: 0x6CF5D98910 Offset: 0xD41910 VA: 0x6CF5D98910
	private void SearchRoomNo(int windowID) { }

	// RVA: 0x6CF5D98C34 Offset: 0xD41C34 VA: 0x6CF5D98C34
	private void SearchFindingRoomName(int windowID) { }

	// RVA: 0x6CF5D98E98 Offset: 0xD41E98 VA: 0x6CF5D98E98
	private void SearchRoomNow(int windowID) { }

	// RVA: 0x6CF5D990FC Offset: 0xD420FC VA: 0x6CF5D990FC
	private void RoomNameWhat(int windowID) { }

	// RVA: 0x6CF5D9942C Offset: 0xD4242C VA: 0x6CF5D9942C
	private void BrowseRoomsWins(int windowID) { }

	// RVA: 0x6CF5D9B768 Offset: 0xD44768 VA: 0x6CF5D9B768
	private void BrowseRoomsWindow(int windowID) { }

	// RVA: 0x6CF5D95504 Offset: 0xD3E504 VA: 0x6CF5D95504
	private IEnumerator RefreshRooms() { }

	// RVA: 0x6CF5D96664 Offset: 0xD3F664 VA: 0x6CF5D96664
	private IEnumerator JoinCreateRoom(string newRoomName, string newMapName, int newMaxPlayers, string newGameMode, string newSpecMode, float roundDuration, int newKillLimit) { }

	// RVA: 0x6CF5D9DCAC Offset: 0xD46CAC VA: 0x6CF5D9DCAC
	private void OnJoinedRoom() { }

	// RVA: 0x6CF5D9DDC4 Offset: 0xD46DC4 VA: 0x6CF5D9DDC4
	private void OnPhotonCreateGameFailed() { }

	// RVA: 0x6CF5D9DE38 Offset: 0xD46E38 VA: 0x6CF5D9DE38
	private void OnPhotonJoinRoomFailed() { }

	// RVA: 0x6CF5D9DEAC Offset: 0xD46EAC VA: 0x6CF5D9DEAC
	private void OnFailedToConnectToPhoton() { }

	// RVA: 0x6CF5D9DF20 Offset: 0xD46F20 VA: 0x6CF5D9DF20
	private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadMode) { }

	// RVA: 0x6CF5D9F6E8 Offset: 0xD486E8 VA: 0x6CF5D9F6E8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class GrenadeOpen : MonoBehaviour
{
	// Fields

	public bool upGrenade; // 0x20
	public GameObject GrenadeDownMe; // 0x28
	private float timeLeftShow; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5DA0B0C Offset: 0xD49B0C VA: 0x6CF5DA0B0C
	private void FixedUpdate() { }

	// RVA: 0x6CF5DA0B70 Offset: 0xD49B70 VA: 0x6CF5DA0B70
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class GrenadeSpot : MonoBehaviour
{
	// Fields

	public GrenadeOpen go; // 0x20
	public GameObject sgr; // 0x28
	public RoomController rc; // 0x30
	public Transform thisT; // 0x38
	private float distanceToBuyLimit; // 0x40
	private float distance; // 0x44
	private bool isInside; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5DA0B88 Offset: 0xD49B88 VA: 0x6CF5DA0B88
	private void Start() { }

	// RVA: 0x6CF5DA0BA8 Offset: 0xD49BA8 VA: 0x6CF5DA0BA8
	private void FixedUpdate() { }

	// RVA: 0x6CF5DA0ED0 Offset: 0xD49ED0 VA: 0x6CF5DA0ED0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ChatState
{
	// Fields

	public int value__; // 0x10
	public const ChatState None = 0; // 0x0
	public const ChatState Public = 1; // 0x0
	public const ChatState Team = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class Message : Object
{
	// Fields

	public string senderName; // 0x10
	public Color senderTeamColor; // 0x18
	public string text; // 0x28
	public string isTeamChat; // 0x30
	public float timer; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5DB4F7C Offset: 0xD5DF7C VA: 0x6CF5DB4F7C
	public void .ctor(string sn, Color stc, string txt, string itc, float t) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ClearChat>d__54 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MultiplayerChat <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB4FF0 Offset: 0xD5DFF0 VA: 0x6CF5DB4FF0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DB5018 Offset: 0xD5E018 VA: 0x6CF5DB5018
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DB501C Offset: 0xD5E01C VA: 0x6CF5DB501C
	private bool MoveNext() { }

	// RVA: 0x6CF5DB5108 Offset: 0xD5E108 VA: 0x6CF5DB5108
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DB5110 Offset: 0xD5E110 VA: 0x6CF5DB5110
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DB5148 Offset: 0xD5E148 VA: 0x6CF5DB5148
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class MultiplayerChat : MonoBehaviour
{
	// Fields

	public ChatState chatState; // 0x28
	public List`1 messages; // 0x30
	private string chatLabel; // 0x38
	private string chatInput; // 0x40
	private float chatLabelWidth; // 0x48
	public Texture2D CounterText; // 0x50
	public Texture2D TerorText; // 0x58
	public Texture2D AK47; // 0x60
	public Texture2D AUG; // 0x68
	public Texture2D AWP; // 0x70
	public Texture2D DEAGLE; // 0x78
	public Texture2D ELITE; // 0x80
	public Texture2D FAMAS; // 0x88
	public Texture2D FIVESEVEN; // 0x90
	public Texture2D GRENADE; // 0x98
	public Texture2D KNIFE; // 0xA0
	public Texture2D M3; // 0xA8
	public Texture2D M4A1; // 0xB0
	public Texture2D M249; // 0xB8
	public Texture2D MAC10; // 0xC0
	public Texture2D MP5; // 0xC8
	public Texture2D P90; // 0xD0
	public Texture2D P228; // 0xD8
	public Texture2D SCOUT; // 0xE0
	public Texture2D SG550; // 0xE8
	public Texture2D SG552; // 0xF0
	public Texture2D USP; // 0xF8
	public Texture2D XM1014; // 0x100
	public Texture2D HeadShot; // 0x108
	public Texture2D Pause; // 0x110
	public Texture2D Radar; // 0x118
	public Texture2D C4; // 0x120
	public Texture2D SK; // 0x128
	private RoomController rc; // 0x130
	private RoomUI ru; // 0x138
	private xmlReader xml; // 0x140
	private string languagesPrefsName; // 0x148
	private TouchScreenKeyboard keyboard; // 0x150
	private float time; // 0x158
	private float time2; // 0x15C
	private float time3; // 0x160
	private float time4; // 0x164
	private float time5; // 0x168
	private bool time2W; // 0x16C
	public int CameraFollow; // 0x170
	private int diffuseBas; // 0x174
	private GUIStyle guiStyle; // 0x178

	// Properties


	// Methods

	// RVA: 0x6CF5DA0EE4 Offset: 0xD49EE4 VA: 0x6CF5DA0EE4
	private void Start() { }

	// RVA: 0x6CF5DA0FE0 Offset: 0xD49FE0 VA: 0x6CF5DA0FE0
	private void Update() { }

	// RVA: 0x6CF5DA1128 Offset: 0xD4A128 VA: 0x6CF5DA1128
	private void OnGUI() { }

	// RVA: 0x6CF5DA6A04 Offset: 0xD4FA04 VA: 0x6CF5DA6A04
	private void SendChat(string ourName, string text, int team, bool isTeamChat) { }

	// RVA: 0x6CF5DA6C0C Offset: 0xD4FC0C VA: 0x6CF5DA6C0C
	private void SendChatRemote(string senderName, string text, int senderTeam, bool isTeamChat) { }

	// RVA: 0x6CF5DA699C Offset: 0xD4F99C VA: 0x6CF5DA699C
	private IEnumerator ClearChat() { }

	// RVA: 0x6CF5DA6ED8 Offset: 0xD4FED8 VA: 0x6CF5DA6ED8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OptionsSettings : MonoBehaviour
{
	// Fields

	private Resolution[] screenReolsutions; // 0x20
	private String[] availableQualities; // 0x28
	private float mouseSensitivity; // 0x30
	private int selectedResolution; // 0x34
	private int selectedQuality; // 0x38
	private string qualityPrefsName; // 0x40
	private string mouseSensitivityPrefsName; // 0x48
	public ConnectMenu cm; // 0x50
	public RoomController rc; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF5DB5150 Offset: 0xD5E150 VA: 0x6CF5DB5150
	private void Start() { }

	// RVA: 0x6CF5DB5280 Offset: 0xD5E280 VA: 0x6CF5DB5280
	private void OnGUI() { }

	// RVA: 0x6CF5DB53E4 Offset: 0xD5E3E4 VA: 0x6CF5DB53E4
	private void OptionsWindow(int windowID) { }

	// RVA: 0x6CF5DB5EF0 Offset: 0xD5EEF0 VA: 0x6CF5DB5EF0
	public void SetFullscreen() { }

	// RVA: 0x6CF5DB5F8C Offset: 0xD5EF8C VA: 0x6CF5DB5F8C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ActionReport : Object
{
	// Fields

	public string leftText; // 0x10
	public string middleText; // 0x18
	public string rightText; // 0x20
	public Color leftTextColor; // 0x28
	public Color rightTextColor; // 0x38
	public float timer; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5DBBA9C Offset: 0xD64A9C VA: 0x6CF5DBBA9C
	public void .ctor(string lt, string mt, string rt, Color ltc, Color rtc, float t) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <AddCashDelayed>d__143 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBB86C Offset: 0xD6486C VA: 0x6CF5DBB86C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBCCA4 Offset: 0xD65CA4 VA: 0x6CF5DBCCA4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBCCA8 Offset: 0xD65CA8 VA: 0x6CF5DBCCA8
	private bool MoveNext() { }

	// RVA: 0x6CF5DBCD4C Offset: 0xD65D4C VA: 0x6CF5DBCD4C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBCD54 Offset: 0xD65D54 VA: 0x6CF5DBCD54
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBCD8C Offset: 0xD65D8C VA: 0x6CF5DBCD8C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <AddKIllCashCoroutine>d__154 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBC8D0 Offset: 0xD658D0 VA: 0x6CF5DBC8D0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBCD94 Offset: 0xD65D94 VA: 0x6CF5DBCD94
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBCD98 Offset: 0xD65D98 VA: 0x6CF5DBCD98
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD0C0 Offset: 0xD660C0 VA: 0x6CF5DBD0C0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD0C8 Offset: 0xD660C8 VA: 0x6CF5DBD0C8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD100 Offset: 0xD66100 VA: 0x6CF5DBD100
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <CashZero>d__130 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB8D3C Offset: 0xD61D3C VA: 0x6CF5DB8D3C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD108 Offset: 0xD66108 VA: 0x6CF5DBD108
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD10C Offset: 0xD6610C VA: 0x6CF5DBD10C
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD1F8 Offset: 0xD661F8 VA: 0x6CF5DBD1F8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD200 Offset: 0xD66200 VA: 0x6CF5DBD200
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD238 Offset: 0xD66238 VA: 0x6CF5DBD238
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DoHitDetectorCoroutine>d__149 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBBEFC Offset: 0xD64EFC VA: 0x6CF5DBBEFC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD240 Offset: 0xD66240 VA: 0x6CF5DBD240
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD244 Offset: 0xD66244 VA: 0x6CF5DBD244
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD3D0 Offset: 0xD663D0 VA: 0x6CF5DBD3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD3D8 Offset: 0xD663D8 VA: 0x6CF5DBD3D8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD410 Offset: 0xD66410 VA: 0x6CF5DBD410
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <PrepareRespawnCoroutine>d__133 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB971C Offset: 0xD6271C VA: 0x6CF5DB971C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD418 Offset: 0xD66418 VA: 0x6CF5DBD418
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD41C Offset: 0xD6641C VA: 0x6CF5DBD41C
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD574 Offset: 0xD66574 VA: 0x6CF5DBD574
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD57C Offset: 0xD6657C VA: 0x6CF5DBD57C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD5B4 Offset: 0xD665B4 VA: 0x6CF5DBD5B4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <PurchaseTimer>d__135 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB9FD0 Offset: 0xD62FD0 VA: 0x6CF5DB9FD0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD5BC Offset: 0xD665BC VA: 0x6CF5DBD5BC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD5C0 Offset: 0xD665C0 VA: 0x6CF5DBD5C0
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD67C Offset: 0xD6667C VA: 0x6CF5DBD67C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD684 Offset: 0xD66684 VA: 0x6CF5DBD684
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD6BC Offset: 0xD666BC VA: 0x6CF5DBD6BC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ResetPlayersKillsDeaths>d__142 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBB844 Offset: 0xD64844 VA: 0x6CF5DBB844
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD6C4 Offset: 0xD666C4 VA: 0x6CF5DBD6C4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD6C8 Offset: 0xD666C8 VA: 0x6CF5DBD6C8
	private bool MoveNext() { }

	// RVA: 0x6CF5DBD894 Offset: 0xD66894 VA: 0x6CF5DBD894
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBD89C Offset: 0xD6689C VA: 0x6CF5DBD89C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBD8D4 Offset: 0xD668D4 VA: 0x6CF5DBD8D4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <Restart>d__131 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public RoomController <>4__this; // 0x28
	public int Who; // 0x30
	private Hashtable <setRoomProperties>5__2; // 0x38

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB8D64 Offset: 0xD61D64 VA: 0x6CF5DB8D64
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBD8DC Offset: 0xD668DC VA: 0x6CF5DBD8DC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBD8E0 Offset: 0xD668E0 VA: 0x6CF5DBD8E0
	private bool MoveNext() { }

	// RVA: 0x6CF5DBDF40 Offset: 0xD66F40 VA: 0x6CF5DBDF40
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBDF48 Offset: 0xD66F48 VA: 0x6CF5DBDF48
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBDF80 Offset: 0xD66F80 VA: 0x6CF5DBDF80
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ShieldTimer>d__136 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBA058 Offset: 0xD63058 VA: 0x6CF5DBA058
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBDF88 Offset: 0xD66F88 VA: 0x6CF5DBDF88
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBDF8C Offset: 0xD66F8C VA: 0x6CF5DBDF8C
	private bool MoveNext() { }

	// RVA: 0x6CF5DBE048 Offset: 0xD67048 VA: 0x6CF5DBE048
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBE050 Offset: 0xD67050 VA: 0x6CF5DBE050
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBE088 Offset: 0xD67088 VA: 0x6CF5DBE088
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <Start>d__120 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DB6374 Offset: 0xD5F374 VA: 0x6CF5DB6374
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBE090 Offset: 0xD67090 VA: 0x6CF5DBE090
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBE094 Offset: 0xD67094 VA: 0x6CF5DBE094
	private bool MoveNext() { }

	// RVA: 0x6CF5DBEF80 Offset: 0xD67F80 VA: 0x6CF5DBEF80
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBEF88 Offset: 0xD67F88 VA: 0x6CF5DBEF88
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBEFC0 Offset: 0xD67FC0 VA: 0x6CF5DBEFC0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RoomController : MonoBehaviour
{
	// Fields

	public GameObject playerPrefab; // 0x28
	public Camera welcomeCamera; // 0x30
	public AudioClip buySound; // 0x38
	public AudioClip cashRegisterSound; // 0x40
	public AudioClip ctWin; // 0x48
	public AudioClip tWin; // 0x50
	public AudioClip headShot; // 0x58
	public AudioClip killingSpree; // 0x60
	public AudioClip DoubleKill; // 0x68
	public AudioClip Hattrick; // 0x70
	public AudioClip Unstoppable; // 0x78
	public AudioClip MonsterKill; // 0x80
	public AudioClip MegaKill; // 0x88
	public AudioClip UltraKill; // 0x90
	public AudioClip GodLike; // 0x98
	public AudioClip KillNormalDie; // 0xA0
	public AudioClip bombDisarm; // 0xA8
	public AudioClip Diffuse; // 0xB0
	public AudioClip DiffuseTake; // 0xB8
	public List`1 teamASpawnPoints; // 0xC0
	public List`1 teamBSpawnPoints; // 0xC8
	public List`1 teamANormalPoints; // 0xD0
	public List`1 teamBNormalPoints; // 0xD8
	public List`1 teamAPlayers; // 0xE0
	public List`1 teamBPlayers; // 0xE8
	public string spectatorNames; // 0xF0
	public List`1 FollowCam; // 0xF8
	public bool showScoreBoard; // 0x100
	public bool eneteredGrenadeSpot; // 0x101
	public bool leavingRoom; // 0x102
	public bool showFPS; // 0x103
	public bool showBuyMenu; // 0x104
	public bool showOptions; // 0x105
	public bool StartFollow; // 0x106
	public bool FollowCamera; // 0x107
	public bool C4Tag; // 0x108
	public bool DiffuseTag; // 0x109
	public bool DiffuseCreateUI; // 0x10A
	public bool C4XTag; // 0x10B
	public bool SwitchTeam; // 0x10C
	public bool CashOn; // 0x10D
	public PlayerNetwork ourPlayer; // 0x110
	public List`1 otherPlayers; // 0x118
	private Transform welcomeCameraTransform; // 0x120
	private Vector3 defaultCamPos; // 0x128
	private Quaternion defaultCamRot; // 0x134
	public float distance; // 0x144
	public float redScreenFade; // 0x148
	public float hitTopFade; // 0x14C
	public float hitBottomFade; // 0x150
	public float hitLeftFade; // 0x154
	public float hitRightFade; // 0x158
	public bool doingHitDetector; // 0x15C
	private float updateInterval; // 0x160
	private float accum; // 0x164
	private int frames; // 0x168
	private float timeleft; // 0x16C
	private float roundDuration; // 0x170
	private float referenceTime; // 0x174
	private string C4WHO; // 0x178
	private int howPlayer; // 0x180
	public float currentRoundTime; // 0x184
	private float seconds; // 0x188
	private float minutes; // 0x18C
	private string languagesPrefsName; // 0x190
	private string playerNameJoinPrefsName; // 0x198
	public string roundTimeString; // 0x1A0
	public int teamAScore; // 0x1A8
	public int teamANormalScore; // 0x1AC
	public int teamBNormalScore; // 0x1B0
	public int teamBScore; // 0x1B4
	public int ourTeam; // 0x1B8
	public int meTeam; // 0x1BC
	public string currentGameMode; // 0x1C0
	public int currentRespawnTime; // 0x1C8
	public int currentGameStatus; // 0x1CC
	public int currentKillLimit; // 0x1D0
	public PhotonPlayer winningPlayer; // 0x1D8
	public int totalCash; // 0x1E0
	public int currentHP; // 0x1E4
	public string scoreToAddTmp; // 0x1E8
	public string KilledAddTmp; // 0x1F0
	public Color currentAddingCashColor; // 0x1F8
	public Color currentKilledColor; // 0x208
	public Color currentKilledOutColor; // 0x218
	public Color currentTotalCashColor; // 0x228
	private int previousGameStatus; // 0x238
	private bool doneSetup; // 0x23C
	private int waitBeforeRespawn; // 0x240
	private Color addingColor; // 0x244
	private Color substractingColor; // 0x254
	private Color KillingSpreeColor; // 0x264
	private Color HeadShotOut; // 0x274
	private Color addingColorFadeTo; // 0x284
	private Color addingColorKillTo; // 0x294
	private bool addingKillCash; // 0x2A4
	private int lockState; // 0x2A8
	private int myheadshots; // 0x2AC
	public List`1 actionReports; // 0x2B0
	public List`1 actionWeaponsReports; // 0x2B8
	public MultiplayerChat mc; // 0x2C0
	public OptionsSettings os; // 0x2C8
	private FPSMouseLook cameraMouseLook; // 0x2D0
	private Scoreboard sb; // 0x2D8
	private BuyMenu bm; // 0x2E0
	private MultiplayerChat mtp; // 0x2E8
	private RoomUI ru; // 0x2F0
	public AudioSource audioSource; // 0x2F8
	public xmlReader xml; // 0x300
	public AudioSource ZeroStrikeX; // 0x308
	public int timeToPurchase; // 0x310
	public int timeToShield; // 0x314
	public int SoundBas; // 0x318
	private string startMoneyPrefsName; // 0x320
	public GameObject Menuyoket; // 0x328

	// Properties


	// Methods

	// RVA: 0x6CF5DB604C Offset: 0xD5F04C VA: 0x6CF5DB604C
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x6CF5DB614C Offset: 0xD5F14C VA: 0x6CF5DB614C
	public void ChangeMasterClientifAvailble() { }

	// RVA: 0x6CF5DB6208 Offset: 0xD5F208 VA: 0x6CF5DB6208
	public virtual void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5DB620C Offset: 0xD5F20C VA: 0x6CF5DB620C
	private static int SortPlayers(PhotonPlayer A, PhotonPlayer B) { }

	// RVA: 0x6CF5DB6314 Offset: 0xD5F314 VA: 0x6CF5DB6314
	private IEnumerator Start() { }

	// RVA: 0x6CF5DB639C Offset: 0xD5F39C VA: 0x6CF5DB639C
	private void GetTeamScores() { }

	// RVA: 0x6CF5DB65C8 Offset: 0xD5F5C8 VA: 0x6CF5DB65C8
	private void RefreshPlayerList() { }

	// RVA: 0x6CF5DB6A4C Offset: 0xD5FA4C VA: 0x6CF5DB6A4C
	private void RefreshPing() { }

	// RVA: 0x6CF5DB6B5C Offset: 0xD5FB5C VA: 0x6CF5DB6B5C
	private void ResetGameStatus(int statusIndex, PhotonPlayer wp) { }

	// RVA: 0x6CF5DB6E28 Offset: 0xD5FE28 VA: 0x6CF5DB6E28
	private void Update() { }

	// RVA: 0x6CF5DB7140 Offset: 0xD60140 VA: 0x6CF5DB7140
	public void ShowScoreboard() { }

	// RVA: 0x6CF5DB715C Offset: 0xD6015C VA: 0x6CF5DB715C
	public void OpenBuyMenu() { }

	// RVA: 0x6CF5DB71F4 Offset: 0xD601F4 VA: 0x6CF5DB71F4
	private void LockCursor(bool lockCursor) { }

	// RVA: 0x6CF5DB71F8 Offset: 0xD601F8 VA: 0x6CF5DB71F8
	private void FixedUpdate() { }

	// RVA: 0x6CF5DB8C7C Offset: 0xD61C7C VA: 0x6CF5DB8C7C
	private IEnumerator CashZero() { }

	// RVA: 0x6CF5DB8BFC Offset: 0xD61BFC VA: 0x6CF5DB8BFC
	private IEnumerator Restart(int Who, float delay) { }

	// RVA: 0x6CF5DB8D8C Offset: 0xD61D8C VA: 0x6CF5DB8D8C
	public void PrepareRespawn(int team, bool wasSwitched, bool ResetOn) { }

	// RVA: 0x6CF5DB96BC Offset: 0xD626BC VA: 0x6CF5DB96BC
	private IEnumerator PrepareRespawnCoroutine() { }

	// RVA: 0x6CF5DB9744 Offset: 0xD62744 VA: 0x6CF5DB9744
	public void SpawnPlayer(int team) { }

	// RVA: 0x6CF5DB9F70 Offset: 0xD62F70 VA: 0x6CF5DB9F70
	private IEnumerator PurchaseTimer() { }

	// RVA: 0x6CF5DB9FF8 Offset: 0xD62FF8 VA: 0x6CF5DB9FF8
	private IEnumerator ShieldTimer() { }

	// RVA: 0x6CF5DBA080 Offset: 0xD63080 VA: 0x6CF5DBA080
	private void OnLeftRoom() { }

	// RVA: 0x6CF5DBA0D4 Offset: 0xD630D4 VA: 0x6CF5DBA0D4
	private void OnPhotonPlayerPropertiesChanged() { }

	// RVA: 0x6CF5DBA33C Offset: 0xD6333C VA: 0x6CF5DBA33C
	private void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5DBA688 Offset: 0xD63688 VA: 0x6CF5DBA688
	private void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5DBA714 Offset: 0xD63714 VA: 0x6CF5DBA714
	private void OnPhotonCustomRoomPropertiesChanged() { }

	// RVA: 0x6CF5DBB7EC Offset: 0xD647EC VA: 0x6CF5DBB7EC
	private IEnumerator ResetPlayersKillsDeaths() { }

	// RVA: 0x6CF5DBB78C Offset: 0xD6478C VA: 0x6CF5DBB78C
	private IEnumerator AddCashDelayed() { }

	// RVA: 0x6CF5DB9434 Offset: 0xD62434 VA: 0x6CF5DB9434
	private void JoinedTeam(int team) { }

	// RVA: 0x6CF5DBB894 Offset: 0xD64894 VA: 0x6CF5DBB894
	public void ReportKill(string killedName, string weaponName, int killedTeam) { }

	// RVA: 0x6CF5DBA3C0 Offset: 0xD633C0 VA: 0x6CF5DBA3C0
	private void PostActivityRemote(string leftText, string middleText, string rightText, int leftColorRef, int rightColorRef) { }

	// RVA: 0x6CF5DBBB34 Offset: 0xD64B34 VA: 0x6CF5DBBB34
	private void PostActivityRemoteWeapons(string leftText, string middleText, string rightText, int leftColorRef, int rightColorRef) { }

	// RVA: 0x6CF5DBBDFC Offset: 0xD64DFC VA: 0x6CF5DBBDFC
	public void DoHitDetector(int direction) { }

	// RVA: 0x6CF5DBBE9C Offset: 0xD64E9C VA: 0x6CF5DBBE9C
	private IEnumerator DoHitDetectorCoroutine() { }

	// RVA: 0x6CF5DBBF24 Offset: 0xD64F24 VA: 0x6CF5DBBF24
	public void AddKillCash(int bodyPart) { }

	// RVA: 0x6CF5DBC5D4 Offset: 0xD655D4 VA: 0x6CF5DBC5D4
	private void LoginScore() { }

	// RVA: 0x6CF5DBC6DC Offset: 0xD656DC VA: 0x6CF5DBC6DC
	public void SubstractCash(int type) { }

	// RVA: 0x6CF5DBC86C Offset: 0xD6586C VA: 0x6CF5DBC86C
	public int GetCash() { }

	// RVA: 0x6CF5DB8CDC Offset: 0xD61CDC VA: 0x6CF5DB8CDC
	private IEnumerator AddKIllCashCoroutine() { }

	// RVA: 0x6CF5DBC8F8 Offset: 0xD658F8 VA: 0x6CF5DBC8F8
	public void .ctor() { }

	// RVA: 0x6CF5DBCC04 Offset: 0xD65C04 VA: 0x6CF5DBCC04
	private void <LoginScore>b__151_0(bool success) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ActionReports : Object
{
	// Fields

	public Text mainText; // 0x10
	public Text textShadow; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5DBEFC8 Offset: 0xD67FC8 VA: 0x6CF5DBEFC8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class TouchMovements : Object
{
	// Fields

	public Image backgroundCircle; // 0x10
	public Image mainButton; // 0x18
	public Rect defaultArea; // 0x20
	public Vector2 touchOffset; // 0x30
	public Vector2 currentTouchPos; // 0x38
	public int touchID; // 0x40
	public bool isActive; // 0x44

	// Properties


	// Methods

	// RVA: 0x6CF5DBEFD0 Offset: 0xD67FD0 VA: 0x6CF5DBEFD0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ActionButton : Object
{
	// Fields

	public Image background; // 0x10
	public Image icon; // 0x18
	public Rect mainArea; // 0x20
	public bool isActive; // 0x30
	public int touchID; // 0x34

	// Properties


	// Methods

	// RVA: 0x6CF5DBEFD8 Offset: 0xD67FD8 VA: 0x6CF5DBEFD8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <C4Color>d__102 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBEFE0 Offset: 0xD67FE0 VA: 0x6CF5DBEFE0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF008 Offset: 0xD68008 VA: 0x6CF5DBF008
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF00C Offset: 0xD6800C VA: 0x6CF5DBF00C
	private bool MoveNext() { }

	// RVA: 0x6CF5DBF164 Offset: 0xD68164 VA: 0x6CF5DBF164
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBF16C Offset: 0xD6816C VA: 0x6CF5DBF16C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBF1A4 Offset: 0xD681A4 VA: 0x6CF5DBF1A4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DiffuseColor>d__103 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBF1AC Offset: 0xD681AC VA: 0x6CF5DBF1AC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF1D4 Offset: 0xD681D4 VA: 0x6CF5DBF1D4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF1D8 Offset: 0xD681D8 VA: 0x6CF5DBF1D8
	private bool MoveNext() { }

	// RVA: 0x6CF5DBF330 Offset: 0xD68330 VA: 0x6CF5DBF330
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBF338 Offset: 0xD68338 VA: 0x6CF5DBF338
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBF370 Offset: 0xD68370 VA: 0x6CF5DBF370
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff05>d__100 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBF378 Offset: 0xD68378 VA: 0x6CF5DBF378
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF3A0 Offset: 0xD683A0 VA: 0x6CF5DBF3A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF3A4 Offset: 0xD683A4 VA: 0x6CF5DBF3A4
	private bool MoveNext() { }

	// RVA: 0x6CF5DBF4EC Offset: 0xD684EC VA: 0x6CF5DBF4EC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBF4F4 Offset: 0xD684F4 VA: 0x6CF5DBF4F4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBF52C Offset: 0xD6852C VA: 0x6CF5DBF52C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff0>d__101 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBF534 Offset: 0xD68534 VA: 0x6CF5DBF534
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF55C Offset: 0xD6855C VA: 0x6CF5DBF55C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF560 Offset: 0xD68560 VA: 0x6CF5DBF560
	private bool MoveNext() { }

	// RVA: 0x6CF5DBF6A8 Offset: 0xD686A8 VA: 0x6CF5DBF6A8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBF6B0 Offset: 0xD686B0 VA: 0x6CF5DBF6B0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBF6E8 Offset: 0xD686E8 VA: 0x6CF5DBF6E8
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff10>d__99 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBF6F0 Offset: 0xD686F0 VA: 0x6CF5DBF6F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF718 Offset: 0xD68718 VA: 0x6CF5DBF718
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF71C Offset: 0xD6871C VA: 0x6CF5DBF71C
	private bool MoveNext() { }

	// RVA: 0x6CF5DBF864 Offset: 0xD68864 VA: 0x6CF5DBF864
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBF86C Offset: 0xD6886C VA: 0x6CF5DBF86C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBF8A4 Offset: 0xD688A4 VA: 0x6CF5DBF8A4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff20>d__98 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBF8AC Offset: 0xD688AC VA: 0x6CF5DBF8AC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBF8D4 Offset: 0xD688D4 VA: 0x6CF5DBF8D4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBF8D8 Offset: 0xD688D8 VA: 0x6CF5DBF8D8
	private bool MoveNext() { }

	// RVA: 0x6CF5DBFA1C Offset: 0xD68A1C VA: 0x6CF5DBFA1C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBFA24 Offset: 0xD68A24 VA: 0x6CF5DBFA24
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBFA5C Offset: 0xD68A5C VA: 0x6CF5DBFA5C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff40>d__97 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RoomUI <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DBFA64 Offset: 0xD68A64 VA: 0x6CF5DBFA64
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DBFA8C Offset: 0xD68A8C VA: 0x6CF5DBFA8C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DBFA90 Offset: 0xD68A90 VA: 0x6CF5DBFA90
	private bool MoveNext() { }

	// RVA: 0x6CF5DBFBD4 Offset: 0xD68BD4 VA: 0x6CF5DBFBD4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DBFBDC Offset: 0xD68BDC VA: 0x6CF5DBFBDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DBFC14 Offset: 0xD68C14 VA: 0x6CF5DBFC14
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RoomUI : MonoBehaviour
{
	// Fields

	public Sprite whiteTexture; // 0x20
	public Sprite hitDetectorTexture; // 0x28
	public Sprite hpTexture; // 0x30
	public Sprite buyTexture; // 0x38
	public Sprite bombTexture; // 0x40
	public Sprite timeTexture; // 0x48
	public Sprite shieldTexture; // 0x50
	public Sprite roundTexture; // 0x58
	public Sprite roundFFATexture; // 0x60
	public Sprite roundBombTexture; // 0x68
	public Sprite Bomb; // 0x70
	public Sprite BombBorder; // 0x78
	public Sprite navigationCircle; // 0x80
	public Sprite navigationButton; // 0x88
	public Sprite navigationSke; // 0x90
	public Sprite gunFireIcon; // 0x98
	public Sprite gunReloadIcon; // 0xA0
	public Sprite gunAimIcon; // 0xA8
	public Sprite jumpIcon; // 0xB0
	public Sprite crouchIcon; // 0xB8
	public Sprite switchWeaponIcon; // 0xC0
	public Sprite C4Icon; // 0xC8
	public Sprite C4IconBack; // 0xD0
	public Sprite DiffuseIcon; // 0xD8
	public Sprite GrenadeIcon; // 0xE0
	public Sprite FlashIcon; // 0xE8
	private GameObject crosshairRoot; // 0xF0
	private Image[] crosshairSet; // 0xF8
	private Image redScreen; // 0x100
	private Image canRes; // 0x108
	private Image timeRes; // 0x110
	private Image shieldRes; // 0x118
	private Image shopBuyT; // 0x120
	private Image roundHow; // 0x128
	private Image roundHowFFA; // 0x130
	private Image roundBomb; // 0x138
	private Image roundBombIcon; // 0x140
	private Image BombI; // 0x148
	private Image BombBorderI; // 0x150
	private Image FlashImage; // 0x158
	private CanvasGroup FlashCanvas; // 0x160
	private Image[] hitDetectorSet; // 0x168
	private bool previousHitDetector; // 0x170
	private Canvas mainCanvas; // 0x178
	private Text roundTimeText; // 0x180
	private Text roundCounterText; // 0x188
	private Text roundCounterScoreText; // 0x190
	private Text roundTerorText; // 0x198
	private Text roundTerorScoreText; // 0x1A0
	private Text HPText; // 0x1A8
	private Text cashText; // 0x1B0
	private Text KillText; // 0x1B8
	private Text addMoreCashText; // 0x1C0
	private Text weaponAndAmmoText; // 0x1C8
	private Text killedShowText; // 0x1D0
	private Outline KilledOut; // 0x1D8
	public ActionReports[] actionReports; // 0x1E0
	public ActionReports[] actionWeaponsReports; // 0x1E8
	public ActionReports[] chatMessages; // 0x1F0
	private ActionReports respawnTimeText; // 0x1F8
	private ActionReports buyMenuText; // 0x200
	private ActionReports shieldText; // 0x208
	private Image sniperScope; // 0x210
	private float scopeTextureRatio; // 0x218
	private Sprite scopeTextureTmp; // 0x220
	private TouchMovements moveTouch; // 0x228
	private TouchMovements fpsLookTouch; // 0x230
	private ActionButton fireButton; // 0x238
	private ActionButton reloadButton; // 0x240
	private ActionButton aimButton; // 0x248
	private ActionButton jumpButton; // 0x250
	private ActionButton crouchButton; // 0x258
	private ActionButton c4Button; // 0x260
	private ActionButton DiffuseButton; // 0x268
	private ActionButton GrenadeButton; // 0x270
	private ActionButton FlashButton; // 0x278
	private ActionButton switchWeaponButton; // 0x280
	private Vector2 initialTouchPos; // 0x288
	private float swipeTime; // 0x290
	private float keepRotatingTime; // 0x294
	private float previousTouchDirX; // 0x298
	public float C4Create; // 0x29C
	public float DiffuseCreate; // 0x2A0
	private bool diffuseSound; // 0x2A4
	private RoomController rc; // 0x2A8
	private xmlReader xml; // 0x2B0
	private string languagesPrefsName; // 0x2B8
	private float bombTime; // 0x2C0
	private bool pip1; // 0x2C4
	private bool colorC4; // 0x2C5
	private bool colorDiffuse; // 0x2C6

	// Properties


	// Methods

	// RVA: 0x6CF5DA6FF8 Offset: 0xD4FFF8 VA: 0x6CF5DA6FF8
	private void Start() { }

	// RVA: 0x6CF5DA7114 Offset: 0xD50114 VA: 0x6CF5DA7114
	private void InitializeGUI() { }

	// RVA: 0x6CF5DAFF2C Offset: 0xD58F2C VA: 0x6CF5DAFF2C
	private void Update() { }

	// RVA: 0x6CF5DB366C Offset: 0xD5C66C VA: 0x6CF5DB366C
	private IEnumerator OnOff40() { }

	// RVA: 0x6CF5DB36D4 Offset: 0xD5C6D4 VA: 0x6CF5DB36D4
	private IEnumerator OnOff20() { }

	// RVA: 0x6CF5DB373C Offset: 0xD5C73C VA: 0x6CF5DB373C
	private IEnumerator OnOff10() { }

	// RVA: 0x6CF5DB37A4 Offset: 0xD5C7A4 VA: 0x6CF5DB37A4
	private IEnumerator OnOff05() { }

	// RVA: 0x6CF5DB380C Offset: 0xD5C80C VA: 0x6CF5DB380C
	private IEnumerator OnOff0() { }

	// RVA: 0x6CF5DB359C Offset: 0xD5C59C VA: 0x6CF5DB359C
	private IEnumerator C4Color() { }

	// RVA: 0x6CF5DB3604 Offset: 0xD5C604 VA: 0x6CF5DB3604
	private IEnumerator DiffuseColor() { }

	// RVA: 0x6CF5DB3874 Offset: 0xD5C874 VA: 0x6CF5DB3874
	private void MobileButtonsCheck(Vector2 touchPos, int touchID) { }

	// RVA: 0x6CF5DB4938 Offset: 0xD5D938 VA: 0x6CF5DB4938
	private void MobileButtonStop(int touchID) { }

	// RVA: 0x6CF5DB4D04 Offset: 0xD5DD04 VA: 0x6CF5DB4D04
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum CurrentWindow
{
	// Fields

	public int value__; // 0x10
	public const CurrentWindow LeaveRoom = 0; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Scoreboard : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x28
	private CurrentWindow currentWindow; // 0x34
	public RoomController rc; // 0x38
	private xmlReader xml; // 0x40
	private string languagesPrefsName; // 0x48
	public AudioClip ClickSong; // 0x50
	private AudioSource scoreAudioSource; // 0x58
	public Texture2D background; // 0x60
	private int ShowFirst; // 0x68
	public Texture2D CounterText; // 0x70
	public Texture2D TerorText; // 0x78
	public GUISkin guiSKin; // 0x80
	public ReklamTamEkran reklamcagir1; // 0x88
	private Vector2 scoreBoardScroll; // 0x90
	private GUIStyle guiStyle; // 0x98

	// Properties


	// Methods

	// RVA: 0x6CF5DBFC1C Offset: 0xD68C1C VA: 0x6CF5DBFC1C
	private void Start() { }

	// RVA: 0x6CF5DBFE6C Offset: 0xD68E6C VA: 0x6CF5DBFE6C
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5DBFED0 Offset: 0xD68ED0 VA: 0x6CF5DBFED0
	private void Update() { }

	// RVA: 0x6CF5DBFFAC Offset: 0xD68FAC VA: 0x6CF5DBFFAC
	private void OnGUI() { }

	// RVA: 0x6CF5DC03F0 Offset: 0xD693F0 VA: 0x6CF5DC03F0
	private void LeaveRoomNow(int windowID) { }

	// RVA: 0x6CF5DC04E8 Offset: 0xD694E8 VA: 0x6CF5DC04E8
	private void ShowTeamSelected(int windowID) { }

	// RVA: 0x6CF5DC08B4 Offset: 0xD698B4 VA: 0x6CF5DC08B4
	private void ScoreboardWindow(int windowID) { }

	// RVA: 0x6CF5DC1C34 Offset: 0xD6AC34 VA: 0x6CF5DC1C34
	private void DisplayTeamPlayers(List`1 teamTmp, int fieldWidth) { }

	// RVA: 0x6CF5DC2818 Offset: 0xD6B818 VA: 0x6CF5DC2818
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class BulletAutoDestroy : MonoBehaviour
{
	// Fields

	public float timeOut; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5DC2904 Offset: 0xD6B904 VA: 0x6CF5DC2904
	private void Start() { }

	// RVA: 0x6CF5DC2980 Offset: 0xD6B980 VA: 0x6CF5DC2980
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff05>d__20 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public C4 <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC331C Offset: 0xD6C31C VA: 0x6CF5DC331C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC3738 Offset: 0xD6C738 VA: 0x6CF5DC3738
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC373C Offset: 0xD6C73C VA: 0x6CF5DC373C
	private bool MoveNext() { }

	// RVA: 0x6CF5DC38B8 Offset: 0xD6C8B8 VA: 0x6CF5DC38B8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC38C0 Offset: 0xD6C8C0 VA: 0x6CF5DC38C0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC38F8 Offset: 0xD6C8F8 VA: 0x6CF5DC38F8
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff0>d__21 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public C4 <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC3344 Offset: 0xD6C344 VA: 0x6CF5DC3344
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC3900 Offset: 0xD6C900 VA: 0x6CF5DC3900
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC3904 Offset: 0xD6C904 VA: 0x6CF5DC3904
	private bool MoveNext() { }

	// RVA: 0x6CF5DC3A80 Offset: 0xD6CA80 VA: 0x6CF5DC3A80
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC3A88 Offset: 0xD6CA88 VA: 0x6CF5DC3A88
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC3AC0 Offset: 0xD6CAC0 VA: 0x6CF5DC3AC0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff10>d__19 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public C4 <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC32F4 Offset: 0xD6C2F4 VA: 0x6CF5DC32F4
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC3AC8 Offset: 0xD6CAC8 VA: 0x6CF5DC3AC8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC3ACC Offset: 0xD6CACC VA: 0x6CF5DC3ACC
	private bool MoveNext() { }

	// RVA: 0x6CF5DC3C48 Offset: 0xD6CC48 VA: 0x6CF5DC3C48
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC3C50 Offset: 0xD6CC50 VA: 0x6CF5DC3C50
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC3C88 Offset: 0xD6CC88 VA: 0x6CF5DC3C88
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff20>d__18 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public C4 <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC32CC Offset: 0xD6C2CC VA: 0x6CF5DC32CC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC3C90 Offset: 0xD6CC90 VA: 0x6CF5DC3C90
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC3C94 Offset: 0xD6CC94 VA: 0x6CF5DC3C94
	private bool MoveNext() { }

	// RVA: 0x6CF5DC3E0C Offset: 0xD6CE0C VA: 0x6CF5DC3E0C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC3E14 Offset: 0xD6CE14 VA: 0x6CF5DC3E14
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC3E4C Offset: 0xD6CE4C VA: 0x6CF5DC3E4C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <OnOff40>d__17 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public C4 <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC32A4 Offset: 0xD6C2A4 VA: 0x6CF5DC32A4
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC3E54 Offset: 0xD6CE54 VA: 0x6CF5DC3E54
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC3E58 Offset: 0xD6CE58 VA: 0x6CF5DC3E58
	private bool MoveNext() { }

	// RVA: 0x6CF5DC3FD0 Offset: 0xD6CFD0 VA: 0x6CF5DC3FD0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC3FD8 Offset: 0xD6CFD8 VA: 0x6CF5DC3FD8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC4010 Offset: 0xD6D010 VA: 0x6CF5DC4010
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class C4 : MonoBehaviour
{
	// Fields

	public Collider[] ArroundNear; // 0x28
	public Collider[] Arround; // 0x30
	public AudioClip pip; // 0x38
	public AudioClip explode; // 0x40
	public AudioClip bombpl; // 0x48
	public AudioClip c4armed; // 0x50
	public AudioClip c4_plant; // 0x58
	public float bombTime; // 0x60
	public GameObject fadeLight; // 0x68
	private Light c4point; // 0x70
	public SkinnedMeshRenderer C4Tp; // 0x78
	public bool diffuse; // 0x80
	private bool pip1; // 0x81

	// Properties


	// Methods

	// RVA: 0x6CF5DC2990 Offset: 0xD6B990 VA: 0x6CF5DC2990
	private void Start() { }

	// RVA: 0x6CF5DC2B54 Offset: 0xD6BB54 VA: 0x6CF5DC2B54
	private void AreaOfEffectDamage(GameObject players) { }

	// RVA: 0x6CF5DC2BB0 Offset: 0xD6BBB0 VA: 0x6CF5DC2BB0
	private void AreaOfEffectLongDamage(GameObject Longplayers) { }

	// RVA: 0x6CF5DC2C0C Offset: 0xD6BC0C VA: 0x6CF5DC2C0C
	private void Update() { }

	// RVA: 0x6CF5DC30C4 Offset: 0xD6C0C4 VA: 0x6CF5DC30C4
	private IEnumerator OnOff40() { }

	// RVA: 0x6CF5DC3124 Offset: 0xD6C124 VA: 0x6CF5DC3124
	private IEnumerator OnOff20() { }

	// RVA: 0x6CF5DC3184 Offset: 0xD6C184 VA: 0x6CF5DC3184
	private IEnumerator OnOff10() { }

	// RVA: 0x6CF5DC31E4 Offset: 0xD6C1E4 VA: 0x6CF5DC31E4
	private IEnumerator OnOff05() { }

	// RVA: 0x6CF5DC3244 Offset: 0xD6C244 VA: 0x6CF5DC3244
	private IEnumerator OnOff0() { }

	// RVA: 0x6CF5DC336C Offset: 0xD6C36C VA: 0x6CF5DC336C
	private void Explode() { }

	// RVA: 0x6CF5DC366C Offset: 0xD6C66C VA: 0x6CF5DC366C
	private void Difuse2() { }

	// RVA: 0x6CF5DC3728 Offset: 0xD6C728 VA: 0x6CF5DC3728
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <RemoveCasing>d__13 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CasingScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC423C Offset: 0xD6D23C VA: 0x6CF5DC423C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC426C Offset: 0xD6D26C VA: 0x6CF5DC426C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC4270 Offset: 0xD6D270 VA: 0x6CF5DC4270
	private bool MoveNext() { }

	// RVA: 0x6CF5DC4358 Offset: 0xD6D358 VA: 0x6CF5DC4358
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC4360 Offset: 0xD6D360 VA: 0x6CF5DC4360
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC4398 Offset: 0xD6D398 VA: 0x6CF5DC4398
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CasingScript : MonoBehaviour
{
	// Fields

	public bool SawnOffShotgunCasing; // 0x20
	public float minimumXForce; // 0x24
	public float maximumXForce; // 0x28
	public float minimumYForce; // 0x2C
	public float maximumYForce; // 0x30
	public float minimumRotation; // 0x34
	public float maximumRotation; // 0x38
	public float despawnTime; // 0x3C
	public AudioClip[] casingSounds; // 0x40
	public AudioSource audioSource; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5DC4018 Offset: 0xD6D018 VA: 0x6CF5DC4018
	private void Awake() { }

	// RVA: 0x6CF5DC4150 Offset: 0xD6D150 VA: 0x6CF5DC4150
	private void Start() { }

	// RVA: 0x6CF5DC41D0 Offset: 0xD6D1D0 VA: 0x6CF5DC41D0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x6CF5DC4170 Offset: 0xD6D170 VA: 0x6CF5DC4170
	private IEnumerator RemoveCasing() { }

	// RVA: 0x6CF5DC4264 Offset: 0xD6D264 VA: 0x6CF5DC4264
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <FlashbangEffect>d__14 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FlashbangEffectScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC4748 Offset: 0xD6D748 VA: 0x6CF5DC4748
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC4770 Offset: 0xD6D770 VA: 0x6CF5DC4770
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC4774 Offset: 0xD6D774 VA: 0x6CF5DC4774
	private bool MoveNext() { }

	// RVA: 0x6CF5DC4860 Offset: 0xD6D860 VA: 0x6CF5DC4860
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC4868 Offset: 0xD6D868 VA: 0x6CF5DC4868
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC48A0 Offset: 0xD6D8A0 VA: 0x6CF5DC48A0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FlashbangEffectScript : MonoBehaviour
{
	// Fields

	public bool isBlinded; // 0x20
	private bool routineStarted; // 0x21
	private PlayerNetwork pn; // 0x28
	public float effectTimer; // 0x30
	public float alphaTransitionMultiplier; // 0x34
	private float imageAlphaValue; // 0x38
	public float blurTransitionMultiplier; // 0x3C
	private float motionBlurValue; // 0x40
	public Camera effectCamera; // 0x48
	public AudioSource flashbangAudio; // 0x50
	public CanvasGroup flashbangImage; // 0x58
	public AudioClip FlashBang; // 0x60

	// Properties


	// Methods

	// RVA: 0x6CF5DC43A0 Offset: 0xD6D3A0 VA: 0x6CF5DC43A0
	private void Start() { }

	// RVA: 0x6CF5DC4570 Offset: 0xD6D570 VA: 0x6CF5DC4570
	private void Update() { }

	// RVA: 0x6CF5DC46C0 Offset: 0xD6D6C0 VA: 0x6CF5DC46C0
	private IEnumerator FlashbangEffect() { }

	// RVA: 0x6CF5DC4728 Offset: 0xD6D728 VA: 0x6CF5DC4728
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class GameSettings : MonoBehaviour
{
	// Fields

	public static Vector2 moveDirection; // 0x0
	public static Vector2 lookDirection; // 0x8
	public static bool mobileFiring; // 0x10
	public static bool mobileReloading; // 0x11
	public static bool mobileAiming; // 0x12
	public static bool mobileJumping; // 0x13
	public static bool mobileCrounch; // 0x14
	public static bool grenadeShoot; // 0x15
	public static bool flashShoot; // 0x16
	public static int switchWeaponIndex; // 0x18
	public static bool refillingAmmo; // 0x1C
	public static bool C4on; // 0x1D
	public static bool TimeOff; // 0x1E
	public static bool ShowMessageBombMe; // 0x1F
	public static bool ShowBombPlace; // 0x20
	public static bool C4CreateUI; // 0x21
	public static bool AB; // 0x22
	public static bool C4Fire; // 0x23
	public static bool C4idle; // 0x24
	public static bool Diffuse; // 0x25
	public static bool MoveOn; // 0x26
	public static bool AnimOn; // 0x27
	public static bool C4Diffuse; // 0x28
	public static RoomController rc; // 0x30
	public static int cnst; // 0x38
	public static float defaultFOV; // 0x3C
	public static float currentFOV; // 0x40
	public static Sprite currentScopeTexture; // 0x48
	public static string teamAName; // 0x50
	public static Color teamAColor; // 0x58
	public static string teamBName; // 0x68
	public static Color teamBColor; // 0x70
	public static Color drawColor; // 0x80
	public static Color HUDColor; // 0x90
	public static Color buyColor; // 0xA0
	public static Color shieldColor; // 0xB0
	public static Color roundtColor; // 0xC0
	public static Color whitetColor; // 0xD0
	public static Color textShadowColor; // 0xE0
	public static Color customRedColor; // 0xF0
	public static Color otherPlayerGUIBoxColor; // 0x100
	public static float mouseSensitivity; // 0x110
	public static KeyCode[] playerKeys; // 0x118
	public static String[] playerKeysNames; // 0x120
	public static KeyCode[] defaultPlayerKeys; // 0x128
	public static string errorText; // 0x130
	public static string WinTeam; // 0x138
	public static string C4Who; // 0x140
	public static float currentFPS; // 0x148
	public static int ourTeam; // 0x14C
	public static string currentGameMode; // 0x150
	public static bool menuOpened; // 0x158
	public static int actionReportsLimit; // 0x15C
	public static int actionWeaponReportsLimit; // 0x160
	public static int chatMessagesLimit; // 0x164
	public static bool updateActionReports; // 0x168
	public static bool updateWeaponActionReports; // 0x169
	public static bool updateChatMessages; // 0x16A
	public static Font KillFont; // 0x170
	public static GUISkin guiSkin; // 0x178
	public static GUIStyle headerStyle; // 0x180
	public static GUIStyle closeButtonStyle; // 0x188
	public static GUIStyle roomBrowserHeadersStyle; // 0x190
	public static GUIStyle createRoomOptionsStyle; // 0x198
	public static GUIStyle timeStyle; // 0x1A0
	public static GUIStyle finalScreenStyle; // 0x1A8
	public static GUIStyle hudInfoStyle; // 0x1B0
	public static GUIStyle weaponInfoStyle; // 0x1B8
	public static GUIStyle keyPressStyle; // 0x1C0
	public static GUIStyle buyMenuButtonStyle; // 0x1C8
	public static GUIStyle actionReportStyle; // 0x1D0

	// Properties


	// Methods

	// RVA: 0x6CF5DC48A8 Offset: 0xD6D8A8 VA: 0x6CF5DC48A8
	public static string ColorToHex(Color32 color) { }

	// RVA: 0x6CF5DC4940 Offset: 0xD6D940 VA: 0x6CF5DC4940
	public static Color HexToColor(string hex) { }

	// RVA: 0x6CF5DC49EC Offset: 0xD6D9EC VA: 0x6CF5DC49EC
	public void .ctor() { }

	// RVA: 0x6CF5DC49F4 Offset: 0xD6D9F4 VA: 0x6CF5DC49F4
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <FlashDelay>d__27 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LightningScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC5408 Offset: 0xD6E408 VA: 0x6CF5DC5408
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC54F0 Offset: 0xD6E4F0 VA: 0x6CF5DC54F0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC54F4 Offset: 0xD6E4F4 VA: 0x6CF5DC54F4
	private bool MoveNext() { }

	// RVA: 0x6CF5DC55B4 Offset: 0xD6E5B4 VA: 0x6CF5DC55B4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC55BC Offset: 0xD6E5BC VA: 0x6CF5DC55BC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC55F4 Offset: 0xD6E5F4 VA: 0x6CF5DC55F4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <LightFlashOne>d__26 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LightningScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC53E0 Offset: 0xD6E3E0 VA: 0x6CF5DC53E0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC55FC Offset: 0xD6E5FC VA: 0x6CF5DC55FC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC5600 Offset: 0xD6E600 VA: 0x6CF5DC5600
	private bool MoveNext() { }

	// RVA: 0x6CF5DC5848 Offset: 0xD6E848 VA: 0x6CF5DC5848
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC5850 Offset: 0xD6E850 VA: 0x6CF5DC5850
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC5888 Offset: 0xD6E888 VA: 0x6CF5DC5888
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <LightFlashTwo>d__28 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LightningScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC5430 Offset: 0xD6E430 VA: 0x6CF5DC5430
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC5890 Offset: 0xD6E890 VA: 0x6CF5DC5890
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC5894 Offset: 0xD6E894 VA: 0x6CF5DC5894
	private bool MoveNext() { }

	// RVA: 0x6CF5DC5B28 Offset: 0xD6EB28 VA: 0x6CF5DC5B28
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC5B30 Offset: 0xD6EB30 VA: 0x6CF5DC5B30
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC5B68 Offset: 0xD6EB68 VA: 0x6CF5DC5B68
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <Timer>d__29 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LightningScript <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC5458 Offset: 0xD6E458 VA: 0x6CF5DC5458
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC5B70 Offset: 0xD6EB70 VA: 0x6CF5DC5B70
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC5B74 Offset: 0xD6EB74 VA: 0x6CF5DC5B74
	private bool MoveNext() { }

	// RVA: 0x6CF5DC5C28 Offset: 0xD6EC28 VA: 0x6CF5DC5C28
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC5C30 Offset: 0xD6EC30 VA: 0x6CF5DC5C30
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC5C68 Offset: 0xD6EC68 VA: 0x6CF5DC5C68
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class LightningScript : MonoBehaviour
{
	// Fields

	public float minIntensity; // 0x20
	public float maxIntensity; // 0x24
	public float lightDuration; // 0x28
	public float minFlashDelay; // 0x2C
	public float maxFlashDelay; // 0x30
	public float minDelay; // 0x34
	public float maxDelay; // 0x38
	private float delay; // 0x3C
	private float flashDelay; // 0x40
	private bool isWaiting; // 0x44
	public Color mainBackgroundColor; // 0x48
	public Color lightningBackgroundColor; // 0x58
	public float minSize; // 0x68
	public float maxSize; // 0x6C
	public Camera gunCamera; // 0x70
	public Light lightObject; // 0x78
	public AudioSource lightningSound; // 0x80
	public Sprite[] lightningSprites; // 0x88
	public SpriteRenderer lightningSpriteRenderer; // 0x90
	private float x; // 0x98
	private float y; // 0x9C
	private Vector3 lightningPos; // 0xA0
	private float lightningScale; // 0xAC
	private string playerNameJoinPrefsName; // 0xB0

	// Properties


	// Methods

	// RVA: 0x6CF5DC5078 Offset: 0xD6E078 VA: 0x6CF5DC5078
	private void Start() { }

	// RVA: 0x6CF5DC5098 Offset: 0xD6E098 VA: 0x6CF5DC5098
	private void Update() { }

	// RVA: 0x6CF5DC5260 Offset: 0xD6E260 VA: 0x6CF5DC5260
	private IEnumerator LightFlashOne() { }

	// RVA: 0x6CF5DC52C0 Offset: 0xD6E2C0 VA: 0x6CF5DC52C0
	private IEnumerator FlashDelay() { }

	// RVA: 0x6CF5DC5320 Offset: 0xD6E320 VA: 0x6CF5DC5320
	private IEnumerator LightFlashTwo() { }

	// RVA: 0x6CF5DC5380 Offset: 0xD6E380 VA: 0x6CF5DC5380
	private IEnumerator Timer() { }

	// RVA: 0x6CF5DC5480 Offset: 0xD6E480 VA: 0x6CF5DC5480
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum Alignment
{
	// Fields

	public int value__; // 0x10
	public const Alignment None = 0; // 0x0
	public const Alignment LeftTop = 1; // 0x0
	public const Alignment RightTop = 2; // 0x0
	public const Alignment LeftBot = 3; // 0x0
	public const Alignment RightBot = 4; // 0x0
	public const Alignment MiddleTop = 5; // 0x0
	public const Alignment MiddleBot = 6; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RadarSystem : MonoBehaviour
{
	// Fields

	private Vector2 inposition; // 0x20
	public float Size; // 0x28
	public float Distance; // 0x2C
	public Texture2D[] Navtexture; // 0x30
	public String[] EnemyTag; // 0x38
	public Texture2D NavCompass; // 0x40
	public Texture2D NavBG; // 0x48
	public Vector2 PositionOffset; // 0x50
	public Alignment PositionAlignment; // 0x58
	public float Scale; // 0x5C
	public float ScaleIndicator; // 0x60
	public bool MapRotation; // 0x64
	public GameObject Player; // 0x68
	public bool Show; // 0x70
	public Color ColorMult; // 0x74
	private PlayerNetwork pn; // 0x88

	// Properties


	// Methods

	// RVA: 0x6CF5DC5C70 Offset: 0xD6EC70 VA: 0x6CF5DC5C70
	private void Start() { }

	// RVA: 0x6CF5DC5CC0 Offset: 0xD6ECC0 VA: 0x6CF5DC5CC0
	private void Update() { }

	// RVA: 0x6CF5DC60F0 Offset: 0xD6F0F0 VA: 0x6CF5DC60F0
	private Vector2 ConvertToNavPosition(Vector3 pos) { }

	// RVA: 0x6CF5DC6244 Offset: 0xD6F244 VA: 0x6CF5DC6244
	private void DrawNav(GameObject[] enemylists, Texture2D navtexture) { }

	// RVA: 0x6CF5DC6594 Offset: 0xD6F594 VA: 0x6CF5DC6594
	private void OnGUI() { }

	// RVA: 0x6CF5DC68EC Offset: 0xD6F8EC VA: 0x6CF5DC68EC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SetupGUIStyles : MonoBehaviour
{
	// Fields

	public GUISkin guiSkin; // 0x20
	public GUISkin guiSkin2; // 0x28
	public Font KillFont; // 0x30
	public Texture2D closeIcon; // 0x38
	public Texture2D closeIconHover; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF5DC691C Offset: 0xD6F91C VA: 0x6CF5DC691C
	private void Awake() { }

	// RVA: 0x6CF5DC7034 Offset: 0xD70034 VA: 0x6CF5DC7034
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <Start>d__5 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SplashFade <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC71A0 Offset: 0xD701A0 VA: 0x6CF5DC71A0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC7294 Offset: 0xD70294 VA: 0x6CF5DC7294
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC7298 Offset: 0xD70298 VA: 0x6CF5DC7298
	private bool MoveNext() { }

	// RVA: 0x6CF5DC74C4 Offset: 0xD704C4 VA: 0x6CF5DC74C4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC74CC Offset: 0xD704CC VA: 0x6CF5DC74CC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC7504 Offset: 0xD70504 VA: 0x6CF5DC7504
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SplashFade : MonoBehaviour
{
	// Fields

	public Image splashImage; // 0x20
	public string loadLevel; // 0x28
	private ObscuredBool cheat; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5DC703C Offset: 0xD7003C VA: 0x6CF5DC703C
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5DC70A0 Offset: 0xD700A0 VA: 0x6CF5DC70A0
	private void Update() { }

	// RVA: 0x6CF5DC7140 Offset: 0xD70140 VA: 0x6CF5DC7140
	private IEnumerator Start() { }

	// RVA: 0x6CF5DC71C8 Offset: 0xD701C8 VA: 0x6CF5DC71C8
	private void FadeIn() { }

	// RVA: 0x6CF5DC71F8 Offset: 0xD701F8 VA: 0x6CF5DC71F8
	private void FadeOut() { }

	// RVA: 0x6CF5DC7228 Offset: 0xD70228 VA: 0x6CF5DC7228
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class TagFire : MonoBehaviour
{
	// Fields

	private bool tagOn; // 0x20
	private float timer; // 0x24

	// Properties


	// Methods

	// RVA: 0x6CF5DC750C Offset: 0xD7050C VA: 0x6CF5DC750C
	public void AllClear() { }

	// RVA: 0x6CF5DC751C Offset: 0xD7051C VA: 0x6CF5DC751C
	private void Update() { }

	// RVA: 0x6CF5DC7634 Offset: 0xD70634 VA: 0x6CF5DC7634
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <MoveCameraCrouch>d__59 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSController <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC906C Offset: 0xD7206C VA: 0x6CF5DC906C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC9350 Offset: 0xD72350 VA: 0x6CF5DC9350
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC9354 Offset: 0xD72354 VA: 0x6CF5DC9354
	private bool MoveNext() { }

	// RVA: 0x6CF5DC94E4 Offset: 0xD724E4 VA: 0x6CF5DC94E4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DC94EC Offset: 0xD724EC VA: 0x6CF5DC94EC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DC9524 Offset: 0xD72524 VA: 0x6CF5DC9524
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FPSController : MonoBehaviour
{
	// Fields

	public Transform firstPersonView; // 0x20
	public Transform playerCamera; // 0x28
	public float walkSpeed; // 0x30
	public float runSpeed; // 0x34
	public float crouchSpeed; // 0x38
	public float jumpSpeed; // 0x3C
	public float ladderSpeed; // 0x40
	public float gravity; // 0x44
	public float fallingDamageThreshold; // 0x48
	public bool slideWhenOverSlopeLimit; // 0x4C
	public float slideSpeed; // 0x50
	private bool airControl; // 0x54
	public int movementState; // 0x58
	public bool isMoving; // 0x5C
	public bool isGrounded; // 0x5D
	public bool isCrouching; // 0x5E
	public bool C4tg; // 0x5F
	public bool Diffusetg; // 0x60
	public bool C4XTG; // 0x61
	public bool isSprintingSlowly; // 0x62
	public float speed; // 0x64
	public PlayerNetwork pn; // 0x68
	public float fallSlowDown; // 0x70
	public Vector3 firstPersonViewRotation; // 0x74
	private float antiBumpFactor; // 0x80
	private Vector3 moveDirection; // 0x84
	private LayerMask layerMask; // 0x90
	private CharacterController controller; // 0x98
	private Transform myTransform; // 0xA0
	private RaycastHit hit; // 0xA8
	private float fallStartLevel; // 0xD4
	private bool falling; // 0xD8
	private float slideLimit; // 0xDC
	private float rayDistance; // 0xE0
	private bool sliding; // 0xE4
	private bool limitDiagonalSpeed; // 0xE5
	private float inputX; // 0xE8
	private float inputY; // 0xEC
	private float inputXSet; // 0xF0
	private float inputYSet; // 0xF4
	private float inputModifyFactor; // 0xF8
	private Vector3 defaultCamPos; // 0xFC
	private float defaultControllerHeight; // 0x108
	private float camHeight; // 0x10C
	private Transform currentLadder; // 0x110
	private Vector3 climbingDirection; // 0x118
	private float climbDownThreshold; // 0x124
	private float ladderAngle; // 0x128
	private Vector3 slidingDirection; // 0x12C
	private float slidingSpeedTmp; // 0x138
	private float slopeAngle; // 0x13C

	// Properties


	// Methods

	// RVA: 0x6CF5DC7644 Offset: 0xD70644 VA: 0x6CF5DC7644
	private void Start() { }

	// RVA: 0x6CF5DC7788 Offset: 0xD70788 VA: 0x6CF5DC7788
	public void AssignLadder(Transform ladder) { }

	// RVA: 0x6CF5DC77BC Offset: 0xD707BC VA: 0x6CF5DC77BC
	public void RemoveLadder(Transform ladder) { }

	// RVA: 0x6CF5DC7834 Offset: 0xD70834 VA: 0x6CF5DC7834
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x6CF5DC7B58 Offset: 0xD70B58 VA: 0x6CF5DC7B58
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x6CF5DC7D74 Offset: 0xD70D74 VA: 0x6CF5DC7D74
	private void Update() { }

	// RVA: 0x6CF5DC8E24 Offset: 0xD71E24 VA: 0x6CF5DC8E24
	private void FixedUpdate() { }

	// RVA: 0x6CF5DC8B58 Offset: 0xD71B58 VA: 0x6CF5DC8B58
	private bool CanGetUp() { }

	// RVA: 0x6CF5DC8DC4 Offset: 0xD71DC4 VA: 0x6CF5DC8DC4
	private IEnumerator MoveCameraCrouch() { }

	// RVA: 0x6CF5DC8A28 Offset: 0xD71A28 VA: 0x6CF5DC8A28
	private void FallingDamageAlert(float fallDistance) { }

	// RVA: 0x6CF5DC9294 Offset: 0xD72294 VA: 0x6CF5DC9294
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum RotationAxes
{
	// Fields

	public int value__; // 0x10
	public const RotationAxes MouseX = 0; // 0x0
	public const RotationAxes MouseY = 1; // 0x0
	public const RotationAxes MouseOrbit = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <MoveToTarget>d__25 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSMouseLook <>4__this; // 0x20
	private Quaternion <rotation>5__2; // 0x28

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC9E18 Offset: 0xD72E18 VA: 0x6CF5DC9E18
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DC9E7C Offset: 0xD72E7C VA: 0x6CF5DC9E7C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DC9E80 Offset: 0xD72E80 VA: 0x6CF5DC9E80
	private bool MoveNext() { }

	// RVA: 0x6CF5DCA1FC Offset: 0xD731FC VA: 0x6CF5DCA1FC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DCA204 Offset: 0xD73204 VA: 0x6CF5DCA204
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DCA23C Offset: 0xD7323C VA: 0x6CF5DCA23C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <SmoothRecoil>d__23 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSMouseLook <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DC9C68 Offset: 0xD72C68 VA: 0x6CF5DC9C68
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DCA244 Offset: 0xD73244 VA: 0x6CF5DCA244
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DCA248 Offset: 0xD73248 VA: 0x6CF5DCA248
	private bool MoveNext() { }

	// RVA: 0x6CF5DCA340 Offset: 0xD73340 VA: 0x6CF5DCA340
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DCA348 Offset: 0xD73348 VA: 0x6CF5DCA348
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DCA380 Offset: 0xD73380 VA: 0x6CF5DCA380
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FPSMouseLook : MonoBehaviour
{
	// Fields

	public RotationAxes axes; // 0x20
	public Transform target; // 0x28
	private float currentSensitivityX; // 0x30
	private float currentSensitivityY; // 0x34
	private float sensitivityX; // 0x38
	private float sensitivityY; // 0x3C
	private float minimumY; // 0x40
	private float maximumY; // 0x44
	private float rotationX; // 0x48
	private float rotationY; // 0x4C
	private float minimumX; // 0x50
	private float maximumX; // 0x54
	private Quaternion originalRotation; // 0x58
	private bool doingRecoil; // 0x68
	private float recoilAmount; // 0x6C
	private float tempRecoil; // 0x70
	private float distance; // 0x74
	private bool reachedTarget; // 0x78

	// Properties


	// Methods

	// RVA: 0x6CF5DC952C Offset: 0xD7252C VA: 0x6CF5DC952C
	private void Start() { }

	// RVA: 0x6CF5DC95FC Offset: 0xD725FC VA: 0x6CF5DC95FC
	private void LateUpdate() { }

	// RVA: 0x6CF5DC9B98 Offset: 0xD72B98 VA: 0x6CF5DC9B98
	public static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x6CF5DC9BD4 Offset: 0xD72BD4 VA: 0x6CF5DC9BD4
	public void Recoil() { }

	// RVA: 0x6CF5DC9C08 Offset: 0xD72C08 VA: 0x6CF5DC9C08
	private IEnumerator SmoothRecoil() { }

	// RVA: 0x6CF5DC9C90 Offset: 0xD72C90 VA: 0x6CF5DC9C90
	public void AssignTarget(Transform t1) { }

	// RVA: 0x6CF5DC9DB8 Offset: 0xD72DB8 VA: 0x6CF5DC9DB8
	private IEnumerator MoveToTarget() { }

	// RVA: 0x6CF5DC9E40 Offset: 0xD72E40 VA: 0x6CF5DC9E40
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum BodyPart
{
	// Fields

	public int value__; // 0x10
	public const BodyPart Head = 0; // 0x0
	public const BodyPart Torso = 1; // 0x0
	public const BodyPart Limbs = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class HitBox : MonoBehaviour
{
	// Fields

	public BodyPart bodyPart; // 0x20
	public PlayerNetwork playerNetwork; // 0x28
	private Vector3 cameraRelative; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5DCA388 Offset: 0xD73388 VA: 0x6CF5DCA388
	public void Damage(Int32[] values, Vector3 hitPos) { }

	// RVA: 0x6CF5DCA46C Offset: 0xD7346C VA: 0x6CF5DCA46C
	public void AssignVariables(PlayerNetwork pn, BodyPart bp) { }

	// RVA: 0x6CF5DCA478 Offset: 0xD73478 VA: 0x6CF5DCA478
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class LadderScript : MonoBehaviour
{
	// Fields

	public Transform thisT; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5DCA480 Offset: 0xD73480 VA: 0x6CF5DCA480
	private void Start() { }

	// RVA: 0x6CF5DCA49C Offset: 0xD7349C VA: 0x6CF5DCA49C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal struct State
{
	// Fields

	internal double timestamp; // 0x10
	internal Vector3 pos; // 0x18
	internal Quaternion rot; // 0x24

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <MoveON>d__59 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DCB484 Offset: 0xD74484 VA: 0x6CF5DCB484
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DCF774 Offset: 0xD78774 VA: 0x6CF5DCF774
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DCF778 Offset: 0xD78778 VA: 0x6CF5DCF778
	private bool MoveNext() { }

	// RVA: 0x6CF5DCF844 Offset: 0xD78844 VA: 0x6CF5DCF844
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DCF84C Offset: 0xD7884C VA: 0x6CF5DCF84C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DCF884 Offset: 0xD78884 VA: 0x6CF5DCF884
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ShieldOnNow>d__58 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerNetwork <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DCB404 Offset: 0xD74404 VA: 0x6CF5DCB404
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DCF88C Offset: 0xD7888C VA: 0x6CF5DCF88C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DCF890 Offset: 0xD78890 VA: 0x6CF5DCF890
	private bool MoveNext() { }

	// RVA: 0x6CF5DCF958 Offset: 0xD78958 VA: 0x6CF5DCF958
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DCF960 Offset: 0xD78960 VA: 0x6CF5DCF960
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DCF998 Offset: 0xD78998 VA: 0x6CF5DCF998
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PlayerNetwork : MonoBehaviour
{
	// Fields

	public SoldierAnimation soldierAnimation; // 0x28
	public GameObject Counter; // 0x30
	public GameObject Teror; // 0x38
	public PlayerWeapons playerWeapons; // 0x40
	public GameObject firstPersonView; // 0x48
	public GameObject CounterBox; // 0x50
	public GameObject C4Box; // 0x58
	public GameObject C4Box4; // 0x60
	public Transform ThrowPoint; // 0x68
	public float ForwardThrowForce; // 0x70
	public float UpwardThrowForce; // 0x74
	public Transform nameLabelTransform; // 0x78
	public Text nameLabel; // 0x80
	public Text nameLabelShadow; // 0x88
	public AudioSource playerAudio; // 0x90
	public AudioSource walkingAudio; // 0x98
	public AudioClip hitSound; // 0xA0
	public AudioClip[] walkingSounds; // 0xA8
	public AudioClip[] ladderSounds; // 0xB0
	public Collider[] headHitBoxes; // 0xB8
	public Collider[] torsoHitBoxes; // 0xC0
	public Collider[] limbsHitBoxes; // 0xC8
	private Vector3 playerPos; // 0xD0
	public Vector3 aimPos; // 0xDC
	private Vector3 smoothAimPos; // 0xE8
	private float positionSmoother; // 0xF4
	private float d; // 0xF8
	public FPSController fpsController; // 0x100
	private FPSMouseLook localMouseLook; // 0x108
	private RadarSystem rs; // 0x110
	private FlashbangEffectScript fbes; // 0x118
	public FPSMouseLook cameraMouseLook; // 0x120
	public Transform thisT; // 0x128
	public int playerID; // 0x130
	public bool playerKilled; // 0x134
	public int KillSay; // 0x138
	public string TeamName; // 0x140
	public string MeName; // 0x148
	private int currentWeaponIndex; // 0x150
	private int previousWeaponIndex; // 0x154
	private bool isFiringRemote; // 0x158
	public int playerTeam; // 0x15C
	private Camera mainCamera; // 0x160
	private Transform mainCameraT; // 0x168
	private Vector3 screenPos; // 0x170
	private float offset; // 0x17C
	private string lastWeaponName; // 0x180
	private int lastBodyPart; // 0x188
	private int allPlayer; // 0x18C
	private double interpolationBackTime; // 0x190
	private State[] m_BufferedState; // 0x198
	private int m_TimestampCount; // 0x1A0
	private int movementStateLocal; // 0x1A4
	private int receivedMovementState; // 0x1A8
	private float stepLength; // 0x1AC

	// Properties


	// Methods

	// RVA: 0x6CF5DCA4A4 Offset: 0xD734A4 VA: 0x6CF5DCA4A4
	private void Start() { }

	// RVA: 0x6CF5DCB278 Offset: 0xD74278 VA: 0x6CF5DCB278
	private void SetupBoxes(Collider[] tmpBoxes, BodyPart bp) { }

	// RVA: 0x6CF5DCB3A4 Offset: 0xD743A4 VA: 0x6CF5DCB3A4
	private IEnumerator ShieldOnNow() { }

	// RVA: 0x6CF5DCB42C Offset: 0xD7442C VA: 0x6CF5DCB42C
	private IEnumerator MoveON() { }

	// RVA: 0x6CF5DCB214 Offset: 0xD74214 VA: 0x6CF5DCB214
	private void SetupShield(Collider[] tmpBoxes) { }

	// RVA: 0x6CF5DCB4AC Offset: 0xD744AC VA: 0x6CF5DCB4AC
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5DCB9E8 Offset: 0xD749E8 VA: 0x6CF5DCB9E8
	private void BoxC4Fire() { }

	// RVA: 0x6CF5DCBC20 Offset: 0xD74C20 VA: 0x6CF5DCBC20
	private void Update() { }

	// RVA: 0x6CF5DCC500 Offset: 0xD75500 VA: 0x6CF5DCC500
	private void InterpolatePosition() { }

	// RVA: 0x6CF5DCC820 Offset: 0xD75820 VA: 0x6CF5DCC820
	public void FireSingleRemote() { }

	// RVA: 0x6CF5DCC8EC Offset: 0xD758EC VA: 0x6CF5DCC8EC
	private void FireRemoteRPC() { }

	// RVA: 0x6CF5DCC908 Offset: 0xD75908 VA: 0x6CF5DCC908
	public void FireSingleRemoteC4Fire() { }

	// RVA: 0x6CF5DCC9D4 Offset: 0xD759D4 VA: 0x6CF5DCC9D4
	private void FireRemoteRPCC4Fire() { }

	// RVA: 0x6CF5DCC9F0 Offset: 0xD759F0 VA: 0x6CF5DCC9F0
	public void FireSingleRemoteC4Idle() { }

	// RVA: 0x6CF5DCCABC Offset: 0xD75ABC VA: 0x6CF5DCCABC
	private void FireRemoteRPCC4Idle() { }

	// RVA: 0x6CF5DCCAD8 Offset: 0xD75AD8 VA: 0x6CF5DCCAD8
	public void DoReload() { }

	// RVA: 0x6CF5DCCBA4 Offset: 0xD75BA4 VA: 0x6CF5DCCBA4
	private void DoReloadRemote() { }

	// RVA: 0x6CF5DC9094 Offset: 0xD72094 VA: 0x6CF5DC9094
	public void ApplyDamage(Int32[] values) { }

	// RVA: 0x6CF5DCCCE8 Offset: 0xD75CE8 VA: 0x6CF5DCCCE8
	private void DamageRemote(Int32[] values, int killerID) { }

	// RVA: 0x6CF5DCD39C Offset: 0xD7639C VA: 0x6CF5DCD39C
	public void BombDmg(int killerID) { }

	// RVA: 0x6CF5DCD710 Offset: 0xD76710 VA: 0x6CF5DCD710
	public void BombDmgLong(int killerID) { }

	// RVA: 0x6CF5DCDA84 Offset: 0xD76A84 VA: 0x6CF5DCDA84
	public void C4Dmg() { }

	// RVA: 0x6CF5DCDDEC Offset: 0xD76DEC VA: 0x6CF5DCDDEC
	public void C4DmgLong() { }

	// RVA: 0x6CF5DCE154 Offset: 0xD77154 VA: 0x6CF5DCE154
	public void DiffuseC4() { }

	// RVA: 0x6CF5DCE248 Offset: 0xD77248 VA: 0x6CF5DCE248
	private void DiffuseC4Now() { }

	// RVA: 0x6CF5DCE2A4 Offset: 0xD772A4 VA: 0x6CF5DCE2A4
	public void WonCounter() { }

	// RVA: 0x6CF5DCE398 Offset: 0xD77398 VA: 0x6CF5DCE398
	private void WonCT() { }

	// RVA: 0x6CF5DCE408 Offset: 0xD77408 VA: 0x6CF5DCE408
	public void WonTeror() { }

	// RVA: 0x6CF5DCE4FC Offset: 0xD774FC VA: 0x6CF5DCE4FC
	private void WonT() { }

	// RVA: 0x6CF5DCE56C Offset: 0xD7756C VA: 0x6CF5DCE56C
	private void KillPlayer(int killerID) { }

	// RVA: 0x6CF5DCD274 Offset: 0xD76274 VA: 0x6CF5DCD274
	private int GetDMG(int weaponIndex, int bodyPart) { }

	// RVA: 0x6CF5DCD148 Offset: 0xD76148 VA: 0x6CF5DCD148
	private void PlayHitSound() { }

	// RVA: 0x6CF5DCC74C Offset: 0xD7574C VA: 0x6CF5DCC74C
	private void PlayWalkingSound() { }

	// RVA: 0x6CF5DCF538 Offset: 0xD78538 VA: 0x6CF5DCF538
	private void PlayWalkingSoundInvoke() { }

	// RVA: 0x6CF5DCF64C Offset: 0xD7864C VA: 0x6CF5DCF64C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class WeaponAnimationSet : Object
{
	// Fields

	public AnimationClip idle; // 0x10
	public AnimationClip fire; // 0x18
	public AnimationClip ReloadT; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5DD132C Offset: 0xD7A32C VA: 0x6CF5DD132C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AnimationSet : Object
{
	// Fields

	public AnimationClip idle; // 0x10
	public AnimationClip walk_front; // 0x18
	public AnimationClip walk_front_left; // 0x20
	public AnimationClip walk_front_right; // 0x28
	public AnimationClip crouchDie; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5DD1334 Offset: 0xD7A334 VA: 0x6CF5DD1334
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DoHitMovementCoroutine>d__58 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SoldierAnimation <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DD12AC Offset: 0xD7A2AC VA: 0x6CF5DD12AC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DD133C Offset: 0xD7A33C VA: 0x6CF5DD133C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DD1340 Offset: 0xD7A340 VA: 0x6CF5DD1340
	private bool MoveNext() { }

	// RVA: 0x6CF5DD15E4 Offset: 0xD7A5E4 VA: 0x6CF5DD15E4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DD15EC Offset: 0xD7A5EC VA: 0x6CF5DD15EC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DD1624 Offset: 0xD7A624 VA: 0x6CF5DD1624
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SoldierAnimation : MonoBehaviour
{
	// Fields

	public Transform spine1; // 0x20
	public Transform spine2; // 0x28
	public WeaponAnimationSet normalSet; // 0x30
	public WeaponAnimationSet ShotGunSet; // 0x38
	public WeaponAnimationSet pistolSet; // 0x40
	public WeaponAnimationSet knifeSet; // 0x48
	public WeaponAnimationSet bombSet; // 0x50
	public WeaponAnimationSet eliteSet; // 0x58
	public WeaponAnimationSet m246Set; // 0x60
	public WeaponAnimationSet C4Set; // 0x68
	public AnimationSet standingSet; // 0x70
	public AnimationSet crouchSet; // 0x78
	public AnimationClip reload; // 0x80
	public AnimationClip jumpPose; // 0x88
	public AnimationClip[] killedFalls; // 0x90
	public AnimationClip HeadFalls; // 0x98
	public AnimationClip TPose; // 0xA0
	private WeaponAnimationSet currentWeaponAnimationSet; // 0xA8
	private AnimationSet currentAnimationSet; // 0xB0
	private AnimationClip currentWalkAnimation; // 0xB8
	private FPSWeapon previousSelectedWeapon; // 0xC0
	private float forwardSpeed; // 0xC8
	private float strafeSpeed; // 0xCC
	private Vector3 velocity; // 0xD0
	private float speed; // 0xDC
	private Vector3 lastPosition; // 0xE0
	private Animation soldierAnimationComponent; // 0xF0
	public PlayerWeapons playerWeapons; // 0xF8
	public PlayerNetwork playerNetwork; // 0x100
	public int movementState; // 0x108
	public bool isMoving; // 0x10C
	private bool isKilled; // 0x10D
	private Vector2 hitPosition; // 0x110
	private Vector2 currentHitPosition; // 0x118
	private AnimationClip currentAnimationToPlay; // 0x120
	private AnimationClip previousAnimationPlayed; // 0x128
	private Quaternion referenceRotation; // 0x130
	private Quaternion startParentRotationQ; // 0x140
	private Quaternion startChildRotationQ; // 0x150
	private Quaternion startParentRotationQ2; // 0x160
	private Quaternion startChildRotationQ2; // 0x170
	private bool doneSetup; // 0x180

	// Properties


	// Methods

	// RVA: 0x6CF5DCAC40 Offset: 0xD73C40 VA: 0x6CF5DCAC40
	public void Setup() { }

	// RVA: 0x6CF5DCF9A0 Offset: 0xD789A0 VA: 0x6CF5DCF9A0
	private void SetMixedTransforms(WeaponAnimationSet anmset) { }

	// RVA: 0x6CF5DCFBA0 Offset: 0xD78BA0 VA: 0x6CF5DCFBA0
	private void SetWalkAnimations(AnimationSet anmset) { }

	// RVA: 0x6CF5DCFD30 Offset: 0xD78D30 VA: 0x6CF5DCFD30
	private void LateUpdate() { }

	// RVA: 0x6CF5DD06C8 Offset: 0xD796C8 VA: 0x6CF5DD06C8
	private void CalculatePlayerSpeed() { }

	// RVA: 0x6CF5DD0924 Offset: 0xD79924 VA: 0x6CF5DD0924
	private void RecalculateBoneRotations() { }

	// RVA: 0x6CF5DD0BCC Offset: 0xD79BCC VA: 0x6CF5DD0BCC
	public void PlayFireAnimation() { }

	// RVA: 0x6CF5DD0C44 Offset: 0xD79C44 VA: 0x6CF5DD0C44
	public void PlayFireAnimationC4() { }

	// RVA: 0x6CF5DD0D30 Offset: 0xD79D30 VA: 0x6CF5DD0D30
	public void PlayFireC4Stop() { }

	// RVA: 0x6CF5DD0D70 Offset: 0xD79D70 VA: 0x6CF5DD0D70
	public void PlayİdleC4() { }

	// RVA: 0x6CF5DD0E18 Offset: 0xD79E18 VA: 0x6CF5DD0E18
	public void PlayReloadAnimation(float duration) { }

	// RVA: 0x6CF5DCF2DC Offset: 0xD782DC VA: 0x6CF5DCF2DC
	public void PlayKillAnimationHead() { }

	// RVA: 0x6CF5DCF3D0 Offset: 0xD783D0 VA: 0x6CF5DCF3D0
	public void PlayKillAnimation() { }

	// RVA: 0x6CF5DCD1FC Offset: 0xD761FC VA: 0x6CF5DCD1FC
	public void DoHitMovement() { }

	// RVA: 0x6CF5DD124C Offset: 0xD7A24C VA: 0x6CF5DD124C
	private IEnumerator DoHitMovementCoroutine() { }

	// RVA: 0x6CF5DD12D4 Offset: 0xD7A2D4 VA: 0x6CF5DD12D4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FlashBang : MonoBehaviour
{
	// Fields

	public Collider[] ArroundNear; // 0x20
	public Collider[] Arround; // 0x28
	public float timeLeft; // 0x30
	public Transform particleEffect; // 0x38
	public Rigidbody rb; // 0x40
	public SkinnedMeshRenderer FlashTP; // 0x48
	public SkinnedMeshRenderer FlashDw; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF5DD162C Offset: 0xD7A62C VA: 0x6CF5DD162C
	private void Start() { }

	// RVA: 0x6CF5DD16D4 Offset: 0xD7A6D4 VA: 0x6CF5DD16D4
	private void FlashFalse() { }

	// RVA: 0x6CF5DD170C Offset: 0xD7A70C VA: 0x6CF5DD170C
	private void AreaOfEffectLongDamage(GameObject Longplayers) { }

	// RVA: 0x6CF5DD2094 Offset: 0xD7B094 VA: 0x6CF5DD2094
	private void Update() { }

	// RVA: 0x6CF5DD2374 Offset: 0xD7B374 VA: 0x6CF5DD2374
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum WeaponType
{
	// Fields

	public int value__; // 0x10
	public const WeaponType Primary = 0; // 0x0
	public const WeaponType Secondary = 1; // 0x0
	public const WeaponType Special = 2; // 0x0
	public const WeaponType Grenade = 3; // 0x0
	public const WeaponType Flash = 4; // 0x0
	public const WeaponType C4 = 5; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class FPSAnimations : Object
{
	// Fields

	public AnimationClip idle; // 0x10
	public AnimationClip fire; // 0x18
	public AnimationClip fire2; // 0x20
	public AnimationClip reload; // 0x28
	public AnimationClip deploy; // 0x30
	public AnimationClip reload2; // 0x38
	public AnimationClip reload3; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF5DE0620 Offset: 0xD89620 VA: 0x6CF5DE0620
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <BombGrenade>d__74 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE0628 Offset: 0xD89628 VA: 0x6CF5DE0628
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE0650 Offset: 0xD89650 VA: 0x6CF5DE0650
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE0654 Offset: 0xD89654 VA: 0x6CF5DE0654
	private bool MoveNext() { }

	// RVA: 0x6CF5DE0760 Offset: 0xD89760 VA: 0x6CF5DE0760
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE0768 Offset: 0xD89768 VA: 0x6CF5DE0768
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE07A0 Offset: 0xD897A0 VA: 0x6CF5DE07A0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <CasingDelay>d__72 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE07A8 Offset: 0xD897A8 VA: 0x6CF5DE07A8
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE07D0 Offset: 0xD897D0 VA: 0x6CF5DE07D0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE07D4 Offset: 0xD897D4 VA: 0x6CF5DE07D4
	private bool MoveNext() { }

	// RVA: 0x6CF5DE09AC Offset: 0xD899AC VA: 0x6CF5DE09AC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE09B4 Offset: 0xD899B4 VA: 0x6CF5DE09B4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE09EC Offset: 0xD899EC VA: 0x6CF5DE09EC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DoMuzzleFlash2>d__73 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE09F4 Offset: 0xD899F4 VA: 0x6CF5DE09F4
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE0A1C Offset: 0xD89A1C VA: 0x6CF5DE0A1C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE0A20 Offset: 0xD89A20 VA: 0x6CF5DE0A20
	private bool MoveNext() { }

	// RVA: 0x6CF5DE0CC8 Offset: 0xD89CC8 VA: 0x6CF5DE0CC8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE0CD0 Offset: 0xD89CD0 VA: 0x6CF5DE0CD0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE0D08 Offset: 0xD89D08 VA: 0x6CF5DE0D08
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DoMuzzleFlash>d__71 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE0D10 Offset: 0xD89D10 VA: 0x6CF5DE0D10
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE0D38 Offset: 0xD89D38 VA: 0x6CF5DE0D38
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE0D3C Offset: 0xD89D3C VA: 0x6CF5DE0D3C
	private bool MoveNext() { }

	// RVA: 0x6CF5DE0FE8 Offset: 0xD89FE8 VA: 0x6CF5DE0FE8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE0FF0 Offset: 0xD89FF0 VA: 0x6CF5DE0FF0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE1028 Offset: 0xD8A028 VA: 0x6CF5DE1028
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <FlashBang>d__75 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE1030 Offset: 0xD8A030 VA: 0x6CF5DE1030
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE1058 Offset: 0xD8A058 VA: 0x6CF5DE1058
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE105C Offset: 0xD8A05C VA: 0x6CF5DE105C
	private bool MoveNext() { }

	// RVA: 0x6CF5DE1190 Offset: 0xD8A190 VA: 0x6CF5DE1190
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE1198 Offset: 0xD8A198 VA: 0x6CF5DE1198
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE11D0 Offset: 0xD8A1D0 VA: 0x6CF5DE11D0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ReduceSpreadOverTime>d__79 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE11D8 Offset: 0xD8A1D8 VA: 0x6CF5DE11D8
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE1200 Offset: 0xD8A200 VA: 0x6CF5DE1200
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE1204 Offset: 0xD8A204 VA: 0x6CF5DE1204
	private bool MoveNext() { }

	// RVA: 0x6CF5DE130C Offset: 0xD8A30C VA: 0x6CF5DE130C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE1314 Offset: 0xD8A314 VA: 0x6CF5DE1314
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE134C Offset: 0xD8A34C VA: 0x6CF5DE134C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ReloadCoroutine>d__69 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20
	public bool extraDelay; // 0x28

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE1354 Offset: 0xD8A354 VA: 0x6CF5DE1354
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE137C Offset: 0xD8A37C VA: 0x6CF5DE137C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE1380 Offset: 0xD8A380 VA: 0x6CF5DE1380
	private bool MoveNext() { }

	// RVA: 0x6CF5DE1784 Offset: 0xD8A784 VA: 0x6CF5DE1784
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE178C Offset: 0xD8A78C VA: 0x6CF5DE178C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE17C4 Offset: 0xD8A7C4 VA: 0x6CF5DE17C4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ReloadCoroutineShotGun>d__70 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20
	public bool extraDelay; // 0x28
	private int <bulletsWeNeed>5__2; // 0x2C
	private int <i>5__3; // 0x30

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE17CC Offset: 0xD8A7CC VA: 0x6CF5DE17CC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE17F4 Offset: 0xD8A7F4 VA: 0x6CF5DE17F4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE17F8 Offset: 0xD8A7F8 VA: 0x6CF5DE17F8
	private bool MoveNext() { }

	// RVA: 0x6CF5DE1CFC Offset: 0xD8ACFC VA: 0x6CF5DE1CFC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE1D04 Offset: 0xD8AD04 VA: 0x6CF5DE1D04
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE1D3C Offset: 0xD8AD3C VA: 0x6CF5DE1D3C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ReloadTimes>d__76 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE1D44 Offset: 0xD8AD44 VA: 0x6CF5DE1D44
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE1D6C Offset: 0xD8AD6C VA: 0x6CF5DE1D6C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE1D70 Offset: 0xD8AD70 VA: 0x6CF5DE1D70
	private bool MoveNext() { }

	// RVA: 0x6CF5DE1F78 Offset: 0xD8AF78 VA: 0x6CF5DE1F78
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE1F80 Offset: 0xD8AF80 VA: 0x6CF5DE1F80
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE1FB8 Offset: 0xD8AFB8 VA: 0x6CF5DE1FB8
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <ReloadTimesC4>d__77 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE1FC0 Offset: 0xD8AFC0 VA: 0x6CF5DE1FC0
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE1FE8 Offset: 0xD8AFE8 VA: 0x6CF5DE1FE8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE1FEC Offset: 0xD8AFEC VA: 0x6CF5DE1FEC
	private bool MoveNext() { }

	// RVA: 0x6CF5DE22AC Offset: 0xD8B2AC VA: 0x6CF5DE22AC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE22B4 Offset: 0xD8B2B4 VA: 0x6CF5DE22B4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE22EC Offset: 0xD8B2EC VA: 0x6CF5DE22EC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <TakeInAnimation>d__55 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FPSWeapon <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5DE22F4 Offset: 0xD8B2F4 VA: 0x6CF5DE22F4
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5DE231C Offset: 0xD8B31C VA: 0x6CF5DE231C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5DE2320 Offset: 0xD8B320 VA: 0x6CF5DE2320
	private bool MoveNext() { }

	// RVA: 0x6CF5DE255C Offset: 0xD8B55C VA: 0x6CF5DE255C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5DE2564 Offset: 0xD8B564 VA: 0x6CF5DE2564
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5DE259C Offset: 0xD8B59C VA: 0x6CF5DE259C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FPSWeapon : MonoBehaviour
{
	// Fields

	public WeaponType weaponType; // 0x20
	public MeshRenderer muzzleFlash; // 0x28
	public MeshRenderer muzzleFlash2; // 0x30
	public ParticleSystem Capsules; // 0x38
	public ParticleSystem Fumaca; // 0x40
	public ParticleSystem Capsules2; // 0x48
	public ParticleSystem Fumaca2; // 0x50
	public SkinnedMeshRenderer GrenadeTop; // 0x58
	public SkinnedMeshRenderer FlashTop; // 0x60
	public SkinnedMeshRenderer FlashDown; // 0x68
	public Transform ThrowPoint; // 0x70
	public Transform C4Throw; // 0x78
	public GameObject Grenade; // 0x80
	public GameObject Flash; // 0x88
	public GameObject C4; // 0x90
	public float ForwardThrowForce; // 0x98
	public float UpwardThrowForce; // 0x9C
	public GameObject CounterTag; // 0xA0
	public GameObject TerorTag; // 0xA8
	public Transform[] casingSpawnPoints; // 0xB0
	public Transform casingPrefab; // 0xB8
	public bool ShotGunReload; // 0xC0
	public string weaponName; // 0xC8
	public WeaponSet wSettings; // 0xD0
	public bool isThirdPerson; // 0xD8
	public AudioSource audioSource; // 0xE0
	public bool isReloading; // 0xE8
	public PlayerWeapons playerWeapons; // 0xF0
	public SoldierAnimation soldierAnimation; // 0xF8
	public PlayerNetwork playerNetwork; // 0x100
	public int weaponIndex; // 0x108
	public Vector3 aimOffset; // 0x10C
	public Vector3 defaultPosition; // 0x118
	public FPSAnimations fpsAnimations; // 0x128
	private int bulletRange; // 0x130
	private int knifeRange; // 0x134
	private float nextFireTime; // 0x138
	public Animation animationController; // 0x140
	private bool setupDone; // 0x148
	private bool doneTaking; // 0x149
	private int defaultBulletsPerClip; // 0x14C
	private int defaultReserveBulelts; // 0x150
	private int bulletsLeft; // 0x154
	private int reserveBulletsLeft; // 0x158
	private int animSay; // 0x15C
	private Transform muzzleFlashTransform; // 0x160
	private Transform muzzleFlashTransform2; // 0x168
	public Transform thisT; // 0x170
	public GameObject EliteDual; // 0x178
	private float highestBulletSpread; // 0x180
	private float bulletSpread; // 0x184
	private float timeToSpreadCooldown; // 0x188

	// Properties


	// Methods

	// RVA: 0x6CF5DD237C Offset: 0xD7B37C VA: 0x6CF5DD237C
	public void Deploy() { }

	// RVA: 0x6CF5DD2AA4 Offset: 0xD7BAA4 VA: 0x6CF5DD2AA4
	private IEnumerator TakeInAnimation() { }

	// RVA: 0x6CF5DD2B0C Offset: 0xD7BB0C VA: 0x6CF5DD2B0C
	public void Fire() { }

	// RVA: 0x6CF5DD3B48 Offset: 0xD7CB48 VA: 0x6CF5DD3B48
	public void Fire2() { }

	// RVA: 0x6CF5DD3C34 Offset: 0xD7CC34 VA: 0x6CF5DD3C34
	public void C4Fire2() { }

	// RVA: 0x6CF5DD3DB8 Offset: 0xD7CDB8 VA: 0x6CF5DD3DB8
	public void C4Fire() { }

	// RVA: 0x6CF5DD3E78 Offset: 0xD7CE78 VA: 0x6CF5DD3E78
	public void C4idle2() { }

	// RVA: 0x6CF5DD3F3C Offset: 0xD7CF3C VA: 0x6CF5DD3F3C
	public void C4idle() { }

	// RVA: 0x6CF5DD3FC0 Offset: 0xD7CFC0 VA: 0x6CF5DD3FC0
	private void GrenadeShootm() { }

	// RVA: 0x6CF5DD422C Offset: 0xD7D22C VA: 0x6CF5DD422C
	private void FlashShootm() { }

	// RVA: 0x6CF5DD43FC Offset: 0xD7D3FC VA: 0x6CF5DD43FC
	private void C4Shoot() { }

	// RVA: 0x6CF5DD2CB8 Offset: 0xD7BCB8 VA: 0x6CF5DD2CB8
	private void FireOneShot() { }

	// RVA: 0x6CF5DD4798 Offset: 0xD7D798 VA: 0x6CF5DD4798
	private void ShootBullet(Vector3 firePoint, Vector3 fireDirection) { }

	// RVA: 0x6CF5DD5194 Offset: 0xD7E194 VA: 0x6CF5DD5194
	public void ReloadRemote() { }

	// RVA: 0x6CF5DCCC30 Offset: 0xD75C30 VA: 0x6CF5DCCC30
	public void ReloadNetworkSync() { }

	// RVA: 0x6CF5DD5118 Offset: 0xD7E118 VA: 0x6CF5DD5118
	private IEnumerator ReloadCoroutine(bool extraDelay) { }

	// RVA: 0x6CF5DD509C Offset: 0xD7E09C VA: 0x6CF5DD509C
	private IEnumerator ReloadCoroutineShotGun(bool extraDelay) { }

	// RVA: 0x6CF5DD4590 Offset: 0xD7D590 VA: 0x6CF5DD4590
	private IEnumerator DoMuzzleFlash() { }

	// RVA: 0x6CF5DD4660 Offset: 0xD7D660 VA: 0x6CF5DD4660
	private IEnumerator CasingDelay() { }

	// RVA: 0x6CF5DD45F8 Offset: 0xD7D5F8 VA: 0x6CF5DD45F8
	private IEnumerator DoMuzzleFlash2() { }

	// RVA: 0x6CF5DD46C8 Offset: 0xD7D6C8 VA: 0x6CF5DD46C8
	private IEnumerator BombGrenade() { }

	// RVA: 0x6CF5DD4730 Offset: 0xD7D730 VA: 0x6CF5DD4730
	private IEnumerator FlashBang() { }

	// RVA: 0x6CF5DD5318 Offset: 0xD7E318 VA: 0x6CF5DD5318
	private IEnumerator ReloadTimes() { }

	// RVA: 0x6CF5DD3D50 Offset: 0xD7CD50 VA: 0x6CF5DD3D50
	private IEnumerator ReloadTimesC4() { }

	// RVA: 0x6CF5DD5380 Offset: 0xD7E380 VA: 0x6CF5DD5380
	public bool RefillAmmo() { }

	// RVA: 0x6CF5DD5034 Offset: 0xD7E034 VA: 0x6CF5DD5034
	private IEnumerator ReduceSpreadOverTime() { }

	// RVA: 0x6CF5DD5468 Offset: 0xD7E468 VA: 0x6CF5DD5468
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Grenade : MonoBehaviour
{
	// Fields

	public Collider[] ArroundNear; // 0x20
	public Collider[] Arround; // 0x28
	public float timeLeft; // 0x30
	public Transform particleEffect; // 0x38
	public Rigidbody rb; // 0x40
	public int kilrID; // 0x48
	public AudioClip BomBsound; // 0x50
	public SkinnedMeshRenderer GrenadeTp; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF5DE25A4 Offset: 0xD8B5A4 VA: 0x6CF5DE25A4
	private void Start() { }

	// RVA: 0x6CF5DE263C Offset: 0xD8B63C VA: 0x6CF5DE263C
	private void BombFalse() { }

	// RVA: 0x6CF5DE265C Offset: 0xD8B65C VA: 0x6CF5DE265C
	private void AreaOfEffectDamage(GameObject players) { }

	// RVA: 0x6CF5DE2848 Offset: 0xD8B848 VA: 0x6CF5DE2848
	private void AreaOfEffectLongDamage(GameObject Longplayers) { }

	// RVA: 0x6CF5DE2A34 Offset: 0xD8BA34 VA: 0x6CF5DE2A34
	private void Update() { }

	// RVA: 0x6CF5DE2E20 Offset: 0xD8BE20 VA: 0x6CF5DE2E20
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum FireType
{
	// Fields

	public int value__; // 0x10
	public const FireType MachineGun = 0; // 0x0
	public const FireType Pistol = 1; // 0x0
	public const FireType Shotgun = 2; // 0x0
	public const FireType SniperRifle = 3; // 0x0
	public const FireType Knife = 4; // 0x0
	public const FireType GRENADE_LAUNCHER = 5; // 0x0
	public const FireType MachinePistol = 6; // 0x0
	public const FireType SniperRifleAuto = 7; // 0x0
	public const FireType Dual = 8; // 0x0
	public const FireType m246 = 9; // 0x0
	public const FireType C4 = 10; // 0x0
	public const FireType FlashBang = 11; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum AimType
{
	// Fields

	public int value__; // 0x10
	public const AimType None = 0; // 0x0
	public const AimType CameraOnly = 1; // 0x0
	public const AimType CameraAndIronsights = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class WeaponSet : Object
{
	// Fields

	public FPSWeapon firstPersonWeapon; // 0x10
	public FPSWeapon thirdPersonWeapon; // 0x18
	public int weaponCost; // 0x20
	public FireType fireType; // 0x24
	public float timeToDeploy; // 0x28
	public float reloadTime; // 0x2C
	public float fireRate; // 0x30
	public float clipOutTime; // 0x34
	public float clipInTime; // 0x38
	public float clipPullTime; // 0x3C
	public int bulletsPerClip; // 0x40
	public int reserveBullets; // 0x44
	public int headDamage; // 0x48
	public int torsoDamage; // 0x4C
	public int limbsDamage; // 0x50
	public AudioClip fireSound; // 0x58
	public AudioClip clipOut; // 0x60
	public AudioClip clipIn; // 0x68
	public AudioClip clipPull; // 0x70
	public AudioClip takeInSound; // 0x78
	public AimType aimType; // 0x80
	public float aimFOV; // 0x84
	public Transform aimObject; // 0x88
	public Sprite scopeTexture; // 0x90
	public Texture gunPreview; // 0x98
	public int obfuscatedPrice; // 0xA0
	public bool showThis; // 0xA4

	// Properties


	// Methods

	// RVA: 0x6CF5DE4768 Offset: 0xD8D768 VA: 0x6CF5DE4768
	public void .ctor(FPSWeapon fpw, FPSWeapon tpw) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PlayerWeapons : MonoBehaviour
{
	// Fields

	public Transform playerCamera; // 0x20
	public GameObject concreteParticles; // 0x28
	public GameObject metalParticles; // 0x30
	public GameObject bloodParticles; // 0x38
	public AudioSource firstPersonAudioSource; // 0x40
	public AudioSource thirdPersonAudioSource; // 0x48
	public List`1 primaryWeapons; // 0x50
	public List`1 secondaryWeapons; // 0x58
	public List`1 specialWeapons; // 0x60
	public List`1 Grenade; // 0x68
	public List`1 Flash; // 0x70
	public List`1 C4; // 0x78
	public List`1 totalWeapons; // 0x80
	public int selectedPrimary; // 0x88
	public int selectedSecondary; // 0x8C
	public int selectedSpecial; // 0x90
	public int selectedGrenade; // 0x94
	public int selectedFlash; // 0x98
	public int selectedC4; // 0x9C
	private Vector3 defaultSwayPosition; // 0xA0
	private float bobbingSpeed; // 0xAC
	private float bobbingAmount; // 0xB0
	private float timer; // 0xB4
	private float currentBobbingSpeed; // 0xB8
	private Transform firstPersonWeapons; // 0xC0
	public FPSWeapon currentSelectedWeapon; // 0xC8
	public int globalWeaponIndex; // 0xD0
	public bool isFiring; // 0xD4
	public SoldierAnimation soldierAnimation; // 0xD8
	public PlayerNetwork playerNetwork; // 0xE0
	public FPSController fpsController; // 0xE8
	public Camera mainPlayerCamera; // 0xF0
	private bool isAimed; // 0xF8
	private bool MeC4; // 0xF9
	private int previousWeaponIndex; // 0xFC

	// Properties


	// Methods

	// RVA: 0x6CF5DE2E28 Offset: 0xD8BE28 VA: 0x6CF5DE2E28
	public void QuickSetup(bool isLocal) { }

	// RVA: 0x6CF5DE2F84 Offset: 0xD8BF84 VA: 0x6CF5DE2F84
	private void PrepareWepaons(List`1 tmpWeapons) { }

	// RVA: 0x6CF5DE32E8 Offset: 0xD8C2E8 VA: 0x6CF5DE32E8
	private void BombAfter() { }

	// RVA: 0x6CF5DE3520 Offset: 0xD8C520 VA: 0x6CF5DE3520
	private void Update() { }

	// RVA: 0x6CF5DE4094 Offset: 0xD8D094 VA: 0x6CF5DE4094
	public void GetWeaponToSelect(int type) { }

	// RVA: 0x6CF5DE4160 Offset: 0xD8D160 VA: 0x6CF5DE4160
	private void FixedUpdate() { }

	// RVA: 0x6CF5DE3368 Offset: 0xD8C368 VA: 0x6CF5DE3368
	private void SwitchWeapon(FPSWeapon tmpWeapon, bool firstPerson) { }

	// RVA: 0x6CF5DE4164 Offset: 0xD8D164 VA: 0x6CF5DE4164
	private void DoWeaponBobbing() { }

	// RVA: 0x6CF5DE4314 Offset: 0xD8D314 VA: 0x6CF5DE4314
	public void SwitchWeaponRemote() { }

	// RVA: 0x6CF5DE437C Offset: 0xD8D37C VA: 0x6CF5DE437C
	public void SwitchWeaponC4() { }

	// RVA: 0x6CF5DE43E8 Offset: 0xD8D3E8 VA: 0x6CF5DE43E8
	public void SwitchWeaponGrenade() { }

	// RVA: 0x6CF5DE4450 Offset: 0xD8D450 VA: 0x6CF5DE4450
	public void SwitchWeaponFlash() { }

	// RVA: 0x6CF5DE44B8 Offset: 0xD8D4B8 VA: 0x6CF5DE44B8
	public void SwitchWeaponC4Show() { }

	// RVA: 0x6CF5DE4558 Offset: 0xD8D558 VA: 0x6CF5DE4558
	public void FireRemote() { }

	// RVA: 0x6CF5DE45D8 Offset: 0xD8D5D8 VA: 0x6CF5DE45D8
	public void FireRemoteC4() { }

	// RVA: 0x6CF5DE4658 Offset: 0xD8D658 VA: 0x6CF5DE4658
	public void IdleRemoteC4() { }

	// RVA: 0x6CF5DE46D8 Offset: 0xD8D6D8 VA: 0x6CF5DE46D8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ActionReports : Object
{
	// Fields

	public Text mainText; // 0x10
	public Text textShadow; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5DE482C Offset: 0xD8D82C VA: 0x6CF5DE482C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class TouchMovements : Object
{
	// Fields

	public Image backgroundCircle; // 0x10
	public Image mainButton; // 0x18
	public Rect defaultArea; // 0x20
	public Vector2 touchOffset; // 0x30
	public Vector2 currentTouchPos; // 0x38
	public int touchID; // 0x40
	public bool isActive; // 0x44

	// Properties


	// Methods

	// RVA: 0x6CF5DE4834 Offset: 0xD8D834 VA: 0x6CF5DE4834
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ActionButton : Object
{
	// Fields

	public Image background; // 0x10
	public Image icon; // 0x18
	public Rect mainArea; // 0x20
	public bool isActive; // 0x30
	public int touchID; // 0x34

	// Properties


	// Methods

	// RVA: 0x6CF5DE483C Offset: 0xD8D83C VA: 0x6CF5DE483C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class customcontrols : MonoBehaviour
{
	// Fields

	public Vector2 Pozisyon; // 0x20
	public Sprite whiteTexture; // 0x28
	public Sprite hitDetectorTexture; // 0x30
	public Sprite hpTexture; // 0x38
	public Sprite buyTexture; // 0x40
	public Sprite bombTexture; // 0x48
	public Sprite timeTexture; // 0x50
	public Sprite shieldTexture; // 0x58
	public Sprite roundTexture; // 0x60
	public Sprite roundFFATexture; // 0x68
	public Sprite roundBombTexture; // 0x70
	public Sprite Bomb; // 0x78
	public Sprite BombBorder; // 0x80
	private Image sniperScope; // 0x88
	private float scopeTextureRatio; // 0x90
	private Sprite scopeTextureTmp; // 0x98
	public ActionReports[] actionReports; // 0xA0
	public ActionReports[] actionWeaponsReports; // 0xA8
	public ActionReports[] chatMessages; // 0xB0
	private ActionReports respawnTimeText; // 0xB8
	private ActionReports buyMenuText; // 0xC0
	private ActionReports shieldText; // 0xC8
	private GameObject crosshairRoot; // 0xD0
	private Image[] crosshairSet; // 0xD8
	private Image redScreen; // 0xE0
	private Image canRes; // 0xE8
	private Image timeRes; // 0xF0
	private Image shieldRes; // 0xF8
	private Image shopBuyT; // 0x100
	private Image roundHow; // 0x108
	private Image roundHowFFA; // 0x110
	private Image roundBomb; // 0x118
	private Image roundBombIcon; // 0x120
	private Image BombI; // 0x128
	private Image BombBorderI; // 0x130
	private Image FlashImage; // 0x138
	private CanvasGroup FlashCanvas; // 0x140
	private Image[] hitDetectorSet; // 0x148
	private bool previousHitDetector; // 0x150
	private Canvas mainCanvas; // 0x158
	private Text roundTimeText; // 0x160
	private Text roundCounterText; // 0x168
	private Text roundCounterScoreText; // 0x170
	private Text roundTerorText; // 0x178
	private Text roundTerorScoreText; // 0x180
	private Text HPText; // 0x188
	private Text cashText; // 0x190
	private Text KillText; // 0x198
	private Text addMoreCashText; // 0x1A0
	private Text weaponAndAmmoText; // 0x1A8
	private Text killedShowText; // 0x1B0
	private Outline KilledOut; // 0x1B8
	public Sprite navigationCircle; // 0x1C0
	public Sprite navigationButton; // 0x1C8
	public Sprite navigationSke; // 0x1D0
	public Sprite gunFireIcon; // 0x1D8
	public Sprite gunReloadIcon; // 0x1E0
	public Sprite gunAimIcon; // 0x1E8
	public Sprite jumpIcon; // 0x1F0
	public Sprite crouchIcon; // 0x1F8
	public Sprite switchWeaponIcon; // 0x200
	public Sprite C4Icon; // 0x208
	public Sprite C4IconBack; // 0x210
	public Sprite DiffuseIcon; // 0x218
	public Sprite GrenadeIcon; // 0x220
	public Sprite FlashIcon; // 0x228
	private TouchMovements moveTouch; // 0x230
	private TouchMovements fpsLookTouch; // 0x238
	private ActionButton fireButton; // 0x240
	private ActionButton reloadButton; // 0x248
	private ActionButton aimButton; // 0x250
	private ActionButton jumpButton; // 0x258
	private ActionButton crouchButton; // 0x260
	private ActionButton c4Button; // 0x268
	private ActionButton DiffuseButton; // 0x270
	private ActionButton GrenadeButton; // 0x278
	private ActionButton FlashButton; // 0x280
	private ActionButton switchWeaponButton; // 0x288
	public GameObject Menuyoket; // 0x290

	// Properties


	// Methods

	// RVA: 0x6CF5DD54FC Offset: 0xD7E4FC VA: 0x6CF5DD54FC
	private void Awake() { }

	// RVA: 0x6CF5DD5584 Offset: 0xD7E584 VA: 0x6CF5DD5584
	private void Start() { }

	// RVA: 0x6CF5DDE294 Offset: 0xD87294 VA: 0x6CF5DDE294
	private void Update() { }

	// RVA: 0x6CF5DE03A8 Offset: 0xD893A8 VA: 0x6CF5DE03A8
	public void BackMenu() { }

	// RVA: 0x6CF5DDFE7C Offset: 0xD88E7C VA: 0x6CF5DDFE7C
	private void MobileButtonStop(int touchID) { }

	// RVA: 0x6CF5DDEEB0 Offset: 0xD87EB0 VA: 0x6CF5DDEEB0
	private void MobileButtonsCheck(Vector2 touchPos, int touchID) { }

	// RVA: 0x6CF5DD5588 Offset: 0xD7E588 VA: 0x6CF5DD5588
	private void InitGui() { }

	// RVA: 0x6CF5DE0404 Offset: 0xD89404 VA: 0x6CF5DE0404
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class IntegrationDailyRewards : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5DE4844 Offset: 0xD8D844 VA: 0x6CF5DE4844
	private void OnEnable() { }

	// RVA: 0x6CF5DE492C Offset: 0xD8D92C VA: 0x6CF5DE492C
	private void OnDisable() { }

	// RVA: 0x6CF5DE4A14 Offset: 0xD8DA14 VA: 0x6CF5DE4A14
	public void OnClaimPrizeDailyRewards(int day) { }

	// RVA: 0x6CF5DE4ABC Offset: 0xD8DABC VA: 0x6CF5DE4ABC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class IntegrationTimedRewards : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5DE4AC4 Offset: 0xD8DAC4 VA: 0x6CF5DE4AC4
	private void OnEnable() { }

	// RVA: 0x6CF5DE4BA8 Offset: 0xD8DBA8 VA: 0x6CF5DE4BA8
	private void OnDisable() { }

	// RVA: 0x6CF5DE4C8C Offset: 0xD8DC8C VA: 0x6CF5DE4C8C
	public void OnClaimPrizeTimedRewards(int index) { }

	// RVA: 0x6CF5DE4D34 Offset: 0xD8DD34 VA: 0x6CF5DE4D34
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class DeviceIDManager : MonoBehaviour
{
	// Fields

	private const string DeviceIdKey; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DE4D3C Offset: 0xD8DD3C VA: 0x6CF5DE4D3C
	public string GetDeviceID() { }

	// RVA: 0x6CF5DE4DD4 Offset: 0xD8DDD4 VA: 0x6CF5DE4DD4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class GPGSIds : Object
{
	// Fields

	public const string leaderboard_season_2; // 0x0
	public const string leaderboard_ranking; // 0x0
	public const string achievement_welcome_to_counter_combat_online; // 0x0
	public const string leaderboard_user_ranking; // 0x0
	public const string achievement_welcome_to_counter_terrorist_gun_strike; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class KickManager : MonoBehaviour
{
	// Fields

	private static KickManager _instance; // 0x0
	private List`1 bannedPlayers; // 0x28

	// Properties

	public static KickManager Instance { get; }

	// Methods

	// RVA: 0x6CF5DE4DDC Offset: 0xD8DDDC VA: 0x6CF5DE4DDC
	public static KickManager get_Instance() { }

	// RVA: 0x6CF5DE4F30 Offset: 0xD8DF30 VA: 0x6CF5DE4F30
	private void Awake() { }

	// RVA: 0x6CF5DE5060 Offset: 0xD8E060 VA: 0x6CF5DE5060
	private void Start() { }

	// RVA: 0x6CF5DE51F0 Offset: 0xD8E1F0 VA: 0x6CF5DE51F0
	public void ConnectWithCustomAuth(string userId) { }

	// RVA: 0x6CF5DE52B4 Offset: 0xD8E2B4 VA: 0x6CF5DE52B4
	private void OnJoinedRoom() { }

	// RVA: 0x6CF5DE5364 Offset: 0xD8E364 VA: 0x6CF5DE5364
	private void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5DE52B8 Offset: 0xD8E2B8 VA: 0x6CF5DE52B8
	private void CheckAndKickBannedPlayers() { }

	// RVA: 0x6CF5DE538C Offset: 0xD8E38C VA: 0x6CF5DE538C
	private void CheckAndKickBannedPlayer(PhotonPlayer player) { }

	// RVA: 0x6CF5DE5544 Offset: 0xD8E544 VA: 0x6CF5DE5544
	public void AddPlayerToBanList(string nickname) { }

	// RVA: 0x6CF5DE581C Offset: 0xD8E81C VA: 0x6CF5DE581C
	public void RemovePlayerFromBanList(string nickname) { }

	// RVA: 0x6CF5DE56B0 Offset: 0xD8E6B0 VA: 0x6CF5DE56B0
	private string GetUserIdByNickname(string nickname) { }

	// RVA: 0x6CF5DE5774 Offset: 0xD8E774 VA: 0x6CF5DE5774
	private void SaveBannedPlayers() { }

	// RVA: 0x6CF5DE510C Offset: 0xD8E10C VA: 0x6CF5DE510C
	private void LoadBannedPlayers() { }

	// RVA: 0x6CF5DE58CC Offset: 0xD8E8CC VA: 0x6CF5DE58CC
	public void ClearBannedPlayers() { }

	// RVA: 0x6CF5DE54EC Offset: 0xD8E4EC VA: 0x6CF5DE54EC
	public bool IsPlayerBanned(string userID) { }

	// RVA: 0x6CF5DE5938 Offset: 0xD8E938 VA: 0x6CF5DE5938
	private void CheckAndKickUnauthorizedPlayers() { }

	// RVA: 0x6CF5DE540C Offset: 0xD8E40C VA: 0x6CF5DE540C
	private void CheckAndKickUnauthorizedPlayer(PhotonPlayer player) { }

	// RVA: 0x6CF5DE5D1C Offset: 0xD8ED1C VA: 0x6CF5DE5D1C
	private bool IsAuthenticated(PhotonPlayer player) { }

	// RVA: 0x6CF5DE59E4 Offset: 0xD8E9E4 VA: 0x6CF5DE59E4
	private bool IsEmulator() { }

	// RVA: 0x6CF5DE5D60 Offset: 0xD8ED60 VA: 0x6CF5DE5D60
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class LevelSystem : MonoBehaviour
{
	// Fields

	private ObscuredInt level; // 0x20
	public static ObscuredBool exp100; // 0x0
	public static ObscuredBool exp200; // 0xC
	public static ObscuredBool exp5; // 0x18
	private ObscuredDouble currentExp; // 0x38
	private ObscuredBool cheat; // 0x68
	private ObscuredDouble maxExp; // 0x78
	private ObscuredInt multiplyAmount; // 0xA8
	public Slider xpBar; // 0xC0
	public Text levelText; // 0xC8
	public Text xpText; // 0xD0

	// Properties


	// Methods

	// RVA: 0x6CF5DE5DDC Offset: 0xD8EDDC VA: 0x6CF5DE5DDC
	public void UpdateUI(int level, double currentXp, double maxXp) { }

	// RVA: 0x6CF5DE5F04 Offset: 0xD8EF04 VA: 0x6CF5DE5F04
	public void Start() { }

	// RVA: 0x6CF5DE6D3C Offset: 0xD8FD3C VA: 0x6CF5DE6D3C
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5DE6DA0 Offset: 0xD8FDA0 VA: 0x6CF5DE6DA0
	private void Update() { }

	// RVA: 0x6CF5DE6E40 Offset: 0xD8FE40 VA: 0x6CF5DE6E40
	public void CalculateXp() { }

	// RVA: 0x6CF5DE7008 Offset: 0xD90008 VA: 0x6CF5DE7008
	public void AddExp(double amount) { }

	// RVA: 0x6CF5DE70D0 Offset: 0xD900D0 VA: 0x6CF5DE70D0
	public void AddExp5() { }

	// RVA: 0x6CF5DE6714 Offset: 0xD8F714 VA: 0x6CF5DE6714
	public void CheckLevelUp() { }

	// RVA: 0x6CF5DE6A38 Offset: 0xD8FA38 VA: 0x6CF5DE6A38
	public void SavePlayerPrefs() { }

	// RVA: 0x6CF5DE643C Offset: 0xD8F43C VA: 0x6CF5DE643C
	public void LoadPlayerPrefs() { }

	// RVA: 0x6CF5DE70D4 Offset: 0xD900D4 VA: 0x6CF5DE70D4
	public void .ctor() { }

	// RVA: 0x6CF5DE7214 Offset: 0xD90214 VA: 0x6CF5DE7214
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class LevelSystemGUI : MonoBehaviour
{
	// Fields

	public Slider xpBar; // 0x20
	public InputField amountToAdd; // 0x28
	public Text levelText; // 0x30
	public Text xpText; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5DE72C8 Offset: 0xD902C8 VA: 0x6CF5DE72C8
	public void UpdateUI(int level, double currentXp, double maxXp) { }

	// RVA: 0x6CF5DE73F0 Offset: 0xD903F0 VA: 0x6CF5DE73F0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Action`1 <>9__14_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF5DE7EF4 Offset: 0xD90EF4 VA: 0x6CF5DE7EF4
	private static void .cctor() { }

	// RVA: 0x6CF5DE7F50 Offset: 0xD90F50 VA: 0x6CF5DE7F50
	public void .ctor() { }

	// RVA: 0x6CF5DE7F58 Offset: 0xD90F58 VA: 0x6CF5DE7F58
	internal void <UnlockNewPlayerAchi>b__14_0(bool success) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Menuscript : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public GameObject StatsPanel; // 0x30
	public Text Kills; // 0x38
	public Text Deaths; // 0x40
	public Text Headshots; // 0x48
	public Text Playtime; // 0x50
	private List`1 bannedPlayers; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF5DE73F8 Offset: 0xD903F8 VA: 0x6CF5DE73F8
	private void Start() { }

	// RVA: 0x6CF5DE75DC Offset: 0xD905DC VA: 0x6CF5DE75DC
	public void ClearBannedPlayers() { }

	// RVA: 0x6CF5DE7628 Offset: 0xD90628 VA: 0x6CF5DE7628
	public void PlayerStats() { }

	// RVA: 0x6CF5DE7944 Offset: 0xD90944 VA: 0x6CF5DE7944
	public void PlayerstatPanelClose() { }

	// RVA: 0x6CF5DE7964 Offset: 0xD90964 VA: 0x6CF5DE7964
	public void CustomizeControls() { }

	// RVA: 0x6CF5DE79B8 Offset: 0xD909B8 VA: 0x6CF5DE79B8
	public void OnUserClickPrivacyPolicy() { }

	// RVA: 0x6CF5DE74F8 Offset: 0xD904F8 VA: 0x6CF5DE74F8
	private void AchievementCheck() { }

	// RVA: 0x6CF5DE7A20 Offset: 0xD90A20 VA: 0x6CF5DE7A20
	private void UnlockNewPlayerAchi() { }

	// RVA: 0x6CF5DE7B44 Offset: 0xD90B44 VA: 0x6CF5DE7B44
	public void Leaderboard() { }

	// RVA: 0x6CF5DE7BDC Offset: 0xD90BDC VA: 0x6CF5DE7BDC
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5DE7C40 Offset: 0xD90C40 VA: 0x6CF5DE7C40
	private void Update() { }

	// RVA: 0x6CF5DE7CE0 Offset: 0xD90CE0 VA: 0x6CF5DE7CE0
	public void .ctor() { }

	// RVA: 0x6CF5DE7D8C Offset: 0xD90D8C VA: 0x6CF5DE7D8C
	private void <AchievementCheck>b__13_0(IAchievement[] achievements) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal static class CustomTypes : Object
{
	// Fields

	public static readonly Byte[] memVector3; // 0x0
	public static readonly Byte[] memVector2; // 0x8
	public static readonly Byte[] memQuarternion; // 0x10
	public static readonly Byte[] memPlayer; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5DE7FC0 Offset: 0xD90FC0 VA: 0x6CF5DE7FC0
	internal static void Register() { }

	// RVA: 0x6CF5DE82F8 Offset: 0xD912F8 VA: 0x6CF5DE82F8
	private static short SerializeVector3(StreamBuffer outStream, object customobject) { }

	// RVA: 0x6CF5DE8508 Offset: 0xD91508 VA: 0x6CF5DE8508
	private static object DeserializeVector3(StreamBuffer inStream, short length) { }

	// RVA: 0x6CF5DE8718 Offset: 0xD91718 VA: 0x6CF5DE8718
	private static short SerializeVector2(StreamBuffer outStream, object customobject) { }

	// RVA: 0x6CF5DE8908 Offset: 0xD91908 VA: 0x6CF5DE8908
	private static object DeserializeVector2(StreamBuffer inStream, short length) { }

	// RVA: 0x6CF5DE8AE8 Offset: 0xD91AE8 VA: 0x6CF5DE8AE8
	private static short SerializeQuaternion(StreamBuffer outStream, object customobject) { }

	// RVA: 0x6CF5DE8D14 Offset: 0xD91D14 VA: 0x6CF5DE8D14
	private static object DeserializeQuaternion(StreamBuffer inStream, short length) { }

	// RVA: 0x6CF5DE8F34 Offset: 0xD91F34 VA: 0x6CF5DE8F34
	private static short SerializePhotonPlayer(StreamBuffer outStream, object customobject) { }

	// RVA: 0x6CF5DE9110 Offset: 0xD92110 VA: 0x6CF5DE9110
	private static object DeserializePhotonPlayer(StreamBuffer inStream, short length) { }

	// RVA: 0x6CF5DE935C Offset: 0xD9235C VA: 0x6CF5DE935C
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum PhotonNetworkingMessage
{
	// Fields

	public int value__; // 0x10
	public const PhotonNetworkingMessage OnConnectedToPhoton = 0; // 0x0
	public const PhotonNetworkingMessage OnLeftRoom = 1; // 0x0
	public const PhotonNetworkingMessage OnMasterClientSwitched = 2; // 0x0
	public const PhotonNetworkingMessage OnPhotonCreateRoomFailed = 3; // 0x0
	public const PhotonNetworkingMessage OnPhotonJoinRoomFailed = 4; // 0x0
	public const PhotonNetworkingMessage OnCreatedRoom = 5; // 0x0
	public const PhotonNetworkingMessage OnJoinedLobby = 6; // 0x0
	public const PhotonNetworkingMessage OnLeftLobby = 7; // 0x0
	public const PhotonNetworkingMessage OnDisconnectedFromPhoton = 8; // 0x0
	public const PhotonNetworkingMessage OnConnectionFail = 9; // 0x0
	public const PhotonNetworkingMessage OnFailedToConnectToPhoton = 10; // 0x0
	public const PhotonNetworkingMessage OnReceivedRoomListUpdate = 11; // 0x0
	public const PhotonNetworkingMessage OnJoinedRoom = 12; // 0x0
	public const PhotonNetworkingMessage OnPhotonPlayerConnected = 13; // 0x0
	public const PhotonNetworkingMessage OnPhotonPlayerDisconnected = 14; // 0x0
	public const PhotonNetworkingMessage OnPhotonRandomJoinFailed = 15; // 0x0
	public const PhotonNetworkingMessage OnConnectedToMaster = 16; // 0x0
	public const PhotonNetworkingMessage OnPhotonSerializeView = 17; // 0x0
	public const PhotonNetworkingMessage OnPhotonInstantiate = 18; // 0x0
	public const PhotonNetworkingMessage OnPhotonMaxCccuReached = 19; // 0x0
	public const PhotonNetworkingMessage OnPhotonCustomRoomPropertiesChanged = 20; // 0x0
	public const PhotonNetworkingMessage OnPhotonPlayerPropertiesChanged = 21; // 0x0
	public const PhotonNetworkingMessage OnUpdatedFriendList = 22; // 0x0
	public const PhotonNetworkingMessage OnCustomAuthenticationFailed = 23; // 0x0
	public const PhotonNetworkingMessage OnCustomAuthenticationResponse = 24; // 0x0
	public const PhotonNetworkingMessage OnWebRpcResponse = 25; // 0x0
	public const PhotonNetworkingMessage OnOwnershipRequest = 26; // 0x0
	public const PhotonNetworkingMessage OnLobbyStatisticsUpdate = 27; // 0x0
	public const PhotonNetworkingMessage OnPhotonPlayerActivityChanged = 28; // 0x0
	public const PhotonNetworkingMessage OnOwnershipTransfered = 29; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum PhotonLogLevel
{
	// Fields

	public int value__; // 0x10
	public const PhotonLogLevel ErrorsOnly = 0; // 0x0
	public const PhotonLogLevel Informational = 1; // 0x0
	public const PhotonLogLevel Full = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum PhotonTargets
{
	// Fields

	public int value__; // 0x10
	public const PhotonTargets All = 0; // 0x0
	public const PhotonTargets Others = 1; // 0x0
	public const PhotonTargets MasterClient = 2; // 0x0
	public const PhotonTargets AllBuffered = 3; // 0x0
	public const PhotonTargets OthersBuffered = 4; // 0x0
	public const PhotonTargets AllViaServer = 5; // 0x0
	public const PhotonTargets AllBufferedViaServer = 6; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum CloudRegionCode
{
	// Fields

	public int value__; // 0x10
	public const CloudRegionCode eu = 0; // 0x0
	public const CloudRegionCode us = 1; // 0x0
	public const CloudRegionCode asia = 2; // 0x0
	public const CloudRegionCode jp = 3; // 0x0
	public const CloudRegionCode au = 5; // 0x0
	public const CloudRegionCode usw = 6; // 0x0
	public const CloudRegionCode sa = 7; // 0x0
	public const CloudRegionCode cae = 8; // 0x0
	public const CloudRegionCode kr = 9; // 0x0
	public const CloudRegionCode in = 10; // 0x0
	public const CloudRegionCode ru = 11; // 0x0
	public const CloudRegionCode rue = 12; // 0x0
	public const CloudRegionCode none = 4; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum CloudRegionFlag
{
	// Fields

	public int value__; // 0x10
	public const CloudRegionFlag eu = 1; // 0x0
	public const CloudRegionFlag us = 2; // 0x0
	public const CloudRegionFlag asia = 4; // 0x0
	public const CloudRegionFlag jp = 8; // 0x0
	public const CloudRegionFlag au = 16; // 0x0
	public const CloudRegionFlag usw = 32; // 0x0
	public const CloudRegionFlag sa = 64; // 0x0
	public const CloudRegionFlag cae = 128; // 0x0
	public const CloudRegionFlag kr = 256; // 0x0
	public const CloudRegionFlag in = 512; // 0x0
	public const CloudRegionFlag ru = 1024; // 0x0
	public const CloudRegionFlag rue = 2048; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ConnectionState
{
	// Fields

	public int value__; // 0x10
	public const ConnectionState Disconnected = 0; // 0x0
	public const ConnectionState Connecting = 1; // 0x0
	public const ConnectionState Connected = 2; // 0x0
	public const ConnectionState Disconnecting = 3; // 0x0
	public const ConnectionState InitializingApplication = 4; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum EncryptionMode
{
	// Fields

	public int value__; // 0x10
	public const EncryptionMode PayloadEncryption = 0; // 0x0
	public const EncryptionMode DatagramEncryption = 10; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class EncryptionDataParameters : Object
{
	// Fields

	public const byte Mode; // 0x0
	public const byte Secret1; // 0x0
	public const byte Secret2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class Extensions : Object
{
	// Fields

	public static Dictionary`2 ParametersOfMethods; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DE940C Offset: 0xD9240C VA: 0x6CF5DE940C
	public static ParameterInfo[] GetCachedParemeters(MethodInfo mo) { }

	// RVA: 0x6CF5DE950C Offset: 0xD9250C VA: 0x6CF5DE950C
	public static PhotonView[] GetPhotonViewsInChildren(GameObject go) { }

	// RVA: 0x6CF5DE9560 Offset: 0xD92560 VA: 0x6CF5DE9560
	public static PhotonView GetPhotonView(GameObject go) { }

	// RVA: 0x6CF5DE95B0 Offset: 0xD925B0 VA: 0x6CF5DE95B0
	public static bool AlmostEquals(Vector3 target, Vector3 second, float sqrMagnitudePrecision) { }

	// RVA: 0x6CF5DE95DC Offset: 0xD925DC VA: 0x6CF5DE95DC
	public static bool AlmostEquals(Vector2 target, Vector2 second, float sqrMagnitudePrecision) { }

	// RVA: 0x6CF5DE95FC Offset: 0xD925FC VA: 0x6CF5DE95FC
	public static bool AlmostEquals(Quaternion target, Quaternion second, float maxAngle) { }

	// RVA: 0x6CF5DE966C Offset: 0xD9266C VA: 0x6CF5DE966C
	public static bool AlmostEquals(float target, float second, float floatDiff) { }

	// RVA: 0x6CF5DE967C Offset: 0xD9267C VA: 0x6CF5DE967C
	public static void Merge(IDictionary target, IDictionary addHash) { }

	// RVA: 0x6CF5DE9ABC Offset: 0xD92ABC VA: 0x6CF5DE9ABC
	public static void MergeStringKeys(IDictionary target, IDictionary addHash) { }

	// RVA: 0x6CF5DE9F2C Offset: 0xD92F2C VA: 0x6CF5DE9F2C
	public static string ToStringFull(IDictionary origin) { }

	// RVA: 0x6CF5DE9F88 Offset: 0xD92F88 VA: 0x6CF5DE9F88
	public static string ToStringFull(Object[] data) { }

	// RVA: 0x6CF5DEA0B0 Offset: 0xD930B0 VA: 0x6CF5DEA0B0
	public static Hashtable StripToStringKeys(IDictionary original) { }

	// RVA: 0x6CF5DEA4DC Offset: 0xD934DC VA: 0x6CF5DEA4DC
	public static void StripKeysWithNullValues(IDictionary original) { }

	// RVA: 0x6CF5DEAA18 Offset: 0xD93A18 VA: 0x6CF5DEAA18
	public static bool Contains(Int32[] target, int nr) { }

	// RVA: 0x6CF5DEAA70 Offset: 0xD93A70 VA: 0x6CF5DEAA70
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class GameObjectExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5DEAAFC Offset: 0xD93AFC VA: 0x6CF5DEAAFC
	public static bool GetActive(GameObject target) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FriendInfo : Object
{
	// Fields

	private string <UserId>k__BackingField; // 0x10
	private bool <IsOnline>k__BackingField; // 0x18
	private string <Room>k__BackingField; // 0x20

	// Properties

	public string Name { get; }
	public string UserId { get; set; }
	public bool IsOnline { get; set; }
	public string Room { get; set; }
	public bool IsInRoom { get; }

	// Methods

	// RVA: 0x6CF5DEAB10 Offset: 0xD93B10 VA: 0x6CF5DEAB10
	public string get_Name() { }

	// RVA: 0x6CF5DEAB18 Offset: 0xD93B18 VA: 0x6CF5DEAB18
	public string get_UserId() { }

	// RVA: 0x6CF5DEAB20 Offset: 0xD93B20 VA: 0x6CF5DEAB20
	protected internal void set_UserId(string value) { }

	// RVA: 0x6CF5DEAB28 Offset: 0xD93B28 VA: 0x6CF5DEAB28
	public bool get_IsOnline() { }

	// RVA: 0x6CF5DEAB30 Offset: 0xD93B30 VA: 0x6CF5DEAB30
	protected internal void set_IsOnline(bool value) { }

	// RVA: 0x6CF5DEAB3C Offset: 0xD93B3C VA: 0x6CF5DEAB3C
	public string get_Room() { }

	// RVA: 0x6CF5DEAB44 Offset: 0xD93B44 VA: 0x6CF5DEAB44
	protected internal void set_Room(string value) { }

	// RVA: 0x6CF5DEAB4C Offset: 0xD93B4C VA: 0x6CF5DEAB4C
	public bool get_IsInRoom() { }

	// RVA: 0x6CF5DEAB74 Offset: 0xD93B74 VA: 0x6CF5DEAB74
	public override string ToString() { }

	// RVA: 0x6CF5DEAC30 Offset: 0xD93C30 VA: 0x6CF5DEAC30
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private enum RoomOptionBit
{
	// Fields

	public int value__; // 0x10
	public const RoomOptionBit CheckUserOnJoin = 1; // 0x0
	public const RoomOptionBit DeleteCacheOnLeave = 2; // 0x0
	public const RoomOptionBit SuppressRoomEvents = 4; // 0x0
	public const RoomOptionBit PublishUserId = 8; // 0x0
	public const RoomOptionBit DeleteNullProps = 16; // 0x0
	public const RoomOptionBit BroadcastPropsChangeToAll = 32; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class LoadBalancingPeer : PhotonPeer
{
	// Fields

	private readonly Dictionary`2 opParameters; // 0xE8

	// Properties

	internal bool IsProtocolSecure { get; }

	// Methods

	// RVA: 0x6CF5DEAC38 Offset: 0xD93C38 VA: 0x6CF5DEAC38
	internal bool get_IsProtocolSecure() { }

	// RVA: 0x6CF5DEAC58 Offset: 0xD93C58 VA: 0x6CF5DEAC58
	public void .ctor(ConnectionProtocol protocolType) { }

	// RVA: 0x6CF5DEAD08 Offset: 0xD93D08 VA: 0x6CF5DEAD08
	public void .ctor(IPhotonPeerListener listener, ConnectionProtocol protocolType) { }

	// RVA: 0x6CF5DEAD78 Offset: 0xD93D78 VA: 0x6CF5DEAD78
	public virtual bool OpGetRegions(string appId) { }

	// RVA: 0x6CF5DEAE88 Offset: 0xD93E88 VA: 0x6CF5DEAE88
	public virtual bool OpJoinLobby(TypedLobby lobby) { }

	// RVA: 0x6CF5DEB0A4 Offset: 0xD940A4 VA: 0x6CF5DEB0A4
	public virtual bool OpLeaveLobby() { }

	// RVA: 0x6CF5DEB1BC Offset: 0xD941BC VA: 0x6CF5DEB1BC
	private void RoomOptionsToOpParameters(Dictionary`2 op, RoomOptions roomOptions) { }

	// RVA: 0x6CF5DEB6A0 Offset: 0xD946A0 VA: 0x6CF5DEB6A0
	public virtual bool OpCreateRoom(EnterRoomParams opParams) { }

	// RVA: 0x6CF5DEB984 Offset: 0xD94984 VA: 0x6CF5DEB984
	public virtual bool OpJoinRoom(EnterRoomParams opParams) { }

	// RVA: 0x6CF5DEBCDC Offset: 0xD94CDC VA: 0x6CF5DEBCDC
	public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) { }

	// RVA: 0x6CF5DEC058 Offset: 0xD95058 VA: 0x6CF5DEC058
	public virtual bool OpLeaveRoom(bool becomeInactive) { }

	// RVA: 0x6CF5DEC180 Offset: 0xD95180 VA: 0x6CF5DEC180
	public virtual bool OpGetGameList(TypedLobby lobby, string queryData) { }

	// RVA: 0x6CF5DEC490 Offset: 0xD95490 VA: 0x6CF5DEC490
	public virtual bool OpFindFriends(String[] friendsToFind, FindFriendsOptions options) { }

	// RVA: 0x6CF5DEC628 Offset: 0xD95628 VA: 0x6CF5DEC628
	public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties) { }

	// RVA: 0x6CF5DEC6A4 Offset: 0xD956A4 VA: 0x6CF5DEC6A4
	protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties, bool webForward) { }

	// RVA: 0x6CF5DECA00 Offset: 0xD95A00 VA: 0x6CF5DECA00
	protected internal void OpSetPropertyOfRoom(byte propCode, object value) { }

	// RVA: 0x6CF5DECD38 Offset: 0xD95D38 VA: 0x6CF5DECD38
	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties, bool broadcast, byte channelId) { }

	// RVA: 0x6CF5DECDAC Offset: 0xD95DAC VA: 0x6CF5DECDAC
	public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties, bool webForward) { }

	// RVA: 0x6CF5DECAC0 Offset: 0xD95AC0 VA: 0x6CF5DECAC0
	protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties, bool webForward) { }

	// RVA: 0x6CF5DECE3C Offset: 0xD95E3C VA: 0x6CF5DECE3C
	public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics) { }

	// RVA: 0x6CF5DED2F0 Offset: 0xD962F0 VA: 0x6CF5DED2F0
	public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol) { }

	// RVA: 0x6CF5DED764 Offset: 0xD96764 VA: 0x6CF5DED764
	public virtual bool OpChangeGroups(Byte[] groupsToRemove, Byte[] groupsToAdd) { }

	// RVA: 0x6CF5DED914 Offset: 0xD96914 VA: 0x6CF5DED914
	public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions) { }

	// RVA: 0x6CF5DEDBB0 Offset: 0xD96BB0 VA: 0x6CF5DEDBB0
	public virtual bool OpSettings(bool receiveLobbyStats) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class OpJoinRandomRoomParams : Object
{
	// Fields

	public Hashtable ExpectedCustomRoomProperties; // 0x10
	public byte ExpectedMaxPlayers; // 0x18
	public MatchmakingMode MatchingType; // 0x19
	public TypedLobby TypedLobby; // 0x20
	public string SqlLobbyFilter; // 0x28
	public String[] ExpectedUsers; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5DEDD90 Offset: 0xD96D90 VA: 0x6CF5DEDD90
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class EnterRoomParams : Object
{
	// Fields

	public string RoomName; // 0x10
	public RoomOptions RoomOptions; // 0x18
	public TypedLobby Lobby; // 0x20
	public Hashtable PlayerProperties; // 0x28
	public bool OnGameServer; // 0x30
	public bool CreateIfNotExists; // 0x31
	public bool RejoinOnly; // 0x32
	public String[] ExpectedUsers; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5DEDD98 Offset: 0xD96D98 VA: 0x6CF5DEDD98
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ErrorCode : Object
{
	// Fields

	public const int Ok; // 0x0
	public const int OperationNotAllowedInCurrentState; // 0x0
	public const int InvalidOperationCode; // 0x0
	public const int InvalidOperation; // 0x0
	public const int InternalServerError; // 0x0
	public const int InvalidAuthentication; // 0x0
	public const int GameIdAlreadyExists; // 0x0
	public const int GameFull; // 0x0
	public const int GameClosed; // 0x0
	public const int AlreadyMatched; // 0x0
	public const int ServerFull; // 0x0
	public const int UserBlocked; // 0x0
	public const int NoRandomMatchFound; // 0x0
	public const int GameDoesNotExist; // 0x0
	public const int MaxCcuReached; // 0x0
	public const int InvalidRegion; // 0x0
	public const int CustomAuthenticationFailed; // 0x0
	public const int AuthenticationTicketExpired; // 0x0
	public const int PluginReportedError; // 0x0
	public const int PluginMismatch; // 0x0
	public const int JoinFailedPeerAlreadyJoined; // 0x0
	public const int JoinFailedFoundInactiveJoiner; // 0x0
	public const int JoinFailedWithRejoinerNotFound; // 0x0
	public const int JoinFailedFoundExcludedUserId; // 0x0
	public const int JoinFailedFoundActiveJoiner; // 0x0
	public const int HttpLimitReached; // 0x0
	public const int ExternalHttpCallFailed; // 0x0
	public const int SlotError; // 0x0
	public const int InvalidEncryptionParameters; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDA8 Offset: 0xD96DA8 VA: 0x6CF5DEDDA8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ActorProperties : Object
{
	// Fields

	public const byte PlayerName; // 0x0
	public const byte IsInactive; // 0x0
	public const byte UserId; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDB0 Offset: 0xD96DB0 VA: 0x6CF5DEDDB0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class GamePropertyKey : Object
{
	// Fields

	public const byte MaxPlayers; // 0x0
	public const byte IsVisible; // 0x0
	public const byte IsOpen; // 0x0
	public const byte PlayerCount; // 0x0
	public const byte Removed; // 0x0
	public const byte PropsListedInLobby; // 0x0
	public const byte CleanupCacheOnLeave; // 0x0
	public const byte MasterClientId; // 0x0
	public const byte ExpectedUsers; // 0x0
	public const byte PlayerTtl; // 0x0
	public const byte EmptyRoomTtl; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDB8 Offset: 0xD96DB8 VA: 0x6CF5DEDDB8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class EventCode : Object
{
	// Fields

	public const byte GameList; // 0x0
	public const byte GameListUpdate; // 0x0
	public const byte QueueState; // 0x0
	public const byte Match; // 0x0
	public const byte AppStats; // 0x0
	public const byte LobbyStats; // 0x0
	public const byte AzureNodeInfo; // 0x0
	public const byte Join; // 0x0
	public const byte Leave; // 0x0
	public const byte PropertiesChanged; // 0x0
	public const byte SetProperties; // 0x0
	public const byte ErrorInfo; // 0x0
	public const byte CacheSliceChanged; // 0x0
	public const byte AuthEvent; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDC0 Offset: 0xD96DC0 VA: 0x6CF5DEDDC0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ParameterCode : Object
{
	// Fields

	public const byte SuppressRoomEvents; // 0x0
	public const byte EmptyRoomTTL; // 0x0
	public const byte PlayerTTL; // 0x0
	public const byte EventForward; // 0x0
	public const byte IsComingBack; // 0x0
	public const byte IsInactive; // 0x0
	public const byte CheckUserOnJoin; // 0x0
	public const byte ExpectedValues; // 0x0
	public const byte Address; // 0x0
	public const byte PeerCount; // 0x0
	public const byte GameCount; // 0x0
	public const byte MasterPeerCount; // 0x0
	public const byte UserId; // 0x0
	public const byte ApplicationId; // 0x0
	public const byte Position; // 0x0
	public const byte MatchMakingType; // 0x0
	public const byte GameList; // 0x0
	public const byte Secret; // 0x0
	public const byte AppVersion; // 0x0
	public const byte AzureNodeInfo; // 0x0
	public const byte AzureLocalNodeId; // 0x0
	public const byte AzureMasterNodeId; // 0x0
	public const byte RoomName; // 0x0
	public const byte Broadcast; // 0x0
	public const byte ActorList; // 0x0
	public const byte ActorNr; // 0x0
	public const byte PlayerProperties; // 0x0
	public const byte CustomEventContent; // 0x0
	public const byte Data; // 0x0
	public const byte Code; // 0x0
	public const byte GameProperties; // 0x0
	public const byte Properties; // 0x0
	public const byte TargetActorNr; // 0x0
	public const byte ReceiverGroup; // 0x0
	public const byte Cache; // 0x0
	public const byte CleanupCacheOnLeave; // 0x0
	public const byte Group; // 0x0
	public const byte Remove; // 0x0
	public const byte PublishUserId; // 0x0
	public const byte Add; // 0x0
	public const byte Info; // 0x0
	public const byte ClientAuthenticationType; // 0x0
	public const byte ClientAuthenticationParams; // 0x0
	public const byte JoinMode; // 0x0
	public const byte ClientAuthenticationData; // 0x0
	public const byte MasterClientId; // 0x0
	public const byte FindFriendsRequestList; // 0x0
	public const byte FindFriendsOptions; // 0x0
	public const byte FindFriendsResponseOnlineList; // 0x0
	public const byte FindFriendsResponseRoomIdList; // 0x0
	public const byte LobbyName; // 0x0
	public const byte LobbyType; // 0x0
	public const byte LobbyStats; // 0x0
	public const byte Region; // 0x0
	public const byte UriPath; // 0x0
	public const byte WebRpcParameters; // 0x0
	public const byte WebRpcReturnCode; // 0x0
	public const byte WebRpcReturnMessage; // 0x0
	public const byte CacheSliceIndex; // 0x0
	public const byte Plugins; // 0x0
	public const byte NickName; // 0x0
	public const byte PluginName; // 0x0
	public const byte PluginVersion; // 0x0
	public const byte Cluster; // 0x0
	public const byte ExpectedProtocol; // 0x0
	public const byte CustomInitData; // 0x0
	public const byte EncryptionMode; // 0x0
	public const byte EncryptionData; // 0x0
	public const byte RoomOptionFlags; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDC8 Offset: 0xD96DC8 VA: 0x6CF5DEDDC8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OperationCode : Object
{
	// Fields

	public const byte ExchangeKeysForEncryption; // 0x0
	public const byte Join; // 0x0
	public const byte AuthenticateOnce; // 0x0
	public const byte Authenticate; // 0x0
	public const byte JoinLobby; // 0x0
	public const byte LeaveLobby; // 0x0
	public const byte CreateGame; // 0x0
	public const byte JoinGame; // 0x0
	public const byte JoinRandomGame; // 0x0
	public const byte Leave; // 0x0
	public const byte RaiseEvent; // 0x0
	public const byte SetProperties; // 0x0
	public const byte GetProperties; // 0x0
	public const byte ChangeGroups; // 0x0
	public const byte FindFriends; // 0x0
	public const byte GetLobbyStats; // 0x0
	public const byte GetRegions; // 0x0
	public const byte WebRpc; // 0x0
	public const byte ServerSettings; // 0x0
	public const byte GetGameList; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5DEDDD0 Offset: 0xD96DD0 VA: 0x6CF5DEDDD0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum JoinMode
{
	// Fields

	public byte value__; // 0x10
	public const JoinMode Default = 0; // 0x0
	public const JoinMode CreateIfNotExists = 1; // 0x0
	public const JoinMode JoinOrRejoin = 2; // 0x0
	public const JoinMode RejoinOnly = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum MatchmakingMode
{
	// Fields

	public byte value__; // 0x10
	public const MatchmakingMode FillRoom = 0; // 0x0
	public const MatchmakingMode SerialMatching = 1; // 0x0
	public const MatchmakingMode RandomMatching = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ReceiverGroup
{
	// Fields

	public byte value__; // 0x10
	public const ReceiverGroup Others = 0; // 0x0
	public const ReceiverGroup All = 1; // 0x0
	public const ReceiverGroup MasterClient = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum EventCaching
{
	// Fields

	public byte value__; // 0x10
	public const EventCaching DoNotCache = 0; // 0x0
	public const EventCaching MergeCache = 1; // 0x0
	public const EventCaching ReplaceCache = 2; // 0x0
	public const EventCaching RemoveCache = 3; // 0x0
	public const EventCaching AddToRoomCache = 4; // 0x0
	public const EventCaching AddToRoomCacheGlobal = 5; // 0x0
	public const EventCaching RemoveFromRoomCache = 6; // 0x0
	public const EventCaching RemoveFromRoomCacheForActorsLeft = 7; // 0x0
	public const EventCaching SliceIncreaseIndex = 10; // 0x0
	public const EventCaching SliceSetIndex = 11; // 0x0
	public const EventCaching SlicePurgeIndex = 12; // 0x0
	public const EventCaching SlicePurgeUpToIndex = 13; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum PropertyTypeFlag
{
	// Fields

	public byte value__; // 0x10
	public const PropertyTypeFlag None = 0; // 0x0
	public const PropertyTypeFlag Game = 1; // 0x0
	public const PropertyTypeFlag Actor = 2; // 0x0
	public const PropertyTypeFlag GameAndActor = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RoomOptions : Object
{
	// Fields

	private bool isVisibleField; // 0x10
	private bool isOpenField; // 0x11
	public byte MaxPlayers; // 0x12
	public int PlayerTtl; // 0x14
	public int EmptyRoomTtl; // 0x18
	private bool cleanupCacheOnLeaveField; // 0x1C
	public Hashtable CustomRoomProperties; // 0x20
	public String[] CustomRoomPropertiesForLobby; // 0x28
	public String[] Plugins; // 0x30
	private bool suppressRoomEventsField; // 0x38
	private bool publishUserIdField; // 0x39
	private bool deleteNullPropertiesField; // 0x3A

	// Properties

	public bool IsVisible { get; set; }
	public bool IsOpen { get; set; }
	public bool CleanupCacheOnLeave { get; set; }
	public bool SuppressRoomEvents { get; }
	public bool PublishUserId { get; set; }
	public bool DeleteNullProperties { get; set; }
	public bool isVisible { get; set; }
	public bool isOpen { get; set; }
	public byte maxPlayers { get; set; }
	public bool cleanupCacheOnLeave { get; set; }
	public Hashtable customRoomProperties { get; set; }
	public String[] customRoomPropertiesForLobby { get; set; }
	public String[] plugins { get; set; }
	public bool suppressRoomEvents { get; }
	public bool publishUserId { get; set; }

	// Methods

	// RVA: 0x6CF5DEDDD8 Offset: 0xD96DD8 VA: 0x6CF5DEDDD8
	public bool get_IsVisible() { }

	// RVA: 0x6CF5DEDDE0 Offset: 0xD96DE0 VA: 0x6CF5DEDDE0
	public void set_IsVisible(bool value) { }

	// RVA: 0x6CF5DEDDEC Offset: 0xD96DEC VA: 0x6CF5DEDDEC
	public bool get_IsOpen() { }

	// RVA: 0x6CF5DEDDF4 Offset: 0xD96DF4 VA: 0x6CF5DEDDF4
	public void set_IsOpen(bool value) { }

	// RVA: 0x6CF5DEDE00 Offset: 0xD96E00 VA: 0x6CF5DEDE00
	public bool get_CleanupCacheOnLeave() { }

	// RVA: 0x6CF5DEDE08 Offset: 0xD96E08 VA: 0x6CF5DEDE08
	public void set_CleanupCacheOnLeave(bool value) { }

	// RVA: 0x6CF5DEDE14 Offset: 0xD96E14 VA: 0x6CF5DEDE14
	public bool get_SuppressRoomEvents() { }

	// RVA: 0x6CF5DEDE1C Offset: 0xD96E1C VA: 0x6CF5DEDE1C
	public bool get_PublishUserId() { }

	// RVA: 0x6CF5DEDE24 Offset: 0xD96E24 VA: 0x6CF5DEDE24
	public void set_PublishUserId(bool value) { }

	// RVA: 0x6CF5DEDE30 Offset: 0xD96E30 VA: 0x6CF5DEDE30
	public bool get_DeleteNullProperties() { }

	// RVA: 0x6CF5DEDE38 Offset: 0xD96E38 VA: 0x6CF5DEDE38
	public void set_DeleteNullProperties(bool value) { }

	// RVA: 0x6CF5DEDE44 Offset: 0xD96E44 VA: 0x6CF5DEDE44
	public bool get_isVisible() { }

	// RVA: 0x6CF5DEDE4C Offset: 0xD96E4C VA: 0x6CF5DEDE4C
	public void set_isVisible(bool value) { }

	// RVA: 0x6CF5DEDE58 Offset: 0xD96E58 VA: 0x6CF5DEDE58
	public bool get_isOpen() { }

	// RVA: 0x6CF5DEDE60 Offset: 0xD96E60 VA: 0x6CF5DEDE60
	public void set_isOpen(bool value) { }

	// RVA: 0x6CF5DEDE6C Offset: 0xD96E6C VA: 0x6CF5DEDE6C
	public byte get_maxPlayers() { }

	// RVA: 0x6CF5DEDE74 Offset: 0xD96E74 VA: 0x6CF5DEDE74
	public void set_maxPlayers(byte value) { }

	// RVA: 0x6CF5DEDE7C Offset: 0xD96E7C VA: 0x6CF5DEDE7C
	public bool get_cleanupCacheOnLeave() { }

	// RVA: 0x6CF5DEDE84 Offset: 0xD96E84 VA: 0x6CF5DEDE84
	public void set_cleanupCacheOnLeave(bool value) { }

	// RVA: 0x6CF5DEDE90 Offset: 0xD96E90 VA: 0x6CF5DEDE90
	public Hashtable get_customRoomProperties() { }

	// RVA: 0x6CF5DEDE98 Offset: 0xD96E98 VA: 0x6CF5DEDE98
	public void set_customRoomProperties(Hashtable value) { }

	// RVA: 0x6CF5DEDEA0 Offset: 0xD96EA0 VA: 0x6CF5DEDEA0
	public String[] get_customRoomPropertiesForLobby() { }

	// RVA: 0x6CF5DEDEA8 Offset: 0xD96EA8 VA: 0x6CF5DEDEA8
	public void set_customRoomPropertiesForLobby(String[] value) { }

	// RVA: 0x6CF5DEDEB0 Offset: 0xD96EB0 VA: 0x6CF5DEDEB0
	public String[] get_plugins() { }

	// RVA: 0x6CF5DEDEB8 Offset: 0xD96EB8 VA: 0x6CF5DEDEB8
	public void set_plugins(String[] value) { }

	// RVA: 0x6CF5DEDEC0 Offset: 0xD96EC0 VA: 0x6CF5DEDEC0
	public bool get_suppressRoomEvents() { }

	// RVA: 0x6CF5DEDEC8 Offset: 0xD96EC8 VA: 0x6CF5DEDEC8
	public bool get_publishUserId() { }

	// RVA: 0x6CF5DEDED0 Offset: 0xD96ED0 VA: 0x6CF5DEDED0
	public void set_publishUserId(bool value) { }

	// RVA: 0x6CF5DEB5DC Offset: 0xD945DC VA: 0x6CF5DEB5DC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RaiseEventOptions : Object
{
	// Fields

	public static readonly RaiseEventOptions Default; // 0x0
	public EventCaching CachingOption; // 0x10
	public byte InterestGroup; // 0x11
	public Int32[] TargetActors; // 0x18
	public ReceiverGroup Receivers; // 0x20
	public byte SequenceChannel; // 0x21
	public bool ForwardToWebhook; // 0x22
	public bool Encrypt; // 0x23

	// Properties


	// Methods

	// RVA: 0x6CF5DEDEDC Offset: 0xD96EDC VA: 0x6CF5DEDEDC
	public void Reset() { }

	// RVA: 0x6CF5DEDF78 Offset: 0xD96F78 VA: 0x6CF5DEDF78
	public void .ctor() { }

	// RVA: 0x6CF5DEDF80 Offset: 0xD96F80 VA: 0x6CF5DEDF80
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum LobbyType
{
	// Fields

	public byte value__; // 0x10
	public const LobbyType Default = 0; // 0x0
	public const LobbyType SqlLobby = 2; // 0x0
	public const LobbyType AsyncRandomLobby = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class TypedLobby : Object
{
	// Fields

	public string Name; // 0x10
	public LobbyType Type; // 0x18
	public static readonly TypedLobby Default; // 0x0

	// Properties

	public bool IsDefault { get; }

	// Methods

	// RVA: 0x6CF5DEB088 Offset: 0xD94088 VA: 0x6CF5DEB088
	public bool get_IsDefault() { }

	// RVA: 0x6CF5DEDFDC Offset: 0xD96FDC VA: 0x6CF5DEDFDC
	public void .ctor() { }

	// RVA: 0x6CF5DEE03C Offset: 0xD9703C VA: 0x6CF5DEE03C
	public void .ctor(string name, LobbyType type) { }

	// RVA: 0x6CF5DEE06C Offset: 0xD9706C VA: 0x6CF5DEE06C
	public override string ToString() { }

	// RVA: 0x6CF5DEE0F8 Offset: 0xD970F8 VA: 0x6CF5DEE0F8
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class TypedLobbyInfo : TypedLobby
{
	// Fields

	public int PlayerCount; // 0x1C
	public int RoomCount; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5DEE150 Offset: 0xD97150 VA: 0x6CF5DEE150
	public override string ToString() { }

	// RVA: 0x6CF5DEE2FC Offset: 0xD972FC VA: 0x6CF5DEE2FC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum AuthModeOption
{
	// Fields

	public int value__; // 0x10
	public const AuthModeOption Auth = 0; // 0x0
	public const AuthModeOption AuthOnce = 1; // 0x0
	public const AuthModeOption AuthOnceWss = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum CustomAuthenticationType
{
	// Fields

	public byte value__; // 0x10
	public const CustomAuthenticationType Custom = 0; // 0x0
	public const CustomAuthenticationType Steam = 1; // 0x0
	public const CustomAuthenticationType Facebook = 2; // 0x0
	public const CustomAuthenticationType Oculus = 3; // 0x0
	public const CustomAuthenticationType PlayStation = 4; // 0x0
	public const CustomAuthenticationType Xbox = 5; // 0x0
	public const CustomAuthenticationType Viveport = 10; // 0x0
	public const CustomAuthenticationType NintendoSwitch = 11; // 0x0
	public const CustomAuthenticationType None = 255; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class AuthenticationValues : Object
{
	// Fields

	private CustomAuthenticationType authType; // 0x10
	private string <AuthGetParameters>k__BackingField; // 0x18
	private object <AuthPostData>k__BackingField; // 0x20
	private string <Token>k__BackingField; // 0x28
	private string <UserId>k__BackingField; // 0x30

	// Properties

	public CustomAuthenticationType AuthType { get; set; }
	public string AuthGetParameters { get; set; }
	public object AuthPostData { get; set; }
	public string Token { get; set; }
	public string UserId { get; set; }

	// Methods

	// RVA: 0x6CF5DEE350 Offset: 0xD97350 VA: 0x6CF5DEE350
	public CustomAuthenticationType get_AuthType() { }

	// RVA: 0x6CF5DEE358 Offset: 0xD97358 VA: 0x6CF5DEE358
	public void set_AuthType(CustomAuthenticationType value) { }

	// RVA: 0x6CF5DEE360 Offset: 0xD97360 VA: 0x6CF5DEE360
	public string get_AuthGetParameters() { }

	// RVA: 0x6CF5DEE368 Offset: 0xD97368 VA: 0x6CF5DEE368
	public void set_AuthGetParameters(string value) { }

	// RVA: 0x6CF5DEE370 Offset: 0xD97370 VA: 0x6CF5DEE370
	public object get_AuthPostData() { }

	// RVA: 0x6CF5DEE378 Offset: 0xD97378 VA: 0x6CF5DEE378
	private void set_AuthPostData(object value) { }

	// RVA: 0x6CF5DEE380 Offset: 0xD97380 VA: 0x6CF5DEE380
	public string get_Token() { }

	// RVA: 0x6CF5DEE388 Offset: 0xD97388 VA: 0x6CF5DEE388
	public void set_Token(string value) { }

	// RVA: 0x6CF5DEE390 Offset: 0xD97390 VA: 0x6CF5DEE390
	public string get_UserId() { }

	// RVA: 0x6CF5DEE398 Offset: 0xD97398 VA: 0x6CF5DEE398
	public void set_UserId(string value) { }

	// RVA: 0x6CF5DEE3A0 Offset: 0xD973A0 VA: 0x6CF5DEE3A0
	public void .ctor() { }

	// RVA: 0x6CF5DE5284 Offset: 0xD8E284 VA: 0x6CF5DE5284
	public void .ctor(string userId) { }

	// RVA: 0x6CF5DEE3B0 Offset: 0xD973B0 VA: 0x6CF5DEE3B0
	public virtual void SetAuthPostData(string stringData) { }

	// RVA: 0x6CF5DEE3EC Offset: 0xD973EC VA: 0x6CF5DEE3EC
	public virtual void SetAuthPostData(Byte[] byteData) { }

	// RVA: 0x6CF5DEE3F4 Offset: 0xD973F4 VA: 0x6CF5DEE3F4
	public virtual void SetAuthPostData(Dictionary`2 dictData) { }

	// RVA: 0x6CF5DEE3FC Offset: 0xD973FC VA: 0x6CF5DEE3FC
	public virtual void AddAuthParameter(string key, string value) { }

	// RVA: 0x6CF5DEE5C8 Offset: 0xD975C8 VA: 0x6CF5DEE5C8
	public override string ToString() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class FindFriendsOptions : Object
{
	// Fields

	public bool CreatedOnGs; // 0x10
	public bool Visible; // 0x11
	public bool Open; // 0x12

	// Properties


	// Methods

	// RVA: 0x6CF5DEC600 Offset: 0xD95600 VA: 0x6CF5DEC600
	internal int ToIntFlags() { }

	// RVA: 0x6CF5DEE660 Offset: 0xD97660 VA: 0x6CF5DEE660
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ClientState
{
	// Fields

	public int value__; // 0x10
	public const ClientState Uninitialized = 0; // 0x0
	public const ClientState PeerCreated = 1; // 0x0
	public const ClientState Queued = 2; // 0x0
	public const ClientState Authenticated = 3; // 0x0
	public const ClientState JoinedLobby = 4; // 0x0
	public const ClientState DisconnectingFromMasterserver = 5; // 0x0
	public const ClientState ConnectingToGameserver = 6; // 0x0
	public const ClientState ConnectedToGameserver = 7; // 0x0
	public const ClientState Joining = 8; // 0x0
	public const ClientState Joined = 9; // 0x0
	public const ClientState Leaving = 10; // 0x0
	public const ClientState DisconnectingFromGameserver = 11; // 0x0
	public const ClientState ConnectingToMasterserver = 12; // 0x0
	public const ClientState QueuedComingFromGameserver = 13; // 0x0
	public const ClientState Disconnecting = 14; // 0x0
	public const ClientState Disconnected = 15; // 0x0
	public const ClientState ConnectedToMaster = 16; // 0x0
	public const ClientState ConnectingToNameServer = 17; // 0x0
	public const ClientState ConnectedToNameServer = 18; // 0x0
	public const ClientState DisconnectingFromNameServer = 19; // 0x0
	public const ClientState Authenticating = 20; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal enum JoinType
{
	// Fields

	public int value__; // 0x10
	public const JoinType CreateRoom = 0; // 0x0
	public const JoinType JoinRoom = 1; // 0x0
	public const JoinType JoinRandomRoom = 2; // 0x0
	public const JoinType JoinOrCreateRoom = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum DisconnectCause
{
	// Fields

	public int value__; // 0x10
	public const DisconnectCause DisconnectByServerUserLimit = 1042; // 0x0
	public const DisconnectCause ExceptionOnConnect = 1023; // 0x0
	public const DisconnectCause DisconnectByServerTimeout = 1041; // 0x0
	public const DisconnectCause DisconnectByServerLogic = 1043; // 0x0
	public const DisconnectCause Exception = 1026; // 0x0
	public const DisconnectCause InvalidAuthentication = 32767; // 0x0
	public const DisconnectCause MaxCcuReached = 32757; // 0x0
	public const DisconnectCause InvalidRegion = 32756; // 0x0
	public const DisconnectCause SecurityExceptionOnConnect = 1022; // 0x0
	public const DisconnectCause DisconnectByClientTimeout = 1040; // 0x0
	public const DisconnectCause InternalReceiveException = 1039; // 0x0
	public const DisconnectCause AuthenticationTicketExpired = 32753; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ServerConnection
{
	// Fields

	public int value__; // 0x10
	public const ServerConnection MasterServer = 0; // 0x0
	public const ServerConnection GameServer = 1; // 0x0
	public const ServerConnection NameServer = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass163_0 : Object
{
	// Fields

	public CloudRegionCode bestFromPrefs; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E01EA8 Offset: 0xDAAEA8 VA: 0x6CF5E01EA8
	public void .ctor() { }

	// RVA: 0x6CF5E01EB0 Offset: 0xDAAEB0 VA: 0x6CF5E01EB0
	internal bool <OnOperationResponse>b__0(Region x) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class NetworkingPeer : LoadBalancingPeer, IPhotonPeerListener
{
	// Fields

	protected internal string AppId; // 0xF0
	private AuthenticationValues <AuthValues>k__BackingField; // 0xF8
	private string tokenCache; // 0x100
	public AuthModeOption AuthMode; // 0x108
	public EncryptionMode EncryptionMode; // 0x10C
	private bool <IsUsingNameServer>k__BackingField; // 0x110
	public const string NameServerHost; // 0x0
	public const string NameServerHttp; // 0x0
	private static readonly Dictionary`2 ProtocolToNameServerPort; // 0x0
	private string <MasterServerAddress>k__BackingField; // 0x118
	private string <GameServerAddress>k__BackingField; // 0x120
	private ServerConnection <Server>k__BackingField; // 0x128
	private ClientState <State>k__BackingField; // 0x12C
	public bool IsInitialConnect; // 0x130
	public bool insideLobby; // 0x131
	private TypedLobby <lobby>k__BackingField; // 0x138
	protected internal List`1 LobbyStatistics; // 0x140
	public Dictionary`2 mGameList; // 0x148
	public RoomInfo[] mGameListCopy; // 0x150
	private string playername; // 0x158
	private bool mPlayernameHasToBeUpdated; // 0x160
	private Room currentRoom; // 0x168
	private PhotonPlayer <LocalPlayer>k__BackingField; // 0x170
	private int <PlayersOnMasterCount>k__BackingField; // 0x178
	private int <PlayersInRoomsCount>k__BackingField; // 0x17C
	private int <RoomsCount>k__BackingField; // 0x180
	private JoinType lastJoinType; // 0x184
	protected internal EnterRoomParams enterRoomParamsCache; // 0x188
	private bool didAuthenticate; // 0x190
	private String[] friendListRequested; // 0x198
	private int friendListTimestamp; // 0x1A0
	private bool isFetchingFriendList; // 0x1A4
	private List`1 <AvailableRegions>k__BackingField; // 0x1A8
	private CloudRegionCode <CloudRegion>k__BackingField; // 0x1B0
	private string cloudCluster; // 0x1B8
	public string CurrentCluster; // 0x1C0
	public Dictionary`2 mActors; // 0x1C8
	public PhotonPlayer[] mOtherPlayerListCopy; // 0x1D0
	public PhotonPlayer[] mPlayerListCopy; // 0x1D8
	public bool hasSwitchedMC; // 0x1E0
	private HashSet`1 allowedReceivingGroups; // 0x1E8
	private HashSet`1 blockSendingGroups; // 0x1F0
	protected internal Dictionary`2 photonViewList; // 0x1F8
	private readonly PhotonStream readStream; // 0x200
	private readonly PhotonStream pStream; // 0x208
	private readonly Dictionary`2 dataPerGroupReliable; // 0x210
	private readonly Dictionary`2 dataPerGroupUnreliable; // 0x218
	protected internal short currentLevelPrefix; // 0x220
	protected internal bool loadingLevelAndPausedNetwork; // 0x222
	protected internal const string CurrentSceneProperty; // 0x0
	protected internal const string CurrentScenePropertyLoadAsync; // 0x0
	public static bool UsePrefabCache; // 0x8
	internal IPunPrefabPool ObjectPool; // 0x228
	public static Dictionary`2 PrefabCache; // 0x10
	private Dictionary`2 monoRPCMethodsCache; // 0x230
	private readonly Dictionary`2 rpcShortcuts; // 0x238
	private static readonly string OnPhotonInstantiateString; // 0x18
	private string cachedServerAddress; // 0x240
	private string cachedApplicationName; // 0x248
	private ServerConnection cachedServerType; // 0x250
	private AsyncOperation _AsyncLevelLoadingOperation; // 0x258
	private RaiseEventOptions _levelReloadEventOptions; // 0x260
	private bool _isReconnecting; // 0x268
	private readonly Type typePunRPC; // 0x270
	private readonly Type typePhotonMessageInfo; // 0x278
	private readonly object keyByteZero; // 0x280
	private readonly object keyByteOne; // 0x288
	private readonly object keyByteTwo; // 0x290
	private readonly object keyByteThree; // 0x298
	private readonly object keyByteFour; // 0x2A0
	private readonly object keyByteFive; // 0x2A8
	private readonly Object[] emptyObjectArray; // 0x2B0
	private readonly Type[] emptyTypeArray; // 0x2B8
	private Dictionary`2 tempInstantiationData; // 0x2C0
	private readonly Hashtable reusedRpcEvent; // 0x2C8
	public static int ObjectsInOneUpdate; // 0x20
	private RaiseEventOptions options; // 0x2D0
	public const int SyncViewId; // 0x0
	public const int SyncCompressed; // 0x0
	public const int SyncNullValues; // 0x0
	public const int SyncFirstValue; // 0x0
	public bool IsReloadingLevel; // 0x2D8
	public bool AsynchLevelLoadCall; // 0x2D9

	// Properties

	protected internal string AppVersion { get; }
	public AuthenticationValues AuthValues { get; set; }
	private string TokenForInit { get; }
	public bool IsUsingNameServer { get; set; }
	public string NameServerAddress { get; }
	public string MasterServerAddress { get; set; }
	public string GameServerAddress { get; set; }
	protected internal ServerConnection Server { get; set; }
	public ClientState State { get; set; }
	public TypedLobby lobby { get; set; }
	private bool requestLobbyStatistics { get; }
	public string PlayerName { get; set; }
	public Room CurrentRoom { get; set; }
	public PhotonPlayer LocalPlayer { get; set; }
	public int PlayersOnMasterCount { get; set; }
	public int PlayersInRoomsCount { get; set; }
	public int RoomsCount { get; set; }
	protected internal int FriendListAge { get; }
	public bool IsAuthorizeSecretAvailable { get; }
	public List`1 AvailableRegions { get; set; }
	public CloudRegionCode CloudRegion { get; set; }
	public int mMasterClientId { get; set; }

	// Methods

	// RVA: 0x6CF5DEE668 Offset: 0xD97668 VA: 0x6CF5DEE668
	protected internal string get_AppVersion() { }

	// RVA: 0x6CF5DEE724 Offset: 0xD97724 VA: 0x6CF5DEE724
	public AuthenticationValues get_AuthValues() { }

	// RVA: 0x6CF5DEE72C Offset: 0xD9772C VA: 0x6CF5DEE72C
	public void set_AuthValues(AuthenticationValues value) { }

	// RVA: 0x6CF5DEE734 Offset: 0xD97734 VA: 0x6CF5DEE734
	private string get_TokenForInit() { }

	// RVA: 0x6CF5DEE754 Offset: 0xD97754 VA: 0x6CF5DEE754
	public bool get_IsUsingNameServer() { }

	// RVA: 0x6CF5DEE75C Offset: 0xD9775C VA: 0x6CF5DEE75C
	protected internal void set_IsUsingNameServer(bool value) { }

	// RVA: 0x6CF5DEE768 Offset: 0xD97768 VA: 0x6CF5DEE768
	public string get_NameServerAddress() { }

	// RVA: 0x6CF5DEE944 Offset: 0xD97944 VA: 0x6CF5DEE944
	public string get_MasterServerAddress() { }

	// RVA: 0x6CF5DEE94C Offset: 0xD9794C VA: 0x6CF5DEE94C
	protected internal void set_MasterServerAddress(string value) { }

	// RVA: 0x6CF5DEE954 Offset: 0xD97954 VA: 0x6CF5DEE954
	public string get_GameServerAddress() { }

	// RVA: 0x6CF5DEE95C Offset: 0xD9795C VA: 0x6CF5DEE95C
	protected internal void set_GameServerAddress(string value) { }

	// RVA: 0x6CF5DEE964 Offset: 0xD97964 VA: 0x6CF5DEE964
	protected internal ServerConnection get_Server() { }

	// RVA: 0x6CF5DEE96C Offset: 0xD9796C VA: 0x6CF5DEE96C
	private void set_Server(ServerConnection value) { }

	// RVA: 0x6CF5DEE974 Offset: 0xD97974 VA: 0x6CF5DEE974
	public ClientState get_State() { }

	// RVA: 0x6CF5DEE97C Offset: 0xD9797C VA: 0x6CF5DEE97C
	internal void set_State(ClientState value) { }

	// RVA: 0x6CF5DEE984 Offset: 0xD97984 VA: 0x6CF5DEE984
	public TypedLobby get_lobby() { }

	// RVA: 0x6CF5DEE98C Offset: 0xD9798C VA: 0x6CF5DEE98C
	public void set_lobby(TypedLobby value) { }

	// RVA: 0x6CF5DEE994 Offset: 0xD97994 VA: 0x6CF5DEE994
	private bool get_requestLobbyStatistics() { }

	// RVA: 0x6CF5DEEA04 Offset: 0xD97A04 VA: 0x6CF5DEEA04
	public string get_PlayerName() { }

	// RVA: 0x6CF5DEEA0C Offset: 0xD97A0C VA: 0x6CF5DEEA0C
	public void set_PlayerName(string value) { }

	// RVA: 0x6CF5DEEA8C Offset: 0xD97A8C VA: 0x6CF5DEEA8C
	public Room get_CurrentRoom() { }

	// RVA: 0x6CF5DEEB9C Offset: 0xD97B9C VA: 0x6CF5DEEB9C
	private void set_CurrentRoom(Room value) { }

	// RVA: 0x6CF5DEEBA4 Offset: 0xD97BA4 VA: 0x6CF5DEEBA4
	public PhotonPlayer get_LocalPlayer() { }

	// RVA: 0x6CF5DEEBAC Offset: 0xD97BAC VA: 0x6CF5DEEBAC
	internal void set_LocalPlayer(PhotonPlayer value) { }

	// RVA: 0x6CF5DEEBB4 Offset: 0xD97BB4 VA: 0x6CF5DEEBB4
	public int get_PlayersOnMasterCount() { }

	// RVA: 0x6CF5DEEBBC Offset: 0xD97BBC VA: 0x6CF5DEEBBC
	internal void set_PlayersOnMasterCount(int value) { }

	// RVA: 0x6CF5DEEBC4 Offset: 0xD97BC4 VA: 0x6CF5DEEBC4
	public int get_PlayersInRoomsCount() { }

	// RVA: 0x6CF5DEEBCC Offset: 0xD97BCC VA: 0x6CF5DEEBCC
	internal void set_PlayersInRoomsCount(int value) { }

	// RVA: 0x6CF5DEEBD4 Offset: 0xD97BD4 VA: 0x6CF5DEEBD4
	public int get_RoomsCount() { }

	// RVA: 0x6CF5DEEBDC Offset: 0xD97BDC VA: 0x6CF5DEEBDC
	internal void set_RoomsCount(int value) { }

	// RVA: 0x6CF5DEEBE4 Offset: 0xD97BE4 VA: 0x6CF5DEEBE4
	protected internal int get_FriendListAge() { }

	// RVA: 0x6CF5DEEC1C Offset: 0xD97C1C VA: 0x6CF5DEEC1C
	public bool get_IsAuthorizeSecretAvailable() { }

	// RVA: 0x6CF5DEEC44 Offset: 0xD97C44 VA: 0x6CF5DEEC44
	public List`1 get_AvailableRegions() { }

	// RVA: 0x6CF5DEEC4C Offset: 0xD97C4C VA: 0x6CF5DEEC4C
	protected internal void set_AvailableRegions(List`1 value) { }

	// RVA: 0x6CF5DEEC54 Offset: 0xD97C54 VA: 0x6CF5DEEC54
	public CloudRegionCode get_CloudRegion() { }

	// RVA: 0x6CF5DEEC5C Offset: 0xD97C5C VA: 0x6CF5DEEC5C
	protected internal void set_CloudRegion(CloudRegionCode value) { }

	// RVA: 0x6CF5DEEC64 Offset: 0xD97C64 VA: 0x6CF5DEEC64
	public int get_mMasterClientId() { }

	// RVA: 0x6CF5DEED24 Offset: 0xD97D24 VA: 0x6CF5DEED24
	private void set_mMasterClientId(int value) { }

	// RVA: 0x6CF5DEED3C Offset: 0xD97D3C VA: 0x6CF5DEED3C
	public void .ctor(string playername, ConnectionProtocol connectionProtocol) { }

	// RVA: 0x6CF5DEE76C Offset: 0xD9776C VA: 0x6CF5DEE76C
	private string GetNameServerAddress() { }

	// RVA: 0x6CF5DEF574 Offset: 0xD98574 VA: 0x6CF5DEF574
	public override bool Connect(string serverAddress, string applicationName) { }

	// RVA: 0x6CF5DEF5E4 Offset: 0xD985E4 VA: 0x6CF5DEF5E4
	public bool ReconnectToMaster() { }

	// RVA: 0x6CF5DEF8C4 Offset: 0xD988C4 VA: 0x6CF5DEF8C4
	public bool ReconnectAndRejoin() { }

	// RVA: 0x6CF5DEF6A4 Offset: 0xD986A4 VA: 0x6CF5DEF6A4
	public bool Connect(string serverAddress, ServerConnection type) { }

	// RVA: 0x6CF5DEFF90 Offset: 0xD98F90 VA: 0x6CF5DEFF90
	private bool Reconnect() { }

	// RVA: 0x6CF5DF007C Offset: 0xD9907C VA: 0x6CF5DF007C
	public bool ConnectToNameServer() { }

	// RVA: 0x6CF5DF01BC Offset: 0xD991BC VA: 0x6CF5DF01BC
	public bool ConnectToRegionMaster(CloudRegionCode region, string specificCluster) { }

	// RVA: 0x6CF5DEF9B8 Offset: 0xD989B8 VA: 0x6CF5DEF9B8
	protected internal void SetupProtocol(ServerConnection serverType) { }

	// RVA: 0x6CF5DF0538 Offset: 0xD99538 VA: 0x6CF5DF0538
	public override void Disconnect() { }

	// RVA: 0x6CF5DF031C Offset: 0xD9931C VA: 0x6CF5DF031C
	private bool CallAuthenticate() { }

	// RVA: 0x6CF5DF0640 Offset: 0xD99640 VA: 0x6CF5DF0640
	private void DisconnectToReconnect() { }

	// RVA: 0x6CF5DF0668 Offset: 0xD99668 VA: 0x6CF5DF0668
	public bool GetRegions() { }

	// RVA: 0x6CF5DF06AC Offset: 0xD996AC VA: 0x6CF5DF06AC
	public override bool OpFindFriends(String[] friendsToFind, FindFriendsOptions findFriendsOptions) { }

	// RVA: 0x6CF5DF06CC Offset: 0xD996CC VA: 0x6CF5DF06CC
	public bool OpCreateGame(EnterRoomParams enterRoomParams) { }

	// RVA: 0x6CF5DF0824 Offset: 0xD99824 VA: 0x6CF5DF0824
	public override bool OpJoinRoom(EnterRoomParams opParams) { }

	// RVA: 0x6CF5DF0864 Offset: 0xD99864 VA: 0x6CF5DF0864
	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) { }

	// RVA: 0x6CF5DF08F8 Offset: 0xD998F8 VA: 0x6CF5DF08F8
	public override bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions) { }

	// RVA: 0x6CF5DF09D4 Offset: 0xD999D4 VA: 0x6CF5DF09D4
	private void ReadoutProperties(Hashtable gameProperties, Hashtable pActorProperties, int targetActorNr) { }

	// RVA: 0x6CF5DF105C Offset: 0xD9A05C VA: 0x6CF5DF105C
	private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr) { }

	// RVA: 0x6CF5DF16C0 Offset: 0xD9A6C0 VA: 0x6CF5DF16C0
	public void ChangeLocalID(int newID) { }

	// RVA: 0x6CF5DF1A60 Offset: 0xD9AA60 VA: 0x6CF5DF1A60
	private void LeftLobbyCleanup() { }

	// RVA: 0x6CF5DF1BA8 Offset: 0xD9ABA8 VA: 0x6CF5DF1BA8
	private void LeftRoomCleanup() { }

	// RVA: 0x6CF5DF1EDC Offset: 0xD9AEDC VA: 0x6CF5DF1EDC
	protected internal void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects) { }

	// RVA: 0x6CF5DF2738 Offset: 0xD9B738 VA: 0x6CF5DF2738
	private void GameEnteredOnGameServer(OperationResponse operationResponse) { }

	// RVA: 0x6CF5DEF458 Offset: 0xD98458 VA: 0x6CF5DEF458
	private void AddNewPlayer(int ID, PhotonPlayer player) { }

	// RVA: 0x6CF5DF3278 Offset: 0xD9C278 VA: 0x6CF5DF3278
	private void RemovePlayer(int ID, PhotonPlayer player) { }

	// RVA: 0x6CF5DF187C Offset: 0xD9A87C VA: 0x6CF5DF187C
	private void RebuildPlayerListCopies() { }

	// RVA: 0x6CF5DF3300 Offset: 0xD9C300 VA: 0x6CF5DF3300
	private void ResetPhotonViewsOnSerialize() { }

	// RVA: 0x6CF5DF3464 Offset: 0xD9C464 VA: 0x6CF5DF3464
	private void HandleEventLeave(int actorID, EventData evLeave) { }

	// RVA: 0x6CF5DF2FFC Offset: 0xD9BFFC VA: 0x6CF5DF2FFC
	private void CheckMasterClient(int leavingPlayerId) { }

	// RVA: 0x6CF5DF39E4 Offset: 0xD9C9E4 VA: 0x6CF5DF39E4
	protected internal void UpdateMasterClient() { }

	// RVA: 0x6CF5DF3FC0 Offset: 0xD9CFC0 VA: 0x6CF5DF3FC0
	private static int ReturnLowestPlayerId(PhotonPlayer[] players, int playerIdToIgnore) { }

	// RVA: 0x6CF5DF4028 Offset: 0xD9D028 VA: 0x6CF5DF4028
	protected internal bool SetMasterClient(int playerId, bool sync) { }

	// RVA: 0x6CF5DF4238 Offset: 0xD9D238 VA: 0x6CF5DF4238
	public bool SetMasterClient(int nextMasterId) { }

	// RVA: 0x6CF5DF0FF0 Offset: 0xD99FF0 VA: 0x6CF5DF0FF0
	protected internal PhotonPlayer GetPlayerWithId(int number) { }

	// RVA: 0x6CF5DEEAAC Offset: 0xD97AAC VA: 0x6CF5DEEAAC
	private void SendPlayerName() { }

	// RVA: 0x6CF5DF0720 Offset: 0xD99720 VA: 0x6CF5DF0720
	private Hashtable GetLocalActorProperties() { }

	// RVA: 0x6CF5DF43A4 Offset: 0xD9D3A4 VA: 0x6CF5DF43A4
	public void DebugReturn(DebugLevel level, string message) { }

	// RVA: 0x6CF5DF44F0 Offset: 0xD9D4F0 VA: 0x6CF5DF44F0
	public void OnOperationResponse(OperationResponse operationResponse) { }

	// RVA: 0x6CF5DF70F4 Offset: 0xDA00F4 VA: 0x6CF5DF70F4
	public void OnStatusChanged(StatusCode statusCode) { }

	// RVA: 0x6CF5DF7FA4 Offset: 0xDA0FA4 VA: 0x6CF5DF7FA4
	public void OnEvent(EventData photonEvent) { }

	// RVA: 0x6CF5DFC6C0 Offset: 0xDA56C0 VA: 0x6CF5DFC6C0
	public void OnMessage(object messages) { }

	// RVA: 0x6CF5DF6DF4 Offset: 0xD9FDF4 VA: 0x6CF5DF6DF4
	private void SetupEncryption(Dictionary`2 encryptionData) { }

	// RVA: 0x6CF5DF2EC8 Offset: 0xD9BEC8 VA: 0x6CF5DF2EC8
	protected internal void UpdatedActorList(Int32[] actorsInRoom) { }

	// RVA: 0x6CF5DFC6C4 Offset: 0xDA56C4 VA: 0x6CF5DFC6C4
	private void SendVacantViewIds() { }

	// RVA: 0x6CF5DF115C Offset: 0xD9A15C VA: 0x6CF5DF115C
	public static void SendMonoMessage(PhotonNetworkingMessage methodString, Object[] parameters) { }

	// RVA: 0x6CF5DFA1F0 Offset: 0xDA31F0 VA: 0x6CF5DFA1F0
	protected internal void ExecuteRpc(Hashtable rpcData, int senderID) { }

	// RVA: 0x6CF5DFCC00 Offset: 0xDA5C00 VA: 0x6CF5DFCC00
	private bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes) { }

	// RVA: 0x6CF5DFCDA8 Offset: 0xDA5DA8 VA: 0x6CF5DFCDA8
	internal Hashtable SendInstantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, Int32[] viewIDs, Object[] data, bool isGlobalObject) { }

	// RVA: 0x6CF5DFBAE0 Offset: 0xDA4AE0 VA: 0x6CF5DFBAE0
	internal GameObject DoInstantiate(Hashtable evData, PhotonPlayer photonPlayer, GameObject resourceGameObject) { }

	// RVA: 0x6CF5DFD254 Offset: 0xDA6254 VA: 0x6CF5DFD254
	private void StoreInstantiationData(int instantiationId, Object[] instantiationData) { }

	// RVA: 0x6CF5DFD314 Offset: 0xDA6314 VA: 0x6CF5DFD314
	public Object[] FetchInstantiationData(int instantiationId) { }

	// RVA: 0x6CF5DFD2BC Offset: 0xDA62BC VA: 0x6CF5DFD2BC
	private void RemoveInstantiationData(int instantiationId) { }

	// RVA: 0x6CF5DF3ACC Offset: 0xD9CACC VA: 0x6CF5DF3ACC
	public void DestroyPlayerObjects(int playerId, bool localOnly) { }

	// RVA: 0x6CF5DFC694 Offset: 0xDA5694 VA: 0x6CF5DFC694
	public void DestroyAll(bool localOnly) { }

	// RVA: 0x6CF5DF22A8 Offset: 0xD9B2A8 VA: 0x6CF5DF22A8
	protected internal void RemoveInstantiatedGO(GameObject go, bool localOnly) { }

	// RVA: 0x6CF5DFD794 Offset: 0xDA6794 VA: 0x6CF5DFD794
	private void ServerCleanInstantiateAndDestroy(int instantiateId, int creatorId, bool isRuntimeInstantiated) { }

	// RVA: 0x6CF5DFD520 Offset: 0xDA6520 VA: 0x6CF5DFD520
	private void SendDestroyOfPlayer(int actorNr) { }

	// RVA: 0x6CF5DFD6A0 Offset: 0xDA66A0 VA: 0x6CF5DFD6A0
	private void SendDestroyOfAll() { }

	// RVA: 0x6CF5DFD390 Offset: 0xDA6390 VA: 0x6CF5DFD390
	private void OpRemoveFromServerInstantiationsOfPlayer(int actorNr) { }

	// RVA: 0x6CF5DFDBBC Offset: 0xDA6BBC VA: 0x6CF5DFDBBC
	protected internal void RequestOwnership(int viewID, int fromOwner) { }

	// RVA: 0x6CF5DFDE00 Offset: 0xDA6E00 VA: 0x6CF5DFDE00
	protected internal void TransferOwnership(int viewID, int playerID) { }

	// RVA: 0x6CF5DFDA28 Offset: 0xDA6A28 VA: 0x6CF5DFDA28
	public bool LocalCleanPhotonView(PhotonView view) { }

	// RVA: 0x6CF5DFCA08 Offset: 0xDA5A08 VA: 0x6CF5DFCA08
	public PhotonView GetPhotonView(int viewID) { }

	// RVA: 0x6CF5DFE044 Offset: 0xDA7044 VA: 0x6CF5DFE044
	public void RegisterPhotonView(PhotonView netView) { }

	// RVA: 0x6CF5DFD458 Offset: 0xDA6458 VA: 0x6CF5DFD458
	public void OpCleanRpcBuffer(int actorNumber) { }

	// RVA: 0x6CF5DFE32C Offset: 0xDA732C VA: 0x6CF5DFE32C
	public void OpRemoveCompleteCacheOfPlayer(int actorNumber) { }

	// RVA: 0x6CF5DFD614 Offset: 0xDA6614 VA: 0x6CF5DFD614
	public void OpRemoveCompleteCache() { }

	// RVA: 0x6CF5DFE3F4 Offset: 0xDA73F4 VA: 0x6CF5DFE3F4
	private void RemoveCacheOfLeftPlayers() { }

	// RVA: 0x6CF5DFE534 Offset: 0xDA7534 VA: 0x6CF5DFE534
	public void CleanRpcBufferIfMine(PhotonView view) { }

	// RVA: 0x6CF5DFDA8C Offset: 0xDA6A8C VA: 0x6CF5DFDA8C
	public void OpCleanRpcBuffer(PhotonView view) { }

	// RVA: 0x6CF5DFE694 Offset: 0xDA7694 VA: 0x6CF5DFE694
	public void RemoveRPCsInGroup(int group) { }

	// RVA: 0x6CF5DFE80C Offset: 0xDA780C VA: 0x6CF5DFE80C
	public void SetLevelPrefix(short prefix) { }

	// RVA: 0x6CF5DFE814 Offset: 0xDA7814 VA: 0x6CF5DFE814
	internal void RPC(PhotonView view, string methodName, PhotonTargets target, PhotonPlayer player, bool encrypt, Object[] parameters) { }

	// RVA: 0x6CF5DFF100 Offset: 0xDA8100 VA: 0x6CF5DFF100
	public void SetInterestGroups(Byte[] disableGroups, Byte[] enableGroups) { }

	// RVA: 0x6CF5DFF43C Offset: 0xDA843C VA: 0x6CF5DFF43C
	public void SetSendingEnabled(byte group, bool enabled) { }

	// RVA: 0x6CF5DFF4D0 Offset: 0xDA84D0 VA: 0x6CF5DFF4D0
	public void SetSendingEnabled(Byte[] disableGroups, Byte[] enableGroups) { }

	// RVA: 0x6CF5DFF5D4 Offset: 0xDA85D4 VA: 0x6CF5DFF5D4
	public void NewSceneLoaded() { }

	// RVA: 0x6CF5DFF9B8 Offset: 0xDA89B8 VA: 0x6CF5DFF9B8
	public void RunViewUpdate() { }

	// RVA: 0x6CF5E00884 Offset: 0xDA9884 VA: 0x6CF5E00884
	private Object[] OnSerializeWrite(PhotonView view) { }

	// RVA: 0x6CF5DFB5AC Offset: 0xDA45AC VA: 0x6CF5DFB5AC
	private void OnSerializeRead(Object[] data, PhotonPlayer sender, int networkTime, short correctPrefix) { }

	// RVA: 0x6CF5E00BA4 Offset: 0xDA9BA4 VA: 0x6CF5E00BA4
	private Object[] DeltaCompressionWrite(Object[] previousContent, Object[] currentContent) { }

	// RVA: 0x6CF5E00E84 Offset: 0xDA9E84 VA: 0x6CF5E00E84
	private Object[] DeltaCompressionRead(Object[] lastOnSerializeDataReceived, Object[] incomingData) { }

	// RVA: 0x6CF5E00AF8 Offset: 0xDA9AF8 VA: 0x6CF5E00AF8
	private bool AlmostEquals(Object[] lastData, Object[] currentContent) { }

	// RVA: 0x6CF5E01024 Offset: 0xDAA024 VA: 0x6CF5E01024
	private bool AlmostEquals(object one, object two) { }

	// RVA: 0x6CF5E013F8 Offset: 0xDAA3F8 VA: 0x6CF5E013F8
	protected internal static bool GetMethod(MonoBehaviour monob, string methodType, ref MethodInfo mi) { }

	// RVA: 0x6CF5DF13B8 Offset: 0xD9A3B8 VA: 0x6CF5DF13B8
	protected internal void LoadLevelIfSynced() { }

	// RVA: 0x6CF5E01568 Offset: 0xDAA568 VA: 0x6CF5E01568
	protected internal void SetLevelInPropsIfSynced(object levelId, bool initiatingCall, bool asyncLoading) { }

	// RVA: 0x6CF5E01A60 Offset: 0xDAAA60 VA: 0x6CF5E01A60
	private void SendLevelReloadEvent() { }

	// RVA: 0x6CF5E01B18 Offset: 0xDAAB18 VA: 0x6CF5E01B18
	public void SetApp(string appId, string gameVersion) { }

	// RVA: 0x6CF5E01BF4 Offset: 0xDAABF4 VA: 0x6CF5E01BF4
	public bool WebRpc(string uriPath, object parameters) { }

	// RVA: 0x6CF5E01D00 Offset: 0xDAAD00 VA: 0x6CF5E01D00
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public interface IPunObservable
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public interface IPunCallbacks
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnConnectedToPhoton() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnLeftRoom() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonCreateRoomFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonJoinRoomFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnCreatedRoom() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnJoinedLobby() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnLeftLobby() { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnFailedToConnectToPhoton(DisconnectCause cause) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnConnectionFail(DisconnectCause cause) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnDisconnectedFromPhoton() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public abstract void OnPhotonInstantiate(PhotonMessageInfo info) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnReceivedRoomListUpdate() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnJoinedRoom() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonRandomJoinFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnConnectedToMaster() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnPhotonMaxCccuReached() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonPlayerPropertiesChanged(Object[] playerAndUpdatedProps) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnUpdatedFriendList() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnCustomAuthenticationResponse(Dictionary`2 data) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnWebRpcResponse(OperationResponse response) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnOwnershipRequest(Object[] viewAndPlayer) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnLobbyStatisticsUpdate() { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnOwnershipTransfered(Object[] viewAndPlayers) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public interface IPunPrefabPool
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void Destroy(GameObject gameObject) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public struct PhotonMessageInfo
{
	// Fields

	private readonly int timeInt; // 0x10
	public readonly PhotonPlayer sender; // 0x18
	public readonly PhotonView photonView; // 0x20

	// Properties

	public double timestamp { get; }

	// Methods

	// RVA: 0x6CF5E01ED4 Offset: 0xDAAED4 VA: 0x6CF5E01ED4
	public void .ctor(PhotonPlayer player, int timestamp, PhotonView view) { }

	// RVA: 0x6CF5E01EE0 Offset: 0xDAAEE0 VA: 0x6CF5E01EE0
	public double get_timestamp() { }

	// RVA: 0x6CF5E01EF8 Offset: 0xDAAEF8 VA: 0x6CF5E01EF8
	public override string ToString() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class PunEvent : Object
{
	// Fields

	public const byte RPC; // 0x0
	public const byte SendSerialize; // 0x0
	public const byte Instantiation; // 0x0
	public const byte CloseConnection; // 0x0
	public const byte Destroy; // 0x0
	public const byte RemoveCachedRPCs; // 0x0
	public const byte SendSerializeReliable; // 0x0
	public const byte DestroyPlayer; // 0x0
	public const byte AssignMaster; // 0x0
	public const byte OwnershipRequest; // 0x0
	public const byte OwnershipTransfer; // 0x0
	public const byte VacantViewIds; // 0x0
	public const byte levelReload; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E01F90 Offset: 0xDAAF90 VA: 0x6CF5E01F90
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonStream : Object
{
	// Fields

	private bool write; // 0x10
	private Queue`1 writeData; // 0x18
	private Object[] readData; // 0x20
	internal byte currentItem; // 0x28

	// Properties

	public bool isWriting { get; }
	public bool isReading { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x6CF5E01F98 Offset: 0xDAAF98 VA: 0x6CF5E01F98
	public void .ctor(bool write, Object[] incomingData) { }

	// RVA: 0x6CF5E02034 Offset: 0xDAB034 VA: 0x6CF5E02034
	public void SetReadStream(Object[] incomingData, byte pos) { }

	// RVA: 0x6CF5E02044 Offset: 0xDAB044 VA: 0x6CF5E02044
	internal void ResetWriteStream() { }

	// RVA: 0x6CF5E02094 Offset: 0xDAB094 VA: 0x6CF5E02094
	public bool get_isWriting() { }

	// RVA: 0x6CF5E0209C Offset: 0xDAB09C VA: 0x6CF5E0209C
	public bool get_isReading() { }

	// RVA: 0x6CF5E020AC Offset: 0xDAB0AC VA: 0x6CF5E020AC
	public int get_Count() { }

	// RVA: 0x6CF5E0210C Offset: 0xDAB10C VA: 0x6CF5E0210C
	public object ReceiveNext() { }

	// RVA: 0x6CF5E021BC Offset: 0xDAB1BC VA: 0x6CF5E021BC
	public object PeekNext() { }

	// RVA: 0x6CF5E02264 Offset: 0xDAB264 VA: 0x6CF5E02264
	public void SendNext(object obj) { }

	// RVA: 0x6CF5E02310 Offset: 0xDAB310 VA: 0x6CF5E02310
	public Object[] ToArray() { }

	// RVA: 0x6CF5E02378 Offset: 0xDAB378 VA: 0x6CF5E02378
	public void Serialize(ref bool myBool) { }

	// RVA: 0x6CF5E02480 Offset: 0xDAB480 VA: 0x6CF5E02480
	public void Serialize(ref int myInt) { }

	// RVA: 0x6CF5E02580 Offset: 0xDAB580 VA: 0x6CF5E02580
	public void Serialize(ref string value) { }

	// RVA: 0x6CF5E02664 Offset: 0xDAB664 VA: 0x6CF5E02664
	public void Serialize(ref char value) { }

	// RVA: 0x6CF5E02764 Offset: 0xDAB764 VA: 0x6CF5E02764
	public void Serialize(ref short value) { }

	// RVA: 0x6CF5E02864 Offset: 0xDAB864 VA: 0x6CF5E02864
	public void Serialize(ref float obj) { }

	// RVA: 0x6CF5E02964 Offset: 0xDAB964 VA: 0x6CF5E02964
	public void Serialize(ref PhotonPlayer obj) { }

	// RVA: 0x6CF5E02A80 Offset: 0xDABA80 VA: 0x6CF5E02A80
	public void Serialize(ref Vector3 obj) { }

	// RVA: 0x6CF5E02B90 Offset: 0xDABB90 VA: 0x6CF5E02B90
	public void Serialize(ref Vector2 obj) { }

	// RVA: 0x6CF5E02C90 Offset: 0xDABC90 VA: 0x6CF5E02C90
	public void Serialize(ref Quaternion obj) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SceneManagerHelper : Object
{
	// Fields


	// Properties

	public static string ActiveSceneName { get; }
	public static int ActiveSceneBuildIndex { get; }

	// Methods

	// RVA: 0x6CF5E02D90 Offset: 0xDABD90 VA: 0x6CF5E02D90
	public static string get_ActiveSceneName() { }

	// RVA: 0x6CF5E02DF4 Offset: 0xDABDF4 VA: 0x6CF5E02DF4
	public static int get_ActiveSceneBuildIndex() { }

	// RVA: 0x6CF5E02E58 Offset: 0xDABE58 VA: 0x6CF5E02E58
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class WebRpcResponse : Object
{
	// Fields

	private string <Name>k__BackingField; // 0x10
	private int <ReturnCode>k__BackingField; // 0x18
	private string <DebugMessage>k__BackingField; // 0x20
	private Dictionary`2 <Parameters>k__BackingField; // 0x28

	// Properties

	public string Name { get; set; }
	public int ReturnCode { get; set; }
	public string DebugMessage { get; set; }
	public Dictionary`2 Parameters { get; set; }

	// Methods

	// RVA: 0x6CF5E02E60 Offset: 0xDABE60 VA: 0x6CF5E02E60
	public string get_Name() { }

	// RVA: 0x6CF5E02E68 Offset: 0xDABE68 VA: 0x6CF5E02E68
	private void set_Name(string value) { }

	// RVA: 0x6CF5E02E70 Offset: 0xDABE70 VA: 0x6CF5E02E70
	public int get_ReturnCode() { }

	// RVA: 0x6CF5E02E78 Offset: 0xDABE78 VA: 0x6CF5E02E78
	private void set_ReturnCode(int value) { }

	// RVA: 0x6CF5E02E80 Offset: 0xDABE80 VA: 0x6CF5E02E80
	public string get_DebugMessage() { }

	// RVA: 0x6CF5E02E88 Offset: 0xDABE88 VA: 0x6CF5E02E88
	private void set_DebugMessage(string value) { }

	// RVA: 0x6CF5E02E90 Offset: 0xDABE90 VA: 0x6CF5E02E90
	public Dictionary`2 get_Parameters() { }

	// RVA: 0x6CF5E02E98 Offset: 0xDABE98 VA: 0x6CF5E02E98
	private void set_Parameters(Dictionary`2 value) { }

	// RVA: 0x6CF5E02EA0 Offset: 0xDABEA0 VA: 0x6CF5E02EA0
	public void .ctor(OperationResponse response) { }

	// RVA: 0x6CF5E03050 Offset: 0xDAC050 VA: 0x6CF5E03050
	public string ToStringFull() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static UnityAction`2 <>9__10_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF5E0471C Offset: 0xDAD71C VA: 0x6CF5E0471C
	private static void .cctor() { }

	// RVA: 0x6CF5E04778 Offset: 0xDAD778 VA: 0x6CF5E04778
	public void .ctor() { }

	// RVA: 0x6CF5E04780 Offset: 0xDAD780 VA: 0x6CF5E04780
	internal void <Start>b__10_0(Scene scene, LoadSceneMode loadingMode) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <PingAvailableRegionsCoroutine>d__25 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool connectToBest; // 0x20
	private PhotonPingManager <pingManager>5__2; // 0x28

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E046EC Offset: 0xDAD6EC VA: 0x6CF5E046EC
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E04828 Offset: 0xDAD828 VA: 0x6CF5E04828
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E0482C Offset: 0xDAD82C VA: 0x6CF5E0482C
	private bool MoveNext() { }

	// RVA: 0x6CF5E052CC Offset: 0xDAE2CC VA: 0x6CF5E052CC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E052D4 Offset: 0xDAE2D4 VA: 0x6CF5E052D4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E0530C Offset: 0xDAE30C VA: 0x6CF5E0530C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class PhotonHandler : MonoBehaviour
{
	// Fields

	public static PhotonHandler SP; // 0x0
	public int updateInterval; // 0x20
	public int updateIntervalOnSerialize; // 0x24
	private int nextSendTickCount; // 0x28
	private int nextSendTickCountOnSerialize; // 0x2C
	private static bool sendThreadShouldRun; // 0x8
	private static Stopwatch timerToStopConnectionInBackground; // 0x10
	protected internal static bool AppQuits; // 0x18
	protected internal static Type PingImplementation; // 0x20
	private const string PlayerPrefsKey; // 0x0

	// Properties

	internal static CloudRegionCode BestRegionCodeInPreferences { get; set; }

	// Methods

	// RVA: 0x6CF5E031EC Offset: 0xDAC1EC VA: 0x6CF5E031EC
	protected void Awake() { }

	// RVA: 0x6CF5E03554 Offset: 0xDAC554 VA: 0x6CF5E03554
	protected void Start() { }

	// RVA: 0x6CF5E0364C Offset: 0xDAC64C VA: 0x6CF5E0364C
	protected void OnApplicationQuit() { }

	// RVA: 0x6CF5E0385C Offset: 0xDAC85C VA: 0x6CF5E0385C
	protected void OnApplicationPause(bool pause) { }

	// RVA: 0x6CF5E03964 Offset: 0xDAC964 VA: 0x6CF5E03964
	protected void OnDestroy() { }

	// RVA: 0x6CF5E039AC Offset: 0xDAC9AC VA: 0x6CF5E039AC
	protected void Update() { }

	// RVA: 0x6CF5E03E5C Offset: 0xDACE5C VA: 0x6CF5E03E5C
	protected void OnJoinedRoom() { }

	// RVA: 0x6CF5E03EC0 Offset: 0xDACEC0 VA: 0x6CF5E03EC0
	protected void OnCreatedRoom() { }

	// RVA: 0x6CF5E03468 Offset: 0xDAC468 VA: 0x6CF5E03468
	public static void StartFallbackSendAckThread() { }

	// RVA: 0x6CF5E036E8 Offset: 0xDAC6E8 VA: 0x6CF5E036E8
	public static void StopFallbackSendAckThread() { }

	// RVA: 0x6CF5E03F38 Offset: 0xDACF38 VA: 0x6CF5E03F38
	public static bool FallbackSendAckThread() { }

	// RVA: 0x6CF5E0435C Offset: 0xDAD35C VA: 0x6CF5E0435C
	internal static CloudRegionCode get_BestRegionCodeInPreferences() { }

	// RVA: 0x6CF5E04578 Offset: 0xDAD578 VA: 0x6CF5E04578
	internal static void set_BestRegionCodeInPreferences(CloudRegionCode value) { }

	// RVA: 0x6CF5E04624 Offset: 0xDAD624 VA: 0x6CF5E04624
	protected internal static void PingAvailableRegionsAndConnectToBest() { }

	// RVA: 0x6CF5E04688 Offset: 0xDAD688 VA: 0x6CF5E04688
	internal IEnumerator PingAvailableRegionsCoroutine(bool connectToBest) { }

	// RVA: 0x6CF5E04714 Offset: 0xDAD714 VA: 0x6CF5E04714
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonLagSimulationGui : MonoBehaviour
{
	// Fields

	public Rect WindowRect; // 0x20
	public int WindowId; // 0x30
	public bool Visible; // 0x34
	private PhotonPeer <Peer>k__BackingField; // 0x38

	// Properties

	public PhotonPeer Peer { get; set; }

	// Methods

	// RVA: 0x6CF5E05314 Offset: 0xDAE314 VA: 0x6CF5E05314
	public PhotonPeer get_Peer() { }

	// RVA: 0x6CF5E0531C Offset: 0xDAE31C VA: 0x6CF5E0531C
	public void set_Peer(PhotonPeer value) { }

	// RVA: 0x6CF5E05324 Offset: 0xDAE324 VA: 0x6CF5E05324
	public void Start() { }

	// RVA: 0x6CF5E05384 Offset: 0xDAE384 VA: 0x6CF5E05384
	public void OnGUI() { }

	// RVA: 0x6CF5E054E8 Offset: 0xDAE4E8 VA: 0x6CF5E054E8
	private void NetSimHasNoPeerWindow(int windowId) { }

	// RVA: 0x6CF5E05590 Offset: 0xDAE590 VA: 0x6CF5E05590
	private void NetSimWindow(int windowId) { }

	// RVA: 0x6CF5E05CB0 Offset: 0xDAECB0 VA: 0x6CF5E05CB0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class EventCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E0F364 Offset: 0xDB8364 VA: 0x6CF5E0F364
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5E0F3F0 Offset: 0xDB83F0 VA: 0x6CF5E0F3F0
	public virtual void Invoke(byte eventCode, object content, int senderId) { }

	// RVA: 0x6CF5E0F404 Offset: 0xDB8404 VA: 0x6CF5E0F404
	public virtual IAsyncResult BeginInvoke(byte eventCode, object content, int senderId, AsyncCallback callback, object object) { }

	// RVA: 0x6CF5E0F4C4 Offset: 0xDB84C4 VA: 0x6CF5E0F4C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E0F4D0 Offset: 0xDB84D0 VA: 0x6CF5E0F4D0
	private static void .cctor() { }

	// RVA: 0x6CF5E0F52C Offset: 0xDB852C VA: 0x6CF5E0F52C
	public void .ctor() { }

	// RVA: 0x6CF5E0F534 Offset: 0xDB8534 VA: 0x6CF5E0F534
	internal int <.cctor>b__151_0() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class PhotonNetwork : Object
{
	// Fields

	public const string versionPUN; // 0x0
	private static string <gameVersion>k__BackingField; // 0x0
	internal static readonly PhotonHandler photonMono; // 0x8
	internal static NetworkingPeer networkingPeer; // 0x10
	public static readonly int MAX_VIEW_IDS; // 0x18
	internal const string serverSettingsAssetFile; // 0x0
	public static ServerSettings PhotonServerSettings; // 0x20
	public static bool InstantiateInRoomOnly; // 0x28
	public static PhotonLogLevel logLevel; // 0x2C
	private static List`1 <Friends>k__BackingField; // 0x30
	public static float precisionForVectorSynchronization; // 0x38
	public static float precisionForQuaternionSynchronization; // 0x3C
	public static float precisionForFloatSynchronization; // 0x40
	public static bool UseRpcMonoBehaviourCache; // 0x44
	public static bool UsePrefabCache; // 0x45
	public static Dictionary`2 PrefabCache; // 0x48
	public static HashSet`1 SendMonoMessageTargets; // 0x50
	public static Type SendMonoMessageTargetType; // 0x58
	public static bool StartRpcsAsCoroutine; // 0x60
	private static bool isOfflineMode; // 0x61
	private static Room offlineModeRoom; // 0x68
	public static int maxConnections; // 0x70
	private static bool _mAutomaticallySyncScene; // 0x74
	private static bool m_autoCleanUpPlayerObjects; // 0x75
	private static int sendInterval; // 0x78
	private static int sendIntervalOnSerialize; // 0x7C
	private static bool m_isMessageQueueRunning; // 0x80
	private static Stopwatch startupStopwatch; // 0x88
	public static float BackgroundTimeout; // 0x90
	private static bool <UseAlternativeUdpPorts>k__BackingField; // 0x94
	private static EventCallback OnEventCall; // 0x98
	internal static int lastUsedViewSubId; // 0xA0
	internal static int lastUsedViewSubIdStatic; // 0xA4
	internal static List`1 manuallyAllocatedViewIds; // 0xA8

	// Properties

	public static string gameVersion { get; set; }
	public static string ServerAddress { get; }
	public static CloudRegionCode CloudRegion { get; }
	public static string CurrentCluster { get; }
	public static bool connected { get; }
	public static bool connecting { get; }
	public static bool connectedAndReady { get; }
	public static ConnectionState connectionState { get; }
	public static ClientState connectionStateDetailed { get; }
	public static ServerConnection Server { get; }
	public static AuthenticationValues AuthValues { get; set; }
	public static Room room { get; }
	public static PhotonPlayer player { get; }
	public static PhotonPlayer masterClient { get; }
	public static string playerName { get; set; }
	public static PhotonPlayer[] playerList { get; }
	public static PhotonPlayer[] otherPlayers { get; }
	public static List`1 Friends { get; set; }
	public static int FriendsListAge { get; }
	public static IPunPrefabPool PrefabPool { get; set; }
	public static bool offlineMode { get; set; }
	public static bool automaticallySyncScene { get; set; }
	public static bool autoCleanUpPlayerObjects { get; set; }
	public static bool autoJoinLobby { get; set; }
	public static bool EnableLobbyStatistics { get; set; }
	public static List`1 LobbyStatistics { get; set; }
	public static bool insideLobby { get; }
	public static TypedLobby lobby { get; set; }
	public static int sendRate { get; set; }
	public static int sendRateOnSerialize { get; set; }
	public static bool isMessageQueueRunning { get; set; }
	public static double time { get; }
	public static int ServerTimestamp { get; }
	public static bool isMasterClient { get; }
	public static bool inRoom { get; }
	public static bool isNonMasterClientInRoom { get; }
	public static int countOfPlayersOnMaster { get; }
	public static int countOfPlayersInRooms { get; }
	public static int countOfPlayers { get; }
	public static int countOfRooms { get; }
	public static bool NetworkStatisticsEnabled { get; set; }
	public static int ResentReliableCommands { get; }
	public static bool CrcCheckEnabled { get; set; }
	public static int PacketLossByCrcCheck { get; }
	public static int MaxResendsBeforeDisconnect { get; set; }
	public static int QuickResends { get; set; }
	public static bool UseAlternativeUdpPorts { get; set; }

	// Methods

	// RVA: 0x6CF5E05CD4 Offset: 0xDAECD4 VA: 0x6CF5E05CD4
	public static string get_gameVersion() { }

	// RVA: 0x6CF5E05D2C Offset: 0xDAED2C VA: 0x6CF5E05D2C
	public static void set_gameVersion(string value) { }

	// RVA: 0x6CF5E05D88 Offset: 0xDAED88 VA: 0x6CF5E05D88
	public static string get_ServerAddress() { }

	// RVA: 0x6CF5E05E30 Offset: 0xDAEE30 VA: 0x6CF5E05E30
	public static CloudRegionCode get_CloudRegion() { }

	// RVA: 0x6CF5E05EEC Offset: 0xDAEEEC VA: 0x6CF5E05EEC
	public static string get_CurrentCluster() { }

	// RVA: 0x6CF5E041DC Offset: 0xDAD1DC VA: 0x6CF5E041DC
	public static bool get_connected() { }

	// RVA: 0x6CF5E05F74 Offset: 0xDAEF74 VA: 0x6CF5E05F74
	public static bool get_connecting() { }

	// RVA: 0x6CF5E06034 Offset: 0xDAF034 VA: 0x6CF5E06034
	public static bool get_connectedAndReady() { }

	// RVA: 0x6CF5E06134 Offset: 0xDAF134 VA: 0x6CF5E06134
	public static ConnectionState get_connectionState() { }

	// RVA: 0x6CF5E03D5C Offset: 0xDACD5C VA: 0x6CF5E03D5C
	public static ClientState get_connectionStateDetailed() { }

	// RVA: 0x6CF5E04F78 Offset: 0xDADF78 VA: 0x6CF5E04F78
	public static ServerConnection get_Server() { }

	// RVA: 0x6CF5E06234 Offset: 0xDAF234 VA: 0x6CF5E06234
	public static AuthenticationValues get_AuthValues() { }

	// RVA: 0x6CF5E062BC Offset: 0xDAF2BC VA: 0x6CF5E062BC
	public static void set_AuthValues(AuthenticationValues value) { }

	// RVA: 0x6CF5E06340 Offset: 0xDAF340 VA: 0x6CF5E06340
	public static Room get_room() { }

	// RVA: 0x6CF5E063E4 Offset: 0xDAF3E4 VA: 0x6CF5E063E4
	public static PhotonPlayer get_player() { }

	// RVA: 0x6CF5E0646C Offset: 0xDAF46C VA: 0x6CF5E0646C
	public static PhotonPlayer get_masterClient() { }

	// RVA: 0x6CF5E0657C Offset: 0xDAF57C VA: 0x6CF5E0657C
	public static string get_playerName() { }

	// RVA: 0x6CF5E065E0 Offset: 0xDAF5E0 VA: 0x6CF5E065E0
	public static void set_playerName(string value) { }

	// RVA: 0x6CF5E0664C Offset: 0xDAF64C VA: 0x6CF5E0664C
	public static PhotonPlayer[] get_playerList() { }

	// RVA: 0x6CF5E066F4 Offset: 0xDAF6F4 VA: 0x6CF5E066F4
	public static PhotonPlayer[] get_otherPlayers() { }

	// RVA: 0x6CF5E0679C Offset: 0xDAF79C VA: 0x6CF5E0679C
	public static List`1 get_Friends() { }

	// RVA: 0x6CF5E067F4 Offset: 0xDAF7F4 VA: 0x6CF5E067F4
	internal static void set_Friends(List`1 value) { }

	// RVA: 0x6CF5E06850 Offset: 0xDAF850 VA: 0x6CF5E06850
	public static int get_FriendsListAge() { }

	// RVA: 0x6CF5E068E4 Offset: 0xDAF8E4 VA: 0x6CF5E068E4
	public static IPunPrefabPool get_PrefabPool() { }

	// RVA: 0x6CF5E06948 Offset: 0xDAF948 VA: 0x6CF5E06948
	public static void set_PrefabPool(IPunPrefabPool value) { }

	// RVA: 0x6CF5E069B0 Offset: 0xDAF9B0 VA: 0x6CF5E069B0
	public static bool get_offlineMode() { }

	// RVA: 0x6CF5E06A08 Offset: 0xDAFA08 VA: 0x6CF5E06A08
	public static void set_offlineMode(bool value) { }

	// RVA: 0x6CF5E06C54 Offset: 0xDAFC54 VA: 0x6CF5E06C54
	public static bool get_automaticallySyncScene() { }

	// RVA: 0x6CF5E06CAC Offset: 0xDAFCAC VA: 0x6CF5E06CAC
	public static void set_automaticallySyncScene(bool value) { }

	// RVA: 0x6CF5E06D64 Offset: 0xDAFD64 VA: 0x6CF5E06D64
	public static bool get_autoCleanUpPlayerObjects() { }

	// RVA: 0x6CF5E06DBC Offset: 0xDAFDBC VA: 0x6CF5E06DBC
	public static void set_autoCleanUpPlayerObjects(bool value) { }

	// RVA: 0x6CF5E06E80 Offset: 0xDAFE80 VA: 0x6CF5E06E80
	public static bool get_autoJoinLobby() { }

	// RVA: 0x6CF5E06EE4 Offset: 0xDAFEE4 VA: 0x6CF5E06EE4
	public static void set_autoJoinLobby(bool value) { }

	// RVA: 0x6CF5E06F50 Offset: 0xDAFF50 VA: 0x6CF5E06F50
	public static bool get_EnableLobbyStatistics() { }

	// RVA: 0x6CF5E06FB4 Offset: 0xDAFFB4 VA: 0x6CF5E06FB4
	public static void set_EnableLobbyStatistics(bool value) { }

	// RVA: 0x6CF5E07020 Offset: 0xDB0020 VA: 0x6CF5E07020
	public static List`1 get_LobbyStatistics() { }

	// RVA: 0x6CF5E07084 Offset: 0xDB0084 VA: 0x6CF5E07084
	private static void set_LobbyStatistics(List`1 value) { }

	// RVA: 0x6CF5E070EC Offset: 0xDB00EC VA: 0x6CF5E070EC
	public static bool get_insideLobby() { }

	// RVA: 0x6CF5E07150 Offset: 0xDB0150 VA: 0x6CF5E07150
	public static TypedLobby get_lobby() { }

	// RVA: 0x6CF5E071B4 Offset: 0xDB01B4 VA: 0x6CF5E071B4
	public static void set_lobby(TypedLobby value) { }

	// RVA: 0x6CF5E033A8 Offset: 0xDAC3A8 VA: 0x6CF5E033A8
	public static int get_sendRate() { }

	// RVA: 0x6CF5E0721C Offset: 0xDB021C VA: 0x6CF5E0721C
	public static void set_sendRate(int value) { }

	// RVA: 0x6CF5E03408 Offset: 0xDAC408 VA: 0x6CF5E03408
	public static int get_sendRateOnSerialize() { }

	// RVA: 0x6CF5E07328 Offset: 0xDB0328 VA: 0x6CF5E07328
	public static void set_sendRateOnSerialize(int value) { }

	// RVA: 0x6CF5E0746C Offset: 0xDB046C VA: 0x6CF5E0746C
	public static bool get_isMessageQueueRunning() { }

	// RVA: 0x6CF5E074C4 Offset: 0xDB04C4 VA: 0x6CF5E074C4
	public static void set_isMessageQueueRunning(bool value) { }

	// RVA: 0x6CF5E07544 Offset: 0xDB0544 VA: 0x6CF5E07544
	public static double get_time() { }

	// RVA: 0x6CF5E075A4 Offset: 0xDB05A4 VA: 0x6CF5E075A4
	public static int get_ServerTimestamp() { }

	// RVA: 0x6CF5E07684 Offset: 0xDB0684 VA: 0x6CF5E07684
	public static bool get_isMasterClient() { }

	// RVA: 0x6CF5E07758 Offset: 0xDB0758 VA: 0x6CF5E07758
	public static bool get_inRoom() { }

	// RVA: 0x6CF5E077B0 Offset: 0xDB07B0 VA: 0x6CF5E077B0
	public static bool get_isNonMasterClientInRoom() { }

	// RVA: 0x6CF5E07828 Offset: 0xDB0828 VA: 0x6CF5E07828
	public static int get_countOfPlayersOnMaster() { }

	// RVA: 0x6CF5E0788C Offset: 0xDB088C VA: 0x6CF5E0788C
	public static int get_countOfPlayersInRooms() { }

	// RVA: 0x6CF5E078F0 Offset: 0xDB08F0 VA: 0x6CF5E078F0
	public static int get_countOfPlayers() { }

	// RVA: 0x6CF5E0795C Offset: 0xDB095C VA: 0x6CF5E0795C
	public static int get_countOfRooms() { }

	// RVA: 0x6CF5E079C0 Offset: 0xDB09C0 VA: 0x6CF5E079C0
	public static bool get_NetworkStatisticsEnabled() { }

	// RVA: 0x6CF5E07A24 Offset: 0xDB0A24 VA: 0x6CF5E07A24
	public static void set_NetworkStatisticsEnabled(bool value) { }

	// RVA: 0x6CF5E07A90 Offset: 0xDB0A90 VA: 0x6CF5E07A90
	public static int get_ResentReliableCommands() { }

	// RVA: 0x6CF5E07AF4 Offset: 0xDB0AF4 VA: 0x6CF5E07AF4
	public static bool get_CrcCheckEnabled() { }

	// RVA: 0x6CF5E07B58 Offset: 0xDB0B58 VA: 0x6CF5E07B58
	public static void set_CrcCheckEnabled(bool value) { }

	// RVA: 0x6CF5E07CC8 Offset: 0xDB0CC8 VA: 0x6CF5E07CC8
	public static int get_PacketLossByCrcCheck() { }

	// RVA: 0x6CF5E07D2C Offset: 0xDB0D2C VA: 0x6CF5E07D2C
	public static int get_MaxResendsBeforeDisconnect() { }

	// RVA: 0x6CF5E07D90 Offset: 0xDB0D90 VA: 0x6CF5E07D90
	public static void set_MaxResendsBeforeDisconnect(int value) { }

	// RVA: 0x6CF5E07E10 Offset: 0xDB0E10 VA: 0x6CF5E07E10
	public static int get_QuickResends() { }

	// RVA: 0x6CF5E07E7C Offset: 0xDB0E7C VA: 0x6CF5E07E7C
	public static void set_QuickResends(int value) { }

	// RVA: 0x6CF5E07EF4 Offset: 0xDB0EF4 VA: 0x6CF5E07EF4
	public static bool get_UseAlternativeUdpPorts() { }

	// RVA: 0x6CF5E07F4C Offset: 0xDB0F4C VA: 0x6CF5E07F4C
	public static void set_UseAlternativeUdpPorts(bool value) { }

	// RVA: 0x6CF5E07FAC Offset: 0xDB0FAC VA: 0x6CF5E07FAC
	public static void add_OnEventCall(EventCallback value) { }

	// RVA: 0x6CF5E08088 Offset: 0xDB1088 VA: 0x6CF5E08088
	public static void remove_OnEventCall(EventCallback value) { }

	// RVA: 0x6CF5E08164 Offset: 0xDB1164 VA: 0x6CF5E08164
	private static void .cctor() { }

	// RVA: 0x6CF5E08670 Offset: 0xDB1670 VA: 0x6CF5E08670
	public static void SwitchToProtocol(ConnectionProtocol cp) { }

	// RVA: 0x6CF5E086D8 Offset: 0xDB16D8 VA: 0x6CF5E086D8
	public static bool ConnectUsingSettings(string gameVersion) { }

	// RVA: 0x6CF5E08E64 Offset: 0xDB1E64 VA: 0x6CF5E08E64
	public static bool ConnectToMaster(string masterServerAddress, int port, string appID, string gameVersion) { }

	// RVA: 0x6CF5E091A4 Offset: 0xDB21A4 VA: 0x6CF5E091A4
	public static bool Reconnect() { }

	// RVA: 0x6CF5E094B4 Offset: 0xDB24B4 VA: 0x6CF5E094B4
	public static bool ReconnectAndRejoin() { }

	// RVA: 0x6CF5E08C04 Offset: 0xDB1C04 VA: 0x6CF5E08C04
	public static bool ConnectToBestCloudServer(string gameVersion) { }

	// RVA: 0x6CF5E097EC Offset: 0xDB27EC VA: 0x6CF5E097EC
	public static bool ConnectToRegion(CloudRegionCode region, string gameVersion, string cluster) { }

	// RVA: 0x6CF5E09AF4 Offset: 0xDB2AF4 VA: 0x6CF5E09AF4
	public static void OverrideBestCloudServer(CloudRegionCode region) { }

	// RVA: 0x6CF5E09AF8 Offset: 0xDB2AF8 VA: 0x6CF5E09AF8
	public static void RefreshCloudServerRating() { }

	// RVA: 0x6CF5E09B44 Offset: 0xDB2B44 VA: 0x6CF5E09B44
	public static void NetworkStatisticsReset() { }

	// RVA: 0x6CF5E09BA8 Offset: 0xDB2BA8 VA: 0x6CF5E09BA8
	public static string NetworkStatisticsToString() { }

	// RVA: 0x6CF5E09C9C Offset: 0xDB2C9C VA: 0x6CF5E09C9C
	public static void InitializeSecurity() { }

	// RVA: 0x6CF5E09CA0 Offset: 0xDB2CA0 VA: 0x6CF5E09CA0
	private static bool VerifyCanUseNetwork() { }

	// RVA: 0x6CF5E03730 Offset: 0xDAC730 VA: 0x6CF5E03730
	public static void Disconnect() { }

	// RVA: 0x6CF5E09D40 Offset: 0xDB2D40 VA: 0x6CF5E09D40
	public static bool FindFriends(String[] friendsToFind, FindFriendsOptions options) { }

	// RVA: 0x6CF5E09E10 Offset: 0xDB2E10 VA: 0x6CF5E09E10
	public static bool CreateRoom(string roomName) { }

	// RVA: 0x6CF5E0A0DC Offset: 0xDB30DC VA: 0x6CF5E0A0DC
	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby) { }

	// RVA: 0x6CF5E09E70 Offset: 0xDB2E70 VA: 0x6CF5E09E70
	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, String[] expectedUsers) { }

	// RVA: 0x6CF5E0A350 Offset: 0xDB3350 VA: 0x6CF5E0A350
	public static bool JoinRoom(string roomName) { }

	// RVA: 0x6CF5E0A3A8 Offset: 0xDB33A8 VA: 0x6CF5E0A3A8
	public static bool JoinRoom(string roomName, String[] expectedUsers) { }

	// RVA: 0x6CF5E0A5F0 Offset: 0xDB35F0 VA: 0x6CF5E0A5F0
	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby) { }

	// RVA: 0x6CF5E0A660 Offset: 0xDB3660 VA: 0x6CF5E0A660
	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, String[] expectedUsers) { }

	// RVA: 0x6CF5E0A92C Offset: 0xDB392C VA: 0x6CF5E0A92C
	public static bool JoinRandomRoom() { }

	// RVA: 0x6CF5E0AC34 Offset: 0xDB3C34 VA: 0x6CF5E0AC34
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers) { }

	// RVA: 0x6CF5E0A990 Offset: 0xDB3990 VA: 0x6CF5E0A990
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, String[] expectedUsers) { }

	// RVA: 0x6CF5E0ACA8 Offset: 0xDB3CA8 VA: 0x6CF5E0ACA8
	public static bool ReJoinRoom(string roomName) { }

	// RVA: 0x6CF5E0A14C Offset: 0xDB314C VA: 0x6CF5E0A14C
	private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom) { }

	// RVA: 0x6CF5E0AF58 Offset: 0xDB3F58 VA: 0x6CF5E0AF58
	public static bool JoinLobby() { }

	// RVA: 0x6CF5E0AFA8 Offset: 0xDB3FA8 VA: 0x6CF5E0AFA8
	public static bool JoinLobby(TypedLobby typedLobby) { }

	// RVA: 0x6CF5E0B0B8 Offset: 0xDB40B8 VA: 0x6CF5E0B0B8
	public static bool LeaveLobby() { }

	// RVA: 0x6CF5E0B164 Offset: 0xDB4164 VA: 0x6CF5E0B164
	public static bool LeaveRoom(bool becomeInactive) { }

	// RVA: 0x6CF5E0B3FC Offset: 0xDB43FC VA: 0x6CF5E0B3FC
	public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter) { }

	// RVA: 0x6CF5E0B480 Offset: 0xDB4480 VA: 0x6CF5E0B480
	public static RoomInfo[] GetRoomList() { }

	// RVA: 0x6CF5E0B574 Offset: 0xDB4574 VA: 0x6CF5E0B574
	public static void SetPlayerCustomProperties(Hashtable customProperties) { }

	// RVA: 0x6CF5E0BD1C Offset: 0xDB4D1C VA: 0x6CF5E0BD1C
	public static void RemovePlayerCustomProperties(String[] customPropertiesToDelete) { }

	// RVA: 0x6CF5E0BEA8 Offset: 0xDB4EA8 VA: 0x6CF5E0BEA8
	public static bool RaiseEvent(byte eventCode, object eventContent, bool sendReliable, RaiseEventOptions options) { }

	// RVA: 0x6CF5E0BFC4 Offset: 0xDB4FC4 VA: 0x6CF5E0BFC4
	public static int AllocateViewID() { }

	// RVA: 0x6CF5E0C394 Offset: 0xDB5394 VA: 0x6CF5E0C394
	public static int AllocateSceneViewID() { }

	// RVA: 0x6CF5E0C0A4 Offset: 0xDB50A4 VA: 0x6CF5E0C0A4
	private static int AllocateViewID(int ownerId) { }

	// RVA: 0x6CF5E0C4D0 Offset: 0xDB54D0 VA: 0x6CF5E0C4D0
	private static Int32[] AllocateSceneViewIDs(int countOfNewViews) { }

	// RVA: 0x6CF5E0C594 Offset: 0xDB5594 VA: 0x6CF5E0C594
	public static void UnAllocateViewID(int viewID) { }

	// RVA: 0x6CF5E0C734 Offset: 0xDB5734 VA: 0x6CF5E0C734
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group) { }

	// RVA: 0x6CF5E0C7F4 Offset: 0xDB57F4 VA: 0x6CF5E0C7F4
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group, Object[] data) { }

	// RVA: 0x6CF5E0CD1C Offset: 0xDB5D1C VA: 0x6CF5E0CD1C
	public static GameObject InstantiateSceneObject(string prefabName, Vector3 position, Quaternion rotation, byte group, Object[] data) { }

	// RVA: 0x6CF5E0D268 Offset: 0xDB6268 VA: 0x6CF5E0D268
	public static int GetPing() { }

	// RVA: 0x6CF5E0D2CC Offset: 0xDB62CC VA: 0x6CF5E0D2CC
	public static void FetchServerTimestamp() { }

	// RVA: 0x6CF5E0D360 Offset: 0xDB6360 VA: 0x6CF5E0D360
	public static void SendOutgoingCommands() { }

	// RVA: 0x6CF5E0D3E8 Offset: 0xDB63E8 VA: 0x6CF5E0D3E8
	public static bool CloseConnection(PhotonPlayer kickPlayer) { }

	// RVA: 0x6CF5E0D608 Offset: 0xDB6608 VA: 0x6CF5E0D608
	public static bool SetMasterClient(PhotonPlayer masterClientPlayer) { }

	// RVA: 0x6CF5E0D934 Offset: 0xDB6934 VA: 0x6CF5E0D934
	public static void Destroy(PhotonView targetView) { }

	// RVA: 0x6CF5E0DA48 Offset: 0xDB6A48 VA: 0x6CF5E0DA48
	public static void Destroy(GameObject targetGo) { }

	// RVA: 0x6CF5E0DAC4 Offset: 0xDB6AC4 VA: 0x6CF5E0DAC4
	public static void DestroyPlayerObjects(PhotonPlayer targetPlayer) { }

	// RVA: 0x6CF5E0DB80 Offset: 0xDB6B80 VA: 0x6CF5E0DB80
	public static void DestroyPlayerObjects(int targetPlayerId) { }

	// RVA: 0x6CF5E0DD0C Offset: 0xDB6D0C VA: 0x6CF5E0DD0C
	public static void DestroyAll() { }

	// RVA: 0x6CF5E0DDD8 Offset: 0xDB6DD8 VA: 0x6CF5E0DDD8
	public static void RemoveRPCs(PhotonPlayer targetPlayer) { }

	// RVA: 0x6CF5E0DED8 Offset: 0xDB6ED8 VA: 0x6CF5E0DED8
	public static void RemoveRPCs(PhotonView targetPhotonView) { }

	// RVA: 0x6CF5E0DF68 Offset: 0xDB6F68 VA: 0x6CF5E0DF68
	public static void RemoveRPCsInGroup(int targetGroup) { }

	// RVA: 0x6CF5E0DFF8 Offset: 0xDB6FF8 VA: 0x6CF5E0DFF8
	internal static void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, Object[] parameters) { }

	// RVA: 0x6CF5E0E23C Offset: 0xDB723C VA: 0x6CF5E0E23C
	internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, bool encrpyt, Object[] parameters) { }

	// RVA: 0x6CF5E0E470 Offset: 0xDB7470 VA: 0x6CF5E0E470
	public static void CacheSendMonoMessageTargets(Type type) { }

	// RVA: 0x6CF5E0E52C Offset: 0xDB752C VA: 0x6CF5E0E52C
	public static HashSet`1 FindGameObjectsWithComponent(Type type) { }

	// RVA: 0x6CF5E0E6B8 Offset: 0xDB76B8 VA: 0x6CF5E0E6B8
	public static void SetReceivingEnabled(int group, bool enabled) { }

	// RVA: 0x6CF5E0E744 Offset: 0xDB7744 VA: 0x6CF5E0E744
	public static void SetInterestGroups(byte group, bool enabled) { }

	// RVA: 0x6CF5E0E830 Offset: 0xDB7830 VA: 0x6CF5E0E830
	public static void SetReceivingEnabled(Int32[] enableGroups, Int32[] disableGroups) { }

	// RVA: 0x6CF5E0E950 Offset: 0xDB7950 VA: 0x6CF5E0E950
	public static void SetInterestGroups(Byte[] disableGroups, Byte[] enableGroups) { }

	// RVA: 0x6CF5E0E9F4 Offset: 0xDB79F4 VA: 0x6CF5E0E9F4
	public static void SetSendingEnabled(int group, bool enabled) { }

	// RVA: 0x6CF5E0EA58 Offset: 0xDB7A58 VA: 0x6CF5E0EA58
	public static void SetSendingEnabled(byte group, bool enabled) { }

	// RVA: 0x6CF5E0EAFC Offset: 0xDB7AFC VA: 0x6CF5E0EAFC
	public static void SetSendingEnabled(Int32[] enableGroups, Int32[] disableGroups) { }

	// RVA: 0x6CF5E0EBD4 Offset: 0xDB7BD4 VA: 0x6CF5E0EBD4
	public static void SetSendingEnabled(Byte[] disableGroups, Byte[] enableGroups) { }

	// RVA: 0x6CF5E0EC78 Offset: 0xDB7C78 VA: 0x6CF5E0EC78
	public static void SetLevelPrefix(short prefix) { }

	// RVA: 0x6CF5E0ECF8 Offset: 0xDB7CF8 VA: 0x6CF5E0ECF8
	public static void LoadLevel(int levelNumber) { }

	// RVA: 0x6CF5E0EE5C Offset: 0xDB7E5C VA: 0x6CF5E0EE5C
	public static AsyncOperation LoadLevelAsync(int levelNumber) { }

	// RVA: 0x6CF5E0EFC4 Offset: 0xDB7FC4 VA: 0x6CF5E0EFC4
	public static void LoadLevel(string levelName) { }

	// RVA: 0x6CF5E0F0F4 Offset: 0xDB80F4 VA: 0x6CF5E0F0F4
	public static AsyncOperation LoadLevelAsync(string levelName) { }

	// RVA: 0x6CF5E0F230 Offset: 0xDB8230 VA: 0x6CF5E0F230
	public static bool WebRpc(string name, object parameters) { }

	// RVA: 0x6CF5E0F2AC Offset: 0xDB82AC VA: 0x6CF5E0F2AC
	public static bool CallEvent(byte eventCode, object content, int senderId) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonPlayer : Object, IComparable`1, IComparable`1, IEquatable`1, IEquatable`1
{
	// Fields

	private int actorID; // 0x10
	private string nameField; // 0x18
	private string <UserId>k__BackingField; // 0x20
	public readonly bool IsLocal; // 0x28
	private bool <IsInactive>k__BackingField; // 0x29
	private Hashtable <CustomProperties>k__BackingField; // 0x30
	public object TagObject; // 0x38

	// Properties

	public int ID { get; }
	public string NickName { get; set; }
	public string UserId { get; set; }
	public bool IsMasterClient { get; }
	public bool IsInactive { get; set; }
	public Hashtable CustomProperties { get; set; }
	public Hashtable AllProperties { get; }
	public string name { get; set; }
	public string userId { get; set; }
	public bool isLocal { get; }
	public bool isMasterClient { get; }
	public bool isInactive { get; set; }
	public Hashtable customProperties { get; set; }
	public Hashtable allProperties { get; }

	// Methods

	// RVA: 0x6CF5E0F59C Offset: 0xDB859C VA: 0x6CF5E0F59C
	public int get_ID() { }

	// RVA: 0x6CF5E0F5A4 Offset: 0xDB85A4 VA: 0x6CF5E0F5A4
	public string get_NickName() { }

	// RVA: 0x6CF5E0F5AC Offset: 0xDB85AC VA: 0x6CF5E0F5AC
	public void set_NickName(string value) { }

	// RVA: 0x6CF5E0F694 Offset: 0xDB8694 VA: 0x6CF5E0F694
	public string get_UserId() { }

	// RVA: 0x6CF5E0F69C Offset: 0xDB869C VA: 0x6CF5E0F69C
	internal void set_UserId(string value) { }

	// RVA: 0x6CF5E0D590 Offset: 0xDB6590 VA: 0x6CF5E0D590
	public bool get_IsMasterClient() { }

	// RVA: 0x6CF5E0F6A4 Offset: 0xDB86A4 VA: 0x6CF5E0F6A4
	public bool get_IsInactive() { }

	// RVA: 0x6CF5E0F6AC Offset: 0xDB86AC VA: 0x6CF5E0F6AC
	public void set_IsInactive(bool value) { }

	// RVA: 0x6CF5E0F6B8 Offset: 0xDB86B8 VA: 0x6CF5E0F6B8
	public Hashtable get_CustomProperties() { }

	// RVA: 0x6CF5E0F6C0 Offset: 0xDB86C0 VA: 0x6CF5E0F6C0
	internal void set_CustomProperties(Hashtable value) { }

	// RVA: 0x6CF5E0F6C8 Offset: 0xDB86C8 VA: 0x6CF5E0F6C8
	public Hashtable get_AllProperties() { }

	// RVA: 0x6CF5E0F7A4 Offset: 0xDB87A4 VA: 0x6CF5E0F7A4
	public void .ctor(bool isLocal, int actorID, string name) { }

	// RVA: 0x6CF5E0F858 Offset: 0xDB8858 VA: 0x6CF5E0F858
	protected internal void .ctor(bool isLocal, int actorID, Hashtable properties) { }

	// RVA: 0x6CF5E0F910 Offset: 0xDB8910 VA: 0x6CF5E0F910
	public override bool Equals(object p) { }

	// RVA: 0x6CF5E0F9C4 Offset: 0xDB89C4 VA: 0x6CF5E0F9C4
	public override int GetHashCode() { }

	// RVA: 0x6CF5E0F9CC Offset: 0xDB89CC VA: 0x6CF5E0F9CC
	internal void InternalChangeLocalID(int newID) { }

	// RVA: 0x6CF5E0BAB0 Offset: 0xDB4AB0 VA: 0x6CF5E0BAB0
	internal void InternalCacheProperties(Hashtable properties) { }

	// RVA: 0x6CF5E0B810 Offset: 0xDB4810 VA: 0x6CF5E0B810
	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues, bool webForward) { }

	// RVA: 0x6CF5E0FA54 Offset: 0xDB8A54 VA: 0x6CF5E0FA54
	public static PhotonPlayer Find(int ID) { }

	// RVA: 0x6CF5E0FAF0 Offset: 0xDB8AF0 VA: 0x6CF5E0FAF0
	public PhotonPlayer Get(int id) { }

	// RVA: 0x6CF5E0FAF8 Offset: 0xDB8AF8 VA: 0x6CF5E0FAF8
	public PhotonPlayer GetNext() { }

	// RVA: 0x6CF5E0FD84 Offset: 0xDB8D84 VA: 0x6CF5E0FD84
	public PhotonPlayer GetNextFor(PhotonPlayer currentPlayer) { }

	// RVA: 0x6CF5E0FB00 Offset: 0xDB8B00 VA: 0x6CF5E0FB00
	public PhotonPlayer GetNextFor(int currentPlayerId) { }

	// RVA: 0x6CF5E0FD98 Offset: 0xDB8D98 VA: 0x6CF5E0FD98
	public int CompareTo(PhotonPlayer other) { }

	// RVA: 0x6CF5E0FDEC Offset: 0xDB8DEC VA: 0x6CF5E0FDEC
	public int CompareTo(int other) { }

	// RVA: 0x6CF5E0FE28 Offset: 0xDB8E28 VA: 0x6CF5E0FE28
	public bool Equals(PhotonPlayer other) { }

	// RVA: 0x6CF5E0FE80 Offset: 0xDB8E80 VA: 0x6CF5E0FE80
	public bool Equals(int other) { }

	// RVA: 0x6CF5E0FEC0 Offset: 0xDB8EC0 VA: 0x6CF5E0FEC0
	public override string ToString() { }

	// RVA: 0x6CF5E10048 Offset: 0xDB9048 VA: 0x6CF5E10048
	public string ToStringFull() { }

	// RVA: 0x6CF5E1021C Offset: 0xDB921C VA: 0x6CF5E1021C
	public string get_name() { }

	// RVA: 0x6CF5E10224 Offset: 0xDB9224 VA: 0x6CF5E10224
	public void set_name(string value) { }

	// RVA: 0x6CF5E10228 Offset: 0xDB9228 VA: 0x6CF5E10228
	public string get_userId() { }

	// RVA: 0x6CF5E10230 Offset: 0xDB9230 VA: 0x6CF5E10230
	internal void set_userId(string value) { }

	// RVA: 0x6CF5E10238 Offset: 0xDB9238 VA: 0x6CF5E10238
	public bool get_isLocal() { }

	// RVA: 0x6CF5E10240 Offset: 0xDB9240 VA: 0x6CF5E10240
	public bool get_isMasterClient() { }

	// RVA: 0x6CF5E10244 Offset: 0xDB9244 VA: 0x6CF5E10244
	public bool get_isInactive() { }

	// RVA: 0x6CF5E1024C Offset: 0xDB924C VA: 0x6CF5E1024C
	public void set_isInactive(bool value) { }

	// RVA: 0x6CF5E10258 Offset: 0xDB9258 VA: 0x6CF5E10258
	public Hashtable get_customProperties() { }

	// RVA: 0x6CF5E10260 Offset: 0xDB9260 VA: 0x6CF5E10260
	internal void set_customProperties(Hashtable value) { }

	// RVA: 0x6CF5E10268 Offset: 0xDB9268 VA: 0x6CF5E10268
	public Hashtable get_allProperties() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonStatsGui : MonoBehaviour
{
	// Fields

	public bool statsWindowOn; // 0x20
	public bool statsOn; // 0x21
	public bool healthStatsVisible; // 0x22
	public bool trafficStatsOn; // 0x23
	public bool buttonsOn; // 0x24
	public Rect statsRect; // 0x28
	public int WindowId; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E1026C Offset: 0xDB926C VA: 0x6CF5E1026C
	public void Start() { }

	// RVA: 0x6CF5E102A0 Offset: 0xDB92A0 VA: 0x6CF5E102A0
	public void Update() { }

	// RVA: 0x6CF5E102E4 Offset: 0xDB92E4 VA: 0x6CF5E102E4
	public void OnGUI() { }

	// RVA: 0x6CF5E104A0 Offset: 0xDB94A0 VA: 0x6CF5E104A0
	public void TrafficStatsWindow(int windowID) { }

	// RVA: 0x6CF5E11438 Offset: 0xDBA438 VA: 0x6CF5E11438
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonStreamQueue : Object
{
	// Fields

	private int m_SampleRate; // 0x10
	private int m_SampleCount; // 0x14
	private int m_ObjectsPerSample; // 0x18
	private float m_LastSampleTime; // 0x1C
	private int m_LastFrameCount; // 0x20
	private int m_NextObjectIndex; // 0x24
	private List`1 m_Objects; // 0x28
	private bool m_IsWriting; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5E1145C Offset: 0xDBA45C VA: 0x6CF5E1145C
	public void .ctor(int sampleRate) { }

	// RVA: 0x6CF5E114F4 Offset: 0xDBA4F4 VA: 0x6CF5E114F4
	private void BeginWritePackage() { }

	// RVA: 0x6CF5E11788 Offset: 0xDBA788 VA: 0x6CF5E11788
	public void Reset() { }

	// RVA: 0x6CF5E11808 Offset: 0xDBA808 VA: 0x6CF5E11808
	public void SendNext(object obj) { }

	// RVA: 0x6CF5E118DC Offset: 0xDBA8DC VA: 0x6CF5E118DC
	public bool HasQueuedObjects() { }

	// RVA: 0x6CF5E118EC Offset: 0xDBA8EC VA: 0x6CF5E118EC
	public object ReceiveNext() { }

	// RVA: 0x6CF5E11980 Offset: 0xDBA980 VA: 0x6CF5E11980
	public void Serialize(PhotonStream stream) { }

	// RVA: 0x6CF5E11AC4 Offset: 0xDBAAC4 VA: 0x6CF5E11AC4
	public void Deserialize(PhotonStream stream) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ViewSynchronization
{
	// Fields

	public int value__; // 0x10
	public const ViewSynchronization Off = 0; // 0x0
	public const ViewSynchronization ReliableDeltaCompressed = 1; // 0x0
	public const ViewSynchronization Unreliable = 2; // 0x0
	public const ViewSynchronization UnreliableOnChange = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum OnSerializeTransform
{
	// Fields

	public int value__; // 0x10
	public const OnSerializeTransform OnlyPosition = 0; // 0x0
	public const OnSerializeTransform OnlyRotation = 1; // 0x0
	public const OnSerializeTransform OnlyScale = 2; // 0x0
	public const OnSerializeTransform PositionAndRotation = 3; // 0x0
	public const OnSerializeTransform All = 4; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum OnSerializeRigidBody
{
	// Fields

	public int value__; // 0x10
	public const OnSerializeRigidBody OnlyVelocity = 0; // 0x0
	public const OnSerializeRigidBody OnlyAngularVelocity = 1; // 0x0
	public const OnSerializeRigidBody All = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum OwnershipOption
{
	// Fields

	public int value__; // 0x10
	public const OwnershipOption Fixed = 0; // 0x0
	public const OwnershipOption Takeover = 1; // 0x0
	public const OwnershipOption Request = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonView : MonoBehaviour
{
	// Fields

	public int ownerId; // 0x28
	public byte group; // 0x2C
	protected internal bool mixedModeIsReliable; // 0x2D
	public bool OwnerShipWasTransfered; // 0x2E
	public int prefixBackup; // 0x30
	internal Object[] instantiationDataField; // 0x38
	protected internal Object[] lastOnSerializeDataSent; // 0x40
	protected internal Object[] lastOnSerializeDataReceived; // 0x48
	public ViewSynchronization synchronization; // 0x50
	public OnSerializeTransform onSerializeTransformOption; // 0x54
	public OnSerializeRigidBody onSerializeRigidBodyOption; // 0x58
	public OwnershipOption ownershipTransfer; // 0x5C
	public List`1 ObservedComponents; // 0x60
	private Dictionary`2 m_OnSerializeMethodInfos; // 0x68
	private int viewIdField; // 0x70
	public int instantiationId; // 0x74
	public int currentMasterID; // 0x78
	protected internal bool didAwake; // 0x7C
	protected internal bool isRuntimeInstantiated; // 0x7D
	protected internal bool removedFromLocalViewList; // 0x7E
	internal MonoBehaviour[] RpcMonoBehaviours; // 0x80
	private MethodInfo OnSerializeMethodInfo; // 0x88
	private bool failedToFindOnSerialize; // 0x90

	// Properties

	public int prefix { get; set; }
	public Object[] instantiationData { get; set; }
	public int viewID { get; set; }
	public bool isSceneView { get; }
	public PhotonPlayer owner { get; }
	public int OwnerActorNr { get; }
	public bool isOwnerActive { get; }
	public int CreatorActorNr { get; }
	public bool isMine { get; }

	// Methods

	// RVA: 0x6CF5E11C78 Offset: 0xDBAC78 VA: 0x6CF5E11C78
	public int get_prefix() { }

	// RVA: 0x6CF5E11D14 Offset: 0xDBAD14 VA: 0x6CF5E11D14
	public void set_prefix(int value) { }

	// RVA: 0x6CF5E11D1C Offset: 0xDBAD1C VA: 0x6CF5E11D1C
	public Object[] get_instantiationData() { }

	// RVA: 0x6CF5E11DA0 Offset: 0xDBADA0 VA: 0x6CF5E11DA0
	public void set_instantiationData(Object[] value) { }

	// RVA: 0x6CF5E11DA8 Offset: 0xDBADA8 VA: 0x6CF5E11DA8
	public int get_viewID() { }

	// RVA: 0x6CF5E11DB0 Offset: 0xDBADB0 VA: 0x6CF5E11DB0
	public void set_viewID(int value) { }

	// RVA: 0x6CF5E11E80 Offset: 0xDBAE80 VA: 0x6CF5E11E80
	public bool get_isSceneView() { }

	// RVA: 0x6CF5E11EFC Offset: 0xDBAEFC VA: 0x6CF5E11EFC
	public PhotonPlayer get_owner() { }

	// RVA: 0x6CF5E11F04 Offset: 0xDBAF04 VA: 0x6CF5E11F04
	public int get_OwnerActorNr() { }

	// RVA: 0x6CF5E11F0C Offset: 0xDBAF0C VA: 0x6CF5E11F0C
	public bool get_isOwnerActive() { }

	// RVA: 0x6CF5E11E98 Offset: 0xDBAE98 VA: 0x6CF5E11E98
	public int get_CreatorActorNr() { }

	// RVA: 0x6CF5E11FAC Offset: 0xDBAFAC VA: 0x6CF5E11FAC
	public bool get_isMine() { }

	// RVA: 0x6CF5E1204C Offset: 0xDBB04C VA: 0x6CF5E1204C
	protected internal void Awake() { }

	// RVA: 0x6CF5E120EC Offset: 0xDBB0EC VA: 0x6CF5E120EC
	public void RequestOwnership() { }

	// RVA: 0x6CF5E1215C Offset: 0xDBB15C VA: 0x6CF5E1215C
	public void TransferOwnership(PhotonPlayer newOwner) { }

	// RVA: 0x6CF5E12174 Offset: 0xDBB174 VA: 0x6CF5E12174
	public void TransferOwnership(int newOwnerId) { }

	// RVA: 0x6CF5E121F8 Offset: 0xDBB1F8 VA: 0x6CF5E121F8
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5E1225C Offset: 0xDBB25C VA: 0x6CF5E1225C
	protected internal void OnDestroy() { }

	// RVA: 0x6CF5E123C4 Offset: 0xDBB3C4 VA: 0x6CF5E123C4
	public void SerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1298C Offset: 0xDBB98C VA: 0x6CF5E1298C
	public void DeserializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E12A54 Offset: 0xDBBA54 VA: 0x6CF5E12A54
	protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1248C Offset: 0xDBB48C VA: 0x6CF5E1248C
	protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E130D8 Offset: 0xDBC0D8 VA: 0x6CF5E130D8
	protected internal void ExecuteComponentOnSerialize(Component component, PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E134C8 Offset: 0xDBC4C8 VA: 0x6CF5E134C8
	public void RefreshRpcMonoBehaviourCache() { }

	// RVA: 0x6CF5E13518 Offset: 0xDBC518 VA: 0x6CF5E13518
	public void RPC(string methodName, PhotonTargets target, Object[] parameters) { }

	// RVA: 0x6CF5E13598 Offset: 0xDBC598 VA: 0x6CF5E13598
	public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, Object[] parameters) { }

	// RVA: 0x6CF5E1361C Offset: 0xDBC61C VA: 0x6CF5E1361C
	public void RPC(string methodName, PhotonPlayer targetPlayer, Object[] parameters) { }

	// RVA: 0x6CF5E1369C Offset: 0xDBC69C VA: 0x6CF5E1369C
	public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, Object[] parameters) { }

	// RVA: 0x6CF5E13720 Offset: 0xDBC720 VA: 0x6CF5E13720
	public static PhotonView Get(Component component) { }

	// RVA: 0x6CF5E13770 Offset: 0xDBC770 VA: 0x6CF5E13770
	public static PhotonView Get(GameObject gameObj) { }

	// RVA: 0x6CF5E137C0 Offset: 0xDBC7C0 VA: 0x6CF5E137C0
	public static PhotonView Find(int viewID) { }

	// RVA: 0x6CF5E1382C Offset: 0xDBC82C VA: 0x6CF5E1382C
	public override string ToString() { }

	// RVA: 0x6CF5E13A80 Offset: 0xDBCA80 VA: 0x6CF5E13A80
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <PingSocket>d__10 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Region region; // 0x20
	public PhotonPingManager <>4__this; // 0x28
	private PhotonPing <ping>5__2; // 0x30
	private float <rttSum>5__3; // 0x38
	private int <replyCount>5__4; // 0x3C
	private string <regionAddress>5__5; // 0x40
	private int <i>5__6; // 0x48
	private bool <overtime>5__7; // 0x4C
	private Stopwatch <sw>5__8; // 0x50

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E13B18 Offset: 0xDBCB18 VA: 0x6CF5E13B18
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E13E10 Offset: 0xDBCE10 VA: 0x6CF5E13E10
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E13E14 Offset: 0xDBCE14 VA: 0x6CF5E13E14
	private bool MoveNext() { }

	// RVA: 0x6CF5E1444C Offset: 0xDBD44C VA: 0x6CF5E1444C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E14454 Offset: 0xDBD454 VA: 0x6CF5E14454
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E1448C Offset: 0xDBD48C VA: 0x6CF5E1448C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonPingManager : Object
{
	// Fields

	public bool UseNative; // 0x10
	public static int Attempts; // 0x0
	public static bool IgnoreInitialAttempt; // 0x4
	public static int MaxMilliseconsPerPing; // 0x8
	private const string wssProtocolString; // 0x0
	private int PingsRunning; // 0x14

	// Properties

	public Region BestRegion { get; }
	public bool Done { get; }

	// Methods

	// RVA: 0x6CF5E05084 Offset: 0xDAE084 VA: 0x6CF5E05084
	public Region get_BestRegion() { }

	// RVA: 0x6CF5E05074 Offset: 0xDAE074 VA: 0x6CF5E05074
	public bool get_Done() { }

	// RVA: 0x6CF5E05008 Offset: 0xDAE008 VA: 0x6CF5E05008
	public IEnumerator PingSocket(Region region) { }

	// RVA: 0x6CF5E13B40 Offset: 0xDBCB40 VA: 0x6CF5E13B40
	public static string ResolveHost(string hostName) { }

	// RVA: 0x6CF5E05000 Offset: 0xDAE000 VA: 0x6CF5E05000
	public void .ctor() { }

	// RVA: 0x6CF5E13DB4 Offset: 0xDBCDB4 VA: 0x6CF5E13DB4
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Room : RoomInfo
{
	// Fields

	private String[] <PropertiesListedInLobby>k__BackingField; // 0x58

	// Properties

	public string Name { get; set; }
	public bool IsOpen { get; set; }
	public bool IsVisible { get; set; }
	public String[] PropertiesListedInLobby { get; set; }
	public bool AutoCleanUp { get; }
	public int MaxPlayers { get; set; }
	public int PlayerCount { get; }
	public String[] ExpectedUsers { get; }
	public int PlayerTtl { get; set; }
	public int EmptyRoomTtl { get; set; }
	protected internal int MasterClientId { get; set; }
	public string name { get; set; }
	public bool open { get; set; }
	public bool visible { get; set; }
	public String[] propertiesListedInLobby { get; set; }
	public bool autoCleanUp { get; }
	public int maxPlayers { get; set; }
	public int playerCount { get; }
	public String[] expectedUsers { get; }
	protected internal int masterClientId { get; set; }

	// Methods

	// RVA: 0x6CF5E14494 Offset: 0xDBD494 VA: 0x6CF5E14494
	public string get_Name() { }

	// RVA: 0x6CF5E1449C Offset: 0xDBD49C VA: 0x6CF5E1449C
	internal void set_Name(string value) { }

	// RVA: 0x6CF5E144A4 Offset: 0xDBD4A4 VA: 0x6CF5E144A4
	public bool get_IsOpen() { }

	// RVA: 0x6CF5E144AC Offset: 0xDBD4AC VA: 0x6CF5E144AC
	public void set_IsOpen(bool value) { }

	// RVA: 0x6CF5E146B0 Offset: 0xDBD6B0 VA: 0x6CF5E146B0
	public bool get_IsVisible() { }

	// RVA: 0x6CF5E146B8 Offset: 0xDBD6B8 VA: 0x6CF5E146B8
	public void set_IsVisible(bool value) { }

	// RVA: 0x6CF5E148BC Offset: 0xDBD8BC VA: 0x6CF5E148BC
	public String[] get_PropertiesListedInLobby() { }

	// RVA: 0x6CF5E148C4 Offset: 0xDBD8C4 VA: 0x6CF5E148C4
	private void set_PropertiesListedInLobby(String[] value) { }

	// RVA: 0x6CF5E148CC Offset: 0xDBD8CC VA: 0x6CF5E148CC
	public bool get_AutoCleanUp() { }

	// RVA: 0x6CF5E148D4 Offset: 0xDBD8D4 VA: 0x6CF5E148D4
	public int get_MaxPlayers() { }

	// RVA: 0x6CF5E148DC Offset: 0xDBD8DC VA: 0x6CF5E148DC
	public void set_MaxPlayers(int value) { }

	// RVA: 0x6CF5E14B5C Offset: 0xDBDB5C VA: 0x6CF5E14B5C
	public int get_PlayerCount() { }

	// RVA: 0x6CF5E14BD0 Offset: 0xDBDBD0 VA: 0x6CF5E14BD0
	public String[] get_ExpectedUsers() { }

	// RVA: 0x6CF5E14BD8 Offset: 0xDBDBD8 VA: 0x6CF5E14BD8
	public int get_PlayerTtl() { }

	// RVA: 0x6CF5E14BE0 Offset: 0xDBDBE0 VA: 0x6CF5E14BE0
	public void set_PlayerTtl(int value) { }

	// RVA: 0x6CF5E14D54 Offset: 0xDBDD54 VA: 0x6CF5E14D54
	public int get_EmptyRoomTtl() { }

	// RVA: 0x6CF5E14D5C Offset: 0xDBDD5C VA: 0x6CF5E14D5C
	public void set_EmptyRoomTtl(int value) { }

	// RVA: 0x6CF5E14ED0 Offset: 0xDBDED0 VA: 0x6CF5E14ED0
	protected internal int get_MasterClientId() { }

	// RVA: 0x6CF5E14ED8 Offset: 0xDBDED8 VA: 0x6CF5E14ED8
	protected internal void set_MasterClientId(int value) { }

	// RVA: 0x6CF5E0AEA4 Offset: 0xDB3EA4 VA: 0x6CF5E0AEA4
	internal void .ctor(string roomName, RoomOptions options) { }

	// RVA: 0x6CF5E15604 Offset: 0xDBE604 VA: 0x6CF5E15604
	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues, bool webForward) { }

	// RVA: 0x6CF5E158DC Offset: 0xDBE8DC VA: 0x6CF5E158DC
	public void SetPropertiesListedInLobby(String[] propsListedInLobby) { }

	// RVA: 0x6CF5E159D4 Offset: 0xDBE9D4 VA: 0x6CF5E159D4
	public void ClearExpectedUsers() { }

	// RVA: 0x6CF5E15B28 Offset: 0xDBEB28 VA: 0x6CF5E15B28
	public void SetExpectedUsers(String[] expectedUsers) { }

	// RVA: 0x6CF5E15C58 Offset: 0xDBEC58 VA: 0x6CF5E15C58
	public override string ToString() { }

	// RVA: 0x6CF5E15E84 Offset: 0xDBEE84 VA: 0x6CF5E15E84
	public string ToStringFull() { }

	// RVA: 0x6CF5E16118 Offset: 0xDBF118 VA: 0x6CF5E16118
	public string get_name() { }

	// RVA: 0x6CF5E16120 Offset: 0xDBF120 VA: 0x6CF5E16120
	internal void set_name(string value) { }

	// RVA: 0x6CF5E16128 Offset: 0xDBF128 VA: 0x6CF5E16128
	public bool get_open() { }

	// RVA: 0x6CF5E16130 Offset: 0xDBF130 VA: 0x6CF5E16130
	public void set_open(bool value) { }

	// RVA: 0x6CF5E16138 Offset: 0xDBF138 VA: 0x6CF5E16138
	public bool get_visible() { }

	// RVA: 0x6CF5E16140 Offset: 0xDBF140 VA: 0x6CF5E16140
	public void set_visible(bool value) { }

	// RVA: 0x6CF5E16148 Offset: 0xDBF148 VA: 0x6CF5E16148
	public String[] get_propertiesListedInLobby() { }

	// RVA: 0x6CF5E16150 Offset: 0xDBF150 VA: 0x6CF5E16150
	private void set_propertiesListedInLobby(String[] value) { }

	// RVA: 0x6CF5E16158 Offset: 0xDBF158 VA: 0x6CF5E16158
	public bool get_autoCleanUp() { }

	// RVA: 0x6CF5E16160 Offset: 0xDBF160 VA: 0x6CF5E16160
	public int get_maxPlayers() { }

	// RVA: 0x6CF5E16168 Offset: 0xDBF168 VA: 0x6CF5E16168
	public void set_maxPlayers(int value) { }

	// RVA: 0x6CF5E1616C Offset: 0xDBF16C VA: 0x6CF5E1616C
	public int get_playerCount() { }

	// RVA: 0x6CF5E16170 Offset: 0xDBF170 VA: 0x6CF5E16170
	public String[] get_expectedUsers() { }

	// RVA: 0x6CF5E16178 Offset: 0xDBF178 VA: 0x6CF5E16178
	protected internal int get_masterClientId() { }

	// RVA: 0x6CF5E16180 Offset: 0xDBF180 VA: 0x6CF5E16180
	protected internal void set_masterClientId(int value) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RoomInfo : Object
{
	// Fields

	private bool <removedFromList>k__BackingField; // 0x10
	private Hashtable customPropertiesField; // 0x18
	protected byte maxPlayersField; // 0x20
	protected int emptyRoomTtlField; // 0x24
	protected int playerTtlField; // 0x28
	protected String[] expectedUsersField; // 0x30
	protected bool openField; // 0x38
	protected bool visibleField; // 0x39
	protected bool autoCleanUpField; // 0x3A
	protected string nameField; // 0x40
	protected internal int masterClientIdField; // 0x48
	private bool <serverSideMasterClient>k__BackingField; // 0x4C
	private int <PlayerCount>k__BackingField; // 0x50
	private bool <IsLocalClientInside>k__BackingField; // 0x54

	// Properties

	public bool removedFromList { get; set; }
	protected internal bool serverSideMasterClient { get; set; }
	public Hashtable CustomProperties { get; }
	public string Name { get; }
	public int PlayerCount { get; set; }
	public bool IsLocalClientInside { get; set; }
	public byte MaxPlayers { get; }
	public bool IsOpen { get; }
	public bool IsVisible { get; }
	public Hashtable customProperties { get; }
	public string name { get; }
	public int playerCount { get; set; }
	public bool isLocalClientInside { get; set; }
	public byte maxPlayers { get; }
	public bool open { get; }
	public bool visible { get; }

	// Methods

	// RVA: 0x6CF5E16188 Offset: 0xDBF188 VA: 0x6CF5E16188
	public bool get_removedFromList() { }

	// RVA: 0x6CF5E16190 Offset: 0xDBF190 VA: 0x6CF5E16190
	internal void set_removedFromList(bool value) { }

	// RVA: 0x6CF5E1619C Offset: 0xDBF19C VA: 0x6CF5E1619C
	protected internal bool get_serverSideMasterClient() { }

	// RVA: 0x6CF5E161A4 Offset: 0xDBF1A4 VA: 0x6CF5E161A4
	private void set_serverSideMasterClient(bool value) { }

	// RVA: 0x6CF5E161B0 Offset: 0xDBF1B0 VA: 0x6CF5E161B0
	public Hashtable get_CustomProperties() { }

	// RVA: 0x6CF5E161B8 Offset: 0xDBF1B8 VA: 0x6CF5E161B8
	public string get_Name() { }

	// RVA: 0x6CF5E161C0 Offset: 0xDBF1C0 VA: 0x6CF5E161C0
	public int get_PlayerCount() { }

	// RVA: 0x6CF5E161C8 Offset: 0xDBF1C8 VA: 0x6CF5E161C8
	private void set_PlayerCount(int value) { }

	// RVA: 0x6CF5E161D0 Offset: 0xDBF1D0 VA: 0x6CF5E161D0
	public bool get_IsLocalClientInside() { }

	// RVA: 0x6CF5E161D8 Offset: 0xDBF1D8 VA: 0x6CF5E161D8
	public void set_IsLocalClientInside(bool value) { }

	// RVA: 0x6CF5E161E4 Offset: 0xDBF1E4 VA: 0x6CF5E161E4
	public byte get_MaxPlayers() { }

	// RVA: 0x6CF5E161EC Offset: 0xDBF1EC VA: 0x6CF5E161EC
	public bool get_IsOpen() { }

	// RVA: 0x6CF5E161F4 Offset: 0xDBF1F4 VA: 0x6CF5E161F4
	public bool get_IsVisible() { }

	// RVA: 0x6CF5E14EE0 Offset: 0xDBDEE0 VA: 0x6CF5E14EE0
	protected internal void .ctor(string roomName, Hashtable properties) { }

	// RVA: 0x6CF5E161FC Offset: 0xDBF1FC VA: 0x6CF5E161FC
	public override bool Equals(object other) { }

	// RVA: 0x6CF5E1629C Offset: 0xDBF29C VA: 0x6CF5E1629C
	public override int GetHashCode() { }

	// RVA: 0x6CF5E162BC Offset: 0xDBF2BC VA: 0x6CF5E162BC
	public override string ToString() { }

	// RVA: 0x6CF5E164E4 Offset: 0xDBF4E4 VA: 0x6CF5E164E4
	public string ToStringFull() { }

	// RVA: 0x6CF5E14FD8 Offset: 0xDBDFD8 VA: 0x6CF5E14FD8
	protected internal void InternalCacheProperties(Hashtable propertiesToCache) { }

	// RVA: 0x6CF5E1676C Offset: 0xDBF76C VA: 0x6CF5E1676C
	public Hashtable get_customProperties() { }

	// RVA: 0x6CF5E16774 Offset: 0xDBF774 VA: 0x6CF5E16774
	public string get_name() { }

	// RVA: 0x6CF5E1677C Offset: 0xDBF77C VA: 0x6CF5E1677C
	public int get_playerCount() { }

	// RVA: 0x6CF5E16784 Offset: 0xDBF784 VA: 0x6CF5E16784
	public void set_playerCount(int value) { }

	// RVA: 0x6CF5E1678C Offset: 0xDBF78C VA: 0x6CF5E1678C
	public bool get_isLocalClientInside() { }

	// RVA: 0x6CF5E16794 Offset: 0xDBF794 VA: 0x6CF5E16794
	public void set_isLocalClientInside(bool value) { }

	// RVA: 0x6CF5E167A0 Offset: 0xDBF7A0 VA: 0x6CF5E167A0
	public byte get_maxPlayers() { }

	// RVA: 0x6CF5E167A8 Offset: 0xDBF7A8 VA: 0x6CF5E167A8
	public bool get_open() { }

	// RVA: 0x6CF5E167B0 Offset: 0xDBF7B0 VA: 0x6CF5E167B0
	public bool get_visible() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PunRPC : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E167B8 Offset: 0xDBF7B8 VA: 0x6CF5E167B8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Region : Object
{
	// Fields

	public CloudRegionCode Code; // 0x10
	public string Cluster; // 0x18
	public string HostAndPort; // 0x20
	public int Ping; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E167C0 Offset: 0xDBF7C0 VA: 0x6CF5E167C0
	public void .ctor(CloudRegionCode code) { }

	// RVA: 0x6CF5E16844 Offset: 0xDBF844 VA: 0x6CF5E16844
	public void .ctor(CloudRegionCode code, string regionCodeString, string address) { }

	// RVA: 0x6CF5E043E0 Offset: 0xDAD3E0 VA: 0x6CF5E043E0
	public static CloudRegionCode Parse(string codeAsString) { }

	// RVA: 0x6CF5E16880 Offset: 0xDBF880 VA: 0x6CF5E16880
	internal static CloudRegionFlag ParseFlag(CloudRegionCode region) { }

	// RVA: 0x6CF5E16A30 Offset: 0xDBFA30 VA: 0x6CF5E16A30
	internal static CloudRegionFlag ParseFlag(string codeAsString) { }

	// RVA: 0x6CF5E16B94 Offset: 0xDBFB94 VA: 0x6CF5E16B94
	public override string ToString() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum HostingOption
{
	// Fields

	public int value__; // 0x10
	public const HostingOption NotSet = 0; // 0x0
	public const HostingOption PhotonCloud = 1; // 0x0
	public const HostingOption SelfHosted = 2; // 0x0
	public const HostingOption OfflineMode = 3; // 0x0
	public const HostingOption BestRegion = 4; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ServerSettings : ScriptableObject
{
	// Fields

	public string AppID; // 0x18
	public string VoiceAppID; // 0x20
	public string ChatAppID; // 0x28
	public HostingOption HostType; // 0x30
	public CloudRegionCode PreferredRegion; // 0x34
	public CloudRegionFlag EnabledRegions; // 0x38
	public ConnectionProtocol Protocol; // 0x3C
	public string ServerAddress; // 0x40
	public int ServerPort; // 0x48
	public int VoiceServerPort; // 0x4C
	public bool JoinLobby; // 0x50
	public bool EnableLobbyStatistics; // 0x51
	public PhotonLogLevel PunLogging; // 0x54
	public DebugLevel NetworkLogging; // 0x58
	public bool RunInBackground; // 0x59
	public List`1 RpcList; // 0x60
	public bool DisableAutoOpenWizard; // 0x68

	// Properties

	public static CloudRegionCode BestRegionCodeInPreferences { get; }

	// Methods

	// RVA: 0x6CF5E16C24 Offset: 0xDBFC24 VA: 0x6CF5E16C24
	public void UseCloudBestRegion(string cloudAppid) { }

	// RVA: 0x6CF5E16C34 Offset: 0xDBFC34 VA: 0x6CF5E16C34
	public void UseCloud(string cloudAppid) { }

	// RVA: 0x6CF5E16C44 Offset: 0xDBFC44 VA: 0x6CF5E16C44
	public void UseCloud(string cloudAppid, CloudRegionCode code) { }

	// RVA: 0x6CF5E16C54 Offset: 0xDBFC54 VA: 0x6CF5E16C54
	public void UseMyServer(string serverAddress, int serverPort, string application) { }

	// RVA: 0x6CF5E16CD0 Offset: 0xDBFCD0 VA: 0x6CF5E16CD0
	public static bool IsAppId(string val) { }

	// RVA: 0x6CF5E16D70 Offset: 0xDBFD70 VA: 0x6CF5E16D70
	public static CloudRegionCode get_BestRegionCodeInPreferences() { }

	// RVA: 0x6CF5E16D74 Offset: 0xDBFD74 VA: 0x6CF5E16D74
	public static void ResetBestRegionCodeInPreferences() { }

	// RVA: 0x6CF5E16D7C Offset: 0xDBFD7C VA: 0x6CF5E16D7C
	public override string ToString() { }

	// RVA: 0x6CF5E16E30 Offset: 0xDBFE30 VA: 0x6CF5E16E30
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ParameterType
{
	// Fields

	public int value__; // 0x10
	public const ParameterType Float = 1; // 0x0
	public const ParameterType Int = 3; // 0x0
	public const ParameterType Bool = 4; // 0x0
	public const ParameterType Trigger = 9; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum SynchronizeType
{
	// Fields

	public int value__; // 0x10
	public const SynchronizeType Disabled = 0; // 0x0
	public const SynchronizeType Discrete = 1; // 0x0
	public const SynchronizeType Continuous = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class SynchronizedParameter : Object
{
	// Fields

	public ParameterType Type; // 0x10
	public SynchronizeType SynchronizeType; // 0x14
	public string Name; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5E18008 Offset: 0xDC1008 VA: 0x6CF5E18008
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class SynchronizedLayer : Object
{
	// Fields

	public SynchronizeType SynchronizeType; // 0x10
	public int LayerIndex; // 0x14

	// Properties


	// Methods

	// RVA: 0x6CF5E17DE4 Offset: 0xDC0DE4 VA: 0x6CF5E17DE4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass18_0 : Object
{
	// Fields

	public int layerIndex; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E17884 Offset: 0xDC0884 VA: 0x6CF5E17884
	public void .ctor() { }

	// RVA: 0x6CF5E18BDC Offset: 0xDC1BDC VA: 0x6CF5E18BDC
	internal bool <DoesLayerSynchronizeTypeExist>b__0(SynchronizedLayer item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass19_0 : Object
{
	// Fields

	public string name; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E17970 Offset: 0xDC0970 VA: 0x6CF5E17970
	public void .ctor() { }

	// RVA: 0x6CF5E18C00 Offset: 0xDC1C00 VA: 0x6CF5E18C00
	internal bool <DoesParameterSynchronizeTypeExist>b__0(SynchronizedParameter item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass22_0 : Object
{
	// Fields

	public int layerIndex; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E17AA4 Offset: 0xDC0AA4 VA: 0x6CF5E17AA4
	public void .ctor() { }

	// RVA: 0x6CF5E18C24 Offset: 0xDC1C24 VA: 0x6CF5E18C24
	internal bool <GetLayerSynchronizeType>b__0(SynchronizedLayer item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass23_0 : Object
{
	// Fields

	public string name; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E17BC8 Offset: 0xDC0BC8 VA: 0x6CF5E17BC8
	public void .ctor() { }

	// RVA: 0x6CF5E18C48 Offset: 0xDC1C48 VA: 0x6CF5E18C48
	internal bool <GetParameterSynchronizeType>b__0(SynchronizedParameter item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass24_0 : Object
{
	// Fields

	public int layerIndex; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E17DDC Offset: 0xDC0DDC VA: 0x6CF5E17DDC
	public void .ctor() { }

	// RVA: 0x6CF5E18C6C Offset: 0xDC1C6C VA: 0x6CF5E18C6C
	internal bool <SetLayerSynchronized>b__0(SynchronizedLayer item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass25_0 : Object
{
	// Fields

	public string name; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E18000 Offset: 0xDC1000 VA: 0x6CF5E18000
	public void .ctor() { }

	// RVA: 0x6CF5E18C90 Offset: 0xDC1C90 VA: 0x6CF5E18C90
	internal bool <SetParameterSynchronized>b__0(SynchronizedParameter item) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonAnimatorView : MonoBehaviour, IPunObservable
{
	// Fields

	private Animator m_Animator; // 0x20
	private PhotonStreamQueue m_StreamQueue; // 0x28
	private bool ShowLayerWeightsInspector; // 0x30
	private bool ShowParameterInspector; // 0x31
	private List`1 m_SynchronizeParameters; // 0x38
	private List`1 m_SynchronizeLayers; // 0x40
	private Vector3 m_ReceiverPosition; // 0x48
	private float m_LastDeserializeTime; // 0x54
	private bool m_WasSynchronizeTypeChanged; // 0x58
	private PhotonView m_PhotonView; // 0x60
	private List`1 m_raisedDiscreteTriggersCache; // 0x68

	// Properties


	// Methods

	// RVA: 0x6CF5E16EEC Offset: 0xDBFEEC VA: 0x6CF5E16EEC
	private void Awake() { }

	// RVA: 0x6CF5E16F94 Offset: 0xDBFF94 VA: 0x6CF5E16F94
	private void Update() { }

	// RVA: 0x6CF5E17374 Offset: 0xDC0374 VA: 0x6CF5E17374
	public void CacheDiscreteTriggers() { }

	// RVA: 0x6CF5E177A0 Offset: 0xDC07A0 VA: 0x6CF5E177A0
	public bool DoesLayerSynchronizeTypeExist(int layerIndex) { }

	// RVA: 0x6CF5E1788C Offset: 0xDC088C VA: 0x6CF5E1788C
	public bool DoesParameterSynchronizeTypeExist(string name) { }

	// RVA: 0x6CF5E17978 Offset: 0xDC0978 VA: 0x6CF5E17978
	public List`1 GetSynchronizedLayers() { }

	// RVA: 0x6CF5E17980 Offset: 0xDC0980 VA: 0x6CF5E17980
	public List`1 GetSynchronizedParameters() { }

	// RVA: 0x6CF5E17988 Offset: 0xDC0988 VA: 0x6CF5E17988
	public SynchronizeType GetLayerSynchronizeType(int layerIndex) { }

	// RVA: 0x6CF5E17AAC Offset: 0xDC0AAC VA: 0x6CF5E17AAC
	public SynchronizeType GetParameterSynchronizeType(string name) { }

	// RVA: 0x6CF5E17BD0 Offset: 0xDC0BD0 VA: 0x6CF5E17BD0
	public void SetLayerSynchronized(int layerIndex, SynchronizeType synchronizeType) { }

	// RVA: 0x6CF5E17DEC Offset: 0xDC0DEC VA: 0x6CF5E17DEC
	public void SetParameterSynchronized(string name, ParameterType type, SynchronizeType synchronizeType) { }

	// RVA: 0x6CF5E170A4 Offset: 0xDC00A4 VA: 0x6CF5E170A4
	private void SerializeDataContinuously() { }

	// RVA: 0x6CF5E174B8 Offset: 0xDC04B8 VA: 0x6CF5E174B8
	private void DeserializeDataContinuously() { }

	// RVA: 0x6CF5E18010 Offset: 0xDC1010 VA: 0x6CF5E18010
	private void SerializeDataDiscretly(PhotonStream stream) { }

	// RVA: 0x6CF5E182F0 Offset: 0xDC12F0 VA: 0x6CF5E182F0
	private void DeserializeDataDiscretly(PhotonStream stream) { }

	// RVA: 0x6CF5E18680 Offset: 0xDC1680 VA: 0x6CF5E18680
	private void SerializeSynchronizationTypeState(PhotonStream stream) { }

	// RVA: 0x6CF5E1880C Offset: 0xDC180C VA: 0x6CF5E1880C
	private void DeserializeSynchronizationTypeState(PhotonStream stream) { }

	// RVA: 0x6CF5E18994 Offset: 0xDC1994 VA: 0x6CF5E18994
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E18AC0 Offset: 0xDC1AC0 VA: 0x6CF5E18AC0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	// Fields

	private bool m_SynchronizeVelocity; // 0x20
	private bool m_SynchronizeAngularVelocity; // 0x21
	private Rigidbody2D m_Body; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E18CB4 Offset: 0xDC1CB4 VA: 0x6CF5E18CB4
	private void Awake() { }

	// RVA: 0x6CF5E18D04 Offset: 0xDC1D04 VA: 0x6CF5E18D04
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E18E8C Offset: 0xDC1E8C VA: 0x6CF5E18E8C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
	// Fields

	private bool m_SynchronizeVelocity; // 0x20
	private bool m_SynchronizeAngularVelocity; // 0x21
	private Rigidbody m_Body; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E18E9C Offset: 0xDC1E9C VA: 0x6CF5E18E9C
	private void Awake() { }

	// RVA: 0x6CF5E18EEC Offset: 0xDC1EEC VA: 0x6CF5E18EEC
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E19078 Offset: 0xDC2078 VA: 0x6CF5E19078
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	// Fields

	public PhotonTransformViewPositionModel m_PositionModel; // 0x20
	public PhotonTransformViewRotationModel m_RotationModel; // 0x28
	public PhotonTransformViewScaleModel m_ScaleModel; // 0x30
	private PhotonTransformViewPositionControl m_PositionControl; // 0x38
	private PhotonTransformViewRotationControl m_RotationControl; // 0x40
	private PhotonTransformViewScaleControl m_ScaleControl; // 0x48
	private PhotonView m_PhotonView; // 0x50
	private bool m_ReceivedNetworkUpdate; // 0x58
	private bool m_firstTake; // 0x59

	// Properties


	// Methods

	// RVA: 0x6CF5E19088 Offset: 0xDC2088 VA: 0x6CF5E19088
	private void Awake() { }

	// RVA: 0x6CF5E192E0 Offset: 0xDC22E0 VA: 0x6CF5E192E0
	private void OnEnable() { }

	// RVA: 0x6CF5E192EC Offset: 0xDC22EC VA: 0x6CF5E192EC
	private void Update() { }

	// RVA: 0x6CF5E193B4 Offset: 0xDC23B4 VA: 0x6CF5E193B4
	private void UpdatePosition() { }

	// RVA: 0x6CF5E19438 Offset: 0xDC2438 VA: 0x6CF5E19438
	private void UpdateRotation() { }

	// RVA: 0x6CF5E194BC Offset: 0xDC24BC VA: 0x6CF5E194BC
	private void UpdateScale() { }

	// RVA: 0x6CF5E19DE4 Offset: 0xDC2DE4 VA: 0x6CF5E19DE4
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed) { }

	// RVA: 0x6CF5E19E10 Offset: 0xDC2E10 VA: 0x6CF5E19E10
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1A294 Offset: 0xDC3294 VA: 0x6CF5E1A294
	private void DoDrawEstimatedPositionError() { }

	// RVA: 0x6CF5E1A514 Offset: 0xDC3514 VA: 0x6CF5E1A514
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonTransformViewPositionControl : Object
{
	// Fields

	private PhotonTransformViewPositionModel m_Model; // 0x10
	private float m_CurrentSpeed; // 0x18
	private double m_LastSerializeTime; // 0x20
	private Vector3 m_SynchronizedSpeed; // 0x28
	private float m_SynchronizedTurnSpeed; // 0x34
	private Vector3 m_NetworkPosition; // 0x38
	private Queue`1 m_OldNetworkPositions; // 0x48
	private bool m_UpdatedPositionAfterOnSerialize; // 0x50

	// Properties


	// Methods

	// RVA: 0x6CF5E1917C Offset: 0xDC217C VA: 0x6CF5E1917C
	public void .ctor(PhotonTransformViewPositionModel model) { }

	// RVA: 0x6CF5E1A84C Offset: 0xDC384C VA: 0x6CF5E1A84C
	private Vector3 GetOldestStoredNetworkPosition() { }

	// RVA: 0x6CF5E19E04 Offset: 0xDC2E04 VA: 0x6CF5E19E04
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed) { }

	// RVA: 0x6CF5E19540 Offset: 0xDC2540 VA: 0x6CF5E19540
	public Vector3 UpdatePosition(Vector3 currentPosition) { }

	// RVA: 0x6CF5E1AB7C Offset: 0xDC3B7C VA: 0x6CF5E1AB7C
	public Vector3 GetNetworkPosition() { }

	// RVA: 0x6CF5E1A8C4 Offset: 0xDC38C4 VA: 0x6CF5E1A8C4
	public Vector3 GetExtrapolatedPositionOffset() { }

	// RVA: 0x6CF5E19FE8 Offset: 0xDC2FE8 VA: 0x6CF5E19FE8
	public void OnPhotonSerializeView(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1AB88 Offset: 0xDC3B88 VA: 0x6CF5E1AB88
	private void SerializeData(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1ACA4 Offset: 0xDC3CA4 VA: 0x6CF5E1ACA4
	private void DeserializeData(PhotonStream stream, PhotonMessageInfo info) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum InterpolateOptions
{
	// Fields

	public int value__; // 0x10
	public const InterpolateOptions Disabled = 0; // 0x0
	public const InterpolateOptions FixedSpeed = 1; // 0x0
	public const InterpolateOptions EstimatedSpeed = 2; // 0x0
	public const InterpolateOptions SynchronizeValues = 3; // 0x0
	public const InterpolateOptions Lerp = 4; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ExtrapolateOptions
{
	// Fields

	public int value__; // 0x10
	public const ExtrapolateOptions Disabled = 0; // 0x0
	public const ExtrapolateOptions SynchronizeValues = 1; // 0x0
	public const ExtrapolateOptions EstimateSpeedAndTurn = 2; // 0x0
	public const ExtrapolateOptions FixedSpeed = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PhotonTransformViewPositionModel : Object
{
	// Fields

	public bool SynchronizeEnabled; // 0x10
	public bool TeleportEnabled; // 0x11
	public float TeleportIfDistanceGreaterThan; // 0x14
	public InterpolateOptions InterpolateOption; // 0x18
	public float InterpolateMoveTowardsSpeed; // 0x1C
	public float InterpolateLerpSpeed; // 0x20
	public float InterpolateMoveTowardsAcceleration; // 0x24
	public float InterpolateMoveTowardsDeceleration; // 0x28
	public AnimationCurve InterpolateSpeedCurve; // 0x30
	public ExtrapolateOptions ExtrapolateOption; // 0x38
	public float ExtrapolateSpeed; // 0x3C
	public bool ExtrapolateIncludingRoundTripTime; // 0x40
	public int ExtrapolateNumberOfStoredPositions; // 0x44
	public bool DrawErrorGizmo; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E1A5EC Offset: 0xDC35EC VA: 0x6CF5E1A5EC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonTransformViewRotationControl : Object
{
	// Fields

	private PhotonTransformViewRotationModel m_Model; // 0x10
	private Quaternion m_NetworkRotation; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5E1924C Offset: 0xDC224C VA: 0x6CF5E1924C
	public void .ctor(PhotonTransformViewRotationModel model) { }

	// RVA: 0x6CF5E1AE74 Offset: 0xDC3E74 VA: 0x6CF5E1AE74
	public Quaternion GetNetworkRotation() { }

	// RVA: 0x6CF5E19AC8 Offset: 0xDC2AC8 VA: 0x6CF5E19AC8
	public Quaternion GetRotation(Quaternion currentRotation) { }

	// RVA: 0x6CF5E1A0A8 Offset: 0xDC30A8 VA: 0x6CF5E1A0A8
	public void OnPhotonSerializeView(Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum InterpolateOptions
{
	// Fields

	public int value__; // 0x10
	public const InterpolateOptions Disabled = 0; // 0x0
	public const InterpolateOptions RotateTowards = 1; // 0x0
	public const InterpolateOptions Lerp = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PhotonTransformViewRotationModel : Object
{
	// Fields

	public bool SynchronizeEnabled; // 0x10
	public InterpolateOptions InterpolateOption; // 0x14
	public float InterpolateRotateTowardsSpeed; // 0x18
	public float InterpolateLerpSpeed; // 0x1C

	// Properties


	// Methods

	// RVA: 0x6CF5E1A820 Offset: 0xDC3820 VA: 0x6CF5E1A820
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PhotonTransformViewScaleControl : Object
{
	// Fields

	private PhotonTransformViewScaleModel m_Model; // 0x10
	private Vector3 m_NetworkScale; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5E19274 Offset: 0xDC2274 VA: 0x6CF5E19274
	public void .ctor(PhotonTransformViewScaleModel model) { }

	// RVA: 0x6CF5E1AE80 Offset: 0xDC3E80 VA: 0x6CF5E1AE80
	public Vector3 GetNetworkScale() { }

	// RVA: 0x6CF5E19C5C Offset: 0xDC2C5C VA: 0x6CF5E19C5C
	public Vector3 GetScale(Vector3 currentScale) { }

	// RVA: 0x6CF5E1A19C Offset: 0xDC319C VA: 0x6CF5E1A19C
	public void OnPhotonSerializeView(Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum InterpolateOptions
{
	// Fields

	public int value__; // 0x10
	public const InterpolateOptions Disabled = 0; // 0x0
	public const InterpolateOptions MoveTowards = 1; // 0x0
	public const InterpolateOptions Lerp = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PhotonTransformViewScaleModel : Object
{
	// Fields

	public bool SynchronizeEnabled; // 0x10
	public InterpolateOptions InterpolateOption; // 0x14
	public float InterpolateMoveTowardsSpeed; // 0x18
	public float InterpolateLerpSpeed; // 0x1C

	// Properties


	// Methods

	// RVA: 0x6CF5E1A83C Offset: 0xDC383C VA: 0x6CF5E1A83C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ConnectAndJoinRandom : MonoBehaviour
{
	// Fields

	public bool AutoConnect; // 0x28
	public byte Version; // 0x29
	private bool ConnectInUpdate; // 0x2A

	// Properties


	// Methods

	// RVA: 0x6CF5E1AE8C Offset: 0xDC3E8C VA: 0x6CF5E1AE8C
	public virtual void Start() { }

	// RVA: 0x6CF5E1AEDC Offset: 0xDC3EDC VA: 0x6CF5E1AEDC
	public virtual void Update() { }

	// RVA: 0x6CF5E1AFF8 Offset: 0xDC3FF8 VA: 0x6CF5E1AFF8
	public virtual void OnConnectedToMaster() { }

	// RVA: 0x6CF5E1B088 Offset: 0xDC4088 VA: 0x6CF5E1B088
	public virtual void OnJoinedLobby() { }

	// RVA: 0x6CF5E1B118 Offset: 0xDC4118 VA: 0x6CF5E1B118
	public virtual void OnPhotonRandomJoinFailed() { }

	// RVA: 0x6CF5E1B1EC Offset: 0xDC41EC VA: 0x6CF5E1B1EC
	public virtual void OnFailedToConnectToPhoton(DisconnectCause cause) { }

	// RVA: 0x6CF5E1B2B8 Offset: 0xDC42B8 VA: 0x6CF5E1B2B8
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E1B320 Offset: 0xDC4320 VA: 0x6CF5E1B320
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CullArea : MonoBehaviour
{
	// Fields

	private const int MAX_NUMBER_OF_ALLOWED_CELLS; // 0x0
	public const int MAX_NUMBER_OF_SUBDIVISIONS; // 0x0
	public readonly byte FIRST_GROUP_ID; // 0x20
	public readonly Int32[] SUBDIVISION_FIRST_LEVEL_ORDER; // 0x28
	public readonly Int32[] SUBDIVISION_SECOND_LEVEL_ORDER; // 0x30
	public readonly Int32[] SUBDIVISION_THIRD_LEVEL_ORDER; // 0x38
	public Vector2 Center; // 0x40
	public Vector2 Size; // 0x48
	public Vector2[] Subdivisions; // 0x50
	public int NumberOfSubdivisions; // 0x58
	private int <CellCount>k__BackingField; // 0x5C
	private CellTree <CellTree>k__BackingField; // 0x60
	private Dictionary`2 <Map>k__BackingField; // 0x68
	public bool YIsUpAxis; // 0x70
	public bool RecreateCellHierarchy; // 0x71
	private byte idCounter; // 0x72

	// Properties

	public int CellCount { get; set; }
	public CellTree CellTree { get; set; }
	public Dictionary`2 Map { get; set; }

	// Methods

	// RVA: 0x6CF5E1B338 Offset: 0xDC4338 VA: 0x6CF5E1B338
	public int get_CellCount() { }

	// RVA: 0x6CF5E1B340 Offset: 0xDC4340 VA: 0x6CF5E1B340
	private void set_CellCount(int value) { }

	// RVA: 0x6CF5E1B348 Offset: 0xDC4348 VA: 0x6CF5E1B348
	public CellTree get_CellTree() { }

	// RVA: 0x6CF5E1B350 Offset: 0xDC4350 VA: 0x6CF5E1B350
	private void set_CellTree(CellTree value) { }

	// RVA: 0x6CF5E1B358 Offset: 0xDC4358 VA: 0x6CF5E1B358
	public Dictionary`2 get_Map() { }

	// RVA: 0x6CF5E1B360 Offset: 0xDC4360 VA: 0x6CF5E1B360
	private void set_Map(Dictionary`2 value) { }

	// RVA: 0x6CF5E1B368 Offset: 0xDC4368 VA: 0x6CF5E1B368
	private void Awake() { }

	// RVA: 0x6CF5E1B724 Offset: 0xDC4724 VA: 0x6CF5E1B724
	public void OnDrawGizmos() { }

	// RVA: 0x6CF5E1B374 Offset: 0xDC4374 VA: 0x6CF5E1B374
	private void CreateCellHierarchy() { }

	// RVA: 0x6CF5E1B844 Offset: 0xDC4844 VA: 0x6CF5E1B844
	private void CreateChildCells(CellTreeNode parent, int cellLevelInHierarchy) { }

	// RVA: 0x6CF5E1B770 Offset: 0xDC4770 VA: 0x6CF5E1B770
	private void DrawCells() { }

	// RVA: 0x6CF5E1B798 Offset: 0xDC4798 VA: 0x6CF5E1B798
	private bool IsCellCountAllowed() { }

	// RVA: 0x6CF5E1BAC4 Offset: 0xDC4AC4 VA: 0x6CF5E1BAC4
	public List`1 GetActiveCells(Vector3 position) { }

	// RVA: 0x6CF5E1BB88 Offset: 0xDC4B88 VA: 0x6CF5E1BB88
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CellTree : Object
{
	// Fields

	private CellTreeNode <RootNode>k__BackingField; // 0x10

	// Properties

	public CellTreeNode RootNode { get; set; }

	// Methods

	// RVA: 0x6CF5E1BCB0 Offset: 0xDC4CB0 VA: 0x6CF5E1BCB0
	public CellTreeNode get_RootNode() { }

	// RVA: 0x6CF5E1BCB8 Offset: 0xDC4CB8 VA: 0x6CF5E1BCB8
	private void set_RootNode(CellTreeNode value) { }

	// RVA: 0x6CF5E1BCC0 Offset: 0xDC4CC0 VA: 0x6CF5E1BCC0
	public void .ctor() { }

	// RVA: 0x6CF5E1BCC8 Offset: 0xDC4CC8 VA: 0x6CF5E1BCC8
	public void .ctor(CellTreeNode root) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum ENodeType
{
	// Fields

	public int value__; // 0x10
	public const ENodeType Root = 0; // 0x0
	public const ENodeType Node = 1; // 0x0
	public const ENodeType Leaf = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CellTreeNode : Object
{
	// Fields

	public byte Id; // 0x10
	public Vector3 Center; // 0x14
	public Vector3 Size; // 0x20
	public Vector3 TopLeft; // 0x2C
	public Vector3 BottomRight; // 0x38
	public ENodeType NodeType; // 0x44
	public CellTreeNode Parent; // 0x48
	public List`1 Childs; // 0x50
	private float maxDistance; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF5E1BCF0 Offset: 0xDC4CF0 VA: 0x6CF5E1BCF0
	public void .ctor() { }

	// RVA: 0x6CF5E1BCF8 Offset: 0xDC4CF8 VA: 0x6CF5E1BCF8
	public void .ctor(byte id, ENodeType nodeType, CellTreeNode parent) { }

	// RVA: 0x6CF5E1BD38 Offset: 0xDC4D38 VA: 0x6CF5E1BD38
	public void AddChild(CellTreeNode child) { }

	// RVA: 0x6CF5E1BE28 Offset: 0xDC4E28 VA: 0x6CF5E1BE28
	public void Draw() { }

	// RVA: 0x6CF5E1BE2C Offset: 0xDC4E2C VA: 0x6CF5E1BE2C
	public void GetActiveCells(List`1 activeCells, bool yIsUpAxis, Vector3 position) { }

	// RVA: 0x6CF5E1C120 Offset: 0xDC5120 VA: 0x6CF5E1C120
	public bool IsPointInsideCell(bool yIsUpAxis, Vector3 point) { }

	// RVA: 0x6CF5E1C0C0 Offset: 0xDC50C0 VA: 0x6CF5E1C0C0
	public bool IsPointNearCell(bool yIsUpAxis, Vector3 point) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class HighlightOwnedGameObj : MonoBehaviour
{
	// Fields

	public GameObject PointerPrefab; // 0x28
	public float Offset; // 0x30
	private Transform markerTransform; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E1C180 Offset: 0xDC5180 VA: 0x6CF5E1C180
	private void Update() { }

	// RVA: 0x6CF5E1C3EC Offset: 0xDC53EC VA: 0x6CF5E1C3EC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class InputToEvent : MonoBehaviour
{
	// Fields

	private GameObject lastGo; // 0x20
	public static Vector3 inputHitPos; // 0x0
	public bool DetectPointedAtGameObject; // 0x28
	private static GameObject <goPointedAt>k__BackingField; // 0x10
	private Vector2 pressedPosition; // 0x2C
	private Vector2 currentPos; // 0x34
	public bool Dragging; // 0x3C
	private Camera m_Camera; // 0x40

	// Properties

	public static GameObject goPointedAt { get; set; }
	public Vector2 DragVector { get; }

	// Methods

	// RVA: 0x6CF5E1C404 Offset: 0xDC5404 VA: 0x6CF5E1C404
	public static GameObject get_goPointedAt() { }

	// RVA: 0x6CF5E1C44C Offset: 0xDC544C VA: 0x6CF5E1C44C
	private static void set_goPointedAt(GameObject value) { }

	// RVA: 0x6CF5E1C498 Offset: 0xDC5498 VA: 0x6CF5E1C498
	public Vector2 get_DragVector() { }

	// RVA: 0x6CF5E1C4F4 Offset: 0xDC54F4 VA: 0x6CF5E1C4F4
	private void Start() { }

	// RVA: 0x6CF5E1C544 Offset: 0xDC5544 VA: 0x6CF5E1C544
	private void Update() { }

	// RVA: 0x6CF5E1C870 Offset: 0xDC5870 VA: 0x6CF5E1C870
	private void Press(Vector2 screenPos) { }

	// RVA: 0x6CF5E1C944 Offset: 0xDC5944 VA: 0x6CF5E1C944
	private void Release(Vector2 screenPos) { }

	// RVA: 0x6CF5E1C74C Offset: 0xDC574C VA: 0x6CF5E1C74C
	private GameObject RaycastObject(Vector2 screenPos) { }

	// RVA: 0x6CF5E1CA98 Offset: 0xDC5A98 VA: 0x6CF5E1CA98
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class InRoomChat : MonoBehaviour
{
	// Fields

	public Rect GuiRect; // 0x28
	public bool IsVisible; // 0x38
	public bool AlignBottom; // 0x39
	public List`1 messages; // 0x40
	private string inputLine; // 0x48
	private Vector2 scrollPos; // 0x50
	public static readonly string ChatRPC; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E1CAFC Offset: 0xDC5AFC VA: 0x6CF5E1CAFC
	public void Start() { }

	// RVA: 0x6CF5E1CB2C Offset: 0xDC5B2C VA: 0x6CF5E1CB2C
	public void OnGUI() { }

	// RVA: 0x6CF5E1D0E0 Offset: 0xDC60E0 VA: 0x6CF5E1D0E0
	public void Chat(string newLine, PhotonMessageInfo mi) { }

	// RVA: 0x6CF5E1D238 Offset: 0xDC6238 VA: 0x6CF5E1D238
	public void AddLine(string newLine) { }

	// RVA: 0x6CF5E1D2DC Offset: 0xDC62DC VA: 0x6CF5E1D2DC
	public void .ctor() { }

	// RVA: 0x6CF5E1D3B8 Offset: 0xDC63B8 VA: 0x6CF5E1D3B8
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class InRoomRoundTimer : MonoBehaviour
{
	// Fields

	public int SecondsPerTurn; // 0x20
	public double StartTime; // 0x28
	public Rect TextPos; // 0x30
	private bool startRoundWhenTimeIsSynced; // 0x40
	private const string StartTimeKey; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E1D418 Offset: 0xDC6418 VA: 0x6CF5E1D418
	private void StartRoundNow() { }

	// RVA: 0x6CF5E1D54C Offset: 0xDC654C VA: 0x6CF5E1D54C
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E1D6B8 Offset: 0xDC66B8 VA: 0x6CF5E1D6B8
	public void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged) { }

	// RVA: 0x6CF5E1D77C Offset: 0xDC677C VA: 0x6CF5E1D77C
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5E1D874 Offset: 0xDC6874 VA: 0x6CF5E1D874
	private void Update() { }

	// RVA: 0x6CF5E1D884 Offset: 0xDC6884 VA: 0x6CF5E1D884
	public void OnGUI() { }

	// RVA: 0x6CF5E1DBDC Offset: 0xDC6BDC VA: 0x6CF5E1DBDC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ManualPhotonViewAllocator : MonoBehaviour
{
	// Fields

	public GameObject Prefab; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E1DBF8 Offset: 0xDC6BF8 VA: 0x6CF5E1DBF8
	public void AllocateManualPhotonView() { }

	// RVA: 0x6CF5E1DDEC Offset: 0xDC6DEC VA: 0x6CF5E1DDEC
	public void InstantiateRpc(int viewID) { }

	// RVA: 0x6CF5E1DF9C Offset: 0xDC6F9C VA: 0x6CF5E1DF9C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class MoveByKeys : MonoBehaviour
{
	// Fields

	public float Speed; // 0x28
	public float JumpForce; // 0x2C
	public float JumpTimeout; // 0x30
	private bool isSprite; // 0x34
	private float jumpingTime; // 0x38
	private Rigidbody body; // 0x40
	private Rigidbody2D body2d; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E1DFA4 Offset: 0xDC6FA4 VA: 0x6CF5E1DFA4
	public void Start() { }

	// RVA: 0x6CF5E1E084 Offset: 0xDC7084 VA: 0x6CF5E1E084
	public void FixedUpdate() { }

	// RVA: 0x6CF5E1E45C Offset: 0xDC745C VA: 0x6CF5E1E45C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
	// Fields

	private int orderIndex; // 0x20
	private CullArea cullArea; // 0x28
	private List`1 previousActiveCells; // 0x30
	private List`1 activeCells; // 0x38
	private PhotonView pView; // 0x40
	private Vector3 lastPosition; // 0x48
	private Vector3 currentPosition; // 0x54

	// Properties


	// Methods

	// RVA: 0x6CF5E1E478 Offset: 0xDC7478 VA: 0x6CF5E1E478
	private void OnEnable() { }

	// RVA: 0x6CF5E1E5FC Offset: 0xDC75FC VA: 0x6CF5E1E5FC
	private void Start() { }

	// RVA: 0x6CF5E1E72C Offset: 0xDC772C VA: 0x6CF5E1E72C
	private void Update() { }

	// RVA: 0x6CF5E1EC40 Offset: 0xDC7C40 VA: 0x6CF5E1EC40
	private void OnGUI() { }

	// RVA: 0x6CF5E1E7D4 Offset: 0xDC77D4 VA: 0x6CF5E1E7D4
	private bool HaveActiveCellsChanged() { }

	// RVA: 0x6CF5E1E98C Offset: 0xDC798C VA: 0x6CF5E1E98C
	private void UpdateInterestGroups() { }

	// RVA: 0x6CF5E1F014 Offset: 0xDC8014 VA: 0x6CF5E1F014
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E1F180 Offset: 0xDC8180 VA: 0x6CF5E1F180
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OnAwakeUsePhotonView : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E1F188 Offset: 0xDC8188 VA: 0x6CF5E1F188
	private void Awake() { }

	// RVA: 0x6CF5E1F274 Offset: 0xDC8274 VA: 0x6CF5E1F274
	private void Start() { }

	// RVA: 0x6CF5E1F38C Offset: 0xDC838C VA: 0x6CF5E1F38C
	public void OnAwakeRPC() { }

	// RVA: 0x6CF5E1F434 Offset: 0xDC8434 VA: 0x6CF5E1F434
	public void OnAwakeRPC(byte myParameter) { }

	// RVA: 0x6CF5E1F524 Offset: 0xDC8524 VA: 0x6CF5E1F524
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <DestroyRpc>d__2 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public OnClickDestroy <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E1F6A8 Offset: 0xDC86A8 VA: 0x6CF5E1F6A8
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E1F6D8 Offset: 0xDC86D8 VA: 0x6CF5E1F6D8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E1F6DC Offset: 0xDC86DC VA: 0x6CF5E1F6DC
	private bool MoveNext() { }

	// RVA: 0x6CF5E1F7F0 Offset: 0xDC87F0 VA: 0x6CF5E1F7F0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E1F7F8 Offset: 0xDC87F8 VA: 0x6CF5E1F7F8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E1F830 Offset: 0xDC8830 VA: 0x6CF5E1F830
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OnClickDestroy : MonoBehaviour
{
	// Fields

	public bool DestroyByRpc; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E1F52C Offset: 0xDC852C VA: 0x6CF5E1F52C
	public void OnClick() { }

	// RVA: 0x6CF5E1F648 Offset: 0xDC8648 VA: 0x6CF5E1F648
	public IEnumerator DestroyRpc() { }

	// RVA: 0x6CF5E1F6D0 Offset: 0xDC86D0 VA: 0x6CF5E1F6D0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OnClickInstantiate : MonoBehaviour
{
	// Fields

	public GameObject Prefab; // 0x20
	public int InstantiateType; // 0x28
	private String[] InstantiateTypeNames; // 0x30
	public bool showGui; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E1F838 Offset: 0xDC8838 VA: 0x6CF5E1F838
	private void OnClick() { }

	// RVA: 0x6CF5E1FA80 Offset: 0xDC8A80 VA: 0x6CF5E1FA80
	private void OnGUI() { }

	// RVA: 0x6CF5E1FB7C Offset: 0xDC8B7C VA: 0x6CF5E1FB7C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OnJoinedInstantiate : MonoBehaviour
{
	// Fields

	public Transform SpawnPosition; // 0x20
	public float PositionOffset; // 0x28
	public GameObject[] PrefabsToInstantiate; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5E1FC28 Offset: 0xDC8C28 VA: 0x6CF5E1FC28
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E1FF50 Offset: 0xDC8F50 VA: 0x6CF5E1FF50
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class OnStartDelete : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E1FF60 Offset: 0xDC8F60 VA: 0x6CF5E1FF60
	private void Start() { }

	// RVA: 0x6CF5E1FFCC Offset: 0xDC8FCC VA: 0x6CF5E1FFCC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PickupItem : MonoBehaviour, IPunObservable
{
	// Fields

	public float SecondsBeforeRespawn; // 0x28
	public bool PickupOnTrigger; // 0x2C
	public bool PickupIsMine; // 0x2D
	public MonoBehaviour OnPickedUpCall; // 0x30
	public bool SentPickup; // 0x38
	public double TimeOfRespawn; // 0x40
	public static HashSet`1 DisabledPickupItems; // 0x0

	// Properties

	public int ViewID { get; }

	// Methods

	// RVA: 0x6CF5E1FFD4 Offset: 0xDC8FD4 VA: 0x6CF5E1FFD4
	public int get_ViewID() { }

	// RVA: 0x6CF5E1FFF0 Offset: 0xDC8FF0 VA: 0x6CF5E1FFF0
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x6CF5E20194 Offset: 0xDC9194 VA: 0x6CF5E20194
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E200B0 Offset: 0xDC90B0 VA: 0x6CF5E200B0
	public void Pickup() { }

	// RVA: 0x6CF5E202D0 Offset: 0xDC92D0 VA: 0x6CF5E202D0
	public void Drop() { }

	// RVA: 0x6CF5E203AC Offset: 0xDC93AC VA: 0x6CF5E203AC
	public void Drop(Vector3 newPosition) { }

	// RVA: 0x6CF5E204D0 Offset: 0xDC94D0 VA: 0x6CF5E204D0
	public void PunPickup(PhotonMessageInfo msgInfo) { }

	// RVA: 0x6CF5E20804 Offset: 0xDC9804 VA: 0x6CF5E20804
	internal void PickedUp(float timeUntilRespawn) { }

	// RVA: 0x6CF5E20928 Offset: 0xDC9928 VA: 0x6CF5E20928
	internal void PunRespawn(Vector3 pos) { }

	// RVA: 0x6CF5E209EC Offset: 0xDC99EC VA: 0x6CF5E209EC
	internal void PunRespawn() { }

	// RVA: 0x6CF5E20AE8 Offset: 0xDC9AE8 VA: 0x6CF5E20AE8
	public void .ctor() { }

	// RVA: 0x6CF5E20AF8 Offset: 0xDC9AF8 VA: 0x6CF5E20AF8
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PickupItemSimple : MonoBehaviour
{
	// Fields

	public float SecondsBeforeRespawn; // 0x28
	public bool PickupOnCollide; // 0x2C
	public bool SentPickup; // 0x2D

	// Properties


	// Methods

	// RVA: 0x6CF5E20B84 Offset: 0xDC9B84 VA: 0x6CF5E20B84
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x6CF5E20C44 Offset: 0xDC9C44 VA: 0x6CF5E20C44
	public void Pickup() { }

	// RVA: 0x6CF5E20D28 Offset: 0xDC9D28 VA: 0x6CF5E20D28
	public void PunPickupSimple(PhotonMessageInfo msgInfo) { }

	// RVA: 0x6CF5E20EE0 Offset: 0xDC9EE0 VA: 0x6CF5E20EE0
	public void RespawnAfter() { }

	// RVA: 0x6CF5E20F80 Offset: 0xDC9F80 VA: 0x6CF5E20F80
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PickupItemSyncer : MonoBehaviour
{
	// Fields

	public bool IsWaitingForPickupInit; // 0x28
	private const float TimeDeltaToIgnore; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E20F90 Offset: 0xDC9F90 VA: 0x6CF5E20F90
	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5E21740 Offset: 0xDCA740 VA: 0x6CF5E21740
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E218E0 Offset: 0xDCA8E0 VA: 0x6CF5E218E0
	public void AskForPickupItemSpawnTimes() { }

	// RVA: 0x6CF5E21B20 Offset: 0xDCAB20 VA: 0x6CF5E21B20
	public void RequestForPickupTimes(PhotonMessageInfo msgInfo) { }

	// RVA: 0x6CF5E21B4C Offset: 0xDCAB4C VA: 0x6CF5E21B4C
	public void RequestForPickupItems(PhotonMessageInfo msgInfo) { }

	// RVA: 0x6CF5E21010 Offset: 0xDCA010 VA: 0x6CF5E21010
	private void SendPickedUpItems(PhotonPlayer targetPlayer) { }

	// RVA: 0x6CF5E21BD4 Offset: 0xDCABD4 VA: 0x6CF5E21BD4
	public void PickupItemInit(double timeBase, Single[] inactivePickupsAndTimes) { }

	// RVA: 0x6CF5E21EC4 Offset: 0xDCAEC4 VA: 0x6CF5E21EC4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PointedAtGameObjectInfo : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E21ECC Offset: 0xDCAECC VA: 0x6CF5E21ECC
	private void OnGUI() { }

	// RVA: 0x6CF5E22184 Offset: 0xDCB184 VA: 0x6CF5E22184
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PunPlayerScores : MonoBehaviour
{
	// Fields

	public const string PlayerScoreProp; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E2218C Offset: 0xDCB18C VA: 0x6CF5E2218C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class ScoreExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E22194 Offset: 0xDCB194 VA: 0x6CF5E22194
	public static void SetScore(PhotonPlayer player, int newScore) { }

	// RVA: 0x6CF5E2226C Offset: 0xDCB26C VA: 0x6CF5E2226C
	public static void AddScore(PhotonPlayer player, int scoreToAddToCurrent) { }

	// RVA: 0x6CF5E22354 Offset: 0xDCB354 VA: 0x6CF5E22354
	public static int GetScore(PhotonPlayer player) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum Team
{
	// Fields

	public byte value__; // 0x10
	public const Team none = 0; // 0x0
	public const Team red = 1; // 0x0
	public const Team blue = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PunTeams : MonoBehaviour
{
	// Fields

	public static Dictionary`2 PlayersPerTeam; // 0x0
	public const string TeamPlayerProp; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E22418 Offset: 0xDCB418 VA: 0x6CF5E22418
	public void Start() { }

	// RVA: 0x6CF5E2283C Offset: 0xDCB83C VA: 0x6CF5E2283C
	public void OnDisable() { }

	// RVA: 0x6CF5E228C8 Offset: 0xDCB8C8 VA: 0x6CF5E228C8
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E22D90 Offset: 0xDCBD90 VA: 0x6CF5E22D90
	public void OnLeftRoom() { }

	// RVA: 0x6CF5E22D94 Offset: 0xDCBD94 VA: 0x6CF5E22D94
	public void OnPhotonPlayerPropertiesChanged(Object[] playerAndUpdatedProps) { }

	// RVA: 0x6CF5E22D98 Offset: 0xDCBD98 VA: 0x6CF5E22D98
	public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5E22D9C Offset: 0xDCBD9C VA: 0x6CF5E22D9C
	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5E228CC Offset: 0xDCB8CC VA: 0x6CF5E228CC
	public void UpdateTeams() { }

	// RVA: 0x6CF5E22E64 Offset: 0xDCBE64 VA: 0x6CF5E22E64
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class TeamExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E22DA0 Offset: 0xDCBDA0 VA: 0x6CF5E22DA0
	public static Team GetTeam(PhotonPlayer player) { }

	// RVA: 0x6CF5E22E6C Offset: 0xDCBE6C VA: 0x6CF5E22E6C
	public static void SetTeam(PhotonPlayer player, Team team) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class PunTurnManager : PunBehaviour
{
	// Fields

	public float TurnDuration; // 0x28
	public IPunTurnManagerCallbacks TurnManagerListener; // 0x30
	private readonly HashSet`1 finishedPlayers; // 0x38
	public const byte TurnManagerEventOffset; // 0x0
	public const byte EvMove; // 0x0
	public const byte EvFinalMove; // 0x0
	private bool _isOverCallProcessed; // 0x40

	// Properties

	public int Turn { get; set; }
	public float ElapsedTimeInTurn { get; }
	public float RemainingSecondsInTurn { get; }
	public bool IsCompletedByAll { get; }
	public bool IsFinishedByMe { get; }
	public bool IsOver { get; }

	// Methods

	// RVA: 0x6CF5E23060 Offset: 0xDCC060 VA: 0x6CF5E23060
	public int get_Turn() { }

	// RVA: 0x6CF5E231E8 Offset: 0xDCC1E8 VA: 0x6CF5E231E8
	private void set_Turn(int value) { }

	// RVA: 0x6CF5E23408 Offset: 0xDCC408 VA: 0x6CF5E23408
	public float get_ElapsedTimeInTurn() { }

	// RVA: 0x6CF5E235B4 Offset: 0xDCC5B4 VA: 0x6CF5E235B4
	public float get_RemainingSecondsInTurn() { }

	// RVA: 0x6CF5E235DC Offset: 0xDCC5DC VA: 0x6CF5E235DC
	public bool get_IsCompletedByAll() { }

	// RVA: 0x6CF5E23694 Offset: 0xDCC694 VA: 0x6CF5E23694
	public bool get_IsFinishedByMe() { }

	// RVA: 0x6CF5E23718 Offset: 0xDCC718 VA: 0x6CF5E23718
	public bool get_IsOver() { }

	// RVA: 0x6CF5E23748 Offset: 0xDCC748 VA: 0x6CF5E23748
	private void Start() { }

	// RVA: 0x6CF5E237EC Offset: 0xDCC7EC VA: 0x6CF5E237EC
	private void Update() { }

	// RVA: 0x6CF5E238EC Offset: 0xDCC8EC VA: 0x6CF5E238EC
	public void BeginTurn() { }

	// RVA: 0x6CF5E23908 Offset: 0xDCC908 VA: 0x6CF5E23908
	public void SendMove(object move, bool finished) { }

	// RVA: 0x6CF5E24060 Offset: 0xDCD060 VA: 0x6CF5E24060
	public bool GetPlayerFinishedTurn(PhotonPlayer player) { }

	// RVA: 0x6CF5E23CC8 Offset: 0xDCCCC8 VA: 0x6CF5E23CC8
	public void OnEvent(byte eventCode, object content, int senderId) { }

	// RVA: 0x6CF5E240CC Offset: 0xDCD0CC VA: 0x6CF5E240CC
	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged) { }

	// RVA: 0x6CF5E241F0 Offset: 0xDCD1F0 VA: 0x6CF5E241F0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public interface IPunTurnManagerCallbacks
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnTurnBegins(int turn) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnTurnCompleted(int turn) { }

	// RVA: 0x6CF5BD75EC Offset: 0xB805EC VA: 0x6CF5BD75EC
	public abstract void OnPlayerMove(PhotonPlayer player, int turn, object move) { }

	// RVA: 0x6CF5BD75EC Offset: 0xB805EC VA: 0x6CF5BD75EC
	public abstract void OnPlayerFinished(PhotonPlayer player, int turn, object move) { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnTurnTimeEnds(int turn) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public static class TurnExtensions : Object
{
	// Fields

	public static readonly string TurnPropKey; // 0x0
	public static readonly string TurnStartPropKey; // 0x8
	public static readonly string FinishedTurnPropKey; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5E23288 Offset: 0xDCC288 VA: 0x6CF5E23288
	public static void SetTurn(Room room, int turn, bool setStartTime) { }

	// RVA: 0x6CF5E230E4 Offset: 0xDCC0E4 VA: 0x6CF5E230E4
	public static int GetTurn(RoomInfo room) { }

	// RVA: 0x6CF5E234B0 Offset: 0xDCC4B0 VA: 0x6CF5E234B0
	public static int GetTurnStart(RoomInfo room) { }

	// RVA: 0x6CF5E2427C Offset: 0xDCD27C VA: 0x6CF5E2427C
	public static int GetFinishedTurn(PhotonPlayer player) { }

	// RVA: 0x6CF5E23B74 Offset: 0xDCCB74 VA: 0x6CF5E23B74
	public static void SetFinishedTurn(PhotonPlayer player, int turn) { }

	// RVA: 0x6CF5E243E4 Offset: 0xDCD3E4 VA: 0x6CF5E243E4
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class QuitOnEscapeOrBack : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E24488 Offset: 0xDCD488 VA: 0x6CF5E24488
	private void Update() { }

	// RVA: 0x6CF5E244E8 Offset: 0xDCD4E8 VA: 0x6CF5E244E8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ServerTime : MonoBehaviour
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E244F0 Offset: 0xDCD4F0 VA: 0x6CF5E244F0
	private void OnGUI() { }

	// RVA: 0x6CF5E246F0 Offset: 0xDCD6F0 VA: 0x6CF5E246F0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ShowInfoOfPlayer : MonoBehaviour
{
	// Fields

	private GameObject textGo; // 0x28
	private TextMesh tm; // 0x30
	public float CharacterSize; // 0x38
	public Font font; // 0x40
	public bool DisableOnOwnObjects; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E246F8 Offset: 0xDCD6F8 VA: 0x6CF5E246F8
	private void Start() { }

	// RVA: 0x6CF5E24A4C Offset: 0xDCDA4C VA: 0x6CF5E24A4C
	private void Update() { }

	// RVA: 0x6CF5E24BE4 Offset: 0xDCDBE4 VA: 0x6CF5E24BE4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ShowStatusWhenConnecting : MonoBehaviour
{
	// Fields

	public GUISkin Skin; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E24BEC Offset: 0xDCDBEC VA: 0x6CF5E24BEC
	private void OnGUI() { }

	// RVA: 0x6CF5E24F0C Offset: 0xDCDF0C VA: 0x6CF5E24F0C
	private string GetConnectingDots() { }

	// RVA: 0x6CF5E25000 Offset: 0xDCE000 VA: 0x6CF5E25000
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SmoothSyncMovement : MonoBehaviour, IPunObservable
{
	// Fields

	public float SmoothingDelay; // 0x28
	private Vector3 correctPlayerPos; // 0x2C
	private Quaternion correctPlayerRot; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E25008 Offset: 0xDCE008 VA: 0x6CF5E25008
	public void Awake() { }

	// RVA: 0x6CF5E25208 Offset: 0xDCE208 VA: 0x6CF5E25208
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { }

	// RVA: 0x6CF5E25370 Offset: 0xDCE370 VA: 0x6CF5E25370
	public void Update() { }

	// RVA: 0x6CF5E25504 Offset: 0xDCE504 VA: 0x6CF5E25504
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SupportLogger : MonoBehaviour
{
	// Fields

	public bool LogTrafficStats; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E255A4 Offset: 0xDCE5A4 VA: 0x6CF5E255A4
	public void Start() { }

	// RVA: 0x6CF5E256B4 Offset: 0xDCE6B4 VA: 0x6CF5E256B4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SupportLogging : MonoBehaviour
{
	// Fields

	public bool LogTrafficStats; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E256C4 Offset: 0xDCE6C4 VA: 0x6CF5E256C4
	public void Start() { }

	// RVA: 0x6CF5E2572C Offset: 0xDCE72C VA: 0x6CF5E2572C
	protected void OnApplicationPause(bool pause) { }

	// RVA: 0x6CF5E2585C Offset: 0xDCE85C VA: 0x6CF5E2585C
	public void OnApplicationQuit() { }

	// RVA: 0x6CF5E25864 Offset: 0xDCE864 VA: 0x6CF5E25864
	public void LogStats() { }

	// RVA: 0x6CF5E2592C Offset: 0xDCE92C VA: 0x6CF5E2592C
	private void LogBasics() { }

	// RVA: 0x6CF5E25BA4 Offset: 0xDCEBA4 VA: 0x6CF5E25BA4
	public void OnConnectedToPhoton() { }

	// RVA: 0x6CF5E25C58 Offset: 0xDCEC58 VA: 0x6CF5E25C58
	public void OnFailedToConnectToPhoton(DisconnectCause cause) { }

	// RVA: 0x6CF5E25D48 Offset: 0xDCED48 VA: 0x6CF5E25D48
	public void OnJoinedLobby() { }

	// RVA: 0x6CF5E25E28 Offset: 0xDCEE28 VA: 0x6CF5E25E28
	public void OnJoinedRoom() { }

	// RVA: 0x6CF5E25FD8 Offset: 0xDCEFD8 VA: 0x6CF5E25FD8
	public void OnCreatedRoom() { }

	// RVA: 0x6CF5E26188 Offset: 0xDCF188 VA: 0x6CF5E26188
	public void OnLeftRoom() { }

	// RVA: 0x6CF5E261F0 Offset: 0xDCF1F0 VA: 0x6CF5E261F0
	public void OnDisconnectedFromPhoton() { }

	// RVA: 0x6CF5E26258 Offset: 0xDCF258 VA: 0x6CF5E26258
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Action`1 <>9__13_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF5E27140 Offset: 0xDD0140 VA: 0x6CF5E27140
	private static void .cctor() { }

	// RVA: 0x6CF5E2719C Offset: 0xDD019C VA: 0x6CF5E2719C
	public void .ctor() { }

	// RVA: 0x6CF5E271A4 Offset: 0xDD01A4 VA: 0x6CF5E271A4
	internal void <Start>b__13_0(SdkConfiguration sdkConfiguration) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <RecordTimeRoutine>d__12 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ReklamTamEkran <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E265E4 Offset: 0xDCF5E4 VA: 0x6CF5E265E4
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E271F8 Offset: 0xDD01F8 VA: 0x6CF5E271F8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E271FC Offset: 0xDD01FC VA: 0x6CF5E271FC
	private bool MoveNext() { }

	// RVA: 0x6CF5E274CC Offset: 0xDD04CC VA: 0x6CF5E274CC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E274D4 Offset: 0xDD04D4 VA: 0x6CF5E274D4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E2750C Offset: 0xDD050C VA: 0x6CF5E2750C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ReklamTamEkran : MonoBehaviour
{
	// Fields

	private string adUnitId; // 0x20
	private string RewardAdUnit; // 0x28
	private int retryAttempt; // 0x30
	public static bool timedrewardsreklam; // 0x0
	private string mAuthCode; // 0x38
	private static GameObject instance; // 0x8
	private int MyPlayTime; // 0x40
	private int PlayTimeMinute; // 0x44
	private int PlayTimeHour; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E26260 Offset: 0xDCF260 VA: 0x6CF5E26260
	private void Awake() { }

	// RVA: 0x6CF5E26350 Offset: 0xDCF350 VA: 0x6CF5E26350
	public void DoAuthenticate() { }

	// RVA: 0x6CF5E263F4 Offset: 0xDCF3F4 VA: 0x6CF5E263F4
	private void OnSignInResult(SignInStatus signInStatus) { }

	// RVA: 0x6CF5E26584 Offset: 0xDCF584 VA: 0x6CF5E26584
	public IEnumerator RecordTimeRoutine() { }

	// RVA: 0x6CF5E2660C Offset: 0xDCF60C VA: 0x6CF5E2660C
	public void Start() { }

	// RVA: 0x6CF5E26C40 Offset: 0xDCFC40 VA: 0x6CF5E26C40
	public void Reklam() { }

	// RVA: 0x6CF5E26D34 Offset: 0xDCFD34 VA: 0x6CF5E26D34
	public void UnityRewardedAd() { }

	// RVA: 0x6CF5E26790 Offset: 0xDCF790 VA: 0x6CF5E26790
	public void InitializeInterstitialAds() { }

	// RVA: 0x6CF5E26CD8 Offset: 0xDCFCD8 VA: 0x6CF5E26CD8
	private void LoadInterstitial() { }

	// RVA: 0x6CF5E26E28 Offset: 0xDCFE28 VA: 0x6CF5E26E28
	private void OnInterstitialLoadedEvent(string adUnitId, AdInfo adInfo) { }

	// RVA: 0x6CF5E26E30 Offset: 0xDCFE30 VA: 0x6CF5E26E30
	private void OnInterstitialLoadFailedEvent(string adUnitId, ErrorInfo errorInfo) { }

	// RVA: 0x6CF5E26ED0 Offset: 0xDCFED0 VA: 0x6CF5E26ED0
	private void OnInterstitialDisplayedEvent(string adUnitId, AdInfo adInfo) { }

	// RVA: 0x6CF5E26ED4 Offset: 0xDCFED4 VA: 0x6CF5E26ED4
	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, ErrorInfo errorInfo, AdInfo adInfo) { }

	// RVA: 0x6CF5E26ED8 Offset: 0xDCFED8 VA: 0x6CF5E26ED8
	private void OnInterstitialClickedEvent(string adUnitId, AdInfo adInfo) { }

	// RVA: 0x6CF5E26EDC Offset: 0xDCFEDC VA: 0x6CF5E26EDC
	private void OnInterstitialHiddenEvent(string adUnitId, AdInfo adInfo) { }

	// RVA: 0x6CF5E26EE0 Offset: 0xDCFEE0 VA: 0x6CF5E26EE0
	private void OnAdRevenuePaidEvent(string adUnitId, AdInfo adInfo) { }

	// RVA: 0x6CF5E269C0 Offset: 0xDCF9C0 VA: 0x6CF5E269C0
	public void InitializeRewardedAds() { }

	// RVA: 0x6CF5E26DCC Offset: 0xDCFDCC VA: 0x6CF5E26DCC
	private void LoadRewardedAd() { }

	// RVA: 0x6CF5E26EE4 Offset: 0xDCFEE4 VA: 0x6CF5E26EE4
	private void OnRewardedAdLoadedEvent(string RewardAdUnit, AdInfo adInfo) { }

	// RVA: 0x6CF5E26F38 Offset: 0xDCFF38 VA: 0x6CF5E26F38
	private void OnRewardedAdLoadFailedEvent(string RewardAdUnit, ErrorInfo errorInfo) { }

	// RVA: 0x6CF5E26FD8 Offset: 0xDCFFD8 VA: 0x6CF5E26FD8
	private void OnRewardedAdDisplayedEvent(string RewardAdUnit, AdInfo adInfo) { }

	// RVA: 0x6CF5E26FDC Offset: 0xDCFFDC VA: 0x6CF5E26FDC
	private void OnRewardedAdFailedToDisplayEvent(string RewardAdUnit, ErrorInfo errorInfo, AdInfo adInfo) { }

	// RVA: 0x6CF5E26FE0 Offset: 0xDCFFE0 VA: 0x6CF5E26FE0
	private void OnRewardedAdClickedEvent(string RewardAdUnit, AdInfo adInfo) { }

	// RVA: 0x6CF5E26FE4 Offset: 0xDCFFE4 VA: 0x6CF5E26FE4
	private void OnRewardedAdHiddenEvent(string RewardAdUnit, AdInfo adInfo) { }

	// RVA: 0x6CF5E26FE8 Offset: 0xDCFFE8 VA: 0x6CF5E26FE8
	private void OnRewardedAdReceivedRewardEvent(string RewardAdUnit, Reward reward, AdInfo adInfo) { }

	// RVA: 0x6CF5E270C4 Offset: 0xDD00C4 VA: 0x6CF5E270C4
	private void OnRewardedAdRevenuePaidEvent(string RewardAdUnit, AdInfo adInfo) { }

	// RVA: 0x6CF5E270C8 Offset: 0xDD00C8 VA: 0x6CF5E270C8
	public void .ctor() { }

	// RVA: 0x6CF5E27138 Offset: 0xDD0138 VA: 0x6CF5E27138
	private void <OnSignInResult>b__11_0(string authCode) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RewardScript : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E27514 Offset: 0xDD0514 VA: 0x6CF5E27514
	private void Start() { }

	// RVA: 0x6CF5E275F4 Offset: 0xDD05F4 VA: 0x6CF5E275F4
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E27658 Offset: 0xDD0658 VA: 0x6CF5E27658
	private void Update() { }

	// RVA: 0x6CF5E276F8 Offset: 0xDD06F8 VA: 0x6CF5E276F8
	private void OnEnable() { }

	// RVA: 0x6CF5E27890 Offset: 0xDD0890 VA: 0x6CF5E27890
	private void OnDisable() { }

	// RVA: 0x6CF5E27A28 Offset: 0xDD0A28 VA: 0x6CF5E27A28
	public void OnClaimPrizeDailyRewards(int day) { }

	// RVA: 0x6CF5E27C50 Offset: 0xDD0C50 VA: 0x6CF5E27C50
	public void OnClaimPrizeTimedRewards(int index) { }

	// RVA: 0x6CF5E28020 Offset: 0xDD1020 VA: 0x6CF5E28020
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class RunTimeCombineAndRelease : MonoBehaviour
{
	// Fields

	public SimpleMeshCombine simpleMeshCombine; // 0x20
	public float combineTime; // 0x28
	public float releaseTime; // 0x2C

	// Properties


	// Methods

	// RVA: 0x6CF5E2808C Offset: 0xDD108C VA: 0x6CF5E2808C
	public void Awake() { }

	// RVA: 0x6CF5E280DC Offset: 0xDD10DC VA: 0x6CF5E280DC
	public void Start() { }

	// RVA: 0x6CF5E281DC Offset: 0xDD11DC VA: 0x6CF5E281DC
	public void Combine() { }

	// RVA: 0x6CF5E28F5C Offset: 0xDD1F5C VA: 0x6CF5E28F5C
	public void Release() { }

	// RVA: 0x6CF5E29190 Offset: 0xDD2190 VA: 0x6CF5E29190
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SimpleMeshCombine : MonoBehaviour
{
	// Fields

	public GameObject[] combinedGameOjects; // 0x20
	public GameObject combined; // 0x28
	public string meshName; // 0x30
	public bool _canGenerateLightmapUV; // 0x38
	public int vCount; // 0x3C
	public bool generateLightmapUV; // 0x40
	public GameObject copyTarget; // 0x48
	public bool destroyOldColliders; // 0x50
	public bool keepStructure; // 0x51

	// Properties


	// Methods

	// RVA: 0x6CF5E29060 Offset: 0xDD2060 VA: 0x6CF5E29060
	public void EnableRenderers(bool e) { }

	// RVA: 0x6CF5E291A4 Offset: 0xDD21A4 VA: 0x6CF5E291A4
	public MeshFilter[] FindEnabledMeshes() { }

	// RVA: 0x6CF5E28258 Offset: 0xDD1258 VA: 0x6CF5E28258
	public void CombineMeshes() { }

	// RVA: 0x6CF5E293DC Offset: 0xDD23DC VA: 0x6CF5E293DC
	public int Contains(ArrayList l, Material n) { }

	// RVA: 0x6CF5E29514 Offset: 0xDD2514 VA: 0x6CF5E29514
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SimpleMeshCombineMaster : MonoBehaviour
{
	// Fields

	public bool generateLightmapUV; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E2956C Offset: 0xDD256C VA: 0x6CF5E2956C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class skindeneme1 : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public string weaponType; // 0x30
	public string weaponSkin; // 0x38
	public ObscuredInt weaponSkinID; // 0x40
	public ObscuredInt weaponSkinID2; // 0x54
	public ObscuredInt weaponSkinID3; // 0x68
	public ObscuredInt weaponSkinID4; // 0x7C
	public ObscuredInt weaponSkinID5; // 0x90
	public ObscuredInt weaponSkinID6; // 0xA4
	public ObscuredInt weaponSkinID7; // 0xB8
	public ObscuredInt weaponSkinID8; // 0xCC
	public ObscuredInt weaponSkinID9; // 0xE0
	public ObscuredInt weaponSkinID10; // 0xF4
	public ObscuredInt weaponSkinID11; // 0x108
	public ObscuredInt weaponSkinID12; // 0x11C
	public ObscuredInt weaponSkinID13; // 0x130
	public ObscuredInt weaponSkinID14; // 0x144
	public ObscuredInt weaponSkinID15; // 0x158
	public ObscuredInt weaponSkinID16; // 0x16C
	public ObscuredInt weaponSkinID17; // 0x180
	public ObscuredInt weaponSkinID18; // 0x194
	public ObscuredInt weaponSkinID19; // 0x1A8
	public ObscuredInt weaponSkinID20; // 0x1BC
	public Renderer Ak47; // 0x1D0
	public Renderer Aug; // 0x1D8
	public Renderer Awp; // 0x1E0
	public Renderer Deagle; // 0x1E8
	public Renderer Elite; // 0x1F0
	public Renderer Famas; // 0x1F8
	public Renderer Fiveseven; // 0x200
	public Renderer Knife; // 0x208
	public Renderer M3; // 0x210
	public Renderer M4a1; // 0x218
	public Renderer M249; // 0x220
	public Renderer Mac; // 0x228
	public Renderer Mp5; // 0x230
	public Renderer P90; // 0x238
	public Renderer P228; // 0x240
	public Renderer Scout; // 0x248
	public Renderer Sg550; // 0x250
	public Renderer Sg552; // 0x258
	public Renderer Usp; // 0x260
	public Renderer Xm1014; // 0x268
	public string weaponQuality; // 0x270
	public string weaponName; // 0x278
	public bool IsStatTrack; // 0x280
	public bool nameTag; // 0x281
	public SkinGameData Ss; // 0x288
	public GameObject StatTrack; // 0x290
	public TextMesh NameC; // 0x298

	// Properties


	// Methods

	// RVA: 0x6CF5E29574 Offset: 0xDD2574 VA: 0x6CF5E29574
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E295D8 Offset: 0xDD25D8 VA: 0x6CF5E295D8
	private void Start() { }

	// RVA: 0x6CF5E296DC Offset: 0xDD26DC VA: 0x6CF5E296DC
	private void Update() { }

	// RVA: 0x6CF5E2A5A4 Offset: 0xDD35A4 VA: 0x6CF5E2A5A4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class SkinGameData : MonoBehaviour
{
	// Fields

	public Texture[] Ak47; // 0x20
	public Texture[] Aug; // 0x28
	public Texture[] Awp; // 0x30
	public Texture[] Deagle; // 0x38
	public Texture[] Elite; // 0x40
	public Texture[] Famas; // 0x48
	public Texture[] Fiveseven; // 0x50
	public Texture[] Knife; // 0x58
	public Texture[] M3; // 0x60
	public Texture[] M4a1; // 0x68
	public Texture[] M249; // 0x70
	public Texture[] Mac; // 0x78
	public Texture[] Mp5; // 0x80
	public Texture[] P90; // 0x88
	public Texture[] P228; // 0x90
	public Texture[] Scout; // 0x98
	public Texture[] Sg550; // 0xA0
	public Texture[] Sg552; // 0xA8
	public Texture[] Usp; // 0xB0
	public Texture[] Xm1014; // 0xB8

	// Properties


	// Methods

	// RVA: 0x6CF5E2A610 Offset: 0xDD3610 VA: 0x6CF5E2A610
	private void Start() { }

	// RVA: 0x6CF5E2A614 Offset: 0xDD3614 VA: 0x6CF5E2A614
	private void Update() { }

	// RVA: 0x6CF5E2A618 Offset: 0xDD3618 VA: 0x6CF5E2A618
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class scene : MonoBehaviour
{
	// Fields

	public int extraMoney; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E2A620 Offset: 0xDD3620 VA: 0x6CF5E2A620
	private void Start() { }

	// RVA: 0x6CF5E2A624 Offset: 0xDD3624 VA: 0x6CF5E2A624
	private void Update() { }

	// RVA: 0x6CF5E2A628 Offset: 0xDD3628 VA: 0x6CF5E2A628
	public void change() { }

	// RVA: 0x6CF5E2A690 Offset: 0xDD3690 VA: 0x6CF5E2A690
	public void extra() { }

	// RVA: 0x6CF5E2A6A0 Offset: 0xDD36A0 VA: 0x6CF5E2A6A0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class BuyWeaponNew : MonoBehaviour
{
	// Fields

	private ObscuredBool cheat; // 0x20
	public Manager mng; // 0x30
	public CanvasScript cs; // 0x38
	public CheckWeaponBuyed cwb; // 0x40
	public int index; // 0x48
	public ObscuredInt money; // 0x4C
	public ObscuredInt weaponPrice; // 0x60
	public string weaponName; // 0x78
	public string buy; // 0x80
	public bool weaponBuyed; // 0x88
	public GameObject selectedWeapon; // 0x90
	public Button selectedButton; // 0x98
	public GameObject selectedModel; // 0xA0
	public Text selectedText; // 0xA8
	public GameObject[] weapons; // 0xB0
	public Button[] buyButtons; // 0xB8
	public GameObject[] weaponModels; // 0xC0
	public Text[] weaponTexts; // 0xC8

	// Properties


	// Methods

	// RVA: 0x6CF5E2A6A8 Offset: 0xDD36A8 VA: 0x6CF5E2A6A8
	private void Start() { }

	// RVA: 0x6CF5E2A894 Offset: 0xDD3894 VA: 0x6CF5E2A894
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E2A8F8 Offset: 0xDD38F8 VA: 0x6CF5E2A8F8
	private void Update() { }

	// RVA: 0x6CF5E2A998 Offset: 0xDD3998 VA: 0x6CF5E2A998
	public void back() { }

	// RVA: 0x6CF5E2A9E4 Offset: 0xDD39E4 VA: 0x6CF5E2A9E4
	public void checkWeapon() { }

	// RVA: 0x6CF5E2AEF4 Offset: 0xDD3EF4 VA: 0x6CF5E2AEF4
	public void findWeapon(int i) { }

	// RVA: 0x6CF5E2B024 Offset: 0xDD4024 VA: 0x6CF5E2B024
	public void buyWeapon() { }

	// RVA: 0x6CF5E2B550 Offset: 0xDD4550 VA: 0x6CF5E2B550
	public void saveBuy(string saveWeapon) { }

	// RVA: 0x6CF5E2B1AC Offset: 0xDD41AC VA: 0x6CF5E2B1AC
	public void checkBuy() { }

	// RVA: 0x6CF5E2B7B8 Offset: 0xDD47B8 VA: 0x6CF5E2B7B8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CanvasScript : MonoBehaviour
{
	// Fields

	public string weaponName; // 0x20
	public int weaponPrice; // 0x28
	public Button[] buttons; // 0x30
	public Text weaponText; // 0x38
	public Text priceText; // 0x40
	public BuyWeaponNew bw; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E2B824 Offset: 0xDD4824 VA: 0x6CF5E2B824
	private void Start() { }

	// RVA: 0x6CF5E2B828 Offset: 0xDD4828 VA: 0x6CF5E2B828
	private void Update() { }

	// RVA: 0x6CF5E2B82C Offset: 0xDD482C VA: 0x6CF5E2B82C
	public void OnClickedButton(string name) { }

	// RVA: 0x6CF5E2B854 Offset: 0xDD4854 VA: 0x6CF5E2B854
	public void writeText() { }

	// RVA: 0x6CF5E2B9BC Offset: 0xDD49BC VA: 0x6CF5E2B9BC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class CheckWeaponBuyed : MonoBehaviour
{
	// Fields

	public bool buyed; // 0x20
	public string buy; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E2B9C4 Offset: 0xDD49C4 VA: 0x6CF5E2B9C4
	private void Start() { }

	// RVA: 0x6CF5E2BA34 Offset: 0xDD4A34 VA: 0x6CF5E2BA34
	private void Update() { }

	// RVA: 0x6CF5E2B768 Offset: 0xDD4768 VA: 0x6CF5E2B768
	public void checkWeapon() { }

	// RVA: 0x6CF5E2BA38 Offset: 0xDD4A38 VA: 0x6CF5E2BA38
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Manager : MonoBehaviour
{
	// Fields

	public ObscuredInt weapontools; // 0x20
	public GameObject Menuyoket; // 0x38
	public static ObscuredBool tools5; // 0x0
	public static ObscuredBool tools100; // 0xC
	public Text weapontoolsText; // 0x40
	private ObscuredBool cheat; // 0x48
	public ReklamTamEkran reklamcagir4; // 0x58

	// Properties


	// Methods

	// RVA: 0x6CF5E2BA40 Offset: 0xDD4A40 VA: 0x6CF5E2BA40
	private void Start() { }

	// RVA: 0x6CF5E2C0C0 Offset: 0xDD50C0 VA: 0x6CF5E2C0C0
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E2C124 Offset: 0xDD5124 VA: 0x6CF5E2C124
	public void Add5WeaponTools() { }

	// RVA: 0x6CF5E2C1D0 Offset: 0xDD51D0 VA: 0x6CF5E2C1D0
	private void Update() { }

	// RVA: 0x6CF5E2C270 Offset: 0xDD5270 VA: 0x6CF5E2C270
	public void changeScene() { }

	// RVA: 0x6CF5E2B360 Offset: 0xDD4360 VA: 0x6CF5E2B360
	public bool canBuy(int amount) { }

	// RVA: 0x6CF5E2B3F8 Offset: 0xDD43F8 VA: 0x6CF5E2B3F8
	public void changeMoney(int amount) { }

	// RVA: 0x6CF5E2C408 Offset: 0xDD5408 VA: 0x6CF5E2C408
	public void resetAll() { }

	// RVA: 0x6CF5E2C458 Offset: 0xDD5458 VA: 0x6CF5E2C458
	public void .ctor() { }

	// RVA: 0x6CF5E2C4C4 Offset: 0xDD54C4 VA: 0x6CF5E2C4C4
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class ObjectRotator : MonoBehaviour
{
	// Fields

	public float rotationMin; // 0x20
	public float rotationMax; // 0x24
	public Slider rotationSlider; // 0x28
	public Slider powerSlider; // 0x30
	public float currentRoation; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E2C55C Offset: 0xDD555C VA: 0x6CF5E2C55C
	private void Start() { }

	// RVA: 0x6CF5E2C560 Offset: 0xDD5560 VA: 0x6CF5E2C560
	private void Update() { }

	// RVA: 0x6CF5E2C5B4 Offset: 0xDD55B4 VA: 0x6CF5E2C5B4
	private void OnGUI() { }

	// RVA: 0x6CF5E2C670 Offset: 0xDD5670 VA: 0x6CF5E2C670
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <LateCall>d__9 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Watch <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E2C984 Offset: 0xDD5984 VA: 0x6CF5E2C984
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E2C9B4 Offset: 0xDD59B4 VA: 0x6CF5E2C9B4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E2C9B8 Offset: 0xDD59B8 VA: 0x6CF5E2C9B8
	private bool MoveNext() { }

	// RVA: 0x6CF5E2CAF0 Offset: 0xDD5AF0 VA: 0x6CF5E2CAF0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E2CAF8 Offset: 0xDD5AF8 VA: 0x6CF5E2CAF8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E2CB30 Offset: 0xDD5B30 VA: 0x6CF5E2CB30
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class Watch : MonoBehaviour
{
	// Fields

	public ReklamTamEkran reklamcagir2; // 0x20
	public Manager mng; // 0x28
	public int currentMoney; // 0x30
	public int extra; // 0x34
	public GameObject back; // 0x38
	public Text text; // 0x40
	public string gain; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E2C680 Offset: 0xDD5680 VA: 0x6CF5E2C680
	private void Awake() { }

	// RVA: 0x6CF5E2C7A4 Offset: 0xDD57A4 VA: 0x6CF5E2C7A4
	public void watchAds() { }

	// RVA: 0x6CF5E2C924 Offset: 0xDD5924 VA: 0x6CF5E2C924
	private IEnumerator LateCall() { }

	// RVA: 0x6CF5E2C9AC Offset: 0xDD59AC VA: 0x6CF5E2C9AC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public class WeaponAnim : MonoBehaviour
{
	// Fields

	public GameObject weapon; // 0x20
	public Image image; // 0x28
	public Animation anim; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5E2CB38 Offset: 0xDD5B38 VA: 0x6CF5E2CB38
	private void Start() { }

	// RVA: 0x6CF5E2CBCC Offset: 0xDD5BCC VA: 0x6CF5E2CBCC
	private void Update() { }

	// RVA: 0x6CF5E2CC40 Offset: 0xDD5C40 VA: 0x6CF5E2CC40
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct MonoScriptData
{
	// Fields

	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E2CC48 Offset: 0xDD5C48 VA: 0x6CF5E2CC48
	private static MonoScriptData Get() { }

	// RVA: 0x6CF5E2CD0C Offset: 0xDD5D0C VA: 0x6CF5E2CD0C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon
public class MonoBehaviour : MonoBehaviour
{
	// Fields

	private PhotonView pvCache; // 0x20

	// Properties

	public PhotonView photonView { get; }

	// Methods

	// RVA: 0x6CF5E1C36C Offset: 0xDC536C VA: 0x6CF5E1C36C
	public PhotonView get_photonView() { }

	// RVA: 0x6CF5E1C3FC Offset: 0xDC53FC VA: 0x6CF5E1C3FC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon
public class PunBehaviour : MonoBehaviour, IPunCallbacks
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E2CD14 Offset: 0xDD5D14 VA: 0x6CF5E2CD14
	public virtual void OnConnectedToPhoton() { }

	// RVA: 0x6CF5E2CD18 Offset: 0xDD5D18 VA: 0x6CF5E2CD18
	public virtual void OnLeftRoom() { }

	// RVA: 0x6CF5E2CD1C Offset: 0xDD5D1C VA: 0x6CF5E2CD1C
	public virtual void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5E2CD20 Offset: 0xDD5D20 VA: 0x6CF5E2CD20
	public virtual void OnPhotonCreateRoomFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5E2CD24 Offset: 0xDD5D24 VA: 0x6CF5E2CD24
	public virtual void OnPhotonJoinRoomFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5E2CD28 Offset: 0xDD5D28 VA: 0x6CF5E2CD28
	public virtual void OnCreatedRoom() { }

	// RVA: 0x6CF5E2CD2C Offset: 0xDD5D2C VA: 0x6CF5E2CD2C
	public virtual void OnJoinedLobby() { }

	// RVA: 0x6CF5E2CD30 Offset: 0xDD5D30 VA: 0x6CF5E2CD30
	public virtual void OnLeftLobby() { }

	// RVA: 0x6CF5E2CD34 Offset: 0xDD5D34 VA: 0x6CF5E2CD34
	public virtual void OnFailedToConnectToPhoton(DisconnectCause cause) { }

	// RVA: 0x6CF5E2CD38 Offset: 0xDD5D38 VA: 0x6CF5E2CD38
	public virtual void OnDisconnectedFromPhoton() { }

	// RVA: 0x6CF5E2CD3C Offset: 0xDD5D3C VA: 0x6CF5E2CD3C
	public virtual void OnConnectionFail(DisconnectCause cause) { }

	// RVA: 0x6CF5E2CD40 Offset: 0xDD5D40 VA: 0x6CF5E2CD40
	public virtual void OnPhotonInstantiate(PhotonMessageInfo info) { }

	// RVA: 0x6CF5E2CD44 Offset: 0xDD5D44 VA: 0x6CF5E2CD44
	public virtual void OnReceivedRoomListUpdate() { }

	// RVA: 0x6CF5E2CD48 Offset: 0xDD5D48 VA: 0x6CF5E2CD48
	public virtual void OnJoinedRoom() { }

	// RVA: 0x6CF5E2CD4C Offset: 0xDD5D4C VA: 0x6CF5E2CD4C
	public virtual void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5E2CD50 Offset: 0xDD5D50 VA: 0x6CF5E2CD50
	public virtual void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5E2CD54 Offset: 0xDD5D54 VA: 0x6CF5E2CD54
	public virtual void OnPhotonRandomJoinFailed(Object[] codeAndMsg) { }

	// RVA: 0x6CF5E2CD58 Offset: 0xDD5D58 VA: 0x6CF5E2CD58
	public virtual void OnConnectedToMaster() { }

	// RVA: 0x6CF5E2CD5C Offset: 0xDD5D5C VA: 0x6CF5E2CD5C
	public virtual void OnPhotonMaxCccuReached() { }

	// RVA: 0x6CF5E2CD60 Offset: 0xDD5D60 VA: 0x6CF5E2CD60
	public virtual void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged) { }

	// RVA: 0x6CF5E2CD64 Offset: 0xDD5D64 VA: 0x6CF5E2CD64
	public virtual void OnPhotonPlayerPropertiesChanged(Object[] playerAndUpdatedProps) { }

	// RVA: 0x6CF5E2CD68 Offset: 0xDD5D68 VA: 0x6CF5E2CD68
	public virtual void OnUpdatedFriendList() { }

	// RVA: 0x6CF5E2CD6C Offset: 0xDD5D6C VA: 0x6CF5E2CD6C
	public virtual void OnCustomAuthenticationFailed(string debugMessage) { }

	// RVA: 0x6CF5E2CD70 Offset: 0xDD5D70 VA: 0x6CF5E2CD70
	public virtual void OnCustomAuthenticationResponse(Dictionary`2 data) { }

	// RVA: 0x6CF5E2CD74 Offset: 0xDD5D74 VA: 0x6CF5E2CD74
	public virtual void OnWebRpcResponse(OperationResponse response) { }

	// RVA: 0x6CF5E2CD78 Offset: 0xDD5D78 VA: 0x6CF5E2CD78
	public virtual void OnOwnershipRequest(Object[] viewAndPlayer) { }

	// RVA: 0x6CF5E2CD7C Offset: 0xDD5D7C VA: 0x6CF5E2CD7C
	public virtual void OnLobbyStatisticsUpdate() { }

	// RVA: 0x6CF5E2CD80 Offset: 0xDD5D80 VA: 0x6CF5E2CD80
	public virtual void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5E2CD84 Offset: 0xDD5D84 VA: 0x6CF5E2CD84
	public virtual void OnOwnershipTransfered(Object[] viewAndPlayers) { }

	// RVA: 0x6CF5E24274 Offset: 0xDCD274 VA: 0x6CF5E24274
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChannelCreationOptions : Object
{
	// Fields

	public static ChannelCreationOptions Default; // 0x0
	private bool <PublishSubscribers>k__BackingField; // 0x10
	private int <MaxSubscribers>k__BackingField; // 0x14

	// Properties

	public bool PublishSubscribers { get; set; }
	public int MaxSubscribers { get; set; }

	// Methods

	// RVA: 0x6CF5E2CD88 Offset: 0xDD5D88 VA: 0x6CF5E2CD88
	public bool get_PublishSubscribers() { }

	// RVA: 0x6CF5E2CD90 Offset: 0xDD5D90 VA: 0x6CF5E2CD90
	public void set_PublishSubscribers(bool value) { }

	// RVA: 0x6CF5E2CD9C Offset: 0xDD5D9C VA: 0x6CF5E2CD9C
	public int get_MaxSubscribers() { }

	// RVA: 0x6CF5E2CDA4 Offset: 0xDD5DA4 VA: 0x6CF5E2CDA4
	public void set_MaxSubscribers(int value) { }

	// RVA: 0x6CF5E2CDAC Offset: 0xDD5DAC VA: 0x6CF5E2CDAC
	public void .ctor() { }

	// RVA: 0x6CF5E2CDB4 Offset: 0xDD5DB4 VA: 0x6CF5E2CDB4
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChannelWellKnownProperties : Object
{
	// Fields

	public const byte MaxSubscribers; // 0x0
	public const byte PublishSubscribers; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E2CE10 Offset: 0xDD5E10 VA: 0x6CF5E2CE10
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatChannel : Object
{
	// Fields

	public readonly string Name; // 0x10
	public readonly List`1 Senders; // 0x18
	public readonly List`1 Messages; // 0x20
	public int MessageLimit; // 0x28
	private bool <IsPrivate>k__BackingField; // 0x2C
	private int <LastMsgId>k__BackingField; // 0x30
	private Dictionary`2 properties; // 0x38
	private bool <PublishSubscribers>k__BackingField; // 0x40
	private int <MaxSubscribers>k__BackingField; // 0x44
	public readonly HashSet`1 Subscribers; // 0x48

	// Properties

	public bool IsPrivate { get; set; }
	public int MessageCount { get; }
	public int LastMsgId { get; set; }
	public bool PublishSubscribers { get; set; }
	public int MaxSubscribers { get; set; }

	// Methods

	// RVA: 0x6CF5E2CE18 Offset: 0xDD5E18 VA: 0x6CF5E2CE18
	public bool get_IsPrivate() { }

	// RVA: 0x6CF5E2CE20 Offset: 0xDD5E20 VA: 0x6CF5E2CE20
	protected internal void set_IsPrivate(bool value) { }

	// RVA: 0x6CF5E2CE2C Offset: 0xDD5E2C VA: 0x6CF5E2CE2C
	public int get_MessageCount() { }

	// RVA: 0x6CF5E2CE74 Offset: 0xDD5E74 VA: 0x6CF5E2CE74
	public int get_LastMsgId() { }

	// RVA: 0x6CF5E2CE7C Offset: 0xDD5E7C VA: 0x6CF5E2CE7C
	protected void set_LastMsgId(int value) { }

	// RVA: 0x6CF5E2CE84 Offset: 0xDD5E84 VA: 0x6CF5E2CE84
	public bool get_PublishSubscribers() { }

	// RVA: 0x6CF5E2CE8C Offset: 0xDD5E8C VA: 0x6CF5E2CE8C
	protected void set_PublishSubscribers(bool value) { }

	// RVA: 0x6CF5E2CE98 Offset: 0xDD5E98 VA: 0x6CF5E2CE98
	public int get_MaxSubscribers() { }

	// RVA: 0x6CF5E2CEA0 Offset: 0xDD5EA0 VA: 0x6CF5E2CEA0
	protected void set_MaxSubscribers(int value) { }

	// RVA: 0x6CF5E2CEA8 Offset: 0xDD5EA8 VA: 0x6CF5E2CEA8
	public void .ctor(string name) { }

	// RVA: 0x6CF5E2CFC0 Offset: 0xDD5FC0 VA: 0x6CF5E2CFC0
	public void Add(string sender, object message, int msgId) { }

	// RVA: 0x6CF5E2D1A0 Offset: 0xDD61A0 VA: 0x6CF5E2D1A0
	public void Add(String[] senders, Object[] messages, int lastMsgId) { }

	// RVA: 0x6CF5E2D0E4 Offset: 0xDD60E4 VA: 0x6CF5E2D0E4
	public void TruncateMessages() { }

	// RVA: 0x6CF5E2D23C Offset: 0xDD623C VA: 0x6CF5E2D23C
	public void ClearMessages() { }

	// RVA: 0x6CF5E2D2E4 Offset: 0xDD62E4 VA: 0x6CF5E2D2E4
	public string ToStringMessages() { }

	// RVA: 0x6CF5E2D428 Offset: 0xDD6428 VA: 0x6CF5E2D428
	internal void ReadProperties(Dictionary`2 newProperties) { }

	// RVA: 0x6CF5E2D82C Offset: 0xDD682C VA: 0x6CF5E2D82C
	internal void AddSubscribers(String[] users) { }

	// RVA: 0x6CF5E2D8C8 Offset: 0xDD68C8 VA: 0x6CF5E2D8C8
	internal void ClearProperties() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatClient : Object, IPhotonPeerListener
{
	// Fields

	private const int FriendRequestListMax; // 0x0
	public const int DefaultMaxSubscribers; // 0x0
	private string <NameServerAddress>k__BackingField; // 0x10
	private string <FrontendAddress>k__BackingField; // 0x18
	private string chatRegion; // 0x20
	private ChatState <State>k__BackingField; // 0x28
	private ChatDisconnectCause <DisconnectedCause>k__BackingField; // 0x2C
	private string <AppVersion>k__BackingField; // 0x30
	private string <AppId>k__BackingField; // 0x38
	private AuthenticationValues <AuthValues>k__BackingField; // 0x40
	public int MessageLimit; // 0x48
	public readonly Dictionary`2 PublicChannels; // 0x50
	public readonly Dictionary`2 PrivateChannels; // 0x58
	private readonly HashSet`1 PublicChannelsUnsubscribing; // 0x60
	private readonly IChatClientListener listener; // 0x68
	public ChatPeer chatPeer; // 0x70
	private const string ChatAppName; // 0x0
	private bool didAuthenticate; // 0x78
	private Nullable`1 statusToSetWhenConnected; // 0x7C
	private object messageToSetWhenConnected; // 0x88
	private int msDeltaForServiceCalls; // 0x90
	private int msTimestampOfLastServiceCall; // 0x94
	private bool <UseBackgroundWorkerForSending>k__BackingField; // 0x98

	// Properties

	public string NameServerAddress { get; set; }
	public string FrontendAddress { get; set; }
	public string ChatRegion { get; set; }
	public ChatState State { get; set; }
	public ChatDisconnectCause DisconnectedCause { get; set; }
	public bool CanChat { get; }
	private bool HasPeer { get; }
	public string AppVersion { get; set; }
	public string AppId { get; set; }
	public AuthenticationValues AuthValues { get; set; }
	public string UserId { get; set; }
	public bool UseBackgroundWorkerForSending { get; set; }
	public ConnectionProtocol TransportProtocol { get; set; }
	public Dictionary`2 SocketImplementationConfig { get; }
	public DebugLevel DebugOut { get; set; }

	// Methods

	// RVA: 0x6CF5E2D950 Offset: 0xDD6950 VA: 0x6CF5E2D950
	public string get_NameServerAddress() { }

	// RVA: 0x6CF5E2D958 Offset: 0xDD6958 VA: 0x6CF5E2D958
	private void set_NameServerAddress(string value) { }

	// RVA: 0x6CF5E2D960 Offset: 0xDD6960 VA: 0x6CF5E2D960
	public string get_FrontendAddress() { }

	// RVA: 0x6CF5E2D968 Offset: 0xDD6968 VA: 0x6CF5E2D968
	private void set_FrontendAddress(string value) { }

	// RVA: 0x6CF5E2D970 Offset: 0xDD6970 VA: 0x6CF5E2D970
	public string get_ChatRegion() { }

	// RVA: 0x6CF5E2D978 Offset: 0xDD6978 VA: 0x6CF5E2D978
	public void set_ChatRegion(string value) { }

	// RVA: 0x6CF5E2D980 Offset: 0xDD6980 VA: 0x6CF5E2D980
	public ChatState get_State() { }

	// RVA: 0x6CF5E2D988 Offset: 0xDD6988 VA: 0x6CF5E2D988
	private void set_State(ChatState value) { }

	// RVA: 0x6CF5E2D990 Offset: 0xDD6990 VA: 0x6CF5E2D990
	public ChatDisconnectCause get_DisconnectedCause() { }

	// RVA: 0x6CF5E2D998 Offset: 0xDD6998 VA: 0x6CF5E2D998
	private void set_DisconnectedCause(ChatDisconnectCause value) { }

	// RVA: 0x6CF5E2D9A0 Offset: 0xDD69A0 VA: 0x6CF5E2D9A0
	public bool get_CanChat() { }

	// RVA: 0x6CF5E2D9D4 Offset: 0xDD69D4 VA: 0x6CF5E2D9D4
	public bool CanChatInChannel(string channelName) { }

	// RVA: 0x6CF5E2D9C4 Offset: 0xDD69C4 VA: 0x6CF5E2D9C4
	private bool get_HasPeer() { }

	// RVA: 0x6CF5E2DA80 Offset: 0xDD6A80 VA: 0x6CF5E2DA80
	public string get_AppVersion() { }

	// RVA: 0x6CF5E2DA88 Offset: 0xDD6A88 VA: 0x6CF5E2DA88
	private void set_AppVersion(string value) { }

	// RVA: 0x6CF5E2DA90 Offset: 0xDD6A90 VA: 0x6CF5E2DA90
	public string get_AppId() { }

	// RVA: 0x6CF5E2DA98 Offset: 0xDD6A98 VA: 0x6CF5E2DA98
	private void set_AppId(string value) { }

	// RVA: 0x6CF5E2DAA0 Offset: 0xDD6AA0 VA: 0x6CF5E2DAA0
	public AuthenticationValues get_AuthValues() { }

	// RVA: 0x6CF5E2DAA8 Offset: 0xDD6AA8 VA: 0x6CF5E2DAA8
	public void set_AuthValues(AuthenticationValues value) { }

	// RVA: 0x6CF5E2DAB0 Offset: 0xDD6AB0 VA: 0x6CF5E2DAB0
	public string get_UserId() { }

	// RVA: 0x6CF5E2DAC8 Offset: 0xDD6AC8 VA: 0x6CF5E2DAC8
	private void set_UserId(string value) { }

	// RVA: 0x6CF5E2DB48 Offset: 0xDD6B48 VA: 0x6CF5E2DB48
	public bool get_UseBackgroundWorkerForSending() { }

	// RVA: 0x6CF5E2DB50 Offset: 0xDD6B50 VA: 0x6CF5E2DB50
	public void set_UseBackgroundWorkerForSending(bool value) { }

	// RVA: 0x6CF5E2DB5C Offset: 0xDD6B5C VA: 0x6CF5E2DB5C
	public ConnectionProtocol get_TransportProtocol() { }

	// RVA: 0x6CF5E2DB78 Offset: 0xDD6B78 VA: 0x6CF5E2DB78
	public void set_TransportProtocol(ConnectionProtocol value) { }

	// RVA: 0x6CF5E2DD18 Offset: 0xDD6D18 VA: 0x6CF5E2DD18
	public Dictionary`2 get_SocketImplementationConfig() { }

	// RVA: 0x6CF5E2DD34 Offset: 0xDD6D34 VA: 0x6CF5E2DD34
	public void .ctor(IChatClientListener listener, ConnectionProtocol protocol) { }

	// RVA: 0x6CF5E2DF00 Offset: 0xDD6F00 VA: 0x6CF5E2DF00
	public bool Connect(string appId, string appVersion, AuthenticationValues authValues) { }

	// RVA: 0x6CF5E2E1C8 Offset: 0xDD71C8 VA: 0x6CF5E2E1C8
	public bool ConnectAndSetStatus(string appId, string appVersion, AuthenticationValues authValues, int status, object message) { }

	// RVA: 0x6CF5E2E26C Offset: 0xDD726C VA: 0x6CF5E2E26C
	public void Service() { }

	// RVA: 0x6CF5E2E2E4 Offset: 0xDD72E4 VA: 0x6CF5E2E2E4
	private bool SendOutgoingInBackground() { }

	// RVA: 0x6CF5E2E318 Offset: 0xDD7318 VA: 0x6CF5E2E318
	public void SendAcksOnly() { }

	// RVA: 0x6CF5E2E330 Offset: 0xDD7330 VA: 0x6CF5E2E330
	public void Disconnect() { }

	// RVA: 0x6CF5E2E374 Offset: 0xDD7374 VA: 0x6CF5E2E374
	public void StopThread() { }

	// RVA: 0x6CF5E2E38C Offset: 0xDD738C VA: 0x6CF5E2E38C
	public bool Subscribe(String[] channels) { }

	// RVA: 0x6CF5E2E548 Offset: 0xDD7548 VA: 0x6CF5E2E548
	public bool Subscribe(String[] channels, Int32[] lastMsgIds) { }

	// RVA: 0x6CF5E2E394 Offset: 0xDD7394 VA: 0x6CF5E2E394
	public bool Subscribe(String[] channels, int messagesFromHistory) { }

	// RVA: 0x6CF5E2EAB4 Offset: 0xDD7AB4 VA: 0x6CF5E2EAB4
	public bool Unsubscribe(String[] channels) { }

	// RVA: 0x6CF5E2ECB8 Offset: 0xDD7CB8 VA: 0x6CF5E2ECB8
	public bool PublishMessage(string channelName, object message, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2EFB0 Offset: 0xDD7FB0 VA: 0x6CF5E2EFB0
	internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2ECC4 Offset: 0xDD7CC4 VA: 0x6CF5E2ECC4
	private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2EFBC Offset: 0xDD7FBC VA: 0x6CF5E2EFBC
	public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2EFCC Offset: 0xDD7FCC VA: 0x6CF5E2EFCC
	public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2F2D4 Offset: 0xDD82D4 VA: 0x6CF5E2F2D4
	internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2EFDC Offset: 0xDD7FDC VA: 0x6CF5E2EFDC
	private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook) { }

	// RVA: 0x6CF5E2F2E4 Offset: 0xDD82E4 VA: 0x6CF5E2F2E4
	private bool SetOnlineStatus(int status, object message, bool skipMessage) { }

	// RVA: 0x6CF5E2F540 Offset: 0xDD8540 VA: 0x6CF5E2F540
	public bool SetOnlineStatus(int status) { }

	// RVA: 0x6CF5E2F54C Offset: 0xDD854C VA: 0x6CF5E2F54C
	public bool SetOnlineStatus(int status, object message) { }

	// RVA: 0x6CF5E2F554 Offset: 0xDD8554 VA: 0x6CF5E2F554
	public bool AddFriends(String[] friends) { }

	// RVA: 0x6CF5E2F874 Offset: 0xDD8874 VA: 0x6CF5E2F874
	public bool RemoveFriends(String[] friends) { }

	// RVA: 0x6CF5E2FB94 Offset: 0xDD8B94 VA: 0x6CF5E2FB94
	public string GetPrivateChannelNameByUser(string userName) { }

	// RVA: 0x6CF5E2FBF8 Offset: 0xDD8BF8 VA: 0x6CF5E2FBF8
	public bool TryGetChannel(string channelName, bool isPrivate, ref ChatChannel channel) { }

	// RVA: 0x6CF5E2FC70 Offset: 0xDD8C70 VA: 0x6CF5E2FC70
	public bool TryGetChannel(string channelName, ref ChatChannel channel) { }

	// RVA: 0x6CF5E2FD08 Offset: 0xDD8D08 VA: 0x6CF5E2FD08
	public bool TryGetPrivateChannelByUser(string userId, ref ChatChannel channel) { }

	// RVA: 0x6CF5E2FD68 Offset: 0xDD8D68 VA: 0x6CF5E2FD68
	public void set_DebugOut(DebugLevel value) { }

	// RVA: 0x6CF5E2E948 Offset: 0xDD7948 VA: 0x6CF5E2E948
	public DebugLevel get_DebugOut() { }

	// RVA: 0x6CF5E2FD84 Offset: 0xDD8D84 VA: 0x6CF5E2FD84
	private void ExitGames.Client.Photon.IPhotonPeerListener.DebugReturn(DebugLevel level, string message) { }

	// RVA: 0x6CF5E2FE3C Offset: 0xDD8E3C VA: 0x6CF5E2FE3C
	private void ExitGames.Client.Photon.IPhotonPeerListener.OnEvent(EventData eventData) { }

	// RVA: 0x6CF5E31574 Offset: 0xDDA574 VA: 0x6CF5E31574
	private void ExitGames.Client.Photon.IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse) { }

	// RVA: 0x6CF5E31E7C Offset: 0xDDAE7C VA: 0x6CF5E31E7C
	private void ExitGames.Client.Photon.IPhotonPeerListener.OnStatusChanged(StatusCode statusCode) { }

	// RVA: 0x6CF5E2E964 Offset: 0xDD7964 VA: 0x6CF5E2E964
	private bool SendChannelOperation(String[] channels, byte operation, int historyLength) { }

	// RVA: 0x6CF5E301E8 Offset: 0xDD91E8 VA: 0x6CF5E301E8
	private void HandlePrivateMessageEvent(EventData eventData) { }

	// RVA: 0x6CF5E2FEAC Offset: 0xDD8EAC VA: 0x6CF5E2FEAC
	private void HandleChatMessagesEvent(EventData eventData) { }

	// RVA: 0x6CF5E30670 Offset: 0xDD9670 VA: 0x6CF5E30670
	private void HandleSubscribeEvent(EventData eventData) { }

	// RVA: 0x6CF5E30BB4 Offset: 0xDD9BB4 VA: 0x6CF5E30BB4
	private void HandleUnsubscribeEvent(EventData eventData) { }

	// RVA: 0x6CF5E31780 Offset: 0xDDA780 VA: 0x6CF5E31780
	private void HandleAuthResponse(OperationResponse operationResponse) { }

	// RVA: 0x6CF5E304A8 Offset: 0xDD94A8 VA: 0x6CF5E304A8
	private void HandleStatusUpdate(EventData eventData) { }

	// RVA: 0x6CF5E327CC Offset: 0xDDB7CC VA: 0x6CF5E327CC
	private void ConnectToFrontEnd() { }

	// RVA: 0x6CF5E325A4 Offset: 0xDDB5A4 VA: 0x6CF5E325A4
	private bool AuthenticateOnFrontEnd() { }

	// RVA: 0x6CF5E311E0 Offset: 0xDDA1E0 VA: 0x6CF5E311E0
	private void HandleUserUnsubscribedEvent(EventData eventData) { }

	// RVA: 0x6CF5E30D48 Offset: 0xDD9D48 VA: 0x6CF5E30D48
	private void HandleUserSubscribedEvent(EventData eventData) { }

	// RVA: 0x6CF5E328E8 Offset: 0xDDB8E8 VA: 0x6CF5E328E8
	public bool Subscribe(string channel, int lastMsgId, int messagesFromHistory, ChannelCreationOptions creationOptions) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public enum ChatDisconnectCause
{
	// Fields

	public int value__; // 0x10
	public const ChatDisconnectCause None = 0; // 0x0
	public const ChatDisconnectCause DisconnectByServerUserLimit = 1; // 0x0
	public const ChatDisconnectCause ExceptionOnConnect = 2; // 0x0
	public const ChatDisconnectCause DisconnectByServer = 3; // 0x0
	public const ChatDisconnectCause TimeoutDisconnect = 4; // 0x0
	public const ChatDisconnectCause Exception = 5; // 0x0
	public const ChatDisconnectCause InvalidAuthentication = 6; // 0x0
	public const ChatDisconnectCause MaxCcuReached = 7; // 0x0
	public const ChatDisconnectCause InvalidRegion = 8; // 0x0
	public const ChatDisconnectCause OperationNotAllowedInCurrentState = 9; // 0x0
	public const ChatDisconnectCause CustomAuthenticationFailed = 10; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatEventCode : Object
{
	// Fields

	public const byte ChatMessages; // 0x0
	public const byte Users; // 0x0
	public const byte PrivateMessage; // 0x0
	public const byte FriendsList; // 0x0
	public const byte StatusUpdate; // 0x0
	public const byte Subscribe; // 0x0
	public const byte Unsubscribe; // 0x0
	public const byte UserSubscribed; // 0x0
	public const byte UserUnsubscribed; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E32FCC Offset: 0xDDBFCC VA: 0x6CF5E32FCC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatOperationCode : Object
{
	// Fields

	public const byte Authenticate; // 0x0
	public const byte Subscribe; // 0x0
	public const byte Unsubscribe; // 0x0
	public const byte Publish; // 0x0
	public const byte SendPrivate; // 0x0
	public const byte ChannelHistory; // 0x0
	public const byte UpdateStatus; // 0x0
	public const byte AddFriends; // 0x0
	public const byte RemoveFriends; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E32FD4 Offset: 0xDDBFD4 VA: 0x6CF5E32FD4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatParameterCode : Object
{
	// Fields

	public const byte Channels; // 0x0
	public const byte Channel; // 0x0
	public const byte Messages; // 0x0
	public const byte Message; // 0x0
	public const byte Senders; // 0x0
	public const byte Sender; // 0x0
	public const byte ChannelUserCount; // 0x0
	public const byte UserId; // 0x0
	public const byte MsgId; // 0x0
	public const byte MsgIds; // 0x0
	public const byte Secret; // 0x0
	public const byte SubscribeResults; // 0x0
	public const byte Status; // 0x0
	public const byte Friends; // 0x0
	public const byte SkipMessage; // 0x0
	public const byte HistoryLength; // 0x0
	public const byte WebFlags; // 0x0
	public const byte Properties; // 0x0
	public const byte ChannelSubscribers; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E32FDC Offset: 0xDDBFDC VA: 0x6CF5E32FDC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ChatPeer : PhotonPeer
{
	// Fields

	public const string NameServerHost; // 0x0
	public const string NameServerHttp; // 0x0
	private static readonly Dictionary`2 ProtocolToNameServerPort; // 0x0

	// Properties

	public string NameServerAddress { get; }
	internal virtual bool IsProtocolSecure { get; }

	// Methods

	// RVA: 0x6CF5E2E0A8 Offset: 0xDD70A8 VA: 0x6CF5E2E0A8
	public string get_NameServerAddress() { }

	// RVA: 0x6CF5E33198 Offset: 0xDDC198 VA: 0x6CF5E33198
	internal virtual bool get_IsProtocolSecure() { }

	// RVA: 0x6CF5E2DE88 Offset: 0xDD6E88 VA: 0x6CF5E2DE88
	public void .ctor(IPhotonPeerListener listener, ConnectionProtocol protocol) { }

	// RVA: 0x6CF5E331B8 Offset: 0xDDC1B8 VA: 0x6CF5E331B8
	private void ConfigUnitySockets() { }

	// RVA: 0x6CF5E32FE4 Offset: 0xDDBFE4 VA: 0x6CF5E32FE4
	private string GetNameServerAddress() { }

	// RVA: 0x6CF5E2E0AC Offset: 0xDD70AC VA: 0x6CF5E2E0AC
	public bool Connect() { }

	// RVA: 0x6CF5E322D8 Offset: 0xDDB2D8 VA: 0x6CF5E322D8
	public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues) { }

	// RVA: 0x6CF5E33388 Offset: 0xDDC388 VA: 0x6CF5E33388
	private static void .cctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public enum CustomAuthenticationType
{
	// Fields

	public byte value__; // 0x10
	public const CustomAuthenticationType Custom = 0; // 0x0
	public const CustomAuthenticationType Steam = 1; // 0x0
	public const CustomAuthenticationType Facebook = 2; // 0x0
	public const CustomAuthenticationType Oculus = 3; // 0x0
	public const CustomAuthenticationType PlayStation = 4; // 0x0
	public const CustomAuthenticationType Xbox = 5; // 0x0
	public const CustomAuthenticationType Viveport = 10; // 0x0
	public const CustomAuthenticationType None = 255; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class AuthenticationValues : Object
{
	// Fields

	private CustomAuthenticationType authType; // 0x10
	private string <AuthGetParameters>k__BackingField; // 0x18
	private object <AuthPostData>k__BackingField; // 0x20
	private string <Token>k__BackingField; // 0x28
	private string <UserId>k__BackingField; // 0x30

	// Properties

	public CustomAuthenticationType AuthType { get; set; }
	public string AuthGetParameters { get; set; }
	public object AuthPostData { get; set; }
	public string Token { get; set; }
	public string UserId { get; set; }

	// Methods

	// RVA: 0x6CF5E33478 Offset: 0xDDC478 VA: 0x6CF5E33478
	public CustomAuthenticationType get_AuthType() { }

	// RVA: 0x6CF5E33480 Offset: 0xDDC480 VA: 0x6CF5E33480
	public void set_AuthType(CustomAuthenticationType value) { }

	// RVA: 0x6CF5E33488 Offset: 0xDDC488 VA: 0x6CF5E33488
	public string get_AuthGetParameters() { }

	// RVA: 0x6CF5E33490 Offset: 0xDDC490 VA: 0x6CF5E33490
	public void set_AuthGetParameters(string value) { }

	// RVA: 0x6CF5E33498 Offset: 0xDDC498 VA: 0x6CF5E33498
	public object get_AuthPostData() { }

	// RVA: 0x6CF5E334A0 Offset: 0xDDC4A0 VA: 0x6CF5E334A0
	private void set_AuthPostData(object value) { }

	// RVA: 0x6CF5E334A8 Offset: 0xDDC4A8 VA: 0x6CF5E334A8
	public string get_Token() { }

	// RVA: 0x6CF5E334B0 Offset: 0xDDC4B0 VA: 0x6CF5E334B0
	public void set_Token(string value) { }

	// RVA: 0x6CF5E334B8 Offset: 0xDDC4B8 VA: 0x6CF5E334B8
	public string get_UserId() { }

	// RVA: 0x6CF5E334C0 Offset: 0xDDC4C0 VA: 0x6CF5E334C0
	public void set_UserId(string value) { }

	// RVA: 0x6CF5E2DB38 Offset: 0xDD6B38 VA: 0x6CF5E2DB38
	public void .ctor() { }

	// RVA: 0x6CF5E334C8 Offset: 0xDDC4C8 VA: 0x6CF5E334C8
	public void .ctor(string userId) { }

	// RVA: 0x6CF5E334F8 Offset: 0xDDC4F8 VA: 0x6CF5E334F8
	public virtual void SetAuthPostData(string stringData) { }

	// RVA: 0x6CF5E33534 Offset: 0xDDC534 VA: 0x6CF5E33534
	public virtual void SetAuthPostData(Byte[] byteData) { }

	// RVA: 0x6CF5E3353C Offset: 0xDDC53C VA: 0x6CF5E3353C
	public virtual void AddAuthParameter(string key, string value) { }

	// RVA: 0x6CF5E33710 Offset: 0xDDC710 VA: 0x6CF5E33710
	public override string ToString() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ParameterCode : Object
{
	// Fields

	public const byte ApplicationId; // 0x0
	public const byte Secret; // 0x0
	public const byte AppVersion; // 0x0
	public const byte ClientAuthenticationType; // 0x0
	public const byte ClientAuthenticationParams; // 0x0
	public const byte ClientAuthenticationData; // 0x0
	public const byte Region; // 0x0
	public const byte Address; // 0x0
	public const byte UserId; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E337A8 Offset: 0xDDC7A8 VA: 0x6CF5E337A8
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public class ErrorCode : Object
{
	// Fields

	public const int Ok; // 0x0
	public const int OperationNotAllowedInCurrentState; // 0x0
	public const int InvalidOperationCode; // 0x0
	public const int InternalServerError; // 0x0
	public const int InvalidAuthentication; // 0x0
	public const int GameIdAlreadyExists; // 0x0
	public const int GameFull; // 0x0
	public const int GameClosed; // 0x0
	public const int ServerFull; // 0x0
	public const int UserBlocked; // 0x0
	public const int NoRandomMatchFound; // 0x0
	public const int GameDoesNotExist; // 0x0
	public const int MaxCcuReached; // 0x0
	public const int InvalidRegion; // 0x0
	public const int CustomAuthenticationFailed; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E337B0 Offset: 0xDDC7B0 VA: 0x6CF5E337B0
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public enum ChatState
{
	// Fields

	public int value__; // 0x10
	public const ChatState Uninitialized = 0; // 0x0
	public const ChatState ConnectingToNameServer = 1; // 0x0
	public const ChatState ConnectedToNameServer = 2; // 0x0
	public const ChatState Authenticating = 3; // 0x0
	public const ChatState Authenticated = 4; // 0x0
	public const ChatState DisconnectingFromNameServer = 5; // 0x0
	public const ChatState ConnectingToFrontEnd = 6; // 0x0
	public const ChatState ConnectedToFrontEnd = 7; // 0x0
	public const ChatState DisconnectingFromFrontEnd = 8; // 0x0
	public const ChatState QueuedComingFromFrontEnd = 9; // 0x0
	public const ChatState Disconnecting = 10; // 0x0
	public const ChatState Disconnected = 11; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public static class ChatUserStatus : Object
{
	// Fields

	public const int Offline; // 0x0
	public const int Invisible; // 0x0
	public const int Online; // 0x0
	public const int Away; // 0x0
	public const int DND; // 0x0
	public const int LFG; // 0x0
	public const int Playing; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Chat
public interface IChatClientListener
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void DebugReturn(DebugLevel level, string message) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnDisconnected() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void OnConnected() { }

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void OnChatStateChange(ChatState state) { }

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public abstract void OnGetMessages(string channelName, String[] senders, Object[] messages) { }

	// RVA: 0x6CF5BD773C Offset: 0xB8073C VA: 0x6CF5BD773C
	public abstract void OnPrivateMessage(string sender, object message, string channelName) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public abstract void OnSubscribed(String[] channels, Boolean[] results) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public abstract void OnUnsubscribed(String[] channels) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public abstract void OnStatusUpdate(string user, int status, bool gotMessage, object message) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public abstract void OnUserSubscribed(string channel, string user) { }

	// RVA: 0x6CF5BD766C Offset: 0xB8066C VA: 0x6CF5BD766C
	public abstract void OnUserUnsubscribed(string channel, string user) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Realtime
public abstract class PhotonPing : Object, IDisposable
{
	// Fields

	public string DebugString; // 0x10
	public bool Successful; // 0x18
	protected internal bool GotResult; // 0x19
	protected internal int PingLength; // 0x1C
	protected internal Byte[] PingBytes; // 0x20
	protected internal byte PingId; // 0x28

	// Properties


	// Methods

	// RVA: 0x6CF5E337B8 Offset: 0xDDC7B8 VA: 0x6CF5E337B8
	public virtual bool StartPing(string ip) { }

	// RVA: 0x6CF5E337F0 Offset: 0xDDC7F0 VA: 0x6CF5E337F0
	public virtual bool Done() { }

	// RVA: 0x6CF5E33828 Offset: 0xDDC828 VA: 0x6CF5E33828
	public virtual void Dispose() { }

	// RVA: 0x6CF5E33860 Offset: 0xDDC860 VA: 0x6CF5E33860
	protected internal void Init() { }

	// RVA: 0x6CF5E338A0 Offset: 0xDDC8A0 VA: 0x6CF5E338A0
	protected void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: Photon.Realtime
public class PingMono : PhotonPing
{
	// Fields

	private Socket sock; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF5E33948 Offset: 0xDDC948 VA: 0x6CF5E33948
	public override bool StartPing(string ip) { }

	// RVA: 0x6CF5E33BA0 Offset: 0xDDCBA0 VA: 0x6CF5E33BA0
	public override bool Done() { }

	// RVA: 0x6CF5E33CC0 Offset: 0xDDCCC0 VA: 0x6CF5E33CC0
	public override void Dispose() { }

	// RVA: 0x6CF5E33D60 Offset: 0xDDCD60 VA: 0x6CF5E33D60
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class RoomIndexingChanged : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E34D34 Offset: 0xDDDD34 VA: 0x6CF5E34D34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5E34DBC Offset: 0xDDDDBC VA: 0x6CF5E34DBC
	public virtual void Invoke() { }

	// RVA: 0x6CF5E34DD0 Offset: 0xDDDDD0 VA: 0x6CF5E34DD0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x6CF5E34DF0 Offset: 0xDDDDF0 VA: 0x6CF5E34DF0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.UtilityScripts
public class PlayerRoomIndexing : PunBehaviour
{
	// Fields

	public static PlayerRoomIndexing instance; // 0x0
	public RoomIndexingChanged OnRoomIndexingChanged; // 0x28
	public const string RoomPlayerIndexedProp; // 0x0
	private Int32[] _playerIds; // 0x30
	private object _indexes; // 0x38
	private Dictionary`2 _indexesLUT; // 0x40
	private List`1 _indexesPool; // 0x48
	private PhotonPlayer _p; // 0x50

	// Properties

	public Int32[] PlayerIds { get; }

	// Methods

	// RVA: 0x6CF5E33D64 Offset: 0xDDCD64 VA: 0x6CF5E33D64
	public Int32[] get_PlayerIds() { }

	// RVA: 0x6CF5E33D6C Offset: 0xDDCD6C VA: 0x6CF5E33D6C
	public void Awake() { }

	// RVA: 0x6CF5E340DC Offset: 0xDDD0DC VA: 0x6CF5E340DC
	public override void OnJoinedRoom() { }

	// RVA: 0x6CF5E348D4 Offset: 0xDDD8D4 VA: 0x6CF5E348D4
	public override void OnLeftRoom() { }

	// RVA: 0x6CF5E348D8 Offset: 0xDDD8D8 VA: 0x6CF5E348D8
	public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer) { }

	// RVA: 0x6CF5E34958 Offset: 0xDDD958 VA: 0x6CF5E34958
	public override void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer) { }

	// RVA: 0x6CF5E34BA0 Offset: 0xDDDBA0 VA: 0x6CF5E34BA0
	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged) { }

	// RVA: 0x6CF5E34C24 Offset: 0xDDDC24 VA: 0x6CF5E34C24
	public override void OnMasterClientSwitched(PhotonPlayer newMasterClient) { }

	// RVA: 0x6CF5E34C94 Offset: 0xDDDC94 VA: 0x6CF5E34C94
	public int GetRoomIndex(PhotonPlayer player) { }

	// RVA: 0x6CF5E33E90 Offset: 0xDDCE90 VA: 0x6CF5E33E90
	private void SanitizeIndexing(bool forceIndexing) { }

	// RVA: 0x6CF5E345B8 Offset: 0xDDD5B8 VA: 0x6CF5E345B8
	private void RefreshData() { }

	// RVA: 0x6CF5E34168 Offset: 0xDDD168 VA: 0x6CF5E34168
	private void AssignIndex(PhotonPlayer player) { }

	// RVA: 0x6CF5E349D8 Offset: 0xDDD9D8 VA: 0x6CF5E349D8
	private void UnAssignIndex(PhotonPlayer player) { }

	// RVA: 0x6CF5E34D2C Offset: 0xDDDD2C VA: 0x6CF5E34D2C
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.UtilityScripts
public static class PlayerRoomIndexingExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E34DFC Offset: 0xDDDDFC VA: 0x6CF5E34DFC
	public static int GetRoomIndex(PhotonPlayer player) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.UtilityScripts
public class ButtonInsideScrollList : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Fields

	private ScrollRect scrollRect; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E34EFC Offset: 0xDDDEFC VA: 0x6CF5E34EFC
	private void Start() { }

	// RVA: 0x6CF5E34F4C Offset: 0xDDDF4C VA: 0x6CF5E34F4C
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x6CF5E34FEC Offset: 0xDDDFEC VA: 0x6CF5E34FEC
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x6CF5E35088 Offset: 0xDDE088 VA: 0x6CF5E35088
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.UtilityScripts
public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Fields

	private Text _text; // 0x20
	public Color NormalColor; // 0x28
	public Color HoverColor; // 0x38

	// Properties


	// Methods

	// RVA: 0x6CF5E35090 Offset: 0xDDE090 VA: 0x6CF5E35090
	public void Awake() { }

	// RVA: 0x6CF5E350E0 Offset: 0xDDE0E0 VA: 0x6CF5E350E0
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6CF5E35110 Offset: 0xDDE110 VA: 0x6CF5E35110
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6CF5E35140 Offset: 0xDDE140 VA: 0x6CF5E35140
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.UtilityScripts
public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Fields

	public Toggle toggle; // 0x20
	private Text _text; // 0x28
	public Color NormalOnColor; // 0x30
	public Color NormalOffColor; // 0x40
	public Color HoverOnColor; // 0x50
	public Color HoverOffColor; // 0x60
	private bool isHover; // 0x70

	// Properties


	// Methods

	// RVA: 0x6CF5E3515C Offset: 0xDDE15C VA: 0x6CF5E3515C
	public void OnEnable() { }

	// RVA: 0x6CF5E35224 Offset: 0xDDE224 VA: 0x6CF5E35224
	public void OnDisable() { }

	// RVA: 0x6CF5E352C8 Offset: 0xDDE2C8 VA: 0x6CF5E352C8
	public void OnValueChanged(bool isOn) { }

	// RVA: 0x6CF5E3535C Offset: 0xDDE35C VA: 0x6CF5E3535C
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x6CF5E353D0 Offset: 0xDDE3D0 VA: 0x6CF5E353D0
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x6CF5E35440 Offset: 0xDDE440 VA: 0x6CF5E35440
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.Client.DemoParticle
public class TimeKeeper : Object
{
	// Fields

	private int lastExecutionTime; // 0x10
	private bool shouldExecute; // 0x14
	private int <Interval>k__BackingField; // 0x18
	private bool <IsEnabled>k__BackingField; // 0x1C

	// Properties

	public int Interval { get; set; }
	public bool IsEnabled { get; set; }
	public bool ShouldExecute { get; set; }

	// Methods

	// RVA: 0x6CF5E3545C Offset: 0xDDE45C VA: 0x6CF5E3545C
	public int get_Interval() { }

	// RVA: 0x6CF5E35464 Offset: 0xDDE464 VA: 0x6CF5E35464
	public void set_Interval(int value) { }

	// RVA: 0x6CF5E3546C Offset: 0xDDE46C VA: 0x6CF5E3546C
	public bool get_IsEnabled() { }

	// RVA: 0x6CF5E35474 Offset: 0xDDE474 VA: 0x6CF5E35474
	public void set_IsEnabled(bool value) { }

	// RVA: 0x6CF5E35480 Offset: 0xDDE480 VA: 0x6CF5E35480
	public bool get_ShouldExecute() { }

	// RVA: 0x6CF5E354CC Offset: 0xDDE4CC VA: 0x6CF5E354CC
	public void set_ShouldExecute(bool value) { }

	// RVA: 0x6CF5E354D8 Offset: 0xDDE4D8 VA: 0x6CF5E354D8
	public void .ctor(int interval) { }

	// RVA: 0x6CF5E35518 Offset: 0xDDE518 VA: 0x6CF5E35518
	public void Reset() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.Client.GUI
public enum GizmoType
{
	// Fields

	public int value__; // 0x10
	public const GizmoType WireSphere = 0; // 0x0
	public const GizmoType Sphere = 1; // 0x0
	public const GizmoType WireCube = 2; // 0x0
	public const GizmoType Cube = 3; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: ExitGames.Client.GUI
public class GizmoTypeDrawer : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E35538 Offset: 0xDDE538 VA: 0x6CF5E35538
	public static void Draw(Vector3 center, GizmoType type, Color color, float size) { }

	// RVA: 0x6CF5E356BC Offset: 0xDDE6BC VA: 0x6CF5E356BC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class OnClaimPrize : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E36100 Offset: 0xDDF100 VA: 0x6CF5E36100
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5E3618C Offset: 0xDDF18C VA: 0x6CF5E3618C
	public virtual void Invoke(int day) { }

	// RVA: 0x6CF5E361A0 Offset: 0xDDF1A0 VA: 0x6CF5E361A0
	public virtual IAsyncResult BeginInvoke(int day, AsyncCallback callback, object object) { }

	// RVA: 0x6CF5E36224 Offset: 0xDDF224 VA: 0x6CF5E36224
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <InitializeTimer>d__14 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DailyRewards <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E35988 Offset: 0xDDE988 VA: 0x6CF5E35988
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E36230 Offset: 0xDDF230 VA: 0x6CF5E36230
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E36234 Offset: 0xDDF234 VA: 0x6CF5E36234
	private bool MoveNext() { }

	// RVA: 0x6CF5E363B4 Offset: 0xDDF3B4 VA: 0x6CF5E363B4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E363BC Offset: 0xDDF3BC VA: 0x6CF5E363BC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E363F4 Offset: 0xDDF3F4 VA: 0x6CF5E363F4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class DailyRewards : DailyRewardsCore`1
{
	// Fields

	public List`1 rewards; // 0x70
	public DateTime lastRewardTime; // 0x78
	public int availableReward; // 0x80
	public int lastReward; // 0x84
	public bool keepOpen; // 0x88
	private ObscuredBool cheat; // 0x8C
	public static OnClaimPrize onClaimPrize; // 0x0
	private const string LAST_REWARD_TIME; // 0x0
	private const string LAST_REWARD; // 0x0
	private const string FMT; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E356C4 Offset: 0xDDE6C4 VA: 0x6CF5E356C4
	private void Start() { }

	// RVA: 0x6CF5E3581C Offset: 0xDDE81C VA: 0x6CF5E3581C
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E35880 Offset: 0xDDE880 VA: 0x6CF5E35880
	private void Update() { }

	// RVA: 0x6CF5E357BC Offset: 0xDDE7BC VA: 0x6CF5E357BC
	private IEnumerator InitializeTimer() { }

	// RVA: 0x6CF5E359B0 Offset: 0xDDE9B0 VA: 0x6CF5E359B0
	public void CheckRewards() { }

	// RVA: 0x6CF5E35D34 Offset: 0xDDED34 VA: 0x6CF5E35D34
	public void ClaimPrize() { }

	// RVA: 0x6CF5E35F98 Offset: 0xDDEF98 VA: 0x6CF5E35F98
	public Reward GetReward(int day) { }

	// RVA: 0x6CF5E35FF0 Offset: 0xDDEFF0 VA: 0x6CF5E35FF0
	public void Reset() { }

	// RVA: 0x6CF5E36078 Offset: 0xDDF078 VA: 0x6CF5E36078
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class OnInitialize : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public virtual void Invoke(bool error, string errorMessage) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public virtual IAsyncResult BeginInvoke(bool error, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <InitializeDate>d__13 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public DailyRewardsCore`1 <>4__this; // 0x0
	private WWW <www>5__2; // 0x0

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	private bool MoveNext() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public abstract class DailyRewardsCore`1 : MonoBehaviour
{
	// Fields

	public bool isSingleton; // 0x0
	public string worldClockUrl; // 0x0
	public string worldClockFMT; // 0x0
	public bool useWorldClockApi; // 0x0
	public WorldClock worldClock; // 0x0
	public string errorMessage; // 0x0
	public bool isErrorConnect; // 0x0
	public DateTime now; // 0x0
	public int maxRetries; // 0x0
	private int connectrionRetries; // 0x0
	public static OnInitialize onInitialize; // 0x0
	public bool isInitialized; // 0x0
	private static T _instance; // 0x0

	// Properties

	public static T instance { get; }

	// Methods

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public IEnumerator InitializeDate() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T get_instance() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected virtual void Awake() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	protected void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class DailyRewardsInterface : MonoBehaviour
{
	// Fields

	public Canvas canvas; // 0x20
	public GameObject dailyRewardPrefab; // 0x28
	public GameObject panelDebug; // 0x30
	public bool isDebug; // 0x38
	public GameObject panelReward; // 0x40
	public Text textReward; // 0x48
	public Button buttonCloseReward; // 0x50
	public GameObject buttonClaimGo; // 0x58
	public GameObject buttonCloseGo; // 0x60
	public Button buttonClaim; // 0x68
	public Button buttonClose; // 0x70
	public Text textTimeDue; // 0x78
	public GridLayoutGroup dailyRewardsGroup; // 0x80
	public ScrollRect scrollRect; // 0x88
	public Image imageReward; // 0x90
	private bool readyToClaim; // 0x98
	private List`1 dailyRewardsUI; // 0xA0

	// Properties


	// Methods

	// RVA: 0x6CF5E363FC Offset: 0xDDF3FC VA: 0x6CF5E363FC
	private void Awake() { }

	// RVA: 0x6CF5E36428 Offset: 0xDDF428 VA: 0x6CF5E36428
	private void Start() { }

	// RVA: 0x6CF5E367C8 Offset: 0xDDF7C8 VA: 0x6CF5E367C8
	private void OnEnable() { }

	// RVA: 0x6CF5E36970 Offset: 0xDDF970 VA: 0x6CF5E36970
	private void OnDisable() { }

	// RVA: 0x6CF5E36590 Offset: 0xDDF590 VA: 0x6CF5E36590
	private void InitializeDailyRewardsUI() { }

	// RVA: 0x6CF5E36C64 Offset: 0xDDFC64 VA: 0x6CF5E36C64
	public void UpdateUI() { }

	// RVA: 0x6CF5E36F28 Offset: 0xDDFF28 VA: 0x6CF5E36F28
	public void SnapToReward() { }

	// RVA: 0x6CF5E37038 Offset: 0xDE0038 VA: 0x6CF5E37038
	private void Update() { }

	// RVA: 0x6CF5E3727C Offset: 0xDE027C VA: 0x6CF5E3727C
	private void OnClaimPrize(int day) { }

	// RVA: 0x6CF5E373E0 Offset: 0xDE03E0 VA: 0x6CF5E373E0
	private void OnInitialize(bool error, string errorMessage) { }

	// RVA: 0x6CF5E37498 Offset: 0xDE0498 VA: 0x6CF5E37498
	public void OnResetClick() { }

	// RVA: 0x6CF5E3753C Offset: 0xDE053C VA: 0x6CF5E3753C
	public void OnAdvanceDayClick() { }

	// RVA: 0x6CF5E375E4 Offset: 0xDE05E4 VA: 0x6CF5E375E4
	public void OnAdvanceHourClick() { }

	// RVA: 0x6CF5E3768C Offset: 0xDE068C VA: 0x6CF5E3768C
	public void .ctor() { }

	// RVA: 0x6CF5E37708 Offset: 0xDE0708 VA: 0x6CF5E37708
	private void <Start>b__18_0() { }

	// RVA: 0x6CF5E37764 Offset: 0xDE0764 VA: 0x6CF5E37764
	private void <Start>b__18_1() { }

	// RVA: 0x6CF5E377F0 Offset: 0xDE07F0 VA: 0x6CF5E377F0
	private void <Start>b__18_2() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public enum DailyRewardState
{
	// Fields

	public int value__; // 0x10
	public const DailyRewardState UNCLAIMED_AVAILABLE = 0; // 0x0
	public const DailyRewardState UNCLAIMED_UNAVAILABLE = 1; // 0x0
	public const DailyRewardState CLAIMED = 2; // 0x0

	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class DailyRewardUI : MonoBehaviour
{
	// Fields

	public bool showRewardName; // 0x20
	public Text textDay; // 0x28
	public Text textReward; // 0x30
	public Image imageRewardBackground; // 0x38
	public Image imageReward; // 0x40
	public Color colorClaim; // 0x48
	private Color colorUnclaimed; // 0x58
	public int day; // 0x68
	public Reward reward; // 0x70
	public DailyRewardState state; // 0x78

	// Properties


	// Methods

	// RVA: 0x6CF5E3781C Offset: 0xDE081C VA: 0x6CF5E3781C
	private void Awake() { }

	// RVA: 0x6CF5E36B18 Offset: 0xDDFB18 VA: 0x6CF5E36B18
	public void Initialize() { }

	// RVA: 0x6CF5E36EC0 Offset: 0xDDFEC0 VA: 0x6CF5E36EC0
	public void Refresh() { }

	// RVA: 0x6CF5E37850 Offset: 0xDE0850 VA: 0x6CF5E37850
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
[Serializable]
public class Reward : Object
{
	// Fields

	public string unit; // 0x10
	public int reward; // 0x18
	public Sprite sprite; // 0x20

	// Properties


	// Methods

	// RVA: 0x6CF5E37858 Offset: 0xDE0858 VA: 0x6CF5E37858
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class OnCanClaim : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E38034 Offset: 0xDE1034 VA: 0x6CF5E38034
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5E380BC Offset: 0xDE10BC VA: 0x6CF5E380BC
	public virtual void Invoke() { }

	// RVA: 0x6CF5E380D0 Offset: 0xDE10D0 VA: 0x6CF5E380D0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x6CF5E380F0 Offset: 0xDE10F0 VA: 0x6CF5E380F0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
public sealed class OnClaimPrize : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5E380FC Offset: 0xDE10FC VA: 0x6CF5E380FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF5E38188 Offset: 0xDE1188 VA: 0x6CF5E38188
	public virtual void Invoke(int index) { }

	// RVA: 0x6CF5E3819C Offset: 0xDE119C VA: 0x6CF5E3819C
	public virtual IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

	// RVA: 0x6CF5E38220 Offset: 0xDE1220 VA: 0x6CF5E38220
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <InitializeTimer>d__14 : Object, IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TimedRewards <>4__this; // 0x20

	// Properties

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5E37A1C Offset: 0xDE0A1C VA: 0x6CF5E37A1C
	public void .ctor(int <>1__state) { }

	// RVA: 0x6CF5E3822C Offset: 0xDE122C VA: 0x6CF5E3822C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6CF5E38230 Offset: 0xDE1230 VA: 0x6CF5E38230
	private bool MoveNext() { }

	// RVA: 0x6CF5E384C8 Offset: 0xDE14C8 VA: 0x6CF5E384C8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x6CF5E384D0 Offset: 0xDE14D0 VA: 0x6CF5E384D0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x6CF5E38508 Offset: 0xDE1508 VA: 0x6CF5E38508
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class TimedRewards : DailyRewardsCore`1
{
	// Fields

	public DateTime lastRewardTime; // 0x70
	public TimeSpan timer; // 0x78
	public float maxTime; // 0x80
	public List`1 rewards; // 0x88
	private ObscuredBool cheat; // 0x90
	public static OnCanClaim onCanClaim; // 0x0
	public static OnClaimPrize onClaimPrize; // 0x8
	private bool canClaim; // 0x9C
	private const string TIMED_REWARDS_TIME; // 0x0
	private const string FMT; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5E37860 Offset: 0xDE0860 VA: 0x6CF5E37860
	private void Start() { }

	// RVA: 0x6CF5E379B8 Offset: 0xDE09B8 VA: 0x6CF5E379B8
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E37958 Offset: 0xDE0958 VA: 0x6CF5E37958
	private IEnumerator InitializeTimer() { }

	// RVA: 0x6CF5E37A44 Offset: 0xDE0A44 VA: 0x6CF5E37A44
	private void Update() { }

	// RVA: 0x6CF5E37CC4 Offset: 0xDE0CC4 VA: 0x6CF5E37CC4
	public void ClaimReward(int rewardIdx) { }

	// RVA: 0x6CF5E37E6C Offset: 0xDE0E6C VA: 0x6CF5E37E6C
	public void Reset() { }

	// RVA: 0x6CF5E37F54 Offset: 0xDE0F54 VA: 0x6CF5E37F54
	public Reward GetReward(int index) { }

	// RVA: 0x6CF5E37FAC Offset: 0xDE0FAC VA: 0x6CF5E37FAC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private sealed class <>c__DisplayClass22_0 : Object
{
	// Fields

	public TimedRewardsInterface <>4__this; // 0x10
	public int index; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF5E393C0 Offset: 0xDE23C0 VA: 0x6CF5E393C0
	public void .ctor() { }

	// RVA: 0x6CF5E3A4B0 Offset: 0xDE34B0 VA: 0x6CF5E3A4B0
	internal void <OnClickReward>b__0() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class TimedRewardsInterface : MonoBehaviour
{
	// Fields

	public GameObject canvas; // 0x20
	public GameObject canvas2; // 0x28
	public ReklamTamEkran reklamcagir1; // 0x30
	private ObscuredBool cheat; // 0x38
	public Button buttonClaim; // 0x48
	public Button GetSkin1; // 0x50
	public Button GetSkin2; // 0x58
	public Button GetSkin3; // 0x60
	public Button GetSkin4; // 0x68
	public Button GetSkin5; // 0x70
	public Button GetSkin6; // 0x78
	public Button GetSkin7; // 0x80
	public Text textInfo; // 0x88
	public GameObject rewardPrefab; // 0x90
	private List`1 rewardsUI; // 0x98

	// Properties


	// Methods

	// RVA: 0x6CF5E38510 Offset: 0xDE1510 VA: 0x6CF5E38510
	private void Awake() { }

	// RVA: 0x6CF5E38660 Offset: 0xDE1660 VA: 0x6CF5E38660
	private void OnCheatingDetected() { }

	// RVA: 0x6CF5E386C4 Offset: 0xDE16C4 VA: 0x6CF5E386C4
	private void Start() { }

	// RVA: 0x6CF5E38D20 Offset: 0xDE1D20 VA: 0x6CF5E38D20
	private void OnEnable() { }

	// RVA: 0x6CF5E38EC8 Offset: 0xDE1EC8 VA: 0x6CF5E38EC8
	private void OnDisable() { }

	// RVA: 0x6CF5E39070 Offset: 0xDE2070 VA: 0x6CF5E39070
	private void Update() { }

	// RVA: 0x6CF5E38AD0 Offset: 0xDE1AD0 VA: 0x6CF5E38AD0
	private void InitializeAvailableRewardsUI() { }

	// RVA: 0x6CF5E39258 Offset: 0xDE2258 VA: 0x6CF5E39258
	private UnityAction OnClickReward(int index) { }

	// RVA: 0x6CF5E393C8 Offset: 0xDE23C8 VA: 0x6CF5E393C8
	public void OnResetClick() { }

	// RVA: 0x6CF5E3942C Offset: 0xDE242C VA: 0x6CF5E3942C
	private void ClaimReward(int index) { }

	// RVA: 0x6CF5E3949C Offset: 0xDE249C VA: 0x6CF5E3949C
	private void OnCanClaim() { }

	// RVA: 0x6CF5E39598 Offset: 0xDE2598 VA: 0x6CF5E39598
	private void OnInitialize(bool error, string errorMessage) { }

	// RVA: 0x6CF5E395F4 Offset: 0xDE25F4 VA: 0x6CF5E395F4
	public void .ctor() { }

	// RVA: 0x6CF5E396A0 Offset: 0xDE26A0 VA: 0x6CF5E396A0
	private void <Start>b__17_0() { }

	// RVA: 0x6CF5E3982C Offset: 0xDE282C VA: 0x6CF5E3982C
	private void <Start>b__17_1() { }

	// RVA: 0x6CF5E39A00 Offset: 0xDE2A00 VA: 0x6CF5E39A00
	private void <Start>b__17_2() { }

	// RVA: 0x6CF5E39BD4 Offset: 0xDE2BD4 VA: 0x6CF5E39BD4
	private void <Start>b__17_3() { }

	// RVA: 0x6CF5E39DA8 Offset: 0xDE2DA8 VA: 0x6CF5E39DA8
	private void <Start>b__17_4() { }

	// RVA: 0x6CF5E39F34 Offset: 0xDE2F34 VA: 0x6CF5E39F34
	private void <Start>b__17_5() { }

	// RVA: 0x6CF5E3A108 Offset: 0xDE3108 VA: 0x6CF5E3A108
	private void <Start>b__17_6() { }

	// RVA: 0x6CF5E3A2DC Offset: 0xDE32DC VA: 0x6CF5E3A2DC
	private void <Start>b__17_7() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
public class TimedRewardUI : MonoBehaviour
{
	// Fields

	public Text textReward; // 0x20
	public Text textUnit; // 0x28
	public Image imageReward; // 0x30
	public Button button; // 0x38
	public int index; // 0x40
	public Reward reward; // 0x48

	// Properties


	// Methods

	// RVA: 0x6CF5E39310 Offset: 0xDE2310 VA: 0x6CF5E39310
	public void Initialize() { }

	// RVA: 0x6CF5E3A4CC Offset: 0xDE34CC VA: 0x6CF5E3A4CC
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: NiobiumStudios
[Serializable]
public class WorldClock : Object
{
	// Fields

	public string currentDateTime; // 0x10
	public string utcOffset; // 0x18
	public string dayOfTheWeek; // 0x20
	public string timeZoneName; // 0x28
	public long currentFileTime; // 0x30
	public string ordinalDate; // 0x38
	public string serviceResponse; // 0x40

	// Properties


	// Methods

	// RVA: 0x6CF5E3A4D4 Offset: 0xDE34D4 VA: 0x6CF5E3A4D4
	public void .ctor() { }

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=12
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=13
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=16
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=32
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=48
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=68
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=4865
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
private struct __StaticArrayInitTypeSize=9763
{
	// Fields


	// Properties


	// Methods

}

// Dll : Assembly-CSharp.dll
// Namespace: 
internal sealed class <PrivateImplementationDetails> : Object
{
	// Fields

	internal static readonly __StaticArrayInitTypeSize=16 07DC3A0CCF491A1AB464EA18BE2D062B4DDDBC4E2370115ABEEF2136F3298FC5; // 0x0
	internal static readonly __StaticArrayInitTypeSize=32 0CA47679A8B48490B35902039B874DC32C465A4B547059C0D941091B7B72CB21; // 0x10
	internal static readonly __StaticArrayInitTypeSize=13 1995DEFE26C524A9CB3CF007B4A76A325342658A716A5F50C3B262D2F38DF919; // 0x30
	internal static readonly __StaticArrayInitTypeSize=48 3BB048C6BCFB13ADB4230B15FDE86F7FCFA341C302CC263DFC9250D7877BABFB; // 0x3D
	internal static readonly __StaticArrayInitTypeSize=9763 432BB6757129EA5E6A02D8E82FFC9CDBF3581535F60C654B0F3243D466F6A8E7; // 0x6D
	internal static readonly __StaticArrayInitTypeSize=4865 7BAAD6167AAFD6951B74C90CB22A2DEB5676D2F5457C9292E9F680DB291E2195; // 0x2690
	internal static readonly __StaticArrayInitTypeSize=16 7E8D5B72D290BA59F0EDBE3D6F961EEA1A534C250A6EF2CAC5B85C0C2111735F; // 0x3991
	internal static readonly __StaticArrayInitTypeSize=68 A190927ACFD6760570A4869AEBB00D9459E49F04EF5C8FDBC1A11B0FDFBF803F; // 0x39A1
	internal static readonly __StaticArrayInitTypeSize=32 B05EDD1766E8D631F85F3EC4828F160E156BB188B1960C9555289554B3091EA2; // 0x39E5
	internal static readonly __StaticArrayInitTypeSize=12 E1BB2DECAB167A9EA5F9D456E7B53673160863EC7EB462BD80C27EA48746837B; // 0x3A05

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal class <Module>
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6962484 Offset: 0x190B484 VA: 0x6CF6962484
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF696248C Offset: 0x190B48C VA: 0x6CF696248C
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngineInternal
public struct MathfInternal
{
	// Fields

	public static float FloatMinNormal; // 0x0
	public static float FloatMinDenormal; // 0x4
	public static bool IsFlushToZeroEnabled; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF6962494 Offset: 0x190B494 VA: 0x6CF6962494
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngineInternal
public enum TypeInferenceRules
{
	// Fields

	public int value__; // 0x10
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0; // 0x0
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1; // 0x0
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2; // 0x0
	public const TypeInferenceRules TypeOfFirstArgument = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngineInternal
[Serializable]
public class TypeInferenceRuleAttribute : Attribute
{
	// Fields

	private readonly string _rule; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF696252C Offset: 0x190B52C VA: 0x6CF696252C
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x6CF69625B0 Offset: 0x190B5B0 VA: 0x6CF69625B0
	public void .ctor(string rule) { }

	// RVA: 0x6CF69625D8 Offset: 0x190B5D8 VA: 0x6CF69625D8
	public override string ToString() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngineInternal
public class GenericStack : Stack
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69625E0 Offset: 0x190B5E0 VA: 0x6CF69625E0
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
public interface IJob
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public abstract void Execute() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal sealed class ExecuteJobFunction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal struct JobStruct`1
{
	// Fields

	internal static readonly SharedStatic`1 jobReflectionData; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	internal static void Initialize() { }

	// RVA: 0x6CF5BE17C0 Offset: 0xB8A7C0 VA: 0x6CF5BE17C0
	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
public static class IJobExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	public static void EarlyJobInit() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
public interface IJobParallelFor
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BD7380 Offset: 0xB80380 VA: 0x6CF5BD7380
	public abstract void Execute(int index) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class ExecuteJobFunction : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal struct ParallelForJobStruct`1
{
	// Fields

	internal static readonly SharedStatic`1 jobReflectionData; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	internal static void Initialize() { }

	// RVA: 0x6CF5BE17C0 Offset: 0xB8A7C0 VA: 0x6CF5BE17C0
	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
public static class IJobParallelForExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private static IntPtr GetReflectionData() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
public struct JobHandle : IEquatable`1
{
	// Fields

	internal ulong jobGroup; // 0x10
	internal int version; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69625E8 Offset: 0x190B5E8 VA: 0x6CF69625E8
	public void Complete() { }

	// RVA: 0x6CF6962674 Offset: 0x190B674 VA: 0x6CF6962674
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x6CF6962638 Offset: 0x190B638 VA: 0x6CF6962638
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	// RVA: 0x6CF696269C Offset: 0x190B69C VA: 0x6CF696269C
	public static JobHandle CombineDependencies(NativeArray`1 jobs) { }

	// RVA: 0x6CF6962758 Offset: 0x190B758 VA: 0x6CF6962758
	public static JobHandle CombineDependencies(NativeSlice`1 jobs) { }

	// RVA: 0x6CF69626FC Offset: 0x190B6FC VA: 0x6CF69626FC
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	// RVA: 0x6CF6962844 Offset: 0x190B844 VA: 0x6CF6962844
	public bool Equals(JobHandle other) { }

	// RVA: 0x6CF69627F0 Offset: 0x190B7F0 VA: 0x6CF69627F0
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, ref JobHandle ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute : Attribute
{
	// Fields

	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6962854 Offset: 0x190B854 VA: 0x6CF6962854
	public void .ctor(Type producerType) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges
{
	// Fields

	internal int BatchSize; // 0x10
	internal int NumJobs; // 0x14
	public int TotalIterationCount; // 0x18
	internal IntPtr StartEndIndex; // 0x20

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum ScheduleMode
{
	// Fields

	public int value__; // 0x10
	public const ScheduleMode Run = 0; // 0x0
	public const ScheduleMode Batched = 1; // 0x0
	public const ScheduleMode Parallel = 1; // 0x0
	public const ScheduleMode Single = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct JobScheduleParameters
{
	// Fields

	public JobHandle Dependency; // 0x10
	public int ScheduleMode; // 0x20
	public IntPtr ReflectionData; // 0x28
	public IntPtr JobDataPtr; // 0x30

	// Properties


	// Methods

	// RVA: 0x6CF6962AD0 Offset: 0x190BAD0 VA: 0x6CF6962AD0
	public void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal sealed class PanicFunction_ : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6962B08 Offset: 0x190BB08 VA: 0x6CF6962B08
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6962B90 Offset: 0x190BB90 VA: 0x6CF6962B90
	public virtual void Invoke() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility : Object
{
	// Fields

	internal static PanicFunction_ PanicFunction; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF696287C Offset: 0x190B87C VA: 0x6CF696287C
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex) { }

	// RVA: 0x6CF69628D8 Offset: 0x190B8D8 VA: 0x6CF69628D8
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	// RVA: 0x6CF69629A0 Offset: 0x190B9A0 VA: 0x6CF69629A0
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x6CF6962A0C Offset: 0x190BA0C VA: 0x6CF6962A0C
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x6CF6962A6C Offset: 0x190BA6C VA: 0x6CF6962A6C
	private static void InvokePanicFunction() { }

	// RVA: 0x6CF6962944 Offset: 0x190B944 VA: 0x6CF6962944
	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, ref JobHandle ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IL2CPP.CompilerServices
internal class Il2CppEagerStaticClassConstructionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6962BA4 Offset: 0x190BBA4 VA: 0x6CF6962BA4
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public sealed class IgnoredByDeepProfilerAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6962BAC Offset: 0x190BBAC VA: 0x6CF6962BAC
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public struct ProfilerCategory
{
	// Fields

	private readonly ushort m_CategoryId; // 0x10

	// Properties

	public string Name { get; }
	public static ProfilerCategory Scripts { get; }

	// Methods

	// RVA: 0x6CF6962BB4 Offset: 0x190BBB4 VA: 0x6CF6962BB4
	internal void .ctor(ushort category) { }

	// RVA: 0x6CF6962BBC Offset: 0x190BBBC VA: 0x6CF6962BBC
	public string get_Name() { }

	// RVA: 0x6CF6962DB8 Offset: 0x190BDB8 VA: 0x6CF6962DB8
	public override string ToString() { }

	// RVA: 0x6CF6962DBC Offset: 0x190BDBC VA: 0x6CF6962DBC
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x6CF6962DC4 Offset: 0x190BDC4 VA: 0x6CF6962DC4
	public static ushort op_Implicit(ProfilerCategory category) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public enum ProfilerCategoryColor
{
	// Fields

	public ushort value__; // 0x10
	public const ProfilerCategoryColor Render = 0; // 0x0
	public const ProfilerCategoryColor Scripts = 1; // 0x0
	public const ProfilerCategoryColor BurstJobs = 2; // 0x0
	public const ProfilerCategoryColor Other = 3; // 0x0
	public const ProfilerCategoryColor Physics = 4; // 0x0
	public const ProfilerCategoryColor Animation = 5; // 0x0
	public const ProfilerCategoryColor Audio = 6; // 0x0
	public const ProfilerCategoryColor AudioJob = 7; // 0x0
	public const ProfilerCategoryColor AudioUpdateJob = 8; // 0x0
	public const ProfilerCategoryColor Lighting = 9; // 0x0
	public const ProfilerCategoryColor GC = 10; // 0x0
	public const ProfilerCategoryColor VSync = 11; // 0x0
	public const ProfilerCategoryColor Memory = 12; // 0x0
	public const ProfilerCategoryColor Internal = 13; // 0x0
	public const ProfilerCategoryColor UI = 14; // 0x0
	public const ProfilerCategoryColor Build = 15; // 0x0
	public const ProfilerCategoryColor Input = 16; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct AutoScope : IDisposable
{
	// Fields

	internal readonly IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6962F30 Offset: 0x190BF30 VA: 0x6CF6962F30
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x6CF6962FCC Offset: 0x190BFCC VA: 0x6CF6962FCC
	public void Dispose() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public struct ProfilerMarker
{
	// Fields

	internal readonly IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6962DC8 Offset: 0x190BDC8 VA: 0x6CF6962DC8
	public void .ctor(string name) { }

	// RVA: 0x6CF6962E78 Offset: 0x190BE78 VA: 0x6CF6962E78
	public void .ctor(ProfilerCategory category, string name) { }

	// RVA: 0x6CF6962ED8 Offset: 0x190BED8 VA: 0x6CF6962ED8
	public AutoScope Auto() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public enum ProfilerCounterOptions
{
	// Fields

	public ushort value__; // 0x10
	public const ProfilerCounterOptions None = 0; // 0x0
	public const ProfilerCounterOptions FlushOnEndOfFrame = 2; // 0x0
	public const ProfilerCounterOptions ResetToZeroOnFlush = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling
public struct DebugScreenCapture
{
	// Fields

	private NativeArray`1 <RawImageDataReference>k__BackingField; // 0x10
	private TextureFormat <ImageFormat>k__BackingField; // 0x20
	private int <Width>k__BackingField; // 0x24
	private int <Height>k__BackingField; // 0x28

	// Properties

	public NativeArray`1 RawImageDataReference { set; }
	public TextureFormat ImageFormat { set; }
	public int Width { set; }
	public int Height { set; }

	// Methods

	// RVA: 0x6CF6963068 Offset: 0x190C068 VA: 0x6CF6963068
	public void set_RawImageDataReference(NativeArray`1 value) { }

	// RVA: 0x6CF6963070 Offset: 0x190C070 VA: 0x6CF6963070
	public void set_ImageFormat(TextureFormat value) { }

	// RVA: 0x6CF6963078 Offset: 0x190C078 VA: 0x6CF6963078
	public void set_Width(int value) { }

	// RVA: 0x6CF6963080 Offset: 0x190C080 VA: 0x6CF6963080
	public void set_Height(int value) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.LowLevel
public enum MarkerFlags
{
	// Fields

	public ushort value__; // 0x10
	public const MarkerFlags Default = 0; // 0x0
	public const MarkerFlags Script = 2; // 0x0
	public const MarkerFlags ScriptInvoke = 32; // 0x0
	public const MarkerFlags ScriptDeepProfiler = 64; // 0x0
	public const MarkerFlags AvailabilityEditor = 4; // 0x0
	public const MarkerFlags AvailabilityNonDevelopment = 8; // 0x0
	public const MarkerFlags Warning = 16; // 0x0
	public const MarkerFlags Counter = 128; // 0x0
	public const MarkerFlags SampleGPU = 256; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.LowLevel.Unsafe
public struct ProfilerCategoryDescription
{
	// Fields

	public readonly ushort Id; // 0x10
	public readonly ushort Flags; // 0x12
	public readonly Color32 Color; // 0x14
	private readonly int reserved0; // 0x18
	public readonly int NameUtf8Len; // 0x1C
	public readonly Byte* NameUtf8; // 0x20

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.LowLevel.Unsafe
public static class ProfilerUnsafeUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963088 Offset: 0x190C088 VA: 0x6CF6963088
	internal static ushort CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	// RVA: 0x6CF6962C3C Offset: 0x190BC3C VA: 0x6CF6962C3C
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	// RVA: 0x6CF6962E1C Offset: 0x190BE1C VA: 0x6CF6962E1C
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x6CF6963120 Offset: 0x190C120 VA: 0x6CF6963120
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x6CF696318C Offset: 0x190C18C VA: 0x6CF696318C
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, byte type, byte unit) { }

	// RVA: 0x6CF6962F90 Offset: 0x190BF90 VA: 0x6CF6962F90
	public static void BeginSample(IntPtr markerPtr) { }

	// RVA: 0x6CF696302C Offset: 0x190C02C VA: 0x6CF696302C
	public static void EndSample(IntPtr markerPtr) { }

	// RVA: 0x6CF6963200 Offset: 0x190C200 VA: 0x6CF6963200
	internal static Void* CreateCounterValue__Unmanaged(ref IntPtr counterPtr, Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x6CF6962CCC Offset: 0x190BCCC VA: 0x6CF6962CCC
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

	// RVA: 0x6CF69630DC Offset: 0x190C0DC VA: 0x6CF69630DC
	private static void GetCategoryDescription_Injected(ushort categoryId, ref ProfilerCategoryDescription ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata : Object
{
	// Fields

	private string <Description>k__BackingField; // 0x10
	private Byte[] <Data>k__BackingField; // 0x18

	// Properties

	public string Description { get; set; }
	internal Byte[] Data { get; }

	// Methods

	// RVA: 0x6CF696329C Offset: 0x190C29C VA: 0x6CF696329C
	public string get_Description() { }

	// RVA: 0x6CF69632A4 Offset: 0x190C2A4 VA: 0x6CF69632A4
	public void set_Description(string value) { }

	// RVA: 0x6CF69632AC Offset: 0x190C2AC VA: 0x6CF69632AC
	internal Byte[] get_Data() { }

	// RVA: 0x6CF69632B4 Offset: 0x190C2B4 VA: 0x6CF69632B4
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Profiling.Memory
public static class MemoryProfiler : Object
{
	// Fields

	private static Action`2 m_SnapshotFinished; // 0x0
	private static Action`3 m_SaveScreenshotToDisk; // 0x8
	private static Action`1 CreatingMetadata; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69632BC Offset: 0x190C2BC VA: 0x6CF69632BC
	private static Byte[] PrepareMetadata() { }

	// RVA: 0x6CF69634B8 Offset: 0x190C4B8 VA: 0x6CF69634B8
	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	// RVA: 0x6CF6963544 Offset: 0x190C544 VA: 0x6CF6963544
	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

	// RVA: 0x6CF6963634 Offset: 0x190C634 VA: 0x6CF6963634
	private static void FinalizeSnapshot(string path, bool result) { }

	// RVA: 0x6CF69636B8 Offset: 0x190C6B8 VA: 0x6CF69636B8
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileState
{
	// Fields

	public int value__; // 0x10
	public const FileState Absent = 0; // 0x0
	public const FileState Exists = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public enum AssetLoadingSubsystem
{
	// Fields

	public int value__; // 0x10
	public const AssetLoadingSubsystem Other = 0; // 0x0
	public const AssetLoadingSubsystem Texture = 1; // 0x0
	public const AssetLoadingSubsystem VirtualTexture = 2; // 0x0
	public const AssetLoadingSubsystem Mesh = 3; // 0x0
	public const AssetLoadingSubsystem Audio = 4; // 0x0
	public const AssetLoadingSubsystem Scripts = 5; // 0x0
	public const AssetLoadingSubsystem EntitiesScene = 6; // 0x0
	public const AssetLoadingSubsystem EntitiesStreamBinaryReader = 7; // 0x0
	public const AssetLoadingSubsystem FileInfo = 8; // 0x0
	public const AssetLoadingSubsystem ContentLoading = 9; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public enum Priority
{
	// Fields

	public int value__; // 0x10
	public const Priority PriorityLow = 0; // 0x0
	public const Priority PriorityHigh = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public enum ProcessingState
{
	// Fields

	public int value__; // 0x10
	public const ProcessingState Unknown = 0; // 0x0
	public const ProcessingState InQueue = 1; // 0x0
	public const ProcessingState Reading = 2; // 0x0
	public const ProcessingState Completed = 3; // 0x0
	public const ProcessingState Failed = 4; // 0x0
	public const ProcessingState Canceled = 5; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileReadType
{
	// Fields

	public int value__; // 0x10
	public const FileReadType Sync = 0; // 0x0
	public const FileReadType Async = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public struct AsyncReadManagerRequestMetric
{
	// Fields

	private readonly string <AssetName>k__BackingField; // 0x10
	private readonly string <FileName>k__BackingField; // 0x18
	private readonly ulong <OffsetBytes>k__BackingField; // 0x20
	private readonly ulong <SizeBytes>k__BackingField; // 0x28
	private readonly ulong <AssetTypeId>k__BackingField; // 0x30
	private readonly ulong <CurrentBytesRead>k__BackingField; // 0x38
	private readonly uint <BatchReadCount>k__BackingField; // 0x40
	private readonly bool <IsBatchRead>k__BackingField; // 0x44
	private readonly ProcessingState <State>k__BackingField; // 0x48
	private readonly FileReadType <ReadType>k__BackingField; // 0x4C
	private readonly Priority <PriorityLevel>k__BackingField; // 0x50
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x54
	private readonly double <RequestTimeMicroseconds>k__BackingField; // 0x58
	private readonly double <TimeInQueueMicroseconds>k__BackingField; // 0x60
	private readonly double <TotalTimeMicroseconds>k__BackingField; // 0x68

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
public class AsyncReadManagerMetricsFilters : Object
{
	// Fields

	internal UInt64[] TypeIDs; // 0x10
	internal ProcessingState[] States; // 0x18
	internal FileReadType[] ReadTypes; // 0x20
	internal Priority[] PriorityLevels; // 0x28
	internal AssetLoadingSubsystem[] Subsystems; // 0x30

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.Archive
public enum ArchiveStatus
{
	// Fields

	public int value__; // 0x10
	public const ArchiveStatus InProgress = 0; // 0x0
	public const ArchiveStatus Complete = 1; // 0x0
	public const ArchiveStatus Failed = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.Archive
public struct ArchiveFileInfo
{
	// Fields

	public string Filename; // 0x10
	public ulong FileSize; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.Archive
public struct ArchiveHandle
{
	// Fields

	internal ulong Handle; // 0x10

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.IO.Archive
public static class ArchiveFileInterface : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class ReadOnlyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class WriteOnlyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class DeallocateOnJobCompletionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class NativeFixedLengthAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class NativeMatchesParallelForLengthAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public sealed class NativeDisableParallelForRestrictionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public enum Allocator
{
	// Fields

	public int value__; // 0x10
	public const Allocator Invalid = 0; // 0x0
	public const Allocator None = 1; // 0x0
	public const Allocator Temp = 2; // 0x0
	public const Allocator TempJob = 3; // 0x0
	public const Allocator Persistent = 4; // 0x0
	public const Allocator AudioKernel = 5; // 0x0
	public const Allocator FirstUserIndex = 64; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public enum NativeArrayOptions
{
	// Fields

	public int value__; // 0x10
	public const NativeArrayOptions UninitializedMemory = 0; // 0x0
	public const NativeArrayOptions ClearMemory = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct Enumerator : IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private NativeArray`1 m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(ref NativeArray`1 array) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Reset() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct Enumerator : IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private ReadOnly m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(ref ReadOnly array) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Reset() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct ReadOnly : IEnumerable`1, IEnumerable
{
	// Fields

	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Properties

	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	internal void .ctor(Void* buffer, int length) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Length() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Enumerator GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public struct NativeArray`1 : IDisposable, IEnumerable`1, IEnumerable, IEquatable`1
{
	// Fields

	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties

	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options) { }

	// RVA: 0x0 Offset: 0xFFFFFF930AFA9000 VA: 0x0
	private static void Allocate(int length, Allocator allocator, ref NativeArray`1 array) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Length() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void set_Item(int index, T value) { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool get_IsCreated() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public T[] ToArray() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Enumerator GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Equals(NativeArray`1 other) { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public override bool Equals(object obj) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public override int GetHashCode() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static void Copy(NativeArray`1 src, T[] dst, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static void CopySafe(NativeArray`1 src, int srcIndex, T[] dst, int dstIndex, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public ReadOnly AsReadOnly() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
internal struct NativeArrayDispose
{
	// Fields

	internal Void* m_Buffer; // 0x10
	internal Allocator m_AllocatorLabel; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF69637B4 Offset: 0x190C7B4 VA: 0x6CF69637B4
	public void Dispose() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
internal struct NativeArrayDisposeJob : IJob
{
	// Fields

	internal NativeArrayDispose Data; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF696383C Offset: 0x190C83C VA: 0x6CF696383C
	public void Execute() { }

	// RVA: 0x6CF6963880 Offset: 0x190C880 VA: 0x6CF6963880
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView`1 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
internal sealed class NativeArrayReadOnlyDebugView`1 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public static class NativeSliceExtensions : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static NativeSlice`1 Slice(NativeArray`1 thisArray, int start, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static NativeSlice`1 Slice(NativeSlice`1 thisSlice, int start, int length) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public struct Enumerator : IEnumerator`1, IEnumerator, IDisposable
{
	// Fields

	private NativeSlice`1 m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void .ctor(ref NativeSlice`1 array) { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Dispose() { }

	// RVA: 0x6CF5BD67E0 Offset: 0xB7F7E0 VA: 0x6CF5BD67E0
	public bool MoveNext() { }

	// RVA: 0x6CF5BD7258 Offset: 0xB80258 VA: 0x6CF5BD7258
	public void Reset() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Current() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
public struct NativeSlice`1 : IEnumerable`1, IEnumerable, IEquatable`1
{
	// Fields

	internal Byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties

	public T Item { get; set; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(NativeSlice`1 slice, int start, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(NativeArray`1 array) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static NativeSlice`1 op_Implicit(NativeArray`1 array) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void .ctor(NativeArray`1 array, int start, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public T get_Item(int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void set_Item(int index, T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public void CopyFrom(NativeSlice`1 slice) { }

	// RVA: 0x6CF5BD7574 Offset: 0xB80574 VA: 0x6CF5BD7574
	public void CopyFrom(T[] array) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Stride() { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public int get_Length() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public Enumerator GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator`1 System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Equals(NativeSlice`1 other) { }

	// RVA: 0x6CF5BD68DC Offset: 0xB7F8DC VA: 0x6CF5BD68DC
	public override bool Equals(object obj) { }

	// RVA: 0x6CF5BD6A18 Offset: 0xB7FA18 VA: 0x6CF5BD6A18
	public override int GetHashCode() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections
internal sealed class NativeSliceDebugView`1 : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal struct SharedStatic`1
{
	// Fields

	private readonly Void* _buffer; // 0x0

	// Properties

	public T Data { get; }

	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private void .ctor(Void* buffer) { }

	// RVA: 0x6CF5BD6C78 Offset: 0xB7FC78 VA: 0x6CF5BD6C78
	public ref T get_Data() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static SharedStatic`1 GetOrCreate(uint alignment) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal static class SharedStatic : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69638C0 Offset: 0x190C8C0 VA: 0x6CF69638C0
	public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstLike : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private struct HashCode64`1
{
	// Fields

	public static readonly long Value; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF5BE00D4 Offset: 0xB890D4 VA: 0x6CF5BE00D4
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5BDD960 Offset: 0xB86960 VA: 0x6CF5BDD960
	public static long GetHashCode64() { }

	// RVA: 0x6CF696397C Offset: 0x190C97C VA: 0x6CF696397C
	internal static long HashStringWithFNV1A64(string text) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A08 Offset: 0x190CA08 VA: 0x6CF6963A08
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A10 Offset: 0x190CA10 VA: 0x6CF6963A10
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A18 Offset: 0x190CA18 VA: 0x6CF6963A18
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A20 Offset: 0x190CA20 VA: 0x6CF6963A20
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A28 Offset: 0x190CA28 VA: 0x6CF6963A28
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetThreadIndexAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public class WriteAccessRequiredAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A30 Offset: 0x190CA30 VA: 0x6CF6963A30
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A38 Offset: 0x190CA38 VA: 0x6CF6963A38
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A40 Offset: 0x190CA40 VA: 0x6CF6963A40
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static NativeArray`1 ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static Void* GetUnsafePtr(NativeArray`1 nativeArray) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static Void* GetUnsafeReadOnlyPtr(NativeArray`1 nativeArray) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeSliceUnsafeUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static NativeSlice`1 ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static Void* GetUnsafePtr(NativeSlice`1 nativeSlice) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static Void* GetUnsafeReadOnlyPtr(NativeSlice`1 nativeSlice) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private struct AlignOfHelper`1
{
	// Fields

	public byte dummy; // 0x0
	public T data; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Collections.LowLevel.Unsafe
public static class UnsafeUtility : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963A48 Offset: 0x190CA48 VA: 0x6CF6963A48
	public static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	// RVA: 0x6CF69637F8 Offset: 0x190C7F8 VA: 0x6CF69637F8
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	// RVA: 0x6CF69635E0 Offset: 0x190C5E0 VA: 0x6CF69635E0
	public static void MemCpy(Void* destination, Void* source, long size) { }

	// RVA: 0x6CF6963AA4 Offset: 0x190CAA4 VA: 0x6CF6963AA4
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	// RVA: 0x6CF6963B18 Offset: 0x190CB18 VA: 0x6CF6963B18
	public static void MemSet(Void* destination, byte value, long size) { }

	// RVA: 0x6CF6963B6C Offset: 0x190CB6C VA: 0x6CF6963B6C
	public static void MemClear(Void* destination, long size) { }

	// RVA: 0x6CF6963BB4 Offset: 0x190CBB4 VA: 0x6CF6963BB4
	public static int SizeOf(Type type) { }

	// RVA: 0x6CF6963BF0 Offset: 0x190CBF0 VA: 0x6CF6963BF0
	public static bool IsBlittable(Type type) { }

	// RVA: 0x6CF6963C2C Offset: 0x190CC2C VA: 0x6CF6963C2C
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x6CF6963C8C Offset: 0x190CC8C VA: 0x6CF6963C8C
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x6CF6963E48 Offset: 0x190CE48 VA: 0x6CF6963E48
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: 0x6CF6963E78 Offset: 0x190CE78 VA: 0x6CF6963E78
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: 0x6CF5BDAA64 Offset: 0xB83A64 VA: 0x6CF5BDAA64
	public static int AlignOf() { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T ReadArrayElement(Void* source, int index) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static Void* AddressOf(ref T output) { }

	// RVA: 0x6CF5BDAA64 Offset: 0xB83A64 VA: 0x6CF5BDAA64
	public static int SizeOf() { }

	// RVA: 0x6CF5BDDD38 Offset: 0xB86D38 VA: 0x6CF5BDDD38
	public static ref T As(ref U from) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static ref T AsRef(Void* ptr) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static int EnumToInt(T enumValue) { }

	// RVA: 0x6CF5BE19C0 Offset: 0xB8A9C0 VA: 0x6CF5BE19C0
	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public static bool EnumEquals(T lhs, T rhs) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Burst
public class BurstDiscardAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963EC4 Offset: 0x190CEC4 VA: 0x6CF6963EC4
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963928 Offset: 0x190C928 VA: 0x6CF6963928
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: JetBrains.Annotations
public sealed class NotNullAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963ECC Offset: 0x190CECC VA: 0x6CF6963ECC
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: JetBrains.Annotations
public sealed class PureAttribute : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6963ED4 Offset: 0x190CED4 VA: 0x6CF6963ED4
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct SortingLayer
{
	// Fields

	private int m_Id; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6963EDC Offset: 0x190CEDC VA: 0x6CF6963EDC
	public static int GetLayerValueFromID(int id) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Keyframe
{
	// Fields

	private float m_Time; // 0x10
	private float m_Value; // 0x14
	private float m_InTangent; // 0x18
	private float m_OutTangent; // 0x1C
	private int m_WeightedMode; // 0x20
	private float m_InWeight; // 0x24
	private float m_OutWeight; // 0x28

	// Properties

	public float time { get; }
	public float value { get; }
	public float inTangent { get; }
	public float outTangent { get; }

	// Methods

	// RVA: 0x6CF6963F18 Offset: 0x190CF18 VA: 0x6CF6963F18
	public void .ctor(float time, float value) { }

	// RVA: 0x6CF6963F28 Offset: 0x190CF28 VA: 0x6CF6963F28
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x6CF6963F3C Offset: 0x190CF3C VA: 0x6CF6963F3C
	public float get_time() { }

	// RVA: 0x6CF6963F44 Offset: 0x190CF44 VA: 0x6CF6963F44
	public float get_value() { }

	// RVA: 0x6CF6963F4C Offset: 0x190CF4C VA: 0x6CF6963F4C
	public float get_inTangent() { }

	// RVA: 0x6CF6963F54 Offset: 0x190CF54 VA: 0x6CF6963F54
	public float get_outTangent() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum WrapMode
{
	// Fields

	public int value__; // 0x10
	public const WrapMode Once = 1; // 0x0
	public const WrapMode Loop = 2; // 0x0
	public const WrapMode PingPong = 4; // 0x0
	public const WrapMode Default = 0; // 0x0
	public const WrapMode ClampForever = 8; // 0x0
	public const WrapMode Clamp = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class AnimationCurve : Object, IEquatable`1
{
	// Fields

	internal IntPtr m_Ptr; // 0x10

	// Properties

	public Keyframe[] keys { get; }
	public Keyframe Item { get; }
	public int length { get; }

	// Methods

	// RVA: 0x6CF6963F5C Offset: 0x190CF5C VA: 0x6CF6963F5C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x6CF6963F98 Offset: 0x190CF98 VA: 0x6CF6963F98
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0x6CF6963FD4 Offset: 0x190CFD4 VA: 0x6CF6963FD4
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x6CF6964018 Offset: 0x190D018 VA: 0x6CF6964018
	protected override void Finalize() { }

	// RVA: 0x6CF69640D4 Offset: 0x190D0D4 VA: 0x6CF69640D4
	public float Evaluate(float time) { }

	// RVA: 0x6CF6964120 Offset: 0x190D120 VA: 0x6CF6964120
	public Keyframe[] get_keys() { }

	// RVA: 0x6CF6964198 Offset: 0x190D198 VA: 0x6CF6964198
	public Keyframe get_Item(int index) { }

	// RVA: 0x6CF69642A0 Offset: 0x190D2A0 VA: 0x6CF69642A0
	public int get_length() { }

	// RVA: 0x6CF6964224 Offset: 0x190D224 VA: 0x6CF6964224
	private Keyframe GetKey(int index) { }

	// RVA: 0x6CF696415C Offset: 0x190D15C VA: 0x6CF696415C
	private Keyframe[] GetKeys() { }

	// RVA: 0x6CF6964330 Offset: 0x190D330 VA: 0x6CF6964330
	public override int GetHashCode() { }

	// RVA: 0x6CF696436C Offset: 0x190D36C VA: 0x6CF696436C
	public void .ctor(Keyframe[] keys) { }

	// RVA: 0x6CF69643BC Offset: 0x190D3BC VA: 0x6CF69643BC
	public void .ctor() { }

	// RVA: 0x6CF6964408 Offset: 0x190D408 VA: 0x6CF6964408
	public override bool Equals(object o) { }

	// RVA: 0x6CF6964514 Offset: 0x190D514 VA: 0x6CF6964514
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x6CF69642DC Offset: 0x190D2DC VA: 0x6CF69642DC
	private void GetKey_Injected(int index, ref Keyframe ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class LowMemoryCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69654AC Offset: 0x190E4AC VA: 0x6CF69654AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6965534 Offset: 0x190E534 VA: 0x6CF6965534
	public virtual void Invoke() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class MemoryUsageChangedCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6965548 Offset: 0x190E548 VA: 0x6CF6965548
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF69655E4 Offset: 0x190E5E4 VA: 0x6CF69655E4
	public virtual void Invoke(ref ApplicationMemoryUsageChange usage) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class LogCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69655F8 Offset: 0x190E5F8 VA: 0x6CF69655F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6965698 Offset: 0x190E698 VA: 0x6CF6965698
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Application : Object
{
	// Fields

	private static LowMemoryCallback lowMemory; // 0x0
	private static MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static LogCallback s_LogCallbackHandler; // 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; // 0x18
	private static Action`1 focusChanged; // 0x20
	private static Action`1 deepLinkActivated; // 0x28
	private static Func`1 wantsToQuit; // 0x30
	private static Action quitting; // 0x38
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48

	// Properties

	public static bool isPlaying { get; }
	public static bool isFocused { get; }
	public static bool runInBackground { set; }
	public static bool isBatchMode { get; }
	public static string temporaryCachePath { get; }
	public static string unityVersion { get; }
	public static int targetFrameRate { set; }
	public static RuntimePlatform platform { get; }
	public static int loadedLevel { get; }
	public static string loadedLevelName { get; }
	public static bool isEditor { get; }

	// Methods

	// RVA: 0x6CF69645DC Offset: 0x190D5DC VA: 0x6CF69645DC
	public static void Quit(int exitCode) { }

	// RVA: 0x6CF6964618 Offset: 0x190D618 VA: 0x6CF6964618
	public static void Quit() { }

	// RVA: 0x6CF6964688 Offset: 0x190D688 VA: 0x6CF6964688
	public static bool get_isPlaying() { }

	// RVA: 0x6CF69646B0 Offset: 0x190D6B0 VA: 0x6CF69646B0
	public static bool get_isFocused() { }

	// RVA: 0x6CF69646D8 Offset: 0x190D6D8 VA: 0x6CF69646D8
	public static void set_runInBackground(bool value) { }

	// RVA: 0x6CF6964714 Offset: 0x190D714 VA: 0x6CF6964714
	public static bool get_isBatchMode() { }

	// RVA: 0x6CF696473C Offset: 0x190D73C VA: 0x6CF696473C
	public static string get_temporaryCachePath() { }

	// RVA: 0x6CF6964764 Offset: 0x190D764 VA: 0x6CF6964764
	public static string get_unityVersion() { }

	// RVA: 0x6CF696478C Offset: 0x190D78C VA: 0x6CF696478C
	public static void OpenURL(string url) { }

	// RVA: 0x6CF69647C8 Offset: 0x190D7C8 VA: 0x6CF69647C8
	public static void set_targetFrameRate(int value) { }

	// RVA: 0x6CF6964804 Offset: 0x190D804 VA: 0x6CF6964804
	public static RuntimePlatform get_platform() { }

	// RVA: 0x6CF696482C Offset: 0x190D82C VA: 0x6CF696482C
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	// RVA: 0x6CF6964964 Offset: 0x190D964 VA: 0x6CF6964964
	internal static bool HasLogCallback() { }

	// RVA: 0x6CF69649E8 Offset: 0x190D9E8 VA: 0x6CF69649E8
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	// RVA: 0x6CF6964AC4 Offset: 0x190DAC4 VA: 0x6CF6964AC4
	private static bool Internal_ApplicationWantsToQuit() { }

	// RVA: 0x6CF6964DC8 Offset: 0x190DDC8 VA: 0x6CF6964DC8
	private static void Internal_ApplicationInit() { }

	// RVA: 0x6CF6964E48 Offset: 0x190DE48 VA: 0x6CF6964E48
	private static void Internal_ApplicationQuit() { }

	// RVA: 0x6CF6964EF4 Offset: 0x190DEF4 VA: 0x6CF6964EF4
	private static void Internal_ApplicationUnload() { }

	// RVA: 0x6CF6964F88 Offset: 0x190DF88 VA: 0x6CF6964F88
	internal static void InvokeOnBeforeRender() { }

	// RVA: 0x6CF696517C Offset: 0x190E17C VA: 0x6CF696517C
	internal static void InvokeFocusChanged(bool focus) { }

	// RVA: 0x6CF6965218 Offset: 0x190E218 VA: 0x6CF6965218
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x6CF69652B4 Offset: 0x190E2B4 VA: 0x6CF69652B4
	public static int get_loadedLevel() { }

	// RVA: 0x6CF6965318 Offset: 0x190E318 VA: 0x6CF6965318
	public static string get_loadedLevelName() { }

	// RVA: 0x6CF696537C Offset: 0x190E37C VA: 0x6CF696537C
	public static void LoadLevel(int index) { }

	// RVA: 0x6CF69653D8 Offset: 0x190E3D8 VA: 0x6CF69653D8
	public static AsyncOperation LoadLevelAsync(string levelName) { }

	// RVA: 0x6CF6965434 Offset: 0x190E434 VA: 0x6CF6965434
	public static bool get_isEditor() { }

	// RVA: 0x6CF696543C Offset: 0x190E43C VA: 0x6CF696543C
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum ApplicationMemoryUsage
{
	// Fields

	public int value__; // 0x10
	public const ApplicationMemoryUsage Unknown = 0; // 0x0
	public const ApplicationMemoryUsage Low = 1; // 0x0
	public const ApplicationMemoryUsage Medium = 2; // 0x0
	public const ApplicationMemoryUsage High = 3; // 0x0
	public const ApplicationMemoryUsage Critical = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct ApplicationMemoryUsageChange
{
	// Fields

	private ApplicationMemoryUsage <memoryUsage>k__BackingField; // 0x10

	// Properties

	private ApplicationMemoryUsage memoryUsage { set; }

	// Methods

	// RVA: 0x6CF69656AC Offset: 0x190E6AC VA: 0x6CF69656AC
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x6CF696495C Offset: 0x190D95C VA: 0x6CF696495C
	public void .ctor(ApplicationMemoryUsage usage) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum SendMessageOptions
{
	// Fields

	public int value__; // 0x10
	public const SendMessageOptions RequireReceiver = 0; // 0x0
	public const SendMessageOptions DontRequireReceiver = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum PrimitiveType
{
	// Fields

	public int value__; // 0x10
	public const PrimitiveType Sphere = 0; // 0x0
	public const PrimitiveType Capsule = 1; // 0x0
	public const PrimitiveType Cylinder = 2; // 0x0
	public const PrimitiveType Cube = 3; // 0x0
	public const PrimitiveType Plane = 4; // 0x0
	public const PrimitiveType Quad = 5; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum Space
{
	// Fields

	public int value__; // 0x10
	public const Space World = 0; // 0x0
	public const Space Self = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum RuntimePlatform
{
	// Fields

	public int value__; // 0x10
	public const RuntimePlatform OSXEditor = 0; // 0x0
	public const RuntimePlatform OSXPlayer = 1; // 0x0
	public const RuntimePlatform WindowsPlayer = 2; // 0x0
	public const RuntimePlatform OSXWebPlayer = 3; // 0x0
	public const RuntimePlatform OSXDashboardPlayer = 4; // 0x0
	public const RuntimePlatform WindowsWebPlayer = 5; // 0x0
	public const RuntimePlatform WindowsEditor = 7; // 0x0
	public const RuntimePlatform IPhonePlayer = 8; // 0x0
	public const RuntimePlatform XBOX360 = 10; // 0x0
	public const RuntimePlatform PS3 = 9; // 0x0
	public const RuntimePlatform Android = 11; // 0x0
	public const RuntimePlatform NaCl = 12; // 0x0
	public const RuntimePlatform FlashPlayer = 15; // 0x0
	public const RuntimePlatform LinuxPlayer = 13; // 0x0
	public const RuntimePlatform LinuxEditor = 16; // 0x0
	public const RuntimePlatform WebGLPlayer = 17; // 0x0
	public const RuntimePlatform MetroPlayerX86 = 18; // 0x0
	public const RuntimePlatform WSAPlayerX86 = 18; // 0x0
	public const RuntimePlatform MetroPlayerX64 = 19; // 0x0
	public const RuntimePlatform WSAPlayerX64 = 19; // 0x0
	public const RuntimePlatform MetroPlayerARM = 20; // 0x0
	public const RuntimePlatform WSAPlayerARM = 20; // 0x0
	public const RuntimePlatform WP8Player = 21; // 0x0
	public const RuntimePlatform BlackBerryPlayer = 22; // 0x0
	public const RuntimePlatform TizenPlayer = 23; // 0x0
	public const RuntimePlatform PSP2 = 24; // 0x0
	public const RuntimePlatform PS4 = 25; // 0x0
	public const RuntimePlatform PSM = 26; // 0x0
	public const RuntimePlatform XboxOne = 27; // 0x0
	public const RuntimePlatform SamsungTVPlayer = 28; // 0x0
	public const RuntimePlatform WiiU = 30; // 0x0
	public const RuntimePlatform tvOS = 31; // 0x0
	public const RuntimePlatform Switch = 32; // 0x0
	public const RuntimePlatform Lumin = 33; // 0x0
	public const RuntimePlatform Stadia = 34; // 0x0
	public const RuntimePlatform CloudRendering = 35; // 0x0
	public const RuntimePlatform GameCoreScarlett = 4294967295; // 0x0
	public const RuntimePlatform GameCoreXboxSeries = 36; // 0x0
	public const RuntimePlatform GameCoreXboxOne = 37; // 0x0
	public const RuntimePlatform PS5 = 38; // 0x0
	public const RuntimePlatform EmbeddedLinuxArm64 = 39; // 0x0
	public const RuntimePlatform EmbeddedLinuxArm32 = 40; // 0x0
	public const RuntimePlatform EmbeddedLinuxX64 = 41; // 0x0
	public const RuntimePlatform EmbeddedLinuxX86 = 42; // 0x0
	public const RuntimePlatform LinuxServer = 43; // 0x0
	public const RuntimePlatform WindowsServer = 44; // 0x0
	public const RuntimePlatform OSXServer = 45; // 0x0
	public const RuntimePlatform QNXArm32 = 46; // 0x0
	public const RuntimePlatform QNXArm64 = 47; // 0x0
	public const RuntimePlatform QNXX64 = 48; // 0x0
	public const RuntimePlatform QNXX86 = 49; // 0x0
	public const RuntimePlatform VisionOS = 50; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum SystemLanguage
{
	// Fields

	public int value__; // 0x10
	public const SystemLanguage Afrikaans = 0; // 0x0
	public const SystemLanguage Arabic = 1; // 0x0
	public const SystemLanguage Basque = 2; // 0x0
	public const SystemLanguage Belarusian = 3; // 0x0
	public const SystemLanguage Bulgarian = 4; // 0x0
	public const SystemLanguage Catalan = 5; // 0x0
	public const SystemLanguage Chinese = 6; // 0x0
	public const SystemLanguage Czech = 7; // 0x0
	public const SystemLanguage Danish = 8; // 0x0
	public const SystemLanguage Dutch = 9; // 0x0
	public const SystemLanguage English = 10; // 0x0
	public const SystemLanguage Estonian = 11; // 0x0
	public const SystemLanguage Faroese = 12; // 0x0
	public const SystemLanguage Finnish = 13; // 0x0
	public const SystemLanguage French = 14; // 0x0
	public const SystemLanguage German = 15; // 0x0
	public const SystemLanguage Greek = 16; // 0x0
	public const SystemLanguage Hebrew = 17; // 0x0
	public const SystemLanguage Icelandic = 19; // 0x0
	public const SystemLanguage Indonesian = 20; // 0x0
	public const SystemLanguage Italian = 21; // 0x0
	public const SystemLanguage Japanese = 22; // 0x0
	public const SystemLanguage Korean = 23; // 0x0
	public const SystemLanguage Latvian = 24; // 0x0
	public const SystemLanguage Lithuanian = 25; // 0x0
	public const SystemLanguage Norwegian = 26; // 0x0
	public const SystemLanguage Polish = 27; // 0x0
	public const SystemLanguage Portuguese = 28; // 0x0
	public const SystemLanguage Romanian = 29; // 0x0
	public const SystemLanguage Russian = 30; // 0x0
	public const SystemLanguage SerboCroatian = 31; // 0x0
	public const SystemLanguage Slovak = 32; // 0x0
	public const SystemLanguage Slovenian = 33; // 0x0
	public const SystemLanguage Spanish = 34; // 0x0
	public const SystemLanguage Swedish = 35; // 0x0
	public const SystemLanguage Thai = 36; // 0x0
	public const SystemLanguage Turkish = 37; // 0x0
	public const SystemLanguage Ukrainian = 38; // 0x0
	public const SystemLanguage Vietnamese = 39; // 0x0
	public const SystemLanguage ChineseSimplified = 40; // 0x0
	public const SystemLanguage ChineseTraditional = 41; // 0x0
	public const SystemLanguage Hindi = 42; // 0x0
	public const SystemLanguage Unknown = 43; // 0x0
	public const SystemLanguage Hungarian = 18; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum LogType
{
	// Fields

	public int value__; // 0x10
	public const LogType Error = 0; // 0x0
	public const LogType Assert = 1; // 0x0
	public const LogType Warning = 2; // 0x0
	public const LogType Log = 3; // 0x0
	public const LogType Exception = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum LogOption
{
	// Fields

	public int value__; // 0x10
	public const LogOption None = 0; // 0x0
	public const LogOption NoStacktrace = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal class BootConfigData : Object
{
	// Fields

	private IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF69656B4 Offset: 0x190E6B4 VA: 0x6CF69656B4
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x6CF696570C Offset: 0x190E70C VA: 0x6CF696570C
	private void .ctor(IntPtr nativeHandle) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public enum MonoOrStereoscopicEye
{
	// Fields

	public int value__; // 0x10
	public const MonoOrStereoscopicEye Left = 0; // 0x0
	public const MonoOrStereoscopicEye Right = 1; // 0x0
	public const MonoOrStereoscopicEye Mono = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class CameraCallback : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6966C4C Offset: 0x190FC4C VA: 0x6CF6966C4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6966CE8 Offset: 0x190FCE8 VA: 0x6CF6966CE8
	public virtual void Invoke(Camera cam) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Camera : Behaviour
{
	// Fields

	public const float kMinAperture; // 0x0
	public const float kMaxAperture; // 0x0
	public const int kMinBladeCount; // 0x0
	public const int kMaxBladeCount; // 0x0
	public static CameraCallback onPreCull; // 0x0
	public static CameraCallback onPreRender; // 0x8
	public static CameraCallback onPostRender; // 0x10

	// Properties

	public float nearClipPlane { get; set; }
	public float farClipPlane { get; set; }
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { set; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public float depth { get; set; }
	public float aspect { get; set; }
	public int cullingMask { get; set; }
	public int eventMask { get; }
	public bool useOcclusionCulling { set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public Rect pixelRect { get; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public int targetDisplay { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x6CF6965790 Offset: 0x190E790 VA: 0x6CF6965790
	public void .ctor() { }

	// RVA: 0x6CF6965798 Offset: 0x190E798 VA: 0x6CF6965798
	public float get_nearClipPlane() { }

	// RVA: 0x6CF69657D4 Offset: 0x190E7D4 VA: 0x6CF69657D4
	public void set_nearClipPlane(float value) { }

	// RVA: 0x6CF6965820 Offset: 0x190E820 VA: 0x6CF6965820
	public float get_farClipPlane() { }

	// RVA: 0x6CF696585C Offset: 0x190E85C VA: 0x6CF696585C
	public void set_farClipPlane(float value) { }

	// RVA: 0x6CF69658A8 Offset: 0x190E8A8 VA: 0x6CF69658A8
	public float get_fieldOfView() { }

	// RVA: 0x6CF69658E4 Offset: 0x190E8E4 VA: 0x6CF69658E4
	public void set_fieldOfView(float value) { }

	// RVA: 0x6CF6965930 Offset: 0x190E930 VA: 0x6CF6965930
	public void set_renderingPath(RenderingPath value) { }

	// RVA: 0x6CF6965974 Offset: 0x190E974 VA: 0x6CF6965974
	public bool get_allowHDR() { }

	// RVA: 0x6CF69659B0 Offset: 0x190E9B0 VA: 0x6CF69659B0
	public void set_allowHDR(bool value) { }

	// RVA: 0x6CF69659F4 Offset: 0x190E9F4 VA: 0x6CF69659F4
	public void set_allowMSAA(bool value) { }

	// RVA: 0x6CF6965A38 Offset: 0x190EA38 VA: 0x6CF6965A38
	public float get_orthographicSize() { }

	// RVA: 0x6CF6965A74 Offset: 0x190EA74 VA: 0x6CF6965A74
	public void set_orthographicSize(float value) { }

	// RVA: 0x6CF6965AC0 Offset: 0x190EAC0 VA: 0x6CF6965AC0
	public bool get_orthographic() { }

	// RVA: 0x6CF6965AFC Offset: 0x190EAFC VA: 0x6CF6965AFC
	public void set_orthographic(bool value) { }

	// RVA: 0x6CF6965B40 Offset: 0x190EB40 VA: 0x6CF6965B40
	public float get_depth() { }

	// RVA: 0x6CF6965B7C Offset: 0x190EB7C VA: 0x6CF6965B7C
	public void set_depth(float value) { }

	// RVA: 0x6CF6965BC8 Offset: 0x190EBC8 VA: 0x6CF6965BC8
	public float get_aspect() { }

	// RVA: 0x6CF6965C04 Offset: 0x190EC04 VA: 0x6CF6965C04
	public void set_aspect(float value) { }

	// RVA: 0x6CF6965C50 Offset: 0x190EC50 VA: 0x6CF6965C50
	public int get_cullingMask() { }

	// RVA: 0x6CF6965C8C Offset: 0x190EC8C VA: 0x6CF6965C8C
	public void set_cullingMask(int value) { }

	// RVA: 0x6CF6965CD0 Offset: 0x190ECD0 VA: 0x6CF6965CD0
	public int get_eventMask() { }

	// RVA: 0x6CF6965D0C Offset: 0x190ED0C VA: 0x6CF6965D0C
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x6CF6965D50 Offset: 0x190ED50 VA: 0x6CF6965D50
	public Color get_backgroundColor() { }

	// RVA: 0x6CF6965DEC Offset: 0x190EDEC VA: 0x6CF6965DEC
	public void set_backgroundColor(Color value) { }

	// RVA: 0x6CF6965E84 Offset: 0x190EE84 VA: 0x6CF6965E84
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x6CF6965EC0 Offset: 0x190EEC0 VA: 0x6CF6965EC0
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x6CF6965F04 Offset: 0x190EF04 VA: 0x6CF6965F04
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x6CF6965F40 Offset: 0x190EF40 VA: 0x6CF6965F40
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x6CF6965F84 Offset: 0x190EF84 VA: 0x6CF6965F84
	public Rect get_pixelRect() { }

	// RVA: 0x6CF6966020 Offset: 0x190F020 VA: 0x6CF6966020
	public int get_pixelWidth() { }

	// RVA: 0x6CF696605C Offset: 0x190F05C VA: 0x6CF696605C
	public int get_pixelHeight() { }

	// RVA: 0x6CF6966098 Offset: 0x190F098 VA: 0x6CF6966098
	public RenderTexture get_targetTexture() { }

	// RVA: 0x6CF69660D4 Offset: 0x190F0D4 VA: 0x6CF69660D4
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x6CF6966118 Offset: 0x190F118 VA: 0x6CF6966118
	public int get_targetDisplay() { }

	// RVA: 0x6CF6966154 Offset: 0x190F154 VA: 0x6CF6966154
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x6CF6966204 Offset: 0x190F204 VA: 0x6CF6966204
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x6CF696628C Offset: 0x190F28C VA: 0x6CF696628C
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x6CF696633C Offset: 0x190F33C VA: 0x6CF696633C
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x6CF69663C4 Offset: 0x190F3C4 VA: 0x6CF69663C4
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x6CF6966490 Offset: 0x190F490 VA: 0x6CF6966490
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x6CF696655C Offset: 0x190F55C VA: 0x6CF696655C
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x6CF6966628 Offset: 0x190F628 VA: 0x6CF6966628
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x6CF6966630 Offset: 0x190F630 VA: 0x6CF6966630
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x6CF6966638 Offset: 0x190F638 VA: 0x6CF6966638
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x6CF69666F4 Offset: 0x190F6F4 VA: 0x6CF69666F4
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x6CF69667C8 Offset: 0x190F7C8 VA: 0x6CF69667C8
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x6CF6966800 Offset: 0x190F800 VA: 0x6CF6966800
	public Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0x6CF6966844 Offset: 0x190F844 VA: 0x6CF6966844
	public static Camera get_main() { }

	// RVA: 0x6CF696686C Offset: 0x190F86C VA: 0x6CF696686C
	public static Camera get_current() { }

	// RVA: 0x6CF6966894 Offset: 0x190F894 VA: 0x6CF6966894
	private static int GetAllCamerasCount() { }

	// RVA: 0x6CF69668BC Offset: 0x190F8BC VA: 0x6CF69668BC
	private static int GetAllCamerasImpl(Camera[] cam) { }

	// RVA: 0x6CF69668F8 Offset: 0x190F8F8 VA: 0x6CF69668F8
	public static int get_allCamerasCount() { }

	// RVA: 0x6CF6966920 Offset: 0x190F920 VA: 0x6CF6966920
	public static int GetAllCameras(Camera[] cameras) { }

	// RVA: 0x6CF69669F8 Offset: 0x190F9F8 VA: 0x6CF69669F8
	public void Render() { }

	// RVA: 0x6CF6966A34 Offset: 0x190FA34 VA: 0x6CF6966A34
	public void RenderWithShader(Shader shader, string replacementTag) { }

	// RVA: 0x6CF6966A88 Offset: 0x190FA88 VA: 0x6CF6966A88
	public static void SetupCurrent(Camera cur) { }

	// RVA: 0x6CF6966AC4 Offset: 0x190FAC4 VA: 0x6CF6966AC4
	public void CopyFrom(Camera other) { }

	// RVA: 0x6CF6966B08 Offset: 0x190FB08 VA: 0x6CF6966B08
	private static void FireOnPreCull(Camera cam) { }

	// RVA: 0x6CF6966B74 Offset: 0x190FB74 VA: 0x6CF6966B74
	private static void FireOnPreRender(Camera cam) { }

	// RVA: 0x6CF6966BE0 Offset: 0x190FBE0 VA: 0x6CF6966BE0
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x6CF6965DA8 Offset: 0x190EDA8 VA: 0x6CF6965DA8
	private void get_backgroundColor_Injected(ref Color ret) { }

	// RVA: 0x6CF6965E40 Offset: 0x190EE40 VA: 0x6CF6965E40
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x6CF6965FDC Offset: 0x190EFDC VA: 0x6CF6965FDC
	private void get_pixelRect_Injected(ref Rect ret) { }

	// RVA: 0x6CF69661C0 Offset: 0x190F1C0 VA: 0x6CF69661C0
	private void get_worldToCameraMatrix_Injected(ref Matrix4x4 ret) { }

	// RVA: 0x6CF6966248 Offset: 0x190F248 VA: 0x6CF6966248
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x6CF69662F8 Offset: 0x190F2F8 VA: 0x6CF69662F8
	private void get_projectionMatrix_Injected(ref Matrix4x4 ret) { }

	// RVA: 0x6CF6966380 Offset: 0x190F380 VA: 0x6CF6966380
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x6CF696643C Offset: 0x190F43C VA: 0x6CF696643C
	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, ref Matrix4x4 ret) { }

	// RVA: 0x6CF6966500 Offset: 0x190F500 VA: 0x6CF6966500
	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, ref Vector3 ret) { }

	// RVA: 0x6CF69665CC Offset: 0x190F5CC VA: 0x6CF69665CC
	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, ref Vector3 ret) { }

	// RVA: 0x6CF69666A0 Offset: 0x190F6A0 VA: 0x6CF69666A0
	private void ScreenToViewportPoint_Injected(ref Vector3 position, ref Vector3 ret) { }

	// RVA: 0x6CF696676C Offset: 0x190F76C VA: 0x6CF696676C
	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, ref Ray ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct CullingGroupEvent
{
	// Fields

	private int m_Index; // 0x10
	private byte m_PrevState; // 0x14
	private byte m_ThisState; // 0x15

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class StateChanged : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6966D58 Offset: 0x190FD58 VA: 0x6CF6966D58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF6966DE4 Offset: 0x190FDE4 VA: 0x6CF6966DE4
	public virtual void Invoke(CullingGroupEvent sphere) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class CullingGroup : Object
{
	// Fields

	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF6966CFC Offset: 0x190FCFC VA: 0x6CF6966CFC
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class FlareLayer : Behaviour
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public enum ReflectionProbeEvent
{
	// Fields

	public int value__; // 0x10
	public const ReflectionProbeEvent ReflectionProbeAdded = 0; // 0x0
	public const ReflectionProbeEvent ReflectionProbeRemoved = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class ReflectionProbe : Behaviour
{
	// Fields

	private static Action`2 reflectionProbeChanged; // 0x0
	private static Dictionary`2 registeredDefaultReflectionSetActions; // 0x8
	private static List`1 registeredDefaultReflectionTextureActions; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF6966DF8 Offset: 0x190FDF8 VA: 0x6CF6966DF8
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0x6CF6966E88 Offset: 0x190FE88 VA: 0x6CF6966E88
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x6CF696700C Offset: 0x191000C VA: 0x6CF696700C
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal sealed class DebugLogHandler : Object, ILogHandler
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF69670E8 Offset: 0x19100E8 VA: 0x6CF69670E8
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	// RVA: 0x6CF6967144 Offset: 0x1910144 VA: 0x6CF6967144
	internal static void Internal_LogException(Exception ex, object obj) { }

	// RVA: 0x6CF6967188 Offset: 0x1910188 VA: 0x6CF6967188
	public void LogFormat(LogType logType, object context, string format, Object[] args) { }

	// RVA: 0x6CF69671F0 Offset: 0x19101F0 VA: 0x6CF69671F0
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	// RVA: 0x6CF696725C Offset: 0x191025C VA: 0x6CF696725C
	public void LogException(Exception exception, object context) { }

	// RVA: 0x6CF69672EC Offset: 0x19102EC VA: 0x6CF69672EC
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Debug : Object
{
	// Fields

	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties

	public static ILogger unityLogger { get; }
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x6CF69672F4 Offset: 0x19102F4 VA: 0x6CF69672F4
	public static ILogger get_unityLogger() { }

	// RVA: 0x6CF696734C Offset: 0x191034C VA: 0x6CF696734C
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	// RVA: 0x6CF696745C Offset: 0x191045C VA: 0x6CF696745C
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	// RVA: 0x6CF696757C Offset: 0x191057C VA: 0x6CF696757C
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x6CF69675D0 Offset: 0x19105D0 VA: 0x6CF69675D0
	public static void Log(object message) { }

	// RVA: 0x6CF69676D8 Offset: 0x19106D8 VA: 0x6CF69676D8
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	// RVA: 0x6CF69679B0 Offset: 0x19109B0 VA: 0x6CF69679B0
	public static void LogError(object message) { }

	// RVA: 0x6CF6967AB8 Offset: 0x1910AB8 VA: 0x6CF6967AB8
	public static void LogError(object message, object context) { }

	// RVA: 0x6CF6967BD0 Offset: 0x1910BD0 VA: 0x6CF6967BD0
	public static void LogErrorFormat(string format, Object[] args) { }

	// RVA: 0x6CF6967CE8 Offset: 0x1910CE8 VA: 0x6CF6967CE8
	public static void LogErrorFormat(object context, string format, Object[] args) { }

	// RVA: 0x6CF6964CC0 Offset: 0x190DCC0 VA: 0x6CF6964CC0
	public static void LogException(Exception exception) { }

	// RVA: 0x6CF6967E04 Offset: 0x1910E04 VA: 0x6CF6967E04
	public static void LogException(Exception exception, object context) { }

	// RVA: 0x6CF6967F18 Offset: 0x1910F18 VA: 0x6CF6967F18
	public static void LogWarning(object message) { }

	// RVA: 0x6CF6968020 Offset: 0x1911020 VA: 0x6CF6968020
	public static void LogWarning(object message, object context) { }

	// RVA: 0x6CF6968138 Offset: 0x1911138 VA: 0x6CF6968138
	public static void LogWarningFormat(string format, Object[] args) { }

	// RVA: 0x6CF6968250 Offset: 0x1911250 VA: 0x6CF6968250
	public static void LogWarningFormat(object context, string format, Object[] args) { }

	// RVA: 0x6CF696836C Offset: 0x191136C VA: 0x6CF696836C
	public static void Assert(bool condition) { }

	// RVA: 0x6CF696849C Offset: 0x191149C VA: 0x6CF696849C
	public static void Assert(bool condition, string message) { }

	// RVA: 0x6CF69685B8 Offset: 0x19115B8 VA: 0x6CF69685B8
	public static void LogAssertion(object message) { }

	// RVA: 0x6CF69686C0 Offset: 0x19116C0 VA: 0x6CF69686C0
	public static void LogAssertionFormat(string format, Object[] args) { }

	// RVA: 0x6CF69687D8 Offset: 0x19117D8 VA: 0x6CF69687D8
	public static bool get_isDebugBuild() { }

	// RVA: 0x6CF6968800 Offset: 0x1911800 VA: 0x6CF6968800
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	// RVA: 0x6CF6968BF8 Offset: 0x1911BF8 VA: 0x6CF6968BF8
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x6CF6968E1C Offset: 0x1911E1C VA: 0x6CF6968E1C
	private static void .cctor() { }

	// RVA: 0x6CF6967510 Offset: 0x1910510 VA: 0x6CF6967510
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
internal class Expression : Object
{
	// Fields

	internal readonly String[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF696ACB4 Offset: 0x1913CB4 VA: 0x6CF696ACB4
	internal void .ctor(string expression) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	public bool Evaluate(ref T value, int index, int count) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private struct PcgRandom
{
	// Fields

	private readonly ulong increment; // 0x10
	private ulong state; // 0x18

	// Properties


	// Methods

	// RVA: 0x6CF696AC4C Offset: 0x1913C4C VA: 0x6CF696AC4C
	public void .ctor(ulong state, ulong sequence) { }

	// RVA: 0x6CF696A6A4 Offset: 0x19136A4 VA: 0x6CF696A6A4
	public uint GetUInt() { }

	// RVA: 0x6CF696AD70 Offset: 0x1913D70 VA: 0x6CF696AD70
	private static uint RotateRight(uint v, int rot) { }

	// RVA: 0x6CF696AD58 Offset: 0x1913D58 VA: 0x6CF696AD58
	private static uint XshRr(ulong s) { }

	// RVA: 0x6CF696AD38 Offset: 0x1913D38 VA: 0x6CF696AD38
	private void Step() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private enum Op
{
	// Fields

	public int value__; // 0x10
	public const Op Add = 0; // 0x0
	public const Op Sub = 1; // 0x0
	public const Op Mul = 2; // 0x0
	public const Op Div = 3; // 0x0
	public const Op Mod = 4; // 0x0
	public const Op Neg = 5; // 0x0
	public const Op Pow = 6; // 0x0
	public const Op Sqrt = 7; // 0x0
	public const Op Sin = 8; // 0x0
	public const Op Cos = 9; // 0x0
	public const Op Tan = 10; // 0x0
	public const Op Floor = 11; // 0x0
	public const Op Ceil = 12; // 0x0
	public const Op Round = 13; // 0x0
	public const Op Rand = 14; // 0x0
	public const Op Linear = 15; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private enum Associativity
{
	// Fields

	public int value__; // 0x10
	public const Associativity Left = 0; // 0x0
	public const Associativity Right = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private class Operator : Object
{
	// Fields

	public readonly Op op; // 0x10
	public readonly int precedence; // 0x14
	public readonly Associativity associativity; // 0x18
	public readonly int inputs; // 0x1C

	// Properties


	// Methods

	// RVA: 0x6CF696AC74 Offset: 0x1913C74 VA: 0x6CF696AC74
	public void .ctor(Op op, int precedence, int inputs, Associativity associativity) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
[Serializable]
private sealed class <>c : Object
{
	// Fields

	public static readonly <>c <>9; // 0x0
	public static Func`2 <>9__14_0; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF696AD78 Offset: 0x1913D78 VA: 0x6CF696AD78
	private static void .cctor() { }

	// RVA: 0x6CF696ADD4 Offset: 0x1913DD4 VA: 0x6CF696ADD4
	public void .ctor() { }

	// RVA: 0x6CF696ADDC Offset: 0x1913DDC VA: 0x6CF696ADDC
	internal bool <ExpressionToTokens>b__14_0(string f) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class ExpressionEvaluator : Object
{
	// Fields

	private static PcgRandom s_Random; // 0x0
	private static Dictionary`2 s_Operators; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF5BD9068 Offset: 0xB82068 VA: 0x6CF5BD9068
	internal static bool Evaluate(string expression, ref T value, ref Expression delayed) { }

	// RVA: 0x6CF5C90CB4 Offset: 0xC39CB4 VA: 0x6CF5C90CB4
	private static bool EvaluateTokens(String[] tokens, ref T value, int index, int count) { }

	// RVA: 0x6CF6968F50 Offset: 0x1911F50 VA: 0x6CF6968F50
	private static bool EvaluateDouble(String[] tokens, ref double value, int index, int count) { }

	// RVA: 0x6CF69699A8 Offset: 0x19129A8 VA: 0x6CF69699A8
	private static String[] InfixToRPN(String[] tokens) { }

	// RVA: 0x6CF6969E14 Offset: 0x1912E14 VA: 0x6CF6969E14
	private static bool NeedToPop(Stack`1 operatorStack, Operator newOperator) { }

	// RVA: 0x6CF6969EFC Offset: 0x1912EFC VA: 0x6CF6969EFC
	private static String[] ExpressionToTokens(string expression, ref bool hasVariables) { }

	// RVA: 0x6CF6969540 Offset: 0x1912540 VA: 0x6CF6969540
	private static bool IsCommand(string token) { }

	// RVA: 0x6CF6969940 Offset: 0x1912940 VA: 0x6CF6969940
	private static bool IsVariable(string token) { }

	// RVA: 0x6CF6969DA8 Offset: 0x1912DA8 VA: 0x6CF6969DA8
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x6CF6969420 Offset: 0x1912420 VA: 0x6CF6969420
	private static bool IsOperator(string token) { }

	// RVA: 0x6CF69694A0 Offset: 0x19124A0 VA: 0x6CF69694A0
	private static Operator TokenToOperator(string token) { }

	// RVA: 0x6CF696A338 Offset: 0x1913338 VA: 0x6CF696A338
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x6CF696A528 Offset: 0x1913528 VA: 0x6CF696A528
	private static String[] FixUnaryOperators(String[] tokens) { }

	// RVA: 0x6CF69695EC Offset: 0x19125EC VA: 0x6CF69695EC
	private static double EvaluateOp(Double[] values, Op op, int index, int count) { }

	// RVA: 0x6CF5BD8FA4 Offset: 0xB81FA4 VA: 0x6CF5BD8FA4
	private static bool TryParse(string expression, ref T result) { }

	// RVA: 0x6CF696A6DC Offset: 0x19136DC VA: 0x6CF696A6DC
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class LightingSettings : Object
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF696AE5C Offset: 0x1913E5C VA: 0x6CF696AE5C
	internal void LightingSettingsDontStripMe() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Bounds : IEquatable`1, IFormattable
{
	// Fields

	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Properties

	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; }
	public Vector3 max { get; }

	// Methods

	// RVA: 0x6CF696AE60 Offset: 0x1913E60 VA: 0x6CF696AE60
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x6CF696AE80 Offset: 0x1913E80 VA: 0x6CF696AE80
	public override int GetHashCode() { }

	// RVA: 0x6CF696AF50 Offset: 0x1913F50 VA: 0x6CF696AF50
	public override bool Equals(object other) { }

	// RVA: 0x6CF696B020 Offset: 0x1914020 VA: 0x6CF696B020
	public bool Equals(Bounds other) { }

	// RVA: 0x6CF696B08C Offset: 0x191408C VA: 0x6CF696B08C
	public Vector3 get_center() { }

	// RVA: 0x6CF696B098 Offset: 0x1914098 VA: 0x6CF696B098
	public void set_center(Vector3 value) { }

	// RVA: 0x6CF696B0A4 Offset: 0x19140A4 VA: 0x6CF696B0A4
	public Vector3 get_size() { }

	// RVA: 0x6CF696B0BC Offset: 0x19140BC VA: 0x6CF696B0BC
	public void set_size(Vector3 value) { }

	// RVA: 0x6CF696B0D8 Offset: 0x19140D8 VA: 0x6CF696B0D8
	public Vector3 get_extents() { }

	// RVA: 0x6CF696B0E4 Offset: 0x19140E4 VA: 0x6CF696B0E4
	public void set_extents(Vector3 value) { }

	// RVA: 0x6CF696B0F0 Offset: 0x19140F0 VA: 0x6CF696B0F0
	public Vector3 get_min() { }

	// RVA: 0x6CF696B110 Offset: 0x1914110 VA: 0x6CF696B110
	public Vector3 get_max() { }

	// RVA: 0x6CF696B130 Offset: 0x1914130 VA: 0x6CF696B130
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x6CF696B1AC Offset: 0x19141AC VA: 0x6CF696B1AC
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x6CF696B228 Offset: 0x1914228 VA: 0x6CF696B228
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x6CF696B260 Offset: 0x1914260 VA: 0x6CF696B260
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x6CF696B2D8 Offset: 0x19142D8 VA: 0x6CF696B2D8
	public override string ToString() { }

	// RVA: 0x6CF696B2E8 Offset: 0x19142E8 VA: 0x6CF696B2E8
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct BoundsInt : IEquatable`1, IFormattable
{
	// Fields

	private Vector3Int m_Position; // 0x10
	private Vector3Int m_Size; // 0x1C

	// Properties

	public Vector3Int position { get; set; }
	public Vector3Int size { get; set; }

	// Methods

	// RVA: 0x6CF696B470 Offset: 0x1914470 VA: 0x6CF696B470
	public Vector3Int get_position() { }

	// RVA: 0x6CF696B480 Offset: 0x1914480 VA: 0x6CF696B480
	public void set_position(Vector3Int value) { }

	// RVA: 0x6CF696B48C Offset: 0x191448C VA: 0x6CF696B48C
	public Vector3Int get_size() { }

	// RVA: 0x6CF696B49C Offset: 0x191449C VA: 0x6CF696B49C
	public void set_size(Vector3Int value) { }

	// RVA: 0x6CF696B4A8 Offset: 0x19144A8 VA: 0x6CF696B4A8
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x6CF696B4BC Offset: 0x19144BC VA: 0x6CF696B4BC
	public override string ToString() { }

	// RVA: 0x6CF696B4CC Offset: 0x19144CC VA: 0x6CF696B4CC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x6CF696B628 Offset: 0x1914628 VA: 0x6CF696B628
	public override bool Equals(object other) { }

	// RVA: 0x6CF696B6FC Offset: 0x19146FC VA: 0x6CF696B6FC
	public bool Equals(BoundsInt other) { }

	// RVA: 0x6CF696B774 Offset: 0x1914774 VA: 0x6CF696B774
	public override int GetHashCode() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Plane : IFormattable
{
	// Fields

	private Vector3 m_Normal; // 0x10
	private float m_Distance; // 0x1C

	// Properties

	public Vector3 normal { get; }

	// Methods

	// RVA: 0x6CF696B848 Offset: 0x1914848 VA: 0x6CF696B848
	public Vector3 get_normal() { }

	// RVA: 0x6CF696B854 Offset: 0x1914854 VA: 0x6CF696B854
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x6CF696B964 Offset: 0x1914964 VA: 0x6CF696B964
	public bool Raycast(Ray ray, ref float enter) { }

	// RVA: 0x6CF696BA64 Offset: 0x1914A64 VA: 0x6CF696BA64
	public override string ToString() { }

	// RVA: 0x6CF696BA74 Offset: 0x1914A74 VA: 0x6CF696BA74
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Ray : IFormattable
{
	// Fields

	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Properties

	public Vector3 origin { get; }
	public Vector3 direction { get; }

	// Methods

	// RVA: 0x6CF696BBFC Offset: 0x1914BFC VA: 0x6CF696BBFC
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x6CF696BCE8 Offset: 0x1914CE8 VA: 0x6CF696BCE8
	public Vector3 get_origin() { }

	// RVA: 0x6CF696BCF4 Offset: 0x1914CF4 VA: 0x6CF696BCF4
	public Vector3 get_direction() { }

	// RVA: 0x6CF696BD00 Offset: 0x1914D00 VA: 0x6CF696BD00
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x6CF696BD28 Offset: 0x1914D28 VA: 0x6CF696BD28
	public override string ToString() { }

	// RVA: 0x6CF696BD38 Offset: 0x1914D38 VA: 0x6CF696BD38
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Rect : IEquatable`1, IFormattable
{
	// Fields

	private float m_XMin; // 0x10
	private float m_YMin; // 0x14
	private float m_Width; // 0x18
	private float m_Height; // 0x1C

	// Properties

	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x6CF696BEC0 Offset: 0x1914EC0 VA: 0x6CF696BEC0
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x6CF696BECC Offset: 0x1914ECC VA: 0x6CF696BECC
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x6CF696BED8 Offset: 0x1914ED8 VA: 0x6CF696BED8
	public void .ctor(Rect source) { }

	// RVA: 0x6CF696BEE4 Offset: 0x1914EE4 VA: 0x6CF696BEE4
	public static Rect get_zero() { }

	// RVA: 0x6CF696BEF8 Offset: 0x1914EF8 VA: 0x6CF696BEF8
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x6CF696BF04 Offset: 0x1914F04 VA: 0x6CF696BF04
	public float get_x() { }

	// RVA: 0x6CF696BF0C Offset: 0x1914F0C VA: 0x6CF696BF0C
	public void set_x(float value) { }

	// RVA: 0x6CF696BF14 Offset: 0x1914F14 VA: 0x6CF696BF14
	public float get_y() { }

	// RVA: 0x6CF696BF1C Offset: 0x1914F1C VA: 0x6CF696BF1C
	public void set_y(float value) { }

	// RVA: 0x6CF696BF24 Offset: 0x1914F24 VA: 0x6CF696BF24
	public Vector2 get_position() { }

	// RVA: 0x6CF696BF2C Offset: 0x1914F2C VA: 0x6CF696BF2C
	public void set_position(Vector2 value) { }

	// RVA: 0x6CF696BF34 Offset: 0x1914F34 VA: 0x6CF696BF34
	public Vector2 get_center() { }

	// RVA: 0x6CF696BF4C Offset: 0x1914F4C VA: 0x6CF696BF4C
	public void set_center(Vector2 value) { }

	// RVA: 0x6CF696BF68 Offset: 0x1914F68 VA: 0x6CF696BF68
	public Vector2 get_min() { }

	// RVA: 0x6CF696BF70 Offset: 0x1914F70 VA: 0x6CF696BF70
	public void set_min(Vector2 value) { }

	// RVA: 0x6CF696BF8C Offset: 0x1914F8C VA: 0x6CF696BF8C
	public Vector2 get_max() { }

	// RVA: 0x6CF696BF9C Offset: 0x1914F9C VA: 0x6CF696BF9C
	public void set_max(Vector2 value) { }

	// RVA: 0x6CF696BFB0 Offset: 0x1914FB0 VA: 0x6CF696BFB0
	public float get_width() { }

	// RVA: 0x6CF696BFB8 Offset: 0x1914FB8 VA: 0x6CF696BFB8
	public void set_width(float value) { }

	// RVA: 0x6CF696BFC0 Offset: 0x1914FC0 VA: 0x6CF696BFC0
	public float get_height() { }

	// RVA: 0x6CF696BFC8 Offset: 0x1914FC8 VA: 0x6CF696BFC8
	public void set_height(float value) { }

	// RVA: 0x6CF696BFD0 Offset: 0x1914FD0 VA: 0x6CF696BFD0
	public Vector2 get_size() { }

	// RVA: 0x6CF696BFD8 Offset: 0x1914FD8 VA: 0x6CF696BFD8
	public void set_size(Vector2 value) { }

	// RVA: 0x6CF696BFE0 Offset: 0x1914FE0 VA: 0x6CF696BFE0
	public float get_xMin() { }

	// RVA: 0x6CF696BFE8 Offset: 0x1914FE8 VA: 0x6CF696BFE8
	public void set_xMin(float value) { }

	// RVA: 0x6CF696C004 Offset: 0x1915004 VA: 0x6CF696C004
	public float get_yMin() { }

	// RVA: 0x6CF696C00C Offset: 0x191500C VA: 0x6CF696C00C
	public void set_yMin(float value) { }

	// RVA: 0x6CF696C028 Offset: 0x1915028 VA: 0x6CF696C028
	public float get_xMax() { }

	// RVA: 0x6CF696C038 Offset: 0x1915038 VA: 0x6CF696C038
	public void set_xMax(float value) { }

	// RVA: 0x6CF696C048 Offset: 0x1915048 VA: 0x6CF696C048
	public float get_yMax() { }

	// RVA: 0x6CF696C058 Offset: 0x1915058 VA: 0x6CF696C058
	public void set_yMax(float value) { }

	// RVA: 0x6CF696C068 Offset: 0x1915068 VA: 0x6CF696C068
	public bool Contains(Vector2 point) { }

	// RVA: 0x6CF696C0AC Offset: 0x19150AC VA: 0x6CF696C0AC
	public bool Contains(Vector3 point) { }

	// RVA: 0x6CF696C0F0 Offset: 0x19150F0 VA: 0x6CF696C0F0
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x6CF696C11C Offset: 0x191511C VA: 0x6CF696C11C
	public bool Overlaps(Rect other) { }

	// RVA: 0x6CF696C168 Offset: 0x1915168 VA: 0x6CF696C168
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x6CF696C1FC Offset: 0x19151FC VA: 0x6CF696C1FC
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x6CF696C230 Offset: 0x1915230 VA: 0x6CF696C230
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x6CF696C264 Offset: 0x1915264 VA: 0x6CF696C264
	public override int GetHashCode() { }

	// RVA: 0x6CF696C2EC Offset: 0x19152EC VA: 0x6CF696C2EC
	public override bool Equals(object other) { }

	// RVA: 0x6CF696C3D8 Offset: 0x19153D8 VA: 0x6CF696C3D8
	public bool Equals(Rect other) { }

	// RVA: 0x6CF696C478 Offset: 0x1915478 VA: 0x6CF696C478
	public override string ToString() { }

	// RVA: 0x6CF696C484 Offset: 0x1915484 VA: 0x6CF696C484
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct RectInt : IEquatable`1, IFormattable
{
	// Fields

	private int m_XMin; // 0x10
	private int m_YMin; // 0x14
	private int m_Width; // 0x18
	private int m_Height; // 0x1C

	// Properties

	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public int xMin { get; }
	public int yMin { get; }
	public int xMax { get; }
	public int yMax { get; }

	// Methods

	// RVA: 0x6CF696C6B8 Offset: 0x19156B8 VA: 0x6CF696C6B8
	public int get_x() { }

	// RVA: 0x6CF696C6C0 Offset: 0x19156C0 VA: 0x6CF696C6C0
	public void set_x(int value) { }

	// RVA: 0x6CF696C6C8 Offset: 0x19156C8 VA: 0x6CF696C6C8
	public int get_y() { }

	// RVA: 0x6CF696C6D0 Offset: 0x19156D0 VA: 0x6CF696C6D0
	public void set_y(int value) { }

	// RVA: 0x6CF696C6D8 Offset: 0x19156D8 VA: 0x6CF696C6D8
	public int get_width() { }

	// RVA: 0x6CF696C6E0 Offset: 0x19156E0 VA: 0x6CF696C6E0
	public void set_width(int value) { }

	// RVA: 0x6CF696C6E8 Offset: 0x19156E8 VA: 0x6CF696C6E8
	public int get_height() { }

	// RVA: 0x6CF696C6F0 Offset: 0x19156F0 VA: 0x6CF696C6F0
	public void set_height(int value) { }

	// RVA: 0x6CF696C6F8 Offset: 0x19156F8 VA: 0x6CF696C6F8
	public int get_xMin() { }

	// RVA: 0x6CF696C75C Offset: 0x191575C VA: 0x6CF696C75C
	public int get_yMin() { }

	// RVA: 0x6CF696C7C0 Offset: 0x19157C0 VA: 0x6CF696C7C0
	public int get_xMax() { }

	// RVA: 0x6CF696C824 Offset: 0x1915824 VA: 0x6CF696C824
	public int get_yMax() { }

	// RVA: 0x6CF696C888 Offset: 0x1915888 VA: 0x6CF696C888
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x6CF696C894 Offset: 0x1915894 VA: 0x6CF696C894
	public bool Overlaps(RectInt other) { }

	// RVA: 0x6CF696CB34 Offset: 0x1915B34 VA: 0x6CF696CB34
	public override string ToString() { }

	// RVA: 0x6CF696CB44 Offset: 0x1915B44 VA: 0x6CF696CB44
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x6CF696CD4C Offset: 0x1915D4C VA: 0x6CF696CD4C
	public bool Equals(RectInt other) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[Serializable]
public class RectOffset : Object, IFormattable
{
	// Fields

	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties

	public int left { get; set; }
	public int right { get; set; }
	public int top { get; set; }
	public int bottom { get; set; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x6CF696CD90 Offset: 0x1915D90 VA: 0x6CF696CD90
	public void .ctor() { }

	// RVA: 0x6CF696CE00 Offset: 0x1915E00 VA: 0x6CF696CE00
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x6CF696CE2C Offset: 0x1915E2C VA: 0x6CF696CE2C
	protected override void Finalize() { }

	// RVA: 0x6CF696CF28 Offset: 0x1915F28 VA: 0x6CF696CF28
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x6CF696D14C Offset: 0x191614C VA: 0x6CF696D14C
	public override string ToString() { }

	// RVA: 0x6CF696D15C Offset: 0x191615C VA: 0x6CF696D15C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x6CF696CECC Offset: 0x1915ECC VA: 0x6CF696CECC
	private void Destroy() { }

	// RVA: 0x6CF696CDD8 Offset: 0x1915DD8 VA: 0x6CF696CDD8
	private static IntPtr InternalCreate() { }

	// RVA: 0x6CF696D4E4 Offset: 0x19164E4 VA: 0x6CF696D4E4
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x6CF696D3F4 Offset: 0x19163F4 VA: 0x6CF696D3F4
	public int get_left() { }

	// RVA: 0x6CF696D03C Offset: 0x191603C VA: 0x6CF696D03C
	public void set_left(int value) { }

	// RVA: 0x6CF696D430 Offset: 0x1916430 VA: 0x6CF696D430
	public int get_right() { }

	// RVA: 0x6CF696D080 Offset: 0x1916080 VA: 0x6CF696D080
	public void set_right(int value) { }

	// RVA: 0x6CF696D46C Offset: 0x191646C VA: 0x6CF696D46C
	public int get_top() { }

	// RVA: 0x6CF696D0C4 Offset: 0x19160C4 VA: 0x6CF696D0C4
	public void set_top(int value) { }

	// RVA: 0x6CF696D4A8 Offset: 0x19164A8 VA: 0x6CF696D4A8
	public int get_bottom() { }

	// RVA: 0x6CF696D108 Offset: 0x1916108 VA: 0x6CF696D108
	public void set_bottom(int value) { }

	// RVA: 0x6CF696D520 Offset: 0x1916520 VA: 0x6CF696D520
	public int get_horizontal() { }

	// RVA: 0x6CF696D55C Offset: 0x191655C VA: 0x6CF696D55C
	public int get_vertical() { }

	// RVA: 0x6CF696D598 Offset: 0x1916598 VA: 0x6CF696D598
	public Rect Remove(Rect rect) { }

	// RVA: 0x6CF696D5FC Offset: 0x19165FC VA: 0x6CF696D5FC
	private void Remove_Injected(ref Rect rect, ref Rect ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Gizmos : Object
{
	// Fields


	// Properties

	public static Color color { set; }

	// Methods

	// RVA: 0x6CF696D650 Offset: 0x1916650 VA: 0x6CF696D650
	public static void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0x6CF696D6E4 Offset: 0x19166E4 VA: 0x6CF696D6E4
	public static void DrawWireSphere(Vector3 center, float radius) { }

	// RVA: 0x6CF696D784 Offset: 0x1916784 VA: 0x6CF696D784
	public static void DrawSphere(Vector3 center, float radius) { }

	// RVA: 0x6CF696D824 Offset: 0x1916824 VA: 0x6CF696D824
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0x6CF696D8B8 Offset: 0x19168B8 VA: 0x6CF696D8B8
	public static void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x6CF696D94C Offset: 0x191694C VA: 0x6CF696D94C
	public static void set_color(Color value) { }

	// RVA: 0x6CF696D6A0 Offset: 0x19166A0 VA: 0x6CF696D6A0
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x6CF696D738 Offset: 0x1916738 VA: 0x6CF696D738
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x6CF696D7D8 Offset: 0x19167D8 VA: 0x6CF696D7D8
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x6CF696D874 Offset: 0x1916874 VA: 0x6CF696D874
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x6CF696D908 Offset: 0x1916908 VA: 0x6CF696D908
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x6CF696D990 Offset: 0x1916990 VA: 0x6CF696D990
	private static void set_color_Injected(ref Color value) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
private struct OrderBlock
{
	// Fields

	internal int order; // 0x10
	internal UnityAction callback; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal static class BeforeRenderHelper : Object
{
	// Fields

	private static List`1 s_OrderBlocks; // 0x0

	// Properties


	// Methods

	// RVA: 0x6CF6964FD4 Offset: 0x190DFD4 VA: 0x6CF6964FD4
	public static void Invoke() { }

	// RVA: 0x6CF696D9CC Offset: 0x19169CC VA: 0x6CF696D9CC
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public static class CustomRenderTextureManager : Object
{
	// Fields

	private static Action`1 textureLoaded; // 0x0
	private static Action`1 textureUnloaded; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF696DA58 Offset: 0x1916A58 VA: 0x6CF696DA58
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	// RVA: 0x6CF696DAC4 Offset: 0x1916AC4 VA: 0x6CF696DAC4
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: 
public sealed class DisplaysUpdatedDelegate : MulticastDelegate
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF696E2E8 Offset: 0x19172E8 VA: 0x6CF696E2E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x6CF696E370 Offset: 0x1917370 VA: 0x6CF696E370
	public virtual void Invoke() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Display : Object
{
	// Fields

	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	private static DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties

	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x6CF696DB30 Offset: 0x1916B30 VA: 0x6CF696DB30
	internal void .ctor() { }

	// RVA: 0x6CF696DB6C Offset: 0x1916B6C VA: 0x6CF696DB6C
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x6CF696DB94 Offset: 0x1916B94 VA: 0x6CF696DB94
	public int get_renderingWidth() { }

	// RVA: 0x6CF696DC7C Offset: 0x1916C7C VA: 0x6CF696DC7C
	public int get_renderingHeight() { }

	// RVA: 0x6CF696DD10 Offset: 0x1916D10 VA: 0x6CF696DD10
	public int get_systemWidth() { }

	// RVA: 0x6CF696DDF8 Offset: 0x1916DF8 VA: 0x6CF696DDF8
	public int get_systemHeight() { }

	// RVA: 0x6CF696DE8C Offset: 0x1916E8C VA: 0x6CF696DE8C
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x6CF696DFA8 Offset: 0x1916FA8 VA: 0x6CF696DFA8
	public static Display get_main() { }

	// RVA: 0x6CF696E000 Offset: 0x1917000 VA: 0x6CF696E000
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0x6CF696E148 Offset: 0x1917148 VA: 0x6CF696E148
	internal static void FireDisplaysUpdated() { }

	// RVA: 0x6CF696DDA4 Offset: 0x1916DA4 VA: 0x6CF696DDA4
	private static void GetSystemExtImpl(IntPtr nativeDisplay, ref int w, ref int h) { }

	// RVA: 0x6CF696DC28 Offset: 0x1916C28 VA: 0x6CF696DC28
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, ref int w, ref int h) { }

	// RVA: 0x6CF696DF4C Offset: 0x1916F4C VA: 0x6CF696DF4C
	private static int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry) { }

	// RVA: 0x6CF696E1DC Offset: 0x19171DC VA: 0x6CF696E1DC
	private static void .cctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum FullScreenMode
{
	// Fields

	public int value__; // 0x10
	public const FullScreenMode ExclusiveFullScreen = 0; // 0x0
	public const FullScreenMode FullScreenWindow = 1; // 0x0
	public const FullScreenMode MaximizedWindow = 2; // 0x0
	public const FullScreenMode Windowed = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct RefreshRate : IEquatable`1, IComparable`1
{
	// Fields

	public uint numerator; // 0x10
	public uint denominator; // 0x14

	// Properties

	public double value { get; }

	// Methods

	// RVA: 0x6CF696E384 Offset: 0x1917384 VA: 0x6CF696E384
	public double get_value() { }

	// RVA: 0x6CF696E398 Offset: 0x1917398 VA: 0x6CF696E398
	public bool Equals(RefreshRate other) { }

	// RVA: 0x6CF696E3D4 Offset: 0x19173D4 VA: 0x6CF696E3D4
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x6CF696E424 Offset: 0x1917424 VA: 0x6CF696E424
	public override string ToString() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Screen : Object
{
	// Fields


	// Properties

	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static int sleepTimeout { set; }
	public static bool fullScreen { get; set; }

	// Methods

	// RVA: 0x6CF696E4C0 Offset: 0x19174C0 VA: 0x6CF696E4C0
	public static int get_width() { }

	// RVA: 0x6CF696E4E8 Offset: 0x19174E8 VA: 0x6CF696E4E8
	public static int get_height() { }

	// RVA: 0x6CF696E510 Offset: 0x1917510 VA: 0x6CF696E510
	public static float get_dpi() { }

	// RVA: 0x6CF696E538 Offset: 0x1917538 VA: 0x6CF696E538
	public static void set_sleepTimeout(int value) { }

	// RVA: 0x6CF696E574 Offset: 0x1917574 VA: 0x6CF696E574
	public static bool get_fullScreen() { }

	// RVA: 0x6CF696E59C Offset: 0x191759C VA: 0x6CF696E59C
	public static void set_fullScreen(bool value) { }

	// RVA: 0x6CF696E5D8 Offset: 0x19175D8 VA: 0x6CF696E5D8
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x6CF696E694 Offset: 0x1917694 VA: 0x6CF696E694
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x6CF696E704 Offset: 0x1917704 VA: 0x6CF696E704
	public static void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x6CF696E638 Offset: 0x1917638 VA: 0x6CF696E638
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct RenderBuffer
{
	// Fields

	internal int m_RenderTextureInstanceID; // 0x10
	internal IntPtr m_BufferPtr; // 0x18

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum ComputeBufferMode
{
	// Fields

	public int value__; // 0x10
	public const ComputeBufferMode Immutable = 0; // 0x0
	public const ComputeBufferMode Dynamic = 1; // 0x0
	public const ComputeBufferMode Circular = 2; // 0x0
	public const ComputeBufferMode StreamOut = 3; // 0x0
	public const ComputeBufferMode SubUpdates = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Graphics : Object
{
	// Fields

	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static Dictionary`2 s_RenderInstancedDataLayouts; // 0x8

	// Properties


	// Methods

	// RVA: 0x6CF696E770 Offset: 0x1917770 VA: 0x6CF696E770
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x6CF696E798 Offset: 0x1917798 VA: 0x6CF696E798
	private static void Internal_SetNullRT() { }

	// RVA: 0x6CF696E7C0 Offset: 0x19177C0 VA: 0x6CF696E7C0
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x6CF696E8D4 Offset: 0x19178D4 VA: 0x6CF696E8D4
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x6CF696E928 Offset: 0x1917928 VA: 0x6CF696E928
	public static void ClearRandomWriteTargets() { }

	// RVA: 0x6CF696E950 Offset: 0x1917950 VA: 0x6CF696E950
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x6CF696EA30 Offset: 0x1917A30 VA: 0x6CF696EA30
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	// RVA: 0x6CF696EA6C Offset: 0x1917A6C VA: 0x6CF696EA6C
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	// RVA: 0x6CF696EAC0 Offset: 0x1917AC0 VA: 0x6CF696EAC0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x6CF696EB2C Offset: 0x1917B2C VA: 0x6CF696EB2C
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	// RVA: 0x6CF696EB88 Offset: 0x1917B88 VA: 0x6CF696EB88
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x6CF696EBCC Offset: 0x1917BCC VA: 0x6CF696EBCC
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x6CF696EC68 Offset: 0x1917C68 VA: 0x6CF696EC68
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x6CF696ED9C Offset: 0x1917D9C VA: 0x6CF696ED9C
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x6CF696EE18 Offset: 0x1917E18 VA: 0x6CF696EE18
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x6CF696EFD8 Offset: 0x1917FD8 VA: 0x6CF696EFD8
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x6CF696F0F0 Offset: 0x19180F0 VA: 0x6CF696F0F0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x6CF696F184 Offset: 0x1918184 VA: 0x6CF696F184
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	// RVA: 0x6CF696F29C Offset: 0x191829C VA: 0x6CF696F29C
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x6CF696F320 Offset: 0x1918320 VA: 0x6CF696F320
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x6CF696F3C0 Offset: 0x19183C0 VA: 0x6CF696F3C0
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x6CF696F430 Offset: 0x1918430 VA: 0x6CF696F430
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	// RVA: 0x6CF696F530 Offset: 0x1918530 VA: 0x6CF696F530
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x6CF696F590 Offset: 0x1918590 VA: 0x6CF696F590
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x6CF696F5F8 Offset: 0x19185F8 VA: 0x6CF696F5F8
	private static void .cctor() { }

	// RVA: 0x6CF696E868 Offset: 0x1917868 VA: 0x6CF696E868
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x6CF696E9DC Offset: 0x19179DC VA: 0x6CF696E9DC
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class GL : Object
{
	// Fields


	// Properties

	public static bool invertCulling { set; }
	public static Matrix4x4 modelview { set; }

	// Methods

	// RVA: 0x6CF696F6B4 Offset: 0x19186B4 VA: 0x6CF696F6B4
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x6CF696F704 Offset: 0x1918704 VA: 0x6CF696F704
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x6CF696F754 Offset: 0x1918754 VA: 0x6CF696F754
	public static void TexCoord2(float x, float y) { }

	// RVA: 0x6CF696F798 Offset: 0x1918798 VA: 0x6CF696F798
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x6CF696F7FC Offset: 0x19187FC VA: 0x6CF696F7FC
	public static void MultiTexCoord2(int unit, float x, float y) { }

	// RVA: 0x6CF696F854 Offset: 0x1918854 VA: 0x6CF696F854
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x6CF696F8AC Offset: 0x19188AC VA: 0x6CF696F8AC
	public static void Color(Color c) { }

	// RVA: 0x6CF696F904 Offset: 0x1918904 VA: 0x6CF696F904
	public static void set_invertCulling(bool value) { }

	// RVA: 0x6CF696F940 Offset: 0x1918940 VA: 0x6CF696F940
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x6CF696F9B8 Offset: 0x19189B8 VA: 0x6CF696F9B8
	public static void set_modelview(Matrix4x4 value) { }

	// RVA: 0x6CF696FA04 Offset: 0x1918A04 VA: 0x6CF696FA04
	public static void PushMatrix() { }

	// RVA: 0x6CF696FA2C Offset: 0x1918A2C VA: 0x6CF696FA2C
	public static void PopMatrix() { }

	// RVA: 0x6CF696FA54 Offset: 0x1918A54 VA: 0x6CF696FA54
	public static void LoadIdentity() { }

	// RVA: 0x6CF696FA7C Offset: 0x1918A7C VA: 0x6CF696FA7C
	public static void LoadOrtho() { }

	// RVA: 0x6CF696FAA4 Offset: 0x1918AA4 VA: 0x6CF696FAA4
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	// RVA: 0x6CF696FB1C Offset: 0x1918B1C VA: 0x6CF696FB1C
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x6CF696FBEC Offset: 0x1918BEC VA: 0x6CF696FBEC
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x6CF696FC44 Offset: 0x1918C44 VA: 0x6CF696FC44
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	// RVA: 0x6CF696FC9C Offset: 0x1918C9C VA: 0x6CF696FC9C
	public static void Begin(int mode) { }

	// RVA: 0x6CF696FCD8 Offset: 0x1918CD8 VA: 0x6CF696FCD8
	public static void End() { }

	// RVA: 0x6CF696FD00 Offset: 0x1918D00 VA: 0x6CF696FD00
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x6CF696FDD0 Offset: 0x1918DD0 VA: 0x6CF696FDD0
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x6CF696FDDC Offset: 0x1918DDC VA: 0x6CF696FDDC
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x6CF696FDEC Offset: 0x1918DEC VA: 0x6CF696FDEC
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x6CF696FE6C Offset: 0x1918E6C VA: 0x6CF696FE6C
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x6CF696F97C Offset: 0x191897C VA: 0x6CF696F97C
	private static void SetViewMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x6CF696FAE0 Offset: 0x1918AE0 VA: 0x6CF696FAE0
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x6CF696FB98 Offset: 0x1918B98 VA: 0x6CF696FB98
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, ref Matrix4x4 ret) { }

	// RVA: 0x6CF696FD6C Offset: 0x1918D6C VA: 0x6CF696FD6C
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x6CF696FE30 Offset: 0x1918E30 VA: 0x6CF696FE30
	private static void Viewport_Injected(ref Rect pixelRect) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class LightmapSettings : Object
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class LightProbes : Object
{
	// Fields

	private static Action lightProbesUpdated; // 0x0
	private static Action tetrahedralizationCompleted; // 0x8
	private static Action needsRetetrahedralization; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF696FEB0 Offset: 0x1918EB0 VA: 0x6CF696FEB0
	private static void Internal_CallLightProbesUpdatedFunction() { }

	// RVA: 0x6CF696FF14 Offset: 0x1918F14 VA: 0x6CF696FF14
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0x6CF696FF78 Offset: 0x1918F78 VA: 0x6CF696FF78
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct Resolution
{
	// Fields

	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private RefreshRate m_RefreshRate; // 0x18

	// Properties

	public int width { get; }
	public int height { get; }

	// Methods

	// RVA: 0x6CF696FFDC Offset: 0x1918FDC VA: 0x6CF696FFDC
	public int get_width() { }

	// RVA: 0x6CF696FFE4 Offset: 0x1918FE4 VA: 0x6CF696FFE4
	public int get_height() { }

	// RVA: 0x6CF696FFEC Offset: 0x1918FEC VA: 0x6CF696FFEC
	public override string ToString() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal struct RenderInstancedDataLayout
{
	// Fields

	private readonly int <size>k__BackingField; // 0x10
	private readonly int <offsetObjectToWorld>k__BackingField; // 0x14
	private readonly int <offsetPrevObjectToWorld>k__BackingField; // 0x18
	private readonly int <offsetRenderingLayerMask>k__BackingField; // 0x1C

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal struct Internal_DrawTextureArguments
{
	// Fields

	public Rect screenRect; // 0x10
	public Rect sourceRect; // 0x20
	public int leftBorder; // 0x30
	public int rightBorder; // 0x34
	public int topBorder; // 0x38
	public int bottomBorder; // 0x3C
	public Color leftBorderColor; // 0x40
	public Color rightBorderColor; // 0x50
	public Color topBorderColor; // 0x60
	public Color bottomBorderColor; // 0x70
	public Color color; // 0x80
	public Vector4 borderWidths; // 0x90
	public Vector4 cornerRadiuses; // 0xA0
	public bool smoothCorners; // 0xB0
	public int pass; // 0xB4
	public Texture texture; // 0xB8
	public Material mat; // 0xC0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class QualitySettings : Object
{
	// Fields

	private static Action`2 activeQualityLevelChanged; // 0x0

	// Properties

	public static int pixelLightCount { get; set; }
	public static float shadowDistance { set; }
	public static String[] names { get; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0x6CF697016C Offset: 0x191916C VA: 0x6CF697016C
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x6CF69701EC Offset: 0x19191EC VA: 0x6CF69701EC
	public static void SetQualityLevel(int index) { }

	// RVA: 0x6CF6970270 Offset: 0x1919270 VA: 0x6CF6970270
	public static int get_pixelLightCount() { }

	// RVA: 0x6CF6970298 Offset: 0x1919298 VA: 0x6CF6970298
	public static void set_pixelLightCount(int value) { }

	// RVA: 0x6CF69702D4 Offset: 0x19192D4 VA: 0x6CF69702D4
	public static void set_shadowDistance(float value) { }

	// RVA: 0x6CF697022C Offset: 0x191922C VA: 0x6CF697022C
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	// RVA: 0x6CF697030C Offset: 0x191930C VA: 0x6CF697030C
	public static String[] get_names() { }

	// RVA: 0x6CF6970334 Offset: 0x1919334 VA: 0x6CF6970334
	public static ColorSpace get_activeColorSpace() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class ImageEffectTransformsToLDR : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF697035C Offset: 0x191935C VA: 0x6CF697035C
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class ImageEffectOpaque : Attribute
{
	// Fields


	// Properties


	// Methods

	// RVA: 0x6CF6970364 Offset: 0x1919364 VA: 0x6CF6970364
	public void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class TrailRenderer : Renderer
{
	// Fields


	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class MaterialPropertyBlock : Object
{
	// Fields

	internal IntPtr m_Ptr; // 0x10

	// Properties


	// Methods

	// RVA: 0x6CF697036C Offset: 0x191936C VA: 0x6CF697036C
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x6CF69703C0 Offset: 0x19193C0 VA: 0x6CF69703C0
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x6CF697041C Offset: 0x191941C VA: 0x6CF697041C
	private static IntPtr CreateImpl() { }

	// RVA: 0x6CF6970444 Offset: 0x1919444 VA: 0x6CF6970444
	private static void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x6CF6970480 Offset: 0x1919480 VA: 0x6CF6970480
	private void Clear(bool keepMemory) { }

	// RVA: 0x6CF69704C4 Offset: 0x19194C4 VA: 0x6CF69704C4
	public void Clear() { }

	// RVA: 0x6CF6970504 Offset: 0x1919504 VA: 0x6CF6970504
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x6CF6970610 Offset: 0x1919610 VA: 0x6CF6970610
	public void .ctor() { }

	// RVA: 0x6CF6970658 Offset: 0x1919658 VA: 0x6CF6970658
	protected override void Finalize() { }

	// RVA: 0x6CF69706EC Offset: 0x19196EC VA: 0x6CF69706EC
	private void Dispose() { }

	// RVA: 0x6CF6970790 Offset: 0x1919790 VA: 0x6CF6970790
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x6CF69707E4 Offset: 0x19197E4 VA: 0x6CF69707E4
	public void SetVectorArray(int nameID, Vector4[] values) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Renderer : Component
{
	// Fields


	// Properties

	public bool enabled { get; set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public bool receiveShadows { set; }
	public int sortingLayerID { get; }
	public int sortingOrder { get; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; }

	// Methods

	// RVA: 0x6CF69707FC Offset: 0x19197FC VA: 0x6CF69707FC
	private Material GetMaterial() { }

	// RVA: 0x6CF6970838 Offset: 0x1919838 VA: 0x6CF6970838
	private Material GetSharedMaterial() { }

	// RVA: 0x6CF6970874 Offset: 0x1919874 VA: 0x6CF6970874
	private void SetMaterial(Material m) { }

	// RVA: 0x6CF69708B8 Offset: 0x19198B8 VA: 0x6CF69708B8
	private Material[] GetMaterialArray() { }

	// RVA: 0x6CF69708F4 Offset: 0x19198F4 VA: 0x6CF69708F4
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x6CF6970948 Offset: 0x1919948 VA: 0x6CF6970948
	private void SetMaterialArray(Material[] m) { }

	// RVA: 0x6CF69709B0 Offset: 0x19199B0 VA: 0x6CF69709B0
	public bool get_enabled() { }

	// RVA: 0x6CF69709EC Offset: 0x19199EC VA: 0x6CF69709EC
	public void set_enabled(bool value) { }

	// RVA: 0x6CF6970A30 Offset: 0x1919A30 VA: 0x6CF6970A30
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x6CF6970A74 Offset: 0x1919A74 VA: 0x6CF6970A74
	public void set_receiveShadows(bool value) { }

	// RVA: 0x6CF6970AB8 Offset: 0x1919AB8 VA: 0x6CF6970AB8
	public int get_sortingLayerID() { }

	// RVA: 0x6CF6970AF4 Offset: 0x1919AF4 VA: 0x6CF6970AF4
	public int get_sortingOrder() { }

	// RVA: 0x6CF6970B30 Offset: 0x1919B30 VA: 0x6CF6970B30
	internal int get_sortingGroupID() { }

	// RVA: 0x6CF6970B6C Offset: 0x1919B6C VA: 0x6CF6970B6C
	internal int get_sortingGroupOrder() { }

	// RVA: 0x6CF6970BA8 Offset: 0x1919BA8 VA: 0x6CF6970BA8
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x6CF6970BE4 Offset: 0x1919BE4 VA: 0x6CF6970BE4
	public Material[] get_materials() { }

	// RVA: 0x6CF6970C20 Offset: 0x1919C20 VA: 0x6CF6970C20
	public void set_materials(Material[] value) { }

	// RVA: 0x6CF6970C24 Offset: 0x1919C24 VA: 0x6CF6970C24
	public Material get_material() { }

	// RVA: 0x6CF6970C60 Offset: 0x1919C60 VA: 0x6CF6970C60
	public void set_material(Material value) { }

	// RVA: 0x6CF6970CA4 Offset: 0x1919CA4 VA: 0x6CF6970CA4
	public Material get_sharedMaterial() { }

	// RVA: 0x6CF6970CE0 Offset: 0x1919CE0 VA: 0x6CF6970CE0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x6CF6970D24 Offset: 0x1919D24 VA: 0x6CF6970D24
	public Material[] get_sharedMaterials() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class RenderSettings : Object
{
	// Fields


	// Properties

	public static float fogStartDistance { get; }
	public static float fogEndDistance { get; }
	public static FogMode fogMode { get; }
	public static float fogDensity { get; }

	// Methods

	// RVA: 0x6CF6970D60 Offset: 0x1919D60 VA: 0x6CF6970D60
	public static float get_fogStartDistance() { }

	// RVA: 0x6CF6970D88 Offset: 0x1919D88 VA: 0x6CF6970D88
	public static float get_fogEndDistance() { }

	// RVA: 0x6CF6970DB0 Offset: 0x1919DB0 VA: 0x6CF6970DB0
	public static FogMode get_fogMode() { }

	// RVA: 0x6CF6970DD8 Offset: 0x1919DD8 VA: 0x6CF6970DD8
	public static float get_fogDensity() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Shader : Object
{
	// Fields


	// Properties

	public int maximumLOD { set; }
	public bool isSupported { get; }

	// Methods

	// RVA: 0x6CF6970E00 Offset: 0x1919E00 VA: 0x6CF6970E00
	public static Shader Find(string name) { }

	// RVA: 0x6CF6970E6C Offset: 0x1919E6C VA: 0x6CF6970E6C
	public void set_maximumLOD(int value) { }

	// RVA: 0x6CF6970EB0 Offset: 0x1919EB0 VA: 0x6CF6970EB0
	public bool get_isSupported() { }

	// RVA: 0x6CF6970EEC Offset: 0x1919EEC VA: 0x6CF6970EEC
	public static void EnableKeyword(string keyword) { }

	// RVA: 0x6CF6970F28 Offset: 0x1919F28 VA: 0x6CF6970F28
	public static void DisableKeyword(string keyword) { }

	// RVA: 0x6CF6970F64 Offset: 0x1919F64 VA: 0x6CF6970F64
	internal static int TagToID(string name) { }

	// RVA: 0x6CF6970FA0 Offset: 0x1919FA0 VA: 0x6CF6970FA0
	public static int PropertyToID(string name) { }

	// RVA: 0x6CF6970FDC Offset: 0x1919FDC VA: 0x6CF6970FDC
	private void .ctor() { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Material : Object
{
	// Fields


	// Properties

	public Shader shader { get; set; }
	public Color color { set; }
	public Texture mainTexture { get; set; }
	public int passCount { get; }
	public String[] shaderKeywords { get; set; }

	// Methods

	// RVA: 0x6CF6971034 Offset: 0x191A034 VA: 0x6CF6971034
	private static void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0x6CF6971078 Offset: 0x191A078 VA: 0x6CF6971078
	private static void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0x6CF69710BC Offset: 0x191A0BC VA: 0x6CF69710BC
	private static void CreateWithString(Material self) { }

	// RVA: 0x6CF69710F8 Offset: 0x191A0F8 VA: 0x6CF69710F8
	public void .ctor(Shader shader) { }

	// RVA: 0x6CF6971188 Offset: 0x191A188 VA: 0x6CF6971188
	public void .ctor(Material source) { }

	// RVA: 0x6CF6971218 Offset: 0x191A218 VA: 0x6CF6971218
	public void .ctor(string contents) { }

	// RVA: 0x6CF6971298 Offset: 0x191A298 VA: 0x6CF6971298
	public Shader get_shader() { }

	// RVA: 0x6CF69712D4 Offset: 0x191A2D4 VA: 0x6CF69712D4
	public void set_shader(Shader value) { }

	// RVA: 0x6CF6971318 Offset: 0x191A318 VA: 0x6CF6971318
	public void set_color(Color value) { }

	// RVA: 0x6CF69714B0 Offset: 0x191A4B0 VA: 0x6CF69714B0
	public Texture get_mainTexture() { }

	// RVA: 0x6CF6971614 Offset: 0x191A614 VA: 0x6CF6971614
	public void set_mainTexture(Texture value) { }

	// RVA: 0x6CF69713EC Offset: 0x191A3EC VA: 0x6CF69713EC
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x6CF69717B0 Offset: 0x191A7B0 VA: 0x6CF69717B0
	public bool HasProperty(int nameID) { }

	// RVA: 0x6CF69717F4 Offset: 0x191A7F4 VA: 0x6CF69717F4
	public bool HasProperty(string name) { }

	// RVA: 0x6CF6971864 Offset: 0x191A864 VA: 0x6CF6971864
	public void EnableKeyword(string keyword) { }

	// RVA: 0x6CF69718A8 Offset: 0x191A8A8 VA: 0x6CF69718A8
	public void DisableKeyword(string keyword) { }

	// RVA: 0x6CF69718EC Offset: 0x191A8EC VA: 0x6CF69718EC
	public int get_passCount() { }

	// RVA: 0x6CF6971928 Offset: 0x191A928 VA: 0x6CF6971928
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x6CF6971984 Offset: 0x191A984 VA: 0x6CF6971984
	public string GetTag(string tag, bool searchFallbacks) { }

	// RVA: 0x6CF6971A0C Offset: 0x191AA0C VA: 0x6CF6971A0C
	public bool SetPass(int pass) { }

	// RVA: 0x6CF6971A50 Offset: 0x191AA50 VA: 0x6CF6971A50
	public void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0x6CF6971A94 Offset: 0x191AA94 VA: 0x6CF6971A94
	private String[] GetShaderKeywords() { }

	// RVA: 0x6CF6971AD0 Offset: 0x191AAD0 VA: 0x6CF6971AD0
	private void SetShaderKeywords(String[] names) { }

	// RVA: 0x6CF6971B14 Offset: 0x191AB14 VA: 0x6CF6971B14
	public String[] get_shaderKeywords() { }

	// RVA: 0x6CF6971B50 Offset: 0x191AB50 VA: 0x6CF6971B50
	public void set_shaderKeywords(String[] value) { }

	// RVA: 0x6CF6971B94 Offset: 0x191AB94 VA: 0x6CF6971B94
	public int ComputeCRC() { }

	// RVA: 0x6CF6971BD0 Offset: 0x191ABD0 VA: 0x6CF6971BD0
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x6CF6971C24 Offset: 0x191AC24 VA: 0x6CF6971C24
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x6CF6971CD4 Offset: 0x191ACD4 VA: 0x6CF6971CD4
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x6CF6971D7C Offset: 0x191AD7C VA: 0x6CF6971D7C
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x6CF6971DD0 Offset: 0x191ADD0 VA: 0x6CF6971DD0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	// RVA: 0x6CF6971E24 Offset: 0x191AE24 VA: 0x6CF6971E24
	private float GetFloatImpl(int name) { }

	// RVA: 0x6CF6971E68 Offset: 0x191AE68 VA: 0x6CF6971E68
	private Color GetColorImpl(int name) { }

	// RVA: 0x6CF6971F1C Offset: 0x191AF1C VA: 0x6CF6971F1C
	private Texture GetTextureImpl(int name) { }

	// RVA: 0x6CF6971F60 Offset: 0x191AF60 VA: 0x6CF6971F60
	public void SetFloat(string name, float value) { }

	// RVA: 0x6CF6971FE0 Offset: 0x191AFE0 VA: 0x6CF6971FE0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x6CF6971434 Offset: 0x191A434 VA: 0x6CF6971434
	public void SetColor(string name, Color value) { }

	// RVA: 0x6CF6971430 Offset: 0x191A430 VA: 0x6CF6971430
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x6CF6972034 Offset: 0x191B034 VA: 0x6CF6972034
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x6CF69720B0 Offset: 0x191B0B0 VA: 0x6CF69720B0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x6CF6971730 Offset: 0x191A730 VA: 0x6CF6971730
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x6CF69716DC Offset: 0x191A6DC VA: 0x6CF69716DC
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x6CF697214C Offset: 0x191B14C VA: 0x6CF697214C
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x6CF69721CC Offset: 0x191B1CC VA: 0x6CF69721CC
	public float GetFloat(string name) { }

	// RVA: 0x6CF697223C Offset: 0x191B23C VA: 0x6CF697223C
	public float GetFloat(int nameID) { }

	// RVA: 0x6CF6972280 Offset: 0x191B280 VA: 0x6CF6972280
	public Vector4 GetVector(string name) { }

	// RVA: 0x6CF69715A4 Offset: 0x191A5A4 VA: 0x6CF69715A4
	public Texture GetTexture(string name) { }

	// RVA: 0x6CF6971560 Offset: 0x191A560 VA: 0x6CF6971560
	public Texture GetTexture(int nameID) { }

	// RVA: 0x6CF6971C80 Offset: 0x191AC80 VA: 0x6CF6971C80
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x6CF6971D28 Offset: 0x191AD28 VA: 0x6CF6971D28
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x6CF6971EC8 Offset: 0x191AEC8 VA: 0x6CF6971EC8
	private void GetColorImpl_Injected(int name, ref Color ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct LightBakingOutput
{
	// Fields

	public int probeOcclusionLightIndex; // 0x10
	public int occlusionMaskChannel; // 0x14
	public LightmapBakeType lightmapBakeType; // 0x18
	public MixedLightingMode mixedLightingMode; // 0x1C
	public bool isBaked; // 0x20

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Light : Behaviour
{
	// Fields

	private int m_BakedIndex; // 0x18

	// Properties

	public LightType type { get; }
	public float spotAngle { get; }
	public Color color { get; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; set; }
	public float bounceIntensity { get; }
	public float shadowBias { set; }
	public float range { get; }
	public LightBakingOutput bakingOutput { get; }
	public LightShadows shadows { get; }
	public float shadowStrength { get; set; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x6CF69722CC Offset: 0x191B2CC VA: 0x6CF69722CC
	public LightType get_type() { }

	// RVA: 0x6CF6972308 Offset: 0x191B308 VA: 0x6CF6972308
	public float get_spotAngle() { }

	// RVA: 0x6CF6972344 Offset: 0x191B344 VA: 0x6CF6972344
	public Color get_color() { }

	// RVA: 0x6CF69723E0 Offset: 0x191B3E0 VA: 0x6CF69723E0
	public float get_colorTemperature() { }

	// RVA: 0x6CF697241C Offset: 0x191B41C VA: 0x6CF697241C
	public bool get_useColorTemperature() { }

	// RVA: 0x6CF6972458 Offset: 0x191B458 VA: 0x6CF6972458
	public float get_intensity() { }

	// RVA: 0x6CF6972494 Offset: 0x191B494 VA: 0x6CF6972494
	public void set_intensity(float value) { }

	// RVA: 0x6CF69724E0 Offset: 0x191B4E0 VA: 0x6CF69724E0
	public float get_bounceIntensity() { }

	// RVA: 0x6CF697251C Offset: 0x191B51C VA: 0x6CF697251C
	public void set_shadowBias(float value) { }

	// RVA: 0x6CF6972568 Offset: 0x191B568 VA: 0x6CF6972568
	public float get_range() { }

	// RVA: 0x6CF69725A4 Offset: 0x191B5A4 VA: 0x6CF69725A4
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x6CF6972650 Offset: 0x191B650 VA: 0x6CF6972650
	public LightShadows get_shadows() { }

	// RVA: 0x6CF697268C Offset: 0x191B68C VA: 0x6CF697268C
	public float get_shadowStrength() { }

	// RVA: 0x6CF69726C8 Offset: 0x191B6C8 VA: 0x6CF69726C8
	public void set_shadowStrength(float value) { }

	// RVA: 0x6CF6972714 Offset: 0x191B714 VA: 0x6CF6972714
	public float get_cookieSize() { }

	// RVA: 0x6CF6972750 Offset: 0x191B750 VA: 0x6CF6972750
	public Texture get_cookie() { }

	// RVA: 0x6CF697239C Offset: 0x191B39C VA: 0x6CF697239C
	private void get_color_Injected(ref Color ret) { }

	// RVA: 0x6CF697260C Offset: 0x191B60C VA: 0x6CF697260C
	private void get_bakingOutput_Injected(ref LightBakingOutput ret) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class Skybox : Behaviour
{
	// Fields


	// Properties

	public Material material { get; set; }

	// Methods

	// RVA: 0x6CF697278C Offset: 0x191B78C VA: 0x6CF697278C
	public Material get_material() { }

	// RVA: 0x6CF69727C8 Offset: 0x191B7C8 VA: 0x6CF69727C8
	public void set_material(Material value) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class MeshFilter : Component
{
	// Fields


	// Properties

	public Mesh sharedMesh { get; set; }

	// Methods

	// RVA: 0x6CF697280C Offset: 0x191B80C VA: 0x6CF697280C
	private void DontStripMeshFilter() { }

	// RVA: 0x6CF6972810 Offset: 0x191B810 VA: 0x6CF6972810
	public Mesh get_sharedMesh() { }

	// RVA: 0x6CF697284C Offset: 0x191B84C VA: 0x6CF697284C
	public void set_sharedMesh(Mesh value) { }

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum RenderingPath
{
	// Fields

	public int value__; // 0x10
	public const RenderingPath UsePlayerSettings = 4294967295; // 0x0
	public const RenderingPath VertexLit = 0; // 0x0
	public const RenderingPath Forward = 1; // 0x0
	public const RenderingPath DeferredLighting = 2; // 0x0
	public const RenderingPath DeferredShading = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum ComputeBufferType
{
	// Fields

	public int value__; // 0x10
	public const ComputeBufferType Default = 0; // 0x0
	public const ComputeBufferType Raw = 1; // 0x0
	public const ComputeBufferType Append = 2; // 0x0
	public const ComputeBufferType Counter = 4; // 0x0
	public const ComputeBufferType Constant = 8; // 0x0
	public const ComputeBufferType Structured = 16; // 0x0
	public const ComputeBufferType DrawIndirect = 256; // 0x0
	public const ComputeBufferType IndirectArguments = 256; // 0x0
	public const ComputeBufferType GPUMemory = 512; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum LightType
{
	// Fields

	public int value__; // 0x10
	public const LightType Spot = 0; // 0x0
	public const LightType Directional = 1; // 0x0
	public const LightType Point = 2; // 0x0
	public const LightType Area = 3; // 0x0
	public const LightType Rectangle = 3; // 0x0
	public const LightType Disc = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum LightShadows
{
	// Fields

	public int value__; // 0x10
	public const LightShadows None = 0; // 0x0
	public const LightShadows Hard = 1; // 0x0
	public const LightShadows Soft = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum FogMode
{
	// Fields

	public int value__; // 0x10
	public const FogMode Linear = 1; // 0x0
	public const FogMode Exponential = 2; // 0x0
	public const FogMode ExponentialSquared = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum LightmapBakeType
{
	// Fields

	public int value__; // 0x10
	public const LightmapBakeType Realtime = 4; // 0x0
	public const LightmapBakeType Baked = 2; // 0x0
	public const LightmapBakeType Mixed = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum MixedLightingMode
{
	// Fields

	public int value__; // 0x10
	public const MixedLightingMode IndirectOnly = 0; // 0x0
	public const MixedLightingMode Shadowmask = 2; // 0x0
	public const MixedLightingMode Subtractive = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum CameraClearFlags
{
	// Fields

	public int value__; // 0x10
	public const CameraClearFlags Skybox = 1; // 0x0
	public const CameraClearFlags Color = 2; // 0x0
	public const CameraClearFlags SolidColor = 2; // 0x0
	public const CameraClearFlags Depth = 3; // 0x0
	public const CameraClearFlags Nothing = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum DepthTextureMode
{
	// Fields

	public int value__; // 0x10
	public const DepthTextureMode None = 0; // 0x0
	public const DepthTextureMode Depth = 1; // 0x0
	public const DepthTextureMode DepthNormals = 2; // 0x0
	public const DepthTextureMode MotionVectors = 4; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum MeshTopology
{
	// Fields

	public int value__; // 0x10
	public const MeshTopology Triangles = 0; // 0x0
	public const MeshTopology Quads = 2; // 0x0
	public const MeshTopology Lines = 3; // 0x0
	public const MeshTopology LineStrip = 4; // 0x0
	public const MeshTopology Points = 5; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum ColorSpace
{
	// Fields

	public int value__; // 0x10
	public const ColorSpace Uninitialized = 4294967295; // 0x0
	public const ColorSpace Gamma = 0; // 0x0
	public const ColorSpace Linear = 1; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum FilterMode
{
	// Fields

	public int value__; // 0x10
	public const FilterMode Point = 0; // 0x0
	public const FilterMode Bilinear = 1; // 0x0
	public const FilterMode Trilinear = 2; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum TextureWrapMode
{
	// Fields

	public int value__; // 0x10
	public const TextureWrapMode Repeat = 0; // 0x0
	public const TextureWrapMode Clamp = 1; // 0x0
	public const TextureWrapMode Mirror = 2; // 0x0
	public const TextureWrapMode MirrorOnce = 3; // 0x0

	// Properties


	// Methods

}

// Dll : UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum TextureFormat
{
	// Fields

	public int value__; // 0x10
	public const TextureFormat Alpha8 = 1; // 0x0
	public const TextureFormat ARGB4444 = 2; // 0x0
	public const TextureFormat RGB24 = 3; // 0x0
	public const TextureFormat RGBA32 = 4; // 0x0
	public const TextureFormat ARGB32 = 5; // 0x0
	public const TextureFormat RGB565 = 7; // 0x0
	public const TextureFormat R16 = 9; // 0x0
	public const TextureFormat DXT1 = 10; // 0x0
	public const TextureFormat DXT5 = 12; // 0x0
	public const TextureFormat RGBA4444 = 13; // 0x0
	public const TextureFormat BGRA32 = 14; // 0x0
	public const TextureFormat RHalf = 15; // 0x0
	public const TextureFormat RGHalf = 16; // 0x0
	public const TextureFormat RGBAHalf = 17; // 0x0
	public const TextureFormat RFloat = 18; // 0x0
	public const TextureFormat RGFloat = 19; // 0x0
	public const TextureFormat RGBAFloat = 20; // 0x0
	public const TextureFormat YUY2 = 21; // 0x0
	public const TextureFormat RGB9e5Float = 22; // 0x0
	public const TextureFormat BC4 = 26; // 0x0
	public const TextureFormat BC5 = 27; // 0x0
	public const TextureFormat BC6H = 24; // 0x0
	public const TextureFormat BC7 = 25; // 0x0
	public const TextureFormat DXT1Crunched = 28; // 0x0
	public const TextureFormat DXT5Crunched = 29; // 0x0
	public const TextureFormat PVRTC_RGB2 = 30; // 0x0
	public const TextureFormat PVRTC_RGBA2 = 31; // 0x0
	public const TextureFormat PVRTC_RGB4 = 32; // 0x0
	public const TextureFormat PVRTC_RGBA4 = 33; // 0x0
	public const TextureFormat ETC_RGB4 = 34; // 0x0
	public const TextureFormat EAC_R = 41; // 0x0
	public const TextureFormat EAC_R_SIGNED = 42; // 0x0
	public const TextureFormat EAC_RG = 43; // 0x0
	public const TextureFormat EAC_RG_SIGNED = 44; // 0x0
	public const TextureFormat ETC2_RGB = 45; // 0x0
	public const TextureFormat ETC2_RGBA1 = 46; // 0x0
	public const TextureFormat ETC2_RGBA8 = 47; // 0x0
	public const TextureFormat ASTC_4x4 = 48; // 0x0
	public const TextureFormat ASTC_5x5 = 49; // 0x0
	public const TextureFormat ASTC_6x6 = 50; // 0x0
	public const TextureFormat ASTC_8x8 = 51; // 0x0
	public const TextureFormat ASTC_10x10 = 52; // 0x0
	public const TextureFormat ASTC_12x12 = 53; // 0x0
	public const TextureFormat ETC_RGB4_3DS = 60; /