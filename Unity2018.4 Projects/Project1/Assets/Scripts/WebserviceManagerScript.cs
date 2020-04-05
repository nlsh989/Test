using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Test
{
    public delegate void ResponseDel(string res);

    public class WebserviceManagerScript : Singleton<WebserviceManagerScript>
    {
        //url
        private readonly string URL = "https://5e6b24f90f70dd001643c248.mockapi.io/v1/demo/math/data";

        private string mJSONResponse = null;

        // Start is called before the first frame update
        void Start()
        {
            GetData(null);
        }

        public void GetData(ResponseDel callback)
        {
            if (mJSONResponse == null)
            {
                StartCoroutine(GetDataFromServer(callback));
            }
            else
            {
                callback?.Invoke(mJSONResponse);
            }
        }

        private IEnumerator GetDataFromServer(ResponseDel callback)
        {
            //create post web request
            UnityWebRequest webRequest = UnityWebRequest.Get(URL);
            //calling and wait for response
            yield return webRequest.SendWebRequest();
            //check for if any error occurred
            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
                Debug.LogError(webRequest.error);
            }
            else
            {
                // Show results as text
                Debug.Log(webRequest.downloadHandler.text);
                mJSONResponse = webRequest.downloadHandler.text;
                callback?.Invoke(webRequest.downloadHandler.text);
            }
        }

    }
}
