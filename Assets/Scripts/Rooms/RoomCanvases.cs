﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCanvases : MonoBehaviour
{
    [SerializeField]
    private CreateOrJoinRoomCanvas _createOrJoinRoomCanvas;
    public CreateOrJoinRoomCanvas CreateOrJoinRoomCanvas
    {
        get
        {
            return _createOrJoinRoomCanvas;
        }
    }

    [SerializeField]
    private CurrentRoomCanvas _currentRoomCanvas;
    public CurrentRoomCanvas CurrentRoomCanvas
    {
        get
        {
            return _currentRoomCanvas;
        }
    }

    private void Start()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CurrentRoomCanvas.FirstInitialize(this);
        CreateOrJoinRoomCanvas.FirstInitialize(this);
    }
}
