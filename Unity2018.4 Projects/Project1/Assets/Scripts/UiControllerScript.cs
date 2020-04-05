using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;

namespace Test
{
    public class UiControllerScript : Singleton<UiControllerScript>
    {
        [SerializeField]
        GameObject InfoPrefab, ItemPrefab, SubItemPrefab;
        [SerializeField]
        GameObject ChooseScreenPanel, Screen1Panel, Screen2Panel;
        [SerializeField]
        ScrollRect scrollRect;

        public GameObject GetSubItemPrefab { get { return SubItemPrefab; } }
        public GameObject GetInfoPrefab { get { return InfoPrefab; } }

        public void OnClickedScreen1Button()
        {
            ChooseScreenPanel.SetActive(false);
            Screen1Panel.SetActive(true);
            WebserviceManagerScript.Instance.GetData(ServerCallBack);
        }
        public void OnClickedScreen2Button()
        {
            ChooseScreenPanel.SetActive(false);
            Screen2Panel.SetActive(true);
        }

        private void ServerCallBack(string jsonStr)
        {
            var data = JSON.Parse(jsonStr);
            List<DataEntity> dataList = new List<DataEntity>();
            for (int i = 0; i < data.Count; i++)
            {
                DataEntity dataEntiy = new DataEntity();

                var item = data[i];

                dataEntiy.id = item["id"];
                dataEntiy.createdAt = item["createdAt"];
                dataEntiy.name = item["name"];
                dataEntiy.avatar = item["avatar"];

              
                var subData = item["Addition"];
                for (int j = 0; j < subData.Count; j++)
                {
                    var arr = subData[j];
                    List<SubtopicEntity> sbEnityList = new List<SubtopicEntity>();
                    for (int k = 0; k < arr.Count; k++)
                    {
                        SubtopicEntity subtopicEntity = new SubtopicEntity();
                        subtopicEntity.subtopic_id = arr["subtopic_id"];
                        subtopicEntity.subtopic_name = arr["subtopic_name"];
                    }
                    dataEntiy.additionList.Add(sbEnityList);
                }

                 subData = item["Geometry"];
                for (int j = 0; j < subData.Count; j++)
                {
                    var arr = subData[j];
                    List<SubtopicEntity> sbEnityList = new List<SubtopicEntity>();
                    for (int k = 0; k < arr.Count; k++)
                    {
                        SubtopicEntity subtopicEntity = new SubtopicEntity();
                        subtopicEntity.subtopic_id = arr["subtopic_id"];
                        subtopicEntity.subtopic_name = arr["subtopic_name"];
                    }
                    dataEntiy.geometryList.Add(sbEnityList);
                }

                 subData = item["Mixed Operations"];
                for (int j = 0; j < subData.Count; j++)
                {
                    var arr = subData[j];
                    List<SubtopicEntity> sbEnityList = new List<SubtopicEntity>();
                    for (int k = 0; k < arr.Count; k++)
                    {
                        SubtopicEntity subtopicEntity = new SubtopicEntity();
                        subtopicEntity.subtopic_id = arr["subtopic_id"];
                        subtopicEntity.subtopic_name = arr["subtopic_name"];
                    }
                    dataEntiy.mixedOperationsList.Add(sbEnityList);
                }

                 subData = item["Number sense"];
                for (int j = 0; j < subData.Count; j++)
                {
                    var arr = subData[j];
                    List<SubtopicEntity> sbEnityList = new List<SubtopicEntity>();
                    for (int k = 0; k < arr.Count; k++)
                    {
                        SubtopicEntity subtopicEntity = new SubtopicEntity();
                        subtopicEntity.subtopic_id = arr["subtopic_id"];
                        subtopicEntity.subtopic_name = arr["subtopic_name"];
                    }
                    dataEntiy.numberSenseList.Add(sbEnityList);
                }

                 subData = item["Subtraction"];
                for (int j = 0; j < subData.Count; j++)
                {
                    var arr = subData[j];
                    List<SubtopicEntity> sbEnityList = new List<SubtopicEntity>();
                    for (int k = 0; k < arr.Count; k++)
                    {
                        SubtopicEntity subtopicEntity = new SubtopicEntity();
                        subtopicEntity.subtopic_id = arr["subtopic_id"];
                        subtopicEntity.subtopic_name = arr["subtopic_name"];
                    }
                    dataEntiy.subtractionList.Add(sbEnityList);
                }

                dataList.Add(dataEntiy);
            }
            CreateScrollItems(dataList);
        }
     

        void CreateScrollItems(List<DataEntity> dataList)
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                GameObject item = Instantiate(ItemPrefab, scrollRect.content) as GameObject;
                item.GetComponent<ItemHandlerScript>().Init(dataList[i]);
                GameObject subItem = Instantiate(SubItemPrefab, item.transform) as GameObject;
                subItem.GetComponent<SubItemHandlerScript>().Init("Addition", dataList[i].additionList);
                subItem = Instantiate(SubItemPrefab, item.transform) as GameObject;
                subItem.GetComponent<SubItemHandlerScript>().Init("Geometry", dataList[i].geometryList);
                subItem = Instantiate(SubItemPrefab, item.transform) as GameObject;
                subItem.GetComponent<SubItemHandlerScript>().Init("Mixed Operations", dataList[i].mixedOperationsList);
                subItem = Instantiate(SubItemPrefab, item.transform) as GameObject;
                subItem.GetComponent<SubItemHandlerScript>().Init("Number Sense", dataList[i].numberSenseList);
                subItem = Instantiate(SubItemPrefab, item.transform) as GameObject;
                subItem.GetComponent<SubItemHandlerScript>().Init("Subtraction", dataList[i].subtractionList);
            }
        }

    }
}
