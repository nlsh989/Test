using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class InfoHandlerScript : MonoBehaviour
    {
        [SerializeField]
        Text InfoText;

        public void SetText(string info)
        {
            InfoText.text = info;
        }

    }
}
