using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BrickBreaker.Utilities;

namespace BrickBreaker.Main
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        protected override void Awake()
        {
            base.Awake();
        }

        void Start()
        {
            Debug.Log("Game Service Running");
        }
     
    }
}

