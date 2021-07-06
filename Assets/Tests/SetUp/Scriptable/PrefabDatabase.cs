using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;
using Tag;
namespace Tests
{
    [CreateAssetMenu(fileName = "PrefabDatabase", menuName = "PrefabDatabase")]
    public class PrefabDatabase : ScriptableObject
    {
        public List<GameObject> prefabList;
        public List<Sprite> spriteList;

        public GameObject GetObeject(string name)
        {
            GameObject gameObject = prefabList.Find(x => x.name.ToLower() == name.ToLower());
            if (gameObject == null)
                throw new Exception("String Sachi Pass Karo!!!");
            return gameObject;
        }

        public Sprite GetSprite(string name)
        {
            Sprite sprite = spriteList.Find(x => x.name.ToLower() == name.ToLower());
            if (sprite == null)
                throw new Exception("String Sachi Pass Karo!!!");
            return sprite;
        }
    }
}
