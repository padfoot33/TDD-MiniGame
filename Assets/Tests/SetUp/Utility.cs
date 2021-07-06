using System;
using UnityEditor;
using UnityEngine;

namespace Tests
{
    public static class Utility
    {
        private const string BASE_PATH = "Assets/";
        private const string TEST_SCRIPTABLE_PATH = BASE_PATH + "Tests/SetUp/Scriptable/";
        private static PrefabDatabase database;

        public static void Init()
        {
            database = AssetDatabase.LoadAssetAtPath<PrefabDatabase>(TEST_SCRIPTABLE_PATH + "PrefabDatabase.asset");
        }
        public static GameObject Instantiate(string name)
        {
            return GameObject.Instantiate(database.GetObeject(name));
        }
        public static GameObject Instantiate(string name,Vector3 vector,Quaternion quaternion)
        {
            return GameObject.Instantiate(database.GetObeject(name),vector,quaternion);
        }
        public static void DestroyObject(MonoBehaviour name)
        {
            GameObject.Destroy(name.gameObject);
        }
        public static void DestroyImmediateObject(MonoBehaviour name)
        {
            GameObject.DestroyImmediate(name.gameObject);
        }

        public static void DestroyAll(MonoBehaviour[] objects)
        {
            foreach (var item in objects)
            {
                DestroyObject(item);
            }
        }
        public static Sprite GetSprite(string name)
        {
            return database.GetSprite(name);
        }

    }
}
