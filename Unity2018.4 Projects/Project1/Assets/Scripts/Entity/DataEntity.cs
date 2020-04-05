using System.Collections;
using System.Collections.Generic;

public class DataEntity
{
    //"id": "1",
    //"createdAt": "2020-03-12T22:21:35.592Z",
    //"name": "Nichole Schneider",
    //"avatar": "https://s3.amazonaws.com/uifaces/faces/twitter/jeremiaha/128.jpg",
    //"Addition": 
    public string id=string.Empty;
    public string createdAt = string.Empty;
    public string name = string.Empty;
    public string avatar = string.Empty;
    public List<SubtopicEntity> additionList=new List<SubtopicEntity>();
    public List<SubtopicEntity> geometryList = new List<SubtopicEntity>();
    public List<SubtopicEntity> mixedOperationsList = new List<SubtopicEntity>();
    public List<SubtopicEntity> numberSenseList = new List<SubtopicEntity>();
    public List<SubtopicEntity> subtractionList = new List<SubtopicEntity>();
}
