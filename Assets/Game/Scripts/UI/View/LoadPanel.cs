using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Game
{
    public class LoadPanel : MonoBehaviour
    {
        private Image renwu;
        private Image processBar;
        private Text biaoyu;

        private AsyncOperation async;
        private IEnumerator ienum;
        private bool hasLoad;
        // Use this for initialization
        private void OnEnable()
        {
            hasLoad = false;
            time = 0;
            this.transform.Find("renwu").GetComponent<Image>().sprite = LoadCtr.Instance.GetBgImage();
            this.transform.Find("renwu").GetComponent<Image>().SetNativeSize();
            processBar = this.transform.Find("processbar").GetComponent<Image>();
            processBar.fillAmount = 0;
           this.transform.Find("tishiyu").GetComponent<Text>().text = LoadCtr.Instance.GetTick();
            if(ienum != null)
            {
                StopCoroutine(ienum);
            }
            ienum = LoadScene(LoadCtr.Instance.sceneName);
            
        }
        private void Start()
        {
            StartCoroutine(ienum);
        }
        IEnumerator LoadScene(string name)
        {
            async = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(name);
            async.allowSceneActivation = false;
            yield return async;
            //while (!async.isDone)
            //{
            //    if (async.progress < 0.9f)
            //        processBar.fillAmount = async.progress;
            //    else
            //    {
            //        //processBar.fillAmount = 1.0f;
            //        async.allowSceneActivation = true;
            //    }
                    
            //    yield return null;
            //}
            //while (async.isDone)
            //{
            //    processBar.fillAmount = async.progress;
            //}
          
        }
        float num;
        float time;
        void Update()
        {
            //if (ienum != null)
            //{

            //    ienum = null;
            //}
            //if (async == null)
            //{
            //    return;
            //}
            //num = async.progress;
            //time += Time.deltaTime * 100;
            //if (time > 100)
            //{
            //    async.allowSceneActivation = true;
            //}
            //else
            //{
            //    if (!hasLoad)
            //    {
            //        processBar.fillAmount = 1;

            //        hasLoad = true;
            //    }


            //}
            num = async.progress;

            if (async.progress >= 0.9f)
            {
                //operation.progress的值最大为0.9
                num = 1.0f;
            }

            if (num != processBar.fillAmount)
            {
                //插值运算
                processBar.fillAmount = Mathf.Lerp(processBar.fillAmount, num, Time.deltaTime * 1);
                if (Mathf.Abs(processBar.fillAmount - num) < 0.01f)
                {
                    processBar.fillAmount = num;
                }
            }

            //loadingText.text = ((int)(loadingSlider.value * 100)).ToString() + "%";

            if ((int)(processBar.fillAmount * 100) == 100)
            {
                //允许异步加载完毕后自动切换场景
                async.allowSceneActivation = true;
            }

           



        }
        IEnumerator LoadSucc()
        {
            yield return new WaitForSeconds(0.001f);
            async.allowSceneActivation = true;
        }
       

    }
}

