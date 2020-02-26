using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLitJson : MonoBehaviour
{
    public class classA
    {
        public int aInt;
        public float bFloat;
        public double cDouble;
    }

    public class classB
    {
        public string strString;
    }

    public class classC
    {
        public classA aClass;
        public classB bClass;
        public Vector2 Vector2C;
        public Vector3 vector3D;
    }
    // Start is called before the first frame update
    void Start()
    {
        classA classAInst = new classA() { aInt = 1, bFloat = 2.0f,cDouble=2383.5 };
        classB classBInst = new classB() {strString="你好！" };
        classC classCInst = new classC() { aClass =classAInst,bClass=classBInst,Vector2C=new Vector2(5,6),vector3D=new Vector3(7,8,9f)};
        string jsonClassC=JsonMapper.ToJson(classCInst);
        Debug.LogError($"序列化 jsonClassC:{jsonClassC}");
        classC classUnSeri=JsonMapper.ToObject<classC>(jsonClassC);
        Debug.LogError($"反序列化 classC classUnSeri.vector3D:{classUnSeri.vector3D}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
