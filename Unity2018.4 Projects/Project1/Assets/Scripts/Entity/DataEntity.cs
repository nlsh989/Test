using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class DataEntity
    {
        //"id": "1",
        //"createdAt": "2020-03-12T22:21:35.592Z",
        //"name": "Nichole Schneider",
        //"avatar": "https://s3.amazonaws.com/uifaces/faces/twitter/jeremiaha/128.jpg",
        //"Addition": 
        public string id = string.Empty;
        public string createdAt = string.Empty;
        public string name = string.Empty;
        public string avatar = string.Empty;
        public List<List<SubtopicEntity>> additionList = new List<List<SubtopicEntity>>();
        public List<List<SubtopicEntity>> geometryList = new List<List<SubtopicEntity>>();
        public List<List<SubtopicEntity>> mixedOperationsList = new List<List<SubtopicEntity>>();
        public List<List<SubtopicEntity>> numberSenseList = new List<List<SubtopicEntity>>();
        public List<List<SubtopicEntity>> subtractionList = new List<List<SubtopicEntity>>();
    }
}
