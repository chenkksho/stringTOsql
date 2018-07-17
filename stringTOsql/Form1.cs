using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringTOsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                var source = this.sourTxt.Text;
                if(!source.Contains("sql参数：") && !source.Contains("执行sql:"))
                {
                    throw new Exception("格式不正确，请检查！");
                }
                source=source.Replace("sql参数：\n", "");
             
                string[] strArray= Regex.Split(source, "执行sql:");
                if (strArray.Count()>=2)
                {

                    strArray[1] = strArray[1].Replace("\n", "");  //win7复制过来的sql不会自动换行 需要主动把换行符去掉
                    var paramDic=cmdParam(strArray[0]);

                    if (paramDic.Count <= 0) throw new Exception("参数数量不正确，请检查！");
                    var sqlLst=cmdSql(strArray,paramDic);
                    this.sourTxt.Text = "";
                    foreach (var item in sqlLst)
                    {
                        this.sourTxt.Text += item + "\n";
                    }
                    
                }
                else
                {
                    throw new Exception("格式不正确，请检查！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private List<string> cmdSql(string[] strArray, Dictionary<string, string> paramDic)
        {
            var strResult = new List<string>();
            for (int i = 1; i < strArray.Length; i++)
            {
                var strSql = strArray[i];
                foreach (var item in paramDic)
                {
                    strSql = strSql.Replace("?" + item.Key,string.Format("'{0}'", item.Value));
                }
                strResult.Add(strSql);
            }
            return strResult;
        }

        private Dictionary<string, string> cmdParam(string str)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            str= str.TrimStart('\n').TrimEnd('\n');
            var strItems = str.Split('\n');
            foreach (var item in strItems)
            {
                var itemArray = item.Split(',');
                if (itemArray.Count() != 3) throw new Exception("参数" + itemArray[0]+"不正确，请检查！");
                var itemValueA = Regex.Split(itemArray[2], "value:", RegexOptions.IgnoreCase);
                if (itemValueA.Count() != 2) throw new Exception(itemArray[0]+"参数值不正确，请检查！");
                if(dic.Keys.Contains(itemArray[0]))
                {
                    dic[itemArray[0]] = itemValueA[1];
                }
                else
                {
                    dic.Add(itemArray[0], itemValueA[1]);
                }
               
            }
            return dic;
        }

     
    }
}
