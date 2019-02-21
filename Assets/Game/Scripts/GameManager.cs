﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {


        private void Awake()
        {
            DontDestroyOnLoad(this);
            this.gameObject.AddComponent<Utils>().Init();
            JsonMgr.Instance.Init();
            ResourceLoadMgr.Instance.Init();

          
        }

        
       


    }
}

