using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset textJson;
    [System.Serializable] 

    public class player
    {
        public string name;
        public int health;
        public int weapon;
    }

    [System.Serializable]
    public class PlayerList
    {
        public player[] player;
    }

    public PlayerList myPlayerList = new PlayerList();

    void Start()
    {
      myPlayerList = JsonUtility.FromJson<PlayerList>(textJson.text);
    }
}
