using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Game
{
    public class MyCamera : MonoBehaviour
    {
        GameObject _player;//跟随对象
        private Vector3 _oldPos;//先前位置
        private Vector3 _offset;//移动的偏移值
        private Quaternion oldRo;//先前角度
       // private Vector3 oldPos;//
        //private Transform CameraPosition;
        // Use this for initialization
        void OnEnable()
        {
            _player = GameObject.Find("Player");//跟随对象赋值
            _oldPos = _player.transform.position;//记录原来的位置
            //CameraPosition = GameObject.Find("CameraPos").transform;
        }

        // Update is called once per frame
        void Update()
        {
            _offset = _player.transform.position - _oldPos;//计算移动偏移值
            _oldPos = _player.transform.position;//更新先前位置
            this.transform.position += _offset;//更新相机位置
           // CameraPosition.position += _offset;
            //this.transform.position = CameraPos.transform.position;
            //this.transform.rotation = CameraPos.transform.rotation;
             //CameraRotate();
        }
        float oldRotatePos;
        bool isRotate = false;
        Touch rotatTouch;
//        void CameraRotate()
//        {
//#if UNITY_EDITOR
//            if (Input.GetMouseButtonDown(0))
//            {
//                if (!isHitTouch(Input.mousePosition))
//                {
//                    oldRotatePos = Input.mousePosition.x;
//                    isRotate = true;
//                }

//            }
//            if (Input.GetMouseButton(0) && isRotate)
//            {
//                float newRotatePos = Input.mousePosition.x;
//                float offset = newRotatePos - oldRotatePos;
//                oldRotatePos = newRotatePos;
//                if (offset != 0)
//                {
//                    transform.RotateAround(_player.transform.position, _player.transform.up, offset);
//                }
//            }
//            if (Input.GetMouseButtonUp(0) && isRotate)
//            {
//                isRotate = false;
//                transform.rotation = CameraPosition.rotation;
//                transform.position = CameraPosition.position;
//            }



//#elif UNITY_ANDROID || UNITY_IPHONE
//            if (Input.touchCount > 0)
//            {
               
//                if (!isRotate)
//                {
//                    Debug.Log("jinlaiInputTouch");
//                    for (int i = 0; i <= Input.touchCount; i++)
//                    {
//                        Debug.Log("touches"+i+":"+Input.touches[i].position);
//                        if (!isHitTouch(Input.touches[i].position))
//                        {
//                            rotatTouch = Input.touches[i];
//                            oldRotatePos = rotatTouch.position.x;
//                            isRotate = true;
//                            Debug.Log("old:"+i);
//                            break;
//                        }
//                    }
//                }
//                if (isRotate)
//                {
//                     Debug.Log("jinlaiIsRotate"+rotatTouch.phase);
//                    if (rotatTouch.phase == TouchPhase.Moved)
//                    {
//                        Debug.Log("jinlaiIsMove");
//                        float newRotatePos = rotatTouch.position.x;
//                        float offset = newRotatePos - oldRotatePos;
//                        oldRotatePos = newRotatePos;
//                        if (offset != 0)
//                        {
//                            transform.RotateAround(_player.transform.position, _player.transform.up, offset);
//                        }
//                    }
//                    if (rotatTouch.phase == TouchPhase.Ended)
//                    {
//                        isRotate = false;
//                        transform.rotation = CameraPosition.rotation;
//                        transform.position = CameraPosition.position;

//                    }

//                }

//            }
//#endif
//        }
//        bool isHitTouch(Vector2 pos)
//        {
//            if (EventSystem.current.IsPointerOverGameObject())
//            {
//                return true;
//            }
//            return false;
//        }
   }
}

