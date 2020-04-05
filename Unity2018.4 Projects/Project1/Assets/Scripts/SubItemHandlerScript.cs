using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class SubItemHandlerScript : MonoBehaviour
    {
        [SerializeField]
        Text name;

        private List<List<SubtopicEntity>> mSubListOfList;
        private List<SubtopicEntity> mSubTopicList;

        public void Init(string name,List<List<SubtopicEntity>> subListOfList)
        {
            this.name.text=name;
            //mSubListOfList=subListOfList;
        }

        public void Init(string name, List<SubtopicEntity> subList)
        {
            this.name.text = name;
            //mSubTopicList = subList;
        }

        public void OnClickedToggleBtn(bool flag)
        {
            //if (flag)
            //{
            //    for (int i = 0; i < transform.childCount; i++)
            //    {
            //        Destroy(transform.GetChild(i).gameObject);
            //    }
            //}
            //else
            //{
            //    if (mSubListOfList != null)
            //    {
            //        for (int i = 0; i < mSubListOfList.Count; i++)
            //        {
            //            GameObject item = Instantiate(UiControllerScript.Instance.GetSubItemPrefab, transform) as GameObject;
            //            item.GetComponent<SubItemHandlerScript>().Init("Level "+(i+1),mSubListOfList[i]);
            //        }
            //    }
            //    else if (mSubTopicList != null)
            //    {
            //        for (int i = 0; i < mSubTopicList.Count; i++)
            //        {
            //            GameObject item = Instantiate(UiControllerScript.Instance.GetInfoPrefab, transform) as GameObject;
            //            item.GetComponent<InfoHandlerScript>().SetText(mSubTopicList[i].subtopic_name);
            //        }
            //    }
            //}
        }
    }
}
