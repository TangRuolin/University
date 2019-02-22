using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Game
{
    public class BloodPanel : MonoBehaviour
    {

        public Image bar;
        public Text num;
        [HideInInspector]
        public AICtr aiCtr;
        //private float nowBlood;
        //private float fullBlood;
        // Use this for initialization
        private float time;
        public void Init()
        {
            time = 0;
            bar.fillAmount = aiCtr.blood / aiCtr.fullBlood;
            num.text = aiCtr.blood.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            time += Time.deltaTime;
            if(time > Const.ShowBloodPanel)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}

