using UnityEngine;

public class AudioController : MonoBehaviour
{
	[SerializeField] private AudioSource engineSound;
	[SerializeField] private EngineAudioController engineAudioController;

	public void UpdateEngineSound(float currentSpeed, float minSpeed, float maxSpeed)
	{
		engineAudioController.UpdateEngineSound(engineSound, currentSpeed, minSpeed, maxSpeed);
	}
}