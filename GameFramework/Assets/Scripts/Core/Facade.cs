﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public static class Facade
{
    public static GameController GameController
    {
        get
        {
            return ManagerCollect.Instance.MainUpdate.GetComponent<GameController>();
        }
    }

    public static TimerManager GetTimerManager()
    {
        return ManagerCollect.Instance.GetManager<TimerManager>(ManagerNames.Timer);
    }

    public static MusicManager GetMusicManager()
    {
        return ManagerCollect.Instance.GetManager<MusicManager>(ManagerNames.Music);
    }

    public static PanelManager GetPanelManager()
    {
        return ManagerCollect.Instance.GetManager<PanelManager>(ManagerNames.Panel);
    }

    public static NetworkManager GetNetworkManager()
    {
        return ManagerCollect.Instance.GetManager<NetworkManager>(ManagerNames.Network);
    }

    public static AssetLoadManager GetAssetLoadManager()
    {
        return ManagerCollect.Instance.GetManager<AssetLoadManager>(ManagerNames.Asset);
    }

    public static CroutineManager GetCroutineManager()
    {
        return ManagerCollect.Instance.GetManager<CroutineManager>(ManagerNames.Croutine);
    }

    public static SceneManager GetSceneManager()
    {
        return ManagerCollect.Instance.GetManager<SceneManager>(ManagerNames.Scene);
    }

    public static InputManager GetInputManager()
    {
        return ManagerCollect.Instance.GetManager<InputManager>(ManagerNames.Input);
    }

    public static ResourcesUpdateManager GetResourcesUpdateManager()
    {
        return ManagerCollect.Instance.GetManager<ResourcesUpdateManager>(ManagerNames.Input);
    }

    public static GameObject GUIRoot
    {
        get
        {
            GameObject go = GameObject.FindWithTag("GUIRoot");
            if (go != null) return go;
            return null;
        }
    }

    /// <summary>
    /// PanelCamera
    /// </summary>
    public static Transform PanelCamera
    {
        get
        {
            GameObject go = GameObject.FindWithTag("PanelCamera");
            if (go != null) return go.transform;
            return null;
        }
    }

    /// <summary>
    /// EffectCamera
    /// </summary>
    public static Transform EffectCamera
    {
        get
        {
            GameObject go = GameObject.FindWithTag("EffectCamera");
            if (go != null) return go.transform;
            return null;
        }
    }

    /// <summary>
    /// MessageCanvas
    /// </summary>
    public static Transform MessageCanvas
    {
        get
        {
            GameObject go = GameObject.FindWithTag("MessageCanvas");
            if (go != null) return go.transform;
            return null;
        }
    }


    /// <summary>
    /// PopupsWindow
    /// </summary>
    public static Transform PopupsWindow
    {
        get
        {
            GameObject go = GameObject.FindWithTag("PopupsWindow");
            if (go != null) return go.transform;
            return null;
        }
    }

    /// <summary>
    /// 网络消息发送者 [socket]
    /// </summary>
    public static MessageSender MessageSender
    {
        get { return MessageSender.Instance; }
    }
}