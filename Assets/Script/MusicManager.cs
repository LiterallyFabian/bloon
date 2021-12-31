using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private  List<AudioClip> musicClips;
    private AudioSource _audioSource;
    private int _currentClipIndex;

    private void Start()
    {
        Shuffle(musicClips);
        _audioSource = GetComponent<AudioSource>();
        NextSong();
    }

    private void Update()
    {
        if (!_audioSource.isPlaying) NextSong();
        
        //fade out music volume at song end
        if (_audioSource.volume > 0 && _audioSource.time >= _audioSource.clip.length - 1)
        {
            _audioSource.volume -= 0.01f;
        }
    }
    
    private void NextSong()
    {
        _currentClipIndex++;
        if (_currentClipIndex == musicClips.Count) 
            _currentClipIndex = 0;
        
        _audioSource.clip = musicClips[_currentClipIndex];
        _audioSource.volume = 1;
        _audioSource.Play();
    }
    
    public static void Shuffle<T>(IList<T> list)
    {
        Random rng = new Random();
        int n = list.Count;

        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }
}