using System;
using System.Runtime.CompilerServices;

public struct OVRTaskBuilder<T>
{
	private OVRTask<T>? _task;

	public OVRTask<T> Task => default(OVRTask<T>);

	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}

	public static OVRTaskBuilder<T> Create()
	{
		return default(OVRTaskBuilder<T>);
	}

	public void SetException(Exception exception)
	{
	}

	public void SetResult(T result)
	{
	}

	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
	}
}
