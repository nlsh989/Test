using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Test
{
    public class ItemHandlerScript : MonoBehaviour
    {
        [SerializeField]
        Text name;
        [SerializeField]
        RawImage profilePic;

        private DataEntity mData;
        public void Init(DataEntity data)
        {
            mData = data;
            name.text = mData.name;
            StartCoroutine(TextureLoader());
        }

        IEnumerator TextureLoader()
        {
            //create post web request
            UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(mData.avatar);
            //calling and wait for response
            yield return webRequest.SendWebRequest();
            //check for if any error occurred
            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
                Debug.LogError(webRequest.error);
            }
            else
            {
                Texture myTexture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
                profilePic.texture = myTexture;
                profilePic.color = Color.white;
           }
        }

    }
}
