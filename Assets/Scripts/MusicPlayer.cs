using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Start()
    {
        int numOfMusicPlayers = FindObjectsByType<MusicPlayer>().Length;

        if (numOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
