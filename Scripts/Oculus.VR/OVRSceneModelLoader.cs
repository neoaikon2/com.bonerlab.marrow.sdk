using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_model_loader")]
[RequireComponent(typeof(OVRSceneManager))]
public class OVRSceneModelLoader : MonoBehaviour
{
	private const float RetryingReminderDelay = 10f;

	private bool _sceneCaptureRequested;

	protected OVRSceneManager SceneManager { get; private set; }

	private void Start()
	{
	}
	private IEnumerator AttemptToLoadSceneModel()
	{
		return null;
	}

	protected virtual void OnStart()
	{
	}

	protected static OVRTask<bool> RequestScenePermissionAsync()
	{
		return default(OVRTask<bool>);
	}
	protected virtual void OnLoadSceneModelFailedPermissionNotGranted()
	{
	}

	private void LoadSceneModel()
	{
	}

	protected virtual void OnSceneModelLoadedSuccessfully()
	{
	}

	protected virtual void OnNoSceneModelToLoad()
	{
	}

	protected virtual void OnNewSceneModelAvailable()
	{
	}

	protected virtual void OnSceneCaptureReturnedWithoutError()
	{
	}

	protected virtual void OnUnexpectedErrorWithSceneCapture()
	{
	}
}
