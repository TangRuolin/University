using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.IO;

namespace Game
{
    public class JsonMgr
    {

        private static JsonMgr _instance;
        public static JsonMgr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JsonMgr();
                }
                return _instance;
            }
        }
        public ContentInfo contentInfo { get; private set; }
        public void Init()
        {
            string Content = Resources.Load<TextAsset>("Json/ContentJson").text;
            //TextAsset textFile = Resources.Load<TextAsset>("Json/ContextJson");
            ////Debug.Log(Content);
            //if (textFile == null)
            //{
            //    Debug.LogError("读取不到文件");
            //}
            //string Content = textFile.text;
            contentInfo = JsonUtility.FromJson<ContentInfo>(Content);
        }
        public class ContentInfo
        {
            public EnemyData[] monsterType;
            public string[] tick;
            public Vector3[] startPosition;
            public Vector3[] eneginePos;
            public int[] skillTime;
            public int[] skillCD;
            public int[] skillEnegineNum;
            public string[] audioName;
        }

        /// <summary>
        /// 路径
        /// </summary>
        /// <returns></returns>
        public static string GetSaPathForIO()
        {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR

            //IO文件流读写直接获取路径进行读写即可
            return Application.streamingAssetsPath + "/Json/";

#elif UNITY_IPHONE

        //类似安卓
        return Application.streamingAssetsPath + "/Json/";

#elif UNITY_ANDROID

        //Android下此路径仅用于AB包加载，文件读写无效
        //还有这个路径只能用来AssetBundle.LoadFromFile 。如果想用File类操作。 比如File.ReadAllText  或者 File.Exists  Directory.Exists 这样都是不行的。
        return  Application.streamingAssetsPath + "/Json/";

#else
        //其余情况暂时不考虑
        return string.Empty;

#endif

        }
    }
}