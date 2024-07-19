using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

public static class OVRTask
{
	private class MultiTaskData<T> : OVRObjectPool.IPoolObject
	{
		protected OVRTask<T> CombinedTask;

		protected T Result;

		protected HashSet<Guid> Remaining;

		private void OVRObjectPool_002EIPoolObject_002EOnGet()
		{
		}

		private void OVRObjectPool_002EIPoolObject_002EOnReturn()
		{
		}

		protected void AddTask(Guid id)
		{
		}

		protected void OnResult(Guid taskId)
		{
		}

		public void OnGet()
		{
			throw new NotImplementedException();
		}

		public void OnReturn()
		{
			throw new NotImplementedException();
		}
	}

	private class MultiTaskData<T1, T2> : MultiTaskData<(T1, T2)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2>)> _onResult2;

		public static OVRTask<(T1, T2)> Get(OVRTask<T1> task1, OVRTask<T2> task2)
		{
			return default(OVRTask<(T1, T2)>);
		}
	}

	private class MultiTaskData<T1, T2, T3> : MultiTaskData<(T1, T2, T3)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3>)> _onResult3;

		public static OVRTask<(T1, T2, T3)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3)
		{
			return default(OVRTask<(T1, T2, T3)>);
		}
	}

	private class MultiTaskData<T1, T2, T3, T4> : MultiTaskData<(T1, T2, T3, T4)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3, T4>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3, T4>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3, T4>)> _onResult3;

		private static Action<T4, (Guid, MultiTaskData<T1, T2, T3, T4>)> _onResult4;

		public static OVRTask<(T1, T2, T3, T4)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4)
		{
			return default(OVRTask<(T1, T2, T3, T4)>);
		}
	}

	private class MultiTaskData<T1, T2, T3, T4, T5> : MultiTaskData<(T1, T2, T3, T4, T5)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3, T4, T5>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3, T4, T5>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3, T4, T5>)> _onResult3;

		private static Action<T4, (Guid, MultiTaskData<T1, T2, T3, T4, T5>)> _onResult4;

		private static Action<T5, (Guid, MultiTaskData<T1, T2, T3, T4, T5>)> _onResult5;

		public static OVRTask<(T1, T2, T3, T4, T5)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5)
		{
			return default(OVRTask<(T1, T2, T3, T4, T5)>);
		}
	}

	private class MultiTaskData<T1, T2, T3, T4, T5, T6> : MultiTaskData<(T1, T2, T3, T4, T5, T6)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult3;

		private static Action<T4, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult4;

		private static Action<T5, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult5;

		private static Action<T6, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6>)> _onResult6;

		public static OVRTask<(T1, T2, T3, T4, T5, T6)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6)
		{
			return default(OVRTask<(T1, T2, T3, T4, T5, T6)>);
		}
	}

	private class MultiTaskData<T1, T2, T3, T4, T5, T6, T7> : MultiTaskData<(T1, T2, T3, T4, T5, T6, T7)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult3;

		private static Action<T4, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult4;

		private static Action<T5, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult5;

		private static Action<T6, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult6;

		private static Action<T7, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7>)> _onResult7;

		public static OVRTask<(T1, T2, T3, T4, T5, T6, T7)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6, OVRTask<T7> task7)
		{
			return default(OVRTask<(T1, T2, T3, T4, T5, T6, T7)>);
		}
	}

	private class MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8> : MultiTaskData<(T1, T2, T3, T4, T5, T6, T7, T8)>
	{
		private static Action<T1, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult1;

		private static Action<T2, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult2;

		private static Action<T3, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult3;

		private static Action<T4, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult4;

		private static Action<T5, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult5;

		private static Action<T6, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult6;

		private static Action<T7, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult7;

		private static Action<T8, (Guid, MultiTaskData<T1, T2, T3, T4, T5, T6, T7, T8>)> _onResult8;

		public static OVRTask<(T1, T2, T3, T4, T5, T6, T7, T8)> Get(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6, OVRTask<T7> task7, OVRTask<T8> task8)
		{
			return default(OVRTask<(T1, T2, T3, T4, T5, T6, T7, T8)>);
		}
	}

	public static OVRTask<TResult[]> WhenAll<TResult>(IEnumerable<OVRTask<TResult>> tasks)
	{
		return default(OVRTask<TResult[]>);
	}

	public static OVRTask<List<TResult>> WhenAll<TResult>(IEnumerable<OVRTask<TResult>> tasks, List<TResult> results)
	{
		return default(OVRTask<List<TResult>>);
	}

	internal static OVRTask<TResult> FromGuid<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> FromRequest<TResult>(ulong id)
	{
		return default(OVRTask<TResult>);
	}

	public static OVRTask<TResult> FromResult<TResult>(TResult result)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> GetExisting<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> GetExisting<TResult>(ulong id)
	{
		return default(OVRTask<TResult>);
	}

	public static void SetResult<TResult>(Guid id, TResult result)
	{
	}

	internal static void SetResult<TResult>(ulong id, TResult result)
	{
	}

	private static OVRTask<TResult> Get<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	public static OVRTask<TResult> Create<TResult>(Guid taskId)
	{
		return default(OVRTask<TResult>);
	}

	internal static Guid GetId(ulong value)
	{
		return default(Guid);
	}

	internal static void RegisterType<TResult>()
	{
	}

	public static OVRTask<(T1, T2)> WhenAll<T1, T2>(OVRTask<T1> task1, OVRTask<T2> task2)
	{
		return default(OVRTask<(T1, T2)>);
	}

	public static OVRTask<(T1, T2, T3)> WhenAll<T1, T2, T3>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3)
	{
		return default(OVRTask<(T1, T2, T3)>);
	}

	public static OVRTask<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4)
	{
		return default(OVRTask<(T1, T2, T3, T4)>);
	}

	public static OVRTask<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5)
	{
		return default(OVRTask<(T1, T2, T3, T4, T5)>);
	}

	public static OVRTask<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6)
	{
		return default(OVRTask<(T1, T2, T3, T4, T5, T6)>);
	}

	public static OVRTask<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6, OVRTask<T7> task7)
	{
		return default(OVRTask<(T1, T2, T3, T4, T5, T6, T7)>);
	}

	public static OVRTask<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(OVRTask<T1> task1, OVRTask<T2> task2, OVRTask<T3> task3, OVRTask<T4> task4, OVRTask<T5> task5, OVRTask<T6> task6, OVRTask<T7> task7, OVRTask<T8> task8)
	{
		return default(OVRTask<(T1, T2, T3, T4, T5, T6, T7, T8)>);
	}
}
[AsyncMethodBuilder(typeof(OVRTaskBuilder<>))]
public readonly struct OVRTask<TResult> : IEquatable<OVRTask<TResult>>, IDisposable
{
	private delegate void ContinueWithInvoker(Guid guid, TResult result);

	private delegate bool ContinueWithRemover(Guid guid);

	private delegate bool InternalDataRemover(Guid guid);

	private static class InternalData<T>
	{
		private static readonly Dictionary<Guid, T> Data;

		private static readonly InternalDataRemover Remover;

		private static readonly Action Clearer;

		public static bool TryGet(Guid taskId, out T data)
		{
			data = default(T);
			return false;
		}

		public static void Set(Guid taskId, T data)
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private static void Clear()
		{
		}
	}

	private static class IncrementalResultSubscriber<T>
	{
		private static readonly Dictionary<Guid, Action<T>> Subscribers;

		private static readonly Action<Guid> Remover;

		private static readonly Action Clearer;

		public static void Set(Guid taskId, Action<T> subscriber)
		{
		}

		public static void Notify(Guid taskId, T result)
		{
		}

		private static void Remove(Guid id)
		{
		}

		private static void Clear()
		{
		}
	}

	private readonly struct CombinedTaskData : IDisposable
	{
		public readonly OVRTask<List<TResult>> Task;

		private readonly HashSet<Guid> _remainingTaskIds;

		private readonly List<Guid> _originalTaskOrder;

		private readonly Dictionary<Guid, TResult> _completedTasks;

		private readonly List<TResult> _userOwnedResultList;

		private static readonly Action<TResult, CombinedTaskDataWithCompletedTaskId> _onSingleTaskCompleted;

		private void OnSingleTaskCompleted(Guid taskId, TResult result)
		{
		}

		public CombinedTaskData(IEnumerable<OVRTask<TResult>> tasks, List<TResult> userOwnedResultList)
		{
			Task = default(OVRTask<List<TResult>>);
			_remainingTaskIds = null;
			_originalTaskOrder = null;
			_completedTasks = null;
			_userOwnedResultList = null;
		}

		public void Dispose()
		{
		}
	}

	private struct CombinedTaskDataWithCompletedTaskId
	{
		public Guid CompletedTaskId;

		public CombinedTaskData CombinedData;
	}

	private class TaskSource : IValueTaskSource<TResult>, OVRObjectPool.IPoolObject
	{
		//private ManualResetValueTaskSourceCore<TResult> _manualSource;

		public ValueTask<TResult> Task { get; private set; }

		public TResult GetResult(short token)
		{
			return default(TResult);
		}

		public ValueTaskSourceStatus GetStatus(short token)
		{
			return default(ValueTaskSourceStatus);
		}

		public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
		}

		private void OVRObjectPool_002EIPoolObject_002EOnGet()
		{
		}

		private void OVRObjectPool_002EIPoolObject_002EOnReturn()
		{
		}

		public void SetResult(TResult result)
		{
		}

		public void SetException(Exception exception)
		{
		}

		public void OnGet()
		{
			throw new NotImplementedException();
		}

		public void OnReturn()
		{
			throw new NotImplementedException();
		}
	}

	private class Awaitable<T>
	{
	}

	private class AwaitableCompletionSource<T>
	{
		public Awaitable<T> Awaitable => null;

		public void SetResult(in T result)
		{
		}

		public void Reset()
		{
		}

		public void SetException(Exception exception)
		{
		}
	}

	private class AwaitableSource : AwaitableCompletionSource<TResult>, OVRObjectPool.IPoolObject
	{
		public void OnGet()
		{
		}

		public void OnReturn()
		{
		}

		public void SetResultAndReturnToPool(in TResult result)
		{
		}
	}

	public readonly struct Awaiter : INotifyCompletion
	{
		private readonly OVRTask<TResult> _task;

		public bool IsCompleted => false;

		internal Awaiter(OVRTask<TResult> task)
		{
			_task = default(OVRTask<TResult>);
		}

		private void System_002ERuntime_002ECompilerServices_002EINotifyCompletion_002EOnCompleted(Action continuation)
		{
		}

		public TResult GetResult()
		{
			return default(TResult);
		}

		public void OnCompleted(Action continuation)
		{
			throw new NotImplementedException();
		}
	}

	private readonly struct Callback
	{
		private static readonly Dictionary<Guid, Callback> Callbacks;

		private readonly Action<TResult> _delegate;

		public static readonly ContinueWithInvoker Invoker;

		public static readonly ContinueWithRemover Remover;

		public static readonly Action Clearer;

		private static void Invoke(Guid taskId, TResult result)
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private static void Clear()
		{
		}

		private void Invoke(TResult result)
		{
		}

		private Callback(Action<TResult> @delegate)
		{
			_delegate = null;
		}

		public static void Add(Guid taskId, Action<TResult> @delegate)
		{
		}
	}

	private readonly struct CallbackWithState<T>
	{
		private static readonly Dictionary<Guid, CallbackWithState<T>> Callbacks;

		private readonly T _data;

		private readonly Action<TResult, T> _delegate;

		private static readonly ContinueWithInvoker Invoker;

		private static readonly ContinueWithRemover Remover;

		private static readonly Action Clearer;

		private static void Invoke(Guid taskId, TResult result)
		{
		}

		private CallbackWithState(T data, Action<TResult, T> @delegate)
		{
			_data = default(T);
			_delegate = null;
		}

		private static void Clear()
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private void Invoke(TResult result)
		{
		}

		public static void Add(Guid taskId, T data, Action<TResult, T> callback)
		{
		}
	}

	private static readonly HashSet<Guid> Pending;

	private static readonly Dictionary<Guid, TResult> Results;

	private static readonly Dictionary<Guid, Exception> Exceptions;

	private static readonly Dictionary<Guid, TaskSource> Sources;

	private static readonly Dictionary<Guid, AwaitableSource> AwaitableSources;

	private static readonly Dictionary<Guid, Action> Continuations;

	private static readonly Dictionary<Guid, ContinueWithInvoker> ContinueWithInvokers;

	private static readonly Dictionary<Guid, ContinueWithRemover> ContinueWithRemovers;

	private static readonly HashSet<Action> ContinueWithClearers;

	private static readonly Dictionary<Guid, InternalDataRemover> InternalDataRemovers;

	private static readonly HashSet<Action> InternalDataClearers;

	private static readonly Dictionary<Guid, Action<Guid>> IncrementalResultSubscriberRemovers;

	private static readonly HashSet<Action> IncrementalResultSubscriberClearers;

	internal readonly Guid _id;

	private static readonly Action<List<TResult>, OVRTask<TResult[]>> _onCombinedTaskCompleted;

	internal bool IsPending => false;

	public bool IsCompleted => false;

	public bool IsFaulted => false;

	public bool HasResult => false;

	private static bool TryExtractValue<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	internal static void Clear()
	{
	}

	internal OVRTask(Guid id)
	{
		_id = default(Guid);
	}

	static OVRTask()
	{
	}

	internal bool AddToPending()
	{
		return false;
	}

	internal void SetInternalData<T>(T data)
	{
	}

	internal bool TryGetInternalData<T>(out T data)
	{
		data = default(T);
		return false;
	}

	internal void SetException(Exception exception)
	{
	}

	private bool TryRemoveInternalData()
	{
		return false;
	}

	private bool TryInvokeContinuation()
	{
		return false;
	}

	internal void SetResult(TResult result)
	{
	}

	internal void SetIncrementalResultCallback<TIncrementalResult>(Action<TIncrementalResult> onIncrementalResultAvailable)
	{
	}

	internal void NotifyIncrementalResult<TIncrementalResult>(TIncrementalResult incrementalResult)
	{
	}

	internal static OVRTask<List<TResult>> WhenAll(IEnumerable<OVRTask<TResult>> tasks, List<TResult> results)
	{
		return default(OVRTask<List<TResult>>);
	}

	internal static OVRTask<TResult[]> WhenAll(IEnumerable<OVRTask<TResult>> tasks)
	{
		return default(OVRTask<TResult[]>);
	}

	public Exception GetException()
	{
		return null;
	}

	public TResult GetResult()
	{
		return default(TResult);
	}

	public bool TryGetResult(out TResult result)
	{
		result = default(TResult);
		return false;
	}

	public ValueTask<TResult> ToValueTask()
	{
		return default(ValueTask<TResult>);
	}

	public Awaiter GetAwaiter()
	{
		return default(Awaiter);
	}

	private void WithContinuation(Action continuation)
	{
	}

	public void ContinueWith(Action<TResult> onCompleted)
	{
	}

	public void ContinueWith<T>(Action<TResult, T> onCompleted, T state)
	{
	}

	private void ValidateDelegateAndThrow(object @delegate, string paramName)
	{
	}

	public void Dispose()
	{
	}

	public bool Equals(OVRTask<TResult> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(OVRTask<TResult> lhs, OVRTask<TResult> rhs)
	{
		return false;
	}

	public static bool operator !=(OVRTask<TResult> lhs, OVRTask<TResult> rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
