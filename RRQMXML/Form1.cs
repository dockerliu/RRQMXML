using RRQMXml;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RRQMXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlTool xml = new XmlTool("App.xml");

        /// <summary>
        /// 测试生成Xml按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testGenerateXmlBtn_Click(object sender, EventArgs e)
        {
            //创建方法一：节点+属性名+属性值
            //xml.AttributeStorage("student","name","张三");

            //创建方法二：节点+属性名集合+属性值集合
            //string[] attribute_names = new string[] { "姓名", "性别", "年龄", "学号" };
            //string[] attribute_values = new string[] { "张三", "男", "20", "10001" };
            //xml.AttributeStorage("stdudent1", attribute_names, attribute_values);

            //创建方法三：集合存储
            //string[] nodenames = new string[] { "student2", "student3", "student4" };
            //string[] attribute_values = new string[] { "张三2", "张三3", "张三4" };
            //string[] attribute_names = new string[] { "姓名", "姓名", "姓名" };
            //xml.AttributeStorage(nodenames, attribute_names, attribute_values);

            //创建方法四：集合存储
            string[] nodenames = new string[] { "student5", "student6", "student7", "student8", "student9", "student10" };
            string[] attribute_names = new string[] { "姓名", "性别", "年龄", "学号" };
            string[] name_values = new string[] { "张三5", "张三6", "张三7", "张三8", "张三9", "张三10" };
            string[] gender_values = new string[] { "男", "男", "男", "女", "男", "女" };
            string[] age_values = new string[] { "14", "16", "17", "19", "20", "21" };
            string[] sno_values = new string[] { "1002", "1003", "1004", "1005", "1006", "1007" };
            xml.AttributeStorage(nodenames, attribute_names,4, name_values, gender_values, age_values, sno_values);
            
        }

        /// <summary>
        /// 读取XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testReadXmlBtn_Click(object sender, EventArgs e)
        {
            //读取XML方法一：节点名+属性名取值
            //string value = xml.SearchWords("student5", "姓名");
            //txtXML.AppendText(value + "\r\n");

            //读取XML方法二：已知属性名，属性值，然后获取其他属性值
            string[] values = xml.SearchWords("姓名", "张三", "学号");
            foreach (string  item in values)
            {
                txtXML.AppendText(item);
            }

            
        }

        void ExistXML()
        {
            xml.NodeExist("Node");//判断节点是否存在
            xml.RemoveAllNode();//移除所有节点
            xml.RemoveNode("nodeName");
            xml.RemoveNode("AttributeName", DateTime.Now);//按时间删除当前时间以前的节点
            xml.RemoveNode("AttributeName", "AttributeValue");//按属性名称，属性值 
            Dictionary<string, string> keyValuePairs = xml.SearchAllAttributes("nodeName");//查找节点所有的属性，返回一个键值对
            


        }
    }
}
