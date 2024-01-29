using UnityEngine;

public class VoiceTrigger : MonoBehaviour
{
    public AudioClip voiceClip; // The voice clip to play

    private bool hasPlayed; // To prevent multiple plays

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayed)
        {
            // Play the voice clip
            AudioSource.PlayClipAtPoint(voiceClip, transform.position);

            hasPlayed = true; // Set the flag to prevent multiple plays
        }
    }
}