using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClicked => Input.GetMouseButtonDown(0);
        public bool RightMouseClicked => Input.GetMouseButtonDown(1);
    }
}

