using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour 
{
    public AudioSource audioSource = null;

    private Hashtable sounds = new Hashtable();

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    /// <summary>
    /// 载入一个音频
    /// </summary>
    public AudioClip LoadAudioClip(string path)
    {
        AudioClip ac = Get(path);
        if (ac == null)
        {
            ac = (AudioClip)Resources.Load(path, typeof(AudioClip));
            Add(path, ac);
        }
        return ac;
    }

    /// <summary>
    /// 播放背景音乐
    /// </summary>
    /// <param name="canPlay"></param>
    public void PlayBacksound(string name, bool canPlay)
    {
        if (this.audioSource.clip != null)
        {
            if (name.IndexOf(this.audioSource.clip.name) > -1)
            {
                if (!canPlay)
                {
                    this.audioSource.Stop();
                    this.audioSource.clip = null;
                }
                return;
            }
        }

        if (canPlay)
        {
            this.audioSource.loop = true;
            this.audioSource.clip = LoadAudioClip(name);
            this.audioSource.Play();
        }
        else
        {
            this.audioSource.Stop();
            this.audioSource.clip = null;
        }
    }

    /// <summary>
    /// 播放音效
    /// </summary>
    public void Play(string name)
    {
        AudioSource.PlayClipAtPoint(LoadAudioClip(name), new Vector3(), 1);
    }

    /// <summary>
    /// 添加一个声音
    /// </summary>
    private void Add(string key, AudioClip value)
    {
        if (sounds[key] != null || value == null)
            return;
        sounds.Add(key, value);
    }

    /// <summary>
    /// 获取一个声音
    /// </summary>
    private AudioClip Get(string key)
    {
        if (sounds[key] == null)
            return null;
        return sounds[key] as AudioClip;
    }
}
